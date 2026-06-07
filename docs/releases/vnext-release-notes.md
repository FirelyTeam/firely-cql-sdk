# vNext Release Notes

## Breaking Changes

## Features

## Fixes

- Added conversions from `CqlCode` to FHIR `Coding` and from `CqlConcept` to FHIR `CodeableConcept`, fixing an `ExpressionBuildingError` ("Cannot convert Hl7.Cql.Primitives.CqlConcept to Hl7.Fhir.Model.CodeableConcept") when compiling libraries that bind a concept to a FHIR `CodeableConcept` element (e.g. CMS108FHIRVTEProphylaxis).
