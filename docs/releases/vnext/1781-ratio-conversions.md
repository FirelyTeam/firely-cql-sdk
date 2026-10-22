## Fixes

- **CQL to ELM translation, code generation and runtime** — `ToRatio(String)`, `ConvertsToRatio(Any)` and
  `ToQuantity(Ratio)` are available. `ToRatio` and `ConvertsToRatio` used to fail CQL-to-ELM translation as unknown
  functions, and `ToQuantity` on a ratio failed C# generation. `ToRatio('1.0 \'mg\':2.0 \'mg\'')` is
  `1.0 'mg':2.0 'mg'`, a quantity without a unit takes the default unit `'1'` (`ToRatio('1:128')` is `1:128`), and a
  string that is not two quantities separated by a colon is null (`ToRatio('1.0 \'mg\';2.0 \'mg\'')`).
  `ConvertsToRatio` is true for a ratio and for a string `ToRatio` accepts. `ToQuantity` of a ratio divides the
  numerator by the denominator, as `/` on quantities does, so `ToQuantity(6 'mg':2 'mL')` equals `3 'mg/mL'` and a
  zero denominator gives null. `convert '1:2' to Ratio` converts like `ToRatio` instead of throwing "No conversion
  from System.String to CqlRatio is defined".
- **Runtime** — `CqlRatio.TryParse` accepts the format the specification gives for `ToRatio`: each quantity is an
  optionally signed number with an optional quoted unit, and a colon inside a quoted unit does not split the ratio.
  Unquoted units are rejected and a quantity without a unit is accepted.
- **Code generator** — Generated C# for existing libraries is unchanged, and so are existing evaluation results: these
  conversions previously failed to translate, compile or run. `GeneratorToolVersion` is `6.2.0.0`: C# generated for
  `ToRatio` calls the new `ICqlOperators.ConvertStringToRatio`, which earlier runtimes lack.
  `LibraryInstanceInvoker_6_0` already accepts the new version, so no new invoker is needed.

## New Public API

- **Runtime** — `ICqlOperators.ConvertStringToRatio(string?)`, `ICqlOperators.ConvertsToRatio(object?)` and
  `ICqlOperators.ConvertRatioToQuantity(CqlRatio?)`. (#1777, #1781)

## Potentially Breaking

- **Runtime** — `ICqlOperators` gains `ConvertStringToRatio`, `ConvertsToRatio` and `ConvertRatioToQuantity` without
  default implementations, so a custom `ICqlOperators` implementation must add all three. (#1777, #1781)
