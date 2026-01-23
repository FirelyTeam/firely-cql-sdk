/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Runtime;
using Hl7.Cql.Runtime.Internal;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Reflection;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;

namespace CqlSdkExamples;

partial class Program
{
    void CachingExample()
    {
        Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║          CQL SDK Array-Based Caching Example                  ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════════════╝\n");

        PreferredApproach_UsingInvocationToolkit();
        Console.WriteLine("\n" + new string('═', 66) + "\n");
        NonPreferredApproach_ManualDllLoading();
    }

    /// <summary>
    /// PREFERRED APPROACH: Using InvocationToolkit
    /// The InvocationToolkit automatically handles cache index initialization for you.
    /// This is the recommended way to use caching in the CQL SDK.
    /// </summary>
    void PreferredApproach_UsingInvocationToolkit()
    {
        Console.WriteLine("█ PREFERRED APPROACH: Using InvocationToolkit");
        Console.WriteLine("█ Cache indices are automatically initialized by LibrarySetInvoker\n");

        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        CqlToolkit cqlToolkit = new(loggerFactory);

        // CQL library with expressions to cache
        var cql = (CqlLibraryString)"""
                                    library CachingExample version '1.0.0'

                                    define "ExpensiveComputation":
                                        Sum({1, 2, 3, 4, 5, 6, 7, 8, 9, 10})

                                    define "NullValue":
                                        null

                                    define "AnotherExpression":
                                        'This is also cached'
                                    """;

        // Create library set invoker - cache indices are initialized automatically
        using LibrarySetInvoker librarySetInvoker =
            cqlToolkit
                .AddCqlLibraries(cql)
                .CreateLibrarySetInvoker();

        var cache = librarySetInvoker.Cache;
        cache.StartNewCache(); // Initialize cache with default ExecutionAndPublication strategy
        Console.WriteLine($"✓ Library loaded. Cache size: {cache.CacheEntriesCount} entries\n");

        // Example 1: Basic caching
        Console.WriteLine("1. Basic Caching (ExecutionAndPublication strategy - default):");
        var context1 = FhirCqlContext.WithDataSource();

        var sw = Stopwatch.StartNew();
        for (int i = 0; i < 3; i++)
        {
            var result = librarySetInvoker.InvokeLibraryDefinition(
                context1,
                cql.LibraryIdentifier,
                "ExpensiveComputation");
            Console.WriteLine($"   Call {i + 1}: Result = {result} " +
                            $"({(i == 0 ? "computed" : "cached")})");
        }
        Console.WriteLine($"   Time: {sw.ElapsedMilliseconds}ms");
        Console.WriteLine($"   Cache hits: {cache.CacheHits}, misses: {cache.CacheMisses}\n");

        // Example 2: Caching null values (now supported!)
        Console.WriteLine("2. Caching Null Values:");
        cache.StartNewCache(); // Reset cache for demonstration
        var context2 = FhirCqlContext.WithDataSource();

        for (int i = 0; i < 2; i++)
        {
            var result = librarySetInvoker.InvokeLibraryDefinition(
                context2,
                cql.LibraryIdentifier,
                "NullValue");
            Console.WriteLine($"   Call {i + 1}: Result = {result ?? "(null)"} " +
                            $"({(i == 0 ? "computed and cached" : "retrieved from cache")})");
        }
        Console.WriteLine($"   Cache hits: {cache.CacheHits}, misses: {cache.CacheMisses}\n");

        // Example 3: PublicationOnly strategy (allow multiple concurrent computations)
        Console.WriteLine("3. PublicationOnly Strategy (multiple threads can compute concurrently):");
        cache.StartNewCache(CacheWriteStrategy.PublicationOnly); // Use PublicationOnly strategy
        var context3 = FhirCqlContext.WithDataSource();
        Console.WriteLine("   ✓ Using PublicationOnly: Multiple threads can compute, last write wins");
        Console.WriteLine("   ✓ Per-entry locking: Different cache entries don't contend with each other");

        var result3 = librarySetInvoker.InvokeLibraryDefinition(
            context3,
            cql.LibraryIdentifier,
            "ExpensiveComputation");
        Console.WriteLine($"   Result: {result3} (fastest mode for read-heavy scenarios)\n");

        // Example 4: Cache invalidation
        Console.WriteLine("4. Cache Invalidation:");
        cache.StartNewCache(); // Initialize cache
        var context4 = FhirCqlContext.WithDataSource();

        var result4a = librarySetInvoker.InvokeLibraryDefinition(
            context4,
            cql.LibraryIdentifier,
            "ExpensiveComputation");
        Console.WriteLine($"   First call: {result4a} (computed)");
        Console.WriteLine($"   Cache stats: {cache.CacheHits} hits, {cache.CacheMisses} misses");

        cache.StartNewCache(); // Reset cache - invalidates old cached values
        var result4b = librarySetInvoker.InvokeLibraryDefinition(
            context4,
            cql.LibraryIdentifier,
            "ExpensiveComputation");
        Console.WriteLine($"   After StartNewCache(): {result4b} (recomputed)");
        Console.WriteLine($"   Cache stats: {cache.CacheHits} hits, {cache.CacheMisses} misses\n");

        // Example 5: Cache statistics
        Console.WriteLine("5. Cache Statistics Monitoring:");
        cache.StartNewCache();
        var context5 = FhirCqlContext.WithDataSource();

        // Execute several expressions
        for (int i = 0; i < 5; i++)
        {
            _ = librarySetInvoker.InvokeLibraryDefinition(context5, cql.LibraryIdentifier, "ExpensiveComputation");
            _ = librarySetInvoker.InvokeLibraryDefinition(context5, cql.LibraryIdentifier, "NullValue");
        }

        Console.WriteLine($"   Total cache calls: {cache.CacheCallCount}");
        Console.WriteLine($"   Cache hits: {cache.CacheHits}");
        Console.WriteLine($"   Cache misses: {cache.CacheMisses}");
        var effectiveness = cache.CacheCallCount > 0 ? (cache.CacheHits * 100.0 / cache.CacheCallCount) : 0;
        Console.WriteLine($"   Cache effectiveness: {effectiveness:F1}%");

        Console.WriteLine("\n✓ Preferred Approach Complete!");
        Console.WriteLine("  • Cache indices initialized automatically");
        Console.WriteLine("  • Optimal cache size determined automatically");
        Console.WriteLine("  • Zero reflection overhead");
        Console.WriteLine("  • Type-safe generated code");
    }

    /// <summary>
    /// NON-PREFERRED APPROACH: Manual Library Usage
    /// Only use this if you're NOT using the InvocationToolkit.
    /// Requires manual cache management.
    /// </summary>
    void NonPreferredApproach_ManualDllLoading()
    {
        Console.WriteLine("█ NON-PREFERRED APPROACH: Manual Library Usage");
        Console.WriteLine("█ Use only when NOT using InvocationToolkit\n");
        Console.WriteLine("⚠ WARNING: This approach is more complex and error-prone.");
        Console.WriteLine("⚠ Use the InvocationToolkit approach above whenever possible.\n");

        // Step 1: Compile CQL to get libraries (simulated here - in real scenario you'd load from DLLs)
        Console.WriteLine("Step 1: Compile CQL to get library instances");
        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        CqlToolkit cqlToolkit = new(loggerFactory);

        var cql = (CqlLibraryString)"""
                                    library ManualExample version '1.0.0'

                                    define "TestExpression":
                                        42

                                    define "NullExpression":
                                        null
                                    """;

        using var tempInvoker = cqlToolkit
            .AddCqlLibraries(cql)
            .CreateLibrarySetInvoker();

        // Step 2: Extract ILibrary instances from the invoker
        Console.WriteLine("Step 2: Extract ILibrary instances");
        var libraries = ExtractLibrariesFromAssemblies(tempInvoker);
        Console.WriteLine($"   Found {libraries.Length} library/libraries\n");

        // Step 3: CRITICAL - Create CqlLibrarySetInvocationCache manually
        Console.WriteLine("Step 3: Create CqlLibrarySetInvocationCache manually");
        var cache = new CqlLibrarySetInvocationCache(libraries);
        cache.StartNewCache(); // Initialize the cache
        Console.WriteLine($"   ✓ Initialized {cache.CacheEntriesCount} cache entries");
        Console.WriteLine($"   ✓ Cache enabled and ready\n");

        // Step 4: Use the library with manual method invocation
        Console.WriteLine("Step 4: Invoke library expressions manually");
        var context = FhirCqlContext.WithDataSource();
        var library = libraries[0];

        var testExpressionMethod = library.GetType().GetMethod("TestExpression");
        if (testExpressionMethod != null)
        {
            // First call - cache miss
            var result1 = testExpressionMethod.Invoke(library, [context]);
            Console.WriteLine($"   First call: {result1}");
            Console.WriteLine($"   Cache stats: {cache.CacheHits} hits, {cache.CacheMisses} misses");

            // Second call - cache hit
            var result2 = testExpressionMethod.Invoke(library, [context]);
            Console.WriteLine($"   Second call: {result2} (cached)");
            Console.WriteLine($"   Cache stats: {cache.CacheHits} hits, {cache.CacheMisses} misses");
        }

        // Null value caching
        var nullExpressionMethod = library.GetType().GetMethod("NullExpression");
        if (nullExpressionMethod != null)
        {
            Console.WriteLine($"\n   Testing null value caching:");
            var nullResult1 = nullExpressionMethod.Invoke(library, [context]);
            Console.WriteLine($"   First call: {nullResult1 ?? "(null)"} (computed)");

            var nullResult2 = nullExpressionMethod.Invoke(library, [context]);
            Console.WriteLine($"   Second call: {nullResult2 ?? "(null)"} (cached null value!)");
            Console.WriteLine($"   Cache stats: {cache.CacheHits} hits, {cache.CacheMisses} misses\n");
        }

        Console.WriteLine("✗ Manual Approach Complete (NOT RECOMMENDED)");
        Console.WriteLine("  • Requires manual CqlLibrarySetInvocationCache creation");
        Console.WriteLine("  • Must manually invoke library methods via reflection");
        Console.WriteLine("  • More error-prone than InvocationToolkit");
        Console.WriteLine("  • Only use when InvocationToolkit cannot be used");
    }

    /// <summary>
    /// Helper method to extract ILibrary instances from a LibrarySetInvoker.
    /// In a real scenario, you'd load these from DLL files using Assembly.LoadFrom() and instantiate them.
    /// </summary>
    private ILibrary[] ExtractLibrariesFromAssemblies(LibrarySetInvoker invoker)
    {
        var libraries = new List<ILibrary>();

        foreach (var libraryInvoker in invoker.LibraryInvokers.Values)
        {
            // Use reflection to get the Library property (it's internal)
            var libraryProperty = libraryInvoker.GetType().GetProperty("Library",
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            if (libraryProperty != null)
            {
                var library = libraryProperty.GetValue(libraryInvoker) as ILibrary;
                if (library != null)
                {
                    libraries.Add(library);
                }
            }
        }

        return [.. libraries];
    }
}
