## Fixes

- Interval `properly included in` / `properly includes` now apply Start/End boundary semantics: a null closed boundary means the minimum or maximum of the point type and a null open boundary is unknown, so `Interval[1, 10] properly included in Interval[null, null]` is `true` at the operator level instead of `null`. A boundary comparison that is indeterminate, such as between Date values of different precision without a precision argument, now yields `null` instead of `true`, consistent with `included in`. `Successor` of the maximum value and `Predecessor` of the minimum value of Integer, Long, Decimal, Quantity and Time now return `null` as the specification requires instead of wrapping around, and closing an interval whose open boundary sits at such an extreme leaves that boundary unknown instead of turning it into the opposite extreme. (#1620)

This changes CQL evaluation results.

## Breaking Changes

- `CqlTime.Successor()` and `CqlTime.Predecessor()` now return `CqlTime?` instead of `CqlTime`, since the successor of the maximum time and the predecessor of the minimum time are `null`. Callers that dereferenced the result unconditionally get a nullable warning. (#1620)
