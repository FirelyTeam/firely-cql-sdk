## Potentially Breaking

- Generated C# now lowers CQL's `and`/`or`/`implies` to C#'s own short-circuiting `&&`/`||` over
  the new [`CqlBoolean`](../../../Cql/Cql.Abstractions/Primitives/CqlBoolean.cs) type, replacing the
  branching guard statements the previous change emitted. `CqlBoolean` is a three-valued Boolean
  whose `operator true`/`operator false` let C# synthesise `&&`/`||`, which `bool?` cannot do — the
  lifted `&`/`|` always evaluate both operands, and `&&`/`||` are not liftable over `Nullable<T>`.
  Evaluation semantics and expression values are identical to the guard form, including which
  operand may be skipped; only the emitted shape changes. `implies` lowers to `!left || right`.
  `xor` keeps its guard, because `null` is its deciding value and C# has no `^^`. (#1514)
- A right operand too large to inline moves into a zero-argument **local function** rather than
  being inlined, since it can never be hoisted into a statement above the expression without
  destroying the skip. Such functions are only ever called, never converted to a delegate, so
  Roslyn gives them a struct closure passed by `ref` and they do not allocate — preserving the
  property that ruled out the `Lazy<bool?>` runtime overloads. (#1514)
- `GeneratorToolVersion` is now **5.3.3.0**. Previously generated libraries keep working unchanged:
  the invoker toolkit accepts any version in `[5.1.0.0, 5.4.0.0)`. (#1514)

## Other

- A `CqlBoolean`-typed body no longer re-casts its result when the enclosing signature is already
  `bool?` — the conversion is implicit at the `return`, so the outer `(bool?)(…)` was pure noise.
  This removes 1,440 casts across the checked-in generated code, in both definition bodies and
  `bool?`-declared local functions. The conversion is kept wherever it is load-bearing (78 sites):
  `?? false`, a lifted `!`, and the null patterns each genuinely require a `bool?` and have no
  implicit conversion to fall back on. Declared signatures are unchanged, so this is a readability
  change only — it is the reason for the patch-level `GeneratorToolVersion` bump. (#1514)
- A short-circuit operator's **right** operand no longer carries a `(CqlBoolean)` conversion either
  (478 sites): overload resolution for the underlying `&`/`|` applies it implicitly, and a skipped
  operand is never converted, so the skip is unaffected. The **left** operand keeps its conversion,
  and that asymmetry is load-bearing rather than cosmetic — C# synthesises `&&`/`||` from the left
  operand's own `operator true`/`operator false`, so a `bool?` left operand has no `&&` at all.
  Right operands that bind looser than `&&` (an `is` pattern, a coalesce — 9 sites) are now
  parenthesised explicitly, having previously relied on the discarded cast's parentheses. (#1514)
- Converting to `CqlBoolean` no longer routes through `bool?` first (57 sites): a plain `bool` from a
  pattern such as `x is null` converts to `CqlBoolean` directly, so `(CqlBoolean)(b_ is null)` is
  emitted rather than `(CqlBoolean)((bool?)(b_ is null))`. The same removal reaches inside the local
  functions that hold larger operands, whose bodies now `return b_ is null;` instead of
  `return (bool?)(b_ is null);`. (#1514)
