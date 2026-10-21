# Cql.Abstractions

See the root [CLAUDE.md](../../CLAUDE.md) for when to use `CqlException<TError>` vs plain .NET exceptions.

Error types follow one rule across the repository:

- **`Hl7.Cql.Exceptions`** (`Exceptions/`) keeps the exception machinery: `CqlException`, `CqlException<TError>`, `CqlErrorExtensions`, `CqlEvaluationFrame`, and `ICqlError` with the interfaces that derive from it (`ICqlEvaluationError`, `ICqlArithmeticError`).
- **Every public `ICqlError` value** lives in an `Errors/` folder of the area that throws or returns it, with namespace `<namespace of that area>.Errors`. In this project, errors the primitives throw go in `Primitives/Errors/`, namespace `Hl7.Cql.Primitives.Errors`. Elsewhere, for example, `Cql.Runtime/Operators/Errors/` → `Hl7.Cql.Operators.Errors` and `Cql.Invocation/Toolkit/Errors/` → `Hl7.Cql.Invocation.Toolkit.Errors`. This holds whether the error is thrown inside a `CqlException` or returned as a value. Internal errors, such as those in `Exceptions/Errors.cs`, may stay in the namespace of the code that uses them.
- **An error the CQL specification requires to be signalled to the calling environment during evaluation** implements `ICqlEvaluationError`, directly or through an interface derived from it such as `ICqlArithmeticError`. That is how a host tells it from a failure inside the SDK: `catch (CqlException e) when (e.Error is ICqlEvaluationError)`.

A public error struct must also be registered in `PublicAPI.Unshipped.txt`.
