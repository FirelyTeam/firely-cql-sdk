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

**Always link the PR to its tracking ticket.** Include a closing keyword (`Fixes #NNNN`, or `Refs #NNNN` if it shouldn't auto-close the issue) directly in the PR body/title — a closing keyword buried only in a commit message on the branch does **not** reliably create the tracked link (verify with `gh api graphql` querying `pullRequest.closingIssuesReferences` if in doubt). If no ticket exists yet for the work, create one first (see `file-github-issue` / `pickup-github-ticket`) rather than opening an unlinked PR.

If `gh pr edit --body-file` fails with an unrelated GraphQL error (e.g. a "Projects (classic)" deprecation error), the edit did not apply — fall back to `gh api repos/<owner>/<repo>/pulls/<number> -X PATCH --input <json-file>` with a `{"body": "..."}` payload, and re-verify the body actually changed.
