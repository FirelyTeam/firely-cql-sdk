## Fixes

- An interval selector whose boundaries are both null is no longer `null` itself. A closed null boundary means the minimum or maximum of the point type, so `Interval[null, null]` is the maximal interval covering the whole domain: `5 in Interval[null, null]` is `true`, `Interval[null, null] overlaps Interval[1, 10]` (and `overlaps before` / `overlaps after`) is `true`, `Interval[null, null] union Interval[1, 10]` is `Interval[null, null]`, `Interval[null, null] starts Interval[1, 10]` and `Interval[1, 10] ends Interval[null, null]` are `false`, and `point from Interval[null, null]` signals an error because the interval is not a unit interval. An open null boundary is unknown, so `Interval(null, null)` is a non-null interval whose boundaries are unknown and operators over it yield `null`. `after`, `before`, `same or before`, `same or after`, `starts`, `ends`, `union`, `point from`, `start of`, `end of` and interval equality now follow these Start/End boundary semantics, as `in`, `overlaps` and the properly-includes operators already did: `start of` and `end of` the maximal interval are the minimum and maximum of the point type, `same or before` and `same or after` compare the first interval's end with the second one's start (so an interval is not same or before itself), and interval equality is `false` when one boundary is known to differ even if the other is unknown, and `null` when the intervals share an unknown boundary and differ in nothing else. Operators over two intervals of `Any` (for example `Interval[null, null] starts Interval[null, null]`) evaluate instead of failing. (#1629) `point from` over a non-unit interval now throws `CqlException<CqlPointFromNonUnitIntervalError>` instead of `InvalidOperationException`. (#1625)

This changes CQL evaluation results.

## Other

- `LibrarySetCSharpCodeGenerator.GeneratorToolVersion` moves `5.2.2.0` → `5.2.3.0`. The generated API is
  unchanged, so the existing `LibraryInstanceInvoker_5_0` still applies; only the C# emitted for an
  all-null interval literal differs. (#1629)
