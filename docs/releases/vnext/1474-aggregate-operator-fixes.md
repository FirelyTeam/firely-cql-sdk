## Fixes

- `Median` returns the middle of the sorted, non-null values for an odd-count list, in all three overloads
  (`Decimal`, `Integer`, `Long`). The odd-count branch read the middle index out of the original source instead of
  the sorted, null-stripped values, so it returned an arbitrary element: `Median({ 8, 2, 4 })` gave `2` rather than
  `4`, and `Median({ 8, null, 2, null, 4 })` gave `null`. The even-count branch was already correct (#1472).
- `GeometricMean` takes the root over the non-null count, as the spec (§9.B) defines it —
  `Power(Product(X), 1 / Count(X))` over the non-null elements. Counting the nulls that the product had skipped
  made `GeometricMean({ 2.0, null, 8.0, null })` return `2.0` instead of `4.0`. As a side effect of the corrected
  exponent, an input whose only non-null value is negative (e.g. `{ -16.0, null }`) now returns that value where it
  previously threw an `OverflowException` (`Math.Pow` of a negative base with a fractional exponent is `NaN`) (#1472).
- `GeometricMean` of a list containing a genuine `0` returns `0`. The product loop treated a zero product as
  "not yet initialized" and dropped the element while still counting it, so `GeometricMean({ 0.0, 4.0, 9.0 })`
  returned `3.3019...` instead of `0` (#1474).

## Improvements

- `Avg`, `Median` and `GeometricMean` walk their source exactly once. `Avg` previously walked its filtered query
  three times (emptiness test, summation, count), and `GeometricMean` and `Median`'s odd-count branch twice each,
  which re-ran the producing query for a lazily evaluated source (#1472).
