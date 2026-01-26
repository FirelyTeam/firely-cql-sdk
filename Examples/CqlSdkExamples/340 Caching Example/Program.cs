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

        // Get the library invocation set
        var libraryInvocationSet = librarySetInvoker.LibraryInvocationSet;
        Console.WriteLine($"✓ Library loaded. Cache size: {libraryInvocationSet.CacheEntriesCount} entries\n");

        // Example 1: Basic caching with StartCachingScope (PREFERRED)
        Console.WriteLine("1. Basic Caching using StartCachingScope (RECOMMENDED):");
        var context1 = FhirCqlContext.WithDataSource();
        
        var sw = Stopwatch.StartNew();
        using (context1.StartCachingScope(libraryInvocationSet)) // Automatic cleanup on dispose
        {
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
            Console.WriteLine($"   Cache hits: {context1.CacheHits}, misses: {context1.CacheMisses}");
        } // Cache automatically stopped and arrays returned to pool
        Console.WriteLine("   ✓ Cache cleaned up automatically\n");

        // Example 2: Caching null values (now supported!)
        Console.WriteLine("2. Caching Null Values:");
        var context2 = FhirCqlContext.WithDataSource();
        
        using (context2.StartCachingScope(libraryInvocationSet))
        {
            for (int i = 0; i < 2; i++)
            {
                var result = librarySetInvoker.InvokeLibraryDefinition(
                    context2,
                    cql.LibraryIdentifier,
                    "NullValue");
                Console.WriteLine($"   Call {i + 1}: Result = {result ?? "(null)"} " +
                                $"({(i == 0 ? "computed and cached" : "retrieved from cache")})");
            }
            Console.WriteLine($"   Cache hits: {context2.CacheHits}, misses: {context2.CacheMisses}");
        }
        Console.WriteLine();

        // Example 3: PublicationOnly strategy (allow multiple concurrent computations)
        Console.WriteLine("3. PublicationOnly Strategy (multiple threads can compute concurrently):");
        var context3 = FhirCqlContext.WithDataSource();
        
        using (context3.StartCachingScope(libraryInvocationSet, CacheWriteStrategy.PublicationOnly))
        {
            Console.WriteLine("   ✓ Using PublicationOnly: Multiple threads can compute, last write wins");
            Console.WriteLine("   ✓ Per-entry locking: Different cache entries don't contend with each other");
            
            var result3 = librarySetInvoker.InvokeLibraryDefinition(
                context3,
                cql.LibraryIdentifier,
                "ExpensiveComputation");
            Console.WriteLine($"   Result: {result3} (fastest mode for read-heavy scenarios)");
        }
        Console.WriteLine();

        // Example 4: Comparison - StartCachingScope vs manual StartCaching/StopCaching
        Console.WriteLine("4. Comparison: StartCachingScope (preferred) vs Manual (when needed):");
        
        // Preferred: StartCachingScope
        Console.WriteLine("   a) Using StartCachingScope (RECOMMENDED):");
        var context4a = FhirCqlContext.WithDataSource();
        using (context4a.StartCachingScope(libraryInvocationSet))
        {
            var result = librarySetInvoker.InvokeLibraryDefinition(
                context4a,
                cql.LibraryIdentifier,
                "ExpensiveComputation");
            Console.WriteLine($"      Result: {result}");
            Console.WriteLine($"      Cache stats: {context4a.CacheHits} hits, {context4a.CacheMisses} misses");
        } // Automatically cleaned up
        Console.WriteLine("      ✓ Resources automatically released");
        
        // Alternative: Manual control
        Console.WriteLine("\n   b) Using manual StartCaching/StopCaching (when you need control):");
        var context4b = FhirCqlContext.WithDataSource();
        context4b.StartCaching(libraryInvocationSet);
        var result4b = librarySetInvoker.InvokeLibraryDefinition(
            context4b,
            cql.LibraryIdentifier,
            "ExpensiveComputation");
        Console.WriteLine($"      Result: {result4b}");
        Console.WriteLine($"      Cache stats: {context4b.CacheHits} hits, {context4b.CacheMisses} misses");
        context4b.StopCaching(); // Manual cleanup required
        Console.WriteLine("      ✓ Resources manually released with StopCaching()\n");

        // Example 5: Cache statistics
        Console.WriteLine("5. Cache Statistics Monitoring:");
        var context5 = FhirCqlContext.WithDataSource();
        
        using (context5.StartCachingScope(libraryInvocationSet))
        {
            // Execute several expressions
            for (int i = 0; i < 5; i++)
            {
                _ = librarySetInvoker.InvokeLibraryDefinition(context5, cql.LibraryIdentifier, "ExpensiveComputation");
                _ = librarySetInvoker.InvokeLibraryDefinition(context5, cql.LibraryIdentifier, "NullValue");
            }
            
            Console.WriteLine($"   Total cache calls: {context5.CacheCallCount}");
            Console.WriteLine($"   Cache hits: {context5.CacheHits}");
            Console.WriteLine($"   Cache misses: {context5.CacheMisses}");
            var effectiveness = context5.CacheCallCount > 0 ? (context5.CacheHits * 100.0 / context5.CacheCallCount) : 0;
            Console.WriteLine($"   Cache effectiveness: {effectiveness:F1}%");
        }

        Console.WriteLine("\n✓ Preferred Approach Complete!");
        Console.WriteLine("  • Cache indices initialized automatically");
        Console.WriteLine("  • Optimal cache size determined automatically");
        Console.WriteLine("  • Zero reflection overhead");
        Console.WriteLine("  • Type-safe generated code");
        Console.WriteLine("  • Automatic resource cleanup with StartCachingScope");
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

        // Step 3: CRITICAL - Create CqlLibraryInvocationSet and start caching on context
        Console.WriteLine("Step 3: Create CqlLibraryInvocationSet and start caching on context");
        var libraryInvocationSet = new CqlLibraryInvocationSet(libraries);
        Console.WriteLine($"   ✓ Initialized {libraryInvocationSet.CacheEntriesCount} cache entries in library set");

        // Step 4: Use the library with manual method invocation
        Console.WriteLine("\nStep 4: Invoke library expressions manually");
        var context = FhirCqlContext.WithDataSource();
        
        using (context.StartCachingScope(libraryInvocationSet))
        {
            Console.WriteLine($"   ✓ Cache enabled with {libraryInvocationSet.CacheEntriesCount} entries");
            Console.WriteLine($"   ✓ Cache ready\n");
            
            var library = libraries[0];
            
            var testExpressionMethod = library.GetType().GetMethod("TestExpression");
            if (testExpressionMethod != null)
            {
                // First call - cache miss
                var result1 = testExpressionMethod.Invoke(library, [context]);
                Console.WriteLine($"   First call: {result1}");
                Console.WriteLine($"   Cache stats: {context.CacheHits} hits, {context.CacheMisses} misses");
                
                // Second call - cache hit
                var result2 = testExpressionMethod.Invoke(library, [context]);
                Console.WriteLine($"   Second call: {result2} (cached)");
                Console.WriteLine($"   Cache stats: {context.CacheHits} hits, {context.CacheMisses} misses");
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
                Console.WriteLine($"   Cache stats: {context.CacheHits} hits, {context.CacheMisses} misses\n");
            }
        } // Cache automatically stopped and cleaned up

        Console.WriteLine("✗ Manual Approach Complete (NOT RECOMMENDED)");
        Console.WriteLine("  • Requires manual CqlLibraryInvocationSet creation");
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
