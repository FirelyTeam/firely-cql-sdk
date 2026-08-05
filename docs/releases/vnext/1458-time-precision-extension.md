## Breaking changes

- Converting a partial-precision `System.Time` or `System.DateTime` value to FHIR now produces a
  lexically valid FHIR value, per the CQL-to-FHIR type mapping: missing minutes/seconds are
  zero-padded (e.g. `@T10` becomes `10:00:00`, `@2014-02-01T10` becomes `2014-02-01T10:00:00Z`) and
  the original precision is recorded in the
  [time-precision extension](http://hl7.org/fhir/StructureDefinition/time-precision) (`h` for hour
  precision, `min` for minute precision). This also applies to the `dateTime` boundaries of a
  `Period` converted from an `Interval<DateTime>` or `Interval<Time>`. Previously such values were
  emitted at their original precision, which is not valid FHIR (FHIR `time` requires `hh:mm:ss`,
  and FHIR `dateTime` requires minutes and seconds once hours are present). Values at second
  precision or finer, and date-only `DateTime` values, are unaffected. In the FHIR-to-CQL
  direction, a `time`/`dateTime` carrying the extension is truncated back to its declared
  precision, so padded values round-trip to the original partial-precision value (#1458, closes #1456).

- Every FHIR `dateTime` converted from a CQL value now carries a timezone offset whenever it has a
  time component, as FHIR requires ("if hours and minutes are specified, a timezone offset SHALL be
  populated"). A CQL value without an offset is emitted as UTC (`@2014-02-01T10:30` becomes
  `2014-02-01T10:30:00Z`), a zero offset renders as `Z` on every path (previously the boundaries of a
  `Period` converted from an `Interval<Time>` rendered it as `+00:00`), and an explicit non-zero
  offset is preserved as `±hh:mm`. Date-only `dateTime` values stay offset-free — FHIR forbids an
  offset without a time — and FHIR `time` values are unaffected, since that datatype has no timezone
  offset concept. Because FHIR cannot represent "no offset" on a time-bearing `dateTime`, an
  offset-less CQL value comes back as UTC — a zero offset, rendering as `Z` — when converted from
  FHIR to CQL again; its precision is still restored from the time-precision extension
  (#1458, closes #1506).
