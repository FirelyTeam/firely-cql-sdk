/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Linq;
using System.Linq.Expressions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

internal partial class LibrarySetExpressionBuilderContext
{
    private readonly LibraryExpressionBuilder _libraryExpressionBuilder;

    public LibrarySetExpressionBuilderContext(
        LibrarySetExpressionBuilder builder,
        DefinitionDictionary<LambdaExpression> librarySetDefinitions,
        LibrarySet librarySet)
    {
        _libraryExpressionBuilder = builder._libraryExpressionBuilder;
        LibrarySetDefinitions = librarySetDefinitions;
        LibrarySet = librarySet;
        DebuggerInfo = new BuilderContextDebuggerInfo("LibrarySet", Name: LibrarySet!.Name!);
    }

    public DefinitionDictionary<LambdaExpression> LibrarySetDefinitions { get; }
    public LibrarySet LibrarySet { get; }

    public DefinitionDictionary<LambdaExpression> ProcessLibrarySet() =>
        this.CatchRethrowExpressionBuildingException(_ =>
        {
            var ambiguousOverloadCorrector = new AmbiguousOverloadCorrector();

            foreach (var library in LibrarySet)
            {
                // Make sure all overloads in the library are unique.
                // This is a fix for QICore-based CQL, where the functions only differ by profiles on the same resource.
                // We should remove this when the compiler is fixed.
                // See https://github.com/FirelyTeam/firely-cql-sdk/issues/438.
                ambiguousOverloadCorrector.Fix(library);

                var librarySetDefinitions = _libraryExpressionBuilder.ProcessLibrary(library, null, this);
                LibrarySetDefinitions.Merge(librarySetDefinitions);
            }

            return LibrarySetDefinitions;
        });
}