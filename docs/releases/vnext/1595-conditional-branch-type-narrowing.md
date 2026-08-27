## Potentially Breaking

- **CQL-to-ELM translator:** an `if` / `else if` chain whose branches have no common type is now
  typed as the *choice* of its branch types rather than as the first branch's type. For a define
  written that way, the generated C# signature changes from that first branch's concrete type to
  `object` — the same C# an equivalent `case` has always produced. Any code compiled against the
  previous signature of such a define needs updating, and packaged artifacts need regenerating. Only
  defines containing this branch-type pattern are affected; every other define generates exactly as
  before. (#1594)

## Fixes

- **CQL-to-ELM translator:** an `if` / `else if` chain whose branches evaluate to lists of different
  tuple types no longer returns `null` for all but one branch. The translator typed the whole chain
  as the first branch's type and cast every other branch down to it; for tuple lists — which the C#
  code generator lowers to nullable value tuples — that cast is always `null` at run time, with no
  error and no warning, so those branches silently evaluated to nothing while the branches matching
  the chain's type kept working. Reconciliation now refuses any cast that cannot hold all of a
  branch's alternatives, so the chain widens to the choice of its branch types and each branch
  returns its own value regardless of branch order. **CQL evaluation results change:** a define
  containing this pattern previously scored as if the affected branches were empty and now returns
  their values, so measure output can move. (#1594)
