/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Abstractions;

internal abstract class CqlLambdaDefinition(
    LambdaExpression lambdaExpression,
    string name) : CqlDefinition(name)
{
    public override Expression Reduce() => LambdaExpression;
    public override bool CanReduce => true;
    public LambdaExpression LambdaExpression { get; } = lambdaExpression;
    public override Type Type => LambdaExpression.Type;
    public override Type ReturnType => LambdaExpression.ReturnType;
}