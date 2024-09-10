/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections.Generic;
using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Encapsulates the ExpressionBuilder and state dictionaries for building definitions.
/// </summary>
internal class LibraryExpressionBuilder(
    ILogger<LibraryExpressionBuilder> logger,
    ExpressionBuilder expressionBuilder)
{
    public DefinitionDictionary<LambdaExpression> ProcessLibrary(
        Library library,
        DefinitionDictionary<LambdaExpression>? libraryDefinitions = null,
        ILibrarySetExpressionBuilderContext? libsCtx = null) =>
        NewLibraryExpressionBuilderContext(library, libraryDefinitions, libsCtx)
            .ProcessLibrary();

    public LibraryExpressionBuilderContext NewLibraryExpressionBuilderContext(
        Library library,
        DefinitionDictionary<LambdaExpression>? libraryDefinitions = null,
        ILibrarySetExpressionBuilderContext? libsCtx = null) =>
        new(logger, expressionBuilder, library, libraryDefinitions ?? new(), libsCtx);

    public ExpressionBuilderContext NewExpressionBuilderContext(
        Library library,
        DefinitionDictionary<LambdaExpression>? libraryDefinitions = null,
        Dictionary<string, ParameterExpression>? operands = null)
    {
        var libCtx = NewLibraryExpressionBuilderContext(library, libraryDefinitions);
        return expressionBuilder.NewExpressionBuilderContext(libCtx, operands);
    }
}