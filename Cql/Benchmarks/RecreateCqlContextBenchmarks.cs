using BenchmarkDotNet.Attributes;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;
using System;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Jobs;

namespace Benchmarks;

//[SimpleJob]
[ShortRunJob(RuntimeMoniker.Net80)]
[ShortRunJob(RuntimeMoniker.Net90)]
[MemoryDiagnoser]
public class RecreateCqlContextBenchmarks
{
    [Benchmark(Description = "Creating CqlContext with no cache for FhirTypeConverter", Baseline = true)]
    public CqlContext CreateContext_WithNoLRUCache()
    {
        DoNotJitAway(Random.Shared.Next(10, 50));
        var context = CreateCqlContext(new() { OverrideFhirTypeConverterCacheSize = 0 });
        return context;
    }

    [Benchmark(Description = "Creating CqlContext with default cache size 10000 for FhirTypeConverter")]
    public CqlContext CreateContext_WithDefaultLRUCacheSize()
    {
        DoNotJitAway(Random.Shared.Next(10, 50));
        var context = CreateCqlContext(new() { OverrideFhirTypeConverterCacheSize = FhirTypeConverter.DefaultCacheSize });
        return context;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void DoNotJitAway(int next)
    {
    }

    [Benchmark(Description = "Creating CqlContext with random cache size for FhirTypeConverter between 10 and 50")]
    public CqlContext CreateContext_WithRandomLRUCacheSize()
    {
        var cacheSize = Random.Shared.Next(10, 50);
        var context = CreateCqlContext(new() { OverrideFhirTypeConverterCacheSize = cacheSize });
        return context;
    }

    protected static CqlContext CreateCqlContext(
        FhirCqlContextOptions? options = null) =>
        FhirCqlContext.CreateContext(options: options);
}