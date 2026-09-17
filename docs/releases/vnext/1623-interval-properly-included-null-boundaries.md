## Fixes

- Interval `properly included in` / `properly includes` now apply Start/End boundary semantics: a null closed boundary means the minimum or maximum of the point type and a null open boundary is unknown, so `Interval[1, 10] properly included in Interval[null, null]` is `true` at the operator level instead of `null`. A boundary comparison that is indeterminate, such as between Date values of different precision without a precision argument, now yields `null` instead of `true`, consistent with `included in`. (#1620)

This changes CQL evaluation results, so the release that ships it needs a MESO bump.
