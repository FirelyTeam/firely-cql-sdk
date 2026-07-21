---
name: sync-acceptance-criteria
description: Tick off completed acceptance-criteria checkboxes in a linked issue/ticket or PR body after finishing and pushing the corresponding work. Use right after pushing commits to a PR, before reporting the task as done.
---

# Sync acceptance criteria

After pushing work to a PR, check whether the linked issue and/or the PR body has an "Acceptance Criteria" (or similar) checklist, and update it to reflect what's actually true on the pushed branch:

1. Fetch the **current** body first (`gh issue view <n> --json body -q '.body'` / `gh pr view <n> --json body -q '.body'`) — never edit from a stale copy, since someone (or an earlier step in the same session) may have changed it since you last read it.
2. For each unchecked item, verify honestly against the real repo/branch state (read the file, run the check, `grep` for the thing) before checking it off. **Never check off a criterion you haven't actually verified** — a false positive here is worse than leaving it unchecked for a human to confirm.
3. Change only `- [ ]` → `- [x]` for verified-complete items; leave everything else (including unmet or partially-met criteria) untouched.
4. Apply the edit with `gh issue edit --body-file` / `gh pr edit --body-file` on a temp file (never `--body` inline). If `gh pr edit`/`gh issue edit` fails on an unrelated error, fall back to the REST PATCH: `gh api repos/<owner>/<repo>/issues|pulls/<number> -X PATCH --input <json-file>` with a `{"body": "..."}` payload.
5. Re-fetch the body afterward and confirm the checkboxes actually flipped — edits can silently fail (see the `write-pr-description` skill's note on `gh pr edit` failing on an unrelated GraphQL error).
