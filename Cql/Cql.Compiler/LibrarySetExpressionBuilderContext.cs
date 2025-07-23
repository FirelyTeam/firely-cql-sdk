/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;
using Library = Hl7.Cql.Elm.Library;

namespace Hl7.Cql.Compiler;

internal partial class LibrarySetExpressionBuilderContext
{
    private readonly LibraryExpressionBuilder _libraryExpressionBuilder;

    public LibrarySetExpressionBuilderContext(
        LibraryExpressionBuilder libraryExpressionBuilder,
        LibrarySet librarySet,
        CqlDefinitionDictionary librarySetDefinitions)
    {
        _libraryExpressionBuilder = libraryExpressionBuilder;
        LibrarySetDefinitions = librarySetDefinitions;
        LibrarySet = librarySet;
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
                        var libraryDefinitions = _libraryExpressionBuilder.ProcessLibrary(library, null, this);
                        LibrarySetDefinitions.Merge(libraryDefinitions);
                        return (library, libraryDefinitions);
                    });
                },
                buildExceptionHandlingStrategy);
}