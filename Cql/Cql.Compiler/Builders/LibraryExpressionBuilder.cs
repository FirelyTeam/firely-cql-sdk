using System.Collections.Generic;
using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler.Builders;

/// <summary>
/// Encapsulates the ExpressionBuilder and state dictionaries for building definitions.
/// </summary>
partial class LibraryExpressionBuilder
{
    private readonly ILogger<ILibraryExpressionBuilderContext> _logger;
    private readonly LibraryDefinitionBuilderSettings _libraryDefinitionBuilderSettings;
    private readonly IExpressionBuilderFactory _expressionBuilderFactory;

    public Library Library { get; }

    public string LibraryKey => Library.NameAndVersion()!;

    public bool AllowUnresolvedExternals => _libraryDefinitionBuilderSettings.AllowUnresolvedExternals;

    public LibraryExpressionBuilder(
        ILogger<ILibraryExpressionBuilderContext> logger,
        IExpressionBuilderFactory expressionBuilderFactory,
        LibraryDefinitionBuilderSettings libraryDefinitionBuilderSettings,
        Library library,
        DefinitionDictionary<LambdaExpression> libraryDefinitions,
        ILibrarySetExpressionBuilderContext? libsCtx = null)
    {
        // External Services
        _libraryDefinitionBuilderSettings = libraryDefinitionBuilderSettings;
        _logger = logger;

        // External State
        LibraryDefinitions = libraryDefinitions;
        Library = library;
        _expressionBuilderFactory = expressionBuilderFactory;
        LibrarySetContext = libsCtx;

        // Internal State
        _libraryIdentifiersByAlias = new();
        _codesByName = new();
        _codesByCodeSystemName = new();
        _codeSystemIdsByCodeSystemRefs = new ByLibraryNameAndNameDictionary<string>();
    }

    public DefinitionDictionary<LambdaExpression> ProcessLibrary() =>
        this.CatchRethrowExpressionBuildingException(_ =>
        {
            _logger.LogInformation("Building expressions for '{library}'", LibraryKey);

            if (Library.includes is { Length: > 0 } includeDefs)
            {
                foreach (var includeDef in includeDefs)
                {
                    NewExpressionBuilder().ProcessIncludes(includeDef);
                }

                AddLibraryDefinitionsFromIncludes();
                AddCodeSystemRefsFromIncludes();
            }

            if (Library.valueSets is { Length: > 0 } valueSetDefs)
            {
                foreach (var valueSetDef in valueSetDefs)
                {
                    NewExpressionBuilder().ProcessValueSetDef(valueSetDef);
                }
            }

            if (Library.codes is { Length: > 0 } codeDefs)
            {
                HashSet<(string codeName, string codeSystemUrl)> foundCodeNameCodeSystemUrls = new();

                foreach (var codeDef in codeDefs)
                {
                    NewExpressionBuilder().ProcessCodeDef(codeDef, foundCodeNameCodeSystemUrls);
                }
            }

            if (Library.codeSystems is { Length: > 0 } codeSystemDefs)
            {
                foreach (var codeSystemDef in codeSystemDefs)
                {
                    NewExpressionBuilder().ProcessCodeSystemDef(codeSystemDef);
                }
            }

            if (Library.concepts is { Length: > 0 } conceptDefs)
            {
                foreach (var conceptDef in conceptDefs)
                {
                    NewExpressionBuilder().ProcessConceptDef(conceptDef);
                }
            }

            if (Library.parameters is { Length: > 0 } parameterDefs)
            {
                foreach (var parameterDef in parameterDefs)
                {
                    NewExpressionBuilder().ProcessParameterDef(parameterDef);
                }
            }

            if (Library.statements is { Length: > 0 } expressionDefs)
            {
                foreach (var expressionDef in expressionDefs)
                {
                    NewExpressionBuilder().ProcessExpressionDef(expressionDef);
                }
            }

            return LibraryDefinitions;
        });

    private ExpressionBuilder NewExpressionBuilder() => _expressionBuilderFactory.New(this);
}

