---
name: resolve-pr-review-comments
description: Address code review comments (e.g. from Copilot's automated PR review) on an open PR, then mark each resolved conversation. Use after a reviewer leaves inline comments and you've fixed and pushed the corresponding changes.
---

# Resolve PR review comments

1. Fetch the inline review comments: `gh api repos/<owner>/<repo>/pulls/<n>/comments -q '.[] | {id, path, line, body}'`.
2. **Verify each comment before acting on it** — a review comment (bot or human) can itself be wrong. Check the claim against the real repo state (read the file, run the check) rather than applying it blindly.
3. Fix what's genuinely wrong, commit, and push to the PR's branch.
4. Reply to each comment thread confirming what changed, referencing the commit: `gh api repos/<owner>/<repo>/pulls/<n>/comments/<comment-id>/replies -f body="Fixed in <sha> — ..."`.
5. **Mark the conversation resolved** — this does not happen automatically just by pushing a fix or replying. Look up the review thread's node ID (not the comment ID) via GraphQL, since only GraphQL can resolve threads:

```graphql
{
  repository(owner: "<owner>", name: "<repo>") {
    pullRequest(number: <n>) {
      reviewThreads(first: 20) {
        nodes { id isResolved path comments(first: 1) { nodes { databaseId } } }
      }
    }
  }
}
```

Match `comments.nodes[0].databaseId` back to the REST comment ID from step 1 to find the right thread, then resolve it:

```graphql
mutation { resolveReviewThread(input: {threadId: "<thread-id>"}) { thread { isResolved } } }
```

Check `isResolved` first — some threads may already flip to resolved on their own after a push (observed with Copilot's reviewer), so don't assume every thread still needs the mutation.
