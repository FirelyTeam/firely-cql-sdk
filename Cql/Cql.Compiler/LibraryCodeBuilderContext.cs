/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler.Preprocessing;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Orchestrates building all definitions of a single library into an
/// <see cref="CqlDefinitionDictionary"/>; see the remarks on
/// <see cref="CodeBuilderContext"/>.
/// </summary>
[DebuggerDisplay("{DebuggerView}")]
internal partial class LibraryCodeBuilderContext : IBuilderContext
{
    private readonly ILogger<LibraryCodeBuilder> _logger;
    private readonly CodeBuilder _expressionBuilder;
    private readonly CqlDefinitionDictionary _libraryDefinitions;
    private readonly LibrarySetCodeBuilderContext? _libsCtx;
    private readonly LibraryPreprocessor _preprocessor;

    public LibraryCodeBuilderContext(
        ILogger<LibraryCodeBuilder> logger,
        CodeBuilder expressionBuilder,
        LibraryPreprocessorBuilder libraryPreprocessorBuilder,
        Library library,
        CqlDefinitionDictionary libraryDefinitions,
        LibrarySetCodeBuilderContext? libsCtx = null)
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
            _logger.LogDebug("Building expressions for '{library}'", LibraryVersionedIdentifier);

            _preprocessor.PreprocessLibrary(Library);

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

    #region DebuggerView

    IBuilderContext? IBuilderContext.OuterBuilderContext => LibrarySetContext;

    BuilderContextDebuggerInfo? IBuilderContext.DebuggerInfo => BuilderContextDebuggerInfo.FromElement(Library);

    public string DebuggerView => this.GetDebuggerView();

    #endregion
}
