## Fixes

- `in` (and `includes` with a point) returns `null` when a boundary comparison is `null`, as it is for a Date, DateTime or Time point less precise than the boundary that matches it at the point's precision, or for quantities whose units are invalid or incommensurable. It returned `true` for such a point at a closed boundary and `false` at an open one. For example, `@2026-09-29T in Interval(@2026-03-29T00:00:00.000Z, @2026-09-29T00:00:00.000Z]` is `null`. A point that falls outside the other boundary still yields `false`, and a closed boundary without a value is still satisfied. (#1684)

This changes CQL evaluation results for the affected expressions.
