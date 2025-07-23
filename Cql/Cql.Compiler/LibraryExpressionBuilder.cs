/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Encapsulates the ExpressionBuilder and state dictionaries for building definitions.
/// </summary>
internal class LibraryExpressionBuilder(
    ILogger<LibraryExpressionBuilder> logger,
    ExpressionBuilder expressionBuilder)
{
    public CqlDefinitionDictionary ProcessLibrary(
        Library library,
        CqlDefinitionDictionary? libraryDefinitions = null,
        LibrarySetExpressionBuilderContext? libsCtx = null) =>
        NewLibraryExpressionBuilderContext(library, libraryDefinitions, libsCtx)
            .ProcessLibrary();

    public LibraryExpressionBuilderContext NewLibraryExpressionBuilderContext(
        Library library,
        CqlDefinitionDictionary? libraryDefinitions = null,
        LibrarySetExpressionBuilderContext? libsCtx = null) =>
        new(logger, expressionBuilder, library, libraryDefinitions ?? new(), libsCtx);

    public ExpressionBuilderContext NewExpressionBuilderContext(
        Library library,
        CqlDefinitionDictionary? libraryDefinitions = null,
        Dictionary<string, ParameterExpression>? operands = null)
    {
        var libraryExpressionBuilderContext = NewLibraryExpressionBuilderContext(library, libraryDefinitions);
        return expressionBuilder.NewExpressionBuilderContext(libraryExpressionBuilderContext, operands);
    }
}