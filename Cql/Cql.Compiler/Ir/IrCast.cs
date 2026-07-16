/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Compiler.Ir;

/// <summary>How an <see cref="IrCast"/> is printed.</summary>
internal enum IrCastKind
{
    /// <summary>An explicit cast, <c>(T)x</c> — throws at runtime when the value is not a T.
    /// Corresponds to ELM's strict <c>cast … as T</c> and to <c>Expression.Convert</c>.</summary>
    Cast,

    /// <summary>A safe cast, <c>x as T</c> — yields null when the value is not a T.
    /// Corresponds to ELM's non-strict <c>as</c> and to <c>Expression.TypeAs</c>.</summary>
    As,
}

/// <summary>
/// A type conversion. Replaces <c>UnaryExpression</c> (Convert/TypeAs) and the old
/// <c>ElmAsExpression</c> custom node.
///
/// <para>The constructor rejects conversions C# has no syntax for; the emitter additionally
/// routes casts through <c>object</c> when the printed operand's type is narrower than the
/// IR type (the CS0030 cases fixed in #1311).</para>
/// </summary>
internal sealed class IrCast : IrExpression
{
    public IrCast(IrExpression operand, Type type, IrCastKind kind)
    {
        if (kind == IrCastKind.As && !IrTypeRules.IsNullAssignable(type))
            throw new ArgumentException($"'as {type}' is not legal C#: the target of a safe cast must be a reference or nullable type.");
        if (!IrTypeRules.HasCSharpConversion(operand.Type, type) && operand.Type != typeof(object) && type != typeof(object))
            throw new ArgumentException($"No C# conversion exists from {operand.Type} to {type}.");

        Operand = operand;
        Type = type;
        Kind = kind;
    }

    public IrExpression Operand { get; }

    public IrCastKind Kind { get; }

    public override Type Type { get; }
}

/// <summary>
/// A runtime type test, printed as a C# <c>is</c> pattern. The emitter applies the rules from
/// #1311: nullable tested types are unwrapped, tuple types print in <c>ValueTuple&lt;…&gt;</c>
/// form, and value-typed operands are boxed so the pattern is always legal C#.
/// </summary>
internal sealed class IrTypeIs(IrExpression operand, Type testedType) : IrExpression
{
    public IrExpression Operand { get; } = operand;

    public Type TestedType { get; } = testedType;

    public override Type Type => typeof(bool);
}
