## Firely CQL SDK 2.8.0

### tl;dr

> **Upgrading?** Here is the short version:
>
> - **Breaking changes:** None.
> - **Required migrations:** Update any direct NuGet references to use `FirelyNetVersion` `6.2.0` if you have a direct dependency on the Firely .NET SDK.
> - **Highlights:** Cross-library reference resolution fixes for concepts, codes, and code systems (resolving real-world measure build failures such as CMS108FHIRVTEProphylaxis), plus an upgrade to Firely .NET SDK `6.2.0`.

---

### CQL SDK

#### New Public API

- None. All changes in this release are to internal types and behavior.

#### Improvements

- **Cross-library reference resolution** — Definitions referenced across libraries are now resolved in their correct defining library context:
  - `ConceptRef`, `CodeRef`, and `CodeSystemRef` referenced through a library alias now resolve against the library that actually defines them, instead of always against the referencing (context) library. This fixes data requirements analysis failures for measures that reference concepts/codes defined in included libraries (e.g. `CMS108FHIRVTEProphylaxis`).
  - Aliased `CodeRef` resolution in a concept context is now correct.
- **ELM tuple type compatibility generalized** — `ElmTupleTypeUtility` now determines union/tuple property type compatibility through `TypeConverter.CanConvert` instead of a hardcoded `CqlDateTime`/`FhirDateTime` special case. This lets any type pair the type converter knows about (not just date/time) participate in tuple union operations.
- **DateTime no longer mis-compiled to a point-less interval** — Removed dead code in `TimingExpressionVisitor` and re-enabled the previously skipped `Issue32DateTime` conformance test; a `DateTime` is no longer incorrectly compiled to an `Interval` without a point type (fixes [#542](https://github.com/FirelyTeam/firely-cql-sdk/issues/542)).
- **QICore type mapping** — `BaseTypeResolver` now remaps the QICore `DoNotPerformReason` extension type to the core FHIR `CodeableConcept` type before lookup.

#### Dependency Updates

- `FirelyNetVersion`: `6.1.1` → `6.2.0` — affects all packages that consume Firely .NET SDK types (`Hl7.Fhir.Base`, `Hl7.Fhir.R4`).
- `Microsoft.Extensions.Logging.Abstractions`: `10.0.3` → `10.0.7` in `Hl7.Cql.Compiler` (aligns the logging package versions and resolves a transitive package downgrade introduced by the Firely 6.2.0 bump).

#### Potentially Breaking

- None.

---

### CQL Packager

#### Breaking

- None.

#### Improvements

- **Data requirements analysis** — `DataRequirementsAnalyzer` now builds `CodeableConcept`/`Coding` output using the defining library of each nested `ConceptDef`, `CodeDef`, and `CodeSystemDef`, producing correct codings for cross-library references.

---

### Demo Projects and Build Tooling

#### Breaking

- None.

#### Improvements

- **Demo Measures dependency alignment** — `Demo/Measures/Measures.csproj` now imports `cql-demo.props` and references `Hl7.Fhir.R4` via the shared `$(FirelyNetVersion)` property (previously pinned to `5.4.0`), keeping the demo in sync with the rest of the SDK.
- **Version drift fixes** — Resolved CI package downgrades after the Firely `6.2.0` bump by aligning `Microsoft.Extensions` package versions rather than applying a broad bump.
- Copyright year updated to `2013-2026`.

---

### Upgrade Checklist

1. Update your NuGet references to use `FirelyNetVersion` `6.2.0` if you have a direct dependency on the Firely .NET SDK.

---

### Pull Requests

| PR | Title |
| --- | --- |
| [#1289](https://github.com/FirelyTeam/firely-cql-sdk/pull/1289) | Fix cross-library definition resolution (CMS108FHIRVTEProphylaxis) |
| [#1288](https://github.com/FirelyTeam/firely-cql-sdk/pull/1288) | Generalize ElmTupleTypeUtility type compatibility |
| [#1287](https://github.com/FirelyTeam/firely-cql-sdk/pull/1287) | Fix cross-library CodeSystemRef resolution |
| [#1285](https://github.com/FirelyTeam/firely-cql-sdk/pull/1285) | Remove dead code, unskip Issue32DateTime test (fixes #542) |
| [#1281](https://github.com/FirelyTeam/firely-cql-sdk/pull/1281) | Upgrade Firely .NET SDK to 6.2.0 and fix version drift |
