## Potentially Breaking

- **`singleton from` on a list with more than one element throws a `CqlException`.** It threw the
  `InvalidOperationException` of LINQ's `SingleOrDefault`, and throws a
  `CqlException<CqlSingletonFromMultipleElementsError>` instead. A caller that catches `InvalidOperationException`
  around evaluation no longer catches this error; catch `CqlException` instead. The error itself is unchanged: the
  specification requires it in §9.B, section "Singleton From" ("If the list contains more than one element, a run-time
  error is thrown."). The `ICqlOperators` signatures, the generated C# and `GeneratorToolVersion` do not change.
  (#1819)

## Fixes

- **`singleton from` on a list with more than one element reports what went wrong.** The message of LINQ's
  `SingleOrDefault`, "Sequence contains more than one element", did not name the CQL operator. The message names the
  operator, the number of elements and their CQL type, for example: "The singleton from operator requires a list with
  at most one element, but was given a list of 19 Condition elements. Use First or Last to take one element, or filter
  the list so that at most one element remains." (#1819)

## New Public API

- `Hl7.Cql.Primitives.CqlSingletonFromMultipleElementsError`, the `ICqlError` thrown by `singleton from` on a list
  with more than one element, where an `InvalidOperationException` was thrown before. (#1819)
