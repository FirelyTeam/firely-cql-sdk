/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler.Preprocessing;
using Hl7.Cql.Runtime;
using Library = Hl7.Cql.Elm.Library;

namespace Hl7.Cql.Compiler;

internal partial class LibrarySetExpressionBuilderContext
{
    private readonly LibraryExpressionBuilder _libraryExpressionBuilder;

    public LibrarySetExpressionBuilderContext(
        LibraryExpressionBuilder libraryExpressionBuilder,
        LibraryPreprocessorBuilder libraryPreprocessorBuilder,
        LibrarySet librarySet,
        CqlDefinitionDictionary librarySetDefinitions)
    {
        _libraryExpressionBuilder = libraryExpressionBuilder;
        LibrarySetDefinitions = librarySetDefinitions;
        LibrarySet = librarySet;
        Preprocessor = libraryPreprocessorBuilder.Build(librarySet);
        DebuggerInfo = new BuilderContextDebuggerInfo("LibrarySet", Name: LibrarySet!.Name!);
        LocatorMetadata = new ExpressionLocatorMetadata();
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

    /// <summary>
    /// Gets the metadata for storing CQL source locator information for expressions.
    /// </summary>
    public ExpressionLocatorMetadata LocatorMetadata { get; }

    public IEnumerable<(Library library, CqlDefinitionDictionary libraryDefinitions)> BuildEachLibraryDefinitions(
        BatchProcessExceptionHandlingStrategyBuilder<Library>? buildExceptionHandlingStrategy = null,
        Action<Library>? prebuildLibraryHandler = null,
        Action<LibrarySetExpressionBuilderContext>? contextCallback = null) =>
        LibrarySet
            .TrySelect(
                library =>
                {
                    prebuildLibraryHandler?.Invoke(library);
                    contextCallback?.Invoke(this); // Invoke context callback to capture metadata
                    return this.CatchRethrowExpressionBuildingException(_ =>
                    {
                        var libraryDefinitions = _libraryExpressionBuilder.ProcessLibrary(library, null, this);
                        LibrarySetDefinitions.Merge(libraryDefinitions);
                        return (library, libraryDefinitions);
                    });
                },
                buildExceptionHandlingStrategy);
}