## Features

- `CqlContext.UseNewCache(int initialCapacity, int concurrencyLevel)` creates the definition/expression
  memoization cache with a configurable number of internal write locks. Cache reads have always been
  lock-free; a concurrency level above the sequential default keeps cache misses on different keys from
  serializing on one write lock when several threads evaluate over the same context. The existing
  `UseNewCache(int)` overload is unchanged and still creates a cache for sequential evaluation. (#1453, closes #1452)
- `FhirCqlContextOptions.EvaluationCache` opts a context created by `FhirCqlContext.ForBundle` /
  `FhirCqlContext.WithDataSource` into memoization, described by the new `EvaluationCacheProfile`
  (`EvaluationCacheProfile.Sequential`, `EvaluationCacheProfile.Concurrent`, or a custom initial capacity and
  concurrency level). The option is `null` by default, so contexts are still created without a cache unless
  caching is requested. (#1453, closes #1452)
- `CqlContext` documents the contract for sharing one context between concurrently evaluating threads:
  `Definitions` and `Parameters` must be fully populated before the fan-out and must not be mutated during
  it, the memoization cache may evaluate a definition more than once (bounded, and harmless because CQL
  expressions are pure), and the data source and value set implementations must tolerate concurrent
  reads. (#1453, closes #1452)
