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

- The ISO 8601 date/time primitives (`DateTimeIso8601`, `DateIso8601`, `TimeIso8601`) no longer format their text
  representation eagerly in the constructor. Most instances — the intermediates of date arithmetic, comparisons
  and FHIR-to-CQL conversions — are never rendered as text, yet each construction paid a `StringBuilder` and one
  small string per component. The text form is now computed on first use and cached; parsing still stores the
  original literal, so parse/format roundtrips stay byte-identical (pinned by a 154-case golden test captured
  from the eager implementation). Constructing a full `CqlDateTime` drops from 1232 ns / 2864 B to 545 ns / 792 B,
  and a `CqlDateTime.Add` — paid per date operation in measure logic — from 1095 ns / 2912 B to 313 ns / 840 B.
  Over the 900-case CMS harness this removes ~66 MB (−9.6%) of steady-state allocation.
