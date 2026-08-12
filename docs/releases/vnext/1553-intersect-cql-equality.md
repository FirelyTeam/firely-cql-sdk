## Fixes

- List `Intersect` now uses CQL equality semantics (same comparer path as `Except`/`Union`/`Distinct`) instead of CLR object equality. This fixes missed matches for value-equal but reference-distinct values, including UCUM-convertible `CqlQuantity` and structurally equal `CqlConcept`/tuple values. The behavior change can add matches, but does not remove matches that were already found under CQL equality. (#1325)

## Internal

- Added `ListSetOperatorBenchmarks` to measure `Intersect`/`Except`/`Union`/`Distinct` across `int`, `string`, `CqlQuantity`, and `CqlConcept`, and captured an A/B baseline for the `Intersect` correctness fix (`.Intersect(right.Cast<object>())` vs `.Intersect(right.Cast<object>(), EqualityComparer)`):
  - `Intersect<CqlQuantity>`: `2.841 μs` -> `38,349.08 μs` at `Values=200`, and `28.938 μs` -> `391,142.98 μs` at `Values=2000`; allocations `5.02 KB` -> `131,106.95 KB` and `45.92 KB` -> `1,311,015.67 KB`.
  - `Intersect<int>`/`Intersect<string>`: smaller absolute deltas (for example `Intersect<int>` at `Values=2000`: `95.672 μs` -> `123.340 μs`, allocations effectively unchanged at `~260.9 KB`).
  - `Except`, `Union`, and `Distinct` are unchanged by this PR and remain on the same comparer path they already used.
  `Intersect` was previously faster because it skipped CQL equality; the measured cost is the cost of restoring correctness, not a new policy added only for this operator. (#1324, #1325)
