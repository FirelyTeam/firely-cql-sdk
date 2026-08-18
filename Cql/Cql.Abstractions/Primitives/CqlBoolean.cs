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

    /// <summary>
    /// Whether this is DEFINITELY true — CQL's <c>is true</c>, which is total: a null argument
    /// yields <see langword="false"/> rather than null (§4 Logical Specification).
    ///
    /// <para>This is the <see cref="bool"/> a branch condition needs, and it is why generated code
    /// does not have to convert back to <c>bool?</c> to ask the question: <c>x.IsTrue</c> says
    /// exactly what <c>(bool?)x ?? false</c> said, without leaving the type.</para>
    /// </summary>
    public bool IsTrue => _state == TrueState;

    /// <summary>
    /// Whether this is DEFINITELY false — CQL's <c>is false</c>, likewise total, so
    /// <see cref="Null"/> yields <see langword="false"/>. Note this is NOT the negation of
    /// <see cref="IsTrue"/>: both are <see langword="false"/> for <see cref="Null"/>.
    /// </summary>
    public bool IsFalse => _state == FalseState;

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

    /// <summary>
    /// CQL's <c>=</c>: null propagates, so comparing anything with <see cref="Null"/> yields
    /// <see cref="Null"/> rather than a definite answer — <c>null = null</c> is unknown, not true.
    /// Defined as the negation of <see cref="op_ExclusiveOr"/>, which is already exactly
    /// "differs from", so the two cannot drift apart.
    ///
    /// <para><b>This deliberately does NOT agree with <see cref="Equals(CqlBoolean)"/>, and the
    /// asymmetry is the point.</b> <c>Equals</c> answers "is this the same state", which is what a
    /// dictionary or a test assertion needs and must stay two-valued and reflexive;
    /// <c>==</c> answers CQL's question, which is three-valued. <c>SqlBoolean</c> — the type this
    /// one is modelled on — draws the line in the same place, for the same reason.</para>
    ///
    /// <para>Without these operators <c>a == b</c> would still compile, silently resolving through
    /// the implicit <c>bool?</c> conversion on both sides and answering <see langword="true"/> for
    /// two nulls. Declaring them replaces an accidental answer with the specified one.</para>
    /// </summary>
    /// <param name="left">The left operand.</param>
    /// <param name="right">The right operand.</param>
    public static CqlBoolean operator ==(CqlBoolean left, CqlBoolean right) => !(left ^ right);

    /// <summary>CQL's <c>!=</c>, which for Booleans is exactly <c>xor</c>: null propagates.
    /// See <see cref="op_Equality"/> for why this does not agree with
    /// <see cref="Equals(CqlBoolean)"/>.</summary>
    /// <param name="left">The left operand.</param>
    /// <param name="right">The right operand.</param>
    public static CqlBoolean operator !=(CqlBoolean left, CqlBoolean right) => left ^ right;

    /// <summary>
    /// State equality: two-valued and reflexive, so <see cref="Null"/> equals itself. This is what
    /// hashing and collection lookup require, and it is deliberately NOT what <c>==</c> means here
    /// — see <see cref="op_Equality"/>.
    /// </summary>
    /// <param name="other">The value to compare with.</param>
    /// <returns><see langword="true"/> when both hold the same state.</returns>
    public bool Equals(CqlBoolean other) => _state == other._state;

    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is CqlBoolean other && Equals(other);

    /// <inheritdoc/>
    public override int GetHashCode() => _state;

    /// <inheritdoc/>
    public override string ToString() =>
        _state switch { NullState => "null", FalseState => "false", _ => "true" };
}
