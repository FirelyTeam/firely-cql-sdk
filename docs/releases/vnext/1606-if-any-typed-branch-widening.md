## Potentially Breaking

- **CQL-to-ELM translator:** an `if` whose `else` branch is typed `Any` — from a call to an
  undefined function under `AllowUnresolvedExternals`, from `Message(null, ...)`, or any other
  expression the translator could not resolve to a more specific type — is no longer typed `Any`
  itself when the `then` branch has a concrete type. A define written that way now generates C#
  typed as that concrete type instead of `object`. Only defines containing this exact pattern are
  affected; every other define generates exactly as before. A `then` branch typed `Any` is
  unaffected and continues to make the whole conditional `Any`, since `Any` is a real static type in
  its own right (a function declared `returns Any` is `Any` at every call site regardless of what
  its body evaluates to) and the specification makes the `then` branch's type govern unconditionally.
  (#1601)

## Fixes

- **CQL-to-ELM translator:** as above, an `if` whose `else` branch is typed `Any` no longer widens
  the `then` branch down to `Any` when `then` has a concrete type. `ElmFactory.If` special-cased this
  reconciliation only for a literal `null` branch; a non-null `Any`-typed `else` branch fell through
  to the general cost-based reconciliation below, which could judge coercing the well-typed `then`
  branch *up* to `Any` cheaper than coercing the `Any`-typed `else` branch down to it, and picked that
  direction. That is visible wherever the conditional feeds a typed consumer: a `such that` clause's
  relationship lambda expects `Func<T, bool?>`, and a `such that` built from this pattern produced
  `Func<T, object>` instead, which the C# compiler has no overload to bind
  (`CannotBindToCqlOperatorError`). The `then` branch's static type now governs whenever `else` is
  `Any`-typed, matching how a literal `null` branch has always been handled and the semantics the CQL
  specification's *If* section requires: "The static type of the `then` argument determines the
  result type of the conditional, and the `else` argument must be of that same type." This
  generalization is one-directional: an `Any`-typed `then` branch is not the same situation, and
  coercing it down to a concretely-typed `else` branch would silently null out any `then` value that
  doesn't happen to fit the `else` branch's type — the same class of defect #1594 fixed for `Choice`
  branches. (#1601)
