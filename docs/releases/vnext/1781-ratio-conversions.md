## Fixes

- `ToRatio(String)`, `ConvertsToRatio(Any)` and `ToQuantity(Ratio)` are available. `ToRatio` and
  `ConvertsToRatio` used to fail CQL-to-ELM translation as unknown functions, and `ToQuantity` on a
  ratio failed C# generation. `ToRatio('1.0 \'mg\':2.0 \'mg\'')` is `1.0 'mg':2.0 'mg'`, a quantity
  without a unit takes the default unit `'1'` (`ToRatio('1:128')` is `1:128`), and a string that is
  not two quantities separated by a colon is null (`ToRatio('1.0 \'mg\';2.0 \'mg\'')`).
  `ConvertsToRatio` is true for a ratio and for a string `ToRatio` accepts. `ToQuantity` of a ratio
  divides the numerator by the denominator, as `/` on quantities does, so `ToQuantity(6 'mg':2 'mL')`
  equals `3 'mg/mL'` and a zero denominator gives null. `convert '1:2' to Ratio` converts like
  `ToRatio` instead of throwing "No conversion from System.String to CqlRatio is defined".
  `ICqlOperators` has the new members `ConvertStringToRatio`, `ConvertsToRatio` and
  `ConvertRatioToQuantity`.
- `CqlRatio.TryParse` accepts the format the specification gives for `ToRatio`: each quantity is an
  optionally signed number with an optional quoted unit, and a colon inside a quoted unit does not
  split the ratio. Unquoted units are rejected and a quantity without a unit is accepted.
- Generated C# for existing libraries is unchanged (no `GeneratorToolVersion` change) and so are
  existing evaluation results: these conversions previously failed to translate, compile or run.
