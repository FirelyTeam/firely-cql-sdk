## Firely CQL SDK 2.12.0

### tl;dr

> **Upgrading?** Here is the short version:
>
> - **Breaking changes:** `LibrarySetInvoker.LibraryInvokers` now throws `ObjectDisposedException` after disposal (previously returned a populated dictionary); `Measure.group.stratifier` entries in Packager output no longer carry `code` or `description`.
> - **Required migrations:** Code that accesses `LibrarySetInvoker.LibraryInvokers` must be inside the invoker's `using` scope. Consumers asserting on generated `Measure` JSON shape must update their expected output to omit `code`/`description` from container stratifiers.
> - **Highlights:** New `LibrarySetInvokerPool` for reusing invoker instances across evaluations; opt-in concurrent evaluation cache profiles; FHIR `Range`-to-CQL-interval conversions; indexed coding cache in `BundleDataSource`.

---

### CQL SDK

#### New Public API

**`Hl7.Cql.Invocation` (`Cql.Invocation`):**

- `Hl7.Cql.Invocation.Toolkit.LibrarySetInvokerPool` — pool that reuses `LibrarySetInvoker` instances keyed on assembly-binary content.
  - `LibrarySetInvokerPool(LibrarySetInvokerPoolOptions? options = null, ILoggerFactory? loggerFactory = null)`
  - `GetOrCreate(InvocationToolkit toolkit, string librarySetName = "") -> LibrarySetInvoker`
  - `Statistics -> LibrarySetInvokerPoolStatistics`
  - `Dispose()`
  - `ToString()`
- `Hl7.Cql.Invocation.Toolkit.LibrarySetInvokerPoolOptions` (record) — `Capacity` (default 8), `MaxPendingUnloads` (default 0). Static `Default` property.
- `Hl7.Cql.Invocation.Toolkit.LibrarySetInvokerPoolStatistics` (struct) — `Hits`, `Misses`, `Entries`, `PendingUnloads`.

**`Hl7.Cql.Runtime` (`Cql.Runtime`):**

- `CqlContext.UseNewCache(int initialCapacity, int concurrencyLevel)` — creates the memoization cache with configurable concurrency.
- `const CqlContext.MaximumCacheConcurrencyLevel = 1024`
- `const CqlContext.SequentialCacheConcurrencyLevel = 1`
- `Hl7.Cql.Runtime.EvaluationCacheProfile` (record) — `Sequential`, `Concurrent` static profiles; `InitialCapacity`, `ConcurrencyLevel` properties.

**`Hl7.Cql.Fhir` (`Cql.Firely`):**

- `FhirCqlContextOptions.EvaluationCache { get; init; } -> EvaluationCacheProfile?` — opts a context into memoization.
- `static FhirTypeConverter.ConvertRangeToCqlInterval(this TypeConverter converter, Range? range, string? cqlPointTypeName) -> object?` — converts a FHIR `Range` to the CQL interval type indicated by `cqlPointTypeName`.

#### Improvements

- **Indexed coding cache in `BundleDataSource`:** retrieves with a code or value set filter over a `Bundle` no longer redo per-resource work on every call. `BundleDataSource` extracts codings once per retrieved type/code-property pair, compiles getters instead of using reflection, and matches explicit code lists via a set lookup. (#1450, #1451)
- **Opt-in evaluation cache profiles:** `FhirCqlContextOptions.EvaluationCache` and `CqlContext.UseNewCache(int, int)` let callers opt contexts into memoization; the existing single-argument `UseNewCache(int)` overload is unchanged. The `CqlContext` documentation now specifies the contract for sharing one context across concurrent threads: `Definitions` and `Parameters` must be fully populated before fan-out and must not be mutated during it; the cache may evaluate a definition more than once (bounded, harmless because CQL expressions are pure); data source and value set implementations must tolerate concurrent reads. (#1452, #1453)
- **FHIR `Range`-to-`Interval` conversions:** `FhirTypeConverter` can now read a FHIR `Range` as `Interval<Long>` (bounds read from `Quantity` values, inclusive, fractional parts truncated). `ConvertRangeToCqlInterval` picks the CQL type from a type-name hint (e.g. `Interval<Integer>`, `Interval<Long>`, `Interval<Decimal>` from the `cqf-cqlType` extension, or the wrapped `Interval<...>` format emitted by the SDK packager); an absent or unrecognized hint yields the widest reading, `Interval<Quantity>`. A single FHIR `Quantity` can also be read as a CQL `Long`. **Both `ConvertRangeToCqlInterval` and the pre-existing `ConvertPeriodToCqlInterval` now recognize the wrapped `Interval<...>` format**, closing the round-trip for intervals packaged by the SDK. (#1454, #1455)
- **`LibrarySetInvokerPool`:** reuses `LibrarySetInvoker` instances across evaluations of the same library set, loading and JIT-compiling assemblies only once. Pool entries are keyed on a sorted SHA-256 hash of the assembly/symbol bytes plus the library-set name and exception-continuation policy. Addresses a production failure mode where collectible load contexts accumulated faster than they were reclaimed, eventually exceeding the kernel's `vm.max_map_count`. (#1440, #1461)
- **`InvocationToolkit Services Dependency Diagram`** added to `docs/dependency-diagrams.md`, covering `InvocationToolkit`, `LibrarySetInvoker`, the invoker graph, and the new pool types. (#1440)
- `docs/releases/vnext-release-notes.md` is now a static pointer doc; fragment files under `docs/releases/vnext/` are the sole pending-content source going forward. (#1445)

#### Fixes

- `LibrarySetInvoker.Dispose()` is now idempotent; previously it called `AssemblyLoadContext.Unload()` unconditionally on every call, which was an access violation before .NET 8.0.0. (#1440)
- `LibrarySetInvoker.Dispose()` and `SetBatchProcessExceptionContinuation` are now inert (and log a warning) when the instance is owned by a `LibrarySetInvokerPool`, preventing inadvertent reconfiguration of a shared pool entry. (#1440)
- `InvocationToolkit.CreateLibrarySetInvoker` no longer leaks the `AssemblyLoadContext` created when loading a library set fails — the context is unloaded before the exception is rethrown. (#1440)
- Corrected stale `Fhir.Metrics` version in `README.md`'s "External Dependencies" table (was `1.3.0`, now `1.4.0`) and in `docs/type-system-unification-assessment.md`. Added guidance to AI instructions to always update those references when bumping package versions. (#1446, #1449)

#### Potentially Breaking

- **`LibrarySetInvoker.LibraryInvokers` after disposal now throws `ObjectDisposedException`** instead of returning a populated dictionary. `Dispose()` also releases the invoker's reference to its `AssemblyLoadContext`, allowing the context and its JIT-compiled mappings to be reclaimed. Code that only accesses an invoker within its `using` scope is unaffected. (#1440)

---

### CQL Packager

#### Breaking

- **`Measure.group.stratifier` no longer carries `code` or `description`** on the container stratifier. Both fields previously duplicated the container's element id and made the resource invalid (FHIR invariant: `(code | description | criteria).exists() xor component.exists()`). The human-readable labels remain on `stratifier.component.code`/`.description`. A container stratifier can no longer be emitted without at least one component. Consumers diffing or asserting on generated `Measure` resources from re-packaged libraries will see this change. (#1499)

#### Fixes

- Generated `Measure` resources now satisfy FHIR invariant `mea-1`: previously every Measure using `@stratifier` components failed validation because the container stratifier also carried `code` and `description`. (#1499)

---

### Demo Projects and Build Tooling

#### Fixes

- CQL-to-ELM generation (`CqlToolingEnabled`) now works on Linux/macOS: the Java classpath wildcard in `Demo/Cql/Build/CqlTooling.Targets.xml` is quoted so Unix shells no longer expand it before `java` sees it. (#1499)

---

### Upgrade Checklist

1. If you access `LibrarySetInvoker.LibraryInvokers`, ensure that access is inside the invoker's `using` scope (or before any `Dispose()` call).
2. If you assert on the shape of Packager-generated `Measure` JSON (e.g. in snapshot tests), update your expected output to omit `code` and `description` from container `Measure.group.stratifier` entries; those fields now appear only on `stratifier.component`.
3. To opt into the new `LibrarySetInvokerPool`, replace per-evaluation `CreateLibrarySetInvoker` calls with a long-lived pool:

   ```csharp
   // Before (one load context per evaluation)
   using var invoker = toolkit.CreateLibrarySetInvoker(librarySetName);

   // After (assemblies loaded and JIT-compiled once; invoker is shared)
   var pool = new LibrarySetInvokerPool();          // keep this long-lived
   var invoker = pool.GetOrCreate(toolkit, librarySetName);
   ```

4. To enable memoization for `FhirCqlContext.ForBundle` / `FhirCqlContext.WithDataSource`, set `EvaluationCache` on the options:

   ```csharp
   var ctx = FhirCqlContext.ForBundle(bundle, new FhirCqlContextOptions
   {
       EvaluationCache = EvaluationCacheProfile.Sequential   // or .Concurrent for multi-threaded use
   });
   ```

   When using `EvaluationCacheProfile.Concurrent` (or `UseNewCache(int, int)` directly): populate `Definitions` and `Parameters` fully before fanning out across threads, and do not mutate them during evaluation. The cache may evaluate a definition more than once (bounded, harmless because CQL expressions are pure). Your data source and value set implementations must tolerate concurrent reads.

---

### Pull Requests

| PR | Title |
| --- | --- |
| [#1499](https://github.com/FirelyTeam/firely-cql-sdk/pull/1499) | Fix FHIR stratifier invariant violation in generated measures |
| [#1497](https://github.com/FirelyTeam/firely-cql-sdk/pull/1497) | Add Integration Runner measurement projects to solution files |
| [#1492](https://github.com/FirelyTeam/firely-cql-sdk/pull/1492) | Bump Integration Runner submodule pointer |
| [#1465](https://github.com/FirelyTeam/firely-cql-sdk/pull/1465) | Add pool invoker example (example 350) |
| [#1462](https://github.com/FirelyTeam/firely-cql-sdk/pull/1462) | Require commit SHA and work description when resolving review comments |
| [#1461](https://github.com/FirelyTeam/firely-cql-sdk/pull/1461) | Pool LibrarySetInvoker instances keyed on assembly-binary content |
| [#1455](https://github.com/FirelyTeam/firely-cql-sdk/pull/1455) | Add FHIR Range-to-Interval conversions |
| [#1453](https://github.com/FirelyTeam/firely-cql-sdk/pull/1453) | Add opt-in evaluation cache profiles and concurrent cache mode |
| [#1451](https://github.com/FirelyTeam/firely-cql-sdk/pull/1451) | Index codings in BundleDataSource to avoid per-retrieve work |
| [#1449](https://github.com/FirelyTeam/firely-cql-sdk/pull/1449) | Fix stale Fhir.Metrics version in docs |
| [#1448](https://github.com/FirelyTeam/firely-cql-sdk/pull/1448) | Phase 2 — retire vnext-release-notes.md as directly-editable file |
