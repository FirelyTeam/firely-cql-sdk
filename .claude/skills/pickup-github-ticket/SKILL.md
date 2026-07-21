---
name: pickup-github-ticket
description: Pick up a GitHub issue/ticket by number or URL — find or create its branch and check it out. Use when the user says to pick up, start, or work on a specific ticket/issue number.
---

# Pick up a GitHub ticket

1. Resolve the request (issue number or URL) to an issue number.
2. Check whether a remote branch already exists for that ticket before creating a new one.
   - If multiple remote branches match, prefer the one that already has an active PR.
3. Check out the selected remote branch locally. If none exists, create a new local branch and check it out immediately — prefer an issue-number-prefixed name (e.g. `86-short-description`).
4. If the ticket is closed or its work looks already merged, ask the user to confirm they still want to pick it up, since it appears done. If they confirm: reopen the ticket if needed, set it to `In Progress`, and create/check out a branch as above.
5. If the ticket is open but has merged partial work, treat it as in progress — check whether an existing active branch or PR already covers the remaining work before creating a new one.
6. When done, include the direct GitHub issue link in the chat response.
