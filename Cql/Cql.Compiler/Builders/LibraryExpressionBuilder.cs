using System.Collections.Generic;
using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler.Builders;

/// <summary>
/// Encapsulates the ExpressionBuilder and state dictionaries for building definitions.
/// </summary>
internal class LibraryExpressionBuilder
{
    internal readonly ILogger<LibraryExpressionBuilder> _logger;
    internal readonly IExpressionBuilderFactory _expressionBuilderFactory;

    public LibraryExpressionBuilder(
        ILogger<LibraryExpressionBuilder> logger,
        IExpressionBuilderFactory expressionBuilderFactory)
    {
        _logger = logger;
        _expressionBuilderFactory = expressionBuilderFactory;
    }

    public DefinitionDictionary<LambdaExpression> ProcessLibrary(
        Library library,
        DefinitionDictionary<LambdaExpression>? libraryDefinitions = null,
        ILibrarySetExpressionBuilderContext? libsCtx = null)
    {
        LibraryExpressionBuilderContext ctx = new(this, library, libraryDefinitions ?? new(), libsCtx);
        return ctx.ProcessLibrary();
    }
}

internal partial class LibraryExpressionBuilderContext
{
    private readonly ILogger<LibraryExpressionBuilder> _logger;
    private readonly IExpressionBuilderFactory _expressionBuilderFactory;

    public Library Library { get; }

    public string LibraryKey => Library.NameAndVersion()!;

    public LibraryExpressionBuilderContext(
        LibraryExpressionBuilder builder,
        Library library,
        DefinitionDictionary<LambdaExpression> libraryDefinitions,
        ILibrarySetExpressionBuilderContext? libsCtx = null)
    {
        // External Services
        _logger = builder._logger;
        _expressionBuilderFactory = builder._expressionBuilderFactory;

        // External State
        LibraryDefinitions = libraryDefinitions;
        Library = library;
        LibrarySetContext = libsCtx;

        // Internal State
        _libraryIdentifiersByAlias = new();
        _codesByName = new();
        _codesByCodeSystemName = new();
        _codeSystemIdsByCodeSystemRefs = new ByLibraryNameAndNameDictionary<string>();
    }

    public DefinitionDictionary<LambdaExpression> ProcessLibrary() =>
        this.CatchRethrowExpressionBuildingException<LibraryExpressionBuilderContext, DefinitionDictionary<LambdaExpression>>(_ =>
        {
            _logger.LogInformation("Building expressions for '{library}'", LibraryKey);

            if (Library.includes is { Length: > 0 } includeDefs)
            {
                foreach (var includeDef in includeDefs)
                {
                    _expressionBuilderFactory.New(this).ProcessIncludes(includeDef);
                }

                AddLibraryDefinitionsFromIncludes();
                AddCodeSystemRefsFromIncludes();
            }

            if (Library.valueSets is { Length: > 0 } valueSetDefs)
            {
                foreach (var valueSetDef in valueSetDefs)
                {
                    _expressionBuilderFactory.New(this).ProcessValueSetDef(valueSetDef);
                }
            }

            if (Library.codes is { Length: > 0 } codeDefs)
            {
                HashSet<(string codeName, string codeSystemUrl)> foundCodeNameCodeSystemUrls = new();

                foreach (var codeDef in codeDefs)
                {
                    _expressionBuilderFactory.New(this).ProcessCodeDef(codeDef, foundCodeNameCodeSystemUrls);
                }
            }

            if (Library.codeSystems is { Length: > 0 } codeSystemDefs)
            {
                foreach (var codeSystemDef in codeSystemDefs)
                {
                    _expressionBuilderFactory.New(this).ProcessCodeSystemDef(codeSystemDef);
                }
            }

            if (Library.concepts is { Length: > 0 } conceptDefs)
            {
                foreach (var conceptDef in conceptDefs)
                {
                    _expressionBuilderFactory.New(this).ProcessConceptDef(conceptDef);
                }
            }

            if (Library.parameters is { Length: > 0 } parameterDefs)
            {
                foreach (var parameterDef in parameterDefs)
                {
                    _expressionBuilderFactory.New(this).ProcessParameterDef(parameterDef);
                }
            }

            if (Library.statements is { Length: > 0 } expressionDefs)
            {
                foreach (var expressionDef in expressionDefs)
                {
                    _expressionBuilderFactory.New(this).ProcessExpressionDef(expressionDef);
                }
            }

            return LibraryDefinitions;
        });
}

