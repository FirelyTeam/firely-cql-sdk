## Fixes

- **`as` from a list of value-typed elements to a list of a reference element type keeps the list.**
  `{ 1, 2, 3 } as List<Any>` evaluated to `null`: the compiler emitted a whole-list
  `as IEnumerable<object>` cast, and `IEnumerable<T>` covariance does not apply to value-type element
  types such as `int?`. Such a list is now boxed element-wise, for both `as` and `cast as`, the way a
  list of compiler-generated tuples already was. Consequently `=`, `!=` and `~` of two `List<Any>`
  operands built from such lists compare the lists instead of a `null`, and the cqframework
  conformance cases `Equal123AndABC`, `Equal123AndString123`, `NotEqualABCAnd123`, `NotEqual123AndABC`,
  `NotEqual123AndString123`, `EquivalentABCAnd123`, `Equivalent123AndABC` and
  `Equivalent123AndString123` run and pass. The reverse direction, a `List<Any>` as a list of a
  value-typed element type, is unchanged and still evaluates to `null`.

  **This changes generated C#**: `GeneratorToolVersion` moves to `6.0.1.0` (patch: the generated API
  is unchanged). No checked-in `*.g.cs` file contains such a conversion, so none changes beyond its
  version header, and the integration runner's vendored library resources are regenerated with the
  new generator.

  **This changes CQL evaluation results.** A define that widens a list of integers, decimals,
  booleans, dates or other value-typed elements to `List<Any>` evaluates to the list rather than to
  `null`. Per [versioning.md](../../versioning.md) this forces a **MESO** bump. (#1711)
