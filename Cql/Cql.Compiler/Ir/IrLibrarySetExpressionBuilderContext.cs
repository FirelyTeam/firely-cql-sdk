/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler.Preprocessing;
using Hl7.Cql.Runtime;
using Library = Hl7.Cql.Elm.Library;

namespace Hl7.Cql.Compiler.Ir;

/// <summary>
/// IR counterpart of <see cref="LibrarySetExpressionBuilderContext"/>: orchestrates building
/// each library of a library set and merging its definitions. This is a mechanical port; see
/// the remarks on <see cref="IrExpressionBuilderContext"/>.
/// </summary>
[DebuggerDisplay("{DebuggerView}")]
internal class IrLibrarySetExpressionBuilderContext : IBuilderContext
{
    private readonly IrLibraryExpressionBuilder _libraryExpressionBuilder;

    public IrLibrarySetExpressionBuilderContext(
        IrLibraryExpressionBuilder libraryExpressionBuilder,
        LibraryPreprocessorBuilder libraryPreprocessorBuilder,
        LibrarySet librarySet,
        IrDefinitionDictionary librarySetDefinitions)
    {
        _libraryExpressionBuilder = libraryExpressionBuilder;
        LibrarySetDefinitions = librarySetDefinitions;
        LibrarySet = librarySet;
        Preprocessor = libraryPreprocessorBuilder.Build(librarySet);
        DebuggerInfo = new BuilderContextDebuggerInfo("LibrarySet", Name: LibrarySet!.Name!);
    }

    /// <summary>
    /// Gets the merged definitions of all the libraries processed in the <see cref="LibrarySet"/>.
    /// </summary>
    public IrDefinitionDictionary LibrarySetDefinitions { get; }

    /// <summary>
    /// Gets the library set being processed.
    /// </summary>
    public LibrarySet LibrarySet { get; }

    public LibraryPreprocessor Preprocessor { get; }

    public IEnumerable<(Library library, IrDefinitionDictionary libraryDefinitions)> BuildEachLibraryDefinitions(
        BatchProcessExceptionHandlingStrategyBuilder<Library>? buildExceptionHandlingStrategy = null,
        Action<Library>? prebuildLibraryHandler = null) =>
        LibrarySet
            .TrySelect(
                library =>
                {
                    prebuildLibraryHandler?.Invoke(library);
                    return this.CatchRethrowExpressionBuildingException(_ =>
                    {
                        var libraryDefinitions = _libraryExpressionBuilder.ProcessLibrary(library, null, this);
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
