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
using Hl7.Fhir.Model;

namespace Benchmarks;

/// <summary>
/// Measures the type conversions an evaluation performs per value. Every one of them goes through the same
/// resolution step in <c>TypeConverter</c>, so the conversions here are chosen to be the ones measure logic reaches
/// most: a coded element's enum on its way to a string, and the FHIR primitives on their way to CQL primitives.
/// </summary>
[ShortRunJob]
[MemoryDiagnoser]
public class TypeConversionBenchmarks
{
    private ICqlOperators _operators = null!;
    private object[] _enums = null!;
    private object[] _dateTimes = null!;
    private object[] _quantities = null!;

    /// <summary>
    /// How many values are converted, i.e. how many elements the surrounding query has.
    /// </summary>
    [Params(200)]
    public int Values { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        _operators = FhirCqlContext.WithDataSource().Operators;

        // Boxed up front: the generated code boxes the enum at the Convert<T>(object?) call site, but that cost
        // belongs to the operator signature rather than to the resolution being measured here.
        _enums = Enumerable
            .Range(0, Values)
            .Select(i => (object)(i % 2 == 0 ? EventStatus.Completed : EventStatus.InProgress))
            .ToArray();

        _dateTimes = Enumerable
            .Range(0, Values)
            .Select(i => (object)new FhirDateTime($"2024-{(i % 12) + 1:00}-{(i % 28) + 1:00}T09:00:00+00:00"))
            .ToArray();

        _quantities = Enumerable
            .Range(0, Values)
            .Select(i => (object)new Quantity(i, "mg"))
            .ToArray();
    }

    /// <summary>
    /// The conversion behind <c>Encounter.status = 'finished'</c>: the enum to its FHIR wire literal. The custom
    /// converter that claims this pair identifies it by reading a <c>FhirEnumeration</c> attribute.
    /// </summary>
    [Benchmark(Description = "Coded element's enum to its wire literal")]
    public int EnumToString()
    {
        var count = 0;
        foreach (var value in _enums)
        {
            if (_operators.Convert<string>(value) is not null)
                count++;
        }

        return count;
    }

    [Benchmark(Description = "FhirDateTime to CqlDateTime")]
    public int FhirDateTimeToCqlDateTime()
    {
        var count = 0;
        foreach (var value in _dateTimes)
        {
            if (_operators.Convert<CqlDateTime>(value) is not null)
                count++;
        }

        return count;
    }

    [Benchmark(Description = "Quantity to CqlQuantity")]
    public int QuantityToCqlQuantity()
    {
        var count = 0;
        foreach (var value in _quantities)
        {
            if (_operators.Convert<CqlQuantity>(value) is not null)
                count++;
        }

        return count;
    }
}
