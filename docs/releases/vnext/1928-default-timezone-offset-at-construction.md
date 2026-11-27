## Potentially Breaking

- **Runtime** — A CQL `DateTime` constructed without a timezone offset (including every offset-less `DateTime` literal and `ToDateTime(String)` of an offset-less string)
  now carries the timezone offset of the evaluation request whenever it has an hour component, as the specification
  requires ("If no timezone offset is specified, the timezone offset of the evaluation request timestamp is used").
  This changes CQL evaluation results:
  - comparisons, `duration between` and `difference between` at hour precision or finer between an offset-less value
    and a value with an explicit offset now normalize both, instead of comparing wall-clock components;
  - `timezoneoffset from X` returns the evaluation request's offset instead of `null` for such values, including
    values of day precision or coarser;
  - `time from X` normalizes the `DateTime` to the evaluation request's offset before extracting the time;
  - `ToString` of such a value now includes the offset;
  - converting such a value to FHIR emits the evaluation request's offset regardless of
    `FhirCqlContextOptions.OverrideConverterTimezoneOffset`, which now only applies to offset-less values built outside
    CQL evaluation.

  When no evaluation timestamp is supplied, the request is UTC, so offset-less values acquire `+00:00`. `CqlDateTime`
  values built directly in host code are unchanged and keep comparing by wall clock against values with an offset.
  (#1507)
