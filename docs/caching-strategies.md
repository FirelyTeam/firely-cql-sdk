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
| Convert FHIR ↔ CQL values | [FHIR type-converter cache](#4-fhir-type-conversion-caching) | Process | on, unbounded |
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

Entries are keyed on the **content** of the assembly binaries, so rebuilding an equivalent `InvocationToolkit` from freshly read bytes still hits the pool.

**Two rules.** The pool owns what it returns:

- **Do not dispose a pooled invoker.** It is shared with every other caller for the same library set; `Dispose()` on a pooled instance is deliberately a no-op so one caller cannot unload the assemblies out from under the others. Likewise `SetBatchProcessExceptionContinuation` is ignored on a pooled instance — ask the pool for the policy you want instead.
- **Do not retain a `LibraryInvoker` or `DefinitionInvoker`** beyond the point where you are done with its library set. Each reaches its library set through a back-reference, so holding one keeps the whole load context alive even after the pool has evicted it.

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
var options = new FhirCqlContextOptions { EvaluationCache = EvaluationCacheProfile.Concurrent };
var context = FhirCqlContext.ForBundle(bundle, options: options);
```

`EvaluationCacheProfile.Sequential` is the default shape; `EvaluationCacheProfile.Concurrent` sizes the cache for one writer per processor. `ConcurrencyLevel` only affects how many internal locks cache *writes* spread over — reads are lock-free at any level — so raise it when several threads evaluate over one context, and leave it alone otherwise.

**Scope and lifetime.** The cache belongs to the `CqlContext`, so it lives exactly as long as that context, and two contexts never share cached results. `DontUseCaching()` disables it; calling `UseNewCache()` again replaces it, which is how you invalidate.

**A cached context is a snapshot.** Results are computed against the data the context was created with, so only enable this for a context whose data does not change while it is being evaluated.

Runnable example: **340 Caching Example**.

## 4. FHIR type-conversion caching

Converting between FHIR POCOs and CQL values is cached process-wide. This is on by default and unbounded. To bound it, set a size:

- at context creation, via `FhirCqlContextOptions.OverrideFhirTypeConverterCacheSize`;
- at compile time, via `ElmToolkitConfig.LRUCacheSize` (`0`, the default, means unbounded).

You normally do not need to touch either. Bound it if you are memory-constrained and converting a very wide variety of values.

## 5. Sharing one context across threads

Pooling and evaluation caching combine naturally, but sharing a **context** between threads has its own contract, documented in full on `CqlContext`:

- `Definitions` and `Parameters` must be fully populated before the work fans out, and not mutated while it runs — both are ordinary, non-concurrent collections.
- The data source and value-set implementations must tolerate concurrent reads, and the data behind them must not change during the evaluation.
- Two threads that miss on the same definition may both evaluate it. The value that loses the race is discarded, which is harmless because CQL expression bodies are pure — but it means the number of evaluations is bounded rather than exactly one per definition.

The simpler alternative, and the one to prefer unless you have measured a reason not to, is **one `CqlContext` per evaluation over a shared pooled invoker**. A pooled `LibrarySetInvoker` is safe to share between concurrently evaluating threads; the per-evaluation state all lives in the context.

**One interaction to be aware of.** Some list operators evaluate lazily, so a cached result can hold a reference into the generated assemblies. A long-lived cached context therefore keeps its library set's load context alive. If you pool invokers *and* keep contexts alive well beyond their evaluation, either materialise those results or call `DontUseCaching()` before the context outlives its evaluation.

## 6. Further reading

- [Getting started](getting-started.md) — setup and the example index
- [`Hl7.Cql.Invocation` README](../Cql/Cql.Invocation/README.md) — pooling API detail
- [`Hl7.Cql.Runtime` README](../Cql/Cql.Runtime/README.md) — context and thread-safety detail
- [CQL engine architecture](cql-engine-architecture.md) — where each stage sits in the pipeline
