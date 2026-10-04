## Fixes

- **A FHIR `Ratio` converts to the CQL `Ratio` type.** The FHIR type converter
  (`FhirTypeConverter`) converted a CQL `Ratio` to a FHIR `Ratio` but had no conversion back, so a
  FHIR `Ratio` - including a `Parameters` parameter whose value is a `Ratio` - could not be converted
  to a `CqlRatio`, and ELM that hands the compiler a FHIR `Ratio` where a `System.Ratio` is required
  failed to compile. The numerator and denominator convert the way a FHIR `Quantity` does; a FHIR
  `Ratio` missing either part, or holding a part without a value, converts to `null`, since a CQL
  `Ratio` requires both. Libraries that convert through `FHIRHelpers.ToRatio` are unaffected: no
  CQL evaluation result of an existing library changes, and `GeneratorToolVersion` is unchanged.
