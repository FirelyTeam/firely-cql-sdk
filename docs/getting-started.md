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

### Repository tooling

Building and using the SDK needs nothing but the .NET SDK (the projects target `net10.0`). The
maintenance scripts under [tools/](../tools/README.md) and [LibrarySets/](../LibrarySets/) are a
separate matter, and each brings its own toolchain — none of which is required to build, test or
consume the SDK itself:

| Needed for | Requirement |
|---|---|
| [tools/condense_spec/](../tools/condense_spec/README.md) — CQL/FHIR spec condensing<br>[tools/dqic_sync/](../tools/dqic_sync/README.md) — conformance-suite comparison | **Python 3**, standard library only — no `pip install` step |
| [tools/mermaid/](../tools/mermaid/README.md) — rendering diagrams to SVG | **Node.js** (the scripts call `npx -y @mermaid-js/mermaid-cli`, so nothing is installed globally) and **PowerShell** or bash, whichever half of the script pair you run |
| [LibrarySets/sync-dqm-2025.ps1](../LibrarySets/sync-dqm-2025.ps1) — refreshing the CMS measure content | **PowerShell**, **git** and a **Java** runtime (it runs the `cql-to-elm` compiler) |
| [tools/XsdToCSharpConverter/](../tools/XsdToCSharpConverter/README.md) — XSD to C# generation | nothing extra; it is a .NET project |

Python was chosen for the scripts that parse or emit structured data — a JSON or XML tool wants a
parser from its standard library rather than an indentation-shaped text assumption — and it is
deliberately kept to the standard library so that "install Python 3" is the whole setup.

The integration runner submodule is a **private** repository, so the rest of this note applies only if
you have access to it. It carries its own tooling with its own prerequisites, documented in that
repository's README — including a Python script that completes paged VSAC value set expansions, which
additionally needs a UMLS API key.

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

External submodule repositories:
* `submodules/Firely.Cql.Sdk.Integration.Runner/` — integration test runner for CMS measures

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
- **310–350**: Invoking CQL definitions, parameters, functions, caching, and pooling library sets
- **400–410**: Loading and invoking from FHIR resource directories
- **500**: Extending SDK functionality

If you are running the same CQL repeatedly — evaluating a measure over a population, for instance — read
**[Caching strategies](caching-strategies.md)** before you tune anything. It covers which of the SDK's
caches to reach for, what each one costs, and how they interact.

## How CQL Execution Works

The SDK follows a pipeline from CQL source to .NET execution results:

1. **CQL → ELM**: CQL text is parsed and compiled to ELM (a structured representation). The .NET `Hl7.Cql.CqlToElm` package handles this. For production use with complex measures, the Java-based [CQL-to-ELM tool](https://github.com/cqframework/clinical_quality_language/tree/master/Src/java) may also be used.

2. **ELM → typed IR**: The `Hl7.Cql.Compiler` package interprets the ELM tree and produces a typed code model (IR) for each CQL definition.

3. **Typed IR → .NET Assembly**: The `Hl7.Cql.CodeGeneration.NET` package emits C# source code from the typed IR, which is then compiled to a .NET assembly by Roslyn.

4. **Assembly → CQL Results**: The `Hl7.Cql.Invocation` toolkit loads the assembly, binds a `CqlContext` (containing patient data, parameters, value sets, and the reference date), and invokes individual definitions.

Steps 1–3 are handled automatically by the toolkits when you call `CreateLibrarySetInvoker()`. See the [CQL Engine Architecture](cql-engine-architecture.md) document for deeper background.

## The Demo Projects

The `Demo/` folder demonstrates the complete packaging pipeline for real HEDIS and CMS measures. It uses the Java-based CQL-to-ELM tooling and MSBuild targets to go from CQL source files all the way to packaged FHIR `Library` resources and .NET assemblies.

To build the Demo projects you need:
1. JDK (21+)
2. [Maven](https://maven.apache.org/install.html) (3.9+)
3. PowerShell Core 7+ (`pwsh`)

Once prerequisites are installed, open `Cql-Sdk-Demos-Examples.slnf` in Visual Studio or run `dotnet build` to build the demo measures.

See the **[Demo Projects](demo-projects.md)** guide for the project structure, pipeline stages, and how to configure your own measure project. The **[CQL Build Pipeline](build-pipeline.md)** document covers the `build.ps1`/`build.sh` scripts, all MSBuild props/targets files, and the Java dependency management in detail. To learn about the individual PackagerCLI commands and options, see the **[CQL Packager Reference](cql-packager.md)**.

## Further Reading

* [CQL Engine Architecture](cql-engine-architecture.md) — internal design and key classes
* [Caching strategies](caching-strategies.md) — which cache to reach for, what each one costs, and how they interact
* [Toolkit Services Dependency Diagrams](dependency-diagrams.md) — service dependency graphs
* [Demo Projects](demo-projects.md) — project structure and how to configure a measure project
* [CQL Build Pipeline](build-pipeline.md) — build scripts, Java CQL-to-ELM tooling, PackagerCLI, and MSBuild targets
* [CQL Packager Reference](cql-packager.md) — all `cql-package` commands, options, and examples
* [Technical README](technical-readme.md) — multi-targeting, code generation versioning, and CI/CD details (maintainers)
* [DevDays 2023 presentation](https://youtu.be/CkTbgfbttJc) — introductory walkthrough
