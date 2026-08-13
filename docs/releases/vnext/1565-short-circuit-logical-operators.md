## Changed

- Generated C# now short-circuits CQL's `and`/`or`: the right operand is only evaluated when the
  left operand has not already decided the result (`false` for `and`, `true` for `or`; a `null`
  left operand still evaluates the right, as three-valued logic requires). Expression *values* are
  unchanged, but two side effects of a skipped right operand no longer occur: a runtime error it
  would have thrown no longer surfaces, and a `Message()` call inside it no longer raises
  `MessageReceived`. The CQL specification permits both. (#1514)
- `and`/`or`/`not` now compile to C#'s lifted `&`/`|`/`!` operators over `bool?` — whose semantics
  are exactly CQL's three-valued logic — instead of `ICqlOperators.And`/`Or`/`Not` calls. Those
  runtime methods (including the `Lazy<bool?>` overloads) remain public API but are no longer
  referenced by generated code; their lifecycle is tracked in
  `docs/generated-code-operator-ledger.md`. `GeneratorToolVersion` is now 5.2.2.0; previously
  generated libraries keep working unchanged. (#1514)
- The generated short-circuit guards carry traceability comments naming the operator and its CQL
  source span, e.g. `// CQL 'and' (33:5-33:57): right operand skipped when left is false`.

## Features

- New `ElmToolkitConfig.CSharpGeneratingConfig` groups C#-generation formatting settings; its
  `PreferFlattenElseBlocks` (default `false`) prints generated conditionals whose branches all exit
  guard-clause style — plain sequential `if` blocks with the final value flat after them — instead
  of `if`/`else` chains. Formatting only; emitted behavior is identical. Configurable from the CQL
  packager's `appsettings.json` under `Elm:CSharpGeneratingConfig:PreferFlattenElseBlocks`.
