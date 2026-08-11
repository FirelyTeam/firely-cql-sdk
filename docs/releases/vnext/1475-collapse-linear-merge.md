## Improvements

- `Collapse` no longer spends superlinear time merging its intervals. The merge phase used to drain the sorted
  list with `RemoveAt(0)`, shifting every remaining element down one slot per interval; it now walks the sorted
  list front to back into a result list pre-sized to the input, which visits the intervals in the same order and
  produces the same result. Measured on disjoint intervals (Release): 229 ms to 4,794 ms going from 25,000 to
  200,000 intervals before, against 190 ms to 536 ms after - roughly 8.9x faster at 200,000 intervals, and
  essentially linear rather than superlinear. Since `Collapse` runs over interval lists built from patient data
  (encounter and medication periods), the cost grew with the size of a patient's history. (#1473)
- The emptiness pre-check in the same helper no longer type-tests `IList<T>`/`T[]`. Those tests asked about the
  interval *point* type rather than the `CqlInterval<T?>` element type the sequence actually holds, so they could
  never match and were dead, misleading code. They are replaced with `Enumerable.TryGetNonEnumeratedCount`, which
  states the intent directly. This is a readability change with no performance effect: the `Count()` fallback the
  dead tests always reached already short-circuits on `ICollection<T>`, so materialized lists and arrays were
  never walked. (#1473)
