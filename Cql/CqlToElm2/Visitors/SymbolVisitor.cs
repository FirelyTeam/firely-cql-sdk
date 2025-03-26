using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm2.Symbols;
using Hl7.Cql.CqlToElm.Grammar.r2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hl7.Cql.Model;
using Antlr4.Runtime;
using Hl7.Cql.Model.Cql;
using Hl7.Cql.CqlToElm2.Coercion;
using Hl7.Cql.CqlToElm2.Expressions;

namespace Hl7.Cql.CqlToElm2.Visitors;
internal class SymbolVisitor : cqlBaseVisitor<Symbol>
{
    public SymbolVisitor(SymbolTable scope,
        ICqlProvider libraryProvider,
        LiteralTypeNames? literalTypeNames = null)
    {
        Scope = scope;
        CqlProvider = libraryProvider;
        LiteralTypeNames = literalTypeNames ?? LiteralTypeNames.Default;
    }

    public SymbolTable Scope { get; }
    public ICqlProvider CqlProvider { get; }
    public LiteralTypeNames LiteralTypeNames { get; }



    public override Symbol VisitCodesystemDefinition([NotNull] cqlParser.CodesystemDefinitionContext context)
    {
        var accessModifier = context.accessModifier().Parse();
        var id = context.identifier().Dequote()!;
        var uri = context.codesystemId().GetText().Detick()!;
        var version = context.versionSpecifier().Parse();

        var codeSystemType = Scope.GetUnique<TypeSymbol>(LiteralTypeNames.CodeSystem);
        if (codeSystemType is not null)
        {
            var codeSystem = new CodeSystemSymbol(id, accessModifier, uri, version, codeSystemType);
            return codeSystem;
        }
        else
        {
            var codeSystem = new CodeSystemSymbol(id, accessModifier, uri, version, AnyType)
                .WithError(ErrorType.LiteralTypeNotFound);
            return codeSystem;
        }
    }

    public override Symbol VisitCodeDefinition([NotNull] cqlParser.CodeDefinitionContext context)
    {
        var accessModifier = context.accessModifier().Parse();
        var id = context.identifier().Dequote()!;
        var code = context.codeId()?.GetText().Detick()!;
        var codeSystemId = context.codeSystemIdentifier().qualifiedIdentifier().Dequote()!;
        var display = context.displayClause()?.STRING().GetText().Detick();
        var codeType = Scope.GetUnique<TypeSymbol>(LiteralTypeNames.Code);
        var codeSystem = Scope.GetUnique<CodeSystemSymbol>(codeSystemId);

        return (codeType, codeSystem) switch
        {
            ({ }, { }) => new CodeSymbol(id, accessModifier, code, display, codeSystem, codeType),
            ({ }, null) => new CodeSymbol(id, accessModifier, code, display,
                    new CodeSystemSymbol(context.codeSystemIdentifier().qualifiedIdentifier().GetText(), AccessModifier.Public, "", new Version(1, 0, 0), AnyType), codeType)
                    .WithError(ErrorType.CodeSystemNotFound),
            (null, { }) => new CodeSymbol(id, accessModifier, code, display, codeSystem, AnyType)
                    .WithError(ErrorType.LiteralTypeNotFound),
            (null, null) => new CodeSymbol(id, accessModifier, code, display,
                    new CodeSystemSymbol(context.codeSystemIdentifier().qualifiedIdentifier().GetText(), AccessModifier.Public, "", new Version(1, 0, 0), AnyType), AnyType)
                    .WithError(ErrorType.LiteralTypeNotFound)
                    .WithError(ErrorType.CodeSystemNotFound)
        };
    }

    public override Symbol VisitConceptDefinition([NotNull] cqlParser.ConceptDefinitionContext context)
    {
        var accessModifier = context.accessModifier().Parse();
        var id = context.identifier().Dequote()!;
        var display = context.displayClause()?.STRING()?.GetText().Detick();
        var allCodesFound = true;
        var codes = new List<CodeSymbol>();
        foreach (var cid in context.codeSystemIdentifier())
        {
            var codeId = cid.qualifiedIdentifier().Dequote()!;
            var codeSymbol = Scope.GetUnique<CodeSymbol>(codeId);
            if (codeSymbol is not null)
                codes.Add(codeSymbol);
            else
                allCodesFound = false;
        }

        var conceptType = Scope.GetUnique<TypeSymbol>(LiteralTypeNames.Concept);
        return (conceptType, allCodesFound) switch
        {
            ({ }, true) => new ConceptSymbol(id, accessModifier, display, codes, conceptType),
            ({ }, false) => new ConceptSymbol(id, accessModifier, display, Array.Empty<CodeSymbol>().AsReadOnly(), conceptType)
                                .WithError(ErrorType.CodeNotFound),
            (null, true) => new ConceptSymbol(id, accessModifier, display, codes, AnyType)
                                .WithError(ErrorType.LiteralTypeNotFound),
            (null, false) => new ConceptSymbol(id, accessModifier, display, Array.Empty<CodeSymbol>().AsReadOnly(), AnyType)
                                .WithError(ErrorType.CodeNotFound)
                                .WithError(ErrorType.LiteralTypeNotFound)
        };
    }

    public override Symbol VisitConversionDefinition([NotNull] cqlParser.ConversionDefinitionContext context)
    {
        var accessModifier = context.accessModifier().Parse();
        var conversionType = context.conversionType().GetText();
        var toTypes = context.toType().typeSpecifier().Parse(Scope, Array.Empty<TypeSymbol>());
        var operandIdentifier = context.identifier().Dequote()!;
        var fromTypes = context.fromType().typeSpecifier().Parse(Scope, Array.Empty<TypeSymbol>());

        if (fromTypes.Length == 1 && toTypes.Length == 1)
        {
            var fromOperand = new OperandSymbol(operandIdentifier, fromTypes[0]);
            var functionBody = context.functionBody();
            Expression? body = null;
            if (functionBody is not null)
            {
                var functionScope = Scope.Enter("Conversion");
                functionScope.AddSymbol(fromOperand);
                var expressionVisitor = new ExpressionVisitor(functionScope, LiteralTypeNames);
                body = expressionVisitor.Visit(functionBody);
            }
            var conversionSymbol = ConversionFunctionSymbol.Implicit(fromOperand, toTypes[0], accessModifier, body)
                .WithLocation(context);
            return conversionSymbol;
        }
        else
            return ConversionFunctionSymbol.Implicit(new OperandSymbol(operandIdentifier, AnyType), AnyType, accessModifier, null)
                .WithLocation(context)
                .WithError(ErrorType.InvalidTypeSpecifier);
    }

    public override Symbol VisitExpressionDefinition([NotNull] cqlParser.ExpressionDefinitionContext context)
    {
        var name = context.identifier().Dequote();
        var accessModifier = context.accessModifier().Parse();
        var returnTypes = context.asClause()?.typeSpecifier().Parse(Scope, null);

        var expressionVisitor = new ExpressionVisitor(Scope, LiteralTypeNames);
        var expression = expressionVisitor.Visit(context.expression()) ??
            throw new NotImplementedException($"Expression type is not implemented.");

        if (returnTypes is not null && returnTypes.Length == 1)
            expression = Scope.CoercionGraph!.Coerce(expression!, returnTypes[0]);

        var symbol = new ExpressionSymbol(name!, accessModifier, expression!)
            .WithLocation(context);

        if (returnTypes is not null)
        {
            if (returnTypes.Length == 0)
                symbol = symbol.WithError(ErrorType.InvalidTypeSpecifier, context.asClause().typeSpecifier().GetText());
            else if (returnTypes.Length > 1)
                symbol = symbol.WithError(ErrorType.AmbiguousTypeSpecifier, context.asClause().typeSpecifier().GetText());
        }
        return symbol;
    }


    public override Symbol VisitFunctionDefinition([NotNull] cqlParser.FunctionDefinitionContext context)
    {
        var name = context.identifier().Dequote();
        var accessModifier = context.accessModifier().Parse();
        var isFluent = context.fluent() is not null;
        var operands = context.operandDefinition().Select(Visit).Cast<OperandSymbol>().ToArray();
        var returnTypes = context.returnClause()?.typeSpecifier().Parse(Scope, null);

        var bodyExpression = context.functionBody().expression();
        Expression? body;
        TypeSymbol returnType;
        if (bodyExpression is not null)
        {
            var functionScope = Scope.Enter(name!);
            foreach (var operand in operands)
                functionScope.AddSymbol(operand);
            var expressionVisitor = new ExpressionVisitor(functionScope, LiteralTypeNames);
            body = expressionVisitor.Visit(bodyExpression);
            returnType = body.Type;
        }
        else if (returnTypes is null || returnTypes.Length != 1)
        {
            body = null;
            returnType = AnyType;
        }
        else
        {
            body = null;
            returnType = returnTypes[0];
        }

        var symbol = isFluent switch {
            true => new FluentFunctionSymbol(name!, accessModifier, returnType!, operands, body)
                .WithLocation(context),
            false => new FunctionSymbol(name!, accessModifier, returnType!, operands, body)
                .WithLocation(context)
        };
        if (returnTypes is not null)
        {
            if (returnTypes.Length == 0)
                symbol = symbol.WithError(ErrorType.InvalidTypeSpecifier, context.returnClause().typeSpecifier().GetText());
            else if (returnTypes.Length > 1)
                symbol = symbol.WithError(ErrorType.AmbiguousTypeSpecifier, context.returnClause().typeSpecifier().GetText());
        }
        return symbol;

    }

    public override Symbol VisitIncludeDefinition([NotNull] cqlParser.IncludeDefinitionContext context)
    {
        var id = context.qualifiedIdentifier().GetText();
        var version = Version.Parse(context.versionSpecifier()?.GetText().Detick() ?? "1.0.0");
        var libs = Scope.Global.GetLocalSymbols(id)
            .Where(sym => sym.Errors.Count == 0)
            .OfType<LibrarySymbol>();

        LibrarySymbol? lib;
        if (version is not null)
            lib = libs.SingleOrDefault(lib => lib.Version == version);
        else lib = libs.OrderByDescending(ls => ls.Version).FirstOrDefault();

        if (lib is null) // lib hasn't been added to global scope yet
        {
            var cql = CqlProvider.GetCql(id, version);
            if (cql is not null)
            {
                var antlStream = new AntlrInputStream(cql.ReadToEnd());
                var lexer = new cqlLexer(antlStream);
                var parser = new cqlParser(new CommonTokenStream(lexer));
                var includeVisitor = new SymbolVisitor(Scope.Global, CqlProvider);
                var libContext = parser.library();
                lib = (LibrarySymbol)includeVisitor.Visit(libContext); // Visit adds lib to the global scope
            }
            else
            {
                var errorSymbol = new LibrarySymbol(id, version!, Scope.Enter($"{id}-{version}"))
                    .WithError(ErrorType.LibraryNotFound);
                return errorSymbol;
            }
        }
        var alias = context.localIdentifier()?.GetText();
        if (alias is not null)
            return lib.Alias(alias);
        else return lib;
    }

    public override Symbol VisitLibrary([NotNull] cqlParser.LibraryContext context)
    {
        var def = context.libraryIdentifier();
        var id = def.qualifiedIdentifier().GetText();
        var version = Version.Parse(def.versionSpecifier()?.GetText().Detick() ?? "1.0.0");
        // create a new Library symbol for this library
        var library = new LibrarySymbol(id, version!, Scope.Enter($"{id}-{version}"));
        // add this library to the parent scope
        Scope.AddSymbol(library);

        // libraries can define types, so need their own coercion graph.
        library.Symbols.LocalCoercionGraph = new();
        // create a new visitor for library scope
        var libraryVisitor = new SymbolVisitor(library.Symbols, CqlProvider);

        // visit definitions.
        // using models first; we will need model types to resolve types used in other definitions
        foreach (var definition in context.libraryDefinition())
        {
            var @using = definition.usingDefinition();
            if (@using is not null)
            {
                var usingSymbol = (ModelSymbol)libraryVisitor.Visit(@using);
                var existing = library.Symbols.GetLocalUnique<ModelSymbol>(usingSymbol.Name);
                if (existing is not null)
                    usingSymbol.WithError(ErrorType.SymbolRedefinition);
                library.Symbols.AddSymbol(usingSymbol);
                // merge the model's coercion graphs into this library's
                library.Symbols.CoercionGraph!.Merge(usingSymbol.Symbols.CoercionGraph);
            }
        }

        // visit includes and code systems
        foreach (var definition in context.libraryDefinition())
        {
            var include = definition.includeDefinition();
            if (include is not null)
            {
                var librarySymbol = (LibrarySymbol)libraryVisitor.Visit(include);
                if (library.Symbols.GetLocalUnique(librarySymbol.Name) is not null)
                {
                    // we need to clone the symbol to avoid modifying the original symbol
                    var errorSymbol = new LibrarySymbol(librarySymbol.Name, librarySymbol.Version, librarySymbol.Symbols)
                        .WithError(ErrorType.SymbolRedefinition);
                    library.Symbols.AddSymbol(errorSymbol);
                    // merge the library's coercion graphs into this library's
                    library.Symbols.CoercionGraph!.Merge(librarySymbol.Symbols.CoercionGraph);

                }
                else
                {
                    library.Symbols.AddSymbol(librarySymbol);
                }
                continue;
            }
            var codeSystem = definition.codesystemDefinition();
            if (codeSystem is not null)
            {
                var symbol = (CodeSystemSymbol)libraryVisitor.Visit(codeSystem);
                if (library.Symbols.GetLocalUnique(symbol.Name) is not null)
                {
                    // we need to clone the symbol to avoid modifying the original symbol
                    var errorSymbol = new CodeSystemSymbol(symbol.Name, symbol.AccessModifier, symbol.Uri, symbol.Version, symbol.Type)
                        .WithError(ErrorType.SymbolRedefinition);
                    library.Symbols.AddSymbol(errorSymbol);
                }
                else
                {
                    library.Symbols.AddSymbol(symbol);
                }
                continue;
            }
        }

        // visit valuesets and codes.  codesystems must already be defined for these.
        foreach (var definition in context.libraryDefinition())
        {
            var code = definition.codeDefinition();
            if (code is not null)
            {
                var symbol = (CodeSymbol)libraryVisitor.Visit(code);
                if (library.Symbols.GetLocalUnique(symbol.Name) is not null)
                {
                    // we need to clone the symbol to avoid modifying the original symbol
                    var errorSymbol = new CodeSymbol(symbol.Name, symbol.AccessModifier, symbol.Code, symbol.Display, symbol.CodeSystem, symbol.Type)
                        .WithError(ErrorType.SymbolRedefinition);
                    library.Symbols.AddSymbol(errorSymbol);
                }
                else
                {
                    library.Symbols.AddSymbol(symbol);
                }
                continue;
            }
            var valueSet = definition.valuesetDefinition();
            if (valueSet is not null)
            {
                var symbol = (ValueSetSymbol)libraryVisitor.Visit(valueSet);
                if (library.Symbols.GetLocalUnique(symbol.Name) is not null)
                {
                    // we need to clone the symbol to avoid modifying the original symbol
                    var errorSymbol = new ValueSetSymbol(symbol.Name, symbol.AccessModifier, symbol.Uri, symbol.Version, symbol.CodeSystems, symbol.Type)
                        .WithError(ErrorType.SymbolRedefinition);
                    library.Symbols.AddSymbol(errorSymbol);
                }
                else
                {
                    library.Symbols.AddSymbol(symbol);
                }
                continue;
            }
        }

        // visit concepts.  codes must already be defined for these.
        foreach (var definition in context.libraryDefinition())
        {
            var concept = definition.conceptDefinition();
            if (concept is not null)
            {
                var symbol = (ConceptSymbol)libraryVisitor.Visit(concept);
                if (library.Symbols.GetLocalUnique(symbol.Name) is not null)
                {
                    // we need to clone the symbol to avoid modifying the original symbol
                    var errorSymbol = new ConceptSymbol(symbol.Name, symbol.AccessModifier, symbol.Display, symbol.Codes, symbol.Type)
                        .WithError(ErrorType.SymbolRedefinition);
                    library.Symbols.AddSymbol(errorSymbol);
                }
                else
                {
                    library.Symbols.AddSymbol(symbol);
                }
                continue;
            }
        }

        // After all coercion graphs have been merged, compute all paths.
        library.Symbols.CoercionGraph!.ComputeCoercionPaths();

        var statementVisitor = new SymbolVisitor(library.Symbols, CqlProvider, LiteralTypeNames);
        foreach (var statement in context.libraryStatement())
        {
            var symbol = statementVisitor.Visit(statement);
            library.Symbols.AddSymbol(symbol);
            // don't add error symbols to the coercion graph
            if (symbol.HasErrors == false)
            {
                switch (symbol)
                {
                    case ConversionFunctionSymbol conversion when conversion.IsImplicit is true:
                        library.Symbols.CoercionGraph!.AddImplicitConversion(conversion);
                        // recompute coercion paths
                        library.Symbols.CoercionGraph!.ComputeCoercionPaths();
                        break;
                    case ConversionFunctionSymbol conversion when conversion.IsImplicit is false:
                        library.Symbols.CoercionGraph!.AddExplicitConversion(conversion);
                        library.Symbols.CoercionGraph!.ComputeCoercionPaths();
                        break;
                    default:
                        break;
                }
            }
        }

        return library;
    }

    public override Symbol VisitModel([NotNull] cqlParser.ModelContext context)
    {
        var def = context.modelIdentifier();
        var id = def.qualifiedIdentifier().GetText();
        var version = def.versionSpecifier().GetText().Detick() ?? "1.0.0";
        var uri = def.modelUri().GetText().Detick()!;

        var modelSymbol = new ModelSymbol(new ModelDefinition(id, version!, uri), id, Scope.Enter(uri));
        Scope.AddSymbol(modelSymbol);

        // the model scope 
        modelSymbol.Symbols.LocalCoercionGraph = new();

        var modelVisitor = new SymbolVisitor(modelSymbol.Symbols, CqlProvider);

        // visit definitions.
        // using models first; we will need model types to resolve types used in other definitions
        foreach (var definition in context.modelDefinition())
        {
            var @using = definition.usingDefinition();
            if (@using is not null)
            {
                var usingSymbol = (ModelSymbol)modelVisitor.Visit(@using);
                var existing = modelSymbol.Symbols.GetLocalUnique<ModelSymbol>(usingSymbol.Name);
                if (existing is not null)
                    usingSymbol.WithError(ErrorType.SymbolRedefinition);
                modelSymbol.Symbols.AddSymbol(usingSymbol);
                modelSymbol.Symbols.CoercionGraph!.Merge(usingSymbol.Symbols.CoercionGraph);
            }
        }

        var typeVisitor = new TypeVisitor(modelSymbol.Model);
        var typeDefContexts = context.modelDefinition()
            .Select(def => def.typeDefinition())
            .Where(d => d is not null)
            .ToArray();
        typeVisitor.ParseTypeDefinitions(typeDefContexts);

        foreach (var type in modelSymbol.Model.TypeDefinitions)
        {
            var typeSymbol = new TypeSymbol(type.Value);
            modelSymbol.Symbols.AddSymbol(typeSymbol);
            modelSymbol.Symbols.CoercionGraph!.AddType(typeSymbol);
        }
        // compute coercion paths for type definitions
        modelSymbol.Symbols.CoercionGraph!.ComputeCoercionPaths();


        var statementVisitor = new SymbolVisitor(modelSymbol.Symbols, CqlProvider, LiteralTypeNames);
        foreach (var statement in context.modelStatement())
        {
            var symbol = statementVisitor.Visit(statement);
            modelSymbol.Symbols.AddSymbol(symbol);
            // don't add error symbols to the coercion graph
            if (symbol.HasErrors == false)
            {
                switch (symbol)
                {
                    case ConversionFunctionSymbol conversion when conversion.IsImplicit is true:
                        modelSymbol.Symbols.CoercionGraph.AddImplicitConversion(conversion);
                        // recompute coercion paths
                        modelSymbol.Symbols.CoercionGraph.ComputeCoercionPaths();
                        break;
                    case ConversionFunctionSymbol conversion when conversion.IsImplicit is false:
                        modelSymbol.Symbols.CoercionGraph.AddExplicitConversion(conversion);
                        modelSymbol.Symbols.CoercionGraph.ComputeCoercionPaths();
                        break;
                    default:
                        break;
                }
            }
        }

        return modelSymbol;
    }

    public override Symbol VisitOperatorDefinition([NotNull] cqlParser.OperatorDefinitionContext context)
    {
        var accessModifier = context.accessModifier().Parse();
        var op = context.overloadableOperator();
        var operands = context.operandDefinition().Select(Visit).Cast<OperandSymbol>().ToArray();
        var returnTypes = context.returnClause()?.typeSpecifier().Parse(Scope, null);

        var functionName = op switch
        {
            var _ when op.binaryOperator() is not null => FormatOperatorFunctionName(op.binaryOperator()),
            _ => null
        };
        if (functionName is not null)
        {
            TypeSymbol returnType;
            Expression? body;
            var bodyContext = context.functionBody().expression();
            if (bodyContext is not null)
            {
                var functionScope = Scope.Enter(functionName);
                foreach (var operand in operands)
                    functionScope.AddSymbol(operand);
                var expressionVisitor = new ExpressionVisitor(functionScope, LiteralTypeNames);
                body = expressionVisitor.Visit(bodyContext);
                returnType = body.Type;
            }
            else if (returnTypes is null || returnTypes.Length != 0)
            {
                returnType = AnyType;
                body = null;
            }
            else
            {
                returnType = returnTypes[0];
                body = null;
            }

            var symbol = new FunctionSymbol(functionName, accessModifier, returnType!, operands, body)
                .WithLocation(context);
            if (returnTypes is not null)
            {
                if (returnTypes.Length == 0)
                    symbol = symbol.WithError(ErrorType.InvalidTypeSpecifier, context.returnClause().typeSpecifier().GetText());
                else if (returnTypes.Length > 1)
                    symbol = symbol.WithError(ErrorType.AmbiguousTypeSpecifier, context.returnClause().typeSpecifier().GetText());
            }
            return symbol;
        }
        else throw new InvalidOperationException($"Unknown operator: {op.GetText()}");
    }

    public override Symbol VisitOperandDefinition([NotNull] cqlParser.OperandDefinitionContext context)
    {
        var name = context.identifier().Dequote()!;
        var type = context.typeSpecifier().Parse(Scope, null);
        
        if (type.Length == 1)
            return new OperandSymbol(name, type[0])
                .WithLocation(context);
        else if (type.Length == 0)
            return new OperandSymbol(name, AnyType)
                .WithLocation(context)
                .WithError(ErrorType.InvalidTypeSpecifier, context.typeSpecifier().GetText());
        else 
            return new OperandSymbol(name, AnyType)
                .WithLocation(context)
                .WithError(ErrorType.AmbiguousTypeSpecifier, context.typeSpecifier().GetText());
    }

    public override Symbol VisitUsingDefinition([NotNull] cqlParser.UsingDefinitionContext context)
    {
        var id = context.qualifiedIdentifier().GetText();
        var versionString = context.versionSpecifier()?.GetText().Detick();
        var alias = context.localIdentifier()?.GetText() ?? id;
        var modelCql = CqlProvider.GetCql(id, Version.Parse(versionString ?? "1.0.0"));
        if (modelCql is not null)
        {
            var antlStream = new AntlrInputStream(modelCql.ReadToEnd());
            var lexer = new cqlLexer(antlStream);
            var parser = new cqlParser(new CommonTokenStream(lexer));
            var includeVisitor = new SymbolVisitor(Scope.Global, CqlProvider);
            var modelcontext = parser.model();
            if (modelcontext is not null)
            {
                var modelVisitor = new SymbolVisitor(Scope.Global, CqlProvider);
                var modelSymbol = (ModelSymbol)modelVisitor.Visit(modelcontext);
                if (alias is not null)
                    return modelSymbol.Alias(alias);
                else return modelSymbol;

            }
        }
        return new ModelSymbol(null!, alias, Scope.Enter(id))
            .WithLocation(context)
            .WithError(ErrorType.ModelNotFound);
    }


    public override Symbol VisitValuesetDefinition([NotNull] cqlParser.ValuesetDefinitionContext context)
    {
        var accessModifier = context.accessModifier().Parse();
        var id = context.identifier().Dequote()!;
        var uri = context.valuesetId().GetText().Detick()!;
        var version = context.versionSpecifier().Parse();
        var codeSystemIds = context.codesystems()?.qualifiedIdentifier();
        var codeSystems = new List<CodeSystemSymbol>();
        var allCodeSystemsFound = true;
        if (codeSystemIds is not null)
        {
            foreach (var csId in codeSystemIds)
            {
                var codeSystemId = csId.Dequote()!;
                var codeSystem = Scope.GetUnique<CodeSystemSymbol>(codeSystemId);
                if (codeSystem is not null)
                    codeSystems.Add(codeSystem);
                else
                    allCodeSystemsFound = false;
            }
        }

        var valueSetType = Scope.GetUnique<TypeSymbol>(LiteralTypeNames.ValueSet);
        return (valueSetType, allCodeSystemsFound) switch
        {
            ({ }, true) => new ValueSetSymbol(id, accessModifier, uri, version, codeSystems, valueSetType),
            ({ }, false) => new ValueSetSymbol(id, accessModifier, uri, version, Array.Empty<CodeSystemSymbol>().AsReadOnly(), valueSetType)
                                .WithError(ErrorType.CodeSystemNotFound),
            (null, true) => new ValueSetSymbol(id, accessModifier, uri, version, codeSystems, AnyType)
                                .WithError(ErrorType.LiteralTypeNotFound),

            (null, false) => new ValueSetSymbol(id, accessModifier, uri, version, Array.Empty<CodeSystemSymbol>().AsReadOnly(), AnyType)
                                .WithError(ErrorType.CodeSystemNotFound)
                                .WithError(ErrorType.LiteralTypeNotFound),
        };
    }


    internal static string FormatOperatorFunctionName(cqlParser.BinaryOperatorContext context) =>
        context switch
        {
            cqlParser.AndOperatorContext => "$(operator and)",
            cqlParser.OrOperatorContext => "$(operator or)",
            _ => $"$(operator{context.GetText()})"
        };

    /// <summary>
    /// Gets the type defined by <see cref="LiteralTypeNames.Any"/>, or throws an <see cref="InvalidOperationException"/> if not found.
    /// </summary>
    private TypeSymbol AnyType => Scope.GetUnique<TypeSymbol>(LiteralTypeNames.Any) ??
        throw new InvalidOperationException($"Type {LiteralTypeNames.Any} has not been loaded in any model.");
}
