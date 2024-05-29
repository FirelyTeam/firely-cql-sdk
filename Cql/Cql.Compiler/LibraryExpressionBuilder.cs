/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Encapsulates the ExpressionBuilder and state dictionaries for building definitions.
/// </summary>
internal class LibraryExpressionBuilder
{
    internal readonly ILogger<LibraryExpressionBuilder> _logger;
    internal readonly ExpressionBuilder _expressionBuilder;

    public LibraryExpressionBuilder(
        ILogger<LibraryExpressionBuilder> logger,
        ExpressionBuilder expressionBuilder)
    {
        _logger = logger;
        _expressionBuilder = expressionBuilder;
    }

    public DefinitionDictionary<LambdaExpression> ProcessLibrary(
        Library library,
        DefinitionDictionary<LambdaExpression>? libraryDefinitions = null,
        ILibrarySetExpressionBuilderContext? libsCtx = null)
    {
        LibraryExpressionBuilderContext ctx = new(this, library, libraryDefinitions ?? new(), libsCtx);
        return ctx.ProcessLibrary();
    }
}