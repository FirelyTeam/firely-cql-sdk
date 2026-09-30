## Fixes

- Interval `intersect` now applies Start/End boundary semantics instead of returning `null` whenever a boundary value is null: a null closed boundary means the minimum or maximum of the point type, and a null open boundary is unknown. `Interval[1, 10] intersect Interval[5, null]` is `Interval[5, 10]`, and `Interval[1, 10] intersect Interval[5, null)` is `Interval[5, null)`, so `start of` that intersection is `5`. A result boundary that depends on an unknown boundary is itself unknown (a null open boundary), and when an unknown boundary leaves it undecided whether the intervals overlap at all, as in `Interval[1, 3] intersect Interval(null, 5]`, the result is `null`. (#1693)

This changes CQL evaluation results for the affected expressions.
