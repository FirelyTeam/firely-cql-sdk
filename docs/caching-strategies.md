# Caching strategies

The SDK has several independent caches, each covering a different cost and living for a different length of time. They are all **opt-in or automatic** — none of them changes results, only how much work is repeated. This page explains which one to reach for, in the order you are likely to need them.

If you only read one thing: a long-running host evaluating the same CQL repeatedly wants **library-set pooling** ([2](#2-library-set-pooling-across-evaluations)) and usually **evaluation caching** ([3](#3-evaluation-caching-within-one-context)) as well. They solve different problems and compose.

## 1. What gets repeated, and what each cache saves

Evaluating CQL goes through roughly four stages. Each has its own cache:

| Cost | Cache | Scope | Default |
| --- | --- | --- | --- |
| Translate CQL → ELM → C# → assembly | Package once, ship the assemblies | Build time | n/a — see [cql-packager.md](cql-packager.md) |
| Load assemblies + JIT-compile them | [`LibrarySetInvokerPool`](#2-library-set-pooling-across-evaluations) | Process | **off** |
| Evaluate a definition | [`CqlContext` evaluation cache](#3-evaluation-caching-within-one-context) | One `CqlContext` | **off** |
| Convert `FhirDateTime` → `CqlDateTime` | [FHIR type-converter LRU](#4-fhir-datetime-conversion-caching) | Process | on, 10,000 entries |
| Extract codings from a bundle for retrieves | Automatic, inside `BundleDataSource` | One bundle | on |

The last one needs no configuration: retrieves over a `Bundle` extract each resource's codings once per bundle and reuse them. It is listed only so you know it is already handled.

## 2. Library-set pooling (across evaluations)

**Problem it solves.** `InvocationToolkit.CreateLibrarySetInvoker` creates a fresh collectible `AssemblyLoadContext` and reloads every assembly on each call. Collectible contexts never use ReadyToRun, so every generated method is JIT-compiled again per context, and unloading is cooperative — it completes only once nothing references the context. A host that evaluates the same library set once per subject therefore accumulates contexts faster than they are reclaimed. On Linux each JIT-compiled region costs two memory mappings, so the process can exhaust the kernel's `vm.max_map_count` and abort.

**Use it when** the same library set is evaluated more than once in a process — measure evaluation over a population being the obvious case.

```csharp
using Hl7.Cql.Invocation.Toolkit;

// Once, for the lifetime of the host.
using var pool = new LibrarySetInvokerPool(new LibrarySetInvokerPoolOptions(Capacity: 4));

// Per request: loads on the first call, reused after that.
var invoker = pool.GetOrCreate(invocationToolkit, "HEDIS");
var result = invoker.InvokeLibraryDefinition(context, libraryIdentifier, "Numerator");
```

Entries are keyed on the **content** of the assembly binaries together with the **library set name** you pass to `GetOrCreate`, so rebuilding an equivalent `InvocationToolkit` from freshly read bytes still hits the pool — but the name has to be stable for a given library set. A name that varies per request (`$"HEDIS-{subjectId}"`, say — which reads naturally, since the parameter also names the load context for diagnostics) misses every single time, and at a small `Capacity` it then evicts on every call too: loading, unloading and re-JIT-compiling per request, which is worse than not pooling at all. The exception-continuation policy is part of the key as well.

**Three rules.** The pool owns what it returns:

- **Do not dispose a pooled invoker.** It is shared with every other caller for the same library set; `Dispose()` on a pooled instance is deliberately a no-op so one caller cannot unload the assemblies out from under the others. Likewise `SetBatchProcessExceptionContinuation` is ignored on a pooled instance — ask the pool for the policy you want instead.
- **Do not retain a `LibraryInvoker` or `DefinitionInvoker`** beyond the point where you are done with its library set. Each reaches its library set through a back-reference, so holding one keeps the whole load context alive even after the pool has evicted it.
- **Size `Capacity` to at least the number of library sets in concurrent use.** Eviction unloads a library set without waiting for its users, so an invoker that is evicted while you still hold it throws `ObjectDisposedException` on next use rather than quietly returning results from unloaded assemblies. That is deliberate — an empty library set would be a silently wrong answer — but it makes capacity a correctness setting, not just a tuning one. It is the one failure mode you can only avoid by configuration, and at or above the number of distinct hot library sets it is unreachable.

**What to monitor.** `LibrarySetInvokerPoolStatistics.PendingUnloads` counts evicted load contexts that have not been reclaimed. A value that keeps climbing means something is violating the second rule. `Hits`/`Misses` tell you whether `Capacity` is large enough: size it to the number of library sets evaluated concurrently, because a pool that thrashes between more library sets than it can hold misses on every request.

`Capacity` is a target rather than a hard ceiling — a library set still being loaded is never evicted, and reclamation lags eviction because unloading is gated on the garbage collector.

Runnable example: **350 Pooling Library Set Invokers** in the [Examples project](../Examples/CqlSdkExamples/).

## 3. Evaluation caching (within one context)

**Problem it solves.** A CQL definition referenced from several places is otherwise re-evaluated at each reference. Memoizing per context collapses that to once.

**Use it when** definitions are referenced more than once during a single evaluation — which is most non-trivial CQL, and certainly measure logic where a denominator and numerator share population definitions.

Caching is **off by default**. Enable it either on the context:

```csharp
context.UseNewCache();                                  // sequential
context.UseNewCache(CqlContext.CacheInitialCapacity,    // sized for concurrent writes
                    Environment.ProcessorCount);
```

…or, preferably, when the context is created:

```csharp
var options = new FhirCqlContextOptions { EvaluationCache = EvaluationCacheProfile.Sequential };
var context = FhirCqlContext.ForBundle(bundle, options: options);
```

Use `EvaluationCacheProfile.Concurrent` instead only when several threads evaluate over the **same** context — see [5](#5-sharing-one-context-across-threads). Under the pattern this page recommends (one context per evaluation over a shared pooled invoker) exactly one thread ever writes to a given context's cache, so `Sequential` is the right profile.

`EvaluationCacheProfile.Sequential` is the default shape; `EvaluationCacheProfile.Concurrent` sizes the cache for one writer per processor. `ConcurrencyLevel` only affects how many internal locks cache *writes* spread over — reads are lock-free at any level — so raise it when several threads evaluate over one context, and leave it alone otherwise. It is not free: the level is passed straight to `new ConcurrentDictionary<long, object?>(concurrencyLevel, …)`, which allocates a lock array of that size, so `Concurrent` on a 64-core host costs 64 locks per context.

**Scope and lifetime.** The cache belongs to the `CqlContext`, so it lives exactly as long as that context, and two contexts never share cached results. `DontUseCaching()` disables it; calling `UseNewCache()` again replaces it, which is how you invalidate.

**A cached context is a snapshot.** Results are computed against the data the context was created with, so only enable this for a context whose data does not change while it is being evaluated.

Runnable example: **340 Caching Example**.

## 4. FHIR date/time conversion caching

Converting `FhirDateTime` values to `CqlDateTime` is memoized in a process-wide LRU cache. It is on by default, **bounded at 10,000 entries**, and shared by every context that uses the default model and cache size. No other FHIR ↔ CQL conversion is cached — the cache holds only `FhirDateTime` → `CqlDateTime` and its `.DateOnly` projection.

To change the bound, set `FhirCqlContextOptions.OverrideFhirTypeConverterCacheSize` at context creation. Note that `0` **disables** the cache rather than unbounding it, and any value other than the default gets its own converter and cache instance rather than the shared default pair.

You normally do not need to touch this. Lower it only if you are memory-constrained; raise it if you evaluate over data with far more than 10,000 distinct date/time values and see the conversion cost.

`ElmToolkitConfig.LRUCacheSize` is **not** this cache. It configures a `TypeConverter` registered in the compiler's own service container for ELM → C# code generation, and has no effect on the converter a runtime `FhirCqlContext` builds.

## 5. Sharing one context across threads

Pooling and evaluation caching combine naturally, but sharing a **context** between threads has its own contract, documented in full on `CqlContext`:

- `Definitions` and `Parameters` must be fully populated before the work fans out, and not mutated while it runs — both are ordinary, non-concurrent collections.
- The data source and value-set implementations must tolerate concurrent reads, and the data behind them must not change during the evaluation.
- Two threads that miss on the same definition may both evaluate it. The value that loses the race is discarded, which is harmless because CQL expression bodies are pure — but it means the number of evaluations is bounded rather than exactly one per definition.

The simpler alternative, and the one to prefer unless you have measured a reason not to, is **one `CqlContext` per evaluation over a shared pooled invoker**. A pooled `LibrarySetInvoker` is safe to share between concurrently evaluating threads; the per-evaluation state all lives in the context.

**One interaction to be aware of.** Some list operators evaluate lazily, so a cached result can hold a reference into the generated assemblies. A long-lived cached context therefore keeps its library set's load context alive. If you pool invokers *and* keep contexts alive well beyond their evaluation, either materialize those results or call `DontUseCaching()` before the context outlives its evaluation.

## 6. Further reading

- [Getting started](getting-started.md) — setup and the example index
- [`Hl7.Cql.Invocation` README](../Cql/Cql.Invocation/README.md) — pooling API detail
- [`Hl7.Cql.Runtime` README](../Cql/Cql.Runtime/README.md) — context and thread-safety detail
- [CQL engine architecture](cql-engine-architecture.md) — where each stage sits in the pipeline
