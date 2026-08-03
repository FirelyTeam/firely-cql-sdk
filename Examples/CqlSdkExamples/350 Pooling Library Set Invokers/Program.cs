/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Microsoft.Extensions.Logging;

namespace CqlSdkExamples;

partial class Program
{
    void PoolingLibrarySetInvokers()
    {
        // Only warnings and above, so the pool's own behavior is easy to see. Drop this to
        // Information and the "Loaded assembly ..." lines make the point on their own: they appear
        // for the first request and never again.
        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole().SetMinimumLevel(LogLevel.Warning));

        var cql = (CqlLibraryString)"""
                                    library PoolingExample version '1.0.0'

                                    define "Answer" :
                                        6 * 7
                                    """;

        // Compile once to assembly binaries. Normally these come from packaged FHIR Library
        // resources; here we build them inline so the example is self-contained.
        //
        // Held as the tuples GetElmToAssemblyResults returns, whose assembly bytes are non-nullable,
        // rather than as AssemblyBinary - whose AssemblyBytes property is typed nullable, so cloning
        // through it would need a null-forgiving operator that this way we avoid entirely.
        var compiled =
            new CqlToolkit(loggerFactory)
                .AddCqlLibraries(cql)
                .CompileToAssemblies()
                .GetElmToAssemblyResults()
                .Select(result => (result.assemblyBinary, result.debugSymbolsBinary))
                .ToList();

        // A fresh toolkit over *copies* of the bytes, to show the pool keys on their content rather
        // than on object identity.
        InvocationToolkit CreateToolkit() =>
            new InvocationToolkit(loggerFactory)
                .AddAssemblyBinaries(
                    compiled.Select(binary => new AssemblyBinary(
                        (byte[])binary.assemblyBinary.Clone(),
                        (byte[]?)binary.debugSymbolsBinary?.Clone())));

        Console.WriteLine("=== Pooling LibrarySetInvokers ===\n");

        // Create the pool ONCE and keep it for as long as the process needs these library sets.
        // Capacity is the number of distinct library sets to keep loaded.
        using var pool = new LibrarySetInvokerPool(
            new LibrarySetInvokerPoolOptions(Capacity: 4),
            loggerFactory);

        // 1. Without pooling, every call reloads and re-JIT-compiles the whole library set.
        Console.WriteLine("1. Without pooling - a new AssemblyLoadContext per call:");
        for (int i = 0; i < 3; i++)
        {
            using var invoker = CreateToolkit().CreateLibrarySetInvoker($"unpooled-{i}");
            var result = invoker.InvokeLibraryDefinition(FhirCqlContext.WithDataSource(), cql.LibraryIdentifier, "Answer");
            Console.WriteLine($"   Call {i + 1}: Answer = {result} (loaded its own assemblies, unloaded on dispose)");
        }
        Console.WriteLine();

        // 2. With pooling, the first request loads and the rest are served from the pool.
        Console.WriteLine("2. With pooling - loaded once, reused after that:");
        for (int i = 0; i < 3; i++)
        {
            var invoker = pool.GetOrCreate(CreateToolkit(), "PoolingExample");
            var result = invoker.InvokeLibraryDefinition(FhirCqlContext.WithDataSource(), cql.LibraryIdentifier, "Answer");
            var statistics = pool.Statistics;
            Console.WriteLine(
                $"   Call {i + 1}: Answer = {result}, hits = {statistics.Hits}, misses = {statistics.Misses}");
        }
        Console.WriteLine("   Note only the first call was a miss.\n");

        // 3. Keying is on the *content* of the assembly binaries. Each CreateToolkit() call above
        //    handed the pool brand-new byte arrays, and they all landed on the same entry.
        Console.WriteLine("3. Content keying - separately built toolkits share one entry:");
        var first = pool.GetOrCreate(CreateToolkit(), "PoolingExample");
        var second = pool.GetOrCreate(CreateToolkit(), "PoolingExample");
        Console.WriteLine($"   Same invoker instance: {ReferenceEquals(first, second)}");
        Console.WriteLine($"   Entries held: {pool.Statistics.Entries}\n");

        // 4. One pooled invoker is safe to share across concurrent evaluations, as long as each
        //    evaluation brings its own CqlContext.
        Console.WriteLine("4. Concurrent evaluation over one shared invoker:");
        var shared = pool.GetOrCreate(CreateToolkit(), "PoolingExample");
        Parallel.For(0, 4, i =>
        {
            var context = FhirCqlContext.WithDataSource(); // one context per evaluation
            var result = shared.InvokeLibraryDefinition(context, cql.LibraryIdentifier, "Answer");
            Console.WriteLine($"   Thread {i}: Answer = {result}");
        });
        Console.WriteLine();

        // 5. The pool owns what it hands out. Disposing a pooled invoker is a no-op precisely so
        //    that one caller cannot unload the assemblies out from under the others.
        Console.WriteLine("5. The pool owns the invoker's lifetime:");
        shared.Dispose(); // deliberately ignored while the pool owns it
        var stillUsable = shared.InvokeLibraryDefinition(FhirCqlContext.WithDataSource(), cql.LibraryIdentifier, "Answer");
        Console.WriteLine($"   After Dispose() on a pooled invoker: Answer = {stillUsable} (still usable)\n");

        Console.WriteLine("Key Points:");
        Console.WriteLine("- Pooling is opt-in; CreateLibrarySetInvoker still loads per call");
        Console.WriteLine("- Create one pool and keep it; ask it for an invoker per request");
        Console.WriteLine("- Entries are keyed on assembly-binary content, not object identity");
        Console.WriteLine("- Do NOT dispose a pooled invoker - it is shared, so Dispose() is a no-op");
        Console.WriteLine("- Do NOT retain a LibraryInvoker or DefinitionInvoker past the library set:");
        Console.WriteLine("  each reaches its library set through a back-reference, so holding one keeps");
        Console.WriteLine("  the whole AssemblyLoadContext alive even after the pool evicts it");
        Console.WriteLine("- Watch Statistics.PendingUnloads: if it keeps climbing, something is doing that");
        Console.WriteLine("- Size Capacity to the number of library sets evaluated concurrently");
    }
}
