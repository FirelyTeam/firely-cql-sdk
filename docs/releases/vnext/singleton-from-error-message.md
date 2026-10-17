## Fixes

- **`singleton from` on a list with more than one element reports what went wrong.** It threw the
  `InvalidOperationException` of LINQ's `SingleOrDefault`, whose message, "Sequence contains more than one element",
  did not name the CQL operator. It throws a `CqlException<CqlSingletonFromMultipleElementsError>` whose message names
  the operator, the number of elements and their CQL type, for example: "The singleton from operator requires a list
  with at most one element, but was given a list of 19 Condition elements. Use First or Last to take one element, or
  filter the list so that at most one element remains." The error itself is unchanged: the specification requires it
  in §9.B, section "Singleton From" ("If the list contains more than one element, a run-time error is thrown."). A
  caller that catches `InvalidOperationException` around evaluation no longer catches this error; catch `CqlException`
  instead. The `ICqlOperators` signatures, the generated C# and `GeneratorToolVersion` do not change.

## New Public API

- `Hl7.Cql.Primitives.CqlSingletonFromMultipleElementsError`, the `ICqlError` thrown by `singleton from` on a list
  with more than one element, where an `InvalidOperationException` was thrown before.
