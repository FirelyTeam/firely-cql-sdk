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
    private readonly ExpressionBuildingDependencies _dependencies;
    private readonly ILogger<LibraryExpressionBuilder> _logger;
    private readonly LibraryDefinitionBuilderSettings _libraryDefinitionBuilderSettings;

    public Library Library { get; }

    public string LibraryKey => Library.NameAndVersion()!;

    public bool AllowUnresolvedExternals => _libraryDefinitionBuilderSettings.AllowUnresolvedExternals;

    public LibraryExpressionBuilder(
        ExpressionBuildingDependencies dependencies,
        Library library,
        DefinitionDictionary<LambdaExpression> libraryDefinitions,
        LibrarySetExpressionBuilder? libsCtx = null)
    {
        // External Services
        _dependencies = dependencies;
        _libraryDefinitionBuilderSettings = dependencies.LibraryDefinitionBuilderSettings;
        _logger = dependencies.LoggerFactory.CreateLogger<LibraryExpressionBuilder>();

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
        this.CatchRethrowExpressionBuildingException(_ =>
        {
            _logger.LogInformation("Building expressions for '{library}'", LibraryKey);

            if (Library.includes is { Length: > 0 } includeDefs)
            {
                foreach (var includeDef in includeDefs)
                {
                    CreateExpressionBuilder().ProcessIncludes(includeDef);
                }

                AddLibraryDefinitionsFromIncludes();
                AddCodeSystemRefsFromIncludes();
            }

            if (Library.valueSets is { Length: > 0 } valueSetDefs)
            {
                foreach (var valueSetDef in valueSetDefs)
                {
                    CreateExpressionBuilder().ProcessValueSetDef(valueSetDef);
                }
            }

            if (Library.codes is { Length: > 0 } codeDefs)
            {
                HashSet<(string codeName, string codeSystemUrl)> foundCodeNameCodeSystemUrls = new();

                foreach (var codeDef in codeDefs)
                {
                    CreateExpressionBuilder().ProcessCodeDef(codeDef, foundCodeNameCodeSystemUrls);
                }
            }

            if (Library.codeSystems is { Length: > 0 } codeSystemDefs)
            {
                foreach (var codeSystemDef in codeSystemDefs)
                {
                    CreateExpressionBuilder().ProcessCodeSystemDef(codeSystemDef);
                }
            }

            if (Library.concepts is { Length: > 0 } conceptDefs)
            {
                foreach (var conceptDef in conceptDefs)
                {
                    CreateExpressionBuilder().ProcessConceptDef(conceptDef);
                }
            }

            if (Library.parameters is { Length: > 0 } parameterDefs)
            {
                foreach (var parameterDef in parameterDefs)
                {
                    CreateExpressionBuilder().ProcessParameterDef(parameterDef);
                }
            }

            if (Library.statements is { Length: > 0 } expressionDefs)
            {
                foreach (var expressionDef in expressionDefs)
                {
                    CreateExpressionBuilder().ProcessExpressionDef(expressionDef);
                }
            }

            return LibraryDefinitions;
        });

    private ExpressionBuilder CreateExpressionBuilder() => new(_dependencies, this);
}