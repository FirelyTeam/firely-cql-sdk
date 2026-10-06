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
using Hl7.Cql.Runtime;

namespace CoreTests
{
    /// <summary>
    /// Checks every interval relationship operator over integer intervals against an oracle that enumerates the values
    /// an interval's boundaries can take and applies the specification's definitions to each combination. An interval's
    /// effective boundaries follow the Start and End operators: an open boundary with a value is stepped inward, a
    /// closed null boundary is the minimum or maximum of the point type, and an open null boundary is unknown and ranges
    /// over the values its interval permits ("Note that open null boundaries of intervals are treaterd [sic] as
    /// uncertainties for the purposes of interval computation.", CQL 1.5.3 Errata 2, Language Semantics, section
    /// "Interval Operators"). The three-valued answer is true when the relation holds for every combination, false when
    /// it holds for none, and null otherwise. The grid covers every combination of the type's extremes, small values and
    /// null in both boundaries, with each boundary open or closed; interval pairs whose effective boundaries cross
    /// (empty intervals) are not checked.
    /// </summary>
    [TestClass]
    [TestCategory("UnitTest")]
    public class IntervalRelationshipOracleTests
    {
        private static readonly CqlContext Context = FhirCqlContext.WithDataSource();
        private static ICqlOperators Ops => Context.Operators;

        private const long Min = int.MinValue;
        private const long Max = int.MaxValue;

        private static readonly int?[] Values = { int.MinValue, -1, 0, 1, 2, int.MaxValue, null };

        private static IEnumerable<CqlInterval<int?>> Intervals()
        {
            foreach (var low in Values)
                foreach (var high in Values)
                {
                    if (low is { } l && high is { } h && l > h)
                        continue;
                    yield return new(low, high, true, true);
                    yield return new(low, high, true, false);
                    yield return new(low, high, false, true);
                    yield return new(low, high, false, false);
                }
        }

        /// <summary>The range of values an effective boundary can take; a known boundary is a range of one value.</summary>
        private readonly record struct Range(long Least, long Greatest)
        {
            public bool IsEmpty => Least > Greatest;
        }

        private static (Range Low, Range High) Effective(CqlInterval<int?> interval)
        {
            var lowClosed = interval.lowClosed ?? false;
            var highClosed = interval.highClosed ?? false;
            if (interval.low is { } low && interval.high is { } high)
            {
                long l = lowClosed ? low : low + 1L, h = highClosed ? high : high - 1L;
                return (new(l, l), new(h, h));
            }
            if (interval.low is { } lowOnly)
            {
                long l = lowClosed ? lowOnly : lowOnly + 1L;
                return (new(l, l), highClosed ? new(Max, Max) : new(l, Max));
            }
            if (interval.high is { } highOnly)
            {
                long h = highClosed ? highOnly : highOnly - 1L;
                return (lowClosed ? new(Min, Min) : new(Min, h), new(h, h));
            }
            return (lowClosed ? new(Min, Min) : new(Min, Max), highClosed ? new(Max, Max) : new(Min, Max));
        }

        /// <summary>
        /// Representative values of a range: its ends and the anchors (the other boundaries and their neighbours) that
        /// fall inside it. A relation built from comparisons and adjacency can only change its answer at those values.
        /// </summary>
        private static IEnumerable<long> Samples(Range range, IEnumerable<long> anchors)
        {
            if (range.Least == range.Greatest)
                return new[] { range.Least };
            var set = new SortedSet<long> { range.Least, range.Greatest };
            foreach (var anchor in anchors)
                for (var d = -1L; d <= 1; d++)
                    if (range.Least <= anchor + d && anchor + d <= range.Greatest)
                        set.Add(anchor + d);
            return set;
        }

        /// <summary>Every (low, high) pair of representative values of the interval's boundaries, or none when it is empty.</summary>
        private static List<(long Low, long High)> Completions(CqlInterval<int?> interval, List<long> anchors)
        {
            var (low, high) = Effective(interval);
            var result = new List<(long, long)>();
            if (low.Least > Max || high.Greatest < Min || low.IsEmpty || high.IsEmpty)
                return result;
            low = new(Math.Max(low.Least, Min), Math.Min(low.Greatest, Max));
            high = new(Math.Max(high.Least, Min), Math.Min(high.Greatest, Max));
            foreach (var l in Samples(low, anchors))
                foreach (var h in Samples(high, anchors))
                    if (l <= h)
                        result.Add((l, h));
            return result;
        }

        private static (List<(long Low, long High)> A, List<(long Low, long High)> B) Enumerate(CqlInterval<int?> a, CqlInterval<int?> b, params long[] extraAnchors)
        {
            var anchors = new List<long> { Min, Max };
            anchors.AddRange(extraAnchors);
            foreach (var v in new[] { a.low, a.high, b.low, b.high })
                if (v is { } value)
                    anchors.Add(value);
            var ca = Completions(a, anchors);
            var cb = Completions(b, anchors);
            // Each unknown boundary is also sampled at the other interval's representative values and their neighbours.
            foreach (var (l, h) in ca.Concat(cb))
            {
                anchors.Add(l);
                anchors.Add(h);
            }
            return (Completions(a, anchors), Completions(b, anchors));
        }

        private static bool? Decide(IEnumerable<bool> outcomes)
        {
            bool anyTrue = false, anyFalse = false;
            foreach (var outcome in outcomes)
            {
                if (outcome) anyTrue = true; else anyFalse = true;
                if (anyTrue && anyFalse) return null;
            }
            return anyTrue;
        }

        private static readonly Dictionary<string, Func<(long Low, long High), (long Low, long High), bool>> Relations = new()
        {
            // "if the ending point of the first interval is less than the starting point of the second"
            ["before"] = (a, b) => a.High < b.Low,
            ["after"] = (a, b) => a.Low > b.High,
            // "the ending point of the first interval is equal to the predecessor of the starting point of the second,
            // or ... the starting point of the first interval is equal to the successor of the ending point of the second"
            ["meetsBefore"] = (a, b) => a.High != Max && a.High + 1 == b.Low,
            ["meetsAfter"] = (a, b) => b.High != Max && b.High + 1 == a.Low,
            ["meets"] = (a, b) => (a.High != Max && a.High + 1 == b.Low) || (b.High != Max && b.High + 1 == a.Low),
            // "the ending point of the first interval is greater than or equal to the starting point of the second
            // interval, and the starting point of the first interval is less than or equal to the ending point of the second"
            ["overlaps"] = (a, b) => a.High >= b.Low && a.Low <= b.High,
            ["overlapsBefore"] = (a, b) => a.High >= b.Low && a.Low <= b.High && a.Low < b.Low,
            ["overlapsAfter"] = (a, b) => a.High >= b.Low && a.Low <= b.High && a.High > b.High,
            ["includes"] = (a, b) => a.Low <= b.Low && a.High >= b.High,
            ["properlyIncludes"] = (a, b) => a.Low <= b.Low && a.High >= b.High && a != b,
            ["properlyIncludedIn"] = (a, b) => b.Low <= a.Low && b.High >= a.High && a != b,
            ["sameAs"] = (a, b) => a == b,
            ["sameOrBefore"] = (a, b) => a.High <= b.Low,
            ["sameOrAfter"] = (a, b) => a.Low >= b.High,
            ["starts"] = (a, b) => a.Low == b.Low && a.High <= b.High,
            ["ends"] = (a, b) => a.High == b.High && a.Low >= b.Low,
        };

        private static readonly Dictionary<string, Func<CqlInterval<int?>, CqlInterval<int?>, bool?>> Operators = new()
        {
            ["before"] = (a, b) => Ops.Before(a, b, null),
            ["after"] = (a, b) => Ops.After(a, b, null),
            ["meetsBefore"] = (a, b) => Ops.MeetsBefore(a, b, null),
            ["meetsAfter"] = (a, b) => Ops.MeetsAfter(a, b, null),
            ["meets"] = (a, b) => Ops.Meets(a, b, null),
            ["overlaps"] = (a, b) => Ops.Overlaps(a, b),
            ["overlapsBefore"] = (a, b) => Ops.OverlapsBefore(a, b),
            ["overlapsAfter"] = (a, b) => Ops.OverlapsAfter(a, b),
            ["includes"] = (a, b) => Ops.IntervalIncludesInterval(a, b, null),
            ["properlyIncludes"] = (a, b) => Ops.IntervalProperlyIncludesInterval(a, b, null),
            ["properlyIncludedIn"] = (a, b) => Ops.IntervalProperlyIncludedInInterval(a, b, null),
            ["sameAs"] = (a, b) => Ops.SameAs(a, b, null),
            ["sameOrBefore"] = (a, b) => Ops.SameOrBefore(a, b),
            ["sameOrAfter"] = (a, b) => Ops.SameOrAfter(a, b),
            ["starts"] = (a, b) => Ops.Starts(a, b, null),
            ["ends"] = (a, b) => Ops.Ends(a, b, null),
        };

        private static readonly Dictionary<string, Func<long, (long Low, long High), bool>> PointRelations = new()
        {
            ["in"] = (p, b) => b.Low <= p && p <= b.High,
            ["includesElement"] = (p, b) => b.Low <= p && p <= b.High,
            ["pointBefore"] = (p, b) => p < b.Low,
            ["pointAfter"] = (p, b) => p > b.High,
            ["intervalBeforePoint"] = (p, b) => b.High < p,
            ["intervalAfterPoint"] = (p, b) => b.Low > p,
            // "returns true if the interval contains (i.e. includes) the point, and the interval is not a unit interval
            // containing only the point"
            ["properlyIncludedIn"] = (p, b) => b.Low <= p && p <= b.High && !(b.Low == p && b.High == p),
            ["properlyIncludesElement"] = (p, b) => b.Low <= p && p <= b.High && !(b.Low == p && b.High == p),
        };

        private static readonly Dictionary<string, Func<int?, CqlInterval<int?>, bool?>> PointOperators = new()
        {
            ["in"] = (p, b) => Ops.In(p, b, null),
            ["includesElement"] = (p, b) => Ops.IntervalIncludesElement(b, p, null),
            ["pointBefore"] = (p, b) => Ops.Before(p, b, null),
            ["pointAfter"] = (p, b) => Ops.After(p, b, null),
            ["intervalBeforePoint"] = (p, b) => Ops.Before(b, p, null),
            ["intervalAfterPoint"] = (p, b) => Ops.After(b, p, null),
            ["properlyIncludedIn"] = (p, b) => Ops.ElementProperlyIncludedInInterval(p, b),
            ["properlyIncludesElement"] = (p, b) => Ops.IntervalProperlyIncludesElement(b, p),
        };

        private static string Show(CqlInterval<int?> i) =>
            $"Interval{((i.lowClosed ?? false) ? "[" : "(")}{Show(i.low)}, {Show(i.high)}{((i.highClosed ?? false) ? "]" : ")")}";

        private static string Show(int? v) => v is null ? "null" : v == int.MinValue ? "min" : v == int.MaxValue ? "max" : v.Value.ToString();

        private static string Show(bool? v) => v is null ? "null" : v.Value ? "true" : "false";

        [TestMethod]
        public void IntervalIntervalOperators_AgreeWithTheEnumerationOracle()
        {
            var failures = new List<string>();
            var checkedCases = 0;
            var intervals = Intervals().ToList();
            foreach (var a in intervals)
                foreach (var b in intervals)
                {
                    var (ca, cb) = Enumerate(a, b);
                    if (ca.Count == 0 || cb.Count == 0)
                        continue;
                    foreach (var (name, relation) in Relations)
                    {
                        var expected = Decide(from x in ca from y in cb select relation(x, y));
                        var actual = Operators[name](a, b);
                        checkedCases++;
                        if (expected != actual)
                            failures.Add($"{Show(a)} {name} {Show(b)}: expected {Show(expected)}, got {Show(actual)}");
                    }
                }

            Assert.AreEqual(0, failures.Count, string.Join(Environment.NewLine, failures.Take(40).Prepend($"{failures.Count} of {checkedCases} cases disagree with the oracle:")));
        }

        [TestMethod]
        public void PointIntervalOperators_AgreeWithTheEnumerationOracle()
        {
            var failures = new List<string>();
            var checkedCases = 0;
            foreach (var p in Values)
                foreach (var b in Intervals())
                {
                    foreach (var (name, relation) in PointRelations)
                    {
                        bool? expected;
                        if (p is null)
                            expected = null;
                        else
                        {
                            var (_, cb) = Enumerate(b, b, p.Value);
                            if (cb.Count == 0)
                                continue;
                            expected = Decide(cb.Select(y => relation(p.Value, y)));
                        }
                        var actual = PointOperators[name](p, b);
                        checkedCases++;
                        if (expected != actual)
                            failures.Add($"{Show(p)} {name} {Show(b)}: expected {Show(expected)}, got {Show(actual)}");
                    }
                }

            Assert.AreEqual(0, failures.Count, string.Join(Environment.NewLine, failures.Take(40).Prepend($"{failures.Count} of {checkedCases} cases disagree with the oracle:")));
        }

        [TestMethod]
        public void RelationshipOperators_SatisfyTheirMutualInvariants()
        {
            var failures = new List<string>();
            var intervals = Intervals().ToList();
            foreach (var a in intervals)
                foreach (var b in intervals)
                {
                    void Check(bool holds, string invariant)
                    {
                        if (!holds) failures.Add($"{Show(a)}, {Show(b)}: {invariant}");
                    }

                    var meetsBefore = Ops.MeetsBefore(a, b, null);
                    var meetsAfter = Ops.MeetsAfter(a, b, null);
                    var meets = Ops.Meets(a, b, null);
                    var overlaps = Ops.Overlaps(a, b);
                    var includes = Ops.IntervalIncludesInterval(a, b, null);
                    var properlyIncludes = Ops.IntervalProperlyIncludesInterval(a, b, null);

                    Check(meets == Or(meetsBefore, meetsAfter), "meets is meets before or meets after");
                    Check(meetsBefore == Ops.MeetsAfter(b, a, null), "meets before mirrors meets after");
                    Check(overlaps == Ops.Overlaps(b, a), "overlaps is symmetric");
                    Check(Ops.SameAs(a, b, null) == Ops.SameAs(b, a, null), "same as is symmetric");
                    Check(Ops.Before(a, b, null) == Ops.After(b, a, null), "before mirrors after");
                    Check(Ops.SameOrBefore(a, b) == Ops.SameOrAfter(b, a), "same or before mirrors same or after");
                    Check(properlyIncludes == Ops.IntervalProperlyIncludedInInterval(b, a, null), "properly includes mirrors properly included in");
                    Check(meets != true || overlaps != true, "intervals that meet do not overlap");
                    Check(properlyIncludes != true || includes == true, "properly includes implies includes");
                    Check(includes != false || properlyIncludes == false, "not included is not properly included");
                    Check(Ops.Starts(a, b, null) != true || Ops.IntervalIncludesInterval(b, a, null) == true, "starts implies included in");
                    Check(Ops.Ends(a, b, null) != true || Ops.IntervalIncludesInterval(b, a, null) == true, "ends implies included in");
                    Check(Ops.SameAs(a, b, null) != true || (includes == true && properlyIncludes == false), "same as implies includes and not properly includes");
                }

            Assert.AreEqual(0, failures.Count, string.Join(Environment.NewLine, failures.Take(40).Prepend($"{failures.Count} invariant violations:")));
        }

        private static bool? Or(bool? left, bool? right) =>
            (left, right) switch
            {
                (true, _) or (_, true) => true,
                (null, _) or (_, null) => null,
                _ => false,
            };
    }
}
