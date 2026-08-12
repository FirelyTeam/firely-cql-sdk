/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using BenchmarkDotNet.Attributes;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;
using BenchmarkDotNet.Jobs;

namespace Benchmarks;

//[SimpleJob]
[ShortRunJob(RuntimeMoniker.Net80)]
[ShortRunJob(RuntimeMoniker.Net90)]
[MemoryDiagnoser]
public class RecreateCqlContextBenchmarks
{
    [Params(true, false)]
    public bool EnableTypeConverterReuse { get; set; }

    [Benchmark(Description = "Creating CqlContext with the default FhirTypeConverter")]
    public CqlContext CreateContext()
    {
        FhirTypeConverter.DisableReuseForBenchmarks = !EnableTypeConverterReuse;
        var context = CreateCqlContext(new());
        return context;
    }

    protected static CqlContext CreateCqlContext(
        FhirCqlContextOptions? options = null) =>
        FhirCqlContext.CreateContext(options: options);
}
