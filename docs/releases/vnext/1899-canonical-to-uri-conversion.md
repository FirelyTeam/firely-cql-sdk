## Fixes

- **Runtime (`Hl7.Cql.Fhir`)** — A `FHIR.canonical` argument now binds to a function parameter of type `FHIR.uri`, such
  as `FHIRHelpers.ToString(value uri)`. The FHIR model info declares `canonical` as a subtype of `uri`, so the translator
  resolves the call without a conversion, but the .NET model holds `Canonical` and `FhirUri` as sibling types; the FHIR
  type converter now bridges that gap, as it already does for `id` and `code` to `string`. Libraries that failed to compile
  on such a call, including FHIRCommon 2.0.0's `url()` and `version()` fluent functions, now compile and evaluate. (#1899)
