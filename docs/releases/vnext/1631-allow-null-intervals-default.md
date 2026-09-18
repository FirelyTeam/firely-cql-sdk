## Potentially Breaking

- The `AllowNullIntervals` translator option (`CqlToElmOptions.AllowNullIntervals` and the
  `CqlToolkitConfig` constructor parameter) defaults to `true`. Consumers that rely on the translator
  rejecting `Interval[null, null]` and `Interval(null, null)` pass `AllowNullIntervals: false`
  explicitly. The Packager CLI example configuration `Hl7.Cql.Packager.appsettings.json` carries the
  same default.

## Fixes

- An interval selector with two untyped `null` boundaries (`Interval[null, null]`, `Interval(null, null)`)
  translates to an `Interval<Any>` instead of raising a translation error, matching the reference
  translator and the cqframework cql-tests suite. This does not change CQL evaluation results for CQL
  that already translated successfully.
