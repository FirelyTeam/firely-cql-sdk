# Versioning

The Firely CQL SDK does **not** use Semantic Versioning, and has never done so in practice.
It uses [EffVer](https://jacobtomlinson.dev/effver/) — Intended Effort Versioning.

## What the digits mean

`MACRO.MESO.MICRO`

Each digit answers *how much work will this cost you to adopt?* — not *what kind of change is it?*

| Digit | Signals |
| --- | --- |
| **MACRO** | You will need to dedicate significant time to upgrading. |
| **MESO** | Some small effort may be required to make sure this version works for you. |
| **MICRO** | This change doesn't intend for you to need to do anything. |

Effort is judged against the **typical** consumer — someone who packages CQL and invokes it
through the SDK. Where a change is cheap for them but expensive for a narrower audience (custom
`ICqlOperators` implementers, for example), the release notes call that audience out explicitly
rather than raising the digit for everyone.

## MESO — any one of these forces the second digit

- A fragment under [docs/releases/vnext/](releases/vnext/README.md) declaring `## Breaking` or
  `## Potentially Breaking`.
- `LibrarySetCSharpCodeGenerator.GeneratorToolVersion` changed. Consumers who check in generated
  `*.g.cs`, or who ship packaged FHIR `Library` resources with embedded C#, must regenerate.
- Public API removed, or an existing signature changed.
- Public API newly marked `[Obsolete]`. Nothing breaks, but a consumer building with
  warnings-as-errors has work to do.
- CQL evaluation results change — including bug fixes that correct previously wrong answers.
  A measure whose output moves is a migration even when the old output was a defect.
- A dependency bump crossing that dependency's own major version.

## MICRO — everything else

Including **new public API**. Adding surface is backward-compatible and costs an existing
consumer nothing, so additions alone do not raise the digit.

## MACRO — the first digit

Reserved for a release whose migration is substantial for a typical consumer: a re-architecture,
removal of a whole surface area, or several MESO-level migrations landing together. This is a
deliberate, recorded decision, not an automatic consequence of any single change.

The `1.x` to `2.x` transition was a MACRO bump under these rules. `1.x` releases are maintained
with hotfixes only and do not receive new features.

## What never affects the version

- Repository-maintenance scripts (for example `LibrarySets/sync-dqm-2025.ps1`).
- Contributor-facing documentation, CI configuration, and build scripts that do not change
  shipped behavior.
- The private `Firely.Cql.Sdk.Integration.Runner` submodule and its vendored resources.
- `CLAUDE.md`, `.claude/`, and `.github/` instruction files.
- Tests.

## The `breaking change` label

A useful hint, not a trigger. Historically it has been applied to only about half the changes
that ended up in a `Breaking` or `Potentially Breaking` section —
[#1312](https://github.com/FirelyTeam/firely-cql-sdk/pull/1312),
[#1490](https://github.com/FirelyTeam/firely-cql-sdk/pull/1490),
[#1532](https://github.com/FirelyTeam/firely-cql-sdk/pull/1532) and
[#1568](https://github.com/FirelyTeam/firely-cql-sdk/pull/1568) all shipped there unlabelled, and
#1312's miss is the direct cause of `2.9.1` going out as a patch carrying a breaking change. It
has also been applied to a release-notes PR
([#1560](https://github.com/FirelyTeam/firely-cql-sdk/pull/1560)), which would trigger a bump on
the very PR that sets the version. Treat the label as a prompt to check the fragment, and let the
fragment decide.

## Two independent scales

| Scale | Scheme | Where |
| --- | --- | --- |
| SDK package version | EffVer | `VersionPrefix` in `cql-sdk.props`, `Demo/cql-demo.props` |
| Code generator version | SemVer (`major.minor.patch.build`) | `GeneratorToolVersion` in [`_CODE GENERATOR VERSION_.cs`](../Cql/CodeGeneration.NET/_CODE%20GENERATOR%20VERSION_.cs) |

Both are stated in every release note. Do not conflate them: a SemVer-minor generator bump is a
MESO-level SDK change, because consumers regenerate.

## Recording the decision

Every release-notes document carries a `### Version Level` section naming the level and the
trigger that forced it. See [release-notes-template.md](releases/release-notes-template.md).

## Tie-breaker

When the level is genuinely unclear, **go up**. A MESO that could have been a MICRO costs nothing.
A MICRO that should have been a MESO breaks a consumer who was told the upgrade was drop-in.

## Why not SemVer

SemVer classifies changes by compatibility. Two categories break that model here:

- **Compatible but costly.** A `GeneratorToolVersion` bump, or a bug fix that changes a measure's
  computed result, is backward-compatible by SemVer's definition and would land in `PATCH`.
  Consumers have real work to do in both cases.
- **Breaking but cheap.** Fixing an option that never worked is technically breaking, yet nobody
  could have depended on the broken behavior.

SemVer also forces `MAJOR` on every breaking change, which for this SDK would have meant roughly
one major per release. EffVer keeps the leading digit meaningful.

## Pre-release versions

EffVer describes the three digits only; it says nothing about pre-release identifiers. We keep
**SemVer 2.0 pre-release syntax** for those, because NuGet's version resolution depends on it — a
pre-release sorts below the corresponding final release, and is not installed unless the consumer
explicitly asks for it (`--prerelease`, or an explicit version).

The full version is assembled by MSBuild from two properties in `cql-sdk.props` and
`Demo/cql-demo.props`:

```xml
<VersionPrefix>2.15.0</VersionPrefix>
<VersionSuffix>rc.1</VersionSuffix>   <!-- commented out for a final release -->
```

giving `2.15.0-rc.1`. `VersionSuffix` stays commented out except while a pre-release is in flight.

| Suffix | Meaning |
| --- | --- |
| `alpha.N` | Early preview, incomplete. Internal testing and experimentation; expect instability and frequent change. |
| `beta.N` | Feature-complete but still under significant testing. Suitable for external testers and early adopters; may contain known issues. |
| `rc.N` | Feature-complete and nearing final release, in final testing. |

Two rules keep the suffix from muddying the effort signal:

- **Decide the EffVer level first, then append the suffix.** `VersionPrefix` is always the version
  you intend to ship, chosen by the rules above. `2.15.0-rc.1` means "the next release is a MESO
  bump, and this is a candidate for it". Never use a pre-release to defer the level decision, and
  never ship a pre-release whose prefix you expect to change — if the level turns out to be wrong,
  correct the prefix and restart the suffix at `.1`.
- **The digits describe adopting the final release, not the pre-release.** "Expect instability" is
  what `alpha`/`beta` conveys, and it is orthogonal to MACRO/MESO/MICRO. A `2.15.0-alpha.1` still
  carries the MESO promise about what upgrading from `2.14.0` to the eventual `2.15.0` will cost.

Historical note: the `v2.0.x-alpha` and `v2.1.0-alpha.18` tags predate this convention and are not
consistent with it. See the
[Creating Tags and Releases](https://github.com/FirelyTeam/firely-cql-sdk/wiki/Creating-Tags-and-Releases)
wiki page for the tagging mechanics.
