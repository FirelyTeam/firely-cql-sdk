# Getting started with the Firely CQL SDK

## Prerequisites

### Windows: Enable Long Paths

This repository contains deeply nested file paths that exceed Windows' default 260-character path limit. Before cloning or building on Windows, you must enable long path support.

1. **Enable long paths in Windows** (requires administrator privileges):
   ```powershell
   # Run as Administrator
   Set-ItemProperty -Path "HKLM:\SYSTEM\CurrentControlSet\Control\FileSystem" -Name "LongPathsEnabled" -Value 1
   ```
   Alternatively, enable it via Group Policy: *Computer Configuration → Administrative Templates → System → Filesystem → Enable Win32 long paths*.

2. **Enable long paths in Git**:
   ```bash
   git config --system core.longpaths true
   ```

> **Note:** A system restart may be required after changing the Windows registry setting.

## Repository Structure

```
firely-cql-sdk/
├── Cql/            # Core SDK source — all Hl7.Cql.* packages and PackagerCLI
├── Demo/           # Demonstrates the full CQL-to-measure pipeline with real HEDIS/CMS measures
├── Examples/       # Runnable C# examples for common SDK scenarios
│   └── CqlSdkExamples/   # Packaging (200s), Invocation (300s–400s), Extensions (500s)
├── docs/           # This documentation
└── spec/           # CQL specification reference and conformance reports
```

External submodule repositories (some private):
* `submodules/Firely.Cql.Sdk.Integration.Runner/` — integration test runner for CMS measures
* `submodules/NCQA/` — NCQA measures used to test the engine

## Building the SDK

Build the core SDK using the `Cql-Sdk.slnf` solution filter (recommended):

```bash
dotnet build Cql-Sdk.slnf
```

To also build demos and examples, use `Cql-Sdk-Demos-Examples.slnf`. The `Cql-Sdk-All.sln` solution includes submodule projects and requires them to be initialized first (`git submodule update`).

## Invoking CQL — The Recommended Approach

The primary way to execute CQL from .NET is via the **Invocation Toolkit** (`Hl7.Cql.Invocation`). It:

- Compiles CQL through ELM to a .NET assembly in a single pipeline
- Manages assembly loading in an isolated `AssemblyLoadContext`
- Handles version checking of generated code
- Provides a clean API for invoking definitions, functions, and bulk expression enumeration

**Always use the invocation toolkit instead of calling generated library classes directly.** Direct calls to generated classes bypass context management, caching, and version safety.

### Example: Hello World

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

### Example: Load from FHIR Resources

```csharp
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Fhir;

// Load pre-packaged FHIR Library resources (containing embedded assembly binaries)
var invocationToolkit = new InvocationToolkit()
    .AddAssemblyBinariesInFhirLibrariesFromDirectory(new DirectoryInfo("output/fhir"));

using var invoker = invocationToolkit.CreateLibrarySetInvoker();

var context = FhirCqlContext.WithDataSource();

var results = invoker
    .SelectExpressions()
    .ToList()
    .SelectResults(context)
    .ToList();
```

See the **[Examples project](../Examples/CqlSdkExamples/)** for complete, runnable samples:
- **210–251**: Packaging CQL/ELM into FHIR Library resources
- **310–340**: Invoking CQL definitions, parameters, functions, and caching
- **400–410**: Loading and invoking from FHIR resource directories
- **500**: Extending SDK functionality

## How CQL Execution Works

The SDK follows a pipeline from CQL source to .NET execution results:

1. **CQL → ELM**: CQL text is parsed and compiled to ELM (a structured representation). The .NET `Hl7.Cql.CqlToElm` package handles this. For production use with complex measures, the Java-based [CQL-to-ELM tool](https://github.com/cqframework/clinical_quality_language/tree/master/Src/java) may also be used.

2. **ELM → LINQ Expressions**: The `Hl7.Cql.Compiler` package interprets the ELM tree and produces `System.Linq.Expressions` lambdas for each CQL definition.

3. **LINQ Expressions → .NET Assembly**: The `Hl7.Cql.CodeGeneration.NET` package converts the expressions to C# source code, which is then compiled to a .NET assembly by Roslyn.

4. **Assembly → CQL Results**: The `Hl7.Cql.Invocation` toolkit loads the assembly, binds a `CqlContext` (containing patient data, parameters, value sets, and the reference date), and invokes individual definitions.

Steps 1–3 are handled automatically by the toolkits when you call `CreateLibrarySetInvoker()`. See the [CQL Engine Architecture](cql-engine-architecture.md) document for deeper background.

## The Demo Projects

The `Demo/` folder demonstrates the complete packaging pipeline for real HEDIS and CMS measures. It uses the Java-based CQL-to-ELM tooling and MSBuild targets to go from CQL source files all the way to packaged FHIR `Library` resources and .NET assemblies.

To build the Demo projects you need:
1. JDK (21+)
2. [Maven](https://maven.apache.org/install.html) (3.9+)
3. PowerShell Core 7+ (`pwsh`)

Once prerequisites are installed, open `Cql-Sdk-Demos-Examples.slnf` in Visual Studio or run `dotnet build` to build the demo measures.

## Further Reading

* [CQL Engine Architecture](cql-engine-architecture.md) — internal design and key classes
* [Toolkit Services Dependency Diagrams](dependency-diagrams.md) — service dependency graphs
* [Technical README](technical-readme.md) — multi-targeting, code generation versioning, and CI/CD details (maintainers)
* [DevDays 2023 presentation](https://youtu.be/CkTbgfbttJc) — introductory walkthrough
* [Firely .NET SDK documentation](https://docs.fire.ly/projects/Firely-NET-SDK/en/latest/cql.html) — CQL section
