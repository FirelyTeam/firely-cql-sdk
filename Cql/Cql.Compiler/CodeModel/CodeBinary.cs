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

    /// <summary><c>a ^ b</c> over <c>bool?</c> operands — CQL's <c>xor</c>. Where lifted
    /// <c>&amp;</c>/<c>|</c> are SPECIAL three-valued operators in C# (a deciding operand wins
    /// over a null one), <c>^</c> is an ordinary null-propagating lifted operator: null if
    /// either operand is null. That is exactly what CQL's xor specifies.</summary>
    BoolXor,
}

/// <summary>
/// A binary operator application.
/// </summary>
internal sealed class CodeBinary : CodeExpression
{
    /// <summary>
    /// Whether the emitter prints this operator inline over its (linearized) children instead of
    /// hoisting the node itself into a local. Defined here, once, because the emitter needs the
    /// same answer in three separate structural walks — the linearize dispatch, the inline-only
    /// classification and the spine-node count — and a set spelled out three times is a set that
    /// drifts: <see cref="CodeBinaryOp.BoolXor"/> was added to the enum and to the printer but
    /// missed all three, so a lowered <c>xor</c> silently lost its inline form.
    /// </summary>
    public static bool PrintsInlineOverChildren(CodeBinaryOp op) =>
        op is CodeBinaryOp.Equal
            or CodeBinaryOp.NotEqual
            or CodeBinaryOp.Coalesce
            or CodeBinaryOp.BoolAnd
            or CodeBinaryOp.BoolOr
            or CodeBinaryOp.BoolXor;

    public CodeBinary(CodeBinaryOp op, CodeExpression left, CodeExpression right, string? originTag = null)
    {
        OriginTag = originTag;

        Type = op switch
        {
            CodeBinaryOp.Coalesce => ValidateCoalesce(left, right),
            CodeBinaryOp.Equal or CodeBinaryOp.NotEqual => typeof(bool),
            CodeBinaryOp.OrElse or CodeBinaryOp.AndAlso => ValidateLogical(op, left, right),
            CodeBinaryOp.BoolAnd or CodeBinaryOp.BoolOr or CodeBinaryOp.BoolXor => ValidateLiftedLogical(op, left, right),
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

    /// <summary>
    /// Short tag naming the CQL construct this operator was lowered from, including its source
    /// locator — e.g. <c>"CQL 'xor' (33:5-33:57)"</c>. Printed as a block comment before the
    /// expression so a reader can trace a native operator back to the CQL that produced it,
    /// exactly as <see cref="CodeConditional.OriginTag"/> does for the guarded forms. Null for
    /// the binaries the builder emits as plumbing (null checks, coalesces), which need no tracing.
    /// </summary>
    public string? OriginTag { get; }
}
