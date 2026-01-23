# Hl7.Cql.Runtime

A support package for HL7.Cql that contains the required runtime components for CQL execution.

## Overview

This package provides the core runtime engine that executes CQL expressions and operations. It includes the operators, comparers, and runtime context needed to evaluate CQL logic during execution.

## Key Features

- **CQL Operators**: Complete implementation of CQL operators for arithmetic, logical, comparison, and other operations
- **Type Comparers**: Specialized comparison logic for CQL data types
- **Runtime Context**: Execution context management for CQL evaluation
- **High-Performance Caching**: Array-based caching system with zero allocation for maximum performance
- **Expression Evaluation**: Core engine for evaluating CQL expressions
- **FHIR Metrics Support**: Integration with FHIR quantity and unit conversions

## Expression Caching

**Caching is managed through CqlLibrariesExecutionCache.** The runtime supports high-performance array-based caching of CQL expression results.

### Architecture

The caching system uses:
- **0-based array indexing**: Direct array access with no hashing overhead
- **Method references**: Zero delegate allocation
- **Per-entry locking**: Better concurrency for multi-threaded scenarios
- **Cache instance association**: Libraries track which cache initialized them
- **Thread-safe null value support**: Correctly caches and retrieves null results

### Enabling Caching (Preferred: InvocationToolkit)

The preferred approach is to use the InvocationToolkit, which handles cache initialization automatically:

```csharp
var invoker = LibrarySetInvoker.Create(...);
// Cache is automatically configured
var result = invoker.Execute(...);
```

### Manual Caching Setup (Advanced)

For scenarios where you load libraries dynamically (e.g., from DLLs at runtime):

```csharp
// Create cache with your libraries
var cache = new CqlLibrariesExecutionCache(myLibrary);

// Start caching with desired strategy
cache.StartNewCache(CacheWriteStrategy.ExecutionAndPublication);

// Use the cache
var result = cache.GetOrCompute(cacheIndex, factory, context);
```

### Cache Write Strategies

Control how concurrent writes are handled:

```csharp
// ExecutionAndPublication (default): Only one thread computes, others wait
cache.StartNewCache(CacheWriteStrategy.ExecutionAndPublication);

// PublicationOnly: Multiple threads can compute, last write wins (faster for read-heavy workloads)
cache.StartNewCache(CacheWriteStrategy.PublicationOnly);
```

### How It Works

- Libraries generate int cache index fields for each cacheable expression
- `CqlLibrariesExecutionCache` initializes these indices by traversing the library dependency graph
- Each library stores a reference to its cache instance, enabling re-initialization (critical for unit testing)
- Only parameter-less expressions (functions with no parameters except `CqlContext`) are cached
- Cache entries use `CacheEntry` class to distinguish between "not cached" and "cached null value"
- Thread safety is guaranteed through volatile semantics and optional per-entry locking

### Cache Statistics

Monitor cache effectiveness:

```csharp
var cache = new CqlLibrariesExecutionCache(myLibrary);
cache.StartNewCache();

// After execution
Console.WriteLine($"Cache entries: {cache.CacheEntriesCount}");
Console.WriteLine($"Total calls: {cache.CacheCallCount}");
Console.WriteLine($"Cache hits: {cache.CacheHits}");
Console.WriteLine($"Cache misses: {cache.CacheMisses}");
```

### When to Use Caching

Enable caching when:
- Evaluating the same expressions multiple times
- Working with expensive computations that don't depend on parameters
- Performance is critical and expression results are deterministic

**Important**: Create a new cache instance or call `StartNewCache()` when starting a new evaluation cycle to ensure stale data isn't used.

### Re-initialization for Unit Testing

Libraries can be re-initialized with different cache instances, critical for unit testing scenarios where singleton libraries are reused across tests:

```csharp
[Test]
public void Test1()
{
    var cache1 = new CqlLibrariesExecutionCache(library);
    cache1.StartNewCache();
    // ... test with cache1
}

[Test]
public void Test2()
{
    // Same library, different cache - library will be re-initialized
    var cache2 = new CqlLibrariesExecutionCache(library);
    cache2.StartNewCache();
    // ... test with cache2
}
```

## Usage

This package is used by the CQL compiler and other runtime components to execute CQL logic. It provides the foundational runtime services needed for CQL evaluation.

## Dependencies

- **Hl7.Cql.Abstractions**: Core abstractions and interfaces
- **Hl7.Cql.Grammar**: CQL grammar definitions
- **Fhir.Metrics**: FHIR unit and quantity handling
- **Microsoft.Extensions.Logging**: Logging framework support

## Further Reading

This package is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). For getting started, release notes, and contribution guidelines, see the [main README](../../README.md). More information can be found at [Firely's documentation site](https://docs.fire.ly/projects/Firely-NET-SDK/en/latest/cql.html).