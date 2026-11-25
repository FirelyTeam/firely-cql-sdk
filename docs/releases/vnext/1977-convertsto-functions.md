## Potentially Breaking

- **CQL to ELM translation** — a library that defines its own function named `ConvertsToBoolean`, `ConvertsToDate`,
  `ConvertsToDateTime`, `ConvertsToDecimal`, `ConvertsToInteger`, `ConvertsToLong`, `ConvertsToQuantity`,
  `ConvertsToString`, `ConvertsToTime` or `CanConvertQuantity` can now have a call resolve to the system operator of
  that name instead. The library's function is still chosen when the argument types match its parameters exactly. A
  call that reaches it only through an implicit conversion, such as a `FHIR.string` argument for a `String` parameter,
  now resolves to the system operator, because any argument matches the operator's `Any` parameter at a lower cost.
  Rename the library's function, or cast the argument to the parameter type at the call, to keep calling it (#1977).

## Fixes

- **CQL to ELM translation** — `ConvertsToBoolean`, `ConvertsToDate`, `ConvertsToDateTime`, `ConvertsToDecimal`,
  `ConvertsToInteger`, `ConvertsToLong`, `ConvertsToQuantity`, `ConvertsToString`, `ConvertsToTime` and
  `CanConvertQuantity(argument, unit)`, which reported "could not resolve function", now translate and evaluate per
  CQL §9.B. This changes CQL evaluation results for those expressions. `GeneratorToolVersion` is unchanged: generated
  code calls the existing `ICqlOperators` members (#1977).
- **CQL to ELM translation** — a `ConvertsTo*` operator, `ConvertsToRatio` included, converts an argument of a model
  type to the System value its model converts it to implicitly before testing it, so `ConvertsToDate(Patient.birthDate)`
  tests the `Date` that `FHIRHelpers.ToDate` returns, and an argument of a choice type such as `Observation.value` is
  converted by the type its value has at run time. A model value that has no System value, such as a `FHIR.string`
  without a value or a `FHIR.Quantity` that `FHIRHelpers.ToQuantity` rejects, gives `false`. Without the conversion
  the operator returned `false` for every model value (#1977).
