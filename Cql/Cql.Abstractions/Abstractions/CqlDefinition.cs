/*
 * Copyright (c) 2025, Firely and NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
namespace Hl7.Cql.Abstractions;

/// <seealso cref="CqlDefinitionAttribute"/>
internal abstract class CqlDefinition(
    LambdaExpression lambda,
    string name) : Expression
{
    public new LambdaExpression Lambda { get; } = lambda;
    public string Name { get; } = name;
    public override Expression Reduce() => Lambda;

    public override bool CanReduce => true;
    public override ExpressionType NodeType => (ExpressionType)(-1);
    public override Type Type => Lambda.Type;
    public Type ReturnType => Lambda.ReturnType;
}