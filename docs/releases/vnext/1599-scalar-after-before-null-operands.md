## Fixes

- Scalar (point) `after` and `before` on Date, DateTime and Time now return `null` when either or
  both operands are null, as the CQL specification requires (§9.B After / Before: "If either or both
  arguments are null, the result is null"). Previously the point comparison fell through to the
  comparer's total ordering of null — the ordering that makes sorting deterministic — and so
  returned a boolean: `(null as DateTime) after @2024-01-01T00:00:00.000Z` evaluated to `true`,
  `value after null` and `null after null` to `false`, `null before value` and `null before null` to
  `false`, and `value before null` to `true`. All six now evaluate to `null`. (#1598)

  **This changes CQL evaluation results**: any expression that compared a possibly-null Date,
  DateTime or Time with scalar `after`/`before` can now yield `null` where it previously yielded
  `true` or `false`, which propagates through the surrounding logic (`and`/`or`, `where` clauses,
  measure population criteria). Comparisons with two non-null operands, the precision-uncertainty
  semantics, the interval-valued `after`/`before` overloads and the null ordering used for sorting
  are all unchanged. No public API change and no `GeneratorToolVersion` change — the emitted C# is
  identical, the fix is entirely in the runtime operator implementation, so previously packaged
  libraries pick the new behavior up on the new runtime without being regenerated.
