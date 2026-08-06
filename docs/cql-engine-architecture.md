# CQL Engine Architecture

## Overview

This engine operates by consuming an ELM representation of a CQL measure and takes the following steps:

1. Interpret the ELM tree and build a typed code model (IR) — a structured set of C#-shaped expression nodes
2. Print the code model to C# source code
3. Compile the C# source text to a .NET assembly using Roslyn

This approach has a number of key advantages over engines which simultaneously interpret the ELM and produce results.

### Key Advantages

- **Performance**: Once the generated C# has been compiled into an assembly, the original ELM is no longer necessary. The executable code runs at full .NET speed without re-examining the ELM on each evaluation.

- **Optimization**: The generated code benefits from the full .NET JIT compilation pipeline, including inlining, loop unrolling, and the JIT's hardware-specific optimizations — something an ELM interpreter cannot easily match.

- **Integration**: Once CQL libraries are compiled into assemblies, they can be referenced by ordinary .NET projects covering a wide range of use cases: web services, console applications, Azure Functions, etc.

- **Debuggability**: The generated C# source code is human-readable procedural code with local variables and line-by-line steps. Standard .NET debuggers can step through it as through any other C# source.

## Key Projects & Classes

### Hl7.Cql.Compiler Project

#### CodeBuilder Class
- Responsible for interpreting the ELM expression tree and building `CodeModel` IR nodes for all definitions and functions in the provided ELM library
- Relies on `CqlOperatorsBinder` to determine which `ICqlOperators` method calls to emit for CQL's operators
- Relies on `CqlContextBinder` to emit parameter and context access nodes
- Relies on `TupleBuilderCache` to create or look up the C# tuple types needed for CQL tuple expressions

#### CqlOperatorsBinder Class
- Bridges ELM operator nodes to `ICqlOperators` method calls in the code model
- Resolves overloads, generic type arguments, and implicit type conversions
- Uses `TypeResolver` to map CQL type references to .NET types and `TypeConverter` for conversion expressions

#### LibraryCodeBuilder / LibrarySetCodeBuilder Classes
- Orchestrate `CodeBuilder` across a single library or a full set of interdependent libraries
- Handle inter-library definition references and dependency ordering

### Hl7.Cql.CodeGeneration.NET Project

#### LibrarySetCSharpCodeGenerator Class
- Entry point for C# code generation: drives `CSharpEmitter` for each library definition and assembles the full C# source file
- Registers generated types (partial class members, using directives, etc.)

#### CSharpEmitter Class
- Prints `CodeModel` IR nodes to C# source text
- Statement-aware: tracks indentation, local variable scopes, and statement vs. expression positions
- Produces readable, deterministic output: same IR always produces byte-identical C#

#### AssemblyCompiler Class
- Invokes Roslyn to compile the generated C# source text to an in-memory or on-disk .NET assembly
- Does **not** use Roslyn to build syntax trees — Roslyn receives finished source text as input

### Hl7.Cql.Runtime Project

#### CqlContext Class
- Contains all information required to execute a compiled CQL library: an `ICqlOperators` implementation, input parameters, and optional caching settings
- One `CqlContext` instance per patient/bundle evaluation

#### ICqlOperators Interface
- Declares every CQL operator method (arithmetic, comparison, interval, clinical, etc.)
- The generated C# calls these methods at runtime
- `CqlOperators` is the standard implementation; custom implementations can wrap or replace it

#### IDataSource Interface
- Abstraction for providing FHIR resources to the engine during evaluation
- The generated `Retrieve` calls forward to `IDataSource.Retrieve<T>()`
- Implement this interface to load resources from any backing store (in-memory bundles, FHIR server, database, etc.)

#### TypeConverter Class
- Translates domain objects to and from CQL primitives used in `ICqlOperators` methods
- Extended by `FhirTypeConverter` in `Hl7.Cql.Firely` for FHIR model types

#### TypeResolver Class (in Hl7.Cql.Abstractions)
- Abstract class mapping CQL type names to .NET `Type` objects
- Used by `CodeBuilder`, `CqlOperatorsBinder`, and `CSharpEmitter`
- `BaseTypeResolver` (in `Hl7.Cql.Runtime`) provides mappings for CQL system types; `FhirTypeResolver` (in `Hl7.Cql.Firely`) extends it for FHIR R4 model types

#### IValueSetDictionary Interface
- Exposes the two methods used by CQL value set filtering in Retrieve statements
- Value set URIs, code system URIs, and codes are case-insensitive
- The default implementation uses hashing for O(1) membership checks

### Hl7.Cql.Firely Project

#### FhirCqlContext Class
- Static factory that constructs a `CqlContext` wired for use with Firely's FHIR POCO model
- Accepts an optional `IDataSource` (for custom data loading), parameter dictionary, value set dictionary, and reference date
- Returns a ready-to-use `CqlContext` instance

#### FhirTypeConverter Class
- Extends `TypeConverter` with mappings between Firely FHIR R4 model types and CQL primitives

#### FhirTypeResolver Class
- Extends `BaseTypeResolver` to map FHIR-prefixed type names to Firely model types using reflection attributes on the generated types

## Extension Scenarios

### How do I load FHIR data from a different source?

Implement `IDataSource` and pass it to `FhirCqlContext.ForBundle(...)` or construct a `CqlContext` directly:

```csharp
public class MyDataSource : IDataSource
{
    public IEnumerable<T> Retrieve<T>(...)
    {
        // load T from your store
    }
}

var ctx = FhirCqlContext.WithDataSource(new MyDataSource());
```

### How do I evaluate the same bundle many times?

`FhirCqlContext.ForBundle(...)` indexes the bundle's entries anew for every context it creates. A host that evaluates
the same, unchanging bundle repeatedly - for instance once per measure group for the same subject - can build the data
source once with `FhirCqlContext.DataSourceForBundle(...)` and pass it to `FhirCqlContext.WithDataSource(...)` per
evaluation:

```csharp
// once per bundle
var dataSource = FhirCqlContext.DataSourceForBundle(bundle);

// per evaluation, each with its own value sets
var ctx = FhirCqlContext.WithDataSource(dataSource, valueSets: scopedValueSets);
```

Each context gets a lightweight view over the shared index that resolves value sets through the `IValueSetDictionary`
passed to `WithDataSource`, so evaluations backed by different (for instance request-scoped) terminology can share one
data source. The index is read-only once built and supports any number of concurrent readers.

### How do I change the way a CQL operator behaves?

Implement `ICqlOperators` (or wrap an existing `CqlOperators` instance) and supply it to the `CqlContext` constructor:

```csharp
public class MyCqlOperators : ICqlOperators
{
    private readonly CqlOperators _inner;
    // delegate everything except the methods you want to override
}

var ctx = new CqlContext(new MyCqlOperators(...), parameters);
```

### How do I use a different value set store?

Implement `IValueSetDictionary` and pass it to the `CqlContext` factory:

```csharp
public class MyValueSetDictionary : IValueSetDictionary
{
    public bool IsCodeInValueSet(string valueSetUri, CqlCode code) => ...;
    public IEnumerable<CqlCode> CodesInValueSet(string valueSetUri) => ...;
}

var ctx = FhirCqlContext.ForBundle(bundle, valueSets: new MyValueSetDictionary());
```

> **Performance Note**: `IsCodeInValueSet` is called millions of times in a typical CQL evaluation. Pre-load all codes before evaluation begins, and make membership checks O(1).

### How do I call this engine from a non-.NET runtime?

Expose the engine via a gRPC or HTTP service (e.g., an ASP.NET Core minimal API or an Azure Function). gRPC with named-pipe transport has very low per-call overhead and works well for in-process or local inter-process calls from other runtimes such as Java or Node.js.