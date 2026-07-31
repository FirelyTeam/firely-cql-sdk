## Fixes

- The interval `intersect` operator no longer returns `null` whenever one of the operands has a
  `null` boundary. Null closed boundaries are now interpreted as the minimum/maximum value of the
  point type, and null open boundaries as unknown boundaries, per the CQL specification:
  `Interval[1, 10] intersect Interval[5, null)` now returns `Interval[5, null)` instead of `null`,
  and `Interval[1, 10] intersect Interval[5, null]` now returns `Interval[5, 10]`. The result is
  still `null` when the operands do not overlap or when an unknown boundary makes the overlap
  undeterminable. (#1457)
