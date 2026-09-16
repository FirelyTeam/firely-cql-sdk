## Fixes

- The `Interval` system function no longer populates `highClosedExpression` from the low boundary's
  `closed` argument. When the third and fourth arguments are non-literal expressions, both closed
  expressions were taken from the third, so the upper bound's closedness was governed by the lower
  bound's expression, silently and with no error or warning. **CQL evaluation results change**, but
  only for libraries that call `"Interval"(low, high, lowClosed, highClosed)` with non-literal closed
  arguments; the `Interval[...]` selector syntax always emits Boolean literals for those positions
  and was unaffected. (#1616)
