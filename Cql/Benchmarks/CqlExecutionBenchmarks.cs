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
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;

namespace Benchmarks;

/// <summary>
/// Measures the operator-level work an evaluation does per element, over a bundle the size of a single patient's
/// record. Each benchmark stands for a shape that shows up throughout real measure logic rather than for one
/// operator in isolation: a retrieve whose result several expressions read, a property reached through a choice
/// type, a coded element compared against a string literal, and the list and sort operators that combine them.
/// </summary>
[ShortRunJob]
[MemoryDiagnoser]
public class CqlExecutionBenchmarks
{
    private const string ConditionValueSet = "http://example.org/fhir/ValueSet/conditions";
    private const string SnomedUri = "http://snomed.info/sct";

    private CqlContext _context = null!;
    private ICqlOperators _operators = null!;
    private RetrieveParameters _retrieveByValueSet = null!;
    private List<object> _left = null!;
    private List<object> _right = null!;
    private List<object> _toSort = null!;
    private FhirDateTime[] _dateTimes = null!;
    private object[] _codedElements = null!;

    /// <summary>
    /// The number of resources of the retrieved type in the bundle.
    /// </summary>
    [Params(200)]
    public int ResourceCount { get; set; }

    /// <summary>
    /// How many expressions read the same retrieve. A definition's value is computed once and cached, but every
    /// expression referring to it walks the result again.
    /// </summary>
    [Params(1, 8)]
    public int Readers { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        var bundle = BuildBundle(ResourceCount);

        var valueSets = new HashValueSetDictionary();
        valueSets.Add(ConditionValueSet, Enumerable
            .Range(0, 16)
            .Select(i => new CqlCode($"code-{i}", SnomedUri))
            .ToList());

        _context = FhirCqlContext.ForBundle(bundle, valueSets: valueSets);
        _operators = _context.Operators;

        _retrieveByValueSet = new RetrieveParameters(
            CodeProperty: null,
            ValueSet: new CqlValueSet(ConditionValueSet, null),
            Codes: null,
            TemplateId: null);

        _left = Enumerable.Range(0, ResourceCount).Select(i => (object)$"element-{i}").ToList();
        _right = Enumerable.Range(0, ResourceCount).Select(i => (object)$"element-{i}").ToList();
        _toSort = Enumerable.Range(0, ResourceCount).Select(i => (object)$"element-{(i * 7919) % ResourceCount}").ToList();

        _dateTimes = Enumerable
            .Range(0, ResourceCount)
            .Select(i => new FhirDateTime($"2024-{(i % 12) + 1:00}-{(i % 28) + 1:00}T09:00:00+00:00"))
            .ToArray();

        // The enum behind a coded element, which is what the generated code compares against a string literal.
        _codedElements = Enumerable
            .Range(0, ResourceCount)
            .Select(i => (object)(i % 2 == 0 ? Encounter.EncounterStatus.Finished : Encounter.EncounterStatus.InProgress))
            .ToArray();
    }

    private static Bundle BuildBundle(int resourceCount)
    {
        var bundle = new Bundle { Type = Bundle.BundleType.Collection };

        bundle.Entry.Add(new Bundle.EntryComponent
        {
            Resource = new Patient { Id = "patient", BirthDate = "1980-05-17" }
        });

        for (var i = 0; i < resourceCount; i++)
        {
            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = new Condition
                {
                    Id = $"condition-{i}",
                    Code = new CodeableConcept(SnomedUri, $"code-{i % 32}"),
                    ClinicalStatus = new CodeableConcept("http://terminology.hl7.org/CodeSystem/condition-clinical", "active"),
                    Onset = new FhirDateTime($"2024-{(i % 12) + 1:00}-{(i % 28) + 1:00}T09:00:00+00:00")
                }
            });
        }

        return bundle;
    }

    /// <summary>
    /// A code-filtered retrieve, read by <see cref="Readers"/> expressions. The retrieve itself decides membership
    /// once per resource; the question is what each additional reader of the result costs.
    /// </summary>
    [Benchmark(Description = "Retrieve by value set, read by N expressions")]
    public int RetrieveByValueSet()
    {
        var conditions = _operators.Retrieve<Condition>(_retrieveByValueSet);

        var count = 0;
        for (var reader = 0; reader < Readers; reader++)
        {
            foreach (var _ in conditions)
                count++;
        }

        return count;
    }

    /// <summary>
    /// An unfiltered retrieve, read by <see cref="Readers"/> expressions - the <c>[Condition]</c> form, without a
    /// terminology filter.
    /// </summary>
    [Benchmark(Description = "Retrieve all of a type, read by N expressions")]
    public int RetrieveAll()
    {
        var conditions = _operators.Retrieve<Condition>(null);

        var count = 0;
        for (var reader = 0; reader < Readers; reader++)
        {
            foreach (var _ in conditions)
                count++;
        }

        return count;
    }

    /// <summary>
    /// Reading a property off a value whose type is only known at runtime, which is what an element reached through
    /// a choice or union type comes down to.
    /// </summary>
    [Benchmark(Description = "Late-bound property access per element")]
    public int LateBoundProperty()
    {
        var count = 0;
        foreach (var dateTime in _dateTimes)
        {
            if (_operators.LateBoundProperty<CqlDateTime>(dateTime, "value") is not null)
                count++;
        }

        return count;
    }

    /// <summary>
    /// Comparing a coded element against a string literal — <c>Encounter.status = 'finished'</c> — in the shape the
    /// code generator actually emits for it: convert the enum behind the element to its FHIR wire literal, then
    /// compare two strings.
    /// </summary>
    /// <remarks>
    /// Deliberately not <see cref="ICqlOperators.EnumEqualsString"/>, which reads like the operator for this and is
    /// measured separately below. No generated library calls it — the generator emits the two-step form instead —
    /// so measuring it would say nothing about what an evaluation spends here.
    /// </remarks>
    [Benchmark(Description = "Coded element compared to a string literal (generated shape)")]
    public int CodedElementEqualsString()
    {
        var count = 0;
        foreach (var coded in _codedElements)
        {
            var literal = _operators.Convert<string>(coded);
            if (_operators.Equal(literal, "finished") == true)
                count++;
        }

        return count;
    }

    /// <summary>
    /// The same comparison through <see cref="ICqlOperators.EnumEqualsString"/>, which routes it to the enum
    /// comparer in one step. Nothing the generator emits reaches this operator today; it is measured so that the
    /// path stays covered for hosts calling <see cref="ICqlOperators"/> directly.
    /// </summary>
    [Benchmark(Description = "Coded element compared to a string literal (EnumEqualsString)")]
    public int CodedElementEnumEqualsString()
    {
        var count = 0;
        foreach (var coded in _codedElements)
        {
            if (_operators.EnumEqualsString(coded, "finished") == true)
                count++;
        }

        return count;
    }

    /// <summary>
    /// <c>right included in left</c> over two lists of the same size.
    /// </summary>
    [Benchmark(Description = "List includes list")]
    public bool? ListIncludesList() =>
        _operators.ListIncludesList(_left, _right);

    /// <summary>
    /// A sort whose result is walked twice, which is what happens whenever a sorted definition feeds more than one
    /// expression.
    /// </summary>
    [Benchmark(Description = "Sort by an expression, result walked twice")]
    public int SortBy()
    {
        var sorted = _operators.SortBy(_toSort, e => e, ListSortDirection.Ascending)!;

        var count = 0;
        foreach (var _ in sorted)
            count++;
        foreach (var _ in sorted)
            count++;

        return count;
    }

    /// <summary>
    /// The age operators, which measure logic evaluates per element of a query rather than once per patient.
    /// </summary>
    [Benchmark(Description = "AgeAt per element")]
    public int AgeAt()
    {
        var asOf = new CqlDate(2024, 6, 1);

        var total = 0;
        for (var i = 0; i < ResourceCount; i++)
            total += _operators.AgeAt(asOf, "year") ?? 0;

        return total;
    }
}
