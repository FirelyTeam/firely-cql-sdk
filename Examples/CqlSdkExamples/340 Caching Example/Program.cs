/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;

namespace CqlSdkExamples;

partial class Program
{
    void CachingExample()
    {
        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        CqlToolkit cqlToolkit = new(loggerFactory);

        // CQL library with an expensive computation
        var cql = (CqlLibraryString)"""
                                    library CachingExample version '1.0.0'

                                    define "ExpensiveComputation" :
                                        Sum({1, 2, 3, 4, 5, 6, 7, 8, 9, 10})

                                    define "AnotherExpression" :
                                        'This is also cached'
                                    """;

        using LibrarySetInvoker librarySetInvoker =
            cqlToolkit
                .AddCqlLibraries(cql)
                .CreateLibrarySetInvoker();

        Console.WriteLine("=== Caching Example ===\n");

        // Example 1: Without caching (default behavior)
        Console.WriteLine("1. Without caching (default):");
        var context1 = FhirCqlContext.WithDataSource();
        var sw = Stopwatch.StartNew();
        for (int i = 0; i < 3; i++)
        {
            var result = librarySetInvoker.InvokeLibraryDefinition(
                context1,
                cql.LibraryIdentifier,
                "ExpensiveComputation");
            Console.WriteLine($"   Call {i + 1}: Result = {result}");
        }
        Console.WriteLine($"   Time: {sw.ElapsedMilliseconds}ms (no caching)\n");

        // Example 2: With caching enabled
        Console.WriteLine("2. With caching enabled:");
        var context2 = FhirCqlContext.WithDataSource();
        context2.UseNewCache(); // Enable caching
        sw.Restart();
        for (int i = 0; i < 3; i++)
        {
            var result = librarySetInvoker.InvokeLibraryDefinition(
                context2,
                cql.LibraryIdentifier,
                "ExpensiveComputation");
            Console.WriteLine($"   Call {i + 1}: Result = {result} (cached after first call)");
        }
        Console.WriteLine($"   Time: {sw.ElapsedMilliseconds}ms (with caching)\n");

        // Example 3: Cache invalidation
        Console.WriteLine("3. Cache invalidation:");
        var context3 = FhirCqlContext.WithDataSource();
        context3.UseNewCache(); // Start with fresh cache
        var result1 = librarySetInvoker.InvokeLibraryDefinition(
            context3,
            cql.LibraryIdentifier,
            "ExpensiveComputation");
        Console.WriteLine($"   First call: {result1} (computed and cached)");

        context3.UseNewCache(); // Invalidate cache - creates new cache
        var result2 = librarySetInvoker.InvokeLibraryDefinition(
            context3,
            cql.LibraryIdentifier,
            "ExpensiveComputation");
        Console.WriteLine($"   After UseNewCache(): {result2} (recomputed with fresh cache)\n");

        // Example 4: Disabling caching
        Console.WriteLine("4. Disabling caching:");
        var context4 = FhirCqlContext.WithDataSource();
        context4.UseNewCache(); // Enable caching
        librarySetInvoker.InvokeLibraryDefinition(context4, cql.LibraryIdentifier, "ExpensiveComputation");
        Console.WriteLine("   Caching enabled, expression evaluated and cached");

        context4.DontUseCaching(); // Disable caching
        librarySetInvoker.InvokeLibraryDefinition(context4, cql.LibraryIdentifier, "ExpensiveComputation");
        Console.WriteLine("   After DontUseCaching(): expression recomputed (no caching)\n");

        // Example 5: Parallel execution with independent caches
        Console.WriteLine("5. Parallel execution (each context has its own cache):");
        Parallel.For(0, 3, i =>
        {
            var context = FhirCqlContext.WithDataSource();
            context.UseNewCache(); // Each context gets its own cache
            var result = librarySetInvoker.InvokeLibraryDefinition(
                context,
                cql.LibraryIdentifier,
                "ExpensiveComputation");
            Console.WriteLine($"   Thread {i}: Result = {result} (independent cache)");
        });

        Console.WriteLine("\nKey Points:");
        Console.WriteLine("- Caching is OFF by default");
        Console.WriteLine("- Call UseNewCache() to enable caching");
        Console.WriteLine("- Each CqlContext has its own independent cache");
        Console.WriteLine("- Only parameter-less expressions are cached");
        Console.WriteLine("- Use DontUseCaching() to disable caching");
        Console.WriteLine("- Thread-safe for parallel execution");
    }
}
