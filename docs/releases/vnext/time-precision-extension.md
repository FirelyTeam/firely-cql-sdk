## Breaking changes

- Converting a partial-precision `System.Time` or `System.DateTime` value to FHIR now produces a
  lexically valid FHIR value, per the CQL-to-FHIR type mapping: missing minutes/seconds are
  zero-padded (e.g. `@T10` becomes `10:00:00`, `@2014-02-01T10` becomes `2014-02-01T10:00:00`) and
  the original precision is recorded in the
  [time-precision extension](http://hl7.org/fhir/StructureDefinition/time-precision) (`h` for hour
  precision, `min` for minute precision). This also applies to the `dateTime` boundaries of a
  `Period` converted from an `Interval<DateTime>` or `Interval<Time>`. Previously such values were
  emitted at their original precision, which is not valid FHIR (FHIR `time` requires `hh:mm:ss`,
  and FHIR `dateTime` requires minutes and seconds once hours are present). Values at second
  precision or finer, and date-only `DateTime` values, are unaffected. In the FHIR-to-CQL
  direction, a `time`/`dateTime` carrying the extension is truncated back to its declared
  precision, so padded values round-trip to the original partial-precision value (#1456).
