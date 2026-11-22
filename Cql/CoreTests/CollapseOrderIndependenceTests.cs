/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;

namespace CoreTests;

/// <summary>
/// Two intervals can have a boundary at the same point, one written open and one closed, as Interval(1, 7] and
/// Interval[2, 7] do. Which of them comes first in the list does not decide how <c>collapse</c> writes that
/// boundary: "The collapse operator returns the unique set of intervals that completely covers the ranges
/// present in the given list of intervals. In other words, adjacent intervals within a sorted list are merged
/// if they either overlap or meet." (CQL 1.5.3 Errata 2, Appendix B - CQL Reference, section "Collapse").
/// The specification does not say which form the result has; this SDK gives the closed one. The tests cover
/// lists without a per argument whose boundaries have values of one precision.
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class CollapseOrderIndependenceTests
{
    private static ICqlOperators Sut() => FhirCqlContext.WithDataSource().Operators;

    private static CqlInterval<int?> Ints(string notation)
    {
        // "(1, 7]" and the like.
        var parts = notation[1..^1].Split(',');
        return new(int.Parse(parts[0]), int.Parse(parts[1]), notation[0] == '[', notation[^1] == ']');
    }

    private static string Show<T>(IEnumerable<CqlInterval<T?>?>? intervals) =>
        intervals is null ? "null" : string.Join(" ", intervals.Select(i => i?.ToString() ?? "null"));

    private static IEnumerable<T[]> Permutations<T>(T[] items)
    {
        if (items.Length <= 1)
        {
            yield return items;
            yield break;
        }

        for (var i = 0; i < items.Length; i++)
            foreach (var rest in Permutations(items.Where((_, j) => j != i).ToArray()))
                yield return [items[i], .. rest];
    }

    private static void AssertEveryOrderGives<T>(
        string expected,
        Func<IEnumerable<CqlInterval<T?>?>, IEnumerable<CqlInterval<T?>?>?> collapse,
        params CqlInterval<T?>?[] intervals)
    {
        foreach (var order in Permutations(intervals))
            Assert.AreEqual(expected, Show(collapse(order)), $"collapse {{ {Show(order)} }}");
    }

    #region The same boundary point, open in one interval and closed in another

    [TestMethod]
    [DataRow("[2, 7]", "(1, 7]", "[2, 7]")]            // same range, low written in two ways
    [DataRow("[1, 7]", "[1, 8)", "[1, 7]")]            // same range, high written in two ways
    [DataRow("[2, 7]", "(1, 8)", "[2, 7]")]            // same range, both written in two ways
    [DataRow("[2, 7]", "(1, 5]", "[2, 7]")]            // same low, the open one ends earlier
    [DataRow("[2, 7]", "(1, 7]", "[2, 5]")]            // same low, the closed one ends earlier
    [DataRow("[1, 7]", "[1, 8)", "[3, 7]")]            // same high, the closed one starts later
    [DataRow("[1, 7]", "[1, 7]", "[3, 8)")]            // same high, the open one starts later
    [DataRow("[2, 7]", "(1, 4]", "[2, 3]", "[4, 8)", "[6, 7]")]
    public void Collapse_IntegerBoundaryWrittenOpenAndClosed_GivesTheClosedFormInEveryOrder(string expected, params string[] intervals) =>
        AssertEveryOrderGives(expected, order => Sut().Collapse(order, null), intervals.Select(Ints).ToArray<CqlInterval<int?>?>());

    [TestMethod]
    public void Collapse_LongBoundaryWrittenOpenAndClosed_GivesTheClosedFormInEveryOrder() =>
        AssertEveryOrderGives<long?>("[2, 7]", order => Sut().Collapse(order, null),
            new CqlInterval<long?>(1L, 7L, false, true),
            new CqlInterval<long?>(2L, 8L, true, false));

    [TestMethod]
    public void Collapse_DecimalBoundaryWrittenOpenAndClosed_GivesTheClosedFormInEveryOrder() =>
        // The Decimal step is 10^-8, so Interval(1.0, 7.0] starts at 1.00000001.
        AssertEveryOrderGives<decimal?>("[1.00000001, 7.0]", order => Sut().Collapse(order, null),
            new CqlInterval<decimal?>(1.0m, 7.0m, false, true),
            new CqlInterval<decimal?>(1.00000001m, 5.0m, true, true));

    [TestMethod]
    public void Collapse_DateBoundaryWrittenOpenAndClosed_GivesTheClosedFormInEveryOrder() =>
        AssertEveryOrderGives<CqlDate?>("[2026-01-02, 2026-01-31]", order => Sut().Collapse(order, null),
            new CqlInterval<CqlDate?>(new CqlDate(2026, 1, 1), new CqlDate(2026, 1, 31), false, true),
            new CqlInterval<CqlDate?>(new CqlDate(2026, 1, 2), new CqlDate(2026, 2, 1), true, false));

    [TestMethod]
    public void Collapse_DateTimeBoundaryWrittenOpenAndClosed_GivesTheClosedFormInEveryOrder()
    {
        static CqlDateTime at(int hour, int minute = 0, int second = 0, int millisecond = 0) =>
            new(2026, 1, 1, hour, minute, second, millisecond, 0, 0);

        // The first interval includes the second. Its high boundary is written open; the second has the same
        // point closed, so the result takes that form.
        AssertEveryOrderGives<CqlDateTime?>(
            new CqlInterval<CqlDateTime?>(at(1), at(4, 59, 59, 999), true, true).ToString()!,
            order => Sut().Collapse(order, null),
            new CqlInterval<CqlDateTime?>(at(1), at(5), true, false),
            new CqlInterval<CqlDateTime?>(at(2), at(4, 59, 59, 999), true, true));
    }

    [TestMethod]
    public void Collapse_TimeBoundaryWrittenOpenAndClosed_GivesTheClosedFormInEveryOrder() =>
        AssertEveryOrderGives<CqlTime?>(
            new CqlInterval<CqlTime?>(new CqlTime(1, 0, 0, 1, null, null), new CqlTime(5, 0, 0, 0, null, null), true, true).ToString()!,
            order => Sut().Collapse(order, null),
            new CqlInterval<CqlTime?>(new CqlTime(1, 0, 0, 0, null, null), new CqlTime(5, 0, 0, 0, null, null), false, true),
            new CqlInterval<CqlTime?>(new CqlTime(1, 0, 0, 1, null, null), new CqlTime(3, 0, 0, 0, null, null), true, true));

    [TestMethod]
    public void Collapse_QuantityBoundaryWrittenOpenAndClosed_GivesTheClosedFormInEveryOrder() =>
        // The Quantity step is that of Decimal, 10^-8, in the unit of the boundary.
        AssertEveryOrderGives<CqlQuantity?>(
            new CqlInterval<CqlQuantity?>(new CqlQuantity(1.00000001m, "g"), new CqlQuantity(7.0m, "g"), true, true).ToString()!,
            order => Sut().Collapse(order, null),
            new CqlInterval<CqlQuantity?>(new CqlQuantity(1.0m, "g"), new CqlQuantity(7.0m, "g"), false, true),
            new CqlInterval<CqlQuantity?>(new CqlQuantity(1.00000001m, "g"), new CqlQuantity(5.0m, "g"), true, true));

    [TestMethod]
    public void Collapse_QuantityBoundaryAtTheSamePointInAnotherUnit_StaysAsWritten()
    {
        // 999.99999 'mg' is the point before 1.0 'g' in steps of 10^-8 'g', so the first two intervals end at
        // the same point. The step of a Quantity is in the unit of the boundary: written in 'mg', that point no
        // longer meets the interval starting at 0.001 'kg'. The boundary of the including interval is kept, and
        // the three intervals collapse into one in every order.
        static CqlQuantity q(decimal value, string unit) => new(value, unit);

        AssertEveryOrderGives<CqlQuantity?>(
            new CqlInterval<CqlQuantity?>(q(0.0m, "g"), q(0.002m, "kg"), true, true).ToString()!,
            order => Sut().Collapse(order, null),
            new CqlInterval<CqlQuantity?>(q(0.0m, "g"), q(1.0m, "g"), true, false),
            new CqlInterval<CqlQuantity?>(q(0.5m, "g"), q(999.99999m, "mg"), true, true),
            new CqlInterval<CqlQuantity?>(q(0.001m, "kg"), q(0.002m, "kg"), true, true));
    }

    [TestMethod]
    public void Collapse_IntegerBoundaryNextToTheTypeExtremes_GivesTheClosedFormInEveryOrder()
    {
        AssertEveryOrderGives<int?>($"[1, {int.MaxValue - 1}]", order => Sut().Collapse(order, null),
            new CqlInterval<int?>(1, int.MaxValue, true, false),
            new CqlInterval<int?>(1, int.MaxValue - 1, true, true));
        AssertEveryOrderGives<int?>($"[{int.MinValue + 1}, 5]", order => Sut().Collapse(order, null),
            new CqlInterval<int?>(int.MinValue, 5, false, true),
            new CqlInterval<int?>(int.MinValue + 1, 5, true, true));
    }

    #endregion

    #region Boundaries that no other interval has at the same point stay as written

    [TestMethod]
    [DataRow("(1, 7]", "(1, 5]", "[4, 7]")]            // the open low is the only one at 2
    [DataRow("[1, 8)", "[1, 5]", "[4, 8)")]            // the open high is the only one at 7
    [DataRow("(1, 8)", "(1, 8)", "[3, 5]")]            // the including interval is returned as written
    [DataRow("(1, 8)", "(1, 5)", "(3, 8)")]            // both intervals have the point open: nothing to choose
    [DataRow("(1, 5) [6, 9)", "(1, 5)", "[6, 9)")]     // intervals that are not merged are not rewritten
    public void Collapse_IntegerBoundaryWithoutAClosedEquivalent_StaysAsWritten(string expected, params string[] intervals) =>
        AssertEveryOrderGives(expected, order => Sut().Collapse(order, null), intervals.Select(Ints).ToArray<CqlInterval<int?>?>());

    [TestMethod]
    public void Collapse_SingleOpenInterval_IsReturnedAsWritten() =>
        // "If the list of intervals contains a single interval, the result is a list with that interval."
        // (same section)
        Assert.AreEqual("(1, 7)", Show(Sut().Collapse([Ints("(1, 7)")], null)));

    #endregion

    #region Every order of every small list

    /// <summary>
    /// Collapses every list of two or three intervals taken from all Integer intervals with boundaries from 1 to
    /// 6 and every combination of open and closed boundaries, in every order of the list, and requires one
    /// result per list, written the same way in every order. The result must also cover exactly the points the list covers, in the fewest intervals.
    /// </summary>
    [TestMethod]
    public void Collapse_EveryOrderOfEverySmallIntegerList_GivesTheSameResult()
    {
        var pool = new List<CqlInterval<int?>>();
        for (var low = 1; low <= 4; low++)
            for (var high = low + 1; high <= 6; high++)
                foreach (var lowClosed in new[] { true, false })
                    foreach (var highClosed in new[] { true, false })
                    {
                        var first = lowClosed ? low : low + 1;
                        var last = highClosed ? high : high - 1;
                        if (first <= last)
                            pool.Add(new(low, high, lowClosed, highClosed));
                    }

        static IEnumerable<int> points(CqlInterval<int?> i) =>
            Enumerable.Range(i.low!.Value + (i.lowClosed == true ? 0 : 1),
                i.high!.Value - i.low!.Value + 1 - (i.lowClosed == true ? 0 : 1) - (i.highClosed == true ? 0 : 1));

        var sut = Sut();
        var failures = new List<string>();
        var lists = 0;
        for (var a = 0; a < pool.Count; a++)
            for (var b = a + 1; b < pool.Count; b++)
                for (var c = b; c < pool.Count; c++)
                {
                    CqlInterval<int?>?[] list = c == b ? [pool[a], pool[b]] : [pool[a], pool[b], pool[c]];
                    lists++;

                    var results = Permutations(list).Select(order => sut.Collapse(order, null)!.ToList()).ToList();
                    if (results.Select(Show).Distinct().Count() > 1)
                    {
                        failures.Add($"{{ {Show(list)} }} gives {string.Join(" and ", results.Select(Show).Distinct())}");
                        continue;
                    }

                    // The points covered are those of the input, and no two result intervals overlap or meet.
                    var expectedPoints = list.SelectMany(i => points(i!)).Distinct().Order().ToList();
                    var actualPoints = results[0].SelectMany(i => points(i!)).ToList();
                    var runs = expectedPoints.Count(p => !expectedPoints.Contains(p - 1));
                    if (!expectedPoints.SequenceEqual(actualPoints) || results[0].Count != runs)
                        failures.Add($"{{ {Show(list)} }} gives {Show(results[0])}, which does not cover its points in {runs} interval(s)");
                }

        Assert.IsTrue(lists > 10_000, $"only {lists} lists");
        Assert.AreEqual(0, failures.Count, $"{failures.Count} of {lists} lists:\n{string.Join("\n", failures.Take(20))}");
    }

    #endregion
}
