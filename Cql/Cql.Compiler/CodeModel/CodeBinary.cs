/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Compiler.CodeModel;

/// <summary>
/// The binary operators the builder emits directly. CQL's arithmetic and logic go through
/// <c>ICqlOperators</c> calls, so only the handful of operators used for plumbing exist here.
/// </summary>
internal enum CodeBinaryOp
{
    /// <summary><c>a ?? b</c></summary>
    Coalesce,

    /// <summary><c>a == b</c> (printed as <c>a is null</c> when compared to a null constant).</summary>
    Equal,

    /// <summary><c>a != b</c> (printed as <c>a is not null</c> when compared to a null constant).</summary>
    NotEqual,

    /// <summary><c>a || b</c></summary>
    OrElse,

    /// <summary><c>a &amp;&amp; b</c></summary>
    AndAlso,

    /// <summary><c>a &amp; b</c> over <c>bool?</c> operands — C#'s lifted <c>&amp;</c> is
    /// exactly CQL's three-valued <c>and</c> (false dominates, null propagates).</summary>
    BoolAnd,

    /// <summary><c>a | b</c> over <c>bool?</c> operands — C#'s lifted <c>|</c> is
    /// exactly CQL's three-valued <c>or</c> (true dominates, null propagates).</summary>
    BoolOr,
}

/// <summary>
/// A binary operator application.
/// </summary>
internal sealed class CodeBinary : CodeExpression
{
    public CodeBinary(CodeBinaryOp op, CodeExpression left, CodeExpression right)
    {
        Type = op switch
        {
            CodeBinaryOp.Coalesce => ValidateCoalesce(left, right),
            CodeBinaryOp.Equal or CodeBinaryOp.NotEqual => typeof(bool),
            CodeBinaryOp.OrElse or CodeBinaryOp.AndAlso => ValidateLogical(op, left, right),
            CodeBinaryOp.BoolAnd or CodeBinaryOp.BoolOr => ValidateLiftedLogical(op, left, right),
            _ => throw new ArgumentException($"Unknown binary operator {op}.")
        };

        Op = op;
        Left = left;
        Right = right;
    }

    private static Type ValidateCoalesce(CodeExpression left, CodeExpression right)
    {
        if (!CodeTypeRules.IsNullAssignable(left.Type))
            throw new ArgumentException($"The left side of ?? must be nullable, not {left.Type}.");

        // T? ?? T yields T; otherwise the result keeps the left type (matching C# rules
        // closely enough for the shapes the builder produces).
        var unwrappedLeft = Nullable.GetUnderlyingType(left.Type) ?? left.Type;
        if (right.Type == unwrappedLeft)
            return unwrappedLeft;

        CodeTypeRules.ValidateAssignment(right, left.Type, "The right side of ??");
        return left.Type;
    }

    private static Type ValidateLogical(CodeBinaryOp op, CodeExpression left, CodeExpression right)
    {
        if (left.Type != typeof(bool) || right.Type != typeof(bool))
            throw new ArgumentException($"Operands of {op} must be bool, got {left.Type} and {right.Type}.");
        return typeof(bool);
    }

    private static Type ValidateLiftedLogical(CodeBinaryOp op, CodeExpression left, CodeExpression right)
    {
        if (left.Type != typeof(bool) && left.Type != typeof(bool?)
            || right.Type != typeof(bool) && right.Type != typeof(bool?))
            throw new ArgumentException($"Operands of {op} must be bool or bool?, got {left.Type} and {right.Type}.");

        // The lifted operator yields bool? as soon as either operand is nullable.
        return left.Type == typeof(bool?) || right.Type == typeof(bool?) ? typeof(bool?) : typeof(bool);
    }

    public CodeBinaryOp Op { get; }

    public CodeExpression Left { get; }

    public CodeExpression Right { get; }

    public override Type Type { get; }
}
