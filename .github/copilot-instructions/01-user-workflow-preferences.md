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

## 1.1. Discuss Before Implementing

1.1.1 When user asks for ideas, suggestions, or "what would be the best way to..." questions, **DISCUSS OPTIONS FIRST**

1.1.2 Present 2-3 approaches with pros/cons

1.1.3 Wait for user to choose an approach before implementing

1.1.4 DO NOT immediately implement solutions when user asks for ideas

1.1.5 User will explicitly ask to proceed with implementation when ready

## 1.2. Instruction for PR AI

1.2.1 When I ask you to update or improve the Pull Request description, follow these requirements:

1.2.1.1 **Analyze the entire set of commits in this PR's branch**

1.2.1.2 **Incorporate all changes made across the full diff**, not just the snippet I'm currently discussing

1.2.1.3 **Summarize the full scope and intent of the work** done throughout the branch

1.2.1.4 The PR description should always reflect:

      1.2.1.4.1 the whole branch history

      1.2.1.4.2 the complete set of code changes

      1.2.1.4.3 architectural decisions

      1.2.1.4.4 reasoning behind changes

      1.2.1.4.5 any breaking changes or migrations

      1.2.1.4.6 anything meaningful discovered during review discussions

1.2.2 **DO NOT** base the PR description only on the last change request or a summary of my prompt

1.2.3 Your goal: **Maintain a comprehensive, up-to-date PR description that represents the entire branch's work, not just the latest prompt**

1.2.4 When writing/updating PR descriptions, use sections:

      1.2.4.1 **Primary Work**

      1.2.4.2 **Auxiliary Work**

1.2.5 Separate those sections with `---`

1.2.6 Even if all work is primary, still label it explicitly

1.2.7 When asked for PR description output, provide raw markdown in a fenced ` ```markdown ` block

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

1.6.1 Use clean markdown with real line breaks and headings

1.6.2 Never leave escaped `\n` in final issue body content

1.6.3 Prefer drafting issue body in `/temp/`

1.6.4 Use `gh issue edit --body-file` to avoid shell escaping/encoding artifacts

1.6.5 Use these sections where relevant:

      1.6.5.1 `Summary`

      1.6.5.2 `Impact`

      1.6.5.3 `Observed Behavior`

      1.6.5.4 `Root Cause`

      1.6.5.5 `Repro Steps`

      1.6.5.6 `Expected Behavior`

      1.6.5.7 `Acceptance Criteria`

## 1.7. Ticket Pickup Workflow

1.7.1 When the user says to pick up a ticket by issue number or GitHub issue URL, resolve that request to the issue number first

1.7.2 Check for an existing remote branch for that ticket before creating a new branch

1.7.3 If multiple remote branches match, prefer the branch that already has an active pull request

1.7.4 Check out the selected remote branch locally before doing other work

1.7.5 If no matching remote branch exists, create a new local branch for the ticket and check it out immediately

1.7.6 Prefer an issue-number-prefixed branch name when creating the branch (for example `86-short-description`)

1.7.7 If the ticket is already closed or the related work is already merged, ask the user to confirm that they still want to pick it up because the work appears done already

1.7.8 If the user confirms they still want to pick it up, reopen the ticket when needed, set its status to `In Progress`, create a new branch for the ticket, and check it out locally

1.7.9 If the ticket is still open but already has merged partial work, treat it as in progress and continue evaluating whether an existing active branch or PR covers the remaining work

1.7.10 After completing a ticket pickup request, include the direct GitHub issue link in the chat response
