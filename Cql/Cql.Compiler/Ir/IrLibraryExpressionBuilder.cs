/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler.Preprocessing;
using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler.Ir;

/// <summary>
/// Encapsulates the IrExpressionBuilder and state dictionaries for building definitions.
/// IR counterpart of <see cref="LibraryExpressionBuilder"/>; a mechanical port, see the
/// remarks on <see cref="IrExpressionBuilderContext"/>.
/// </summary>
internal class IrLibraryExpressionBuilder(
    ILogger<IrLibraryExpressionBuilder> logger,
    IrExpressionBuilder expressionBuilder,
    LibraryPreprocessorBuilder libraryPreprocessorBuilder)
{
    public IrDefinitionDictionary ProcessLibrary(
        Library library,
        IrDefinitionDictionary? libraryDefinitions = null,
        IrLibrarySetExpressionBuilderContext? libsCtx = null) =>
        NewLibraryExpressionBuilderContext(library, libraryDefinitions, libsCtx)
            .ProcessLibrary();

    public IrLibraryExpressionBuilderContext NewLibraryExpressionBuilderContext(
        Library library,
        IrDefinitionDictionary? libraryDefinitions = null,
        IrLibrarySetExpressionBuilderContext? libsCtx = null) =>
        new(logger, expressionBuilder, libraryPreprocessorBuilder, library, libraryDefinitions ?? new(), libsCtx);

    public IrExpressionBuilderContext NewExpressionBuilderContext(
        Library library,
        IrDefinitionDictionary? libraryDefinitions = null,
        Dictionary<string, IrLocal>? operands = null)
    {
        var libraryExpressionBuilderContext = NewLibraryExpressionBuilderContext(library, libraryDefinitions);
        return expressionBuilder.NewExpressionBuilderContext(libraryExpressionBuilderContext, operands);
    }
}
