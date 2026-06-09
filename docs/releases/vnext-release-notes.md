# vNext Release Notes

## Breaking Changes

## Features

## Fixes
- Fixed list and query results of CQL tuples (e.g. `({ 1 }) X return Tuple { key: ... }`) failing to map to a FHIR type. `CqlTypeToFhirTypeMapper.TypeEntryFor(Type)` now recognizes nullable value tuples (`Nullable<ValueTuple<CqlTupleMetadata, ...>>`), which are produced as list/query element types.
