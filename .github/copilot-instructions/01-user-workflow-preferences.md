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

## 1.7. Ticket Pickup Workflow

1.7.1 Follow the shared procedure in [pickup-github-ticket](../../.claude/skills/pickup-github-ticket/SKILL.md) for resolving a ticket number/URL to a branch and picking up the work.
