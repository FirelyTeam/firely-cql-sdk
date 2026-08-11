# 1. Copilot Instructions for Firely CQL SDK

**Version:** 3.15.0

This file is the decision-tree entry point. Route tasks here first, then open the focused sub-document before choosing tools.

## 1.0. Table of Contents

- [1. Copilot Instructions for Firely CQL SDK](#1-copilot-instructions-for-firely-cql-sdk)
- [1.0. Table of Contents](#10-table-of-contents)
- [2.0. Decision Tree / Task Taxonomy](#20-decision-tree--task-taxonomy)
- [3.0. Quick Navigation Index](#30-quick-navigation-index)
- [4.0. Project Context (Brief)](#40-project-context-brief)
- [5.0. Critical Files to Keep Updated (High-Level)](#50-critical-files-to-keep-updated-high-level)
- [6.0. Appendix: Version History](#60-appendix-version-history)

## 2.0. Decision Tree / Task Taxonomy

- Start here for every task: classify request first, open matching sub-document, then execute.
- If multiple categories apply: read all relevant sub-docs before implementation.

- Task-style preferences or GitHub workflow task?
  - Discuss-before-implementing, PR description expectations, GitHub CLI usage, issue formatting, ticket pickup, instruction maintenance, terminal behavior
  - Read [01-user-workflow-preferences.md](copilot-instructions/01-user-workflow-preferences.md)

- InternalsVisibleTo task?
  - InternalsVisibleTo placement, csproj format, signing key usage
  - Read [02-internalsvisibleto-configuration.md](copilot-instructions/02-internalsvisibleto-configuration.md)

- Project discovery task?
  - SDK project placement and examples layout
  - Read [03-project-structure.md](copilot-instructions/03-project-structure.md)

- Code-change or documentation standards task?
  - File headers, coding conventions, internal/public API boundaries, documentation numbering, TOC consistency, parent-document links, README and release-note policies
  - Read [04-development-guidelines.md](copilot-instructions/04-development-guidelines.md)

- Build or cross-platform script task?
  - Build entry points, Windows/Unix compatibility, generator versioning, ELM generation workflow
  - Read [05-build-and-test.md](copilot-instructions/05-build-and-test.md)

- Naming conventions task?
  - Naming prefixes and namespace rules
  - Read [06-naming-conventions.md](copilot-instructions/06-naming-conventions.md)

- FHIR Library handling task?
  - Library.Name vs Library.Id, identifier construction
  - Read [07-fhir-library-resource-handling.md](copilot-instructions/07-fhir-library-resource-handling.md)

- CQL specification conformance task?
  - Specification source of truth, when to consult spec, exact spec file locations
  - Read [08-cql-specification-conformance.md](copilot-instructions/08-cql-specification-conformance.md)

- Nullological operator behavior task?
  - Interface vs implementation return type contract
  - Read [09-nullological-operators-design-pattern.md](copilot-instructions/09-nullological-operators-design-pattern.md)

- CQL evaluation exception design task?
  - ICqlError and CqlException<TError> pattern, error placement, usage boundaries
  - Read [10-cql-evaluation-exceptions.md](copilot-instructions/10-cql-evaluation-exceptions.md)

## 3.0. Quick Navigation Index

- [01-user-workflow-preferences.md](copilot-instructions/01-user-workflow-preferences.md)
- [02-internalsvisibleto-configuration.md](copilot-instructions/02-internalsvisibleto-configuration.md)
- [03-project-structure.md](copilot-instructions/03-project-structure.md)
- [04-development-guidelines.md](copilot-instructions/04-development-guidelines.md)
- [05-build-and-test.md](copilot-instructions/05-build-and-test.md)
- [06-naming-conventions.md](copilot-instructions/06-naming-conventions.md)
- [07-fhir-library-resource-handling.md](copilot-instructions/07-fhir-library-resource-handling.md)
- [08-cql-specification-conformance.md](copilot-instructions/08-cql-specification-conformance.md)
- [09-nullological-operators-design-pattern.md](copilot-instructions/09-nullological-operators-design-pattern.md)
- [10-cql-evaluation-exceptions.md](copilot-instructions/10-cql-evaluation-exceptions.md)

## 4.0. Project Context (Brief)

- Firely CQL SDK provides CQL parsing, compilation, runtime evaluation, invocation, and packaging support.
- Primary technologies:
  - C# and .NET
  - SDK generation from ELM
  - Cross-platform PowerShell and Bash build workflows
- Core folders:
  - Cql for core SDK projects and tests
  - Examples for public and preview samples
  - docs for product and development documentation
  - spec for authoritative condensed CQL specification and conformance materials

## 5.0. Critical Files to Keep Updated (High-Level)

- Always keep these areas synchronized with behavior changes:
  - Root and project README files
  - docs release-note files and related documentation
  - Build and test scripts in both PowerShell and Bash variants
  - Any generator version constants and compatibility checks
  - Public API metadata files when adding public surfaces
- Use [04-development-guidelines.md](copilot-instructions/04-development-guidelines.md) and [05-build-and-test.md](copilot-instructions/05-build-and-test.md) for detailed enforcement rules.

## 6.0. Appendix: Version History

- Section-number references in entries below refer to the numbering as it existed in that version; later inserted sections may have renumbered those headings.

- 3.15.0
  - Added 1.6.2 to [01-user-workflow-preferences.md](copilot-instructions/01-user-workflow-preferences.md): when an issue is too stale to act on because the code or symbols it names no longer exist, close it and file a fresh superseding issue, cross-referenced in both directions, rather than keeping the stale issue open with a rewrite note ([#1529](https://github.com/FirelyTeam/firely-cql-sdk/issues/1529)).
  - Expanded the [file-github-issue](.claude/skills/file-github-issue/SKILL.md) skill with a new `Superseding a stale issue` section covering the canonical mechanics, including `develop` verification, bidirectional cross-references, `not planned` closure of the superseded issue, and emitted-C# acceptance criteria.
  - Mirrored the skill pointer into [CLAUDE.md](../CLAUDE.md), and documented [#48](https://github.com/FirelyTeam/firely-cql-sdk/issues/48) -> [#1528](https://github.com/FirelyTeam/firely-cql-sdk/issues/1528) as the worked example for refiling a stale issue in current terms.

- 3.14.0
  - Added reflection guidance as a new numbered section in [04-development-guidelines.md](copilot-instructions/04-development-guidelines.md): `4.4. Reflection` now requires using [`ReflectionUtility`](../Cql/Cql.Abstractions/Abstractions/Infrastructure/ReflectionUtility.cs) (`MethodOf`/`PropertyOf`/`ConstructorOf`/`GenericMethodDefinitionOf`) instead of string-based `GetMethod`/`GetProperty`, and clarifies why `nameof`-inside-string-lookup is insufficient.
  - Renumbered the following sections in [04-development-guidelines.md](copilot-instructions/04-development-guidelines.md), including item prefixes and TOC entries: `4.4 Documentation` -> `4.5`, `4.5 Release Notes` -> `4.6`.
  - Added review-workflow conventions in [01-user-workflow-preferences.md](copilot-instructions/01-user-workflow-preferences.md) and mirrored in [CLAUDE.md](../CLAUDE.md): reviewers do not push commits to PRs under review, instruction-file convention updates are filed and applied by `@copilot`, and `@copilot` dispatch/verification rules (comment-based dispatch with fully specified asks, plus multi-channel verification and precise `since` timestamps).

- 3.13.0
  - Broadened 1.8.1 (acceptance-criteria tracking): criteria are now ticked off automatically at every point where a checklist's truth may have changed — after pushing work, after a follow-up commit addressing review comments, and when reviewing a PR (including someone else's) — not only when first pushing. The `sync-acceptance-criteria` skill gains a "When to run this" section covering the three triggers plus how to resolve the linked issue when a PR uses `Refs` rather than `Fixes`. Mirrored into `CLAUDE.md`.
  - Expanded the `resolve-pr-review-comments` skill (referenced from 1.9.1): step 4 now states what a reply must contain before a thread is resolved (commit SHA, what changed, the test that pins it, how it was verified), asks for one commit per comment, and adds guidance for a comment that turns out to be wrong — give the concrete evidence in place of a SHA rather than resolving with a bare "this is incorrect" ([#1463](https://github.com/FirelyTeam/firely-cql-sdk/issues/1463)).
- 3.12.0
  - Completed Phase 2 of the fragment-file convention ([#1445](https://github.com/FirelyTeam/firely-cql-sdk/issues/1445)): replaced `docs/releases/vnext-release-notes.md` with a static pointer doc; dropped the "Transitional exception" sentence from §4.5.1 and the dual-source description from §4.5.2; updated the `cut-release-notes` skill to remove the transitional callout and the `vnext-release-notes.md` sweep step; fragment files under `docs/releases/vnext/` are now the sole pending-content source. Mirrored into `CLAUDE.md`.
- 3.11.0
  - Updated 4.5.1 and 4.5.2: made explicit that when cutting a release, **both** pending-content sources must be consolidated and cleared — the `docs/releases/vnext/` fragment files (deleted) and `vnext-release-notes.md` (reset or replaced with a pointer). Also updated the `cut-release-notes` skill reference in 4.5.2 to name both sources, and added a prominent transitional-phase callout to the `cut-release-notes` skill itself. Mirrored into `CLAUDE.md`.
  - Updated 4.2 (fragment-file naming): fragment files are now named `<PR-number>-<short-slug>.md` instead of `<issue-number>-<short-slug>.md`; the "known at branch creation" rationale removed. `docs/releases/vnext/README.md` is the canonical source; 4.5.1 delegates to it.
- 3.10.0
  - Updated 4.5.1: release-note entries now go in a new fragment file under `docs/releases/vnext/` (one per PR) instead of directly editing the shared `vnext-release-notes.md`, which caused recurring merge conflicts between parallel PRs. Transitional exception noted for PRs that already added a direct entry before this convention existed. See `docs/releases/vnext/README.md` for the naming/format convention and [#1432](https://github.com/FirelyTeam/firely-cql-sdk/issues/1432) for the full rationale; mirrored into `CLAUDE.md`.
  - Added 5.5 (Running Integration Runner Benchmarks): links to the new `run-integration-benchmarks` skill for running the `Firely.Cql.Sdk.Integration.Runner` submodule's BenchmarkDotNet project, appending a dated baseline file, and comparing medians against the most recent prior baseline.
- 3.9.0
  - Added a new rule (4.4.11) requiring Mermaid diagrams to be pre-rendered to `.svg` and embedded as an image rather than left as a raw fenced code block, since GitHub's inline renderer doesn't reliably support `classDiagram` `namespace`/`style`/`<<stereotype>>` syntax used in this repo's diagrams; mechanics live in the new `generate-svg-from-mermaid` skill (also mirrored into `CLAUDE.md`).
- 3.8.1
  - Simplified 5.1.4's CI skip-pattern description: `build/azure-pipelines.yml` now uses a single `^.*\.md$` pattern for all markdown files instead of separate entries per instruction-file location.
- 3.8.0
  - Added 5.1.4: CI's `build/azure-pipelines.yml` now skips the full build when every changed file is a documentation or AI-instruction file (`docs/`, `CLAUDE.md`, `.claude/`, `.github/copilot-instructions*`).
- 3.7.0
  - Added a new section (1.9, PR Review Comment Handling): after fixing a review comment and pushing, mark the conversation resolved via the GraphQL `resolveReviewThread` mutation — pushing a fix or replying does not resolve it automatically.
- 3.6.1
  - Fixed a broken relative link to `vnext-release-notes.md` in §4.5.1 (was missing a directory level), corrected `CodeGeneration.NET`/`LibraryInvoker` example paths in §5.3 to include the `Cql/` prefix, and scoped the `PublicAPI.Unshipped.txt` registration requirement in §10.3.3 to public `ICqlError` structs only (the project already has `internal` ones that don't belong there). Found by Copilot's automated review of PR #1386; mirrored into `CLAUDE.md` and `Cql/Cql.Abstractions/CLAUDE.md`.
- 3.6.0
  - Added a new section (1.8, Acceptance Criteria Tracking): after pushing work that completes checklist items in a linked issue or PR, tick them off before reporting the task done.
- 3.5.0
  - Added a rule (1.3.8) requiring these instructions and the root `CLAUDE.md`/`.claude/skills/` files to be kept in sync: any rule added, removed, or changed on one side must be checked against the other.
- 3.4.0
  - De-duplicated task-specific workflows against `.claude/skills/` (also used by Claude Code): PR description conventions, issue formatting, ticket pickup, release-note cutting, and ELM generation now link out to the corresponding skill file instead of restating the procedure. Each sub-document keeps only the universal trigger rules (e.g. breaking changes must land in `vnext-release-notes.md`); the step-by-step mechanics live in the linked skill.
- 3.3.0
  - Expanded code generation version management guidance: clarified that binder/compiler changes which alter generated C# (not only CodeGeneration.NET changes) require a `GeneratorToolVersion` bump, fixed the stale invoker reference, and added the requirement to regenerate checked-in `*.g.cs` files in the same pull request.
- 3.2.0
  - Added a durable documentation rule for copilot instruction docs: cap heading numbering at three segments and keep deeper numbering in body text instead of deeper headings.
- 3.1.0
  - Incorporated GitHub workflow guidance for GitHub CLI usage, issue formatting, ticket pickup, PR body synchronization, and instruction-maintenance safeguards.
  - Incorporated documentation standards for heading numbering, TOC consistency, parent-document links, and cross-document linking rules.
- 3.0.0
  - Major reorganization: split monolithic instructions into decision tree plus focused sub-documents.
  - Added task-taxonomy-first routing and quick index.
- 2.10.0 and earlier
  - Legacy monolithic structure retained in git history.
