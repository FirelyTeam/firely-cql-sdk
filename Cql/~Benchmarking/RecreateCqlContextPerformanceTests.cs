#nullable enable
using System.Threading;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Jobs;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;

namespace Benchmarking;

[ShortRunJob]
// public class RecreateCqlContextPerformanceTests
// {
//     private static readonly FhirCqlContextOptions NoCacheFhirCqlContextOptions = new() { OverrideFhirTypeConverterCacheSize = 0 };
//     private static readonly FhirCqlContextOptions WithDefaultCacheFhirCqlContextOptions = new() { OverrideFhirTypeConverterCacheSize = FhirTypeConverter.DefaultCacheSize };
//
//     [Benchmark(Description = "Creating CqlContext with no cache for FhirTypeConverter")]
//     public void CreateContext_WithNoLRUCache()
//     {
//         Thread.Sleep(10);
//         var context = CreateCqlContext(NoCacheFhirCqlContextOptions);
//         //return context;
//     }
//
//     [Benchmark(Description = "Creating CqlContext with default cache size 10000 for FhirTypeConverter")]
//     public void CreateContext_WithLRUCache()
//     {
//         Thread.Sleep(15);
//         var context = CreateCqlContext(WithDefaultCacheFhirCqlContextOptions);
//         //return context;
//     }
//
//     protected static CqlContext CreateCqlContext(
//         FhirCqlContextOptions? options = null)
//     {
//         var context = FhirCqlContext.CreateContext(options: options);
//         return context;
//     }
// }

//[SimpleJob(RunStrategy.Throughput, RuntimeMoniker.Net80)]
[SimpleJob(RunStrategy.Throughput, launchCount: 3, warmupCount: 5, iterationCount: 10)]
public class IntroBasic
{
    // And define a method with the Benchmark attribute
    [Benchmark(Description = "Thread.Sleep(10)")]
    public void Sleep() => Thread.Sleep(100);

    // You can write a description for your method.
    [Benchmark(Description = "Thread.Sleep(200)")]
    public void SleepWithDescription() => Thread.Sleep(200);
}