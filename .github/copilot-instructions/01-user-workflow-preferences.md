# 1. User Workflow Preferences

Parent document: [../copilot-instructions.md](../copilot-instructions.md)

## 1.0. Table of Contents

- [1. User Workflow Preferences](#1-user-workflow-preferences)
- [1.0. Table of Contents](#10-table-of-contents)
- [1.1. Discuss Before Implementing](#11-discuss-before-implementing)
- [1.2. Instruction for PR AI](#12-instruction-for-pr-ai)
- [1.3. Managing Copilot Instructions](#13-managing-copilot-instructions)
- [1.4. Terminal and Command Execution](#14-terminal-and-command-execution)
- [1.5. GitHub CLI Usage](#15-github-cli-usage)
- [1.6. Issue Formatting Standards](#16-issue-formatting-standards)
- [1.7. Ticket Pickup Workflow](#17-ticket-pickup-workflow)
- [1.8. Acceptance Criteria Tracking](#18-acceptance-criteria-tracking)
- [1.9. PR Review Comment Handling](#19-pr-review-comment-handling)
- [1.10. PR Review Boundaries and `@copilot` Dispatch](#110-pr-review-boundaries-and-copilot-dispatch)

## 1.1. Discuss Before Implementing

1.1.1 When user asks for ideas, suggestions, or "what would be the best way to..." questions, **DISCUSS OPTIONS FIRST**

1.1.2 Present 2-3 approaches with pros/cons

1.1.3 Wait for user to choose an approach before implementing

1.1.4 DO NOT immediately implement solutions when user asks for ideas

1.1.5 User will explicitly ask to proceed with implementation when ready

## 1.2. Instruction for PR AI

1.2.1 When asked to update or improve a Pull Request description, follow the shared procedure in [write-pr-description](../../.claude/skills/write-pr-description/SKILL.md): base it on the full branch history (all commits and the full diff), not just the current prompt, and structure it into `Primary Work` / `Auxiliary Work` sections separated by `---`.

## 1.3. Managing Copilot Instructions

1.3.1 When user provides memory-based instructions (e.g., "remember", "never do", "always do"), add them to this copilot instructions file immediately

1.3.2 After updating the instructions, confirm the update by:

1.3.2.1 If the instruction already existed: State "This instruction already exists in section [heading number]"

1.3.2.2 If newly added: State "Added to copilot instructions as section [heading number]"

1.3.3 When making changes to this file, increment the version number according to semantic versioning:

1.3.3.1 **Major version** (x.0.0): Structural changes or major reorganization

1.3.3.2 **Minor version** (x.y.0): New instructions or sections added

1.3.3.3 **Patch version** (x.y.z): Clarifications, fixes, or minor edits to existing instructions

1.3.4 **When making changes to this file, always update the Table of Contents** to reflect any added, removed, or renamed sections

1.3.5 Use section-scoped numbering edits only; avoid blind global renumbering

1.3.6 After numbering edits validate:

      1.3.6.1 Heading hierarchy and sequence

      1.3.6.2 No duplicated numbering tokens

      1.3.6.3 TOC anchors/entries match

      1.3.6.4 In-text references are updated

1.3.7 Fix numbering mismatches before completion

1.3.8 **Keep the Claude Code instructions in sync**: when adding, removing, or changing a rule here (or in a sub-document), check whether the root [CLAUDE.md](../../CLAUDE.md) or a `.claude/skills/` file states the same rule and needs the equivalent update, and vice versa. A universal convention or gotcha should not exist in one file and not the other; a task-specific workflow should have exactly one canonical copy (in `.claude/skills/`) with the other file linking to it, not restating it.

1.3.9 When a new convention needs to be recorded in `CLAUDE.md` or `.github/copilot-instructions/`, file an issue and have `@copilot` make that instruction-file change on a branch rather than editing instruction files ad hoc in a local working copy.

## 1.4. Terminal and Command Execution

1.4.1 **CRITICAL - PowerShell Non-Interactive Mode**: When running PowerShell commands via `run_in_terminal`, **ALWAYS** use non-interactive mode by adding the `-NonInteractive` flag (e.g., `pwsh -NonInteractive -Command "..."`) to prevent commands from hanging waiting for user input

1.4.2 Avoid creating interactive shells like `pwsh` or `dotnet repl` unless explicitly requested by the user

## 1.5. GitHub CLI Usage

1.5.1 For GitHub workflow tasks, always prefer the GitHub CLI (`gh`) over browser-only or raw HTTP approaches when equivalent CLI support exists

1.5.2 Use `gh` for issue lookup, PR lookup, branch/PR discovery, issue edits, PR edits, and other repository workflow operations whenever possible

1.5.3 If the GitHub CLI is not installed yet, install it before proceeding with GitHub workflow tasks

1.5.4 After installation, assist the user through GitHub CLI authentication before continuing

1.5.5 Treat authentication as part of task setup when `gh` access is required

## 1.6. Issue Formatting Standards

1.6.1 Follow the shared procedure in [file-github-issue](../../.claude/skills/file-github-issue/SKILL.md) for issue body formatting, drafting, and section conventions.

1.6.2 When an issue is too stale to act on — the code or symbols it names no longer exist — close it and file a fresh superseding issue, cross-referenced in both directions, instead of keeping the stale one open with a "needs rewriting" note. The procedure is in [file-github-issue](../../.claude/skills/file-github-issue/SKILL.md).

## 1.7. Ticket Pickup Workflow

1.7.1 Follow the shared procedure in [pickup-github-ticket](../../.claude/skills/pickup-github-ticket/SKILL.md) for resolving a ticket number/URL to a branch and picking up the work.

## 1.8. Acceptance Criteria Tracking

1.8.1 Tick off acceptance-criteria checkboxes in a PR's linked issue (and the PR body) automatically, whenever their truth may have changed: after pushing work, after a follow-up commit that addresses review comments, and when reviewing a PR — including someone else's. Do it before reporting the review or the task done — follow the shared procedure in [sync-acceptance-criteria](../../.claude/skills/sync-acceptance-criteria/SKILL.md).

## 1.9. PR Review Comment Handling

1.9.1 After fixing a review comment (e.g. from Copilot's automated PR review) and pushing the fix, mark that conversation resolved — this does not happen automatically. Follow the shared procedure in [resolve-pr-review-comments](../../.claude/skills/resolve-pr-review-comments/SKILL.md).

## 1.10. PR Review Boundaries and `@copilot` Dispatch

1.10.1 While reviewing someone else's PR, do not commit to that PR branch. Findings go to the author (or `@copilot`) to apply.

1.10.2 The consequence is not only procedural: if a reviewer commits to the branch being reviewed, that reviewer has now contributed code to the PR, so their review is no longer eligible as approval and a second reviewer is required.

1.10.3 An `@copilot` mention in a review body is not a reliable dispatch mechanism. Post the ask as a PR comment tagging `@copilot`, and include the full request in that comment: exact file path, concrete before/after change, and rationale.

1.10.4 Do not send pointer-only asks (for example "apply item 11") that rely on context elsewhere; restate all required edits in the dispatch comment itself.

1.10.5 When verifying whether `@copilot` work landed, check all channels: issue comments (`issues/<n>/comments`), PR reviews (`pulls/<n>/reviews`), inline PR comments (`pulls/<n>/comments`), and timeline events (`issues/<n>/timeline`, including `copilot_work_started`/`copilot_work_finished`).

1.10.6 A completed `@copilot` session with an unchanged head SHA means no code changes were applied; that outcome may leave no review/comment, so timeline events are required evidence.

1.10.7 Any `since` filter used for follow-up verification must use the exact timestamp of the triggering event, never a rounded or approximate time.

1.10.8 When picking up a PR for review, report ahead/behind counts from `git rev-list --left-right --count <branch>...origin/<base>` (first count is ahead, second is behind), and report PR mergeability (`mergeable`, plus `mergeStateStatus` when available), then ask whether to merge the base into it before reviewing — do not decide unilaterally. Reviewing a stale branch means reviewing against a world that has moved, but a base merge re-triggers CI and can surface conflicts mid-review, so the call is the user's. If the branch is 0 behind, say so and carry on.
