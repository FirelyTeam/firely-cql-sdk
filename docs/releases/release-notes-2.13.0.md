## Firely CQL SDK 2.13.0

### tl;dr

> **Upgrading?** Here is the short version:
>
> - **Breaking changes:** FHIR time/dateTime conversion behavior was tightened to emit valid FHIR time-bearing values (including timezone handling), value-set membership now follows closed-world semantics when a value set is resolved locally, and several public API members were removed/changed (notably `FhirTypeConverter` cache-size knobs and `ICqlOperators` precision nullability signatures).
> - **Required migrations:** Remove `cacheSize`/`LRUCacheSize` usage from `FhirTypeConverter.Create(...)`, `FhirCqlContextOptions`, and `ElmToolkitConfig`; update custom `ICqlOperators` implementations to the nullable `string? precision` signatures; and regenerate checked-in generated C# with tool version `5.2.1.0`.
> - **Highlights:** Better evaluation/runtime throughput (type-conversion resolution, collapse, retrieve materialization, age operators, lazy ISO8601 formatting, shared bundle indexing, operator fusion) plus CQL-equality correctness fixes for set operators.

---

### CQL SDK

#### New Public API

- `Hl7.Cql.Fhir.FhirCqlContextOptions.OverrideConverterTimezoneOffset` (`get`/`init`).
- `Hl7.Cql.Fhir.FhirCqlContext.DataSourceForBundle(Bundle bundle, FhirCqlContextOptions? options = null)`.
- `Hl7.Cql.Fhir.FhirTypeConverter.Create(ModelInspector model)`.
- `Hl7.Cql.Fhir.FhirTypeConverter.Create(ModelInspector model, TimeSpan? defaultTimezoneOffset)`.
- New fused list operators on `Hl7.Cql.Operators.ICqlOperators`:
  - `bool? WhereAny<T>(IEnumerable<T>? source, Func<T, bool?> lambda)`
  - `IEnumerable<TR>? WhereSelect<T, TR>(IEnumerable<T>? source, Func<T, bool?> lambda, Func<T?, TR> select)`
  - `IEnumerable<TR>? SelectWhere<T, TR>(IEnumerable<T?>? source, Func<T?, TR> select, Func<TR, bool?> lambda)`
  - `IEnumerable<TR>? SelectDistinct<T, TR>(IEnumerable<T?>? source, Func<T?, TR> select)`

#### Improvements

- Added reusable bundle-backed data-source construction (`DataSourceForBundle`) so repeated evaluations can share one prebuilt index/coding cache over immutable bundle data. (#1467)
- Age operators now resolve patient/birth-date lookup data once per evaluation context instead of per query element. (#1469, #1518)
- `TypeConverter` now resolves applicable conversion paths once rather than repeating converter selection per value. (#1471)
- Aggregate operators (`Avg`, `Median`, `GeometricMean`) received correctness and single-pass evaluation fixes. (#1474)
- `Collapse` interval merge phase now runs linearly over sorted data rather than using repeated front-removals. (#1475)
- Bundle retrieves are materialized once per retrieve shape over bundle-backed sources, avoiding repeated re-evaluation of the same filter pipeline. (#1480)
- Resource-type enumeration for id-based FHIR comparer registration is now process-level lazy initialization instead of per-call reflection sweeps. (#1481)
- ISO8601 string formatting for date/time primitives moved to lazy computation, reducing construction-time allocations. (#1482)
- Codegen/runtime now fuse select/where patterns into single-pass list operators, removing intermediate list materialization in those cases. (#1490)
- Value-set membership checks for resolved value sets now avoid terminology-service fallback round-trips, including code-only checks. (#1510)
- List `Intersect` now uses CQL equality semantics (same comparer path as `Except`/`Union`/`Distinct`) for value-equal non-reference-equal values. (#1553)

#### Dependency Updates

- `FirelyNetVersion` remains `6.3.0` (`cql-base.props`, `Demo/cql-demo.props`) and matches Vonk `FhirNetApiVersion` (`Directory.Packages.props`) at release cut time.

#### Potentially Breaking

- FHIR conversion output is now normalized to valid FHIR lexical forms for partial-precision time/dateTime and timezone handling. This includes zero-padding missing minute/second components, extension-based precision round-tripping, and timezone emission rules for time-bearing dateTimes. (#1458)
- Value-set membership now follows closed-world semantics when a value set is already resolved/expanded locally; unresolved misses are no longer automatically validated remotely. `ValueSetSource.Add` now rejects partial expansions. (#1510)
- Removed cache-size API surface:
  - `*REMOVED* Hl7.Cql.Fhir.FhirTypeConverter.Create(ModelInspector model, int? cacheSize = null)`
  - `*REMOVED* Hl7.Cql.Fhir.FhirTypeConverter.Create(ModelInspector model, int? cacheSize, TimeSpan? defaultTimezoneOffset)`
  - `*REMOVED* Hl7.Cql.Fhir.FhirCqlContextOptions.OverrideFhirTypeConverterCacheSize`
  - `*REMOVED* Hl7.Cql.CodeGeneration.NET.Toolkit.ElmToolkitConfig.LRUCacheSize` (including positional record constructor/deconstruct member shape)
  Migration: remove `cacheSize` and `LRUCacheSize` arguments/initializers. (#1525)
- `Distinct`, `Union`, and `Except` now hash consistently with CQL equality normalization for edge cases (normalized strings, truncated-decimal equality, boundary-equivalent intervals, and tuples containing such values), which can collapse previously separate groups. (#1532)
- `ICqlOperators` precision parameter nullability was normalized on remaining interval/age members from `string` to `string?`; custom implementations must update signatures to match the interface contract. (#1555)
- Generated-code contract moved from `5.2.0.0` to `5.2.1.0` (final value in `LibrarySetCSharpCodeGenerator.GeneratorToolVersion`). `LibraryInstanceInvoker_5_0` still supports this range via `MinSupportedGeneratorToolVersion = 5.1.0.0` and `FirstUnsupportedGeneratorToolVersion = 5.3.0.0`. (#1490, #1555)

---

### CQL Packager

#### Breaking

- None.

#### Improvements

- None.

---

### Demo Projects and Build Tooling

#### Breaking

- Build warning policy enforcement moved to shared base props (`cql-base.props`) and is now consistently applied; projects that previously compiled with tolerated warnings may now fail until warnings are fixed. (#1526)

#### Improvements

- CI restore/build wiring was corrected so Release-only dependencies (including Public API analyzers) are restored for Release builds, allowing analyzer enforcement in automation. (#1559)
- Legacy MSBuild namespace declarations were removed from project/build files for current tooling consistency. (#1520)

---

### Upgrade Checklist

1. Regenerate checked-in generated C# artifacts against generator tool version `5.2.1.0` and upgrade runtime/invocation packages together.
2. Remove deprecated cache-size API usage:
   - `FhirTypeConverter.Create(model, cacheSize)` -> `FhirTypeConverter.Create(model)`
   - `FhirTypeConverter.Create(model, cacheSize, defaultTimezoneOffset)` -> `FhirTypeConverter.Create(model, defaultTimezoneOffset)`
   - `FhirCqlContextOptions.OverrideFhirTypeConverterCacheSize` -> remove
   - `ElmToolkitConfig.LRUCacheSize` argument/initializer -> remove
3. If you implement `ICqlOperators`, update affected method signatures to `string? precision`.
4. If you rely on value-set fallback to external terminology for locally resolved sets, move to complete expansions or leave those value sets unresolved so service routing still applies.
5. If you have tests/assertions over emitted FHIR time/dateTime lexical forms, update expected output for precision-padding and timezone emission behavior.

---

### Pull Requests

| PR | Title |
| --- | --- |
| [#1559](https://github.com/FirelyTeam/firely-cql-sdk/pull/1559) | Fix Release restore config in CI |
| [#1555](https://github.com/FirelyTeam/firely-cql-sdk/pull/1555) | Normalize ICqlOperators precision nullability |
| [#1554](https://github.com/FirelyTeam/firely-cql-sdk/pull/1554) | Add PR pickup base-merge convention |
| [#1553](https://github.com/FirelyTeam/firely-cql-sdk/pull/1553) | Use CQL comparer in list Intersect |
| [#1551](https://github.com/FirelyTeam/firely-cql-sdk/pull/1551) | Clarify existing copyright header rules |
| [#1539](https://github.com/FirelyTeam/firely-cql-sdk/pull/1539) | Remove stale TODO reference in XmlTest.Run comment |
| [#1532](https://github.com/FirelyTeam/firely-cql-sdk/pull/1532) | Align comparer hashes with normalized equality |
| [#1530](https://github.com/FirelyTeam/firely-cql-sdk/pull/1530) | Add stale-issue supersession guidance |
| [#1526](https://github.com/FirelyTeam/firely-cql-sdk/pull/1526) | Fix 820 nullable warnings; enforce via cql-base.props |
| [#1525](https://github.com/FirelyTeam/firely-cql-sdk/pull/1525) | Remove FhirTypeConverter's CqlDateTime LRU cache |
| [#1520](https://github.com/FirelyTeam/firely-cql-sdk/pull/1520) | Remove legacy MSBuild namespaces |
| [#1518](https://github.com/FirelyTeam/firely-cql-sdk/pull/1518) | Extract PatientTypeInfo, narrow age operators' dependency |
| [#1517](https://github.com/FirelyTeam/firely-cql-sdk/pull/1517) | Remove dead _typeSpecifiers field from FhirTypeResolver |
| [#1513](https://github.com/FirelyTeam/firely-cql-sdk/pull/1513) | Record review conventions and reflection policy |
| [#1510](https://github.com/FirelyTeam/firely-cql-sdk/pull/1510) | Answer value set membership without a TS round-trip |
| [#1509](https://github.com/FirelyTeam/firely-cql-sdk/pull/1509) | Validate emitted FHIR in tests, not just its text |
| [#1490](https://github.com/FirelyTeam/firely-cql-sdk/pull/1490) | Fuse immediately-consumed Where/Select chains at codegen |
| [#1482](https://github.com/FirelyTeam/firely-cql-sdk/pull/1482) | Format Iso8601 date/time strings lazily |
| [#1481](https://github.com/FirelyTeam/firely-cql-sdk/pull/1481) | Compute the resource-type list once per process |
| [#1480](https://github.com/FirelyTeam/firely-cql-sdk/pull/1480) | Materialize bundle retrieve results once |
| [#1475](https://github.com/FirelyTeam/firely-cql-sdk/pull/1475) | Linear merge walk in Collapse |
| [#1474](https://github.com/FirelyTeam/firely-cql-sdk/pull/1474) | Fix Median and GeometricMean; make aggregates single-pass |
| [#1471](https://github.com/FirelyTeam/firely-cql-sdk/pull/1471) | Resolve each type conversion once, not per call |
| [#1469](https://github.com/FirelyTeam/firely-cql-sdk/pull/1469) | Resolve age operators' patient lookup once |
| [#1467](https://github.com/FirelyTeam/firely-cql-sdk/pull/1467) | Allow sharing a prebuilt bundle index across data sources |
| [#1458](https://github.com/FirelyTeam/firely-cql-sdk/pull/1458) | Pad partial-precision times/dateTimes for FHIR |
