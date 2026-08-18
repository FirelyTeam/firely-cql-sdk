## Potentially Breaking

- Generated C# now short-circuits CQL's `and`/`or`: the right operand is only evaluated when the
  left operand has not already decided the result (`false` for `and`, `true` for `or`; a `null`
  left operand still evaluates the right, as three-valued logic requires). Additionally, a
  deciding *constant* operand on either side folds at build time — `X and false` compiles to
  `false` and `X or true` to `true`, cascading through nested chains — which skips the other
  operand's evaluation entirely. Expression *values* are unchanged in all cases, but side
  effects of a skipped operand no longer occur: a runtime error it would have thrown no longer
  surfaces, and a `Message()` call inside it no longer raises `MessageReceived`. The CQL
  specification permits this (evaluation of logical operands is not prescribed). (#1514)
- Evaluation counts move in **both** directions, so the change is not uniformly cheaper. A right
  operand too large to inline moves into a hoisted local function whose body deliberately does not
  reach out to an enclosing local — that would turn it into captured closure state and allocate — so
  a subexpression the enclosing scope already computed is emitted again inside the function.

  Measured across every checked-in generated corpus, `develop` against this branch as it now stands
  (emitted **call sites**, not runtime executions):

  | call | develop | now | delta |
  |---|---|---|---|
  | `FHIRHelpers…ToValue` | 4,159 | 1,315 | **−2,844** |
  | `Operators.And` | 2,092 | 0 | −2,092 |
  | `Operators.Not` | 958 | 0 | −958 |
  | `Operators.Or` | 739 | 0 | −739 |
  | `Operators.LateBoundProperty` | 603 | 459 | −144 |
  | `Operators.Implies` | 37 | 0 | −37 |
  | `Operators.IsTrue` | 9 | 0 | −9 |
  | `FHIRHelpers…ToInterval` | 1,446 | 1,714 | **+268** |
  | `FHIRHelpers…ToConcept` | 580 | 761 | +181 |
  | `Operators.Start` | 1,189 | 1,329 | +140 |
  | `Operators.End` | 794 | 863 | +69 |
  | `Operators.Retrieve` | 2,307 | 2,335 | **+28** |
  | `Operators.ConvertIntegerToDecimal` | 199 | 225 | +26 |
  | | | **net** | **−6,020** |

  The two directions have different causes. The large decreases are the operators this change
  lowers natively (`And`/`Or`/`Not`/`Implies`/`IsTrue` become C# operators and disappear as calls),
  plus **`ToValue` losing 2,844 call sites to a dedup fix**: a branch scope used to recompute
  whatever its enclosing scope had already hoisted, so `ToValue(context, x?.Performed)` was emitted
  once above an `if` and identically again inside it. Branch scopes now reuse the enclosing local.
  That fix came out of review feedback on this PR.

  The increases are the local-function cost: a right operand too large to inline moves into a
  hoisted function whose body deliberately does not reach an enclosing local, so a subexpression the
  enclosing scope already has is emitted again inside it.

  **Correcting an earlier claim in this fragment:** it previously stated that `Operators.Retrieve<`
  landed at exactly its previous count and that no additional FHIR retrieve was emitted anywhere.
  That was true of the interim guarded shape and is **no longer true** — it is +28 sites across 8
  files, concentrated in two (+14 each). Most of the added sites sit inside local functions, whose
  bodies run only when the operator does not skip, so this is not necessarily +28 retrieves at run
  time; but the emitted count did move and the previous wording overstated the guarantee. No
  `Message()` call site is duplicated in any library.

  Generated code grows by **7,126 net lines** across 153 files, of which roughly 1.1k is the new
  test fixture rather than shipped library code. (#1514)
- `xor` now short-circuits too — on a **null** left operand, which makes it the odd one out.
  Its null row is constant ("if either or both arguments are null, the result is null"), so a null
  left operand decides the result and the right operand is skipped; a `true` or `false` left
  operand decides nothing and still evaluates the right (`false xor X` is `X`, `true xor X` is
  `not X`). A null constant on either side folds to `null` at build time, erasing the other
  operand. It lowers to C#'s lifted `^`, which propagates null exactly as CQL requires, instead of
  an `ICqlOperators.Xor` call. Same skipped-side-effect disclosure as `and`/`or`. (#1514)
- `IsTrue`/`IsFalse` now compile to the `is true`/`is false` constant patterns instead of
  `ICqlOperators` calls. No behavior change: they are total predicates, so a null argument still
  yields `false` and there is nothing to short-circuit. `ICqlOperators.IsTrue`/`IsFalse` keep
  returning `bool?` for operator-binding uniformity and remain public API. (#1514)
- `implies` now short-circuits as well, and lowers to `!left | right` (which is exactly Kleene
  implication) instead of an `ICqlOperators.Implies` call. Its right operand is skipped when the
  left operand is false, since `false implies X` is `true` for every `X` — and unlike `and`/`or`,
  the specification calls this skip out explicitly: "implies may use short-circuit evaluation in
  the case that the first operand evaluates to false" (§9.B). A `true` or `null` left operand
  still evaluates the right operand (`null implies true` is `true`). The same side-effect
  disclosure applies: an error or `Message()` in a skipped right operand no longer occurs. (#1514)
- `and`/`or`/`not` now compile to C#'s lifted `&`/`|`/`!` operators over `bool?` — whose semantics
  are exactly CQL's three-valued logic — instead of `ICqlOperators.And`/`Or`/`Not` calls. Those
  runtime methods (including the `Lazy<bool?>` overloads) remain public API but are no longer
  referenced by generated code; their lifecycle is tracked in the
  [generated-code operator ledger](../../generated-code-operator-ledger.md). `GeneratorToolVersion` was bumped
  (see [1574-cqlboolean-lowering.md](1574-cqlboolean-lowering.md) for the version this stack lands
  on); previously generated libraries keep working unchanged. (#1514)
- The generated short-circuit guards carry traceability comments naming the operator and its CQL
  source span, e.g. `// CQL 'and' (33:5-33:57): right operand skipped when left is false`.
