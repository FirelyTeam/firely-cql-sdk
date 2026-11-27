/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Scopes
{
    internal class SymbolTable : ISymbolScope
    {
        public SymbolTable(string name, ISymbolScope? parent)
        {
            Name = name;
            Parent = parent;
        }
        private Dictionary<string, IDefinitionElement> LocalSymbols { get; } = new();

        /// <summary>
        /// The libraries included in this scope, in the order they are included, which is the order a fluent call searches them.
        /// </summary>
        private List<ReferencedLibrary> LocalReferencedLibraries { get; } = new();

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
                    if (existing is IFunctionElement existingFunction)
                    {
                        // A function with the same operand types is a redefinition, not an overload.
                        if (!OverloadedFunctionDef.CanCombine(existingFunction, function))
                            return false;

                        // replace existing symbol with new overload.
                        LocalSymbols[symbol.Name] = OverloadedFunctionDef.Create(existingFunction, function);
                        return true;
                    }
                    else
                        return false;
                }
                else
                    symbol = OverloadedFunctionDef.Create(function);
            }
            if (!LocalSymbols.TryAdd(symbol.Name, symbol))
                return false;
            if (symbol is ReferencedLibrary referencedLibrary)
                LocalReferencedLibraries.Add(referencedLibrary);
            return true;
        }


        public bool TryResolveSymbol(string identifier, [NotNullWhen(true)] out IDefinitionElement? symbol)
        {
            if (LocalSymbols.TryGetValue(identifier, out symbol))
                return true;
            else if (Parent is not null && Parent.TryResolveSymbol(identifier, out symbol))
                return true;
            symbol = null;
            return false;
        }

        public bool TryResolveFunction(string identifier, [NotNullWhen(true)] out IFunctionElement? symbol)
        {
            var inLocal = LocalSymbols.TryGetValue(identifier, out var local) && local is IFunctionElement;
            IFunctionElement? parentFunction = null;
            var inParent = Parent is not null && Parent.TryResolveFunction(identifier, out parentFunction) && parentFunction is IFunctionElement;
            if (inLocal)
            {
                var localFunction = (IFunctionElement)local!;
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

        public IEnumerable<(string? LibraryName, IFunctionElement Functions)> ResolveFluentFunctionCandidates(string identifier)
        {
            // The functions of this library, together with the system functions, come first: a local overload wins
            // over one in an included library, even when the included one matches the arguments better.
            if (TryResolveFunction(identifier, out var localAndParent))
                yield return (null, localAndParent);

            foreach (var refLib in ReferencedLibraries)
            {
                // We don't call ResolveFluentFunctionCandidates because fluent functions are not resolved two libraries apart.
                // In other words,if lib A includes lib B and lib B includes C,
                // then A cannot resolve fluents in lib C.
                // If we used ResolveFluentFunctionCandidates here, we'd get that behavior.
                // So, don't.
                if (refLib.Symbols.TryResolveFunction(identifier, out var refOverload))
                {
                    // system functions will be in reference scope through their parent symbol table
                    // don't include those, as they're already in scope through this library's locals.
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
                        yield return (refLib.localIdentifier, rf);
                }
            }
        }

        public IEnumerable<ReferencedLibrary> ReferencedLibraries =>
            Parent switch
            {
                { } => LocalReferencedLibraries.Concat(Parent.ReferencedLibraries),
                _ => LocalReferencedLibraries
            };

        public IEnumerator<IDefinitionElement> GetEnumerator() => LocalSymbols.Values.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
