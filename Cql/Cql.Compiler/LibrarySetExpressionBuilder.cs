/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

internal class LibrarySetExpressionBuilder(
    LibraryExpressionBuilder libraryExpressionBuilder)
{
    public IEnumerable<(Library library, Func<DefinitionDictionary<LambdaExpression>> getLibraryDefinitions)> TryBuildEachLibraryDefinitions(
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression>? librarySetDefinitions = null) =>
        NewLibrarySetExpressionBuilderContext(librarySet, librarySetDefinitions)
            .TryBuildEachLibraryDefinitions();

    private LibrarySetExpressionBuilderContext NewLibrarySetExpressionBuilderContext(
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression>? librarySetDefinitions = null) =>
        new(libraryExpressionBuilder, librarySet, librarySetDefinitions ?? new());
}