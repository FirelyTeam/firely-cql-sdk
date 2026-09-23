## Fixes

- **FHIR type conversion:** converting a FHIR `base64Binary` value to a CQL `String` now yields the
  base64 text of the content, as FHIR defines it and as the model info declares
  `FHIR.base64Binary.value` (`System.String`). The Firely SDK's `Base64Binary.Value` holds the
  decoded bytes, and the `byte[]` to `string` conversion registered by `FhirTypeConverter` decoded
  them as UTF-8, so content that is not UTF-8 text came out garbled and even text content came out
  as its decoding rather than its base64 form. It now applies `Convert.ToBase64String`. This is the
  conversion behind the generated `FHIRHelpers.ToString(base64Binary)` and behind the
  `Base64Binary` arms of choice-type dispatch, so for example `ToString` of an `Attachment.data` now
  returns `"//6AAA=="` for the bytes `FF FE 80 00`.

  **CQL evaluation results change** wherever an expression turns a `base64Binary` into a `String`,
  which forces a MESO bump per [versioning.md](../../versioning.md). No public API change and no
  `GeneratorToolVersion` change: the emitted C# is unchanged.
