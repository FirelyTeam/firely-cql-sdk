/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler.Expressions;

/// <seealso cref="ExpressionDef"/>
/// <seealso cref="CqlExpressionDefinitionAttribute"/>
internal class CqlExpressionDefinition(
    LambdaExpression lambdaExpression,
    string name,
    (string tagName, string[] tagValues)[]? tags = null)
    : CqlLambdaDefinition(lambdaExpression, name)
{
    public (string Name, string[] Values)[] Tags { get; } = tags ?? [];
}