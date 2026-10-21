## New Public API

- **Runtime** — `ICqlEvaluationError`, in `Hl7.Cql.Exceptions`, marks the errors the CQL specification requires to be
  signalled to the calling environment during evaluation. `ICqlArithmeticError` now derives from it, and
  `CqlPointFromNonUnitIntervalError` implements it. A host tells an evaluation error from a failure inside the SDK with
  `catch (CqlException e) when (e.Error is ICqlEvaluationError)`. (#812, #1845)
- **Runtime** — `CqlException.EvaluationFrames` lists the CQL definitions that were being evaluated when the exception
  was thrown, innermost first, as `CqlEvaluationFrame` values: library name, library version and definition name. Any
  other exception thrown during evaluation carries the same frames in its `Data`. (#812, #1845)

## Improvements

- **Runtime** — The message of a `CqlException` thrown during evaluation ends with the definition it was thrown in, for
  example "Thrown while evaluating definition 'Point' of library 'Inner' version '1.0.0'." A function called from a
  definition is reported as that definition; a function the host invokes directly is reported as itself. Generated C#
  and `GeneratorToolVersion` are unchanged. (#812, #1845)
- **Runtime** — The remarks of `ICqlArithmeticError` gave a catch clause that never matches; they now give
  `catch (CqlException e) when (e.Error is ICqlArithmeticError)`. (#1845)
