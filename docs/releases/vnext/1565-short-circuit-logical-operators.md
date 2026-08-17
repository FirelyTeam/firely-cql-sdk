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
- Side effects can also move in the *other* direction, in a small number of shapes. A guarded
  branch reuses values its enclosing block already computed, but a few positions cannot — a
  hoisted local function's body deliberately does not reach out to an enclosing local, and a
  guard test that prints inline is not itself hoisted — so a subexpression shared between the two
  operands may be evaluated twice there. Measured across the checked-in corpora the net effect is
  at or below the previous output for every operator (`Operators.Start` is 2 calls fewer,
  `End`/`Retrieve<` 4 more each, out of 1187/798/2311), and the repeats are property reads and
  cheap accessors rather than retrieves. Where such a subexpression contains a `Message()`, that
  message can be raised more than once. (#1514)
- `implies` now short-circuits as well, and lowers to `!left | right` (which is exactly Kleene
  implication) instead of an `ICqlOperators.Implies` call. Its right operand is skipped when the
  left operand is false, since `false implies X` is `true` for every `X` — and unlike `and`/`or`,
  the specification calls this skip out explicitly: "implies may use short-circuit evaluation in
  the case that the first operand evaluates to false" (§9.B). A `true` or `null` left operand
  still evaluates the right operand (`null implies true` is `true`). The same side-effect
  disclosure applies: an error or `Message()` in a skipped right operand no longer occurs.
  `xor` is unchanged — every row of its truth table varies with the right operand. (#1514)
- `and`/`or`/`not` now compile to C#'s lifted `&`/`|`/`!` operators over `bool?` — whose semantics
  are exactly CQL's three-valued logic — instead of `ICqlOperators.And`/`Or`/`Not` calls. Those
  runtime methods (including the `Lazy<bool?>` overloads) remain public API but are no longer
  referenced by generated code; their lifecycle is tracked in the
  [generated-code operator ledger](../../generated-code-operator-ledger.md). `GeneratorToolVersion` is now 5.3.0.0; previously
  generated libraries keep working unchanged. (#1514)
- The generated short-circuit guards carry traceability comments naming the operator and its CQL
  source span, e.g. `// CQL 'and' (33:5-33:57): right operand skipped when left is false`.
