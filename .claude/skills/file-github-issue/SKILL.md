---
name: file-github-issue
description: Create or edit a GitHub issue for this repo. Use when the user asks to file a bug, write up an issue, or edit an existing issue's body.
---

# File a GitHub issue

- Write clean markdown with real line breaks and headings — never leave literal `\n` escapes in the final issue body.
- Draft the body in a scratch file first, then apply it with `gh issue edit --body-file <path>` (or `gh issue create --body-file <path>`) rather than passing `--body` inline, to avoid shell-escaping/encoding artifacts.
- Set the issue's **type** (Bug, Enhancement or Task) rather than adding a label for its
  kind. A `gh issue create` without a `--type` flag cannot set it, so set it afterwards with
  GraphQL, taking the type id from `repository { issueTypes(first: 10) { nodes { id name } } }`:
  `gh api graphql -f query='mutation($id:ID!,$type:ID!){ updateIssueIssueType(input:{issueId:$id, issueTypeId:$type}) { issue { number issueType { name } } } }' -f id=<issue id> -f type=<type id>`
- Use these sections where relevant to the issue:
  - `Summary`
  - `Impact`
  - `Observed Behavior`
  - `Root Cause`
  - `Repro Steps`
  - `Expected Behavior`
  - `Acceptance Criteria`

## Superseding a stale issue

When an issue is too stale to act on — the code, symbols or pipeline it names no longer
exist — close it and file a fresh one rather than keeping it open with a "needs rewriting"
comment or rewriting its body in place.

1. Verify every `file:line` citation against `develop` before writing the new issue. Never
   let a triage worktree path (e.g. `C:/Drives/D/triage-wt/…`) leak into an issue body.
2. Open the new issue's `Summary` with "This supersedes #NNN", and state explicitly what
   carried over and what did not (deleted classes/methods, and any proposed remedy that
   assumed a pipeline that no longer exists).
3. Record the bounding facts that make the defect latent rather than urgent, if any — they
   are what tells the next reader how to prioritise it.
4. Comment on the old issue naming the new number and what changed, then close it as a
   duplicate of the new issue, since the work is still planned there. Use the GraphQL
   `closeIssue` mutation with both issues' node ids:
   `gh api graphql -f query='mutation($id:ID!,$dup:ID!){ closeIssue(input:{issueId:$id, stateReason:DUPLICATE, duplicateIssueId:$dup}) { issue { number stateReason } } }' -f id=<old issue id> -f dup=<new issue id>`
5. Use line-pinned permalinks (`https://github.com/FirelyTeam/firely-cql-sdk/blob/<sha>/path#L12-L20`)
   for code citations. Relative Markdown links do not resolve in issue bodies.
6. If the fix would change emitted C#, include the `GeneratorToolVersion` bump and the
   `*.g.cs` regeneration in the acceptance criteria.

## Closing an issue

However an issue is closed (completed, not planned, or as a duplicate), remove the labels
that only describe open work: every `Blocked: …` label, and `Help Wanted`. Keep the others,
such as the area labels and `Breaking Change`: they still say what the issue was about.
Do the same for a pull request when it is merged or closed. The REST API removes a label
from issues and pull requests alike:
`gh api -X DELETE "repos/FirelyTeam/firely-cql-sdk/issues/<n>/labels/<label, URL-encoded>"`
