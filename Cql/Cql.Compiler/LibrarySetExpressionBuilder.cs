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
    public IEnumerable<(Library library, DefinitionDictionary<LambdaExpression> libraryDefinitions)> BuildEachLibraryDefinitions(
        LibrarySetEnumerable librarySetEnumerable,
        DefinitionDictionary<LambdaExpression> librarySetDefinitions,
        EnumerateExceptionHandler<Library>? exceptionHandler = null) =>
        NewLibrarySetExpressionBuilderContext(librarySetEnumerable, librarySetDefinitions)
            .BuildEachLibraryDefinitions(exceptionHandler);

    private LibrarySetExpressionBuilderContext NewLibrarySetExpressionBuilderContext(
        LibrarySetEnumerable librarySetEnumerable,
        DefinitionDictionary<LambdaExpression> librarySetDefinitions) =>
        new(libraryExpressionBuilder, librarySetEnumerable, librarySetDefinitions);
}