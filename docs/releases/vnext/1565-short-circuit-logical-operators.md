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
- `and`/`or`/`not` now compile to C#'s lifted `&`/`|`/`!` operators over `bool?` — whose semantics
  are exactly CQL's three-valued logic — instead of `ICqlOperators.And`/`Or`/`Not` calls. Those
  runtime methods (including the `Lazy<bool?>` overloads) remain public API but are no longer
  referenced by generated code; their lifecycle is tracked in the
  [generated-code operator ledger](../../generated-code-operator-ledger.md). `GeneratorToolVersion` is now 5.3.0.0; previously
  generated libraries keep working unchanged. (#1514)
- The generated short-circuit guards carry traceability comments naming the operator and its CQL
  source span, e.g. `// CQL 'and' (33:5-33:57): right operand skipped when left is false`.
- The Packager CLI's `--cs-namespace` option now takes effect. It had been silently ignored since
  its introduction (its value never reached the configuration key), so generated code always ended
  up without a namespace; anyone who passed it will now get the namespace they asked for — which
  changes the generated types' identities and is why this is listed as potentially breaking.
  (The `CqlToFhirCommand.CSharpNamespace` record property was renamed to `CsNamespace` as part of
  this fix, to match System.CommandLine's kebab-to-Pascal option binding.)

## New Public API

- New `ElmToolkitConfig.CSharpGeneratingConfig` groups C#-generation formatting settings; its
  `PreferNoElseBlocks` (default `false`) prints generated conditionals whose branches all exit
  guard-clause style — plain sequential `if` blocks with the final value flat after them — instead
  of `if`/`else` chains. Formatting only; emitted behavior is identical. Configurable from the CQL
  packager's `appsettings.json` under `Elm:CSharpGeneratingConfig:PreferNoElseBlocks`.
- `CSharpGeneratingConfig.CSharpNamespace` is the new canonical home of the generated-code
  namespace setting (packager key `Elm:CSharpGeneratingConfig:CSharpNamespace`). The flat
  `ElmToolkitConfig.CSharpNamespace` keeps working as a backwards-compatible fallback — a value in
  the nested config wins — and will be removed at the next major release.
