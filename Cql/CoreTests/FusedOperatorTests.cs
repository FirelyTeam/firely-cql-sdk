/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */


using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;

namespace CoreTests;

/// <summary>
/// Differential tests for the fused list operators (<c>WhereAny</c>, <c>WhereSelect</c>,
/// <c>SelectWhere</c>, <c>SelectDistinct</c>) the compiler emits in place of the four
/// producer/consumer pairs it can fuse (see issue #1484).
///
/// <para>Every test here compares a fused operator against the <em>literal composition</em> it
/// replaces — the composition is the specification. Three things are asserted, because all three
/// are observable from generated CQL: the result value, the trace of elements the lambdas were
/// invoked with (CQL's <c>Message</c> operator makes lambda invocation observable, and thrown
/// errors surface at the first failing element), and the concrete runtime type of the result
/// (<c>Distinct</c> hands back an array, <c>Where</c>/<c>Select</c> a <c>List</c>, and downstream
/// code can see the difference).</para>
///
/// <para>Note in particular that none of the fused operators short-circuits: in the composed
/// form the producer has already walked its entire source before the consumer looks at anything,
/// so an early exit would drop lambda invocations that the composition performs. The trace
/// assertions below are what pin that down.</para>
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class FusedOperatorTests
{
    private static ICqlOperators Operators() => FhirCqlContext.WithDataSource().Operators;

    // ---- sources ---------------------------------------------------------------------------

    private static List<string?>? NullSource => null;
    private static List<string?> Empty => new();
    private static List<string?> WithNulls => new() { "a", null, "bb", null, "ccc" };
    private static List<string?> Duplicates => new() { "x", "y", "x", null, "z", null, "y" };
    private static List<string?> AllFalse => new() { "a", "bb" };
    private static List<string?> OnlyNullKept => new() { null, "aaaa" };

    // ---- lambda recorder -------------------------------------------------------------------

    /// <summary>
    /// Records, in order, the elements each lambda was invoked with. <c>A</c> holds the predicate's
    /// trace and <c>B</c> the selector's; they are kept apart so that the interleaving nuance of
    /// the single-pass fused forms (see <see cref="WhereSelect_LambdaInterleavingIsTheOnlyDelta"/>)
    /// does not weaken the per-lambda assertions.
    /// </summary>
    private sealed class Trace
    {
        public List<string> A { get; } = new();
        public List<string> B { get; } = new();

        public string ForA => string.Join("|", A);
        public string ForB => string.Join("|", B);

        private static string Key(object? x) => x?.ToString() ?? "<null>";

        public Func<string?, bool?> Predicate(Func<string?, bool?> f) => x => { A.Add(Key(x)); return f(x); };
        public Func<int?, bool?> IntPredicate(Func<int?, bool?> f) => x => { A.Add(Key(x)); return f(x); };
        public Func<string?, int?> IntSelector(Func<string?, int?> f) => x => { B.Add(Key(x)); return f(x); };
        public Func<string?, string?> StringSelector(Func<string?, string?> f) => x => { B.Add(Key(x)); return f(x); };
    }

    private static bool? LenOdd(string? x) => x is null ? null : x.Length % 2 == 1;
    private static bool? KeepNullOnly(string? x) => x is null;
    private static bool? Never(string? x) => false;
    private static bool? AlwaysNull(string? x) => null;
    private static int? LenOf(string? x) => x?.Length;
    private static string? FirstChar(string? x) => x?.Substring(0, 1);
    private static bool? GreaterThanOne(int? x) => x is null ? null : x > 1;

    // ---- assertions ------------------------------------------------------------------------

    private static void AssertSameResult(object? expected, object? actual, string what)
    {
        if (expected is null || actual is null)
        {
            Assert.AreEqual(expected is null, actual is null, $"{what}: null-ness differs.");
            return;
        }

        if (expected is System.Collections.IEnumerable ee && actual is System.Collections.IEnumerable ae)
        {
            CollectionAssert.AreEqual(
                ee.Cast<object?>().ToList(),
                ae.Cast<object?>().ToList(),
                $"{what}: elements differ.");
            return;
        }

        Assert.AreEqual(expected, actual, what);
    }

    /// <summary>
    /// The composed form's concrete result type is part of its observable contract: <c>Distinct</c>
    /// returns an array while <c>Where</c>/<c>Select</c> return a <c>List</c>, and the generated C#
    /// passes these values on to operators that can tell them apart.
    /// </summary>
    private static void AssertSameResultType(object? expected, object? actual, string what) =>
        Assert.AreEqual(expected?.GetType(), actual?.GetType(), $"{what}: concrete result type differs.");

    #region WhereAny == Exists(Where(source, predicate))

    private static void AssertWhereAnyMatchesComposition(
        List<string?>? source,
        Func<string?, bool?> predicate,
        string what)
    {
        var op = Operators();

        var composedTrace = new Trace();
        var expected = op.Exists(op.Where(source, composedTrace.Predicate(predicate))!);

        var fusedTrace = new Trace();
        var actual = op.WhereAny(source, fusedTrace.Predicate(predicate));

        Assert.AreEqual(expected, actual, $"WhereAny/{what}: result differs.");
        Assert.AreEqual(composedTrace.ForA, fusedTrace.ForA, $"WhereAny/{what}: predicate trace differs.");
    }

    [TestMethod]
    public void WhereAny_NullSource_MatchesComposition() =>
        AssertWhereAnyMatchesComposition(NullSource, LenOdd, "null source");

    [TestMethod]
    public void WhereAny_EmptySource_MatchesComposition() =>
        AssertWhereAnyMatchesComposition(Empty, LenOdd, "empty");

    [TestMethod]
    public void WhereAny_NullElements_MatchesComposition() =>
        AssertWhereAnyMatchesComposition(WithNulls, LenOdd, "nulls in elements");

    [TestMethod]
    public void WhereAny_PredicateNeverTrue_MatchesComposition() =>
        AssertWhereAnyMatchesComposition(AllFalse, Never, "never true");

    [TestMethod]
    public void WhereAny_PredicateReturnsNull_MatchesComposition() =>
        AssertWhereAnyMatchesComposition(WithNulls, AlwaysNull, "predicate null");

    /// <summary>
    /// The composition keeps only the null element, and <c>Exists</c> ignores nulls — so the
    /// answer is false even though the predicate matched. The fused form must agree.
    /// </summary>
    [TestMethod]
    public void WhereAny_OnlyNullElementKept_MatchesComposition() =>
        AssertWhereAnyMatchesComposition(OnlyNullKept, KeepNullOnly, "keeps only null");

    /// <summary>
    /// <c>Exists</c> on its own stops at the first non-null element, but the composition has
    /// already run the predicate over the whole source inside <c>Where</c> before <c>Exists</c>
    /// is entered. The fused form must therefore keep evaluating past the first match.
    /// </summary>
    [TestMethod]
    public void WhereAny_DoesNotShortCircuitAfterTheFirstMatch()
    {
        var op = Operators();
        var trace = new Trace();

        var actual = op.WhereAny(WithNulls, trace.Predicate(_ => true));

        Assert.AreEqual(true, actual);
        Assert.AreEqual("a|<null>|bb|<null>|ccc", trace.ForA);
    }

    #endregion

    #region WhereSelect == Select(Where(source, predicate), selector)

    private static void AssertWhereSelectMatchesComposition(
        List<string?>? source,
        Func<string?, bool?> predicate,
        string what)
    {
        var op = Operators();

        var composedTrace = new Trace();
        var expected = op.Select(
            op.Where(source, composedTrace.Predicate(predicate)),
            composedTrace.IntSelector(LenOf));

        var fusedTrace = new Trace();
        var actual = op.WhereSelect(
            source,
            fusedTrace.Predicate(predicate),
            fusedTrace.IntSelector(LenOf));

        AssertSameResult(expected, actual, $"WhereSelect/{what}");
        AssertSameResultType(expected, actual, $"WhereSelect/{what}");
        Assert.AreEqual(composedTrace.ForA, fusedTrace.ForA, $"WhereSelect/{what}: predicate trace differs.");
        Assert.AreEqual(composedTrace.ForB, fusedTrace.ForB, $"WhereSelect/{what}: selector trace differs.");
    }

    [TestMethod]
    public void WhereSelect_NullSource_MatchesComposition() =>
        AssertWhereSelectMatchesComposition(NullSource, LenOdd, "null source");

    [TestMethod]
    public void WhereSelect_EmptySource_MatchesComposition() =>
        AssertWhereSelectMatchesComposition(Empty, LenOdd, "empty");

    [TestMethod]
    public void WhereSelect_NullElements_MatchesComposition() =>
        AssertWhereSelectMatchesComposition(WithNulls, LenOdd, "nulls in elements");

    [TestMethod]
    public void WhereSelect_PredicateReturnsNull_MatchesComposition() =>
        AssertWhereSelectMatchesComposition(WithNulls, AlwaysNull, "predicate null");

    [TestMethod]
    public void WhereSelect_OnlyNullElementKept_MatchesComposition() =>
        AssertWhereSelectMatchesComposition(OnlyNullKept, KeepNullOnly, "keeps only null");

    [TestMethod]
    public void WhereSelect_Duplicates_MatchesComposition() =>
        AssertWhereSelectMatchesComposition(Duplicates, LenOdd, "duplicates");

    /// <summary>
    /// The documented, accepted nuance of the single-pass fused forms: per element the predicate
    /// and the selector interleave (<c>p(x₁), f(x₁), p(x₂)…</c>) where the composition runs every
    /// <c>p</c> first and only then every <c>f</c>. While both lambdas run to completion no
    /// invocation is added or skipped — the per-lambda traces are identical, only their relative
    /// order changes. Once one of them throws the interleaving does become observable; see
    /// <see cref="WhereSelect_PredicateThrows_SelectorHasAlreadyRunForPrecedingElements"/>.
    /// </summary>
    [TestMethod]
    public void WhereSelect_LambdaInterleavingIsTheOnlyDelta()
    {
        var op = Operators();
        var source = new List<string?> { "a", "bbb" };

        var interleaved = new List<string>();
        op.WhereSelect(
            source,
            x => { interleaved.Add("p:" + x); return true; },
            x => { interleaved.Add("f:" + x); return x?.Length; });

        CollectionAssert.AreEqual(new[] { "p:a", "f:a", "p:bbb", "f:bbb" }, interleaved);

        var staged = new List<string>();
        op.Select(
            op.Where(source, x => { staged.Add("p:" + x); return true; }),
            x => { staged.Add("f:" + x); return x?.Length; });

        CollectionAssert.AreEqual(new[] { "p:a", "p:bbb", "f:a", "f:bbb" }, staged);

        // Same invocations, different order — that, and nothing else, is the delta.
        CollectionAssert.AreEquivalent(staged, interleaved);
    }

    #endregion

    #region SelectWhere == Where(Select(source, selector), predicate)

    private static void AssertSelectWhereMatchesComposition(List<string?>? source, string what)
    {
        var op = Operators();

        var composedTrace = new Trace();
        var expected = op.Where(
            op.Select(source, composedTrace.IntSelector(LenOf)),
            composedTrace.IntPredicate(GreaterThanOne));

        var fusedTrace = new Trace();
        var actual = op.SelectWhere(
            source,
            fusedTrace.IntSelector(LenOf),
            fusedTrace.IntPredicate(GreaterThanOne));

        AssertSameResult(expected, actual, $"SelectWhere/{what}");
        AssertSameResultType(expected, actual, $"SelectWhere/{what}");
        Assert.AreEqual(composedTrace.ForB, fusedTrace.ForB, $"SelectWhere/{what}: selector trace differs.");
        Assert.AreEqual(composedTrace.ForA, fusedTrace.ForA, $"SelectWhere/{what}: predicate trace differs.");
    }

    [TestMethod]
    public void SelectWhere_NullSource_MatchesComposition() =>
        AssertSelectWhereMatchesComposition(NullSource, "null source");

    [TestMethod]
    public void SelectWhere_EmptySource_MatchesComposition() =>
        AssertSelectWhereMatchesComposition(Empty, "empty");

    [TestMethod]
    public void SelectWhere_NullElements_MatchesComposition() =>
        AssertSelectWhereMatchesComposition(WithNulls, "nulls in elements");

    [TestMethod]
    public void SelectWhere_Duplicates_MatchesComposition() =>
        AssertSelectWhereMatchesComposition(Duplicates, "duplicates");

    /// <summary>
    /// The selector runs for every source element even when the predicate rejects the projection,
    /// exactly as <c>Select</c> would before <c>Where</c> ever sees the list.
    /// </summary>
    [TestMethod]
    public void SelectWhere_RunsTheSelectorForRejectedElementsToo()
    {
        var op = Operators();
        var trace = new Trace();

        var actual = op.SelectWhere(WithNulls, trace.IntSelector(LenOf), trace.IntPredicate(_ => false));

        AssertSameResult(new List<int?>(), actual, "SelectWhere/all rejected");
        Assert.AreEqual("a|<null>|bb|<null>|ccc", trace.ForB);
    }

    #endregion

    #region SelectDistinct == Distinct(Select(source, selector))

    private static void AssertSelectDistinctMatchesComposition(List<string?>? source, string what)
    {
        var op = Operators();

        var composedTrace = new Trace();
        var expected = op.Distinct(op.Select(source, composedTrace.StringSelector(FirstChar))!);

        var fusedTrace = new Trace();
        var actual = op.SelectDistinct(source, fusedTrace.StringSelector(FirstChar));

        AssertSameResult(expected, actual, $"SelectDistinct/{what}");
        AssertSameResultType(expected, actual, $"SelectDistinct/{what}");
        Assert.AreEqual(composedTrace.ForB, fusedTrace.ForB, $"SelectDistinct/{what}: selector trace differs.");
    }

    [TestMethod]
    public void SelectDistinct_NullSource_MatchesComposition() =>
        AssertSelectDistinctMatchesComposition(NullSource, "null source");

    [TestMethod]
    public void SelectDistinct_EmptySource_MatchesComposition() =>
        AssertSelectDistinctMatchesComposition(Empty, "empty");

    [TestMethod]
    public void SelectDistinct_NullElements_MatchesComposition() =>
        AssertSelectDistinctMatchesComposition(WithNulls, "nulls in elements");

    [TestMethod]
    public void SelectDistinct_DuplicatesAndNulls_MatchesComposition() =>
        AssertSelectDistinctMatchesComposition(Duplicates, "duplicates and nulls");

    /// <summary>
    /// A value-type projection is the case where <c>Distinct</c>'s internals (a
    /// <c>List&lt;object?&gt;</c> boxed through a shared comparer, cast back to an array) are most
    /// likely to diverge, so the fused form is checked for both value and concrete array type.
    /// </summary>
    [TestMethod]
    public void SelectDistinct_ValueTypeProjection_MatchesCompositionIncludingResultType()
    {
        var op = Operators();

        var composedTrace = new Trace();
        var expected = op.Distinct(op.Select(Duplicates, composedTrace.IntSelector(LenOf))!);

        var fusedTrace = new Trace();
        var actual = op.SelectDistinct(Duplicates, fusedTrace.IntSelector(LenOf));

        AssertSameResult(expected, actual, "SelectDistinct/value-type projection");
        AssertSameResultType(expected, actual, "SelectDistinct/value-type projection");
        Assert.AreEqual(composedTrace.ForB, fusedTrace.ForB);
    }

    /// <summary>
    /// <c>Distinct</c> keeps at most one null, and the fused form must not drop it or keep two.
    /// </summary>
    [TestMethod]
    public void SelectDistinct_KeepsExactlyOneNull()
    {
        var op = Operators();

        var actual = op.SelectDistinct(Duplicates, FirstChar);

        AssertSameResult(new[] { "x", "y", null, "z" }, actual, "SelectDistinct/one null");
    }

    #endregion

    #region Exception parity

    /// <summary>
    /// A lambda that throws must throw out of the fused operator at the same element, with the
    /// same exception, as it does out of the composition.
    /// </summary>
    private static (Type type, string message) Catch(Func<object?> f)
    {
        try
        {
            f();
            return (typeof(void), "<no throw>");
        }
        catch (Exception e)
        {
            return (e.GetType(), e.Message);
        }
    }

    [TestMethod]
    public void WhereAny_PredicateThrows_MatchesComposition()
    {
        var op = Operators();
        Func<string?, bool?> boom = x => x == "bb" ? throw new InvalidOperationException("boom-" + x) : true;

        var expected = Catch(() => op.Exists(op.Where(WithNulls, boom)!));
        var actual = Catch(() => op.WhereAny(WithNulls, boom));

        Assert.AreEqual(expected, actual);
        Assert.AreEqual(typeof(InvalidOperationException), actual.type);
    }

    [TestMethod]
    public void WhereSelect_PredicateThrows_MatchesComposition()
    {
        var op = Operators();
        Func<string?, bool?> boom = x => x == "bb" ? throw new InvalidOperationException("boom-" + x) : true;

        var expected = Catch(() => op.Select(op.Where(WithNulls, boom), LenOf));
        var actual = Catch(() => op.WhereSelect(WithNulls, boom, LenOf));

        Assert.AreEqual(expected, actual);
        Assert.AreEqual(typeof(InvalidOperationException), actual.type);
    }

    [TestMethod]
    public void SelectWhere_SelectorThrows_MatchesComposition()
    {
        var op = Operators();
        Func<string?, int?> boom = x => x == "bb" ? throw new InvalidOperationException("boom-" + x) : x?.Length;

        var expected = Catch(() => op.Where(op.Select(WithNulls, boom), GreaterThanOne));
        var actual = Catch(() => op.SelectWhere(WithNulls, boom, GreaterThanOne));

        Assert.AreEqual(expected, actual);
        Assert.AreEqual(typeof(InvalidOperationException), actual.type);
    }

    [TestMethod]
    public void SelectDistinct_SelectorThrows_MatchesComposition()
    {
        var op = Operators();
        Func<string?, string?> boom = x => x == "bb" ? throw new InvalidOperationException("boom-" + x) : x;

        var expected = Catch(() => op.Distinct(op.Select(WithNulls, boom)!));
        var actual = Catch(() => op.SelectDistinct(WithNulls, boom));

        Assert.AreEqual(expected, actual);
        Assert.AreEqual(typeof(InvalidOperationException), actual.type);
    }

    #endregion

    #region Interleaving is observable when a lambda throws

    /// <summary>
    /// The exception itself is the same, but the work done before it is not. The composition runs
    /// the predicate over the whole source before the selector sees anything, so a predicate that
    /// throws leaves the selector uninvoked; the single-pass fused form has already projected every
    /// element that passed the predicate ahead of the failing one, together with whatever side
    /// effects that projection carries. This test pins the <em>fused</em> behaviour — the behaviour
    /// generated code gets — deliberately, rather than asserting parity that does not hold here.
    /// </summary>
    [TestMethod]
    public void WhereSelect_PredicateThrows_SelectorHasAlreadyRunForPrecedingElements()
    {
        var op = Operators();
        var source = new List<string?> { "a", "b" };
        Func<string?, bool?> boom = x => x == "b" ? throw new InvalidOperationException("boom-" + x) : true;

        var fused = new List<string>();
        Func<string?, int?> fusedSelector = x => { fused.Add("f:" + x); return x?.Length; };
        Catch(() => op.WhereSelect(source, boom, fusedSelector));

        var composed = new List<string>();
        Func<string?, int?> composedSelector = x => { composed.Add("f:" + x); return x?.Length; };
        Catch(() => op.Select(op.Where(source, boom), composedSelector));

        CollectionAssert.AreEqual(new[] { "f:a" }, fused);
        CollectionAssert.AreEqual(Array.Empty<string>(), composed);
    }

    /// <summary>Symmetric to <see cref="WhereSelect_PredicateThrows_SelectorHasAlreadyRunForPrecedingElements"/>:
    /// a selector that throws leaves the composition's predicate uninvoked, while the fused form has
    /// already tested every projection produced ahead of the failing element.</summary>
    [TestMethod]
    public void SelectWhere_SelectorThrows_PredicateHasAlreadyRunForPrecedingElements()
    {
        var op = Operators();
        var source = new List<string?> { "a", "b" };
        Func<string?, int?> boom = x => x == "b" ? throw new InvalidOperationException("boom-" + x) : x?.Length;

        var fused = new List<string>();
        Func<int?, bool?> fusedPredicate = x => { fused.Add("p:" + x); return true; };
        Catch(() => op.SelectWhere(source, boom, fusedPredicate));

        var composed = new List<string>();
        Func<int?, bool?> composedPredicate = x => { composed.Add("p:" + x); return true; };
        Catch(() => op.Where(op.Select(source, boom), composedPredicate));

        CollectionAssert.AreEqual(new[] { "p:1" }, fused);
        CollectionAssert.AreEqual(Array.Empty<string>(), composed);
    }

    /// <summary>
    /// When both lambdas would throw, on different elements, the exception that surfaces is itself
    /// no longer shared: the composition finishes the predicate over the whole source before the
    /// selector sees anything, so the predicate's throw on the later element wins, while the
    /// single-pass fused form reaches the selector's throw on the earlier element first. This is
    /// the one case where the two forms differ in more than the work done before the failure.
    /// </summary>
    [TestMethod]
    public void WhereSelect_BothLambdasThrow_FusedSurfacesTheSelectorsThrowFromTheEarlierElement()
    {
        var op = Operators();
        var source = new List<string?> { "a", "b" };
        Func<string?, bool?> predicate = x => x == "b" ? throw new InvalidOperationException("predicate-boom") : true;
        Func<string?, int?> selector = x => x == "a" ? throw new InvalidOperationException("selector-boom") : x?.Length;

        var composed = Catch(() => op.Select(op.Where(source, predicate), selector));
        var fused = Catch(() => op.WhereSelect(source, predicate, selector));

        Assert.AreEqual(typeof(InvalidOperationException), composed.type);
        Assert.AreEqual("predicate-boom", composed.message, "the composition never reaches the selector.");
        Assert.AreEqual(typeof(InvalidOperationException), fused.type);
        Assert.AreEqual("selector-boom", fused.message, "the fused pass reaches the selector's throw first.");
    }

    /// <summary>Symmetric to <see cref="WhereSelect_BothLambdasThrow_FusedSurfacesTheSelectorsThrowFromTheEarlierElement"/>:
    /// the composition finishes the selector over the whole source first, so the selector's throw on
    /// the later element wins, while the fused form reaches the predicate's throw on the projection
    /// of the earlier element first.</summary>
    [TestMethod]
    public void SelectWhere_BothLambdasThrow_FusedSurfacesThePredicatesThrowFromTheEarlierElement()
    {
        var op = Operators();
        var source = new List<string?> { "a", "bb" };
        Func<string?, int?> selector = x => x == "bb" ? throw new InvalidOperationException("selector-boom") : x?.Length;
        Func<int?, bool?> predicate = x => x == 1 ? throw new InvalidOperationException("predicate-boom") : true;

        var composed = Catch(() => op.Where(op.Select(source, selector), predicate));
        var fused = Catch(() => op.SelectWhere(source, selector, predicate));

        Assert.AreEqual(typeof(InvalidOperationException), composed.type);
        Assert.AreEqual("selector-boom", composed.message, "the composition never reaches the predicate.");
        Assert.AreEqual(typeof(InvalidOperationException), fused.type);
        Assert.AreEqual("predicate-boom", fused.message, "the fused pass reaches the predicate's throw first.");
    }

    #endregion
}
