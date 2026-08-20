## Firely CQL SDK 2.13.0

### tl;dr

> **Upgrading?** Here is the short version:
>
> - **Breaking changes:** FHIR time/dateTime conversion behavior was corrected to stop emitting invalid FHIR values and now emit valid FHIR time-bearing values (including timezone handling), value-set membership now follows closed-world semantics when a value set is resolved locally, and several public API members were removed/changed (notably `FhirTypeConverter` cache-size knobs and `ICqlOperators` precision nullability signatures); `Median`/`GeometricMean` now return spec-correct values for inputs that previously produced wrong ones, so aggregate results over affected data will change.
> - **Required migrations:** Remove `cacheSize`/`LRUCacheSize` usage from `FhirTypeConverter.Create(...)`, `FhirCqlContextOptions`, and `ElmToolkitConfig`; update custom `ICqlOperators` implementations to the nullable `string? precision` signatures; and regenerate checked-in generated C# with tool version `5.2.1.0`.
> - **Highlights:** Better evaluation/runtime throughput (type-conversion resolution, collapse, retrieve materialization, age operators, lazy ISO8601 formatting, shared bundle indexing, and single-pass fused operators that combine chained `where`/`select` work) plus CQL-equality correctness fixes for set operators.

---

### CQL SDK

#### New Public API

- `Hl7.Cql.Fhir.FhirCqlContextOptions.OverrideConverterTimezoneOffset` (`get`/`init`).
- `Hl7.Cql.Fhir.FhirCqlContext.DataSourceForBundle(Bundle bundle, FhirCqlContextOptions? options = null)`.
- `Hl7.Cql.Fhir.FhirTypeConverter.Create(ModelInspector model)`.
- `Hl7.Cql.Fhir.FhirTypeConverter.Create(ModelInspector model, TimeSpan? defaultTimezoneOffset)`.
- New fused list operators on `Hl7.Cql.Operators.ICqlOperators`, each replacing a two-pass `Where`/`Select` composition with a single pass over the source (see *Operator fusion* under Improvements):
  - `bool? WhereAny<T>(IEnumerable<T>? source, Func<T, bool?> lambda)`
  - `IEnumerable<TR>? WhereSelect<T, TR>(IEnumerable<T>? source, Func<T, bool?> lambda, Func<T?, TR> select)`
  - `IEnumerable<TR>? SelectWhere<T, TR>(IEnumerable<T?>? source, Func<T?, TR> select, Func<TR, bool?> lambda)`
  - `IEnumerable<TR>? SelectDistinct<T, TR>(IEnumerable<T?>? source, Func<T?, TR> select)`

#### Improvements

- Added reusable bundle-backed data-source construction (`DataSourceForBundle`) so repeated evaluations can share one prebuilt index/coding cache over immutable bundle data. The index is read-only once built and supports any number of concurrent readers, but the source retains both the index and its coding caches for its entire lifetime — a host that caches sources should scope that cache to the subject or request rather than keeping a process-lifetime dictionary. (#1467)
- Age operators now resolve patient/birth-date lookup data once per evaluation context instead of per query element. (#1469, #1518)
- `TypeConverter` now resolves applicable conversion paths once rather than repeating converter selection per value. (#1471)
- `Avg`, `Median` and `GeometricMean` now walk their source exactly once; previously `Avg` walked its filtered query three times and `Median`/`GeometricMean` twice, re-running the producing query for a lazily evaluated source. (#1474)
- `Collapse` interval merge phase now runs linearly over sorted data rather than using repeated front-removals. (#1475)
- Bundle retrieves are materialized once per retrieve shape over bundle-backed sources, avoiding repeated re-evaluation of the same filter pipeline. (#1480)
- Resource-type enumeration for id-based FHIR comparer registration is now process-level lazy initialization instead of per-call reflection sweeps. (#1481)
- ISO8601 string formatting for date/time primitives moved to lazy computation, reducing construction-time allocations. (#1482)
- **Operator fusion**: where the generated C# previously built an intermediate list only to walk it once and discard it, the compiler now emits a single *fused* operator that does the work in one pass. Four immediately-consumed `Where`/`Select` chains are recognised: `Exists(Where(s, p))` becomes `WhereAny(s, p)`, `Select(Where(s, p), f)` becomes `WhereSelect(s, p, f)`, `Where(Select(s, f), p)` becomes `SelectWhere(s, f, p)`, and `Distinct(Select(s, f))` becomes `SelectDistinct(s, f)`. Each fused operator invokes the same lambdas over the same elements in the same relative order as the composition it replaces, so results, `Message` side effects and exception surfaces are unchanged — with one nuance: the fused form interleaves the two lambdas per element rather than running one to completion over the whole source before the other, so if *both* lambdas would throw, on different elements, the exception that surfaces can differ from the one the composition would have surfaced. (#1490)
- Value-set membership checks for resolved value sets now avoid terminology-service fallback round-trips, including code-only checks. (#1510)
- List `Intersect` now uses CQL equality semantics (same comparer path as `Except`/`Union`/`Distinct`) for value-equal non-reference-equal values. (#1553)
- `TypeConverter` instances are memoized per (model, default timezone offset) pair rather than per (model, cache size, offset); with the cache gone, two callers differing only in a matching model and offset now receive the same converter instance. (#1525)

#### Fixes

- `Median` returns the middle of the sorted, non-null values for an odd-count list, in all three overloads (`Decimal`, `Integer`, `Long`). It previously indexed the original source rather than the sorted, null-stripped values, so `Median({ 8, 2, 4 })` returned `2` instead of `4`, and `Median({ 8, null, 2, null, 4 })` returned `null`. (#1472, #1474)
- `Median` of an even number of `Integer` or `Long` values no longer overflows at the midpoint: `Median({ 2147483647, 2147483647 })` returned `-1` and now returns `2147483647`. (#1474)
- `GeometricMean` takes the root over the non-null count as the spec (§9.B) defines it, instead of counting nulls the product had skipped: `GeometricMean({ 2.0, null, 8.0, null })` returned `2.0` and now returns `4.0`. As a consequence an input whose only non-null value is negative (e.g. `{ -16.0, null }`) now returns that value where it previously threw `OverflowException`. (#1472, #1474)
- `GeometricMean` returns `null` when the result cannot be represented, instead of throwing `OverflowException` out of the operator — covering a negative product taken to a fractional root (`GeometricMean({ -2.0, 8.0 })`) and a product that overflows `Decimal`. Each such path writes a warning to the evaluation log. (#1474)
- `GeometricMean` of a list containing a genuine `0` returns `0`; the product loop treated a zero product as "not yet initialized", so `GeometricMean({ 0.0, 4.0, 9.0 })` returned `3.3019…`. (#1474)
- `IsCodeInValueSet(valueSetUri, code)` — the code-only overload, reached from CQL's `code in valueset` on a bare code — no longer throws `FhirOperationException: If 'code' is provided, either 'system' must be provided, or 'inferSystem' must be true` when a terminology service is attached; a resolved value set now answers it directly. (#1510)

#### Dependency Updates

- `FirelyNetVersion` remains `6.3.0` (`cql-base.props`, `Demo/cql-demo.props`) and matches Vonk `FhirNetApiVersion` (`Directory.Packages.props`) at release cut time.

#### Potentially Breaking

- FHIR conversion output now corrects previously invalid partial-precision time/dateTime output to valid FHIR lexical forms, including timezone handling. This includes zero-padding missing minute/second components, extension-based precision round-tripping, and timezone emission rules for time-bearing dateTimes. (#1458)
- Value-set membership now follows closed-world semantics when a value set is already resolved/expanded locally; unresolved misses are no longer automatically validated remotely. `ValueSetSource.Add` now rejects partial expansions. (#1510)
- Removed cache-size API surface:
  - `*REMOVED* Hl7.Cql.Fhir.FhirTypeConverter.Create(ModelInspector model, int? cacheSize = null)`
  - `*REMOVED* Hl7.Cql.Fhir.FhirCqlContextOptions.OverrideFhirTypeConverterCacheSize`
  - `*REMOVED* Hl7.Cql.CodeGeneration.NET.Toolkit.ElmToolkitConfig.LRUCacheSize` (including positional record constructor/deconstruct member shape)
  Migration: remove `cacheSize` and `LRUCacheSize` arguments/initializers. (#1525)
  A fourth overload, `FhirTypeConverter.Create(ModelInspector, int? cacheSize, TimeSpan? defaultTimezoneOffset)`, was both added (#1458) and removed (#1525) inside this release window and never appeared in a released version, so no 2.12.0 consumer can be affected by it; only code built against unreleased `develop` needs that change.
- `Distinct`, `Union`, and `Except` now hash consistently with CQL equality normalization for edge cases (normalized strings, truncated-decimal equality, boundary-equivalent intervals, and tuples containing such values), which can collapse previously separate groups. (#1532)
- `ICqlOperators` gained four abstract members — `WhereAny`, `WhereSelect`, `SelectWhere` and `SelectDistinct` (signatures under "New Public API" above). They have no default interface implementations, so any custom `ICqlOperators` implementation fails to compile until all four are implemented. (#1490)
- `ICqlOperators` precision parameters were normalized from `string` to `string?` on the remaining 16 interval/age members; custom implementations must update these signatures to match the interface contract. (#1555)
  - `Age(string? precision)`
  - `AgeAt(CqlDate? asOf, string? precision)`
  - `CalculateAge(CqlDate? birthDate, string? precision)`
  - `CalculateAge(CqlDateTime? birthDate, string? precision)`
  - `CalculateAgeAt(CqlDate? birthDate, CqlDate? asOf, string? precision)`
  - `CalculateAgeAt(CqlDateTime? birthDate, CqlDateTime? asOf, string? precision)`
  - `ElementProperlyIncludedInInterval(CqlDate left, CqlInterval<CqlDate>? right, string? precision)`
  - `ElementProperlyIncludedInInterval(CqlDateTime left, CqlInterval<CqlDateTime>? right, string? precision)`
  - `ElementProperlyIncludedInInterval(CqlTime left, CqlInterval<CqlTime>? right, string? precision)`
  - `IntervalIncludedIn<T>(CqlInterval<T>? smaller, CqlInterval<T>? larger, string? precision)`
  - `IntervalIncludesInterval<T>(CqlInterval<T>? larger, CqlInterval<T>? smaller, string? precision)`
  - `IntervalProperlyIncludedInInterval<T>(CqlInterval<T>? left, CqlInterval<T>? right, string? precision)`
  - `IntervalProperlyIncludesElement(CqlInterval<CqlDate>? left, CqlDate right, string? precision)`
  - `IntervalProperlyIncludesElement(CqlInterval<CqlDateTime>? left, CqlDateTime right, string? precision)`
  - `IntervalProperlyIncludesElement(CqlInterval<CqlTime>? left, CqlTime right, string? precision)`
  - `IntervalProperlyIncludesInterval<T>(CqlInterval<T>? left, CqlInterval<T>? right, string? precision)`
- Generated-code contract moved from `5.1.7.0` (as shipped in 2.12.0) to `5.2.1.0` (final value in `LibrarySetCSharpCodeGenerator.GeneratorToolVersion`; `5.2.0.0` was an interim value inside this release window). Generated code from this version has a hard dependency on a runtime providing the four new `ICqlOperators` members, so pairing it with an older `Hl7.Cql.Runtime` is not supported: such libraries fall outside the older invocation toolkit's supported generator range and are **skipped at load with a warning** rather than half-working. Consumers who check in generated C#, or ship packaged FHIR `Library` resources with embedded C#/assemblies, should regenerate and upgrade runtime and generated content together. `LibraryInstanceInvoker_5_0` covers the new value via `MinSupportedGeneratorToolVersion = 5.1.0.0` and `FirstUnsupportedGeneratorToolVersion = 5.3.0.0`. (#1490, #1555)

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
   - `FhirCqlContextOptions.OverrideFhirTypeConverterCacheSize` -> remove
   - `ElmToolkitConfig.LRUCacheSize` argument/initializer -> remove
3. If you implement `ICqlOperators`, update the 16 affected method signatures to `string? precision`, and implement the four new fused list operators (`WhereAny`, `WhereSelect`, `SelectWhere`, `SelectDistinct`).
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
