## Fixes

- **Runtime** — the `ConvertsToBoolean`, `ConvertsToDate`, `ConvertsToDateTime`, `ConvertsToDecimal`,
  `ConvertsToInteger`, `ConvertsToLong`, `ConvertsToQuantity`, `ConvertsToString` and `ConvertsToTime` operators
  follow the CQL specification. Each is true when its argument already is of the target type or the matching `To*`
  conversion gives a non-null result for it, false for any other argument, and null for null. They used to return
  false for almost every Boolean, Integer, Long and Decimal argument and for an argument of the target type itself, and
  true for any string whether or not it converts. `ConvertsToBoolean` of an Integer, Long or Decimal is true only for 0
  and 1, and `ConvertsToInteger` of a Long only within the Integer range. **CQL evaluation results change** for any
  library that calls these operators, such as ELM from another translator. (#1836)
