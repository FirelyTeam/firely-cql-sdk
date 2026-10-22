## Potentially Breaking

- **FHIR type converter** — An exclusive boundary of an `Interval<DateTime>` without a timezone offset converts to a
  FHIR `Period` boundary at the converter's default timezone offset, which is the evaluation request's unless
  `FhirCqlContextOptions.OverrideConverterTimezoneOffset` sets another. It used to convert at UTC, while the inclusive
  boundary of the same interval already took the default. A `Period` is inclusive at both ends, so the converter steps
  an exclusive boundary inward by one unit of its precision, and that step gave the value an explicit UTC offset. Under
  an evaluation request at `+02:00`, the measurement period `Interval[@2024-01-01T00:00:00.0, @2025-01-01T00:00:00.0)`
  converted to a `Period` ending at `2024-12-31T23:59:59.999Z`, two hours after the period ends. It now ends at
  `2024-12-31T23:59:59.999+02:00`. A stepped boundary on 0001-01-01 or 9999-12-31 that cannot carry the default keeps
  UTC, as an unstepped boundary does. Under a UTC evaluation request the output is unchanged. (#1507)

This changes the FHIR the SDK emits for such intervals. CQL evaluation results, generated C# and
`GeneratorToolVersion` are unchanged.
