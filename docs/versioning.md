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

Either of two triggers raises it, and the release notes must say **which**:

- **Measured.** The migration is substantial for a typical consumer: a re-architecture, removal of
  a whole surface area, or several MESO-level migrations landing together.
- **Declared.** A deliberate decision that this is a new engine generation — that the release is to
  be considered a separate project from what came before. This is a product judgement, taken and
  recorded, not a consequence of any single change. It may be taken *before* the adoption cost is
  known, and it holds even if that cost later turns out to be modest.

The declared trigger is a deviation from EffVer; see [Deviations from EffVer](#deviations-from-effver).

The `2.x` line is itself a declared MACRO. `v2.0.0-alpha` was tagged 2024-06-13, fourteen months
before the first 2.x final release (`v2.1.0`, 2025-08-19) and while the `1.x` line was still being
tagged — there was no released 2.x version from which any adoption cost could have been measured.
There has never been a `v2.0.0` final, and `1.x` never had a final release either, only three
release candidates.

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
- **Breaking but cheap.** Removing public API that nothing could reach — an `internal` type's
  accidentally-public member, or a surface added and withdrawn inside one release window so no
  released version ever exposed it — is source-breaking by SemVer's definition while costing every
  actual consumer nothing.

  Note that "the option never worked, so nobody can have depended on it" is *not* an instance of
  this. Fixing Packager CLI `--cs-namespace` in #1570 changed generated type identities for
  everyone already passing the option, who must now regenerate — which is why `2.14.0` is MESO. The
  cause of a change being a defect says nothing about the cost of adopting the fix.

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

- **Decide the level first, then append the suffix.** `VersionPrefix` is always the version you
  intend to ship, chosen by the rules above. `2.15.0-rc.1` means "the next release is a MESO bump,
  and this is a candidate for it". Never use a pre-release to defer the level decision.

  A **declared MACRO** is the one exception where the prefix is fixed before the adoption cost is
  known: `3.0.0-alpha.1` is legitimate the moment a new engine generation is declared, and the `3`
  stays put even if the finished release turns out to cost a typical consumer little. Outside that
  case, do not ship a pre-release whose prefix you expect to change — if a measured level proves
  wrong, correct the prefix and restart the suffix at `.1`.
- **The digits describe adopting the final release, not the pre-release.** "Expect instability" is
  what `alpha`/`beta` conveys, and it is orthogonal to MACRO/MESO/MICRO. A `2.15.0-alpha.1` still
  carries the MESO promise about what upgrading from `2.14.0` to the eventual `2.15.0` will cost.

Historical note: the `v2.0.0-alpha` … `v2.0.17-alpha` tags incremented the third digit once per
alpha instead of using an `-alpha.N` suffix, which is not consistent with this convention. The
*decision* to call that line `2.x` while still in alpha is a declared MACRO and is consistent; only
the suffix mechanics were wrong. See the
[Creating Tags and Releases](https://github.com/FirelyTeam/firely-cql-sdk/wiki/Creating-Tags-and-Releases)
wiki page for the tagging mechanics.

## Deviations from EffVer

[EffVer](https://jacobtomlinson.dev/effver/) as published defines the three digits purely by
adoption effort. We follow it with **one** documented deviation, listed here so that citing EffVer
stays honest — the failure this policy exists to fix was a document claiming a scheme the project
did not follow.

**1. MACRO may be *declared* as well as measured.** EffVer's macro means "you will need to dedicate
significant time to upgrading" — a statement about cost. We also allow MACRO to be raised by
declaring a new engine generation, a product judgement that can be taken before any cost is known
and that stands even if the cost proves small. This borrows the PROJECT digit from
[Romantic Versioning](https://romversioning.github.io/romver/): *"if the release is to be considered
as a separate project from older releases … the PROJECT identifier must be incremented."*

Its consequence for pre-releases is covered under [Pre-release versions](#pre-release-versions): a
declared MACRO fixes `VersionPrefix` up front, which no measured level may do.

Everything else is EffVer as written. In particular the MESO trigger list above is a *refinement* —
it enumerates, for this codebase, what "some small effort may be required" concretely means — and
not a departure. Two entries are worth naming as interpretations rather than deviations, since
EffVer does not mention either: marking public API `[Obsolete]` counts as effort because a consumer
building with warnings-as-errors has work to do, and a dependency bump crossing that dependency's
own major counts because the consumer's own graph moves with it.
