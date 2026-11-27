---
name: review-branch
description: Review a branch or pull request with an independent subagent that runs the code-review skill plus a brief tailored to the change. Use when asked to review a branch, a local commit before its first push, or a PR, and the reviewer should not be anchored on the reasoning of the session that wrote the code.
---

# Review a branch with an independent subagent

The session that wrote the code reads it the way it meant it. Hand the review to a fresh subagent instead, and give it the code and the requirement, not your conclusions.

## 1. Before spawning

1. Know the target: the worktree the branch is checked out in, and its base (`origin/develop`, or the feature branch the PR targets). Fetch first so the base is current.
2. Read the linked issue yourself, only to pick the risks to name in the brief (section 2). Do not pass on your own view of whether the change meets it.

## 2. The brief

Spawn one `general-purpose` subagent. The brief tells it to:

1. **Run the `code-review` skill** at `high` on `git diff <base>...HEAD`, run from the worktree, and follow it exactly. That gives the line-by-line pass, the removed-behavior pass, the caller/callee pass and the conventions pass.
2. **Judge the change against the issue's own text** (`gh issue view <n>`), not against the commit message: does the change do what the issue asks, and do its docs claim anything the code does not do?
3. **Check every hard-coded list against its source of truth.** Lists of names, attributes, defaults, node kinds or types are complete only if they match the schema, spec mirror (`/spec/cql/condensed/`) or model they enumerate: name that source and have it compared entry by entry.
4. **Look at the risks specific to this change**, as a short list: for example a comparison that can miss real differences, tests that would pass with the code broken, licensed content (HEDIS) leaking into an attached file, paths that only work on Windows.
5. **Apply the conventions of the branch under review**: the governing `CLAUDE.md` files are the ones inside the worktree, which can differ from the copy the agent was started with.
6. **Stay read-only**: no edits, commits or pushes. It may build and run the specific test classes it needs to confirm a suspicion, not the full suite.
7. **Return the findings as text** in its final message (file:line, severity, short summary, summary, failure scenario), as well as through ReportFindings: from a subagent, only the final message reaches the session.

Keep out of the brief: the design rationale, the findings of earlier rounds, and your expectations. They steer the reviewer to where you already looked.

## 3. After the review

1. Verify every finding against the code before acting on it. Classify each as real (fix it), already handled, or not applicable, and say which and why when reporting.
2. Fix the real ones in a new commit, with a test per fix that would fail without it.
3. **Review the fix commit once more**, with the same brief scoped to `git diff <previous head>..HEAD`: a fix for a review finding is new code, and an incomplete fix is the most likely finding of the next round.
4. Report to the user what was found, what was fixed, and what the brief missed, so the brief in this skill can improve.
