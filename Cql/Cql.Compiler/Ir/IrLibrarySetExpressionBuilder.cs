/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler.Preprocessing;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler.Ir;

/// <summary>
/// IR counterpart of <see cref="LibrarySetExpressionBuilder"/>. This is a mechanical port; see
/// the remarks on <see cref="IrExpressionBuilderContext"/>.
/// </summary>
internal class IrLibrarySetExpressionBuilder(
    IrLibraryExpressionBuilder libraryExpressionBuilder,
    LibraryPreprocessorBuilder libraryPreprocessorBuilder)
{
    public IEnumerable<(Library library, IrDefinitionDictionary libraryDefinitions)> BuildEachLibraryDefinitions(
        LibrarySet librarySet,
        IrDefinitionDictionary librarySetDefinitions,
        BatchProcessExceptionHandlingStrategyBuilder<Library>? errorStrategyBuilder = null,
        Action<Library>? onNextLibrary = null) =>
        NewLibrarySetExpressionBuilderContext(librarySet, librarySetDefinitions)
            .BuildEachLibraryDefinitions(errorStrategyBuilder, onNextLibrary);

    private IrLibrarySetExpressionBuilderContext NewLibrarySetExpressionBuilderContext(
        LibrarySet librarySet,
        IrDefinitionDictionary librarySetDefinitions) =>
        new(libraryExpressionBuilder, libraryPreprocessorBuilder, librarySet, librarySetDefinitions);
}
