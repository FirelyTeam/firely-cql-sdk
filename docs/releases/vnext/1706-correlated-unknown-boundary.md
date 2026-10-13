## Fixes

- `overlaps before`, `overlaps after`, `properly includes` and `properly included in` decide an unknown (open null) boundary over the values it can take instead of combining two range comparisons on it, so a result that no value of the boundary can satisfy is `false` instead of `null`: `Interval[1, 1] overlaps after Interval[0, null)`, `Interval[0, 0] properly includes Interval(null, null)` and `Interval(null, 2] properly includes Interval[null, 2]` are `false`. Results that some values satisfy and others do not stay `null`. (#1706)

This changes CQL evaluation results for the affected expressions.
