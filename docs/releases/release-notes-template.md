# Release Notes Template

Use this template when preparing a new Firely CQL SDK release note document or GitHub release body.

## Source Material

- Review all commits from the previous release tag to the target release branch.
- Incorporate any relevant content from [vnext-release-notes.md](vnext-release-notes.md).
- Prefer shipped/public API facts over implementation details when summarizing developer-facing changes.

## Structure

```md
## Firely CQL SDK <VERSION>

### tl;dr

> **Upgrading?** Here is the short version:
>
> - **Breaking changes:** _List any source-breaking or behavior-breaking changes in one line each._
> - **Required migrations:** _List concrete steps a developer must take (e.g. rename a property, update a config value)._
> - **Highlights:** _One-line summary of the most important new feature or improvement._

---

### CQL SDK

#### New Public API

- Call out exact public type/member/property/method names.

#### Improvements

- Summarize notable SDK/runtime/codegen changes.

#### Dependency Updates

- Call out version bumps that affect consumers, such as `FirelyNetVersion`.

#### Potentially Breaking

- Name the exact public API or behavior that changed.
- Include developer impact.
- Include migration guidance when applicable.

---

### CQL Packager

#### Breaking

- Describe CLI or output behavior changes.
- Include before/after examples when useful.

#### Improvements

- Summarize logging, packaging, and CLI quality-of-life changes.

---

### Demo Projects and Build Tooling

#### Breaking

- Call out renamed MSBuild properties, target files, script flags, and other migration-sensitive changes.
- Include migration snippets when applicable.

#### Improvements

- Summarize build reliability, examples, and documentation/tooling updates.

---

### Upgrade Checklist

1. List the concrete migration steps a developer should take.

---

### Pull Requests

| PR                                                              | Title    |
| --------------------------------------------------------------- | -------- |
| [#NNNN](https://github.com/FirelyTeam/firely-cql-sdk/pull/NNNN) | PR title |
```

## Guidance

- The `tl;dr` section must be the very first section after the version heading. Always include exactly three bullet points: breaking changes, required migrations, and a single highlights line. If there are no breaking changes, required migrations, or highlights, say "None" for that bullet rather than omitting it.
- Keep the document concise, but allow more detail for breaking changes and migration steps.
- For public API changes, always mention the exact API names.
- For dependency version changes, mention both the property name and the old/new version when known.
- Group changes by product area: CQL SDK, CQL Packager, Demo Projects and Build Tooling.
- Prefer developer-facing impact over internal refactoring details.
- If a change is behaviorally breaking but not source-breaking, label it clearly as potentially breaking.
- Include short code or command examples for migration-sensitive changes.

## Common Items To Check

- PublicAPI shipped/unshipped promotions.
- New or changed exception types.
- Public runtime/operator API changes.
- Code generation version changes.
- `FirelyNetVersion` updates.
- Packager CLI argument changes.
- MSBuild property, target, or script-flag renames.
- Content previously drafted in [vnext-release-notes.md](vnext-release-notes.md).
- All merged PRs since the previous release tag (for the PR table at the bottom).
