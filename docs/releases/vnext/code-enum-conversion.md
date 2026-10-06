## Fixes

- **Converting a FHIR `Code<TEnum>` to its `TEnum?` no longer throws.** The conversion that
  `FhirTypeConverter` registers for every FHIR enumeration read the code's `ObjectValue`, which holds
  the FHIR literal as a `string` (for example `"female"`), and cast that to the enum, so it always
  failed with an `InvalidCastException`. It now returns the code's enum value, or `null` when the
  code has none. No call that succeeded before returns anything different; no public API, emitted
  C# or `GeneratorToolVersion` changes.
