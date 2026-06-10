# vNext Release Notes

## Breaking Changes

## Features

## Fixes

- Added conversions from `CqlCode` to FHIR `Coding` and from `CqlConcept` to FHIR `CodeableConcept`, fixing an `ExpressionBuildingError` ("Cannot convert Hl7.Cql.Primitives.CqlConcept to Hl7.Fhir.Model.CodeableConcept") when compiling libraries that bind a concept to a FHIR `CodeableConcept` element.
- Fixed list and query results of CQL tuples (e.g. `({ 1 }) X return Tuple { key: ... }`) failing to map to a FHIR type. `CqlTypeToFhirTypeMapper.TypeEntryFor(Type)` now recognizes nullable value tuples (`Nullable<ValueTuple<CqlTupleMetadata, ...>>`), which are produced as list/query element types.
