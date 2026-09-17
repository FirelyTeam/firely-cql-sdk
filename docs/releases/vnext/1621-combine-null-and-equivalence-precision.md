## Fixes

- `Combine` returns `null` for an empty source list, as the CQL specification requires, instead of an empty string. (#1619)
- `Combine` ignores null elements of its source list and returns `null` when no non-null element remains, as the CQL specification requires; a null element no longer produces a doubled separator. (#1622)
- Decimal equivalence (`~`) now determines each operand's precision ignoring trailing zeros and rounds the more precise operand away from zero before comparing, so `1.001 ~ 1.000` is `true` and `1.5 ~ 1.55` is `false`. Decimal equality is unchanged. (#1619)
- String equivalence (`~`) now ignores case and treats all whitespace characters as equivalent, per the CQL specification; string equality, ordering and hash-based operators stay ordinal. (#1619)

These fixes change CQL evaluation results for the affected expressions.
