# 1. Generated-code operator ledger

As the code generator inlines CQL operator logic directly into generated C#
(see [#1514](https://github.com/FirelyTeam/firely-cql-sdk/issues/1514) for the first
increment), the corresponding `ICqlOperators` methods stop being called by newly generated
code. This ledger records which methods have reached that state, since which
`GeneratorToolVersion`, and what governs their eventual removal.

## 1.1. Retirement policy

A runtime operator method that generated code no longer calls is **not** removed when the
lowering ships. It must remain public and functional for as long as *any* generator version
inside the invoker's supported window (see `LibraryInvoker.<major>.<minor>.cs`,
`MinSupportedGeneratorToolVersion`/`FirstUnsupportedGeneratorToolVersion`) emitted calls to
it — previously generated libraries bind to it at runtime, and `ICqlOperators` implementers
compile against it.

Concretely, a method in this ledger may be removed only when **all** of the following hold:

1. A major release is being cut (removal is a breaking change to `ICqlOperators` for both
   callers and implementers, and needs its own release-note entry).
2. The invoker's minimum supported generator version is at or above the version in the
   ledger's "not called since" column — so no supported generated artifact can still call it.
3. The method is no longer serving as the reference implementation for a lowering's
   conformance tests, or the tests have been repointed at a preserved copy.

Until then, the methods stay: they double as the executable specification the lowering is
verified against (e.g. `CoreTests/ShortCircuitLogicCqlTest.GeneratedCode_AgreesWithRuntimeOperators`
checks generated truth tables against `ICqlOperators.And`/`Or`/`Not`/`Implies`).

`Xor(bool?, bool?)` is deliberately **not** in this ledger: every row of its truth table varies
with the right operand, so it has nothing to short-circuit, and C# has no lifted `^` over `bool?`
matching CQL's three-valued semantics. Generated code still calls it.

## 1.2. Ledger

| `ICqlOperators` member(s) | Not called since | Lowered to | Notes |
|---|---|---|---|
| `And(bool?, bool?)` | 5.3.0.0 ([#1514](https://github.com/FirelyTeam/firely-cql-sdk/issues/1514)) | lifted `&` behind a short-circuit guard | Reference implementation for the lowering's conformance tests |
| `Or(bool?, bool?)` | 5.3.0.0 ([#1514](https://github.com/FirelyTeam/firely-cql-sdk/issues/1514)) | lifted `\|` behind a short-circuit guard | Reference implementation for the lowering's conformance tests |
| `Not(bool?)` | 5.3.0.0 ([#1514](https://github.com/FirelyTeam/firely-cql-sdk/issues/1514)) | lifted `!` | Reference implementation for the lowering's conformance tests |
| `Implies(bool?, bool?)` | 5.3.0.0 ([#1514](https://github.com/FirelyTeam/firely-cql-sdk/issues/1514)) | `!left \| right` behind a short-circuit guard | Reference implementation for the lowering's conformance tests. The spec permits the skip explicitly, unlike `and`/`or`: "implies may use short-circuit evaluation in the case that the first operand evaluates to false" (§9.B) |
| `And`/`Or` `Lazy<bool?>` overloads (3 + 1) | never emitted | — | Shipped as public API but no generator version ever bound them; the short-circuit guard made them redundant ([#1514](https://github.com/FirelyTeam/firely-cql-sdk/issues/1514)) |
| scalar coalesce (no dedicated member) | predates this ledger | native `??` | CQL's scalar `Coalesce(a, b, …)` has emitted C# `??` chains since the IR pipeline; the **list** overload `Coalesce<T>(IEnumerable<T>)` for `Coalesce({…})` is still bound and called |

## 1.3. When adding a row

When a pull request stops the generator from calling an `ICqlOperators` member:

1. Add the row here with the `GeneratorToolVersion` the PR bumps to.
2. Put a `<remarks>` on the member in
   [ICqlOperators.cs](../Cql/Cql.Runtime/Operators/ICqlOperators.cs) pointing at this ledger.
3. Record the change for consumers in a release-note fragment under
   [docs/releases/vnext/](releases/vnext/README.md).
4. Do **not** add `[Obsolete]` — supported generated artifacts still call the member, and the
   attribute would put unactionable warnings on every `ICqlOperators` implementer.
