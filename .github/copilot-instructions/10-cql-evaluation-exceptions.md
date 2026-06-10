## 10. CQL Evaluation Exceptions

### 10.0 Rationale

10.0.1 **Why use `ICqlError` structs instead of plain .NET exceptions?**

The Firely CQL SDK uses a struct-based error pattern (`ICqlError` + `CqlException<TError>`) rather than conventional `new SomeException("message")` throws. This design was chosen for four reasons:

10.0.1.1 **Lazy message construction** — The human-readable message string is _not_ constructed at the throw site. It is constructed on demand inside `GetMessage()`, only when the exception message is actually read (e.g. when logging or displaying the error). This avoids unnecessary string allocations for errors that may be caught and handled without inspecting the message.

10.0.1.2 **Structured error metadata** — All the raw facts that caused the error (e.g. the UCUM unit name, the expected calendar equivalent) are stored as typed properties on the struct, not embedded in an opaque string. Callers can inspect `((CqlException<CqlArithmeticError>)ex).Error.Unit` programmatically without parsing the message.

10.0.1.3 **Strongly-typed catch clauses** — Because each error kind is its own type parameter on `CqlException<TError>`, error handlers can catch `CqlException<CqlUcumYearArithmeticError>` specifically, making catch clauses self-documenting and avoiding substring matching on message text.

10.0.1.4 **Future internationalization** — Because `GetMessage()` is a method on the struct, it can be overridden or replaced with a locale-aware implementation in the future without changing throw sites. All the data needed to produce a translated message is already captured in the struct's properties. (Internationalization is not yet implemented.)

### 10.1 Exception Hierarchy

10.1.1 Two exception types are defined in `Hl7.Cql.Abstractions` (assembly `Hl7.Cql.Abstractions`) for errors raised during CQL evaluation:

- **`CqlException`** (`Hl7.Cql.Exceptions`) — public abstract base exception; message is derived from an `ICqlError` payload
- **`CqlException<TError>`** (`Hl7.Cql.Exceptions`) — generic concrete exception wrapping a strongly-typed `ICqlError` struct payload

  10.1.2 To define a new CQL evaluation error, create a `public readonly record struct` implementing `ICqlError`.
  **IMPORTANT**: The struct must accept the **metadata** (raw facts like a unit name or value) as constructor parameters, NOT a pre-built message string. `GetMessage()` is responsible for constructing the human-readable message from that metadata:

```csharp
// ✅ CORRECT — struct holds metadata, GetMessage() constructs the message
public readonly record struct CqlArithmeticError(string Unit, string CalendarEquivalent) : ICqlError
{
    public string GetMessage() =>
        $"If a definite-duration time-valued unit above days (or weeks) appears in a date/time arithmetic " +
        $"calculation, the evaluation will end and signal an error to the calling environment. " +
        $"Use '{CalendarEquivalent}' instead of UCUM unit '{Unit}'.";
}

// ❌ WRONG — do NOT pass a pre-built message string
public readonly record struct CqlArithmeticError(string Message) : ICqlError
{
    public string GetMessage() => Message;  // anti-pattern
}

// Throw it:
throw new CqlArithmeticError("a", "year").ToException();
// Catch it:
catch (CqlException<CqlArithmeticError> e) { ... }
```

### 10.2 When to Use CqlException

10.2.1 **ALWAYS** create a specific `ICqlError` struct and throw it as `CqlException<TError>` for any exception that should be raised during the evaluation of a CQL expression, instead of using general .NET exceptions like `InvalidOperationException` or `ArgumentException`.

10.2.2 Examples of when to use `CqlException<TError>`:

- Spec-mandated errors during date/time arithmetic (e.g. `CqlUcumYearArithmeticError`, `CqlUcumMonthArithmeticError`)
- Type mismatch errors at evaluation time
- Division by zero or other arithmetic failures
- Any error the CQL spec says "signals an error to the calling environment"

  10.2.3 General .NET exceptions (`ArgumentException`, `InvalidOperationException`) are still appropriate for programming errors (e.g. invalid method arguments), as opposed to errors arising from evaluating CQL expressions at runtime.

### 10.3 Key Points

10.3.1 Exception infrastructure (`ICqlError`, `ICqlArithmeticError`, `CqlException`, `CqlException<TError>`, `CqlErrorExtensions`) lives in `Cql/Cql.Abstractions/Exceptions/`, namespace `Hl7.Cql.Exceptions`.

10.3.2 **`Cql.Abstractions` is a special project**: it uses one `Errors.cs` file **per direct folder**, containing all `ICqlError` structs used within that folder's code. The namespace of each `Errors.cs` matches the folder's namespace:

- `Cql.Abstractions/Exceptions/Errors.cs` → `namespace Hl7.Cql.Exceptions` (internal infrastructure errors)
- `Cql.Abstractions/Primitives/Errors.cs` → `namespace Hl7.Cql.Primitives` (errors thrown by primitive types like `CqlDate`, `CqlDateTime`)
- Add a new `FolderName/Errors.cs` when adding errors used by types in a new folder

  10.3.3 New `ICqlError` structs should be placed in the `Errors.cs` of the folder that contains the throw site, and registered in `Cql/Cql.Abstractions/PublicAPI.Unshipped.txt`.