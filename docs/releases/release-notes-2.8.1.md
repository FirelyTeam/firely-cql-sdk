## Firely CQL SDK 2.8.1

### tl;dr

> **Upgrading?** Here is the short version:
>
> - **Breaking changes:** None.
> - **Required migrations:** None.
> - **Highlights:** Fixed a bug in tuple-to-tuple implicit conversion compatibility checking that caused non-first field incompatibilities to be silently ignored.

---

### CQL SDK

#### New Public API

- None. All changes in this release are to internal behavior.

#### Improvements

- **Tuple-to-tuple implicit conversion fix** — `CoercionProvider.HasImplicitConversion` now correctly evaluates all tuple elements when checking whether one tuple type can be implicitly converted to another. Previously, the inner per-element loop contained early `return true` statements that exited the entire method on the first compatible element match, causing incompatibilities in any non-first field to be silently ignored. The fix accumulates the per-element result into a `found` flag, breaks out of the inner loop only, and returns `true` only after all elements have been verified compatible.
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

| PR | Title |
| --- | --- |
| [#1291](https://github.com/FirelyTeam/firely-cql-sdk/pull/1291) | Fix tuple-to-tuple implicit conversion compatibility check |
