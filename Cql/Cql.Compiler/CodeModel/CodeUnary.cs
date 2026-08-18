/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Primitives;

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
            // CqlBoolean as well as bool/bool?: it declares its own three-valued operator !, so a
            // negation stays in the type instead of being forced out through bool? and coalesced
            // back — `!(a || b)` rather than `(!((bool?)(a || b))) ?? false`.
            CodeUnaryOp.Not when CodeTypeRules.IsPlainBool(operand.Type)
                                 || CodeTypeRules.IsNullableBool(operand.Type)
                                 || CodeTypeRules.IsCqlBoolean(operand.Type) => operand.Type,
            CodeUnaryOp.Not => throw new ArgumentException($"The operand of {op} must be bool, bool? or {nameof(CqlBoolean)}, not {operand.Type}."),
            _ => throw new ArgumentException($"Unknown unary operator {op}."),
        };

        Op = op;
        Operand = operand;
    }

    public CodeUnaryOp Op { get; }

    public CodeExpression Operand { get; }

    public override Type Type { get; }
}
