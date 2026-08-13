/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

namespace Hl7.Cql.Compiler.CodeModel;

/// <summary>
/// The unary operators the builder emits directly, mirroring <see cref="CodeBinaryOp"/>.
/// </summary>
internal enum CodeUnaryOp
{
    /// <summary><c>!a</c> over a <c>bool?</c> operand — C#'s lifted <c>!</c> is exactly
    /// CQL's three-valued <c>not</c> (null stays null).</summary>
    Not,
}

/// <summary>
/// A unary operator application.
/// </summary>
internal sealed class CodeUnary : CodeExpression
{
    public CodeUnary(CodeUnaryOp op, CodeExpression operand)
    {
        Type = op switch
        {
            CodeUnaryOp.Not when operand.Type == typeof(bool) || operand.Type == typeof(bool?) => operand.Type,
            CodeUnaryOp.Not => throw new ArgumentException($"The operand of {op} must be bool or bool?, not {operand.Type}."),
            _ => throw new ArgumentException($"Unknown unary operator {op}."),
        };

        Op = op;
        Operand = operand;
    }

    public CodeUnaryOp Op { get; }

    public CodeExpression Operand { get; }

    public override Type Type { get; }
}
