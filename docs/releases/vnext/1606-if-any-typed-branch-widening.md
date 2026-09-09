## Potentially Breaking

- **CQL-to-ELM translator:** an `if` whose `then` or `else` branch is typed `Any` — from a call to
  an undefined function under `AllowUnresolvedExternals`, from `Message(null, ...)`, or any other
  expression the translator could not resolve to a more specific type — is no longer typed `Any`
  itself when the other branch has a concrete type. A define written that way now generates C# typed
  as that concrete type instead of `object`. Only defines containing this exact pattern are
  affected; every other define generates exactly as before. (#1601)

## Fixes

- **CQL-to-ELM translator:** as above, an `if` whose `then` or `else` branch is typed `Any` no
  longer widens the other, meaningfully-typed branch down to `Any`. `ElmFactory.If` special-cased
  this reconciliation only for a literal `null` branch; any other `Any`-typed branch fell through to
  the general cost-based reconciliation below, which could judge coercing the well-typed branch *up*
  to `Any` cheaper than coercing the `Any`-typed branch down to it, and picked that direction. That
  is visible wherever the conditional feeds a typed consumer: a `such that` clause's relationship
  lambda expects `Func<T, bool?>`, and a `such that` built from this pattern produced
  `Func<T, object>` instead, which the C# compiler has no overload to bind
  (`CannotBindToCqlOperatorError`). The non-`Any` branch's static type now governs whenever the other
  branch is `Any`-typed, in both directions, matching how a literal `null` branch has always been
  handled and the semantics the CQL specification's *If* section requires: "The static type of the
  `then` argument determines the result type of the conditional, and the `else` argument must be of
  that same type." (#1601)
