## Firely CQL SDK 2.7.0

### tl;dr

> **Upgrading?** Here is the short version:
>
> - **Breaking changes:** `ICqlOperators.Contains<T>` list parameter is now nullable; `ICqlOperators.Power(int?, int?)` and `Power(long?, long?)` now return `decimal?`; `PackagingToolkit.SerializeFhirResourcesToJson`, `PackagingToolkitExtensions.SaveFhirResourcesToDirectory`, `InvocationToolkitExtensions.AddAssemblyBinariesInFhirLibrariesFromDirectory`, and `InvocationToolkitExtensions.AddAssemblyBinariesFromFhirLibraryAndDependencies` no longer accept a `configureJsonSerializerOptions` parameter.
> - **Required migrations:** Remove any `configureJsonSerializerOptions` argument passed to the affected methods above; update call sites that expect `int?` or `long?` from `Power` overloads to accept `decimal?`.
> - **Highlights:** Significant CQL spec conformance improvement wave — dozens of runtime, ELM compiler, and type-mapping fixes driven by the 2026 conformance re-verification.

---

### CQL SDK

#### New Public API

- `ICqlOperators.Contains<T>(IEnumerable<T?>? list, T? item)` — list parameter and item are now nullable (previously `IEnumerable<T>! list, T item`).
- `ICqlOperators.In<T>(T? element, IEnumerable<T?>? argument)` — argument is now nullable (previously `IEnumerable<T>!`).
- `ICqlOperators.In<T>(T? t, CqlInterval<T>? interval, string? precision)` — element is now nullable.
- `ICqlOperators.Power(int? argument, int? exponent) -> decimal?` — return type changed from `int?`.
- `ICqlOperators.Power(long? argument, long? exponent) -> decimal?` — return type changed from `long?`.

#### Improvements

- **CQL spec conformance** — wide-ranging fixes aligned to CQL 1.5.3 spec from a full 2026 conformance re-verification pass:
  - `Power` for `Integer`/`Long` operands now correctly returns `Decimal` per spec and handles decimal representability overflow.
  - `Substring` length calculation bug fixed; edge-case with negative or out-of-bounds indices corrected.
  - `EndsWith` with empty suffix and boundary conditions now spec-conformant.
  - `Split` now uses full string-token separator semantics instead of character splitting.
  - `Round` negative midpoint behavior corrected to match spec expectations.
  - `Expand` precision alignment: per-hour / per-1 expand now matches spec semantics.
  - `SameOrAfter`, `SameOrBefore`, and `SameAs` for `DateTime` point operands without explicit precision fixed.
  - List equality for mismatched element types and lists containing null elements now uses correct three-valued AND logic.
  - Tuple equality with null elements fixed to propagate null per spec three-valued logic.
  - `In<T>` (list membership) null-element semantics fixed: `null in {1, null}` → `true`, `null in {1, 2}` → `false`, `5 in null` → `false`; previously a null element always yielded `null` in violation of the spec.
  - `Coalesce` code generation: fixed invalid C# `??` emission when all operands are null lists.
  - `FunctionRef` in CQL-to-ELM now correctly populates the `libraryName` field.
  - `without` relationship clause in CQL query expressions no longer throws `NullReferenceException`.
  - Date/`DateTime` coercion and `ChoiceTypeSpecifier` handling corrected in `CoercionProvider`.
  - Multi-source query typing and alias validation fixed.
  - `CqlDate` addition (Date + Quantity) runtime/translator behavior aligned.
  - Long literal comparison code generation fixed (`0L > 10L` was incorrectly returning `null`).
- **FHIR type mapping**:
  - `Interval<Time>` now correctly maps to FHIR `Period` with `DateTime` elements.
  - Runtime `long` mapped to FHIR `string` carrying CQL `Long` metadata; `TypeCode.Int64` added to the FHIR string mapper.
  - `CqlTime` string conversion now strips timezone offset to match spec semantics.
- **`Microsoft.CodeAnalysis.CSharp`** updated from `4.12.0` to `5.3.0` (used by `Cql.CodeGeneration.NET` and `Cql.Elm`).
- **`FirelyNetVersion`** bumped from `6.1.0` to `6.1.1`.

#### Dependency Updates

- `FirelyNetVersion`: `6.1.0` → `6.1.1` — affects all packages that consume Firely .NET SDK types.
- `Microsoft.CodeAnalysis.CSharp`: `4.12.0` → `5.3.0` (in `Hl7.Cql.CodeGeneration.NET` and `Hl7.Cql.Elm`).

#### Potentially Breaking

- **`ICqlOperators.Contains<T>` signature change** — The list overload now accepts a nullable list and nullable item. Implementations of `ICqlOperators` must update their method signature:

  ```csharp
  // Before
  bool? Contains<T>(IEnumerable<T> list, T item);
  // After
  bool? Contains<T>(IEnumerable<T?>? list, T? item);
  ```

- **`ICqlOperators.Power(int?, int?)` and `Power(long?, long?)` return `decimal?`** — Call sites that stored or compared the result as `int?` or `long?` must be updated:

  ```csharp
  // Before
  int? result = operators.Power(2, 10);
  // After
  decimal? result = operators.Power(2, 10);
  ```

---

### CQL Packager

#### Breaking

- **`PackagingToolkit.SerializeFhirResourcesToJson`** — `configureJsonSerializerOptions` parameter removed. Serialization now uses `BaseFhirJsonSerializer` directly.

  ```csharp
  // Before
  toolkit.SerializeFhirResourcesToJson(resources, writeIndented: true, opts => opts.WriteIndented = true);
  // After
  toolkit.SerializeFhirResourcesToJson(resources, writeIndented: true);
  ```

- **`PackagingToolkitExtensions.SaveFhirResourcesToDirectory`** — `configureJsonSerializerOptions` parameter removed from both the method overload and the `SaveFhirResourcesToDirectoriesOptions` record.

- **`InvocationToolkitExtensions.AddAssemblyBinariesInFhirLibrariesFromDirectory`** — `configureJsonSerializerOptions` parameter removed.

  ```csharp
  // Before
  toolkit.AddAssemblyBinariesInFhirLibrariesFromDirectory(dir, filePredicate: pred, configureJsonSerializerOptions: opts => { });
  // After
  toolkit.AddAssemblyBinariesInFhirLibrariesFromDirectory(dir, filePredicate: pred);
  ```

- **`InvocationToolkitExtensions.AddAssemblyBinariesFromFhirLibraryAndDependencies`** — `configureJsonSerializerOptions` parameter removed.

  ```csharp
  // Before
  toolkit.AddAssemblyBinariesFromFhirLibraryAndDependencies(id, resolver, filePredicate: pred, configureJsonSerializerOptions: opts => { });
  // After
  toolkit.AddAssemblyBinariesFromFhirLibraryAndDependencies(id, resolver, filePredicate: pred);
  ```

#### Improvements

- **FHIR Library deserialization now tolerates non-conformant resource ids and canonical URLs** — `Cql.Packaging`, `Cql.Invocation`, and PackagerCLI now deserialize via `BaseFhirJsonDeserializer` with `DeserializationMode.NoOverflow`. This resolves load failures for real-world HEDIS and other measure-set bundles with non-standard ids (e.g. underscore ids such as `Library-BCSE_Concepts-2025.1.0`). Non-fatal issues surface as logger warnings.
- **PackagerCLI startup banner** — The help/usage description now includes app name, build configuration (omitted for Release builds), version, and .NET runtime version. The command execution banner adds OS and architecture information and formats command-line arguments for readability (named arguments aligned in columns, one per line).
- Info-level log lines in ANSI mode now use a blank space instead of an info emoji for cleaner output.

---

### Demo Projects and Build Tooling

#### Improvements

- CI skip-stage logic replaced with a shared pipeline template (DEVOPS-706) — reduces per-job boilerplate in the build pipeline.
- External Firely documentation site links removed from repository docs; all cross-document references are now relative Markdown hyperlinks within the repo.
- `tl;dr` section added to the release notes template as a required summary header for all future releases.

---

### Upgrade Checklist

1. Remove the `configureJsonSerializerOptions` argument from all calls to `SerializeFhirResourcesToJson`, `SaveFhirResourcesToDirectory`, `AddAssemblyBinariesInFhirLibrariesFromDirectory`, and `AddAssemblyBinariesFromFhirLibraryAndDependencies`.
2. Update any `ICqlOperators` implementation that overrides `Contains<T>` to use the new nullable signature.
3. Update call sites that capture the return value of `Power(int?, int?)` or `Power(long?, long?)` to expect `decimal?`.
4. Update your NuGet references to use `FirelyNetVersion` `6.1.1` if you have a direct dependency on the Firely .NET SDK.

---

### Pull Requests

| PR | Title |
| --- | --- |
| [#1277](https://github.com/FirelyTeam/firely-cql-sdk/pull/1277) | Fix long literal code generation: 0L > 10L returns null instead of false |
| [#1276](https://github.com/FirelyTeam/firely-cql-sdk/pull/1276) | Align Date+Quantity runtime/translator behavior |
| [#1275](https://github.com/FirelyTeam/firely-cql-sdk/pull/1275) | Fix list `In` null-membership semantics |
| [#1273](https://github.com/FirelyTeam/firely-cql-sdk/pull/1273) | Fix multi-source query typing and alias validation |
| [#1271](https://github.com/FirelyTeam/firely-cql-sdk/pull/1271) | Align Expand precision with CQL spec |
| [#1270](https://github.com/FirelyTeam/firely-cql-sdk/pull/1270) | Fix Split to use string-token separators |
| [#1269](https://github.com/FirelyTeam/firely-cql-sdk/pull/1269) | Align Round negative midpoint test expectations |
| [#1268](https://github.com/FirelyTeam/firely-cql-sdk/pull/1268) | Fix EndsWith edge-case spec conformance |
| [#1266](https://github.com/FirelyTeam/firely-cql-sdk/pull/1266) | Fix Power decimal representability regression |
| [#1265](https://github.com/FirelyTeam/firely-cql-sdk/pull/1265) | Spec report refresh for 2026 conformance re-verification |
| [#1264](https://github.com/FirelyTeam/firely-cql-sdk/pull/1264) | Spec conformance report refresh and new issue docs |
| [#1261](https://github.com/FirelyTeam/firely-cql-sdk/pull/1261) | Map runtime long to FHIR string as CQL Long |
| [#1260](https://github.com/FirelyTeam/firely-cql-sdk/pull/1260) | Fix tuple equality with null elements |
| [#1257](https://github.com/FirelyTeam/firely-cql-sdk/pull/1257) | Fix list null equality and contains semantics |
| [#1256](https://github.com/FirelyTeam/firely-cql-sdk/pull/1256) | Fix Substring length calculation bug |
| [#1255](https://github.com/FirelyTeam/firely-cql-sdk/pull/1255) | Align Power decimal return and null handling |
| [#1254](https://github.com/FirelyTeam/firely-cql-sdk/pull/1254) | Strip timezone from CqlTime string conversion |
| [#1253](https://github.com/FirelyTeam/firely-cql-sdk/pull/1253) | Fix CQL-to-ELM coercion: Date/DateTime and ChoiceType |
| [#1251](https://github.com/FirelyTeam/firely-cql-sdk/pull/1251) | Fix Coalesce with null list operands |
| [#1250](https://github.com/FirelyTeam/firely-cql-sdk/pull/1250) | Map Interval\<Time\> to FHIR Period |
| [#1249](https://github.com/FirelyTeam/firely-cql-sdk/pull/1249) | Handle list equality mismatches safely |
| [#1248](https://github.com/FirelyTeam/firely-cql-sdk/pull/1248) | Fix SameOrAfter/SameOrBefore/SameAs for DateTime point operands without precision |
| [#1245](https://github.com/FirelyTeam/firely-cql-sdk/pull/1245) | Fix FunctionRef missing libraryName in CQL-to-ELM |
| [#1243](https://github.com/FirelyTeam/firely-cql-sdk/pull/1243) | Bump Microsoft.CodeAnalysis to 5.3.0 |
| [#1242](https://github.com/FirelyTeam/firely-cql-sdk/pull/1242) | Fix without clause NullReferenceException in CQL queries |
| [#1240](https://github.com/FirelyTeam/firely-cql-sdk/pull/1240) | Ignore literal validation on FHIR library deserialization |
| [#1239](https://github.com/FirelyTeam/firely-cql-sdk/pull/1239) | Output .NET runtime version in PackagerCLI banner |
| [#1237](https://github.com/FirelyTeam/firely-cql-sdk/pull/1237) | Hide info icon in ANSI console output |
| [#1246](https://github.com/FirelyTeam/firely-cql-sdk/pull/1246) | Replace inline skip-stage with shared template (DEVOPS-706) |
| [#1233](https://github.com/FirelyTeam/firely-cql-sdk/pull/1233) | Add tl;dr section to release notes template |
| [#1232](https://github.com/FirelyTeam/firely-cql-sdk/pull/1232) | Remove Firely docs links from repo docs |
