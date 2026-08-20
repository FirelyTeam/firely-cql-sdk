# 11. Versioning

Parent document: [../copilot-instructions.md](../copilot-instructions.md)

## 11.0. Table of Contents

- [11. Versioning](#11-versioning)
- [11.0. Table of Contents](#110-table-of-contents)
- [11.1. Scheme](#111-scheme)
- [11.2. Deciding the Level](#112-deciding-the-level)
- [11.3. Two Independent Scales](#113-two-independent-scales)
- [11.4. Pre-release Versions](#114-pre-release-versions)

## 11.1. Scheme

11.1.1 The SDK package version uses **EffVer** (Intended Effort Versioning), **not** Semantic Versioning: `MACRO.MESO.MICRO`. Each digit states how much effort adoption costs a consumer, not what category the change belongs to. [docs/versioning.md](../../docs/versioning.md) is canonical.

11.1.2 The digits:

11.1.2.1 **MACRO** — you will need to dedicate significant time to upgrading

11.1.2.2 **MESO** — some small effort may be required to make sure this version works for you

11.1.2.3 **MICRO** — this change doesn't intend for you to need to do anything

11.1.3 Effort is judged against the **typical** consumer — someone who packages CQL and invokes it through the SDK. Where a change is cheap for them but expensive for a narrower audience (custom `ICqlOperators` implementers, for example), call that audience out in the release notes rather than raising the digit for everyone.

## 11.2. Deciding the Level

11.2.1 Any one of these forces **MESO**:

11.2.1.1 A `docs/releases/vnext/` fragment declaring `## Breaking` or `## Potentially Breaking`

11.2.1.2 `LibrarySetCSharpCodeGenerator.GeneratorToolVersion` changed — consumers who check in generated `*.g.cs`, or who ship packaged FHIR `Library` resources with embedded C#, must regenerate

11.2.1.3 Public API removed, or an existing signature changed

11.2.1.4 Public API newly marked `[Obsolete]` — nothing breaks, but a consumer building with warnings-as-errors has work to do

11.2.1.5 CQL evaluation results change, **including bug fixes that correct previously wrong answers** — a measure whose output moves is a migration even when the old output was a defect

11.2.1.6 A dependency bump crossing that dependency's own major version

11.2.2 Everything else is **MICRO**, including **new public API additions** — adding surface is backward-compatible and costs an existing consumer nothing.

11.2.3 **MACRO** is reserved for a release whose migration is substantial for a typical consumer: a re-architecture, removal of a whole surface area, or several MESO-level migrations landing together. It is a deliberate, recorded decision, not an automatic consequence of any single change.

11.2.4 These never affect the version: repository-maintenance scripts, contributor-facing documentation, CI configuration, the private integration-runner submodule, `.claude/` and `.github/` instruction files, tests.

11.2.5 The `breaking change` label is a **hint, not a trigger** — the fragment decides. The label has historically been applied to roughly half of the changes that shipped in a `Breaking` or `Potentially Breaking` section, and once to a release-notes PR, which would have triggered a bump on the very PR that sets the version.

11.2.6 **Never justify a level by appealing to previous releases.** The history is inconsistent — `2.9.1` shipped a `#### Breaking` entry as a patch. Cite the rule from [docs/versioning.md](../../docs/versioning.md) instead.

11.2.7 When the level is genuinely unclear, **go up**. A MESO that could have been a MICRO costs nothing; a MICRO that should have been a MESO breaks a consumer who was told the upgrade was drop-in.

11.2.8 Record the level and the trigger that forced it in the release-notes document's `### Version Level` section and in the version-bump PR description.

## 11.3. Two Independent Scales

11.3.1 SDK package version follows EffVer — `VersionPrefix` in `cql-sdk.props` and `Demo/cql-demo.props`.

11.3.2 `GeneratorToolVersion` follows SemVer — see [05-build-and-test.md](05-build-and-test.md) section 5.3.2.2.

11.3.3 Do not conflate them. A SemVer-**minor** generator bump is a **MESO**-level SDK change, because consumers regenerate.

## 11.4. Pre-release Versions

11.4.1 EffVer covers the three digits only. Pre-release identifiers keep **SemVer 2.0 syntax**, because NuGet's version resolution depends on it: a pre-release sorts below the corresponding final release and is not installed unless the consumer explicitly asks for it.

11.4.2 The full version is assembled from two MSBuild properties in `cql-sdk.props` and `Demo/cql-demo.props`: `VersionPrefix` (e.g. `2.15.0`) plus `VersionSuffix` (e.g. `rc.1`), giving `2.15.0-rc.1`. `VersionSuffix` stays commented out except while a pre-release is in flight.

11.4.3 Valid suffixes: `alpha.N` (early preview, incomplete, expect instability), `beta.N` (feature-complete but still under significant testing), `rc.N` (feature-complete, final testing).

11.4.4 **Decide the EffVer level first, then append the suffix.** `VersionPrefix` is always the version intended to ship, chosen by 11.2. Never use a pre-release to defer the level decision, and never ship a pre-release whose prefix is expected to change — if the level turns out to be wrong, correct the prefix and restart the suffix at `.1`.

11.4.5 The digits describe the effort of adopting the **final** release, not the pre-release. "Expect instability" is what `alpha`/`beta` conveys and is orthogonal to MACRO/MESO/MICRO.
