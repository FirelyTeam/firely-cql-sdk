## Improvements

- A retrieve served by `Hl7.Cql.Fhir.BundleDataSource` now decides its result once instead of re-deciding it on
  every enumeration. (This covers bundle-backed retrieves only; other `IDataSource` implementations, including
  the `CompositeDataSource` that fans a retrieve out over several sources, are unchanged.)
  `BundleDataSource.Retrieve` used to hand back a lazy chain — the per-type cast, the code or
  value set filter, and the profile filter — that was re-executed in full each time the result was walked,
  and a retrieve result is typically walked several times during an evaluation (a cached definition read
  from more than one expression, an `exists` check, the inner source of a cross join). The bundle does not
  change while it is being evaluated, so each of those walks reproduced the same answer. The cast, the code
  filter and the profile filter now run eagerly, once, at retrieve time, and the retrieve hands back the
  materialized result; the uncoded per-type cast is additionally cached per bundle, so repeated retrieves of
  the same type over the same bundle share one read-only list. The cache is keyed by the requested resource type, so it
  holds at most one entry per distinct type retrieved (a type absent from the bundle caches one shared empty
  list), and it lives no longer than the bundle itself (#1477).

  This is a behavior-preserving change: every retrieve shape returns the same elements in the same order as
  before. The trade is memory — a retrieve's result list stays alive for the duration of the evaluation
  rather than being recomputed on demand, bounded by the size of the bundle — in exchange for not repeating
  membership decisions that cannot change. `IDataSource.Retrieve` still returns `IEnumerable<T>`; there is no
  public API change.
