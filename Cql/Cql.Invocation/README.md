# Hl7.Cql.Invocation

High-level APIs for invoking CQL libraries from .NET applications.

## Overview

This package is the **recommended entry point** for applications that need to execute CQL logic. It wraps the full compilation pipeline (CQL → ELM → typed IR → C# source → .NET Assembly) and exposes a clean API for invoking definitions, functions, and enumerating results.

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
| `LibrarySetInvokerPool` | Optional pool that reuses `LibrarySetInvoker` instances across evaluations of the same library set, so its assemblies are loaded and JIT-compiled once instead of once per evaluation. |

## Reusing a library set across evaluations

`CreateLibrarySetInvoker` creates a fresh collectible `AssemblyLoadContext` and reloads every assembly on every call. A host that evaluates the same library set repeatedly — a measure evaluated once per subject, say — therefore reloads and re-JIT-compiles the whole assembly closure each time. Collectible contexts never use ReadyToRun, so every method is JIT-compiled per context, and unloading them is asynchronous, so contexts accumulate faster than they are reclaimed. On Linux each JIT-compiled region costs two memory mappings, and exhausting the kernel's `vm.max_map_count` aborts the process.

`LibrarySetInvokerPool` is the opt-in fix. Create one, keep it for as long as the process needs those library sets, and ask it for invokers instead of creating them:

```csharp
using Hl7.Cql.Invocation.Toolkit;

// Once, for the lifetime of the host.
using var pool = new LibrarySetInvokerPool(new LibrarySetInvokerPoolOptions(Capacity: 4));

// Per evaluation: loads on the first call, reused after that.
var librarySetInvoker = pool.GetOrCreate(invocationToolkit, "HEDIS");
var result = librarySetInvoker.InvokeLibraryDefinition(FhirCqlContext.ForBundle(bundle), libraryIdentifier, "Numerator");
```

Entries are keyed on the **content** of the assembly binaries, so rebuilding an equivalent `InvocationToolkit` from freshly read bytes still hits the pool.

Two rules apply when pooling:

- **The pool owns the invokers it returns — do not dispose them.** A returned invoker is shared with every other caller for the same library set, so `Dispose()` on a pooled invoker is a deliberate no-op. Likewise `SetBatchProcessExceptionContinuation` is ignored on a pooled instance: request the continuation you want from the pool and you will get an instance that already has it.
- **Do not retain a `LibraryInvoker` or `DefinitionInvoker` beyond the point where you are done with its library set.** Both reach their library set through a back-reference, so holding one keeps the whole assembly load context alive even after the pool has evicted it. `LibrarySetInvokerPool.Statistics.PendingUnloads` is the signal to watch: a value that keeps climbing means something is doing this.

A pooled invoker is safe to share between concurrently evaluating threads, provided each evaluation uses its own `CqlContext`.

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

This package is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). See the [main README](../../README.md) for an overview, the [getting started guide](../../docs/getting-started.md) for setup instructions, and the [Examples project](../../Examples/CqlSdkExamples/) for complete runnable samples.
