## Fixes

- Aggregate operators whose result cannot be represented evaluate to `null` instead of ending evaluation with a .NET
  exception or a wrapped value, and report the overflow as a warning through the message event. The following results
  change:
  - `Avg` of Decimals whose total leaves the Decimal range: `null` instead of `OverflowException`.
  - `Product` of Integers or Longs whose product leaves the type's range: `null` instead of the value it wrapped
    around to.
  - `Product` of Decimals or quantities whose product leaves the Decimal range: `null` instead of `OverflowException`;
    whose product of nonzero values is too small in magnitude to represent: `null`, as for `*`, instead of `0`.
  - `Product` of quantities whose units differ: `null`, with a warning as `Sum` gives, instead of
    `NotSupportedException`.
  - `Median` of Decimals whose two middle values sum beyond the Decimal range (such as `Median({ maximum Decimal,
    maximum Decimal })`): their midpoint instead of `OverflowException`.
  - `StdDev` and `Variance` whose result leaves the Decimal range: `null` instead of `OverflowException`.
  - `StdDev` and `Variance` of a single value: `null`, as for any division by zero, instead of `OverflowException`.
  - `StdDev` and `Variance` of quantities whose units differ: `null`, with a warning, instead of
    `NotSupportedException`.
  - `PopulationStdDev` and `PopulationVariance` where the total of the values, a deviation from their mean or its
    square leaves the Decimal range: `null` instead of `OverflowException`.
- `singleton from` a list of more than one element signals a CQL error,
  `CqlException<CqlSingletonFromMultipleElementsError>`, instead of a .NET `InvalidOperationException`, as the
  specification mandates a run-time error for that case.

This changes CQL evaluation results for the affected expressions, which per [versioning.md](../../versioning.md) forces
a **MESO** bump. Generated C# and `GeneratorToolVersion` are unchanged.
