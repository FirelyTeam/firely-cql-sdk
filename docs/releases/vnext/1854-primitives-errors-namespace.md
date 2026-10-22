## Breaking

- **Runtime** — The three error types that were still in `Hl7.Cql.Primitives` move to the `Errors` namespace of the
  area that throws them, where the SDK's other error types are:
  - `Hl7.Cql.Primitives.CqlUcumYearArithmeticError` is now `Hl7.Cql.Primitives.Errors.CqlUcumYearArithmeticError`,
    still in `HL7.Cql.Abstractions`.
  - `Hl7.Cql.Primitives.CqlUcumMonthArithmeticError` is now `Hl7.Cql.Primitives.Errors.CqlUcumMonthArithmeticError`,
    still in `HL7.Cql.Abstractions`.
  - `Hl7.Cql.Primitives.CqlPointFromNonUnitIntervalError` is now
    `Hl7.Cql.Operators.Errors.CqlPointFromNonUnitIntervalError`, in `Hl7.Cql.Runtime` instead of
    `HL7.Cql.Abstractions`.

  Code that names one of them, such as `catch (CqlException<CqlUcumYearArithmeticError> e)`, adds
  `using Hl7.Cql.Primitives.Errors;` or `using Hl7.Cql.Operators.Errors;`, or spells out the new full name, and is
  recompiled; an assembly compiled against an earlier version does not find the old types. A host that catches
  `CqlException` with `when (e.Error is ICqlEvaluationError)` needs no change. (#1844)
- **Runtime** — `CqlPointFromNonUnitIntervalError` is no longer a positional record: its constructor is `internal`,
  it has no `Deconstruct`, and `Low`, `High`, `LowClosed` and `HighClosed` are get-only. Code that deconstructed it
  reads the properties instead. (#1844)
