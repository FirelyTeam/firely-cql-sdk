## Fixes

- **Iso8601:** `DateIso8601.TryParse` and `DateTimeIso8601.TryParse` return `false` for a date that
  does not exist, such as `2026-13-45` or 29 February in a common year, instead of throwing
  `ArgumentOutOfRangeException`. `CqlDate.TryParse` and `CqlDateTime.TryParse` delegate to them and
  change with them.

- **CQL-to-ELM translator:** `@2026-13-45` reports `Unparseable date literal '2026-13-45'.` instead
  of throwing out of translation.

  **This changes CQL evaluation results**: the runtime uses these methods for FHIR date values, so
  a Patient whose `birthDate` is `2026-02-29` now makes `Patient.birthDate < @2000-01-01` yield
  `null` where evaluation threw. Dates that exist parse and evaluate exactly as before. No
  `GeneratorToolVersion` change: the emitted C# is identical.
