## Fixes

- **`aggregate distinct` compiles when the query's items are not of the aggregate's result type.**
  The compiler applied `Distinct` with the aggregate's result type instead of the type of the
  query's items, so `aggregate distinct` failed with `CannotBindToCqlOperatorError` over a
  multi-source query (whose items are tuples), and over a single-source query whose items differ in
  type from the result, such as `({'a', 'b', 'a'}) S aggregate distinct C starting 0: C + 1`.
  `Distinct` is now applied to the query's items, as the CQL specification requires, and the
  cqframework conformance case `MegaMultiDistinct` runs and passes.

  Queries that compiled before are those whose items already had the aggregate's result type; the
  generated C# for them is unchanged, so `GeneratorToolVersion` does not change and no CQL
  evaluation result moves.
