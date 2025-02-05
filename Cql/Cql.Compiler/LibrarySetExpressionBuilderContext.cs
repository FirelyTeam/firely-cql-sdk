/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
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
        EnumerationExceptionHandling processLibraryExceptionHandling = default) =>
        this.CatchRethrowExpressionBuildingException(_ =>
        {
            var catchHandler = _logger.CreateLoggingEnumerateExceptionHandler<Library>(
                processLibraryExceptionHandling,
                (lib, log) => log("Error writing library '{libraryName}' to C#.", lib.GetVersionedIdentifier()!));

            LibrarySet
                .TryDoEach(ProcessLibrary)
                .Catch(catchHandler)
                .Count() // We must enumerate all
                ;

            return LibrarySetDefinitions;

            void ProcessLibrary(Library library)
            {
                var librarySetDefinitions = _libraryExpressionBuilder.ProcessLibrary(library, null, this);
                LibrarySetDefinitions.Merge(librarySetDefinitions);
            }
        });

    public IEnumerable<(Library library, Func<DefinitionDictionary<LambdaExpression>> generateLibraryDefinitions)> ProcessLibrarySetDeferred()
    {
        foreach (var library in LibrarySet)
            yield return (library,
                             () => this.CatchRethrowExpressionBuildingException(_ =>
                             {
                                 var libraryDefinitions = _libraryExpressionBuilder.ProcessLibrary(library, null, this);
                                 return libraryDefinitions;
                             }));
    }
}