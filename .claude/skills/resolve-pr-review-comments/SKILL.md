---
name: resolve-pr-review-comments
description: Address code review comments (e.g. from Copilot's automated PR review) on an open PR, then mark each resolved conversation. Use after a reviewer leaves inline comments and you've fixed and pushed the corresponding changes.
---

# Resolve PR review comments

1. Fetch the inline review comments: `gh api repos/<owner>/<repo>/pulls/<n>/comments -q '.[] | {id, path, line, body}'`.
2. **Verify each comment before acting on it** — a review comment (bot or human) can itself be wrong. Check the claim against the real repo state (read the file, run the check) rather than applying it blindly.
3. Fix what's genuinely wrong, commit, and push to the PR's branch. Prefer one commit per comment, so each thread maps to a reviewable change.
4. Reply to each comment thread before resolving it. **Every reply must make the thread self-contained** — someone reading the resolved thread should see which commit to look at and what it did, without cross-referencing the commit list. Include:
   - the **commit SHA** (short form is fine),
   - **what actually changed**, in a sentence or two — not just "fixed",
   - the **test** that pins it, if one was added or changed,
   - and how the fix was **verified**, when that's not obvious (e.g. "confirmed the test fails with the fix reverted").

   `gh api repos/<owner>/<repo>/pulls/<n>/comments/<comment-id>/replies -f body="Fixed in <sha> — ..."`

   **If a comment was refuted rather than fixed** (per step 2), there is no SHA to cite, so give the concrete evidence in its place: the build result, an existing in-repo precedent, or the passing test that disproves the claim. Say plainly that you're leaving the code as-is and why. Never resolve a refuted thread with a bare "this is incorrect".
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
