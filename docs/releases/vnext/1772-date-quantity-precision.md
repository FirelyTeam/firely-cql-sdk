## Fixes

- **`Date` and `DateTime` plus or minus a quantity more precise than the value convert the quantity
  to the value's precision first.** The quantity was applied at its own precision and only the
  result was truncated. The "Add" and "Subtract" sections of "Date and Time Operators" (CQL
  Appendix B – Reference) state: "For partial date/time values where the time-valued quantity is more
  precise than the partial date/time, the operation is performed by converting the time-based
  quantity to the most precise value specified in first argument (truncating any resulting decimal
  portion) and then adding it to the first argument", and the same for subtraction. The quantity is
  converted with the calendar duration conversions the specification lists for equivalence
  (12 months per year, 365 days per year, 30 days per month, 7 days per week, 24 hours per day, then
  60, 60 and 1000), truncating toward zero. Consequently `Date(2014) - 25 months` is `@2012` (was
  `@2011`), `DateTime(2014) - 25 months` is `@2012T` (was `@2011T`) and `Date(2014,6) - 33 days` is
  `@2014-05` (was `@2014-04`), and the cqframework conformance cases
  `DateSubtract2YearsAsMonthsRem1`, `DateTimeSubtract2YearsAsMonthsRem1` and `DateSubtract33Days` run
  and pass. Some additions move as well, for example `Date(2014,6) + 60 days` is `@2014-08` (was
  `@2014-07`) and `DateTime(2016) + 365 days` is `@2017T` (was `@2016T`). A quantity at or above the
  value's precision is applied as before, and `Time` arithmetic is unchanged.

  **This changes CQL evaluation results.** Per [versioning.md](../../versioning.md) this forces a
  **MESO** bump. No `ICqlOperators` signature, emitted C# or `GeneratorToolVersion` changes. (#1771)
