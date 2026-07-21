---
name: cut-release-notes
description: Prepare a versioned release notes document for the Firely CQL SDK. Use when the user asks to write, draft, or cut release notes for a new version.
---

# Cut release notes

1. Use [docs/releases/release-notes-template.md](../../../docs/releases/release-notes-template.md) as the structure and guidance — follow its `tl;dr` format, product-area grouping, and "Common Items To Check" list.
2. Base the notes on every commit since the previous release tag, and incorporate all relevant content already drafted in [docs/releases/vnext-release-notes.md](../../../docs/releases/vnext-release-notes.md).
3. Call out exact public type/member/property/method names for API changes. For dependency version bumps, name the version property (e.g. `FirelyNetVersion`) and the old/new value.
4. Save the new document as `docs/releases/release-notes-<version>.md`.
5. If `VersionPrefix` (the SDK version) is being bumped as part of this release, also update the `## Release Notes` section of `README.md` — it has a line like "This is release version X.Y.Z of the engine." that must stay in sync.
6. After the new release notes document is written, **move** all content out of `docs/releases/vnext-release-notes.md` into it — that file's content is pre-drafted material for exactly this purpose and must not be left behind.
7. Reset `docs/releases/vnext-release-notes.md` back to the empty template, ready for the next cycle:

```md
# vNext Release Notes

## Breaking Changes

## Features

## Fixes
```

Note: breaking changes should already be landing in `vnext-release-notes.md` as part of the PRs that introduce them (see root [CLAUDE.md](../../../CLAUDE.md)) — this skill is about turning that accumulated content into a versioned release, not about discovering breaking changes from scratch.
