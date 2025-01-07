/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Linq.Expressions;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;
using Library = Hl7.Cql.Elm.Library;

namespace Hl7.Cql.Compiler;

internal partial class LibrarySetExpressionBuilderContext
{
    private readonly ILogger<LibrarySetExpressionBuilder> _logger;
    private readonly LibraryExpressionBuilder _libraryExpressionBuilder;

    public LibrarySetExpressionBuilderContext(
        ILogger<LibrarySetExpressionBuilder> logger,
        LibraryExpressionBuilder libraryExpressionBuilder,
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression> librarySetDefinitions)
    {
        _logger = logger;
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
        ProcessBatchItemExceptionHandling processLibraryExceptionHandling = default) =>
        this.CatchRethrowExpressionBuildingException(_ =>
        {
            ExceptionHandlingMethods.ProcessBatchWithExceptionHandlingAndLogging(
                items: LibrarySet,
                process: ProcessLibrary,
                exceptionHandling: processLibraryExceptionHandling,
                logger: _logger,
                buildLoggerMessage: (exceptionHandling, library, exception) => (exceptionHandling, exception) switch
                {
                    (ProcessBatchItemExceptionHandling.ThrowException, { }) => ("Error writing library '{libraryName}' to C#.", [library.GetVersionedIdentifier()!]),
                    (ProcessBatchItemExceptionHandling.IgnoreExceptionAndContinue, { }) => ("Error ignored writing library '{libraryName}' to C#, continuing to next library.", [library.GetVersionedIdentifier()!]),
                    (ProcessBatchItemExceptionHandling.IgnoreExceptionAndBreak, { }) => ("Error ignored writing library '{libraryName}' to C#, abort processing more libraries.", [library.GetVersionedIdentifier()!]),
                    _ => null,
                });

            return LibrarySetDefinitions;

            void ProcessLibrary(Library library)
            {
                var librarySetDefinitions = _libraryExpressionBuilder.ProcessLibrary(library, null, this);
                LibrarySetDefinitions.Merge(librarySetDefinitions);
            }
        });
}