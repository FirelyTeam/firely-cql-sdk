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
/// Measures the age operators over a single-patient bundle. Measure logic evaluates these per element of a query -
/// <c>AgeInYearsAt(start of Encounter.period)</c> inside a <c>where</c> clause, say - rather than once per patient,
/// so <see cref="Calls"/> stands for the elements of such a query.
/// </summary>
[ShortRunJob]
[MemoryDiagnoser]
public class AgeOperatorBenchmarks
{
    private ICqlOperators _operators = null!;
    private CqlDate _asOf = null!;

    /// <summary>
    /// How many times the operator is evaluated, i.e. how many elements the surrounding query has.
    /// </summary>
    [Params(1, 10, 200)]
    public int Calls { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        _operators = CreateOperators();
        _asOf = new CqlDate(2024, 6, 1);
    }

    [Benchmark(Description = "AgeAt, once per element of a query")]
    public int AgeAt()
    {
        var total = 0;
        for (var i = 0; i < Calls; i++)
            total += _operators.AgeAt(_asOf, "year") ?? 0;

        return total;
    }

    [Benchmark(Description = "Age, once per element of a query")]
    public int Age()
    {
        var total = 0;
        for (var i = 0; i < Calls; i++)
            total += _operators.Age("year") ?? 0;

        return total;
    }

    [Benchmark(Description = "AgeAt, context setup + query elements")]
    public int AgeAtWithContextSetup()
    {
        var operators = CreateOperators();
        var total = 0;
        for (var i = 0; i < Calls; i++)
            total += operators.AgeAt(_asOf, "year") ?? 0;

        return total;
    }

    private static ICqlOperators CreateOperators()
    {
        var bundle = new Bundle { Type = Bundle.BundleType.Collection };
        bundle.Entry.Add(new Bundle.EntryComponent
        {
            Resource = new Patient { Id = "patient", BirthDate = "1980-05-17" }
        });

        return FhirCqlContext.ForBundle(bundle).Operators;
    }
}
