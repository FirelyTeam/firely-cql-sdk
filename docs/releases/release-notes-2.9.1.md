## Firely CQL SDK 2.9.1

### tl;dr

> **Upgrading?** Here is the short version:
>
> - **Breaking changes:** The CQL Packager's default fixed canonical URL for `FHIRHelpers` changed from `https://fhir.org/guides/cqf/common/Library/FHIRHelpers` to `http://hl7.org/fhir/uv/cql/Library/FHIRHelpers`.
> - **Required migrations:** If you rely on the Packager's previous default `FHIRHelpers` canonical, set it explicitly via `FixedLibraryCanonicals` in your Packager configuration.
> - **Highlights:** Significant runtime performance improvements to `RunLibrary`/`SelectResults` and to `CqlComparers`/`CqlOperators` (notably `Distinct`), a fix for ELM choice-type handling in generated code, and an update of the Firely .NET SDK dependency to 6.2.1. Aside from the `FHIRHelpers` canonical default noted above, this release contains no correctness or behavior changes to CQL evaluation results.

---

### CQL SDK

#### New Public API

- None.

#### Improvements

- Optimized the `RunLibrary`/`SelectResults` hot path with a value-set fast path, a direct-delegate invoker, and cache tuning, reducing evaluation overhead by roughly 40% in benchmarks (#1322, #1323).
- Fixed O(n²) hot paths in `CqlComparers`/`CqlOperators`: `Distinct` now uses a `HashSet`-based O(n) algorithm instead of repeated `List.Contains` scans, comparer type-resolution is memoized instead of re-walking base types on every call, boxing was removed from equality fast paths, and `CqlConcept` comparisons cache their sorted code arrays instead of re-sorting on every `Compare` (#1324, #1327).
- The C# compiler now collapses ELM choice types whose alternatives all map to the same .NET type (e.g. `Choice<Condition, Condition>` produced for unions of QiCore Condition profiles) to that single type instead of `object`. Generated code stays strongly typed and no longer falls back to late-bound property access (seen in e.g. CMS125 "Right Mastectomy Diagnosis"). The generator tool version was bumped to 5.1.2.0 and the checked-in generated libraries were regenerated (#1317).

#### Dependency Updates

- Bumped the Firely .NET SDK (`Hl7.Fhir.Base`/`Hl7.Fhir.R4`) dependency from 6.2.0 to 6.2.1 (#1320).

#### Potentially Breaking

- None.

---

### CQL Packager

#### Breaking

- Changed the default fixed canonical URL for `FHIRHelpers` from `https://fhir.org/guides/cqf/common/Library/FHIRHelpers` to `http://hl7.org/fhir/uv/cql/Library/FHIRHelpers` (the CQL IG canonical) in `PackagingToolkitConfig.CreateDefaultFixedLibraryCanonicals()`. The matching example in `Hl7.Cql.Packager.appsettings.json` was updated to stay consistent. If you depend on the previous default, override it explicitly via `FixedLibraryCanonicals` (#1312).

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

1. If your build relies on the Packager's previous default `FHIRHelpers` fixed canonical (`https://fhir.org/guides/cqf/common/Library/FHIRHelpers`), set it explicitly via `FixedLibraryCanonicals` in your Packager configuration — the default is now `http://hl7.org/fhir/uv/cql/Library/FHIRHelpers`.
2. No other action required.

---

### Pull Requests

| PR                                                              | Title                                                                                    |
| ---------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| [#1312](https://github.com/FirelyTeam/firely-cql-sdk/pull/1312) | Update default FHIRHelpers canonical URL to hl7.org/fhir/uv/cql                            |
| [#1320](https://github.com/FirelyTeam/firely-cql-sdk/pull/1320) | Update Firely .NET SDK to v6.2.1                                                           |
| [#1317](https://github.com/FirelyTeam/firely-cql-sdk/pull/1317) | Collapse single-type ELM choice types to concrete type                                    |
| [#1323](https://github.com/FirelyTeam/firely-cql-sdk/pull/1323) | Optimize RunLibrary/SelectResults hot path: value set fast path, direct-delegate invoker, cache tuning (-40%) |
| [#1327](https://github.com/FirelyTeam/firely-cql-sdk/pull/1327) | Fix O(n²) Distinct and comparer dispatch hot paths (#1324)                                |
| [#1330](https://github.com/FirelyTeam/firely-cql-sdk/pull/1330) | Update the next release package version from 2.9.0 to 2.9.1 (#1329)                       |
