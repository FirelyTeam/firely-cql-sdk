/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

namespace Hl7.Cql.Primitives;

/// <summary>
/// CQL's three-valued Boolean, as a value type that carries its own null state so that C#'s
/// <c>&amp;&amp;</c> and <c>||</c> can be applied to it.
///
/// <para>This exists for one reason: <c>bool?</c> cannot short-circuit. C# defines
/// <c>&amp;&amp;</c>/<c>||</c> only for <c>bool</c> and for types supplying <c>operator true</c>
/// and <c>operator false</c>, and those cannot be lifted over <see cref="Nullable{T}"/> — nor
/// retrofitted with extension operators, which the compiler accepts as declarations but will not
/// use to synthesise <c>&amp;&amp;</c>. Generated CQL therefore had to express short-circuiting as
/// branching control flow. Over this type it is an expression again:
/// <c>left &amp;&amp; right</c>.</para>
///
/// <para><b>The skip rules fall out of the language, exactly as CQL specifies them.</b>
/// <see cref="op_False"/> answers "is this definitely false", so <c>&amp;&amp;</c> skips its right
/// operand only for a <see langword="false"/> left operand — never for <see cref="Null"/>, because
/// <c>null and false</c> is <c>false</c> and the right operand still matters. Likewise
/// <see cref="op_True"/> answers "is this definitely true", so <c>||</c> skips only on
/// <see langword="true"/>. The rule that a null operand must not short-circuit is therefore
/// structural here rather than a convention a future change could quietly break.</para>
///
/// <para>Deliberately <b>not</b> marked <see cref="CqlPrimitiveTypeAttribute"/>: CQL's
/// <c>Boolean</c> continues to map to <c>bool?</c> throughout the type system, bindings and
/// generated signatures. This type appears only inside generated expressions, with implicit
/// conversions at each end, so adopting it changes no public surface.</para>
///
/// <para>The same shape as <c>System.Data.SqlTypes.SqlBoolean</c>, which does this for SQL's
/// three-valued logic; CQL's tables (spec §9.B) are the same Kleene logic.</para>
/// </summary>
public readonly struct CqlBoolean : IEquatable<CqlBoolean>
{
    // 0 = null, 1 = false, 2 = true. One byte, so no larger than bool? and never heap-allocated.
    private const byte NullState = 0;
    private const byte FalseState = 1;
    private const byte TrueState = 2;

    private readonly byte _state;

    private CqlBoolean(byte state) => _state = state;

    /// <summary>The unknown value — CQL's <c>null</c> Boolean.</summary>
    public static readonly CqlBoolean Null = new(NullState);

    /// <summary>The <see langword="false"/> value.</summary>
    public static readonly CqlBoolean False = new(FalseState);

    /// <summary>The <see langword="true"/> value.</summary>
    public static readonly CqlBoolean True = new(TrueState);

    /// <summary>Whether this is a known value rather than <see cref="Null"/>.</summary>
    public bool HasValue => _state != NullState;

    /// <summary>Converts a <see cref="bool"/> to its CQL counterpart.</summary>
    /// <param name="value">The value to convert.</param>
    public static implicit operator CqlBoolean(bool value) => value ? True : False;

    /// <summary>Converts a <see cref="bool"/>? to its CQL counterpart, mapping null to
    /// <see cref="Null"/>.</summary>
    /// <param name="value">The value to convert.</param>
    public static implicit operator CqlBoolean(bool? value) =>
        value is null ? Null : value.Value ? True : False;

    /// <summary>Converts back to <see cref="bool"/>?, mapping <see cref="Null"/> to null.</summary>
    /// <param name="value">The value to convert.</param>
    public static implicit operator bool?(CqlBoolean value) =>
        value._state == NullState ? null : value._state == TrueState;

    /// <summary>CQL's <c>and</c>: false dominates, otherwise null propagates.</summary>
    /// <param name="left">The left operand.</param>
    /// <param name="right">The right operand.</param>
    public static CqlBoolean operator &(CqlBoolean left, CqlBoolean right) =>
        left._state == FalseState || right._state == FalseState ? False
        : left._state == NullState || right._state == NullState ? Null
        : True;

    /// <summary>CQL's <c>or</c>: true dominates, otherwise null propagates.</summary>
    /// <param name="left">The left operand.</param>
    /// <param name="right">The right operand.</param>
    public static CqlBoolean operator |(CqlBoolean left, CqlBoolean right) =>
        left._state == TrueState || right._state == TrueState ? True
        : left._state == NullState || right._state == NullState ? Null
        : False;

    /// <summary>CQL's <c>xor</c>: null propagates, so a null operand decides the result on its
    /// own — unlike <c>and</c>/<c>or</c>, where a deciding value wins over null.</summary>
    /// <param name="left">The left operand.</param>
    /// <param name="right">The right operand.</param>
    public static CqlBoolean operator ^(CqlBoolean left, CqlBoolean right) =>
        left._state == NullState || right._state == NullState ? Null
        : left._state == right._state ? False
        : True;

    /// <summary>CQL's <c>not</c>: null stays null.</summary>
    /// <param name="value">The operand.</param>
    public static CqlBoolean operator !(CqlBoolean value) =>
        value._state switch { NullState => Null, FalseState => True, _ => False };

    /// <summary>
    /// Whether this is DEFINITELY true. Together with <see cref="op_False"/> this is what enables
    /// <c>&amp;&amp;</c> and <c>||</c> on this type, and it is what makes <c>||</c> skip its right
    /// operand for a true left operand and <b>not</b> for <see cref="Null"/>.
    /// </summary>
    /// <param name="value">The operand.</param>
    public static bool operator true(CqlBoolean value) => value._state == TrueState;

    /// <summary>
    /// Whether this is DEFINITELY false — the condition under which <c>&amp;&amp;</c> skips its
    /// right operand. <see cref="Null"/> is not definitely false, so it never short-circuits,
    /// which is precisely CQL's rule (<c>null and false</c> is <c>false</c>).
    /// </summary>
    /// <param name="value">The operand.</param>
    public static bool operator false(CqlBoolean value) => value._state == FalseState;

    /// <inheritdoc/>
    public bool Equals(CqlBoolean other) => _state == other._state;

    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is CqlBoolean other && Equals(other);

    /// <inheritdoc/>
    public override int GetHashCode() => _state;

    /// <inheritdoc/>
    public override string ToString() =>
        _state switch { NullState => "null", FalseState => "false", _ => "true" };
}
