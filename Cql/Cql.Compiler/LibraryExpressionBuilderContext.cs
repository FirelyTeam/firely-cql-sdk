/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler.Preprocessing;
using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler;

internal partial class LibraryExpressionBuilderContext
{
    private readonly ILogger<LibraryExpressionBuilder> _logger;
    private readonly ExpressionBuilder _expressionBuilder;
    private readonly CqlDefinitionDictionary _libraryDefinitions;
    private readonly LibrarySetExpressionBuilderContext? _libsCtx;
    private readonly LibraryPreprocessor _preprocessor;

    public LibraryExpressionBuilderContext(
        ILogger<LibraryExpressionBuilder> logger,
        ExpressionBuilder expressionBuilder,
        LibraryPreprocessorBuilder libraryPreprocessorBuilder,
        Library library,
        CqlDefinitionDictionary libraryDefinitions,
        LibrarySetExpressionBuilderContext? libsCtx = null)
    {
        _libraryDefinitions = libraryDefinitions;
        _libsCtx = libsCtx;
        _logger = logger;
        _expressionBuilder = expressionBuilder;
        Library = library;
        LibraryVersionedIdentifier = Library.VersionedLibraryIdentifier;
        _preprocessor =
            LibrarySetContext?.Preprocessor
            ?? libraryPreprocessorBuilder.Build(new LibrarySet(LibraryVersionedIdentifier, Library));
    }

    /// <summary>
    /// Gets the library associated with the expression builder context.
    /// </summary>
    public Library Library { get; }

    /// <summary>
    /// Gets the versioned identifier of the library, which is the name and version of the library.
    /// </summary>
    /// <seealso cref="IGetVersionedIdentifierExtensions.GetVersionedLibraryIdentifierString"/>
    public string LibraryVersionedIdentifier { get; }

    public CqlDefinitionDictionary ProcessLibrary() =>
        this.CatchRethrowExpressionBuildingException(_ =>
        {
            _preprocessor.PreprocessLibrary(Library);

            _logger.LogDebug("Building expressions for '{library}'", LibraryVersionedIdentifier);

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

            AddCodeSystemRefs(Library);

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