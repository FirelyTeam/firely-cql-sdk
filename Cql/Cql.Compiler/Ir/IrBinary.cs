/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Compiler.Ir;

/// <summary>
/// The binary operators the builder emits directly. CQL's arithmetic and logic go through
/// <c>ICqlOperators</c> calls, so only the handful of operators used for plumbing exist here.
/// </summary>
internal enum IrBinaryOp
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
}

/// <summary>
/// A binary operator application.
/// </summary>
internal sealed class IrBinary : IrExpression
{
    public IrBinary(IrBinaryOp op, IrExpression left, IrExpression right)
    {
        Type = op switch
        {
            IrBinaryOp.Coalesce => ValidateCoalesce(left, right),
            IrBinaryOp.Equal or IrBinaryOp.NotEqual => typeof(bool),
            IrBinaryOp.OrElse or IrBinaryOp.AndAlso => ValidateLogical(op, left, right),
            _ => throw new ArgumentException($"Unknown binary operator {op}.")
        };

        Op = op;
        Left = left;
        Right = right;
    }

    private static Type ValidateCoalesce(IrExpression left, IrExpression right)
    {
        if (!IrTypeRules.IsNullAssignable(left.Type))
            throw new ArgumentException($"The left side of ?? must be nullable, not {left.Type}.");

        // T? ?? T yields T; otherwise the result keeps the left type (matching C# rules
        // closely enough for the shapes the builder produces).
        var unwrappedLeft = Nullable.GetUnderlyingType(left.Type) ?? left.Type;
        if (right.Type == unwrappedLeft)
            return unwrappedLeft;

        IrTypeRules.ValidateAssignment(right, left.Type, "The right side of ??");
        return left.Type;
    }

    private static Type ValidateLogical(IrBinaryOp op, IrExpression left, IrExpression right)
    {
        if (left.Type != typeof(bool) || right.Type != typeof(bool))
            throw new ArgumentException($"Operands of {op} must be bool, got {left.Type} and {right.Type}.");
        return typeof(bool);
    }

    public IrBinaryOp Op { get; }

    public IrExpression Left { get; }

    public IrExpression Right { get; }

    public override Type Type { get; }
}
