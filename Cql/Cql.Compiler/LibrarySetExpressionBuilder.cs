/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Linq.Expressions;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler;

internal class LibrarySetExpressionBuilder(
    ILogger<LibrarySetExpressionBuilder> logger,
    LibraryExpressionBuilder libraryExpressionBuilder)
{
    public DefinitionDictionary<LambdaExpression> ProcessLibrarySet(
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression>? librarySetDefinitions = null,
        ProcessBatchItemExceptionHandling processLibraryExceptionHandling = default) =>
        NewLibrarySetExpressionBuilderContext(librarySet, librarySetDefinitions)
            .ProcessLibrarySet(processLibraryExceptionHandling);

    private LibrarySetExpressionBuilderContext NewLibrarySetExpressionBuilderContext(
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression>? librarySetDefinitions = null) =>
        new(logger, libraryExpressionBuilder, librarySet, librarySetDefinitions ?? new());
}