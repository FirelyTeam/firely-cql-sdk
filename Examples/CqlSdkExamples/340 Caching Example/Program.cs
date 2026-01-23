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
        cache.StartNewCache();
        Console.WriteLine($"✓ Library loaded. Cache size: {cache.CacheEntriesCount} entries\n");

        // Example 1: Basic caching
        Console.WriteLine("1. Basic Caching (ExecutionAndPublication strategy - default):");
        var context1 = FhirCqlContext.WithDataSource();
        //context1.UseNewCache(cache);  // Enable array-based cache with default strategy

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
        Console.WriteLine($"   Time: {sw.ElapsedMilliseconds}ms\n");

        // Example 2: Caching null values (now supported!)
        Console.WriteLine("2. Caching Null Values:");
        var context2 = FhirCqlContext.WithDataSource();
        cache.StartNewCache();

        for (int i = 0; i < 2; i++)
        {
            var result = librarySetInvoker.InvokeLibraryDefinition(
                context2,
                cql.LibraryIdentifier,
                "NullValue");
            Console.WriteLine($"   Call {i + 1}: Result = {result ?? "(null)"} " +
                            $"({(i == 0 ? "computed and cached" : "retrieved from cache")})");
        }
        Console.WriteLine();

        // Example 3: PublicationOnly strategy (allow multiple concurrent computations)
        Console.WriteLine("3. PublicationOnly Strategy (multiple threads can compute concurrently):");
        var context3 = FhirCqlContext.WithDataSource();
        context3.UseNewCache(librarySetInvoker.LibraryInitializer, CacheWriteStrategy.PublicationOnly);
        Console.WriteLine("   ✓ Using PublicationOnly: Multiple threads can compute, last write wins");
        Console.WriteLine("   ✓ Per-entry locking: Different cache entries don't contend with each other");

        var result3 = librarySetInvoker.InvokeLibraryDefinition(
            context3,
            cql.LibraryIdentifier,
            "ExpensiveComputation");
        Console.WriteLine($"   Result: {result3} (fastest mode for read-heavy scenarios)\n");

        // Example 4: Cache invalidation
        Console.WriteLine("4. Cache Invalidation:");
        var context4 = FhirCqlContext.WithDataSource();
        context4.UseNewCache(librarySetInvoker.LibraryInitializer);

        var result4a = librarySetInvoker.InvokeLibraryDefinition(
            context4,
            cql.LibraryIdentifier,
            "ExpensiveComputation");
        Console.WriteLine($"   First call: {result4a} (computed)");

        context4.UseNewCache(librarySetInvoker.LibraryInitializer); // Create new cache - invalidates old one
        var result4b = librarySetInvoker.InvokeLibraryDefinition(
            context4,
            cql.LibraryIdentifier,
            "ExpensiveComputation");
        Console.WriteLine($"   After UseNewCache(): {result4b} (recomputed)\n");

        // Example 5: Thread safety
        Console.WriteLine("5. Thread-Safe Parallel Execution:");
        Parallel.For(0, 3, i =>
        {
            var context = FhirCqlContext.WithDataSource();
            context.UseNewCache(librarySetInvoker.LibraryInitializer); // Each context has independent cache
            var result = librarySetInvoker.InvokeLibraryDefinition(
                context,
                cql.LibraryIdentifier,
                "ExpensiveComputation");
            Console.WriteLine($"   Thread {i}: Result = {result} (thread-safe)");
        });

        Console.WriteLine("\n✓ Preferred Approach Complete!");
        Console.WriteLine("  • Cache indices initialized automatically");
        Console.WriteLine("  • Optimal cache size determined automatically");
        Console.WriteLine("  • Zero reflection overhead");
        Console.WriteLine("  • Type-safe generated code");
    }

    /// <summary>
    /// NON-PREFERRED APPROACH: Manual DLL Loading
    /// Only use this if you're loading libraries dynamically from DLLs at runtime.
    /// Requires manual cache index initialization using LibraryInitializer.
    /// </summary>
    void NonPreferredApproach_ManualDllLoading()
    {
        Console.WriteLine("█ NON-PREFERRED APPROACH: Manual DLL Loading");
        Console.WriteLine("█ Use only when loading libraries dynamically from DLLs\n");
        Console.WriteLine("⚠ WARNING: This approach is more complex and error-prone.");
        Console.WriteLine("⚠ Use the InvocationToolkit approach above whenever possible.\n");

        // Step 1: Generate DLL (simulated here - in real scenario you'd have pre-compiled DLLs)
        Console.WriteLine("Step 1: Compile CQL to DLL (simulated with InvocationToolkit)");
        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        CqlToolkit cqlToolkit = new(loggerFactory);

        var cql = (CqlLibraryString)"""
                                    library ManualExample version '1.0.0'

                                    define "TestExpression":
                                        42
                                    """;

        using var tempInvoker = cqlToolkit
            .AddCqlLibraries(cql)
            .CreateLibrarySetInvoker();

        // Step 2: Extract ILibrary instances from loaded assemblies
        Console.WriteLine("Step 2: Load DLL and extract ILibrary instances");
        var libraries = ExtractLibrariesFromAssemblies(tempInvoker);
        Console.WriteLine($"   Found {libraries.Length} library/libraries\n");

        // Step 3: CRITICAL - Initialize cache indices manually
        Console.WriteLine("Step 3: Initialize cache indices using LibraryInitializer");
        var initializer = new LibraryInitializer(libraries);
        Console.WriteLine($"   ✓ Initialized {initializer.CacheIndexCount} cache index fields");
        Console.WriteLine($"   ✓ Cache size required: {initializer.CacheIndexCount} entries\n");

        // Step 4: Create CqlContext with properly sized cache
        Console.WriteLine("Step 4: Create CqlContext with caching enabled");
        var context = FhirCqlContext
                      .WithDataSource();
        context.UseNewCache(initializer, CacheWriteStrategy.ExecutionAndPublication);  // Cache indices are now properly initialized
        Console.WriteLine("   ✓ Cache enabled and ready\n");

        // Step 5: Use the library
        Console.WriteLine("Step 5: Invoke library expressions");
        var library = libraries[0];
        var definitionMethod = library.GetType().GetMethod("TestExpression");
        if (definitionMethod != null)
        {
            var result = definitionMethod.Invoke(library, [context]);
            Console.WriteLine($"   Result: {result}");

            // Call again - should use cache
            result = definitionMethod.Invoke(library, [context]);
            Console.WriteLine($"   Result (cached): {result}\n");
        }

        Console.WriteLine("✗ Manual Approach Complete (NOT RECOMMENDED)");
        Console.WriteLine("  • Requires manual cache index initialization");
        Console.WriteLine("  • Must determine cache size via CacheIndexInitializer");
        Console.WriteLine("  • More error-prone than InvocationToolkit");
        Console.WriteLine("  • Only use when absolutely necessary (dynamic DLL loading)");
    }

    /// <summary>
    /// Helper method to extract ILibrary instances from a LibrarySetInvoker
    /// In a real scenario, you'd load these from DLL files using Assembly.LoadFrom()
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
