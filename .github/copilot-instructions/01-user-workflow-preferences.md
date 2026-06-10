# 01. User Workflow Preferences

## 1.1 Discuss Before Implementing

1.1.1 When user asks for ideas, suggestions, or "what would be the best way to..." questions, discuss options first.

1.1.2 Present 2-3 approaches with pros and cons.

1.1.3 Wait for user to choose an approach before implementing.

1.1.4 Do not immediately implement solutions when user asks for ideas.

1.1.5 User will explicitly ask to proceed with implementation when ready.

## 1.2 Instruction for PR AI

1.2.1 When asked to update or improve the Pull Request description, follow these requirements:

1.2.1.1 Analyze the entire set of commits in this PR branch.

1.2.1.2 Incorporate all changes made across the full diff, not just the snippet currently discussed.

1.2.1.3 Summarize the full scope and intent of the work done throughout the branch.

1.2.1.4 The PR description should always reflect:

1.2.1.4.1 the whole branch history

1.2.1.4.2 the complete set of code changes

1.2.1.4.3 architectural decisions

1.2.1.4.4 reasoning behind changes

1.2.1.4.5 any breaking changes or migrations

1.2.1.4.6 anything meaningful discovered during review discussions

1.2.2 Do not base the PR description only on the last change request or a summary of the prompt.

1.2.3 Goal: maintain a comprehensive, up-to-date PR description that represents the entire branch work.

## 1.3 Managing Copilot Instructions

1.3.1 When user provides memory-based instructions (for example: remember, never do, always do), add them to these repository Copilot instruction documents.

1.3.2 After updating the instructions, confirm the update by:

1.3.2.1 If instruction already existed: state "This instruction already exists in section [heading number]".

1.3.2.2 If newly added: state "Added to copilot instructions as section [heading number]".

1.3.3 When making changes to instruction documents, increment the version number according to semantic versioning:

1.3.3.1 Major version (x.0.0): structural changes or major reorganization

1.3.3.2 Minor version (x.y.0): new instructions or sections added

1.3.3.3 Patch version (x.y.z): clarifications, fixes, or minor edits to existing instructions

1.3.4 When making changes to the entry-point instructions file, always update its Table of Contents to reflect added, removed, or renamed sections.

## 1.4 Terminal and Command Execution

1.4.1 Critical: PowerShell non-interactive mode. When running PowerShell commands via run_in_terminal, always use non-interactive mode by adding -NonInteractive (for example: pwsh -NonInteractive -Command "...") to prevent commands from hanging.

1.4.2 Avoid creating interactive shells like pwsh or dotnet repl unless explicitly requested by the user.
