## Fixes

- An interval selector with two untyped `null` boundaries (`Interval[null, null]`, `Interval(null, null)`)
  translates to an `Interval<Any>` instead of raising a translation error, and the `AllowNullIntervals`
  translator option now defaults to `true`. This does not change CQL evaluation results for CQL that
  already translated successfully; the option remains available for callers that want the stricter
  behavior.
