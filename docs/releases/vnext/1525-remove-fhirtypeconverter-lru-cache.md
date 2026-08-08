## Improvements

- `FhirTypeConverter` no longer memoizes `FhirDateTime` → `CqlDateTime` conversions in a process-wide LRU
  cache. The cache and its tuning knobs are gone; every conversion parses the FHIR value and builds a fresh
  `CqlDateTime`. Conversion **results are unchanged** — including partial precisions restored from the
  time-precision extension and every shape of timezone offset — so this is a performance and
  state-management change, not a behavioral one. Reference identity of the returned `CqlDateTime` was the
  cache's only observable effect and was never part of the contract; nothing in the runtime depends on it
  (the reference-equality checks in the comparer bridges are fast paths in front of value comparison, and
  `CqlDateTime.Equals`/`GetHashCode` are value-based). (#1487, closes #1483)

  The trade was measured in [#1483](https://github.com/FirelyTeam/firely-cql-sdk/issues/1483) over a
  900-case corpus: the cache bought roughly **39.5 MB of avoided allocation** per corpus run and no
  measurable CPU or wall-clock benefit, while the cache-consult path (`FhirDateTimeToCqlDateTimeViaCaching`
  — hashing and looking up the ISO 8601 string on every conversion) cost about **8.6 % of active CPU**.
  Removing it also removes process-wide mutable state keyed by patient data and deletes a tuning knob
  that no caller could usefully set. A `ConditionalWeakTable`-based replacement was considered and
  explicitly rejected as out of scope in #1483.

  The corpus A/B for this exact change (2,851 cases, 62 measures, lazy ISO 8601 formatting of
  [#1482](https://github.com/FirelyTeam/firely-cql-sdk/issues/1482) in both arms, cache presence the only
  delta, 48 order-balanced runs) measured, cache-removed vs cache-present:

  - **Results byte-identical**: the per-case oracle fingerprints of both arms match over the whole corpus.
  - **Allocation +83.1 MB per corpus run (+11.3 %, +29 KB/case)** — unanimous across all 24 rounds, and
    **entirely gen0**: +5 gen0 collections, zero change in gen1, zero gen2 in either arm, +5 ms of total
    GC pause on a ~1.9 s run.
  - **Sequentially (dop 1), CPU and wall lean 1.5–6 % slower without the cache** — direction consistent
    across order-balanced and mirrored sequences, magnitude noise-sensitive (19 of 24 rounds positive).
    This does **not** reproduce #1483's "no measurable CPU benefit" for the cache on this corpus: with
    the cache gone, every conversion constructs instead of hitting a string lookup, and sequentially the
    construction is measurably the more expensive of the two even with lazy formatting in place.
  - **Under concurrent execution the penalty evaporates.** The cache serializes every conversion on one
    process-wide `lock` — taken on reads as well as inserts — and at dop 4/8 that lock is measurably
    contended in the cached arm (a median of 2.5–12 monitor-contention events per repetition, versus
    ~zero without the cache). The wall gap shrinks from +5.7 % at dop 1 to +1.15 % at dop 4 and +0.39 %
    at dop 8 — inside the noise floor, so at dop ≥ 4 the two arms are indistinguishable in wall and CPU,
    with the uncached arm scaling marginally better from its own sequential baseline (×2.71 vs ×2.59 at
    dop 4). The allocation regression is dop-independent (+10.8…+11.6 % at every dop), confirming the
    parallel runs do the same work.

  The removal therefore stands on the state-management and simplicity grounds, on the allocation being
  strictly short-lived gen0 garbage, and on eliminating a lock that concurrent evaluation measurably
  contends — not on a CPU win, which neither the sequential nor the parallel measurement showed.

- `TypeConverter` instances are still shared: one is built per (model, default timezone offset) pair, since
  building one reflects over every FHIR enum. The memoization key previously also included the cache size;
  with the cache gone, two callers that differ only in a model and offset match now get the same converter.

## Potentially Breaking

- Removed the FHIR date/time conversion cache size from the public API. The following members are gone:

  | Removed | Replacement |
  | --- | --- |
  | `Hl7.Cql.Fhir.FhirTypeConverter.Create(ModelInspector, int? cacheSize = null)` | `Hl7.Cql.Fhir.FhirTypeConverter.Create(ModelInspector)` |
  | `Hl7.Cql.Fhir.FhirTypeConverter.Create(ModelInspector, int? cacheSize, TimeSpan? defaultTimezoneOffset)` | `Hl7.Cql.Fhir.FhirTypeConverter.Create(ModelInspector, TimeSpan? defaultTimezoneOffset)` |
  | `Hl7.Cql.Fhir.FhirCqlContextOptions.OverrideFhirTypeConverterCacheSize` | none — remove the initializer |
  | `Hl7.Cql.CodeGeneration.NET.Toolkit.ElmToolkitConfig.LRUCacheSize` (record parameter and property) | none — remove the argument or `with` initializer |

  **Migration:** drop the `cacheSize` argument and the two settings. `FhirTypeConverter.Create(model, 0)`
  and `FhirTypeConverter.Create(model, 10_000)` both become `FhirTypeConverter.Create(model)`; a call that
  passed a default timezone offset drops only its middle argument. `ElmToolkitConfig` is a positional
  record, so a caller constructing it positionally past `AllowInvalidCSharp` must drop the cache-size
  argument; named/`with` initializers only need the `LRUCacheSize` entry removed. Since the value was only
  ever a cache bound, no call needs a behavioral substitute — the conversions it guarded are unchanged.

  The `ArgumentOutOfRangeException` a negative `cacheSize` used to raise disappears with the parameter.
  Validation of `defaultTimezoneOffset` (a whole number of minutes within ±14:00) is unchanged. (#1487)
