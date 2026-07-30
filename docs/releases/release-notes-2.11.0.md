## Firely CQL SDK 2.11.0

### tl;dr

> **Upgrading?** Here is the short version:
>
> - **Breaking changes:** Generated C# shape changed (`GeneratorToolVersion` `5.1.2.0` → `5.1.7.0`), and FHIR serialization for `Interval<Integer|Decimal|Long>` mapped to `Range` changed per FHIR-56226.
> - **Required migrations:** Regenerate checked-in generated C# libraries, and update any tests/consumers that assert exact `Range` endpoint/precision output for interval results.
> - **Highlights:** Quantity semantics now align much more closely with CQL §9.B (unit conversion in `~`, null semantics for invalid/incommensurable operations, and hash/equality consistency).

---

### CQL SDK

#### New Public API

- `Hl7.Cql.Fhir.FhirCqlContextOptions.MetricService`
- `Hl7.Cql.Fhir.FhirTypeConverter.ConvertCqlCodeToFhir(this TypeConverter, CqlCode?)`
- `Hl7.Cql.Fhir.FhirTypeConverter.ConvertPeriodToCqlInterval(this TypeConverter, Period?, string?)`
- `Hl7.Cql.Fhir.FhirCqlContextOptions.OverrideRetrieveProfileFilter`
- `Hl7.Cql.Fhir.IRetrieveProfileFilter` and `Hl7.Cql.Fhir.IRetrieveProfileFilter.GetFilter(string)`
- `Hl7.Cql.Fhir.QICoreRetrieveProfileFilter` and `Hl7.Cql.Fhir.QICoreRetrieveProfileFilter.Default`
- `Hl7.Cql.Packaging.Toolkit.PackagingToolkitConfig.MeasureGroupCodeSystem`
- `Hl7.Cql.Runtime.CqlLibraryVersion.CompareTo(Hl7.Cql.Runtime.CqlLibraryVersion)`

#### Improvements

- `Hl7.Cql.Fhir.FhirCqlContextOptions` now accepts an injected UCUM `IMetricService` through `MetricService`, and cross-unit quantity `Add`/`Subtract` now work via the default service while returning the most granular input unit per CQL §9.B (#1282).
- Quantity arithmetic now follows CQL §9.B null semantics for invalid/incompatible UCUM operations (returns `null` instead of throwing), quantity `Multiply` by scalar `'1'` preserves the non-`'1'` unit, `Between` returns `null` for incompatible dimensions, `CanConvertQuantity` now correctly checks convertibility, and `Modulo`/`TruncatedDivide` align with the updated UCUM conversion paths (#1282).
- Host-side FHIR conversion coverage expanded in `Hl7.Cql.Fhir.FhirTypeConverter`: `CqlInterval<CqlTime> -> Period`, `CqlCode -> Code`, `Code -> CqlCode`, `Coding -> CqlCode`, `long -> FhirString`, and point-type-aware `Period -> CqlInterval<...>` conversion (#1408).
- ISO 8601 offset handling was fixed for `TimeIso8601`/`DateTimeIso8601`: signed offsets are now interpreted/rendered correctly (including `-00:30` and `+00:30` cases) (#1408).
- `Expand` now applies spec truncation consistently across list and single-interval forms and no longer emits trailing overshoot intervals that end past the upper boundary (#1413).
- `Expand` no longer hangs for non-advancing `per` values and no longer truncates fractional `per` in `Integer`/`Long` overloads into invalid behavior (#1412).
- Upgraded upstream Java `org.cqframework` `cql-to-elm-cli`/`elm-fhir` tooling from `4.0.0` to `5.0.0`; only `4.6.0` introduced observable ELM-shape changes (interval-literal constant-folding and choice-type alphabetical sorting) (#1334).
- Multi-branch conditionals (`if`/`case ... when`) now emit native C# `if`/`else` instead of invoked local functions, redundant `object` casts are removed, duplicate pure subexpressions within a definition are computed once, and generated local-variable naming is contiguous.
- Tuple-list `union` with structurally compatible but differently-typed tuple elements no longer collapses to empty due to value-type covariance/casting issues (`IEnumerable<object>` path removed) (#1354).
- `Interval` construction with choice-typed operands no longer fails with runtime `InvalidCastException`; generated code/binding now anchors point type using the compatible operand/type alternative (#1350).
- Instance selectors now report a normal translation error when an element value cannot be coerced to the declared element type, instead of throwing `NotImplementedException` (#1416).
- `Union<T>(CqlInterval<T>?, CqlInterval<T>?)` now merges meeting intervals and no longer drops the later-ending tail when the right operand starts first (#1359).
- `OverlapsAfter` now handles null boundaries like `OverlapsBefore` (null low = minimum, null high = maximum), fixing false negatives with unbounded intervals (#1356).
- `with`/`without` relationship clauses compile as semi-join/anti-semi-join existence filters instead of `SelectMany`/`Except`, preventing duplicate or set-semantics-distorted results (#1366).
- `Hasher` now uses thread-safe one-shot `MD5.HashData` instead of a shared static `MD5` instance (#1372).
- `IndexedBundle.FilterByType<T>` no longer yields duplicate resources when multiple codings match (#1365).
- Quantity hashing now uses canonicalized UCUM form plus scale-normalized numeric value, so hash-based list operators (`distinct`, `union`, `except`) correctly deduplicate values equivalent by conversion/scale (#1418).
- `VersionedIdentifier.GetHashCode()` is now consistent with `Equals()`, with case-sensitive `id` and exact opaque `version` matching per the CQL specification, preventing hash-set/library-dependency mismatches (#1375).

#### Dependency Updates

- `Fhir.Metrics` was bumped from `1.3.0` to `1.4.0` (including adding an explicit reference in `Cql.Firely`) (#1282).
- `FirelyNetVersion` remains `6.3.0` (confirmed aligned with Vonk `Directory.Packages.props` `FhirNetApiVersion=6.3.0`).

#### Potentially Breaking

- Generated C# changed shape and `GeneratorToolVersion` advanced from `5.1.2.0` to `5.1.7.0`; consumers with checked-in generated C# should regenerate.
- `Interval<Integer>` / `Interval<Decimal>` serialization to FHIR `Range` now always emits `quantity-precision` extension on bounds and converts open bounds to their closed equivalents at engine minimum precision; `Interval<Long>` now serializes as unit-less (`UCUM '1'`) `Range` (#1402).
- Quantity equality/order comparisons (`=`, `<`, `>`, `<=`, `>=`, `between`) now return `null` for incompatible dimensions/invalid units instead of treating canonicalized values as directly comparable (e.g. `1 'cm'` vs `0.01 'g'`) (#1417).
- Quantity equivalence (`~`) now performs UCUM conversion and never returns `null`; incommensurable units evaluate `false` (#1415, #1417).
- List equality now propagates unknowns from element-level quantity comparisons (e.g. `{1 'cm'} = {0.01 'g'}` is now `null`), and `Date`/`DateTime`/`Time` equivalence with differing precisions now follows spec false semantics instead of reporting true (#1417).
- `Expand` with non-advancing `per` quantities now returns `null` (`per <= 0`), and fractional `per` for `Integer`/`Long` interval expansion now throws `NotSupportedException` instead of truncating and potentially hanging (#1412).

---

### CQL Packager

#### Breaking

- None.

#### Improvements

- New packager configuration/property `PackagingToolkitConfig.MeasureGroupCodeSystem` (CLI `--measure-group-code-system`, appsettings `Packaging:MeasureGroupCodeSystem`) emits `Measure.group.code` using each group id as coding code and validates group ids against FHIR `code` constraints (#1431).

---

### Demo Projects and Build Tooling

#### Breaking

- None.

#### Improvements

- Added `docs/releases/vnext/` per-PR release-note fragments workflow to avoid merge conflicts on the shared vnext file (#1433, #1435).
- Added Integration Runner benchmark workflow documentation/skill (`run-integration-benchmarks`) (#1429).
- Added/updated runtime services dependency documentation and rendered diagrams (`docs/dependency-diagrams.md`, including `RuntimeServices` diagram) (#1400, #1437).

---

### Upgrade Checklist

1. Regenerate any checked-in generated C# libraries to match `GeneratorToolVersion` `5.1.7.0`.
2. Update assertions/consumers that compare exact serialized FHIR `Range` bounds for interval results.
3. Review quantity logic that depended on previous dimension-blind comparison/equality behavior.
4. If using packager measure grouping codings, set `PackagingToolkitConfig.MeasureGroupCodeSystem` (or CLI/appsettings equivalent) and ensure `@group` values satisfy FHIR `code` constraints.

---

### Pull Requests

| PR | Title |
| --- | --- |
| [#1282](https://github.com/FirelyTeam/firely-cql-sdk/pull/1282) | Inject IMetricService into CQL runtime for UCUM unit arithmetic |
| [#1357](https://github.com/FirelyTeam/firely-cql-sdk/pull/1357) | Fix inverted null boundary handling in OverlapsAfter |
| [#1360](https://github.com/FirelyTeam/firely-cql-sdk/pull/1360) | Fix interval Union meets handling and tail drop |
| [#1390](https://github.com/FirelyTeam/firely-cql-sdk/pull/1390) | Restructure spec/ by technology and add FHIR page fetch tool |
| [#1391](https://github.com/FirelyTeam/firely-cql-sdk/pull/1391) | Add DQIC test suite comparator tool |
| [#1395](https://github.com/FirelyTeam/firely-cql-sdk/pull/1395) | feat!: replace System.Linq.Expressions with a typed IR in the ELM-to-C# pipeline |
| [#1396](https://github.com/FirelyTeam/firely-cql-sdk/pull/1396) | Rename types *Expression* to *Code* eg. `ExpressionBuilder` to `CodeBuilder` |
| [#1398](https://github.com/FirelyTeam/firely-cql-sdk/pull/1398) | fix: the two upstream binder/builder bugs preserved bug-for-bug through the migration |
| [#1400](https://github.com/FirelyTeam/firely-cql-sdk/pull/1400) | Fix dependency-diagrams.md drift and non-rendering Mermaid diagrams |
| [#1401](https://github.com/FirelyTeam/firely-cql-sdk/pull/1401) | feat!: drop the three ledgered old-writer quirks from the generated C# |
| [#1404](https://github.com/FirelyTeam/firely-cql-sdk/pull/1404) | feat!: emit native if/else statements for multi-branch conditionals |
| [#1405](https://github.com/FirelyTeam/firely-cql-sdk/pull/1405) | Anchor interval point types when ELM types the points as a choice (port of #1351) |
| [#1408](https://github.com/FirelyTeam/firely-cql-sdk/pull/1408) | feat: add host-side CQL↔FHIR conversions to FhirTypeConverter |
| [#1409](https://github.com/FirelyTeam/firely-cql-sdk/pull/1409) | Map Interval<Integer|Decimal|Long> to FHIR Range per FHIR-56226 |
| [#1411](https://github.com/FirelyTeam/firely-cql-sdk/pull/1411) | test: remove 14 stale XML-suite skip entries and correct outdated skip reasons |
| [#1414](https://github.com/FirelyTeam/firely-cql-sdk/pull/1414) | Fix Expand infinite loop on non-advancing per quantities |
| [#1419](https://github.com/FirelyTeam/firely-cql-sdk/pull/1419) | Fix quantity Equivalent to canonicalize UCUM units |
| [#1420](https://github.com/FirelyTeam/firely-cql-sdk/pull/1420) | Report translation error for uncoercible instance elements |
| [#1421](https://github.com/FirelyTeam/firely-cql-sdk/pull/1421) | Fix Expand overshoot and apply truncation rule consistently |
| [#1423](https://github.com/FirelyTeam/firely-cql-sdk/pull/1423) | Fix quantity hash code to agree with unit-converted equality |
| [#1425](https://github.com/FirelyTeam/firely-cql-sdk/pull/1425) | Fix dimension-blind quantity comparison |
| [#1429](https://github.com/FirelyTeam/firely-cql-sdk/pull/1429) | docs: add skill for running Integration Runner benchmarks and comparing against baseline |
| [#1430](https://github.com/FirelyTeam/firely-cql-sdk/pull/1430) | Upgrade Java cql-to-elm-cli/elm-fhir tooling: 4.0.0 -> 5.0.0 |
| [#1431](https://github.com/FirelyTeam/firely-cql-sdk/pull/1431) | Add MeasureGroupCodeSystem option to emit Measure.group.code |
| [#1433](https://github.com/FirelyTeam/firely-cql-sdk/pull/1433) | Introduce docs/releases/vnext/ fragment files to avoid release-notes conflicts |
| [#1435](https://github.com/FirelyTeam/firely-cql-sdk/pull/1435) | Use PR number for vnext release-note fragment filenames |
| [#1437](https://github.com/FirelyTeam/firely-cql-sdk/pull/1437) | docs: add runtime-services dependency diagram |
