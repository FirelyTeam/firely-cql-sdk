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
    public IEnumerable<(Library library, CqlDefinitionDictionary libraryDefinitions)> BuildEachLibraryDefinitions(
        LibrarySet librarySet,
        CqlDefinitionDictionary librarySetDefinitions,
        BatchProcessExceptionHandlingStrategyBuilder<Library>? errorStrategyBuilder = null,
        Action<Library>? onNextLibrary = null) =>
        NewLibrarySetExpressionBuilderContext(librarySet, librarySetDefinitions)
            .BuildEachLibraryDefinitions(errorStrategyBuilder, onNextLibrary);

    private LibrarySetExpressionBuilderContext NewLibrarySetExpressionBuilderContext(
        LibrarySet librarySet,
        CqlDefinitionDictionary librarySetDefinitions) =>
        new(libraryExpressionBuilder, librarySet, librarySetDefinitions);
}