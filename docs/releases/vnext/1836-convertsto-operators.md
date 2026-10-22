## Fixes

- **Runtime** — the `ConvertsToBoolean`, `ConvertsToDate`, `ConvertsToDateTime`, `ConvertsToDecimal`,
  `ConvertsToInteger`, `ConvertsToLong`, `ConvertsToQuantity`, `ConvertsToString` and `ConvertsToTime` operators
  follow the CQL specification. Each is true when its argument already is of the target type or the matching `To*`
  conversion gives a non-null result for it, false for any other argument, and null for null. They used to return
  false for almost every Boolean, Integer, Long and Decimal argument and for an argument of the target type itself, and
  true for any string whether or not it converts. `ConvertsToBoolean` of an Integer, Long or Decimal is true only for 0
  and 1, and `ConvertsToInteger` of a Long only within the Integer range. Each operator gives the answer of the
  runtime's matching `To*` conversion, so where that conversion departs from the specification, the operator departs
  with it: `ConvertsToDateTime('2014-01-01T25:00:00Z')` throws, and `ConvertsToTime('25:00:00')` and
  `ConvertsToQuantity` of the string `5 'foo'` are true. The change reaches any library that calls these operators,
  such as ELM from another translator. (#1829, #1836)

This changes CQL evaluation results for the affected expressions. Generated C# and `GeneratorToolVersion` are unchanged.
