## Fixes

- **Converting a FHIR `Code<TEnum>` to its `TEnum?` no longer throws.** The conversion that
  `FhirTypeConverter` registers for every FHIR enumeration read the code's `ObjectValue`, which holds
  the FHIR literal as a `string` (for example `"female"`), and cast that to the enum, so it always
  failed with an `InvalidCastException`. It now returns the code's enum value, or `null` when the
  code has none (#1804).

  **This changes CQL evaluation results.** `FhirCqlContext` installs this converter in
  `CqlOperators`, so an evaluation that reached this conversion used to fail and now produces a
  value. Per [versioning.md](../../versioning.md) this forces a **MESO** bump. No public API, emitted
  C# or `GeneratorToolVersion` changes.
