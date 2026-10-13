/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable
#pragma warning disable CS8620, CS8619, CS8604, CS8625

using System.Globalization;
using System.Text;
using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;

namespace CoreTests
{
    /// <summary>
    /// Writes the result of every interval relationship operator over fixed operand grids to the file named by the
    /// CQL_RELATIONSHIP_GRID_OUT environment variable, one line per evaluation, so two builds can be compared with a
    /// plain diff. Inconclusive when the variable is not set.
    /// </summary>
    [TestClass]
    [TestCategory("Diagnostic")]
    public class IntervalRelationshipGridDump
    {
        private static readonly CqlContext Context = FhirCqlContext.WithDataSource();
        private static ICqlOperators Ops => Context.Operators;

        [TestMethod]
        public void Dump()
        {
            var path = Environment.GetEnvironmentVariable("CQL_RELATIONSHIP_GRID_OUT");
            if (string.IsNullOrEmpty(path))
                Assert.Inconclusive("Set CQL_RELATIONSHIP_GRID_OUT to write the grid.");

            using var w = new StreamWriter(path!, false, new UTF8Encoding(false));
            Integers(w);
            Quantities(w);
            Dates(w);
            DateTimes(w);
            Times(w);
        }

        private static string R(Func<bool?> f)
        {
            try { var r = f(); return r is null ? "N" : r.Value ? "T" : "F"; }
            catch (Exception e) { return "E:" + e.GetType().Name; }
        }

        private static string Br(bool? closed, bool low) => low ? (closed == true ? "[" : "(") : (closed == true ? "]" : ")");

        private static void Integers(StreamWriter w)
        {
            int?[] values = { int.MinValue, -1, 0, 1, 2, int.MaxValue, null };
            static string V(int? v) => v is null ? "null" : v == int.MinValue ? "min" : v == int.MaxValue ? "max" : v.Value.ToString(CultureInfo.InvariantCulture);
            var intervals = new List<CqlInterval<int?>>();
            foreach (var lo in values)
                foreach (var hi in values)
                {
                    if (lo is { } l && hi is { } h && l > h) continue;
                    foreach (var lc in new[] { true, false })
                        foreach (var hc in new[] { true, false })
                            intervals.Add(new(lo, hi, lc, hc));
                }
            string S(CqlInterval<int?> i) => $"{Br(i.lowClosed, true)}{V(i.low)},{V(i.high)}{Br(i.highClosed, false)}";

            foreach (var a in intervals)
                foreach (var b in intervals)
                {
                    var k = $"int {S(a)} {S(b)}";
                    w.WriteLine($"{k} before {R(() => Ops.Before(a, b, null))}");
                    w.WriteLine($"{k} after {R(() => Ops.After(a, b, null))}");
                    w.WriteLine($"{k} meets {R(() => Ops.Meets(a, b, null))}");
                    w.WriteLine($"{k} meetsBefore {R(() => Ops.MeetsBefore(a, b, null))}");
                    w.WriteLine($"{k} meetsAfter {R(() => Ops.MeetsAfter(a, b, null))}");
                    w.WriteLine($"{k} overlaps {R(() => Ops.Overlaps(a, b))}");
                    w.WriteLine($"{k} overlapsBefore {R(() => Ops.OverlapsBefore(a, b))}");
                    w.WriteLine($"{k} overlapsAfter {R(() => Ops.OverlapsAfter(a, b))}");
                    w.WriteLine($"{k} includes {R(() => Ops.IntervalIncludesInterval(a, b, null))}");
                    w.WriteLine($"{k} properlyIncludes {R(() => Ops.IntervalProperlyIncludesInterval(a, b, null))}");
                    w.WriteLine($"{k} properlyIncludedIn {R(() => Ops.IntervalProperlyIncludedInInterval(a, b, null))}");
                    w.WriteLine($"{k} sameAs {R(() => Ops.SameAs(a, b, null))}");
                    w.WriteLine($"{k} sameOrBefore {R(() => Ops.SameOrBefore(a, b))}");
                    w.WriteLine($"{k} sameOrAfter {R(() => Ops.SameOrAfter(a, b))}");
                    w.WriteLine($"{k} starts {R(() => Ops.Starts(a, b, null))}");
                    w.WriteLine($"{k} ends {R(() => Ops.Ends(a, b, null))}");
                }

            foreach (var p in values)
                foreach (var b in intervals)
                {
                    var k = $"int {V(p)} {S(b)}";
                    w.WriteLine($"{k} in {R(() => Ops.In(p, b, null))}");
                    w.WriteLine($"{k} includesElement {R(() => Ops.IntervalIncludesElement(b, p, null))}");
                    w.WriteLine($"{k} pointBefore {R(() => Ops.Before(p, b, null))}");
                    w.WriteLine($"{k} pointAfter {R(() => Ops.After(p, b, null))}");
                    w.WriteLine($"{k} intervalBeforePoint {R(() => Ops.Before(b, p, null))}");
                    w.WriteLine($"{k} intervalAfterPoint {R(() => Ops.After(b, p, null))}");
                    w.WriteLine($"{k} properlyIncludedIn {R(() => Ops.ElementProperlyIncludedInInterval(p, b))}");
                    w.WriteLine($"{k} properlyIncludesElement {R(() => Ops.IntervalProperlyIncludesElement(b, p))}");
                }
        }

        private static void Quantities(StreamWriter w)
        {
            var sets = new (string unit, decimal[] values)[] { ("g", new[] { 1000m, 2000m, 3000m }), ("kg", new[] { 1m, 2m, 3m }), ("m", new[] { 1m, 2m, 3m }) };
            static string V(CqlQuantity? q) => q is null ? "null" : $"{q.value!.Value.ToString(CultureInfo.InvariantCulture)}'{q.unit}'";
            var intervals = new List<CqlInterval<CqlQuantity?>>();
            foreach (var (unit, vals) in sets)
            {
                CqlQuantity?[] qs = vals.Select(v => (CqlQuantity?)new CqlQuantity(v, unit)).Append(null).ToArray();
                foreach (var lo in qs)
                    foreach (var hi in qs)
                    {
                        if (lo is { } l && hi is { } h && l.value > h.value) continue;
                        intervals.Add(new(lo, hi, true, true));
                        intervals.Add(new(lo, hi, false, false));
                    }
            }
            string S(CqlInterval<CqlQuantity?> i) => $"{Br(i.lowClosed, true)}{V(i.low)},{V(i.high)}{Br(i.highClosed, false)}";
            var points = new List<CqlQuantity?> { new(1m, "g"), new(2000m, "g"), new(2m, "kg"), new(2m, "m"), new(2m, "1"), null };

            foreach (var a in intervals)
                foreach (var b in intervals)
                {
                    var k = $"qty {S(a)} {S(b)}";
                    w.WriteLine($"{k} before {R(() => Ops.Before(a, b, null))}");
                    w.WriteLine($"{k} after {R(() => Ops.After(a, b, null))}");
                    w.WriteLine($"{k} meets {R(() => Ops.Meets(a, b, null))}");
                    w.WriteLine($"{k} meetsBefore {R(() => Ops.MeetsBefore(a, b, null))}");
                    w.WriteLine($"{k} meetsAfter {R(() => Ops.MeetsAfter(a, b, null))}");
                    w.WriteLine($"{k} overlaps {R(() => Ops.Overlaps(a, b))}");
                    w.WriteLine($"{k} overlapsBefore {R(() => Ops.OverlapsBefore(a, b))}");
                    w.WriteLine($"{k} overlapsAfter {R(() => Ops.OverlapsAfter(a, b))}");
                    w.WriteLine($"{k} includes {R(() => Ops.IntervalIncludesInterval(a, b, null))}");
                    w.WriteLine($"{k} properlyIncludes {R(() => Ops.IntervalProperlyIncludesInterval(a, b, null))}");
                    w.WriteLine($"{k} properlyIncludedIn {R(() => Ops.IntervalProperlyIncludedInInterval(a, b, null))}");
                    w.WriteLine($"{k} sameAs {R(() => Ops.SameAs(a, b, null))}");
                    w.WriteLine($"{k} sameOrBefore {R(() => Ops.SameOrBefore(a, b))}");
                    w.WriteLine($"{k} sameOrAfter {R(() => Ops.SameOrAfter(a, b))}");
                    w.WriteLine($"{k} starts {R(() => Ops.Starts(a, b, null))}");
                    w.WriteLine($"{k} ends {R(() => Ops.Ends(a, b, null))}");
                }

            foreach (var p in points)
                foreach (var b in intervals)
                {
                    var k = $"qty {V(p)} {S(b)}";
                    w.WriteLine($"{k} in {R(() => Ops.In(p, b, null))}");
                    w.WriteLine($"{k} includesElement {R(() => Ops.IntervalIncludesElement(b, p, null))}");
                    w.WriteLine($"{k} pointBefore {R(() => Ops.Before(p, b, null))}");
                    w.WriteLine($"{k} pointAfter {R(() => Ops.After(p, b, null))}");
                    w.WriteLine($"{k} intervalBeforePoint {R(() => Ops.Before(b, p, null))}");
                    w.WriteLine($"{k} intervalAfterPoint {R(() => Ops.After(b, p, null))}");
                    w.WriteLine($"{k} properlyIncludedIn {R(() => Ops.ElementProperlyIncludedInInterval(p, b))}");
                    w.WriteLine($"{k} properlyIncludesElement {R(() => Ops.IntervalProperlyIncludesElement(b, p))}");
                }
        }

        private static CqlDate D(string s) => CqlDate.TryParse(s, out var d) ? d! : throw new ArgumentException(s);
        private static CqlDateTime Dt(string s) => CqlDateTime.TryParse(s, out var d) ? d! : throw new ArgumentException(s);
        private static CqlTime T(string s) => CqlTime.TryParse(s, out var t) ? t! : throw new ArgumentException(s);

        private static void Dates(StreamWriter w)
        {
            // Ordered so that index(low) <= index(high) keeps the interval well-formed.
            string[] texts = { "2012", "2012-01", "2012-01-14", "2012-01-15", "2012-02", "2013" };
            CqlDate?[] values = texts.Select(t => (CqlDate?)D(t)).Append(null).ToArray();
            string?[] precisions = { null, "year", "month", "day" };
            static string V(CqlDate? d) => d is null ? "null" : d.ToString()!;
            var intervals = new List<CqlInterval<CqlDate?>>();
            for (var i = 0; i < values.Length; i++)
                for (var j = 0; j < values.Length; j++)
                {
                    if (values[i] is not null && values[j] is not null && i > j) continue;
                    intervals.Add(new(values[i], values[j], true, true));
                    intervals.Add(new(values[i], values[j], false, false));
                }
            string S(CqlInterval<CqlDate?> i) => $"{Br(i.lowClosed, true)}{V(i.low)},{V(i.high)}{Br(i.highClosed, false)}";

            foreach (var precision in precisions)
            {
                var pr = precision ?? "-";
                foreach (var a in intervals)
                    foreach (var b in intervals)
                    {
                        var k = $"date@{pr} {S(a)} {S(b)}";
                        w.WriteLine($"{k} before {R(() => Ops.Before(a, b, precision))}");
                        w.WriteLine($"{k} after {R(() => Ops.After(a, b, precision))}");
                        w.WriteLine($"{k} meets {R(() => Ops.Meets(a, b, precision))}");
                        w.WriteLine($"{k} meetsBefore {R(() => Ops.MeetsBefore(a, b, precision))}");
                        w.WriteLine($"{k} meetsAfter {R(() => Ops.MeetsAfter(a, b, precision))}");
                        w.WriteLine($"{k} overlaps {R(() => Ops.Overlaps(a, b, precision))}");
                        w.WriteLine($"{k} overlapsBefore {R(() => Ops.OverlapsBefore(a, b, precision))}");
                        w.WriteLine($"{k} overlapsAfter {R(() => Ops.OverlapsAfter(a, b, precision))}");
                        w.WriteLine($"{k} includes {R(() => Ops.IntervalIncludesInterval(a, b, precision))}");
                        w.WriteLine($"{k} properlyIncludes {R(() => Ops.IntervalProperlyIncludesInterval(a, b, precision))}");
                        w.WriteLine($"{k} properlyIncludedIn {R(() => Ops.IntervalProperlyIncludedInInterval(a, b, precision))}");
                        w.WriteLine($"{k} sameAs {R(() => Ops.SameAs(a, b, precision))}");
                        w.WriteLine($"{k} sameOrBefore {R(() => Ops.SameOrBefore(a, b, precision))}");
                        w.WriteLine($"{k} sameOrAfter {R(() => Ops.SameOrAfter(a, b, precision))}");
                        w.WriteLine($"{k} starts {R(() => Ops.Starts(a, b, precision))}");
                        w.WriteLine($"{k} ends {R(() => Ops.Ends(a, b, precision))}");
                    }

                foreach (var p in values)
                    foreach (var b in intervals)
                    {
                        var k = $"date@{pr} {V(p)} {S(b)}";
                        w.WriteLine($"{k} in {R(() => Ops.In(p, b, precision))}");
                        w.WriteLine($"{k} includesElement {R(() => Ops.IntervalIncludesElement(b, p, precision))}");
                        w.WriteLine($"{k} pointBefore {R(() => Ops.Before(p, b, precision))}");
                        w.WriteLine($"{k} pointAfter {R(() => Ops.After(p, b, precision))}");
                        w.WriteLine($"{k} intervalBeforePoint {R(() => Ops.Before(b, p, precision))}");
                        w.WriteLine($"{k} intervalAfterPoint {R(() => Ops.After(b, p, precision))}");
                        w.WriteLine($"{k} properlyIncludedIn {R(() => p is null ? null : Ops.ElementProperlyIncludedInInterval(p, b, precision))}");
                        w.WriteLine($"{k} properlyIncludesElement {R(() => p is null ? null : Ops.IntervalProperlyIncludesElement(b, p, precision))}");
                    }
            }
        }

        private static void DateTimes(StreamWriter w)
        {
            // Ordered so that index(low) <= index(high) keeps the interval well-formed.
            string[] texts = { "2012-01-14T10", "2012-01-14T10:30", "2012-01-14T10:30:00", "2012-01-14T10:30:00.000", "2012-01-14T10:30:00.001", "2012-01-15" };
            CqlDateTime?[] values = texts.Select(t => (CqlDateTime?)Dt(t)).Append(null).ToArray();
            string?[] precisions = { null, "hour", "millisecond" };
            static string V(CqlDateTime? d) => d is null ? "null" : d.ToString()!;
            var intervals = new List<CqlInterval<CqlDateTime?>>();
            for (var i = 0; i < values.Length; i++)
                for (var j = 0; j < values.Length; j++)
                {
                    if (values[i] is not null && values[j] is not null && i > j) continue;
                    intervals.Add(new(values[i], values[j], true, true));
                    intervals.Add(new(values[i], values[j], false, false));
                }
            string S(CqlInterval<CqlDateTime?> i) => $"{Br(i.lowClosed, true)}{V(i.low)},{V(i.high)}{Br(i.highClosed, false)}";

            foreach (var precision in precisions)
            {
                var pr = precision ?? "-";
                foreach (var a in intervals)
                    foreach (var b in intervals)
                    {
                        var k = $"datetime@{pr} {S(a)} {S(b)}";
                        w.WriteLine($"{k} before {R(() => Ops.Before(a, b, precision))}");
                        w.WriteLine($"{k} after {R(() => Ops.After(a, b, precision))}");
                        w.WriteLine($"{k} meets {R(() => Ops.Meets(a, b, precision))}");
                        w.WriteLine($"{k} meetsBefore {R(() => Ops.MeetsBefore(a, b, precision))}");
                        w.WriteLine($"{k} meetsAfter {R(() => Ops.MeetsAfter(a, b, precision))}");
                        w.WriteLine($"{k} overlaps {R(() => Ops.Overlaps(a, b, precision))}");
                        w.WriteLine($"{k} overlapsBefore {R(() => Ops.OverlapsBefore(a, b, precision))}");
                        w.WriteLine($"{k} overlapsAfter {R(() => Ops.OverlapsAfter(a, b, precision))}");
                        w.WriteLine($"{k} includes {R(() => Ops.IntervalIncludesInterval(a, b, precision))}");
                        w.WriteLine($"{k} properlyIncludes {R(() => Ops.IntervalProperlyIncludesInterval(a, b, precision))}");
                        w.WriteLine($"{k} properlyIncludedIn {R(() => Ops.IntervalProperlyIncludedInInterval(a, b, precision))}");
                        w.WriteLine($"{k} sameAs {R(() => Ops.SameAs(a, b, precision))}");
                        w.WriteLine($"{k} sameOrBefore {R(() => Ops.SameOrBefore(a, b, precision))}");
                        w.WriteLine($"{k} sameOrAfter {R(() => Ops.SameOrAfter(a, b, precision))}");
                        w.WriteLine($"{k} starts {R(() => Ops.Starts(a, b, precision))}");
                        w.WriteLine($"{k} ends {R(() => Ops.Ends(a, b, precision))}");
                    }

                foreach (var p in values)
                    foreach (var b in intervals)
                    {
                        var k = $"datetime@{pr} {V(p)} {S(b)}";
                        w.WriteLine($"{k} in {R(() => Ops.In(p, b, precision))}");
                        w.WriteLine($"{k} includesElement {R(() => Ops.IntervalIncludesElement(b, p, precision))}");
                        w.WriteLine($"{k} pointBefore {R(() => Ops.Before(p, b, precision))}");
                        w.WriteLine($"{k} pointAfter {R(() => Ops.After(p, b, precision))}");
                        w.WriteLine($"{k} intervalBeforePoint {R(() => Ops.Before(b, p, precision))}");
                        w.WriteLine($"{k} intervalAfterPoint {R(() => Ops.After(b, p, precision))}");
                        w.WriteLine($"{k} properlyIncludedIn {R(() => p is null ? null : Ops.ElementProperlyIncludedInInterval(p, b, precision))}");
                        w.WriteLine($"{k} properlyIncludesElement {R(() => p is null ? null : Ops.IntervalProperlyIncludesElement(b, p, precision))}");
                    }
            }
        }

        private static void Times(StreamWriter w)
        {
            string[] texts = { "12:00", "12:00:00", "12:00:00.000", "12:00:00.001", "12:00:01", "21:59:59.999" };
            CqlTime?[] values = texts.Select(t => (CqlTime?)T(t)).Append(null).ToArray();
            string?[] precisions = { null, "minute", "second", "millisecond" };
            static string V(CqlTime? t) => t is null ? "null" : t.ToString()!;
            var intervals = new List<CqlInterval<CqlTime?>>();
            for (var i = 0; i < values.Length; i++)
                for (var j = 0; j < values.Length; j++)
                {
                    if (values[i] is not null && values[j] is not null && i > j) continue;
                    intervals.Add(new(values[i], values[j], true, true));
                    intervals.Add(new(values[i], values[j], false, false));
                }
            string S(CqlInterval<CqlTime?> i) => $"{Br(i.lowClosed, true)}{V(i.low)},{V(i.high)}{Br(i.highClosed, false)}";

            foreach (var precision in precisions)
            {
                var pr = precision ?? "-";
                foreach (var a in intervals)
                    foreach (var b in intervals)
                    {
                        var k = $"time@{pr} {S(a)} {S(b)}";
                        w.WriteLine($"{k} before {R(() => Ops.Before(a, b, precision))}");
                        w.WriteLine($"{k} after {R(() => Ops.After(a, b, precision))}");
                        w.WriteLine($"{k} meets {R(() => Ops.Meets(a, b, precision))}");
                        w.WriteLine($"{k} meetsBefore {R(() => Ops.MeetsBefore(a, b, precision))}");
                        w.WriteLine($"{k} meetsAfter {R(() => Ops.MeetsAfter(a, b, precision))}");
                        w.WriteLine($"{k} overlaps {R(() => Ops.Overlaps(a, b, precision))}");
                        w.WriteLine($"{k} overlapsBefore {R(() => Ops.OverlapsBefore(a, b, precision))}");
                        w.WriteLine($"{k} overlapsAfter {R(() => Ops.OverlapsAfter(a, b, precision))}");
                        w.WriteLine($"{k} includes {R(() => Ops.IntervalIncludesInterval(a, b, precision))}");
                        w.WriteLine($"{k} properlyIncludes {R(() => Ops.IntervalProperlyIncludesInterval(a, b, precision))}");
                        w.WriteLine($"{k} properlyIncludedIn {R(() => Ops.IntervalProperlyIncludedInInterval(a, b, precision))}");
                        w.WriteLine($"{k} sameAs {R(() => Ops.SameAs(a, b, precision))}");
                        w.WriteLine($"{k} sameOrBefore {R(() => Ops.SameOrBefore(a, b, precision))}");
                        w.WriteLine($"{k} sameOrAfter {R(() => Ops.SameOrAfter(a, b, precision))}");
                        w.WriteLine($"{k} starts {R(() => Ops.Starts(a, b, precision))}");
                        w.WriteLine($"{k} ends {R(() => Ops.Ends(a, b, precision))}");
                    }

                foreach (var p in values)
                    foreach (var b in intervals)
                    {
                        var k = $"time@{pr} {V(p)} {S(b)}";
                        w.WriteLine($"{k} in {R(() => Ops.In(p, b, precision))}");
                        w.WriteLine($"{k} includesElement {R(() => Ops.IntervalIncludesElement(b, p, precision))}");
                        w.WriteLine($"{k} pointBefore {R(() => Ops.Before(p, b, precision))}");
                        w.WriteLine($"{k} pointAfter {R(() => Ops.After(p, b, precision))}");
                        w.WriteLine($"{k} intervalBeforePoint {R(() => Ops.Before(b, p, precision))}");
                        w.WriteLine($"{k} intervalAfterPoint {R(() => Ops.After(b, p, precision))}");
                        w.WriteLine($"{k} properlyIncludedIn {R(() => p is null ? null : Ops.ElementProperlyIncludedInInterval(p, b, precision))}");
                        w.WriteLine($"{k} properlyIncludesElement {R(() => p is null ? null : Ops.IntervalProperlyIncludesElement(b, p, precision))}");
                    }
            }
        }
    }
}
