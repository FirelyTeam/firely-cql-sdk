# Hl7.Cql.Invocation

High-level APIs for invoking CQL libraries from .NET applications.

## Overview

This package is the **recommended entry point** for applications that need to execute CQL logic. It wraps the full compilation pipeline (CQL → ELM → LINQ Expressions → .NET Assembly) and exposes a clean API for invoking definitions, functions, and enumerating results.

### Why use the Invocation Toolkit instead of calling libraries directly?

The SDK can compile CQL into .NET assemblies containing generated C# classes. It may be tempting to instantiate and call those generated classes directly. **Do not do this.** Reasons:

- **Assembly isolation**: Libraries are loaded into a dedicated `AssemblyLoadContext` so they can be unloaded cleanly. Bypassing this leaks assemblies.
- **Version safety**: The toolkit verifies that the generator tool version that produced the assembly is compatible with the current runtime before loading it.
- **Context lifecycle**: `CqlContext` (patient data, parameters, value sets, reference date) must be wired correctly to the library instance. The toolkit handles this binding.
- **Caching**: Expression result caching is managed per-context by the toolkit; calling generated methods outside of it disables this optimization.

## Key Types

| Type | Description |
|------|-------------|
| `CqlToolkit` | Entry point for compiling inline CQL strings or files and producing a `LibrarySetInvoker`. |
| `InvocationToolkit` | Entry point for loading pre-compiled FHIR Library resources and producing a `LibrarySetInvoker`. |
| `LibrarySetInvoker` | Manages a set of compiled CQL libraries. Use `InvokeLibraryDefinition` for single definitions, `SelectExpressions().SelectResults(context)` for bulk evaluation across all libraries, or `SelectExpressionsForLibrary(libraryIdentifier)` to target a specific library. |
| `LibraryInvoker` | Invoker scoped to a single CQL library. |
| `DefinitionInvoker` | Invoker for a single CQL definition or function. |

## Usage

### Invoke inline CQL

```csharp
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Microsoft.Extensions.Logging;

var loggerFactory = LoggerFactory.Create(b => b.AddConsole());

var cql = (CqlLibraryString)"""
    library HelloWorldLib version '1.0.0'
    define "HelloWorld" : 'Hello from CQL!'
    """;

using var invoker = new CqlToolkit(loggerFactory)
    .AddCqlLibraries(cql)
    .CreateLibrarySetInvoker();

var result = invoker.InvokeLibraryDefinition(
    FhirCqlContext.WithDataSource(),
    cql.LibraryIdentifier,
    "HelloWorld");

Console.WriteLine(result); // Hello from CQL!
```

### Invoke from ELM files

If you have pre-built ELM JSON files (e.g. produced by the [CQL-to-ELM translator](https://github.com/cqframework/clinical_quality_language)), load them with `ElmToolkit` and compile them in-memory to a `LibrarySetInvoker`:

```csharp
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Microsoft.Extensions.Logging;

var loggerFactory = LoggerFactory.Create(b => b.AddConsole());

var elmDirectory = new DirectoryInfo("path/to/elm");

using var librarySetInvoker = new ElmToolkit(loggerFactory)
    .AddElmFilesFromDirectory(elmDirectory)
    .CreateLibrarySetInvoker();

var libraryIdentifier = CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion("MyLibrary", "1.0.0");

var result = librarySetInvoker.InvokeLibraryDefinition(
    FhirCqlContext.WithDataSource(),
    libraryIdentifier,
    "MyDefinition");

Console.WriteLine(result);
```

### Invoke from packaged FHIR Library resources

```csharp
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Fhir;

var invoker = new InvocationToolkit()
    .AddAssemblyBinariesInFhirLibrariesFromDirectory(new DirectoryInfo("output/fhir"));

using var librarySetInvoker = invoker.CreateLibrarySetInvoker();

var context = FhirCqlContext.WithDataSource(
    parameters: new Dictionary<string, object>
    {
        { "Measurement Period", new CqlInterval<CqlDateTime>(...) }
    });

var results = librarySetInvoker
    .SelectExpressions()
    .ToList()
    .SelectResults(context)
    .ToList();
```

### Pass a parameter to a CQL expression

```csharp
var cql = (CqlLibraryString)"""
    library GreetingLib version '1.0.0'
    parameter greeting String
    define "Greet" : 'Hello, ' + greeting
    """;

using var invoker = new CqlToolkit(loggerFactory)
    .AddCqlLibraries(cql)
    .CreateLibrarySetInvoker();

var context = FhirCqlContext.WithDataSource(
    parameters: new Dictionary<string, object> { { "greeting", "World" } });

var result = invoker.InvokeLibraryDefinition(context, cql.LibraryIdentifier, "Greet");
// Hello, World
```

## Dependencies

- **Hl7.Cql.Packaging** — CQL packaging and FHIR resource handling
- **Hl7.Cql.CqlToElm** — CQL to ELM conversion
- **CodeGeneration.NET** — ELM to .NET assembly compilation

## Further Reading

This package is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). See the [main README](../../README.md) for an overview, the [getting started guide](../../docs/getting-started.md) for setup instructions, and the [Examples project](../../Examples/CqlSdkExamples/) for complete runnable samples. More information can be found at [Firely's documentation site](https://docs.fire.ly/projects/Firely-NET-SDK/en/latest/cql.html).
