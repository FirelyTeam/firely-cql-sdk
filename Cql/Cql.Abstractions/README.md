# HL7.Cql.Abstractions

A support package for HL7.Cql that contains shared interfaces and abstractions for CQL.

## Overview

This package provides the foundational interfaces and base abstractions used throughout the CQL SDK. It defines core contracts for data handling, type systems, and runtime behavior that other CQL components depend on.

## Key Features

- Core interfaces for CQL runtime operations
- Type system abstractions
- Shared base classes and utilities
- Internal APIs for cross-package integration

## Usage

This package is typically referenced as a dependency by other CQL packages rather than used directly. It provides the foundational types that enable interoperability between different components of the CQL SDK.

## Dependencies

- **Iso8601**: For ISO 8601 date/time handling

## CQL Evaluation Exceptions

This package defines the exception infrastructure for all errors that occur during CQL expression evaluation.

### Why structs instead of plain exceptions?

The SDK uses an `ICqlError` struct as the _payload_ of a `CqlException<TError>` rather than throwing a plain `new SomeException("message string")`. This design was chosen for four reasons:

1. **Lazy message construction** — The human-readable string is _not_ built at the throw site. `GetMessage()` is only called when the exception message is actually read (e.g. when logging or displaying). This avoids unnecessary string allocations for errors that are caught and handled without ever inspecting the message.

2. **Structured error metadata** — All raw facts that caused the error (e.g. a unit name, an expected calendar equivalent) are stored as typed properties on the struct. A caller can inspect `((CqlException<CqlUcumYearArithmeticError>)ex).Error` programmatically without parsing an opaque string.

3. **Strongly-typed catch clauses** — Because each error kind is its own `TError` type parameter, error handlers can write `catch (CqlException<CqlUcumYearArithmeticError>)`, making catch clauses self-documenting and avoiding substring matching on message text.

4. **Future internationalization** — Because `GetMessage()` is a method on the struct, it can be overridden or replaced with a locale-aware implementation without changing throw sites. All the data needed to produce a translated message is already captured in the struct's properties. _(Internationalization is not yet implemented.)_

### Usage pattern

**Defining a new error type** (in the `Errors.cs` of the folder containing the throw site):

```csharp
// ✅ Correct — struct holds metadata, GetMessage() constructs the string
public readonly record struct CqlUcumYearArithmeticError : ICqlArithmeticError
{
    public string GetMessage() =>
        "If a definite-quantity duration above days (or weeks) appears in a " +
        "date/time arithmetic calculation, the evaluation will end and signal " +
        "an error to the calling environment. Use 'year' or 'years' instead of UCUM unit 'a'.";
}

// ❌ Wrong — do NOT pass a pre-built message string as a constructor argument
public readonly record struct MyError(string Message) : ICqlError
{
    public string GetMessage() => Message;   // anti-pattern
}
```

**Throwing:**

```csharp
throw new CqlUcumYearArithmeticError().ToException();
```

**Catching:**

```csharp
catch (CqlException<CqlUcumYearArithmeticError> ex)
{
    // access structured metadata:
    Console.WriteLine(ex.Error.GetMessage());
}

// or catch any CQL evaluation error:
catch (CqlException ex) { ... }
```

### File structure conventions

- **Exception infrastructure** (`ICqlError`, `CqlException`, `CqlException<TError>`, `CqlErrorExtensions`, `ICqlArithmeticError`) lives in `Exceptions/`, namespace `Hl7.Cql.Exceptions`.
- **`Cql.Abstractions` is special**: each direct sub-folder has its own `Errors.cs` containing all `ICqlError` structs used by code in that folder. The namespace of each `Errors.cs` matches the folder's namespace:
  - `Exceptions/Errors.cs` → `namespace Hl7.Cql.Exceptions` (internal infrastructure errors)
  - `Primitives/Errors.cs` → `namespace Hl7.Cql.Primitives` (errors thrown by primitive types such as `CqlDate`, `CqlDateTime`)
- Add a new `FolderName/Errors.cs` when adding errors used by types in a new folder.
- All public error types must be registered in `PublicAPI.Unshipped.txt`.

## Further Reading

This package is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). For getting started, release notes, and contribution guidelines, see the [main README](../../README.md). More information can be found at [Firely's documentation site](https://docs.fire.ly/projects/Firely-NET-SDK/en/latest/cql.html).