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
- `CqlBoolean.IsTrue`, `IsFalse`, `IsNull`, `IsNotNull`, `IsNotTrue`, `IsNotFalse` and `HasValue` let a
  three-valued value be *tested* without leaving the type. `IsTrue`/`IsFalse` are CQL's
  `is true`/`is false` — total, so `Null` yields `false` for both, and they are therefore not each
  other's negation; `IsNotTrue`/`IsNotFalse` are the actual negations, and each is satisfied by
  `Null`. They return `bool`, which is what a branch condition needs, so `x.IsTrue` replaces what
  used to be written `(bool?)x ?? false`, and `x.IsNull` replaces `x is null` — which a struct cannot
  have as a pattern at all (CS9135). (#1514)
- `CqlBoolean` is marked `[EditorBrowsable(EditorBrowsableState.Never)]` and its documentation now
  leads with the fact that it **supports generated code and is not intended to be used directly**.

  It is public only because it has to be: generated code declares locals of this type and compiles
  into other assemblies — the consuming project for checked-in `*.g.cs`, or an assembly named per
  library set when compiled in memory — and `InternalsVisibleTo` must name each friend assembly up
  front, which is impossible for an open-ended, user-chosen set. So it is a compiler-support type in
  the same sense as the builders in `System.Runtime.CompilerServices`.

  Note this reduces *discoverability* only. It remains public API in every other sense — still
  callable, bindable, reflectable, still listed in `PublicAPI`, and still covered by the usual
  compatibility obligations. You will not meet it by accident though: CQL's `Boolean` maps to `bool?`
  in every generated signature, so the type appears only inside method bodies. (#1514)
