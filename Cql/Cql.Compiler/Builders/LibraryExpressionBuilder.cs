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
    internal readonly ExpressionBuilder _expressionBuilder;

    public LibraryExpressionBuilder(
        ILogger<LibraryExpressionBuilder> logger,
        ExpressionBuilder expressionBuilder)
    {
        _logger = logger;
        _expressionBuilder = expressionBuilder;
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
    private readonly ExpressionBuilder _expressionBuilder;

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
        _expressionBuilder = builder._expressionBuilder;

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
                    _expressionBuilder.ProcessIncludes(this, includeDef);
                }

                AddLibraryDefinitionsFromIncludes();
                AddCodeSystemRefsFromIncludes();
            }

            if (Library.valueSets is { Length: > 0 } valueSetDefs)
            {
                foreach (var valueSetDef in valueSetDefs)
                {
                    _expressionBuilder.ProcessValueSetDef(this, valueSetDef);
                }
            }

            if (Library.codes is { Length: > 0 } codeDefs)
            {
                HashSet<(string codeName, string codeSystemUrl)> foundCodeNameCodeSystemUrls = new();

                foreach (var codeDef in codeDefs)
                {
                    _expressionBuilder.ProcessCodeDef(this, codeDef, foundCodeNameCodeSystemUrls);
                }
            }

            if (Library.codeSystems is { Length: > 0 } codeSystemDefs)
            {
                foreach (var codeSystemDef in codeSystemDefs)
                {
                    _expressionBuilder.ProcessCodeSystemDef(this, codeSystemDef);
                }
            }

            if (Library.concepts is { Length: > 0 } conceptDefs)
            {
                foreach (var conceptDef in conceptDefs)
                {
                    _expressionBuilder.ProcessConceptDef(this, conceptDef);
                }
            }

            if (Library.parameters is { Length: > 0 } parameterDefs)
            {
                foreach (var parameterDef in parameterDefs)
                {
                    _expressionBuilder.ProcessParameterDef(this, parameterDef);
                }
            }

            if (Library.statements is { Length: > 0 } expressionDefs)
            {
                foreach (var expressionDef in expressionDefs)
                {
                    _expressionBuilder.ProcessExpressionDef(this, expressionDef);
                }
            }

            return LibraryDefinitions;
        });
}

