## Fixes

- `in` (and `includes` with a point) returns `null` when a boundary comparison is uncertain, that is, when a Date or DateTime point is less precise than the boundary and matches it at the point's precision. It returned `true` for such a point at a closed boundary and `false` at an open one. For example, `@2026-09-29 in Interval(@2026-03-29T00:00:00.000Z, @2026-09-29T00:00:00.000Z]` is `null`. A point that falls outside the other boundary still yields `false`. (#1684)

This changes CQL evaluation results for the affected expressions.
