/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Abstractions;

/// <seealso cref="CqlDefinitionAttribute"/>
internal abstract class CqlDefinition(string name) : Expression
{
    public string Name { get; } = name;
    public override bool CanReduce => false;
    public override ExpressionType NodeType => (ExpressionType)(-1);
    public abstract Type ReturnType { get; }
}