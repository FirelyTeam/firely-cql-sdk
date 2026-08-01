/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;

namespace CoreTests;

/// <summary>
/// Behavior lock for the <c>Collapse</c> operator (issue #1473). The merge loop and the emptiness
/// pre-check inside <c>CollapseHelper</c> were rewritten for performance only, so every assertion
/// here holds for both the old and the new implementation.
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class CollapseOperatorTests
{
    private static ICqlOperators Sut() => FhirCqlContext.WithDataSource().Operators;

    private static CqlInterval<int?> Ints(int? low, int? high, bool lowClosed = true, bool highClosed = true) =>
        new(low, high, lowClosed, highClosed);

    private static CqlDateTime DateTime(int hour, int minute, int second = 0, int millisecond = 0) =>
        new(2026, 1, 1, hour, minute, second, millisecond, 0, 0);

    private static CqlInterval<CqlDateTime?> DateTimes(CqlDateTime? low, CqlDateTime? high) =>
        new(low, high, true, true);

    private static void AssertInterval<T>(
        CqlInterval<T?>? actual,
        T? low,
        T? high,
        bool lowClosed = true,
        bool highClosed = true)
    {
        Assert.IsNotNull(actual);
        Assert.AreEqual(low, actual.low);
        Assert.AreEqual(high, actual.high);
        Assert.AreEqual(lowClosed, actual.lowClosed);
        Assert.AreEqual(highClosed, actual.highClosed);
    }

    private static IReadOnlyList<CqlInterval<T?>?> Collapsed<T>(IEnumerable<CqlInterval<T?>?>? result)
    {
        Assert.IsNotNull(result);
        return result.ToList();
    }

    #region Integer overload

    [TestMethod]
    public void Collapse_OverlappingIntegerIntervals_MergeIntoOne()
    {
        var result = Collapsed(Sut().Collapse(new CqlInterval<int?>?[] { Ints(1, 5), Ints(3, 8) }, null));

        Assert.AreEqual(1, result.Count);
        AssertInterval(result[0], 1, 8);
    }

    [TestMethod]
    public void Collapse_MeetingIntegerIntervals_MergeIntoOne()
    {
        // [1, 2] and [3, 4] meet: successor(2) == 3.
        var result = Collapsed(Sut().Collapse(new CqlInterval<int?>?[] { Ints(1, 2), Ints(3, 4) }, null));

        Assert.AreEqual(1, result.Count);
        AssertInterval(result[0], 1, 4);
    }

    [TestMethod]
    public void Collapse_ContainedIntegerInterval_IsAbsorbed()
    {
        var result = Collapsed(Sut().Collapse(new CqlInterval<int?>?[] { Ints(1, 10), Ints(3, 5) }, null));

        Assert.AreEqual(1, result.Count);
        AssertInterval(result[0], 1, 10);
    }

    [TestMethod]
    public void Collapse_DisjointIntegerIntervals_StaySeparate()
    {
        // successor(2) == 3 != 5, so [1, 2] and [5, 6] neither overlap nor meet.
        var result = Collapsed(Sut().Collapse(new CqlInterval<int?>?[] { Ints(1, 2), Ints(5, 6) }, null));

        Assert.AreEqual(2, result.Count);
        AssertInterval(result[0], 1, 2);
        AssertInterval(result[1], 5, 6);
    }

    [TestMethod]
    public void Collapse_UnsortedIntegerIntervals_AreSortedBeforeMerging()
    {
        var unsorted = new CqlInterval<int?>?[]
        {
            Ints(20, 25),
            Ints(1, 5),
            Ints(11, 15),
            Ints(4, 9),
            Ints(30, 31),
        };

        var result = Collapsed(Sut().Collapse(unsorted, null));

        // Sorted: [1,5] [4,9] [11,15] [20,25] [30,31]; [1,5] and [4,9] overlap and merge to [1,9].
        Assert.AreEqual(4, result.Count);
        AssertInterval(result[0], 1, 9);
        AssertInterval(result[1], 11, 15);
        AssertInterval(result[2], 20, 25);
        AssertInterval(result[3], 30, 31);
    }

    [TestMethod]
    public void Collapse_ChainOfThreeIntegerIntervals_MergesIntoOne()
    {
        // The specification's own example (CQL 1.5.3 section 9.B, "Collapse1To9"):
        // collapse { Interval[1, 4], Interval[4, 8], Interval[7, 9] } // { Interval[1, 9] }
        // Each interval must be merged against the running result, not against the previous *input*
        // interval: [1,4] and [4,8] merge to [1,8], and [7,9] then merges into that.
        var result = Collapsed(Sut().Collapse(new CqlInterval<int?>?[] { Ints(1, 4), Ints(4, 8), Ints(7, 9) }, null));

        Assert.AreEqual(1, result.Count);
        AssertInterval(result[0], 1, 9);
    }

    [TestMethod]
    public void Collapse_ChainedMergeExtendsAcrossAnAbsorbedInterval()
    {
        // [1,10] absorbs [3,5], and [8,20] must then be merged against the *result* [1,10] - comparing
        // against the previous input interval [3,5] instead would leave [8,20] standing on its own.
        var intervals = new CqlInterval<int?>?[] { Ints(1, 10), Ints(3, 5), Ints(8, 20) };

        var result = Collapsed(Sut().Collapse(intervals, null));

        Assert.AreEqual(1, result.Count);
        AssertInterval(result[0], 1, 20);
    }

    [TestMethod]
    public void Collapse_TwoSeparateMergeGroups_ProduceTwoIntervals()
    {
        var intervals = new CqlInterval<int?>?[] { Ints(1, 5), Ints(4, 9), Ints(20, 25), Ints(24, 30) };

        var result = Collapsed(Sut().Collapse(intervals, null));

        Assert.AreEqual(2, result.Count);
        AssertInterval(result[0], 1, 9);
        AssertInterval(result[1], 20, 30);
    }

    [TestMethod]
    public void Collapse_OpenBoundaryIntervals_MergeAfterNormalization()
    {
        // [1, 3) normalizes to [1, 2], which meets [3, 5]. The merged interval keeps the
        // low boundary of the first and the high boundary of the second.
        var result = Collapsed(Sut().Collapse(new CqlInterval<int?>?[] { Ints(1, 3, highClosed: false), Ints(3, 5) }, null));

        Assert.AreEqual(1, result.Count);
        AssertInterval(result[0], 1, 5);
    }

    /// <summary>
    /// Locks the pre-existing null-element handling. NOTE: this behavior DEVIATES from the
    /// specification - CQL 1.5.3 section 9.B says of `collapse` that "If the list of intervals contains
    /// nulls, they will be excluded from the resulting list", but both `develop` and this
    /// implementation keep them. A null element sorts ahead of everything (SortBy puts null keys first,
    /// ascending) and never merges, because a merge needs two non-null intervals. Correcting that is out
    /// of scope for this performance-only change (issue #1473); a follow-up issue tracks it. This test
    /// pins today's behavior so the refactor cannot silently alter it.
    /// </summary>
    [TestMethod]
    public void Collapse_NullElement_IsSortedFirstAndKeptSeparate()
    {
        var result = Collapsed(Sut().Collapse(new CqlInterval<int?>?[] { Ints(1, 2), null, Ints(3, 4) }, null));

        Assert.AreEqual(2, result.Count);
        Assert.IsNull(result[0]);
        AssertInterval(result[1], 1, 4);
    }

    [TestMethod]
    public void Collapse_LazySource_IsCollapsed()
    {
        // A source whose count is not known without enumerating exercises the Count() fallback.
        var result = Collapsed(Sut().Collapse(LazyIntervals(), null));

        Assert.AreEqual(3, result.Count);
        AssertInterval(result[0], 0, 1);
        AssertInterval(result[1], 10, 11);
        AssertInterval(result[2], 20, 21);
    }

    [TestMethod]
    public void Collapse_LazyEmptySource_ReturnsEmpty()
    {
        var result = Collapsed(Sut().Collapse(LazyIntervals().Where(_ => false), null));

        Assert.AreEqual(0, result.Count);
    }

    [TestMethod]
    public void Collapse_EmptyInput_ReturnsEmptySequence()
    {
        var result = Sut().Collapse(Array.Empty<CqlInterval<int?>?>(), null);

        Assert.IsNotNull(result);
        Assert.AreEqual(0, result.Count());
    }

    [TestMethod]
    public void Collapse_NullInput_ReturnsNull()
    {
        Assert.IsNull(Sut().Collapse((IEnumerable<CqlInterval<int?>?>?)null, null));
    }

    private static IEnumerable<CqlInterval<int?>?> LazyIntervals()
    {
        foreach (var i in Enumerable.Range(0, 3))
            yield return Ints(i * 10, (i * 10) + 1);
    }

    #endregion

    #region DateTime overload

    [TestMethod]
    public void Collapse_OverlappingDateTimeIntervals_MergeIntoOne()
    {
        var intervals = new CqlInterval<CqlDateTime?>?[]
        {
            DateTimes(DateTime(1, 0), DateTime(5, 0)),
            DateTimes(DateTime(3, 0), DateTime(8, 0)),
        };

        var result = Collapsed(Sut().Collapse(intervals, null));

        Assert.AreEqual(1, result.Count);
        AssertInterval(result[0], DateTime(1, 0), DateTime(8, 0));
    }

    [TestMethod]
    public void Collapse_MeetingDateTimeIntervals_MergeIntoOne()
    {
        // Millisecond precision: successor(02:00:00.000) == 02:00:00.001.
        var intervals = new CqlInterval<CqlDateTime?>?[]
        {
            DateTimes(DateTime(1, 0), DateTime(2, 0)),
            DateTimes(DateTime(2, 0, 0, 1), DateTime(3, 0)),
        };

        var result = Collapsed(Sut().Collapse(intervals, null));

        Assert.AreEqual(1, result.Count);
        AssertInterval(result[0], DateTime(1, 0), DateTime(3, 0));
    }

    [TestMethod]
    public void Collapse_ChainOfThreeDateTimeIntervals_MergesIntoOne()
    {
        // The date/time analogue of the specification's { [1,4], [4,8], [7,9] } example: each interval
        // merges into the running result, so the whole chain collapses to a single interval.
        var intervals = new CqlInterval<CqlDateTime?>?[]
        {
            DateTimes(DateTime(1, 0), DateTime(4, 0)),
            DateTimes(DateTime(4, 0), DateTime(8, 0)),
            DateTimes(DateTime(7, 0), DateTime(9, 0)),
        };

        var result = Collapsed(Sut().Collapse(intervals, null));

        Assert.AreEqual(1, result.Count);
        AssertInterval(result[0], DateTime(1, 0), DateTime(9, 0));
    }

    [TestMethod]
    public void Collapse_ContainedDateTimeInterval_IsAbsorbed()
    {
        var intervals = new CqlInterval<CqlDateTime?>?[]
        {
            DateTimes(DateTime(1, 0), DateTime(10, 0)),
            DateTimes(DateTime(3, 0), DateTime(5, 0)),
        };

        var result = Collapsed(Sut().Collapse(intervals, null));

        Assert.AreEqual(1, result.Count);
        AssertInterval(result[0], DateTime(1, 0), DateTime(10, 0));
    }

    [TestMethod]
    public void Collapse_DisjointDateTimeIntervals_StaySeparate()
    {
        var intervals = new CqlInterval<CqlDateTime?>?[]
        {
            DateTimes(DateTime(1, 0), DateTime(2, 0)),
            DateTimes(DateTime(5, 0), DateTime(6, 0)),
        };

        var result = Collapsed(Sut().Collapse(intervals, null));

        Assert.AreEqual(2, result.Count);
        AssertInterval(result[0], DateTime(1, 0), DateTime(2, 0));
        AssertInterval(result[1], DateTime(5, 0), DateTime(6, 0));
    }

    [TestMethod]
    public void Collapse_UnsortedDateTimeIntervals_AreSortedBeforeMerging()
    {
        var unsorted = new CqlInterval<CqlDateTime?>?[]
        {
            DateTimes(DateTime(20, 0), DateTime(21, 0)),
            DateTimes(DateTime(1, 0), DateTime(5, 0)),
            DateTimes(DateTime(11, 0), DateTime(12, 0)),
            DateTimes(DateTime(4, 0), DateTime(9, 0)),
        };

        var result = Collapsed(Sut().Collapse(unsorted, null));

        Assert.AreEqual(3, result.Count);
        AssertInterval(result[0], DateTime(1, 0), DateTime(9, 0));
        AssertInterval(result[1], DateTime(11, 0), DateTime(12, 0));
        AssertInterval(result[2], DateTime(20, 0), DateTime(21, 0));
    }

    /// <summary>
    /// Locks the pre-existing null-element handling for the date/time overload. As with the integer
    /// case above, this DEVIATES from CQL 1.5.3 section 9.B ("If the list of intervals contains nulls,
    /// they will be excluded from the resulting list") - both `develop` and this implementation keep
    /// them. Out of scope for this performance-only change (issue #1473); a follow-up issue tracks it.
    /// </summary>
    [TestMethod]
    public void Collapse_NullDateTimeElement_IsSortedFirstAndKeptSeparate()
    {
        var intervals = new CqlInterval<CqlDateTime?>?[]
        {
            DateTimes(DateTime(1, 0), DateTime(2, 0)),
            null,
        };

        var result = Collapsed(Sut().Collapse(intervals, null));

        Assert.AreEqual(2, result.Count);
        Assert.IsNull(result[0]);
        AssertInterval(result[1], DateTime(1, 0), DateTime(2, 0));
    }

    [TestMethod]
    public void Collapse_EmptyDateTimeInput_ReturnsEmptySequence()
    {
        var result = Sut().Collapse(Array.Empty<CqlInterval<CqlDateTime?>?>(), null);

        Assert.IsNotNull(result);
        Assert.AreEqual(0, result.Count());
    }

    [TestMethod]
    public void Collapse_NullDateTimeInput_ReturnsNull()
    {
        Assert.IsNull(Sut().Collapse((IEnumerable<CqlInterval<CqlDateTime?>?>?)null, null));
    }

    #endregion
}
