## Fixes

- **`Ceiling` and `Floor` of a Decimal whose result is outside the Integer range return `null`.**
  `Ceiling(2147483647.2)`, `Ceiling(2147483648.2)`, `Ceiling(-2147483649.2)`, `Floor(-2147483648.2)`,
  `Floor(2147483648.2)` and `Floor(-2147483649.2)` threw an `OverflowException`; they return `null`, as
  the specification requires in §9.B, section "Arithmetic Operators" ("operations that cause arithmetic overflow
  or underflow, or otherwise cannot be performed (such as division by 0) will result in null, rather
  than a run-time error"). Results at either end of the Integer range are unchanged
  (`Ceiling(-2147483648.2)` is `-2147483648`, `Floor(2147483647.2)` is `2147483647`). The cqframework
  conformance cases `CeilingDecimalLessThanMinInteger`, `CeilingDecimalGreaterThanMaxInteger`,
  `CeilingMaxIntegerAsDecimalWhereDecimalIsNonZero`, `FloorDecimalLessThanMinInteger`,
  `FloorDecimalGreaterThanMaxInteger` and `FloorMinIntegerAsDecimalWhereDecimalIsNonZero` run and pass.

  **This changes CQL evaluation results**: an expression that threw an exception evaluates to `null`.
  Per [versioning.md](../../versioning.md) this forces a **MESO** bump. The `ICqlOperators`
  signatures, the generated C# and `GeneratorToolVersion` do not change. (#1762)
