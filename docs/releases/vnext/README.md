# vNext release note fragments

This folder holds one release-note fragment file per pull request, instead of everyone editing the
single shared [`docs/releases/vnext-release-notes.md`](../vnext-release-notes.md) and hitting merge
conflicts (see [#1432](https://github.com/FirelyTeam/firely-cql-sdk/issues/1432)).

## When to add one

Same trigger as before: any breaking change, feature, or fix worth calling out in the release notes
must be recorded in the same PR that introduces it — not deferred to release time. See the root
[CLAUDE.md](../../../CLAUDE.md) / [copilot-instructions](../../../.github/copilot-instructions/04-development-guidelines.md)
for the exact rule.

> **Transitional note** (see [#1432](https://github.com/FirelyTeam/firely-cql-sdk/issues/1432)): a PR
> that already added its entry directly to `vnext-release-notes.md` before this folder existed does
> not need to move it here. Only entries not yet written should use this folder.

## Naming

`<issue-number>-<short-slug>.md`, e.g. `1413-expand-overshoot.md` — use the tracking **issue** number
(known as soon as the branch is created, per this repo's issue-number-prefixed branch naming
convention), not the PR number (not assigned until the PR is opened). If a PR has no tracking issue,
use a slug-only name unlikely to collide, e.g. `add-benchmark-skill.md`.

`README.md` is reserved and is never treated as a fragment.

## Format

Exactly the same structure as `vnext-release-notes.md` itself, scoped to only the section(s) this PR
needs:

```md
## Fixes

- `Expand` no longer emits a trailing interval that overshoots the upper
  boundary when `per` does not divide the interval width. ... (#1413)
```

A PR with both a breaking change and a fix writes both `##` sections in its one fragment file. No
frontmatter or other metadata — the category comes from the `##` heading, same as today.

## Consolidation

Handled by the [`cut-release-notes`](../../../.claude/skills/cut-release-notes/SKILL.md) skill when a
release is cut: every fragment here gets folded into the versioned release notes document, then
deleted.
