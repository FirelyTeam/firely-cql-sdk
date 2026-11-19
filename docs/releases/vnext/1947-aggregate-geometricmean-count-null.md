## Fixes

- **CQL to ELM translation** — `GeometricMean(List<Decimal>)` now translates, also for a list of Integer or Long values.
  It used to fail with "Could not resolve call to operator GeometricMean with signature (List<Decimal>)"; the runtime
  already implemented it. Regenerate ELM from CQL to pick it up. (#1947)
- **Runtime** — `Count` of a null list now gives `0`, as CQL §9.B *Count* requires ("If the list is null, the result
  is 0"). It used to give null. This changes CQL evaluation results: for example, `Count(X) = 0` over a null list used
  to be null and is now true. ELM and generated C# are unchanged. (#1947)
