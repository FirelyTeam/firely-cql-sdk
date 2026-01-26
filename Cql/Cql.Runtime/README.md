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

**Caching is managed through CqlContext.** The runtime supports high-performance array-based caching of CQL expression results with ArrayPool-based memory management for optimal performance and reduced GC pressure.

### Architecture

The caching system uses:
- **0-based array indexing**: Direct array access with no hashing overhead
- **ArrayPool**: Rents/returns arrays to reduce allocations and GC pressure
- **Struct-based entries**: Cache entries are lightweight structs for improved memory locality
- **Method references**: Zero delegate allocation
- **Per-entry locking**: Better concurrency for multi-threaded scenarios (ExecutionAndPublication mode)
- **Context-managed cache**: Each CqlContext has its own cache instance - eliminates race conditions
- **Thread-safe null value support**: Correctly caches and retrieves null results

### Enabling Caching (Preferred: InvocationToolkit)

The preferred approach is to use the InvocationToolkit, which handles cache initialization automatically:

```csharp
var invoker = LibrarySetInvoker.Create(...);
// Cache is automatically configured
var result = invoker.Execute(...);
```

### Manual Caching Setup

**Preferred: Use StartCachingScope** (automatically stops caching when disposed):

```csharp
// Create library invocation set (initializes cache indices)
var libraryInvocationSet = new CqlLibraryInvocationSet(myLibrary);

// Start caching scope - automatically stops when disposed
var context = FhirCqlContext.ForBundle();
using (context.StartCachingScope(libraryInvocationSet))
{
    // Execute with caching enabled
    var result = myLibrary.SomeExpression(context);
    
    // Cache statistics available
    Console.WriteLine($"Hits: {context.CacheHits}, Misses: {context.CacheMisses}");
    
} // Cache automatically stopped and resources released here
```

**Why use StartCachingScope?**
- **Deterministic cleanup**: Automatically stops caching and releases pooled arrays when the scope is disposed
- **Exception safety**: Ensures proper cleanup even if exceptions occur
- **Resource management**: Returns ArrayPool arrays back to the pool immediately
- **Cleaner code**: No need to manually call StopCaching()

**Alternative: Manual start/stop** (when you need more control):

```csharp
var context = FhirCqlContext.ForBundle();
context.StartCaching(libraryInvocationSet);

// Execute with caching enabled
var result = myLibrary.SomeExpression(context);

// Manually stop caching when done
context.StopCaching();
```

**⚠️ IMPORTANT CONSTRAINT:** Each library should be included in only ONE `CqlLibraryInvocationSet` at a time. The constructor initializes internal cache index fields within the libraries. Including the same library in multiple active invocation sets will overwrite these indices, causing cache corruption and incorrect behavior.

If you need different caches for the same libraries (e.g., for unit testing), create a new `CqlLibraryInvocationSet` for each scenario - the libraries will be safely re-initialized with new indices.

### Cache Write Strategies

Control how concurrent writes are handled:

```csharp
// ExecutionAndPublication (default): Only one thread computes, others wait
using (context.StartCachingScope(libraryInvocationSet, CacheWriteStrategy.ExecutionAndPublication))
{
    // ... use cache
}

// PublicationOnly: Multiple threads can compute, last write wins (faster for read-heavy workloads)
using (context.StartCachingScope(libraryInvocationSet, CacheWriteStrategy.PublicationOnly))
{
    // ... use cache
}
```

### How It Works

- Libraries generate int cache index fields for each cacheable expression
- `CqlLibraryInvocationSet` initializes these indices by traversing the library dependency graph
- Each CqlContext manages its own internal cache instance
- Libraries access the cache by calling `context.GetOrCompute(...)` directly
- Only parameter-less expressions (functions with no parameters except `CqlContext`) are cached
- Cache entries use `CacheEntry` struct to distinguish between "not cached" and "cached null value"
- Thread safety is guaranteed through context-per-thread model and optional per-entry locking

### Cache Statistics

Monitor cache effectiveness through the CqlContext:

```csharp
var libraryInvocationSet = new CqlLibraryInvocationSet(myLibrary);
var context = FhirCqlContext.ForBundle();
using (context.StartCachingScope(libraryInvocationSet))
{
    // Execute expressions
    myLibrary.SomeExpression(context);
    
    // Check statistics
    Console.WriteLine($"Caching enabled: {context.CachingEnabled}");
    Console.WriteLine($"Total calls: {context.CacheCallCount}");
    Console.WriteLine($"Cache hits: {context.CacheHits}");
    Console.WriteLine($"Cache misses: {context.CacheMisses}");
}
```

### When to Use Caching

Enable caching when:
- Evaluating the same expressions multiple times
- Working with expensive computations that don't depend on parameters
- Performance is critical and expression results are deterministic

**Important**: Use `StartCachingScope()` in a using block for automatic cleanup and to ensure stale data isn't used between evaluation cycles.

### Thread Safety

Each thread should use its own CqlContext with its own cache:

```csharp
// Thread 1
var ctx1 = FhirCqlContext.ForBundle();
using (ctx1.StartCachingScope(libraryInvocationSet))
{
    var result1 = library.SomeExpression(ctx1); // Uses ctx1's cache
}

// Thread 2
var ctx2 = FhirCqlContext.ForBundle();
using (ctx2.StartCachingScope(libraryInvocationSet))
{
    var result2 = library.SomeExpression(ctx2); // Uses ctx2's cache
}

// No shared state, no race conditions
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