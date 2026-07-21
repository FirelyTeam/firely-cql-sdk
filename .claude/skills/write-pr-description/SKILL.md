---
name: write-pr-description
description: Write or update a GitHub PR description for this repo. Use when the user asks to create, update, or improve a pull request's description/body.
---

# Write PR description

When updating a PR description, base it on the **entire branch**, not just the change currently being discussed:

1. Look at every commit on the branch (`git log <base>..HEAD`) and the full diff (`git diff <base>...HEAD`), not only the latest commit or the current conversation topic.
2. Summarize the full scope and intent of the work across the whole branch: what changed, why, any architectural decisions, breaking changes/migrations, and anything meaningful that came out of review discussion.
3. Never write a description that only reflects the last change request — it must represent the branch's cumulative work.

Structure the body with two sections separated by `---`:

- **Primary Work**
- **Auxiliary Work**

Label both explicitly even if everything is primary work (still include an "Auxiliary Work" section, e.g. "None").

When asked to just show the description (not post it), output raw markdown in a fenced ` ```markdown ` block. When posting/updating it on GitHub, use `gh pr edit --body-file` on a temp file rather than `--body` with an inline string, to avoid shell-escaping issues.
