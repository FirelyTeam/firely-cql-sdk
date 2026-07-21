---
name: cut-release-notes
description: Prepare a versioned release notes document for the Firely CQL SDK, and the version-bump steps that go with it. Use when the user asks to write, draft, or cut release notes for a new version, or to prepare/cut a release.
---

# Cut release notes

Full process (authoritative source): [Creating Tags and Releases](https://github.com/FirelyTeam/firely-cql-sdk/wiki/Creating-Tags-and-Releases) wiki page. This skill covers everything up to and including the version-bump PR — creating the git tag, the GitHub Release, and approving the NuGet/GitHub Packages deploy are separate, permission-gated steps for a release manager, not something to do as part of this skill.

1. Use [docs/releases/release-notes-template.md](../../../docs/releases/release-notes-template.md) as the structure and guidance — follow its `tl;dr` format, product-area grouping, and "Common Items To Check" list.
2. Base the notes on every commit since the previous release tag, and incorporate all relevant content already drafted in [docs/releases/vnext-release-notes.md](../../../docs/releases/vnext-release-notes.md).
3. Call out exact public type/member/property/method names for API changes. For dependency version bumps, name the version property (e.g. `FirelyNetVersion`) and the old/new value.
4. Save the new document as `docs/releases/release-notes-<version>.md`.
5. Bump `VersionPrefix` (and `VersionSuffix` for a pre-release) in **every** `*.props` file that declares it — currently `cql-sdk.props` and `Demo/cql-demo.props`. Also update the `## Release Notes` section of `README.md` — it has a line like "This is release version X.Y.Z of the engine." that must stay in sync.
6. **Confirm `FirelyNetVersion`** (in `cql-base.props`/`Demo/cql-demo.props`) still matches `FhirNetApiVersion` in [Vonk's `Directory.Packages.props` on `develop`](https://github.com/FirelyTeam/Vonk/blob/develop/Directory.Packages.props) — if you have a local Vonk clone, check `origin/develop` specifically (`git show origin/develop:Directory.Packages.props`), not whatever branch happens to be checked out locally. Bump `FirelyNetVersion` to match if they've drifted.
7. **Promote every `PublicAPI.Unshipped.txt` entry to that project's `PublicAPI.Shipped.txt`**, for every project that has pending entries (check all of them — `find . -name PublicAPI.Unshipped.txt`, excluding `submodules/`).
8. After the new release notes document is written, **move** all content out of `docs/releases/vnext-release-notes.md` into it — that file's content is pre-drafted material for exactly this purpose and must not be left behind.
9. Reset `docs/releases/vnext-release-notes.md` back to the empty template, ready for the next cycle:

```md
# vNext Release Notes

## Breaking Changes

## Features

## Fixes
```

Note: breaking changes should already be landing in `vnext-release-notes.md` as part of the PRs that introduce them (see root [CLAUDE.md](../../../CLAUDE.md)) — this skill is about turning that accumulated content into a versioned release, not about discovering breaking changes from scratch.
