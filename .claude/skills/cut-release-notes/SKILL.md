---
name: cut-release-notes
description: Prepare a versioned release notes document for the Firely CQL SDK, and the version-bump steps that go with it. Use when the user asks to write, draft, or cut release notes for a new version, or to prepare/cut a release.
---

# Cut release notes

Full process (authoritative source): [Creating Tags and Releases](https://github.com/FirelyTeam/firely-cql-sdk/wiki/Creating-Tags-and-Releases) wiki page. This skill covers everything up to and including the version-bump PR — creating the git tag, the GitHub Release, and approving the NuGet/GitHub Packages deploy are separate, permission-gated steps for a release manager, not something to do as part of this skill.

1. **Decide the version level before writing anything.** Apply [docs/versioning.md](../../../docs/versioning.md) against the actual release window: list the fragments and their `##` headings, check whether `GeneratorToolVersion` moved, check every `PublicAPI.Unshipped.txt` for removals or signature changes, and check whether any merged PR changes CQL evaluation results. Record the level and the trigger that forced it — this becomes the release-notes document's `### Version Level` section and goes in the version-bump PR's description. Do not justify the level by what previous releases did; the history is inconsistent (`2.9.1` shipped a breaking change as a patch), so precedent proves nothing.
2. Use [docs/releases/release-notes-template.md](../../../docs/releases/release-notes-template.md) as the structure and guidance — follow its `tl;dr` format, `### Version Level` section, product-area grouping, and "Common Items To Check" list.
3. Base the notes on every commit since the previous release tag, and incorporate all relevant content already drafted as fragment files under [docs/releases/vnext/](../../../docs/releases/vnext/README.md).
4. Call out exact public type/member/property/method names for API changes. For dependency version bumps, name the version property (e.g. `FirelyNetVersion`) and the old/new value.
5. Save the new document as `docs/releases/release-notes-<version>.md`.
6. Bump `VersionPrefix` (and `VersionSuffix` for a pre-release) in **every** `*.props` file that declares it — currently `cql-sdk.props` and `Demo/cql-demo.props`. Also update the `## Release Notes` section of `README.md` — it has a line like "This is release version X.Y.Z of the engine." that must stay in sync.
7. **Confirm `FirelyNetVersion`** (in `cql-base.props`/`Demo/cql-demo.props`) still matches `FhirNetApiVersion` in [Vonk's `Directory.Packages.props` on `develop`](https://github.com/FirelyTeam/Vonk/blob/develop/Directory.Packages.props) — if you have a local Vonk clone, check the FirelyTeam `develop` branch specifically (e.g. `git show upstream/develop:Directory.Packages.props` if `upstream` points at `FirelyTeam/Vonk`, or `git show origin/develop:Directory.Packages.props` if `origin` does), not whatever branch happens to be checked out locally. Bump `FirelyNetVersion` to match if they've drifted.
8. **Promote every `PublicAPI.Unshipped.txt` entry to that project's `PublicAPI.Shipped.txt`**, for every project that has pending entries (check all of them — e.g. `find . -path ./submodules -prune -o -name PublicAPI.Unshipped.txt -print`).
9. After the new release notes document is written, consolidate all pending content into it — none of it may be left behind:
   - Glob `docs/releases/vnext/*.md` (excluding `README.md`). Fold each fragment's `## Breaking Changes`/`## Features`/`## Fixes` bullets into the matching section of the new document, then delete the fragment file.
10. Reset for the next cycle: `docs/releases/vnext-release-notes.md` is already the static pointer doc — leave it as-is.

Note: release-note-worthy breaking changes should already be landing as `docs/releases/vnext/` fragments as part of the PRs that introduce them, and features/fixes can be too (see root [CLAUDE.md](../../../CLAUDE.md)) — this skill is about turning that accumulated content into a versioned release, not about discovering entries from scratch.
