## Improvements

- **A reference tested with `is` has the tested type within the branch it guards.** A `case` whose
  leading conditions are `is` tests of one function operand, query alias or `let`
  (`case when choice is Interval<Quantity> then …`), and an `if` whose condition is such a test,
  now compile to a type switch over that reference whose arms bind it as the tested type. Within a
  branch, `x as T` is that value itself rather than a cast, and a property of `x` binds against
  `T` rather than dispatching over the alternatives of `x`'s choice type, so
  `choice.low as Quantity` under `when choice is Interval<Quantity>` reads a `CqlQuantity`
  directly. Only the leading run of `is` tests narrows; a branch after a condition of any other
  kind is compiled as before. A branch whose test an earlier test already covers (an `Age` after a
  `Quantity`) can never be taken and is dropped. An `as` within a branch to a type the narrowed
  value cannot have, which the translator emits when it resolves a call on a choice to another
  alternative's overload, is compiled on the un-narrowed value as before and logged, since it
  always yields `null`, or for a strict cast always fails. (#1661, #1677)

- **An `as` to a type its operand already has emits no cast.** `x as T` compiled to a C# `as` even
  when `x` already was a `T`, or was upcast to a choice from a `T`. It now compiles to `x` itself.
  This removes casts throughout generated code (`Union<Condition>(g_ as IEnumerable<Condition>, …)`
  is now `Union<Condition>(g_, …)`), including ones the narrowing above exposes: within the branch
  for `choice is Interval<Quantity>`, `choice.low as Quantity` is now just the interval's `low`.
  (#1683)

**This changes generated C#**: `GeneratorToolVersion` moves to `5.3.3.0` (patch: the generated API
is unchanged), and every checked-in `*.g.cs` with such a `case`, `if` or `as` is regenerated. CQL
evaluation results do not change: within the branch the value already is of the tested type, and an
`as` to a value's own type is the value.
