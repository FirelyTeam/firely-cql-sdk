## Performance

- The process-wide date-time parse cache behind the `FhirDateTime` → `CqlDateTime` conversion no longer takes a
  global lock on every read. It is now backed by a two-generation cache whose reads are plain
  `ConcurrentDictionary` lookups; only the rare generation rotation locks. The conversion runs per value during
  an evaluation and the old cache serialized every date access across all concurrently evaluating threads.
- UCUM canonicalization results are memoized (bounded, on the default metric service). Quantity comparison — and
  the hashing behind the set-based operators — canonicalizes per value, and each canonicalization re-parsed the
  unit expression into its metric axes. Over a 900-case slice of the CMS corpus in a single process this was the
  largest remaining source of steady-state allocation; the memo removes ~8% of total allocation, deterministic
  across runs. Injected `IMetricService` implementations are unaffected.

Combined with the operator sweep, CPU for that 900-case slice drops from 1.31–1.40 s (develop, bracketing runs)
to 1.19 s, with allocation down from 715 MB to 691 MB.
