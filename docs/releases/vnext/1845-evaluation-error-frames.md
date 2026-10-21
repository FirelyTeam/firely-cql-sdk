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
  example "Thrown while evaluating definition 'Point' of library 'Inner' version '1.0.0'." A function without
  operands has a frame of its own, like a definition; a function with operands has one only when the host invokes it
  directly, and is otherwise reported as the definition that called it. A sequence that a definition returns
  unread, such as a retrieve from a data source that reads lazily, is reported by the definition that reads it, or
  without frames when the host reads it. Generated C# and `GeneratorToolVersion` are unchanged. (#812, #1845)
- **Runtime** — The remarks of `ICqlArithmeticError` gave a catch clause that never matches; they now give
  `catch (CqlException e) when (e.Error is ICqlArithmeticError)`. (#1845)
