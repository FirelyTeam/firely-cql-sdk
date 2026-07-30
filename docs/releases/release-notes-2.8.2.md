## Firely CQL SDK 2.8.2

### tl;dr

> **Upgrading?** Here is the short version:
>
> - **Breaking changes:** None.
> - **Required migrations:** None.
> - **Highlights:**
>   - Added conversions from `CqlCode` to FHIR `Coding` and from `CqlConcept` to FHIR `CodeableConcept`.
>   - Fixed list/query tuple result mapping for nullable value tuples.

---

### CQL SDK

#### New Public API

- None. All changes in this release are to internal behavior.

#### Improvements

- Added conversions from `CqlCode` to FHIR `Coding` and from `CqlConcept` to FHIR `CodeableConcept`, fixing an `ExpressionBuildingError` ("Cannot convert Hl7.Cql.Primitives.CqlConcept to Hl7.Fhir.Model.CodeableConcept") when compiling libraries that bind a concept to a FHIR `CodeableConcept` element.
- Fixed list and query results of CQL tuples (e.g. `({ 1 }) X return Tuple { key: ... }`) failing to map to a FHIR type. `CqlTypeToFhirTypeMapper.TypeEntryFor(Type)` now recognizes nullable value tuples (`Nullable<ValueTuple<CqlTupleMetadata, ...>>`), which are produced as list/query element types.

#### Dependency Updates

- None.

#### Potentially Breaking

- None.

---

### CQL Packager

#### Breaking

- None.

#### Improvements

- None.

---

### Demo Projects and Build Tooling

#### Breaking

- None.

#### Improvements

- None.

---

### Upgrade Checklist

1. No migration steps required.

---

### Pull Requests

| PR                                                              | Title                                                      |
| --------------------------------------------------------------- | ---------------------------------------------------------- |
