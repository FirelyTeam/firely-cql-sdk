# vNext release note fragments

This folder holds one release-note fragment file per pull request, instead of everyone editing a
single shared file and hitting merge conflicts
(see [#1432](https://github.com/FirelyTeam/firely-cql-sdk/issues/1432)).

## When to add one

Same trigger as before: any breaking change must be recorded in the same PR that introduces it —
not deferred to release time. Features and fixes can also be tracked here when they're worth
calling out in the release notes. See the root
[CLAUDE.md](../../../CLAUDE.md) / [copilot-instructions](../../../.github/copilot-instructions/04-development-guidelines.md)
for the exact rule.

## Naming

`<PR-number>-<short-slug>.md`, e.g. `1433-release-note-fragments.md` — use the **PR** number. The
PR number is available as soon as the PR is opened, which is well before merge and early enough for
the fragment to be added. If no PR has been opened yet (the work is still only on a branch), use a slug-only name unlikely
to collide, e.g. `add-benchmark-skill.md`; rename it to `<PR-number>-<slug>.md` once the PR exists.

`README.md` is reserved and is never treated as a fragment.

## Format

Each fragment file uses the same section headings as the versioned release notes, scoped to only the section(s) this PR
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
