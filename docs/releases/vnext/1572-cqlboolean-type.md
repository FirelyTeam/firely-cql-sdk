## Added

- New public type [`Hl7.Cql.Primitives.CqlBoolean`](../../../Cql/Cql.Abstractions/Primitives/CqlBoolean.cs): CQL's
  three-valued Boolean as a one-byte `readonly struct` carrying its own null state. It exists because
  `bool?` cannot short-circuit — C# synthesises `&&`/`||` only from a type's own `operator true`/
  `operator false`, and those cannot be lifted over `Nullable<T>` — so generated CQL had to express
  short-circuiting as branching control flow. Over this type it is an expression again. It is
  deliberately **not** `[CqlPrimitiveType]`: CQL's `Boolean` continues to map to `bool?` throughout
  the type system, bindings and generated signatures, so no existing public surface changes.
  Implicit conversions to and from `bool` and `bool?` are provided in both directions. (#1514)
- `CqlBoolean`'s `==` and `!=` are **three-valued**, matching CQL's `=`/`!=` and the
  `System.Data.SqlTypes.SqlBoolean` precedent the type is modelled on: null propagates, so
  `CqlBoolean.Null == CqlBoolean.Null` is `Null` (unknown), **not** `true`. They return `CqlBoolean`
  rather than `bool` for that reason.

  This deliberately does not agree with `Equals`, which stays two-valued and reflexive because
  hashing and collection lookup require it. The asymmetry is specified, not accidental — a
  "consistency" cleanup that aligned them would break one of the two contracts.

  Note that omitting these operators would not have avoided the question: `a == b` compiled anyway,
  resolving silently through the implicit `bool?` conversion on both sides and answering `true` for
  two nulls. Declaring them replaces an accidental answer with the specified one. (#1514)
