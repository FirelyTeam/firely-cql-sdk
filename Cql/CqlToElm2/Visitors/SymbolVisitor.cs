using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm2.Symbols;
using Hl7.Cql.CqlToElm.Grammar.r2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hl7.Cql.Model;
using System.Runtime.CompilerServices;
using Antlr4.Runtime;

namespace Hl7.Cql.CqlToElm2.Visitors;
internal class SymbolVisitor : cqlBaseVisitor<Symbol>
{
    public SymbolVisitor(SymbolTable scope,
        IModelProvider modelProvider,
        ILibraryProvider libraryProvider,
        LiteralTypeNames? literalTypeNames = null)
    {
        Scope = scope;
        ModelProvider = modelProvider;
        LibraryProvider = libraryProvider;
        LiteralTypeNames = literalTypeNames ?? new();
    }

    public SymbolTable Scope { get; }
    public IModelProvider ModelProvider { get; }
    public ILibraryProvider LibraryProvider { get; }
    public LiteralTypeNames LiteralTypeNames { get; }

    public override Symbol VisitLibrary([NotNull] cqlParser.LibraryContext context)
    {
        var def = context.libraryDefinition();
        var id = def.qualifiedIdentifier().GetText();
        var version = Version.Parse(def.versionSpecifier()?.GetText().Detick() ?? "1.0.0");
        var libraryScope = Scope.Enter(version switch
        {
            null => id,
            _ => $"{id}-{version}"
        });
        // create a new Library symbol for this library
        var library = new LibrarySymbol(id, version!, libraryScope);
        // add this library to the parent scope
        Scope.AddSymbol(library);
        // create a new visitor for library scope

        var libraryVisitor = new SymbolVisitor(libraryScope, ModelProvider, LibraryProvider);

        // visit definitions.
        // using models first; we will need model types to resolve types used in other definitions
        foreach (var definition in context.libraryDefinitions())
        {
            var @using = definition.usingDefinition();
            if (@using is not null)
            {
                var symbol = libraryVisitor.Visit(@using);
                var existing = libraryScope.GetLocalUnique<ModelSymbol>(symbol.Name);
                if (existing is not null)
                    symbol.WithError(ErrorType.SymbolRedefinition);
                libraryScope.AddSymbol(symbol);
            }
        }

        // visit includes and code systems
        foreach (var definition in context.libraryDefinitions())
        {
            var include = definition.includeDefinition();
            if (include is not null)
            {
                var symbol = (LibrarySymbol)libraryVisitor.Visit(include);
                if (libraryScope.GetLocalUnique(symbol.Name) is not null)
                {
                    // we need to clone the symbol to avoid modifying the original symbol
                    var errorSymbol = new LibrarySymbol(symbol.Name, symbol.Version, symbol.Symbols)
                        .WithError(ErrorType.SymbolRedefinition);
                    libraryScope.AddSymbol(errorSymbol);
                }
                else
                {
                    libraryScope.AddSymbol(symbol);
                }
                continue;
            }
            var codeSystem = definition.codesystemDefinition();
            if (codeSystem is not null)
            {
                var symbol = (CodeSystemSymbol)libraryVisitor.Visit(codeSystem);
                if (libraryScope.GetLocalUnique(symbol.Name) is not null)
                {
                    // we need to clone the symbol to avoid modifying the original symbol
                    var errorSymbol = new CodeSystemSymbol(symbol.Name, symbol.AccessModifier, symbol.Uri, symbol.Version, symbol.Type)
                        .WithError(ErrorType.SymbolRedefinition);
                    libraryScope.AddSymbol(errorSymbol);
                }
                else
                {
                    libraryScope.AddSymbol(symbol);
                }
                continue;
            }
        }

        // visit valuesets and codes.  codesystems must already be defined for these.
        foreach (var definition in context.libraryDefinitions())
        {
            var code = definition.codeDefinition();
            if (code is not null)
            {
                var symbol = (CodeSymbol)libraryVisitor.Visit(code);
                if (libraryScope.GetLocalUnique(symbol.Name) is not null)
                {
                    // we need to clone the symbol to avoid modifying the original symbol
                    var errorSymbol = new CodeSymbol(symbol.Name, symbol.AccessModifier, symbol.Code, symbol.Display, symbol.CodeSystem, symbol.Type)
                        .WithError(ErrorType.SymbolRedefinition);
                    libraryScope.AddSymbol(errorSymbol);
                }
                else
                {
                    libraryScope.AddSymbol(symbol);
                }
                continue;
            }
            var valueSet = definition.valuesetDefinition();
            if (valueSet is not null)
            {
                var symbol = (ValueSetSymbol)libraryVisitor.Visit(valueSet);
                if (libraryScope.GetLocalUnique(symbol.Name) is not null)
                {
                    // we need to clone the symbol to avoid modifying the original symbol
                    var errorSymbol = new ValueSetSymbol(symbol.Name, symbol.AccessModifier, symbol.Uri, symbol.Version, symbol.CodeSystems, symbol.Type)
                        .WithError(ErrorType.SymbolRedefinition);
                    libraryScope.AddSymbol(errorSymbol);
                }
                else
                {
                    libraryScope.AddSymbol(symbol);
                }
                continue;
            }
        }

        // visit concepts.  codes must already be defined for these.
        foreach (var definition in context.libraryDefinitions())
        {
            var concept = definition.conceptDefinition();
            if (concept is not null)
            {
                var symbol = (ConceptSymbol)libraryVisitor.Visit(concept);
                if (libraryScope.GetLocalUnique(symbol.Name) is not null)
                {
                    // we need to clone the symbol to avoid modifying the original symbol
                    var errorSymbol = new ConceptSymbol(symbol.Name, symbol.AccessModifier, symbol.Display, symbol.Codes, symbol.Type)
                        .WithError(ErrorType.SymbolRedefinition);
                    libraryScope.AddSymbol(errorSymbol);
                }
                else
                {
                    libraryScope.AddSymbol(symbol);
                }
                continue;
            }
        }

        return library;
    }

    public override Symbol VisitUsingDefinition([NotNull] cqlParser.UsingDefinitionContext context)
    {
        var id = context.qualifiedIdentifier().GetText();
        var version = context.versionSpecifier()?.GetText().Detick();
        var alias = context.localIdentifier()?.GetText() ?? id;
        if (ModelProvider.TryGetModel(id, version, out var model))
            return new ModelSymbol(model, alias);
        else return new ModelSymbol(null!, alias).WithError(ErrorType.ModelNotFound);
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
            var cql = LibraryProvider.GetLibraryCql(id, version);
            if (cql is not null)
            {
                var antlStream = new AntlrInputStream(cql.ReadToEnd());
                var lexer = new cqlLexer(antlStream);
                var parser = new cqlParser(new CommonTokenStream(lexer));
                var includeVisitor = new SymbolVisitor(Scope.Global, ModelProvider, LibraryProvider);
                var libContext = parser.library();
                lib = (LibrarySymbol)includeVisitor.Visit(libContext); // Visit adds lib to the global scope
            }
            else
            {
                var errorSymbol = new LibrarySymbol(id, version!, Scope.Global.Enter(id))
                    .WithError(ErrorType.LibraryNotFound);
                return errorSymbol;
            }
        }
        var alias = context.localIdentifier()?.GetText();
        if (alias is not null)
            return lib.Alias(alias);
        else return lib;
    }

    public override Symbol VisitCodesystemDefinition([NotNull] cqlParser.CodesystemDefinitionContext context)
    {
        var accessModifier = context.accessModifier().Parse();
        var id = context.identifier().GetText().Dequote()!;
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
        var id = context.identifier().GetText().Dequote()!;
        var code = context.codeId()?.GetText().Detick()!;
        var codeSystemId = context.codesystemIdentifier().GetText().Dequote()!;
        var display = context.displayClause()?.STRING().GetText().Detick();

        var codeType = Scope.GetUnique<TypeSymbol>(LiteralTypeNames.Code);
        var codeSystem = Scope.GetUnique<CodeSystemSymbol>(codeSystemId);

        return (codeType, codeSystem) switch
        {
            ({ }, { }) => new CodeSymbol(id, accessModifier, code, display, codeSystem, codeType),
            ({ }, null) => new CodeSymbol(id, accessModifier, code, display,
                    new CodeSystemSymbol(codeSystemId, AccessModifier.Public, "", new Version(1, 0, 0), AnyType), codeType)
                    .WithError(ErrorType.CodeSystemNotFound),
            (null, { }) => new CodeSymbol(id, accessModifier, code, display, codeSystem, AnyType)
                    .WithError(ErrorType.LiteralTypeNotFound),
            (null, null) => new CodeSymbol(id, accessModifier, code, display,
                    new CodeSystemSymbol(codeSystemId, AccessModifier.Public, "", new Version(1, 0, 0), AnyType), AnyType)
                    .WithError(ErrorType.LiteralTypeNotFound)
                    .WithError(ErrorType.CodeSystemNotFound)
        };
    }

    public override Symbol VisitValuesetDefinition([NotNull] cqlParser.ValuesetDefinitionContext context)
    {
        var accessModifier = context.accessModifier().Parse();
        var id = context.identifier().GetText().Dequote()!;
        var uri = context.valuesetId().GetText().Detick()!;
        var version = context.versionSpecifier().Parse();
        var codeSystemIds = context.codesystems()?.codesystemIdentifier();
        var codeSystems = new List<CodeSystemSymbol>();
        var allCodeSystemsFound = true;
        if (codeSystemIds is not null)
        {
            foreach (var csId in codeSystemIds)
            {
                var idString = csId.identifier().GetText().Dequote()!;
                var libId = csId.libraryIdentifier()?.GetText().Dequote();
                if (libId is not null)
                    idString = $"{libId}.{idString}";

                var codeSystem = Scope.GetUnique<CodeSystemSymbol>(idString);
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

    public override Symbol VisitConceptDefinition([NotNull] cqlParser.ConceptDefinitionContext context)
    {
        var accessModifier = context.accessModifier().Parse();
        var id = context.identifier().GetText().Dequote()!;
        var display = context.displayClause()?.STRING()?.GetText().Detick();
        var allCodesFound = true;
        var codes = new List<CodeSymbol>();
        foreach (var cid in context.codeIdentifier())
        {
            var codeId = cid.GetText().Dequote()!;
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

    /// <summary>
    /// Gets the type defined by <see cref="LiteralTypeNames.Any"/>, or throws an <see cref="InvalidOperationException"/> if not found.
    /// </summary>
    private TypeSymbol AnyType => Scope.GetUnique<TypeSymbol>(LiteralTypeNames.Any) ??
        throw new InvalidOperationException($"Type {LiteralTypeNames.Any} has not been loaded in any model.");
}

file static class Extensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string? Detick(this string? text)
    {
        if (text is not null)
        {
            if (text.StartsWith("'") && text.EndsWith("'"))
            {
                return text[1..^1];
            }
            return text;
        }
        return null;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string? Dequote(this string? text)
    {
        if (text is not null)
        {
            if (text.StartsWith(@"""") && text.EndsWith(@""""))
            {
                return text[1..^1];
            }
            return text;
        }
        return null;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Symbol WithError(this Symbol symbol, ErrorType errorType)
    {
        symbol.Errors.Add(new(errorType));
        return symbol;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static AccessModifier Parse(this cqlParser.AccessModifierContext accessModifierContext)
    {
        return accessModifierContext switch
        {
            null => AccessModifier.Public,
            _ => accessModifierContext.GetText() switch
            {
                "private" => AccessModifier.Private,
                _ => AccessModifier.Public
            }
        };
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Version Parse(this cqlParser.VersionSpecifierContext context) =>
        context switch
        {
            null => new Version(1, 0, 0),
            _ => Version.Parse(context.GetText().Detick()!)
        };
}
