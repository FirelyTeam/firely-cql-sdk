## Firely CQL SDK 2.10.0

### tl;dr

> **Upgrading?** Here is the short version:
>
> - **Breaking changes:** `VersionedIdentifier` (and `VersionedIdentifierDictionary`'s `include` resolution) now compares library `id` case-sensitively and matches `version` as an exact opaque string, instead of case-insensitive/normalized comparison.
> - **Required migrations:** Review any code or data relying on case-insensitive library id lookups (e.g. `"FoO"` vs `"fOo"`) or normalized version-string equivalence (e.g. `"1.0"` treated the same as `"1.0.0"`) — these are now treated as distinct identifiers.
> - **Highlights:** The packager now maps `@stratifier` ELM annotations onto `Measure.group.stratifier`. Also fixed several correctness bugs: duplicate `Retrieve` results, intermittently dropped cross-library references during compilation, `with`/`without` relationship-clause duplication, `Equivalent` on `FHIR.CodeableConcept` ~ `Code`, and late-bound FHIR primitive property access.

---

### CQL SDK

#### New Public API

- None.

#### Improvements

- `Hasher` no longer shares a single static `MD5` instance across threads, fixing intermittent `CryptographicException: Concurrent operations from multiple threads on this type are not supported` when tuple metadata signature hashes were computed concurrently (e.g. during parallel measure evaluation). It now uses the thread-safe one-shot `MD5.HashData` API (#1372).
- `IndexedBundle.FilterByType<T>` (used by `Retrieve`) no longer yields a candidate resource more than once when several of its codings match the filter, preventing inflated `Retrieve` results / population counts for resources with multiple matching codings (#1365).
- CQL `with`/`without` relationship clauses now compile as an existence filter (semi-join/anti-semi-join) instead of `SelectMany`/`Except`, so a source element with multiple matching related elements is emitted exactly once instead of duplicated (or spuriously deduplicated by `Except` set semantics for `without`) (#1366).
- `AssemblyCompiler.CompileEachLibraryToAssemblies` now compiles each library's dependencies first via explicit recursion with memoization, instead of relying on `librariesWithCSharp`'s enumeration order to already guarantee dependencies are compiled first. That assumption didn't reliably hold for large, densely-interconnected library sets (surfaced by the 382-library HEDIS 2025 corpus), causing cross-library references to be intermittently and silently dropped, later surfacing as a confusing Roslyn `CS0103` on an unrelated library (#1373, #1374).
- `Equivalent` between `FHIR.CodeableConcept` and `Cql.Code` is now correctly converted to ELM, fixing equivalence checks that previously failed to compile or evaluate correctly (#788).
- Late-bound property access (e.g. `FhirDateTime.value` reached through a choice/union type) now correctly converts to the target CQL type instead of silently returning null, fixing timing checks and other operations on elements reached through choice or union types.
- `VersionedIdentifier.GetHashCode()` is now consistent with `Equals()`, and both now conform to the CQL specification: `id` comparison is case-sensitive (CQL is a case-sensitive language per §3.4.1 of the Developer's Guide) and `version` is matched as an exact opaque string (per §3.2 of the Developer's Guide and §2.1.5 of the Logical Specification), preventing missed matches/duplicate entries in hash-based dependency sets (#1375).

#### Dependency Updates

- None.

#### Potentially Breaking

- `VersionedIdentifier` equality and ordering semantics changed to be spec-conformant. Library `id` comparison is now **case-sensitive** (CQL is a case-sensitive language) and `version` is now matched as an **exact opaque string** rather than being normalized. This means `VersionedIdentifier` instances that previously compared equal may now compare unequal — for example, ids differing only by case (`"FoO"` vs `"fOo"`) or versions in different but formerly-equivalent formats (`"1.0"` vs `"1.0.0"`) are now considered distinct. This affects all identity checks built on `VersionedIdentifier` comparison, including library dependency graphs and per-library dependency sets in `LibrarySet` (#1376).
- `VersionedIdentifierDictionary` (backing `MemoryLibraryProvider`'s `include` resolution on the active `TryResolveLibrary` path) now resolves library identifiers using the same spec-conformant semantics: `id` lookup is **case-sensitive** (was `OrdinalIgnoreCase`) and `version` must match **exactly** (was numeric-segment normalization that silently equated `"1.0"` with `"1.0.0"`). Code that previously resolved an `include` by a differently-cased id or by a semantically-but-not-textually-equal version specifier will no longer find a match (#1376).

---

### CQL Packager

#### Breaking

- None.

#### Improvements

- The packager now maps `@stratifier` ELM annotations onto `Measure.group.stratifier`, instead of silently ignoring them. All stratifier-tagged definitions of a group collapse into a single container stratifier (`<group>-Stratifier`) with one `component` per `(group, stratifier)` tag pair, each with a text-only code from the tag value, an optional `@description`, and a `text/cql-identifier` criteria referencing the CQL definition. Empty `@stratifier` values, `@stratifier` without a `@group` tag, and duplicate component codes within a group now throw with clear messages instead of producing malformed output. See [docs/cql-packager.md](../cql-packager.md#measure-annotations) (#1358).

---

### Demo Projects and Build Tooling

#### Breaking

- None.

#### Improvements

- Vendored the NCQA HEDIS 2025 golden-parity test corpus (382 libraries) into the Integration Runner and wired `Hedis2025.GoldenTests` into CI, giving much larger and more densely-interconnected coverage than the existing golden corpora (RR23, dqm-content-qicore-2025) — this is what surfaced the `AssemblyCompiler` fix above (#1371).
- The Java/Maven dependency download in `Demo/Cql/Build/CqlTooling.Targets.xml` is now properly gated on `CqlToolingEnabled` (matching its only consumer), instead of running unconditionally on every CI build. Previously, rapid repeated CI builds could hit a download-lock timeout that silently hung the entire build for the full 60-minute job timeout (#1377).

---

### Upgrade Checklist

1. If your code or persisted data compares `VersionedIdentifier`/library identifiers by id or version in a case-insensitive or normalized way, review it against the new case-sensitive, exact-string semantics — matches you relied on that differed only by case or version-string formatting will no longer be found.
2. No other action required — the remaining fixes are backward-compatible bug fixes.

---

### Pull Requests

| PR | Title |
| --- | --- |
| [#1283](https://github.com/FirelyTeam/firely-cql-sdk/pull/1283) | Fix tuple-to-tuple implicit conversion compatibility check |
| [#1347](https://github.com/FirelyTeam/firely-cql-sdk/pull/1347) | Fix late-bound property access for FHIR primitive values |
| [#1358](https://github.com/FirelyTeam/firely-cql-sdk/pull/1358) | Add stratifier support to generated FHIR Measures |
| [#1367](https://github.com/FirelyTeam/firely-cql-sdk/pull/1367) | Compile 'with'/'without' clauses as semi-joins |
| [#1368](https://github.com/FirelyTeam/firely-cql-sdk/pull/1368) | Fix duplicate Retrieve results when multiple codings match |
| [#1371](https://github.com/FirelyTeam/firely-cql-sdk/pull/1371) | Vendor the HEDIS 2025 golden-parity corpus into Integration Runner |
| [#1372](https://github.com/FirelyTeam/firely-cql-sdk/pull/1372) | Make Hasher thread-safe using one-shot MD5.HashData |
| [#1374](https://github.com/FirelyTeam/firely-cql-sdk/pull/1374) | Fix AssemblyCompiler intermittently dropping cross-library references |
| [#1376](https://github.com/FirelyTeam/firely-cql-sdk/pull/1376) | Align VersionedIdentifier hash semantics (breaking change, low risk) |
| [#1388](https://github.com/FirelyTeam/firely-cql-sdk/pull/1388) | Prepare 2.10.0 release (fixes #1387) |
