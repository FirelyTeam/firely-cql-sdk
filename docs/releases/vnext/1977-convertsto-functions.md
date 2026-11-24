## Fixes

- **CQL to ELM translation** — `ConvertsToBoolean`, `ConvertsToDate`, `ConvertsToDateTime`, `ConvertsToDecimal`,
  `ConvertsToInteger`, `ConvertsToLong`, `ConvertsToQuantity`, `ConvertsToString`, `ConvertsToTime` and
  `CanConvertQuantity(argument, unit)`, which reported "could not resolve function", now translate and evaluate per
  CQL §9.B. This changes CQL evaluation results for those expressions. `GeneratorToolVersion` is unchanged: generated
  code calls the existing `ICqlOperators` members (#1977).
