## Fixes

- A FHIR primitive's `value` is read as the System type the model declares even where the
  expression expects a wider type. After narrowing a choice with `is`, such as
  `when R is FHIR.dateTime then R.value` in a `case` over `Condition.onset`, the value of a `dateTime`
  evaluated to the `FhirDateTime` itself instead of a `System.DateTime`. This moves the result of CQL
  that reaches the case,
  though no library in the checked-in corpora does, and changes `GeneratorToolVersion` to `6.0.2.0`.
  (#1719, #1721)
