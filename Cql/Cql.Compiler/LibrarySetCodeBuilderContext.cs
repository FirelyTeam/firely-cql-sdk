/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler.Preprocessing;
using Hl7.Cql.Runtime;
using Library = Hl7.Cql.Elm.Library;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Orchestrates building each library of a library set and merging its definitions; see the
/// remarks on <see cref="CodeBuilderContext"/>.
/// </summary>
[DebuggerDisplay("{DebuggerView}")]
internal class LibrarySetCodeBuilderContext : IBuilderContext
{
    private readonly LibraryCodeBuilder _libraryCodeBuilder;

    public LibrarySetCodeBuilderContext(
        LibraryCodeBuilder libraryCodeBuilder,
        LibraryPreprocessorBuilder libraryPreprocessorBuilder,
        LibrarySet librarySet,
        CqlDefinitionDictionary librarySetDefinitions)
    {
        _libraryCodeBuilder = libraryCodeBuilder;
        LibrarySetDefinitions = librarySetDefinitions;
        LibrarySet = librarySet;
        Preprocessor = libraryPreprocessorBuilder.Build(librarySet);
        DebuggerInfo = new BuilderContextDebuggerInfo("LibrarySet", Name: LibrarySet!.Name!);
    }

    /// <summary>
    /// Gets the merged definitions of all the libraries processed in the <see cref="LibrarySet"/>.
    /// </summary>
    public CqlDefinitionDictionary LibrarySetDefinitions { get; }

    /// <summary>
    /// Gets the library set being processed.
    /// </summary>
    public LibrarySet LibrarySet { get; }

    public LibraryPreprocessor Preprocessor { get; }

    public IEnumerable<(Library library, CqlDefinitionDictionary libraryDefinitions)> BuildEachLibraryDefinitions(
        BatchProcessExceptionHandlingStrategyBuilder<Library>? buildExceptionHandlingStrategy = null,
        Action<Library>? prebuildLibraryHandler = null) =>
        LibrarySet
            .TrySelect(
                library =>
                {
                    prebuildLibraryHandler?.Invoke(library);
                    return this.CatchRethrowExpressionBuildingException(_ =>
                    {
                        var libraryDefinitions = _libraryCodeBuilder.ProcessLibrary(library, null, this);
                        LibrarySetDefinitions.Merge(libraryDefinitions);
                        return (library, libraryDefinitions);
                    });
                },
                buildExceptionHandlingStrategy);

    #region DebuggerView

    public IBuilderContext? OuterBuilderContext => null;
    public BuilderContextDebuggerInfo? DebuggerInfo { get; }
    public string DebuggerView => this.GetDebuggerView();

    #endregion
}
