/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;

namespace CoreTests;

/// <summary>
/// <see cref="CqlBoolean"/>'s three-valued tables, and — the reason the type exists — which operand
/// C#'s <c>&amp;&amp;</c>/<c>||</c> actually evaluate over it.
///
/// <para>The tables are checked against <see cref="ICqlOperators"/> as the oracle, exactly as the
/// generated-code truth tables are, so the type cannot drift from the runtime implementation the
/// rest of the SDK is verified against.</para>
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class CqlBooleanTests
{
    private static readonly bool?[] Values = [true, false, null];

    private static ICqlOperators Operators => Hl7.Cql.Fhir.FhirCqlContext.ForBundle().Operators;

    [TestMethod]
    public void And_MatchesRuntimeOperator()
    {
        foreach (var left in Values)
        foreach (var right in Values)
        {
            bool? actual = (CqlBoolean)left & (CqlBoolean)right;
            Assert.AreEqual(Operators.And(left, right), actual, $"{left} and {right}");
        }
    }

    [TestMethod]
    public void Or_MatchesRuntimeOperator()
    {
        foreach (var left in Values)
        foreach (var right in Values)
        {
            bool? actual = (CqlBoolean)left | (CqlBoolean)right;
            Assert.AreEqual(Operators.Or(left, right), actual, $"{left} or {right}");
        }
    }

    [TestMethod]
    public void Xor_MatchesRuntimeOperator()
    {
        foreach (var left in Values)
        foreach (var right in Values)
        {
            bool? actual = (CqlBoolean)left ^ (CqlBoolean)right;
            Assert.AreEqual(Operators.Xor(left, right), actual, $"{left} xor {right}");
        }
    }

    [TestMethod]
    public void Not_MatchesRuntimeOperator()
    {
        foreach (var value in Values)
        {
            bool? actual = !(CqlBoolean)value;
            Assert.AreEqual(Operators.Not(value), actual, $"not {value}");
        }
    }

    /// <summary>
    /// <c>implies</c> has no C# operator, but <c>!left || right</c> IS Kleene implication — and it
    /// short-circuits on exactly the operand the spec permits skipping.
    /// </summary>
    [TestMethod]
    public void NotLeftOrRight_MatchesImplies()
    {
        foreach (var left in Values)
        foreach (var right in Values)
        {
            bool? actual = !(CqlBoolean)left || (CqlBoolean)right;
            Assert.AreEqual(Operators.Implies(left, right), actual, $"{left} implies {right}");
        }
    }

    /// <summary>
    /// The point of the type. <c>operator false</c> means "definitely false", so <c>&amp;&amp;</c>
    /// skips its right operand for a false left operand and — critically — NOT for null:
    /// <c>null and false</c> is <c>false</c>, so the right operand still matters. The skip rule is
    /// therefore structural, not a convention the emitter has to remember.
    /// </summary>
    [TestMethod]
    public void AndAlso_SkipsOnlyOnFalse()
    {
        Assert.AreEqual("", EvaluatedRightOperandsOfAnd(false), "false decides 'and'; the right operand must not be evaluated.");
        Assert.AreEqual("right", EvaluatedRightOperandsOfAnd(true), "true does not decide 'and'.");
        Assert.AreEqual("right", EvaluatedRightOperandsOfAnd(null), "null must NOT short-circuit 'and' — null and false is false.");
    }

    [TestMethod]
    public void OrElse_SkipsOnlyOnTrue()
    {
        Assert.AreEqual("", EvaluatedRightOperandsOfOr(true), "true decides 'or'; the right operand must not be evaluated.");
        Assert.AreEqual("right", EvaluatedRightOperandsOfOr(false), "false does not decide 'or'.");
        Assert.AreEqual("right", EvaluatedRightOperandsOfOr(null), "null must NOT short-circuit 'or' — null or false is null.");
    }

    /// <summary><c>!left || right</c> skips on a FALSE left operand, which is implies' rule.</summary>
    [TestMethod]
    public void NotLeftOrRight_SkipsOnlyOnFalseLeft()
    {
        Assert.AreEqual("", EvaluatedRightOperandsOfImplies(false), "false decides 'implies' (false implies X is true).");
        Assert.AreEqual("right", EvaluatedRightOperandsOfImplies(true), "true does not decide 'implies' — the result IS the right operand.");
        Assert.AreEqual("right", EvaluatedRightOperandsOfImplies(null), "null must NOT short-circuit 'implies'.");
    }

    /// <summary>
    /// And the counter-case that proves these are real short-circuits rather than a lucky table:
    /// the non-short-circuiting <c>&amp;</c> always evaluates both operands, even where
    /// <c>&amp;&amp;</c> skips.
    /// </summary>
    [TestMethod]
    public void NonShortCircuitingAnd_AlwaysEvaluatesBoth()
    {
        var evaluated = new List<string>();
        _ = (CqlBoolean)false & Track(evaluated, CqlBoolean.True);
        Assert.AreEqual("right", string.Join(",", evaluated), "& is not short-circuiting; only && is.");
    }

    [TestMethod]
    public void Conversions_RoundTrip()
    {
        foreach (var value in Values)
        {
            bool? roundTripped = (CqlBoolean)value;
            Assert.AreEqual(value, roundTripped, $"{value} must survive a round trip through CqlBoolean.");
        }

        Assert.IsFalse(CqlBoolean.Null.HasValue);
        Assert.IsTrue(CqlBoolean.True.HasValue);
        Assert.IsTrue(CqlBoolean.False.HasValue);
        Assert.AreEqual("null", CqlBoolean.Null.ToString());
    }

    /// <summary>The default value of the struct is the unknown value, not false.</summary>
    [TestMethod]
    public void Default_IsNull()
    {
        Assert.AreEqual(CqlBoolean.Null, default(CqlBoolean));
        Assert.IsNull((bool?)default(CqlBoolean));
    }

    private static string EvaluatedRightOperandsOfAnd(bool? left)
    {
        var evaluated = new List<string>();
        _ = (CqlBoolean)left && Track(evaluated, CqlBoolean.True);
        return string.Join(",", evaluated);
    }

    private static string EvaluatedRightOperandsOfOr(bool? left)
    {
        var evaluated = new List<string>();
        _ = (CqlBoolean)left || Track(evaluated, CqlBoolean.True);
        return string.Join(",", evaluated);
    }

    private static string EvaluatedRightOperandsOfImplies(bool? left)
    {
        var evaluated = new List<string>();
        _ = !(CqlBoolean)left || Track(evaluated, CqlBoolean.True);
        return string.Join(",", evaluated);
    }

    /// <summary>Records that the right operand was evaluated, then returns it.</summary>
    private static CqlBoolean Track(List<string> evaluated, CqlBoolean value)
    {
        evaluated.Add("right");
        return value;
    }
}
