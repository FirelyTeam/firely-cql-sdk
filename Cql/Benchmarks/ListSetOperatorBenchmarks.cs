/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using BenchmarkDotNet.Attributes;
using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;

namespace Benchmarks;

/// <summary>
/// Measures the runtime cost of list set operators with element types that span comparer cost:
/// primitive numerics, normalized strings, UCUM-convertible quantities, and concepts.
/// These operators share the same CQL comparer path, so benchmarking the family provides a
/// baseline for correctness changes that alter which operator uses that comparer.
/// </summary>
[ShortRunJob]
[MemoryDiagnoser]
public class ListSetOperatorBenchmarks
{
    private ICqlOperators _operators = null!;
    private int?[] _leftInts = null!;
    private int?[] _rightInts = null!;
    private string?[] _leftStrings = null!;
    private string?[] _rightStrings = null!;
    private CqlQuantity?[] _leftQuantities = null!;
    private CqlQuantity?[] _rightQuantities = null!;
    private CqlConcept?[] _leftConcepts = null!;
    private CqlConcept?[] _rightConcepts = null!;
    private int?[] _intsWithDuplicates = null!;
    private string?[] _stringsWithDuplicates = null!;
    private CqlQuantity?[] _quantitiesWithDuplicates = null!;
    private CqlConcept?[] _conceptsWithDuplicates = null!;

    /// <summary>
    /// How many elements each input list has, representing the number of values
    /// processed by set operators in a query step.
    /// </summary>
    [Params(200, 2000)]
    public int Values { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        _operators = FhirCqlContext.WithDataSource().Operators;
        var overlapStart = Values / 2;

        _leftInts = Enumerable.Range(0, Values).Select(i => (int?)i).ToArray();
        _rightInts = Enumerable.Range(overlapStart, Values).Select(i => (int?)i).ToArray();

        _leftStrings = Enumerable.Range(0, Values).Select(i => $"value-{i:000000}").ToArray();
        _rightStrings = Enumerable.Range(overlapStart, Values).Select(i => $"value-{i:000000}").ToArray();

        _leftQuantities = Enumerable.Range(0, Values)
            .Select(i => (CqlQuantity?)new CqlQuantity(i + 1, "g"))
            .ToArray();
        _rightQuantities = Enumerable.Range(overlapStart, Values)
            .Select(i => (CqlQuantity?)new CqlQuantity((i + 1) * 1000m, "mg"))
            .ToArray();

        _leftConcepts = Enumerable.Range(0, Values)
            .Select(i => (CqlConcept?)new CqlConcept([new CqlCode($"C{i:000000}", "sys")], null))
            .ToArray();
        _rightConcepts = Enumerable.Range(overlapStart, Values)
            .Select(i => (CqlConcept?)new CqlConcept([new CqlCode($"C{i:000000}", "sys")], null))
            .ToArray();

        _intsWithDuplicates = _leftInts.Concat(_leftInts).ToArray();
        _stringsWithDuplicates = _leftStrings.Concat(_leftStrings).ToArray();
        _quantitiesWithDuplicates = _leftQuantities.Concat(_leftQuantities).ToArray();
        _conceptsWithDuplicates = _leftConcepts.Concat(_leftConcepts).ToArray();
    }

    [Benchmark(Description = "Intersect<int>")]
    public int IntersectInt() => Count(_operators.Intersect(_leftInts, _rightInts));

    [Benchmark(Description = "Intersect<string>")]
    public int IntersectString() => Count(_operators.Intersect(_leftStrings, _rightStrings));

    [Benchmark(Description = "Intersect<CqlQuantity>")]
    public int IntersectQuantity() => Count(_operators.Intersect(_leftQuantities, _rightQuantities));

    [Benchmark(Description = "Intersect<CqlConcept>")]
    public int IntersectConcept() => Count(_operators.Intersect(_leftConcepts, _rightConcepts));

    [Benchmark(Description = "Except<int>")]
    public int ExceptInt() => Count(_operators.Except(_leftInts, _rightInts));

    [Benchmark(Description = "Except<string>")]
    public int ExceptString() => Count(_operators.Except(_leftStrings, _rightStrings));

    [Benchmark(Description = "Except<CqlQuantity>")]
    public int ExceptQuantity() => Count(_operators.Except(_leftQuantities, _rightQuantities));

    [Benchmark(Description = "Except<CqlConcept>")]
    public int ExceptConcept() => Count(_operators.Except(_leftConcepts, _rightConcepts));

    [Benchmark(Description = "Union<int>")]
    public int UnionInt() => Count(_operators.Union(_leftInts, _rightInts));

    [Benchmark(Description = "Union<string>")]
    public int UnionString() => Count(_operators.Union(_leftStrings, _rightStrings));

    [Benchmark(Description = "Union<CqlQuantity>")]
    public int UnionQuantity() => Count(_operators.Union(_leftQuantities, _rightQuantities));

    [Benchmark(Description = "Union<CqlConcept>")]
    public int UnionConcept() => Count(_operators.Union(_leftConcepts, _rightConcepts));

    [Benchmark(Description = "Distinct<int>")]
    public int DistinctInt() => Count(_operators.Distinct(_intsWithDuplicates));

    [Benchmark(Description = "Distinct<string>")]
    public int DistinctString() => Count(_operators.Distinct(_stringsWithDuplicates));

    [Benchmark(Description = "Distinct<CqlQuantity>")]
    public int DistinctQuantity() => Count(_operators.Distinct(_quantitiesWithDuplicates));

    [Benchmark(Description = "Distinct<CqlConcept>")]
    public int DistinctConcept() => Count(_operators.Distinct(_conceptsWithDuplicates));

    private static int Count<T>(IEnumerable<T>? values) => values?.Count() ?? 0;
}
