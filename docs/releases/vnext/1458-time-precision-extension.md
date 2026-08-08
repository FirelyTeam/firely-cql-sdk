## Features

- Added `Hl7.Cql.Fhir.FhirCqlContextOptions.OverrideConverterTimezoneOffset` and the
  `Hl7.Cql.Fhir.FhirTypeConverter.Create(ModelInspector, int?, TimeSpan?)` overload, which set the
  timezone offset a CQL value without one is emitted with when it becomes a FHIR `dateTime` carrying
  a time component. The fallback chain is `OverrideConverterTimezoneOffset`, then the offset of the
  `now` argument passed to `FhirCqlContext.ForBundle`/`WithDataSource` — the timestamp of the
  evaluation request, which the CQL specification names as the default — then UTC. The offset must
  be a whole number of minutes within ±14:00. See the timezone bullet under "Breaking changes" for
  what the emitted values now look like, including the two cases that keep UTC regardless. (#1458)

## Breaking changes

- Converting a partial-precision `System.Time` or `System.DateTime` value to FHIR now produces a
  lexically valid FHIR value, per the CQL-to-FHIR type mapping
  (`spec/fhir/condensed/fhir-uv-cql-conformance.md`, "FHIR Type Mapping"; FHIR-55977): missing minutes/seconds are
  zero-padded (e.g. `@T10` becomes `10:00:00`, `@2014-02-01T10` becomes `2014-02-01T10:00:00Z` — or
  the evaluation request's offset in place of `Z`, see the timezone bullet below) and
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
  time component, as FHIR requires (R4 datatypes: "if hours and minutes are specified, a time zone
  SHALL be populated"). A CQL value without an offset is emitted with the evaluation request's
  offset, UTC by default (`@2014-02-01T10:30` becomes `2014-02-01T10:30:00Z`; see the note below), a
  zero offset renders as `Z` on every path (previously the boundaries of a
  `Period` converted from an `Interval<Time>` rendered it as `+00:00`), and an explicit non-zero
  offset on a `DateTime` value is preserved as `±hh:mm` (the boundaries of a `Period` converted
  from an `Interval<Time>` always anchor in UTC instead — see the exceptions note below).
  Date-only `dateTime` values stay offset-free — FHIR forbids an offset without a time.

  **Note:** Per the CQL specification (§2 Author's Guide) an absent timezone offset is the timezone
  offset of the evaluation request, and that is the offset an offset-less CQL value is emitted with:
  the offset of the `now` argument passed to `FhirCqlContext.ForBundle`/`WithDataSource`, or the one
  set explicitly through `FhirCqlContextOptions.OverrideConverterTimezoneOffset` (or
  `FhirTypeConverter.Create`'s `defaultTimezoneOffset` parameter, for a converter built directly).
  When neither is supplied the offset is UTC, which matches the UTC evaluation timestamp the engine
  synthesizes for an omitted `now`. The construction-side half of the specification's rule — an
  offset-less value keeping a null offset, so `timezoneoffset from @2014-02-01T10:30` returns null
  instead of the evaluation request's offset — is unchanged and remains tracked in #1507. Because
  FHIR cannot represent "no offset" on a time-bearing `dateTime`, an offset-less CQL value comes back
  carrying whichever offset was emitted when converted from FHIR to CQL again; its precision is still
  restored from the time-precision extension (#1458, closes #1506).

  **Two exceptions keep UTC.** The `dateTime` boundaries of a `Period` converted from an
  `Interval<Time>` are anchored on the synthetic minimum date `0001-01-01` and always render `Z`:
  a non-UTC offset would put every time of day earlier than a positive offset before the earliest
  instant FHIR and .NET can represent (`0001-01-01T00:30:00+02:00` is not a readable value), and the
  specification's default is about `DateTime` values anyway — a CQL `Time` has no timezone to
  default. That covers a vestigial offset carried by the `CqlTime` itself too: it is dropped on this
  path, exactly as on the FHIR `time` path below. A `DateTime` value at the very edge of the
  representable range keeps UTC for the same reason, i.e. one on `0001-01-01` whose time of day is
  earlier than a positive request offset, or one on `9999-12-31` that a negative request offset
  would push past midnight; an explicit offset on a `DateTime` value is still rendered as-is.

- FHIR `time` output no longer carries a timezone offset: a vestigial offset on a `CqlTime`
  (unreachable from CQL source, since CQL's `Time` type has no timezone concept) is now dropped
  rather than emitted, because FHIR forbids one on `time` (R4: "a time zone SHALL NOT be present").
