---
name: file-github-issue
description: Create or edit a GitHub issue for this repo. Use when the user asks to file a bug, write up an issue, or edit an existing issue's body.
---

# File a GitHub issue

- Write clean markdown with real line breaks and headings — never leave literal `\n` escapes in the final issue body.
- Draft the body in a scratch file first, then apply it with `gh issue edit --body-file <path>` (or `gh issue create --body-file <path>`) rather than passing `--body` inline, to avoid shell-escaping/encoding artifacts.
- Use these sections where relevant to the issue:
  - `Summary`
  - `Impact`
  - `Observed Behavior`
  - `Root Cause`
  - `Repro Steps`
  - `Expected Behavior`
  - `Acceptance Criteria`
