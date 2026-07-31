# Hl7.Cql.Runtime

A support package for HL7.Cql that contains the required runtime components for CQL execution.

## Overview

This package provides the core runtime engine that executes CQL expressions and operations. It includes the operators, comparers, and runtime context needed to evaluate CQL logic during execution.

## Key Features

- **CQL Operators**: Complete implementation of CQL operators for arithmetic, logical, comparison, and other operations
- **Type Comparers**: Specialized comparison logic for CQL data types
- **Runtime Context**: Execution context management for CQL evaluation
- **Expression Caching**: Optional caching of expression results for improved performance
- **Expression Evaluation**: Core engine for evaluating CQL expressions
- **FHIR Metrics Support**: Integration with FHIR quantity and unit conversions

## Expression Caching

**Caching is disabled by default.** The runtime supports optional caching of CQL expression results to improve performance when evaluating the same expressions multiple times.

### Enabling Caching

```csharp
var context = new CqlContext();
context.UseNewCache();  // Enable caching
```

### Disabling Caching

```csharp
context.DontUseCaching();  // Disable caching
```

### How It Works

- Only parameter-less expressions (functions with no parameters except `CqlContext`) are cached
- Each `CqlContext` instance has its own independent cache
- Cache entries are keyed by library version and definition name
- Caching is thread-safe and supports concurrent access
- Null values are cached correctly

### When to Use Caching

Enable caching when:
- Evaluating the same expressions multiple times within a single execution context
- Working with expensive computations that don't depend on parameters
- Performance is critical and expression results are deterministic

**Note**: Always call `UseNewCache()` to create a fresh cache when starting a new evaluation cycle to ensure stale data isn't used.

### Parallel Execution

Each `CqlContext` instance maintains its own cache, making it safe to run multiple contexts in parallel without contention:

```csharp
Parallel.For(0, 10, i =>
{
    var context = new CqlContext();
    context.UseNewCache();
    // Evaluate expressions...
});
```

### Sharing One Context Across Threads

One `CqlContext` may also be shared by threads that evaluate definitions concurrently. Size its cache for the expected degree of parallelism, so that concurrent cache misses are not serialized on a single write lock (reads are lock-free at any level):

```csharp
context.UseNewCache(CqlContext.CacheInitialCapacity, Environment.ProcessorCount);
```

Sharing a context requires the following, which is documented in full on `CqlContext`:

- `Definitions` and `Parameters` are fully populated before the evaluation fans out, and are not mutated while it runs — both are ordinary, non-concurrent collections
- The data source and value set implementations tolerate concurrent reads, and the data behind them does not change during the evaluation
- Callers accept that two threads missing on the same definition may both evaluate it; the value losing the race is discarded, which is harmless because CQL expression bodies are pure

## Usage

This package is used by the CQL compiler and other runtime components to execute CQL logic. It provides the foundational runtime services needed for CQL evaluation.

## Dependencies

- **Hl7.Cql.Abstractions**: Core abstractions and interfaces
- **Hl7.Cql.Grammar**: CQL grammar definitions
- **Fhir.Metrics**: FHIR unit and quantity handling
- **Microsoft.Extensions.Logging**: Logging framework support

## Further Reading

This package is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). For getting started, release notes, and contribution guidelines, see the [main README](../../README.md).