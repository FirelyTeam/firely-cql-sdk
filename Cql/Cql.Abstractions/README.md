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

2. **Structured error metadata** — All raw facts that caused the error (e.g. a UCUM unit name, an expected calendar equivalent) are stored as typed properties on the struct, not embedded in an opaque string. A caller can inspect `((CqlException<MyCqlError>)ex).Error.Unit` programmatically without parsing the message text.

3. **Strongly-typed catch clauses** — Because each error kind is its own `TError` type parameter, error handlers can write `catch (CqlException<MyCqlError>)`, making catch clauses self-documenting and avoiding substring matching on message text.

4. **Future internationalization** — Because `GetMessage()` is a method on the struct, it can be overridden or replaced with a locale-aware implementation without changing throw sites. All the data needed to produce a translated message is already captured in the struct's properties. _(Internationalization is not yet implemented.)_

### Defining a new error type

Place the struct in the `Errors/` folder of the area that throws it, with namespace `<that area's namespace>.Errors`, and make it implement `ICqlEvaluationError` when the CQL specification requires the error to be signalled to the calling environment. The struct must hold the **metadata** (raw facts) as get-only properties, set by its constructor — `GetMessage()` constructs the human-readable string from that metadata on demand.

```csharp
// ✅ Correct — struct holds metadata; GetMessage() constructs the string lazily
public readonly record struct CqlArithmeticError : ICqlArithmeticError
{
    internal CqlArithmeticError(string unit, string calendarEquivalent)
    {
        Unit = unit;
        CalendarEquivalent = calendarEquivalent;
    }

    public string Unit { get; }
    public string CalendarEquivalent { get; }

    public string GetMessage() =>
        $"If a definite-quantity duration above days (or weeks) appears in a date/time arithmetic " +
        $"calculation, the evaluation will end and signal an error to the calling environment. " +
        $"Use '{CalendarEquivalent}' instead of UCUM unit '{Unit}'.";
}

// ❌ Wrong — do NOT pass a pre-built message string as a constructor argument
public readonly record struct CqlArithmeticError : ICqlEvaluationError
{
    internal CqlArithmeticError(string message) => Message = message;

    public string Message { get; }

    public string GetMessage() => Message;  // anti-pattern: message built at throw site
}
```

> **Note:** When all metadata is fully encoded in the type name (e.g. `CqlUcumYearArithmeticError` always refers to unit `"a"`), a parameterless struct is acceptable. The rule is: never pass a pre-formatted message string — all variable information must be in typed properties.

### Throwing and catching

```csharp
// Throwing:
throw new CqlArithmeticError("a", "year").ToException();

// Catching a specific error type:
catch (CqlException<CqlArithmeticError> ex)
{
    string unit = ex.Error.Unit;              // structured metadata
    string msg  = ex.Error.GetMessage();      // human-readable string, built on demand
}

// Catching any CQL evaluation error, but not a failure inside the SDK:
catch (CqlException ex) when (ex.Error is ICqlEvaluationError)
{
    var frames = ex.EvaluationFrames;         // the CQL definitions being evaluated, innermost first
}

// Any other exception thrown during evaluation, such as one from a data source, carries the same frames:
catch (Exception ex)
{
    var frames = ex.GetCqlEvaluationFrames();
}
```

### File structure conventions

- **Exception machinery** (`ICqlError`, `ICqlEvaluationError`, `ICqlArithmeticError`, `CqlException`, `CqlException<TError>`, `CqlErrorExtensions`, `CqlEvaluationFrame`) lives in `Exceptions/`, namespace `Hl7.Cql.Exceptions`.
- **Every public error value** lives in an `Errors/` folder of the area that throws or returns it, with namespace `<namespace of that area>.Errors`, as `Cql.Invocation/Toolkit/Errors/` does with `Hl7.Cql.Invocation.Toolkit.Errors`. In this project, an error the primitives throw goes in `Primitives/Errors/`, namespace `Hl7.Cql.Primitives.Errors`. Internal errors, such as those in `Exceptions/Errors.cs`, may stay in the namespace of the code that uses them.
- All public error types must be registered in `PublicAPI.Unshipped.txt`.

## Further Reading

This package is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). For getting started, release notes, and contribution guidelines, see the [main README](../../README.md).
