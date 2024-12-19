/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

internal partial class LibrarySetExpressionBuilderContext
{
    private readonly LibraryExpressionBuilder _libraryExpressionBuilder;

    public LibrarySetExpressionBuilderContext(
        LibraryExpressionBuilder libraryExpressionBuilder,
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression> librarySetDefinitions)
    {
        _libraryExpressionBuilder = libraryExpressionBuilder;
        LibrarySetDefinitions = librarySetDefinitions;
        LibrarySet = librarySet;
        DebuggerInfo = new BuilderContextDebuggerInfo("LibrarySet", Name: LibrarySet!.Name!);
    }

    /// <summary>
    /// Gets the merged definitions of all the libraries processed in the <see cref="LibrarySet"/>.
    /// </summary>
    public DefinitionDictionary<LambdaExpression> LibrarySetDefinitions { get; }

    /// <summary>
    /// Gets the library set being processed.
    /// </summary>
    public LibrarySet LibrarySet { get; }

    public DefinitionDictionary<LambdaExpression> ProcessLibrarySet(
        Func<ProcessLibrarySetError, bool>? shouldThrowException = null) =>
        this.CatchRethrowExpressionBuildingException(_ =>
        {
            switch (shouldThrowException)
            {
                case null:
                    foreach (var library in LibrarySet)
                        ProcessLibrary(library);
                    break;

                default:
                    foreach (var library in LibrarySet)
                        ProcessLibraryWithErrorHandling(library);
                    break;
            }

            return LibrarySetDefinitions;

            void ProcessLibrary(Library library)
            {
                var librarySetDefinitions = _libraryExpressionBuilder.ProcessLibrary(library, null, this);
                LibrarySetDefinitions.Merge(librarySetDefinitions);
            }

            void ProcessLibraryWithErrorHandling(Library library)
            {
                try
                {
                    ProcessLibrary(library);
                }
                catch (Exception e)
                {
                    var errorHandling = new ProcessLibrarySetError(this, library, e);
                    if (shouldThrowException(errorHandling))
                        throw;
                }
            }
        });

    public readonly record struct ProcessLibrarySetError(
        LibrarySetExpressionBuilderContext Context,
        Library Library,
        Exception Exception);
}