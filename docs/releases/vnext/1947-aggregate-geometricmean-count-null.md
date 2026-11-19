## Fixes

- **CQL to ELM translation** — `GeometricMean(List<Decimal>)` now translates. It used to fail with "Could not resolve
  call to operator GeometricMean"; the runtime already implemented it.
- **Runtime** — `Count` of a null list now gives `0`, as CQL §9.B *Count* requires ("If the list is null, the result
  is 0"). It used to give null. Generated C# is unchanged.
