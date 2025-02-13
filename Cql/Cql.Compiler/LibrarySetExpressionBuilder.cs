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

internal class LibrarySetExpressionBuilder(LibraryExpressionBuilder libraryExpressionBuilder)
{
    public IEnumerable<(Library library, DefinitionDictionary<LambdaExpression> libraryDefinitions)> TryBuildEachLibraryDefinitions(
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression> librarySetDefinitions,
        EnumerateExceptionHandler<Library>? exceptionHandler = null,
        Action<Library>? preHandler = null) =>
        NewLibrarySetExpressionBuilderContext(librarySet, librarySetDefinitions)
            .TryBuildEachLibraryDefinitions(exceptionHandler, preHandler);

    private LibrarySetExpressionBuilderContext NewLibrarySetExpressionBuilderContext(
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression> librarySetDefinitions) =>
        new(libraryExpressionBuilder, librarySet, librarySetDefinitions);
}