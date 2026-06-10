# 10. CQL Evaluation Exceptions

## 10.0 Rationale

10.0.1 Why use ICqlError structs instead of plain .NET exceptions?

The Firely CQL SDK uses a struct-based error pattern (ICqlError + CqlException<TError>) rather than conventional new SomeException("message") throws. This design was chosen for four reasons:

10.0.1.1 Lazy message construction: human-readable message is not built at throw site. It is built on demand inside GetMessage().

10.0.1.2 Structured error metadata: raw facts are stored as typed properties on the struct, not embedded in opaque strings.

10.0.1.3 Strongly-typed catch clauses: each error kind is a type parameter on CqlException<TError>.

10.0.1.4 Future internationalization: GetMessage() can be localized later without changing throw sites.

## 10.1 Exception Hierarchy

10.1.1 Two exception types are defined in Hl7.Cql.Abstractions for errors raised during CQL evaluation:

- CqlException (Hl7.Cql.Exceptions): public abstract base exception with message derived from ICqlError payload
- CqlException<TError> (Hl7.Cql.Exceptions): generic concrete exception wrapping strongly-typed ICqlError payload

10.1.2 To define a new CQL evaluation error, create a public readonly record struct implementing ICqlError.

Important: struct should accept metadata (raw facts) as constructor parameters, not pre-built message strings. GetMessage() constructs the human-readable message.

```csharp
public readonly record struct CqlArithmeticError(string Unit, string CalendarEquivalent) : ICqlError
{
    public string GetMessage() =>
        $"If a definite-duration time-valued unit above days (or weeks) appears in a date/time arithmetic " +
        $"calculation, the evaluation will end and signal an error to the calling environment. " +
        $"Use '{CalendarEquivalent}' instead of UCUM unit '{Unit}'.";
}

public readonly record struct CqlArithmeticErrorBad(string Message) : ICqlError
{
    public string GetMessage() => Message;
}

throw new CqlArithmeticError("a", "year").ToException();
catch (CqlException<CqlArithmeticError> e) { }
```

## 10.2 When to Use CqlException

10.2.1 Always create a specific ICqlError struct and throw it as CqlException<TError> for exceptions raised during evaluation of CQL expressions, instead of general .NET exceptions.

10.2.2 Examples:

- Spec-mandated errors during date or time arithmetic (for example, CqlUcumYearArithmeticError, CqlUcumMonthArithmeticError)
- Type mismatch errors at evaluation time
- Division by zero or other arithmetic failures
- Any error where the CQL specification says to signal an error to the calling environment

10.2.3 General .NET exceptions (ArgumentException, InvalidOperationException) are still appropriate for programming errors, such as invalid method arguments.

## 10.3 Key Points

10.3.1 Exception infrastructure (ICqlError, ICqlArithmeticError, CqlException, CqlException<TError>, CqlErrorExtensions) lives in Cql/Cql.Abstractions/Exceptions with namespace Hl7.Cql.Exceptions.

10.3.2 Cql.Abstractions is a special project using one Errors.cs file per direct folder, containing all ICqlError structs used within that folder code. Namespace of each Errors.cs matches folder namespace.

- Cql/Cql.Abstractions/Exceptions/Errors.cs uses namespace Hl7.Cql.Exceptions for internal infrastructure errors
- Cql/Cql.Abstractions/Primitives/Errors.cs uses namespace Hl7.Cql.Primitives for primitive type errors
- Add a new FolderName/Errors.cs when adding errors used by types in a new folder

10.3.3 New ICqlError structs should be placed in the Errors.cs file of the folder containing throw site, and registered in Cql/Cql.Abstractions/PublicAPI.Unshipped.txt.
