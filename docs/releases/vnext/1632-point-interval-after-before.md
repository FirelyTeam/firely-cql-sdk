## Fixes

- `after` and `before` with one point operand and one interval operand are translated to the point-interval and interval-point overloads instead of promoting the point to an interval, so `(null as Integer) after Interval[1, 10]` and `(null as Integer) before Interval[1, 10]` are `null`, while `11 after Interval[1, 10]`, `0 before Interval[1, 10]`, `Interval[1, 10] after 0` and `Interval[1, 10] before 11` are `true`. A comparison at a precision the operands do not both carry yields `null` rather than `false`, so `@2024 after Interval[@2023-01-01, @2024-01-01]` is `null`. (#1626)

This changes CQL evaluation results.
