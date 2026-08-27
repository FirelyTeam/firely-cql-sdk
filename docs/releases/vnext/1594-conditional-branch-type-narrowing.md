## Fixes

- **CQL-to-ELM translator:** an `if` / `else if` chain whose branches evaluate to lists of different
  tuple types no longer returns `null` for all but one branch. The translator typed the whole chain
  as the first branch's type and cast every other branch down to it; for tuple lists — which the C#
  code generator lowers to nullable value tuples — that cast is always `null` at run time, with no
  error and no warning, so the define silently evaluated to nothing. Such a chain is now typed as
  the *choice* of its branch types, which is what `case` already did, and each branch returns its
  own list regardless of branch order. **CQL evaluation results change:** a define built this way
  previously scored as if the affected branch were empty and now returns its values, so measure
  output can move. (#1594)
