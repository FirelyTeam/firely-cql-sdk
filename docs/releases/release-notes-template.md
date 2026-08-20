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

### Version Level

- **<MACRO | MESO | MICRO>** (`X.Y.Z`). _Name the trigger from [versioning.md](../versioning.md) that forced this level. If more than one fired, name them all. If the level was a judgement call, say what was weighed. For a MACRO, say whether it was **declared** (a new engine generation) or **measured** (adoption effort)._

---

### Generated Code Compatibility

- `LibrarySetCSharpCodeGenerator.GeneratorToolVersion`: **<X.Y.Z.B>** _(unchanged from `<previous version>`, or `<old>` → `<new>`)_.
- Accepted by `LibraryInstanceInvoker_<major>_<minor>`, whose supported range is `[<min>, <first unsupported>)`.

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
- The `### Version Level` section is required and must name the specific trigger, not just the level. "Minor because it felt right" is not a record; "MESO: `GeneratorToolVersion` moved 5.2.1.0 to 5.3.0.0, consumers regenerate" is. See [versioning.md](../versioning.md) for the trigger list.
- Do not justify a level by appealing to what previous releases did. The history is inconsistent — `2.9.1` shipped a breaking change as a patch — so precedent proves nothing. Cite the rule.
- The `### Generated Code Compatibility` section is required **every release, even when nothing moved**. Consumers who check in `*.g.cs`, or who ship packaged FHIR `Library` resources with embedded assemblies, need to know which generator produced their artifacts and whether those artifacts are still inside the invoker's accepted range — and they cannot reconstruct it from earlier notes, since `2.10.0` and `2.12.0` never stated it at all. State the two facts in exactly this one place; the `Common Items To Check` list points here rather than repeating them.
- Keep the document concise, but allow more detail for breaking changes and migration steps.
- For public API changes, always mention the exact API names.
- For dependency version changes, mention both the property name and the old/new version when known.
- Group changes by product area: CQL SDK, CQL Packager, Demo Projects and Build Tooling.
- Prefer developer-facing impact over internal refactoring details.
- If a change is behaviorally breaking but not source-breaking, label it clearly as potentially breaking.
- Include short code or command examples for migration-sensitive changes.

## Common Items To Check

- Version level decided against [versioning.md](../versioning.md), with the trigger recorded.
- PublicAPI shipped/unshipped promotions.
- New or changed exception types.
- Public runtime/operator API changes.
- Generator version and invoker range stated in `### Generated Code Compatibility` (state them every release, not only when they move).
- `FirelyNetVersion` updates.
- Packager CLI argument changes.
- MSBuild property, target, or script-flag renames.
- Content previously drafted in [vnext-release-notes.md](vnext-release-notes.md).
- All merged PRs since the previous release tag (for the PR table at the bottom).
