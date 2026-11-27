/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using System.ComponentModel;
using BenchmarkDotNet.Attributes;
using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;

namespace Benchmarks;

/// <summary>
/// Measures the sort operators and <c>collapse</c> over the result of a sort, the shape of CQL such as
/// <c>collapse (X i sort by low)</c>. The result of a sort is a deferred sequence, so the cases differ in how often
/// that sequence is read.
/// </summary>
[ShortRunJob]
[MemoryDiagnoser]
public class SortOperatorBenchmarks
{
    private ICqlOperators _operators = null!;
    private CqlInterval<CqlDate?>?[] _intervals = null!;
    private int?[] _ints = null!;

    /// <summary>
    /// How many elements the sorted list has. A member has a handful of coverage or service periods; the larger
    /// value shows how the cost grows.
    /// </summary>
    [Params(8, 200)]
    public int Values { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        _operators = FhirCqlContext.WithDataSource().Operators;

        // A fixed order that is not sorted: every seventh position, modulo a count that 7 does not divide.
        var order = Enumerable.Range(0, Values).Select(i => i * 7 % (Values + 1)).ToArray();
        var firstDay = new DateOnly(2026, 1, 1);
        _intervals = order
            .Select(position =>
            {
                // Ten-day periods that start every twenty days: no two of them meet or overlap.
                var low = firstDay.AddDays(position * 20);
                var high = low.AddDays(9);
                return (CqlInterval<CqlDate?>?)new CqlInterval<CqlDate?>(
                    new CqlDate(low.Year, low.Month, low.Day),
                    new CqlDate(high.Year, high.Month, high.Day),
                    true,
                    true);
            })
            .ToArray();
        _ints = order.Select(position => (int?)position).ToArray();
    }

    private IEnumerable<CqlInterval<CqlDate?>?> SortByLow(IEnumerable<CqlInterval<CqlDate?>?> intervals) =>
        _operators.SortBy(intervals, interval => interval!.low!, ListSortDirection.Ascending)!;

    /// <summary>
    /// Reads every element. <c>Count()</c> does not: LINQ counts an ordered sequence without sorting it.
    /// </summary>
    private static int Read<T>(IEnumerable<T> sequence)
    {
        var count = 0;
        foreach (var _ in sequence)
            count++;
        return count;
    }

    [Benchmark]
    public int SortBy_ReadOnce() => Read(SortByLow(_intervals));

    [Benchmark]
    public int SortBy_ReadTwice()
    {
        var sorted = SortByLow(_intervals);
        return Read(sorted) + Read(sorted);
    }

    [Benchmark]
    public int Collapse_OfSortBy() => Read(_operators.Collapse(SortByLow(_intervals), null)!);

    [Benchmark]
    public int Collapse_OfSortByOfSortBy() => Read(_operators.Collapse(SortByLow(SortByLow(_intervals)), null)!);

    [Benchmark]
    public int ListSort_ReadOnce() => Read(_operators.ListSort(_ints, ListSortDirection.Ascending)!);

    [Benchmark]
    public int ListSort_ReadTwice()
    {
        var sorted = _operators.ListSort(_ints, ListSortDirection.Ascending)!;
        return Read(sorted) + Read(sorted);
    }
}
