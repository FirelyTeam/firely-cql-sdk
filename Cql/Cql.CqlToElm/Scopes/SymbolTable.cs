using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Scopes
{
    internal class SymbolTable : ISymbolScope
    {
        public SymbolTable(string name, ISymbolScope? parent)
        {
            Name = name;
            Parent = parent;
        }
        private class ScopeElement
        {
            public IExpressionElement? expression;
            public IFunctionElement? function;
            public IDefinitionElement? other;
        }
        private Dictionary<string, ScopeElement> LocalSymbols { get; } = new();

        public string Name { get; }

        public ISymbolScope? Parent { get; }

        public ISymbolScope EnterScope(string name) {
            //System.Diagnostics.Debug.WriteLine($"Entering scope {name}");
            return new SymbolTable(name, this);
        }
        public void Dispose() { } // do nothing


        public bool TryAdd(IDefinitionElement symbol)
        {
            if (symbol is IFunctionElement function)
            {
                if (LocalSymbols.TryGetValue(symbol.Name, out var existing))
                {
                    if (existing.function is not null)
                    {
                        // replace existing symbol with new overload.
                        if (OverloadedFunctionDef.CanCombine(existing.function, function))
                        {
                            existing.function = OverloadedFunctionDef.Create(existing.function, function);
                            return true;
                        }
                        else
                            return false;
                    }
                    else
                    {
                        existing.function = function;
                        return true;
                    }
                        
                }
                else
                    symbol = OverloadedFunctionDef.Create(function);
            }
            else if (LocalSymbols.TryGetValue(symbol.Name, out var existing))
            {
                if (symbol is IExpressionElement ed && existing.expression is null)
                {
                    existing.expression = ed;
                    return true;
                }
                else if (existing.other is not null)
                {
                    existing.other = symbol;
                    return true;
                }
                else return false;
            }
            return LocalSymbols.TryAdd(symbol.Name, symbol switch
            {
                IFunctionElement f => new ScopeElement { function = f },
                IExpressionElement e => new ScopeElement { expression = e },
                _ => new ScopeElement { other = symbol }
            });
        }


        public bool TryResolveSymbol(string identifier, [NotNullWhen(true)] out IDefinitionElement? element)
        {
            if (LocalSymbols.TryGetValue(identifier, out var symbol)) {
                element = symbol.expression ?? symbol.other ?? symbol.function;
                return element is not null;
            }
            else if (Parent is not null && Parent.TryResolveSymbol(identifier, out element))
                return true;
            element = null;
            return false;
        }

        public bool TryResolveFunction(string identifier, [NotNullWhen(true)] out IFunctionElement? symbol)
        {
            var inLocal = LocalSymbols.TryGetValue(identifier, out var local) && local.function is not null;
            IFunctionElement? parentFunction = null;
            var inParent = Parent is not null && Parent.TryResolveFunction(identifier, out parentFunction) && parentFunction is IFunctionElement;
            if (inLocal)
            {
                var localFunction = local!.function!;
                if (inParent)
                {
                    // start with parent functions (most often, this will be the system lib).
                    // if any locals have the same signature as a parent function, use the local
                    // this allows for things like a local overload of Add(Integer,Integer)
                    // to take precedence over the system operator when called using function syntax.
                    var allLocals = localFunction switch
                    {
                        OverloadedFunctionDef ol => ol.Functions,
                        FunctionDef f => new[] { f },
                        DeferredFunctionDef d => new[] { d.Resolve() },
                        _ => throw new InvalidOperationException("Expecting a function type")
                    };
                    var allParents = parentFunction switch
                    {
                        OverloadedFunctionDef ol => ol.Functions,
                        FunctionDef f => new[] { f },
                        DeferredFunctionDef d => new[] { d.Resolve() },
                        _ => throw new InvalidOperationException("Expecting a function type")
                    };
                    var merged = new List<IHasSignature>(allParents);
                    for (int i = 0; i < merged.Count; i++)
                    {
                        var currentOperands = merged[i]
                            .Operands
                            .Select(op => op.operandTypeSpecifier);
                        for (int j = 0; j < allLocals.Count; j++)
                        {
                            var localOperands = allLocals[j].Operands
                                .Select(op => op.operandTypeSpecifier);
                            if (localOperands.SequenceEqual(currentOperands))
                                merged[i] = allLocals[j];
                        }
                    }
                    // if there are new local overloads introduced, add them.
                    for (int i = 0; i < allLocals.Count; i++)
                    {
                        var l = allLocals[i];
                        var operand = l.Operands;
                        var currentOperands = operand.Select(op => op.operandTypeSpecifier);
                        if (!merged.Any(m => currentOperands.SequenceEqual(m.Operands.Select(op => op.operandTypeSpecifier))))
                            merged.Add(l);
                    }
                    symbol = OverloadedFunctionDef.Create(merged.ToArray());
                    return true;
                }
                else
                {
                    symbol = localFunction;
                    return true;
                }
            }
            else if (inParent)
            {
                symbol = parentFunction!;
                return true;
            }
            else
            {
                symbol = null;
                return false;
            }
        }

        public bool TryResolveFluentFunction(string identifier, [NotNullWhen(true)] out IFunctionElement[]? symbols)
        {
            var inLocalAndParent = TryResolveFunction(identifier, out var localAndParent);
            // list would suffice, but dictionary better for debugging.
            // may need later.
            var fromReferences = new Dictionary<VersionedIdentifier, IFunctionElement>();
            foreach (var refLib in ReferencedLibraries)
            {
                // We don't call TryResolveFleunt because fluent functions are not resolved two libraries apart.
                // In other words,if lib A includes lib B and lib B includes C,
                // then A cannot resolve fluents in lib C.
                // If we used TryResolveFluentFunction here, we'd get that behavior.
                // So, don't.
                if (refLib.Symbols.TryResolveFunction(identifier, out var refOverload))
                {
                    IFunctionElement? rf = null;
                    if (refOverload is OverloadedFunctionDef ov)
                    {
                        var nonSystemFunctions = ov.Functions.Where(f => f is not SystemFunction)
                            .ToArray();
                        if (nonSystemFunctions.Length > 0)
                        {
                            rf = OverloadedFunctionDef.Create(nonSystemFunctions);
                        }
                    }
                    else if (refOverload is not SystemFunction)
                    {
                        rf = refOverload;
                    }
                    if (rf is not null)
                        fromReferences.Add(refLib.Id, rf!);
                }
            }
            if (inLocalAndParent)
            {
                if (fromReferences.Count > 0)
                {

                    var allLocals = localAndParent switch
                    {
                        OverloadedFunctionDef ol => ol.Functions,
                        FunctionDef f => new[] { f },
                        DeferredFunctionDef d => new[] { d.Resolve() },
                        _ => throw new InvalidOperationException("Expecting a function type")
                    };
                    // system functions will be in reference scope through their parent symbol table
                    // don't include those, as they're already in scope through this library's locals.
                    var functionsInRefScope = fromReferences.Values
                        .SelectMany(fe => fe switch
                    {
                        OverloadedFunctionDef ol => ol.Functions,
                        FunctionDef f => new[] { f },
                        DeferredFunctionDef d => new[] { d.Resolve() },
                        _ => throw new InvalidOperationException("Expecting a function type")
                    });
                    var merged = new List<IHasSignature>(functionsInRefScope);
                    for (int i = 0; i < merged.Count; i++)
                    {
                        var currentOperands = merged[i].Operands.Select(op => op.operandTypeSpecifier);
                        for (int j = 0; j < allLocals.Count; j++)
                        {
                            var localOperands = allLocals[j].Operands.Select(op => op.operandTypeSpecifier);
                            if (localOperands.SequenceEqual(currentOperands))
                                merged[i] = allLocals[j];
                        }
                    }
                    // if there are new local overloads introduced, add them.
                    for (int i = 0; i < allLocals.Count; i++)
                    {
                        var l = allLocals[i];
                        var currentOperands = l.Operands.Select(op => op.operandTypeSpecifier);
                        if (!merged.Any(m => currentOperands.SequenceEqual(m.Operands.Select(op => op.operandTypeSpecifier))))
                            merged.Add(l);
                    }
                    var mergedArray = merged.ToArray();
                    if (OverloadedFunctionDef.CanCombine(mergedArray))
                    {
                        symbols = [OverloadedFunctionDef.Create(mergedArray)];
                        return true;
                    }
                    else
                    {
                        symbols = mergedArray;
                        return false;
                    }
                }
                else
                {
                    if (localAndParent is not null)
                    {
                        symbols = [localAndParent];
                        return true;
                    }
                    else
                    {
                        symbols = null;
                        return false;
                    }
                }
            }
            else if (fromReferences.Count > 0)
            {
                var functionsInRefScope = fromReferences.Values.SelectMany(fe => fe switch
                {
                    OverloadedFunctionDef ol => ol.Functions,
                    FunctionDef f => new[] { f },
                    DeferredFunctionDef dfd => new[] { dfd.Resolve() },
                    _ => throw new InvalidOperationException("Expecting a function type")
                }).ToArray();
                if (OverloadedFunctionDef.CanCombine(functionsInRefScope))
                {
                    symbols = [OverloadedFunctionDef.Create(functionsInRefScope)];
                    return true;
                }
                else
                {
                    symbols = functionsInRefScope;
                    return false;
                }
            }
            else
            {
                symbols = null;
                return false;
            }
        }

        public IEnumerable<ReferencedLibrary> ReferencedLibraries =>
            Parent switch
            {
                { } => LocalSymbols.Values
                    .Select(s=> s.other)
                    .OfType<ReferencedLibrary>()
                    .Concat(Parent.ReferencedLibraries),
                _ => LocalSymbols.Values
                    .Select(s => s.other)
                    .OfType<ReferencedLibrary>()
            };

        public IEnumerator<IDefinitionElement> GetEnumerator() => LocalSymbols.Values
            .SelectMany(symbol =>
                new IDefinitionElement[] { symbol.expression!, symbol.function!, symbol.other! }
                .Where(s=>s is not null))
            .GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
