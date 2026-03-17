# CQL Packager Reference

`cql-package` is a .NET CLI tool that converts CQL or ELM source files into C# code, .NET assemblies, and FHIR Library/Measure resources. It is the engine that drives the ELM tooling stage described in the [build pipeline document](build-pipeline.md).

## Overview

> ⚠️ **Note on CQL-to-ELM:** The built-in CQL-to-ELM compiler (`cql-package cql`) is not as mature as the Java-based [CQL-to-ELM CLI](https://github.com/cqframework/clinical_quality_language). For production use, generate ELM with the Java tooling and run `cql-package elm` instead.

The packager accepts two entry points and produces up to five output artefacts:

```
CQL source files          ELM JSON files
       │                        │
       │  cql-package cql       │  cql-package elm
       │                        │
       ▼                        ▼
 ELM JSON files (optional)      │
       │                        │
       └──────────┬─────────────┘
                  │
                  ▼
        C# source files (*.g.cs)
                  │
                  ▼
        .NET assembly (*.dll / *.pdb)
                  │
                  ▼
        FHIR Library + Measure resources (*.json)
```

Two additional utility commands operate on already-packaged FHIR Library resources:

```
FHIR Library resource  ─────────────────────────────────────────────────────────────┐
                                                                                     │
  cql-package extract-library-attachments   →   CQL / ELM / C# / DLL / PDB files   │
  cql-package replace-library-attachments   →   Updated FHIR Library resource   ◄──┘
```

## Installation

Install globally from NuGet:

```shell
dotnet tool install Hl7.Cql.Packager --global --prerelease
```

> **Note**: The `--prerelease` flag is required while only prerelease versions are published.

Verify the installation:

```shell
cql-package --version
cql-package --help
```

## Commands

### `elm` — ELM → C# / DLL / FHIR

Reads pre-built ELM JSON files and converts them to one or more outputs.

> **Recommended starting point.** Use the [Java CQL-to-ELM CLI](https://github.com/cqframework/clinical_quality_language) to produce ELM, then use this command to compile and package.

**Usage:** `cql-package elm [options]`

| Option | Required | Description |
|--------|----------|-------------|
| `--elm <dir>` | ✅ | Input directory containing `*.json` ELM files (searched recursively) |
| `--cql <dir>` | ✅ with `--fhir` | CQL source directory; files are matched by versioned identifier and embedded in FHIR Library resources |
| `--cs <dir>` | | Output directory for generated `*.g.cs` C# source files |
| `--dll <dir>` | | Output directory for compiled `*.dll` .NET assemblies |
| `--pdb <dir>` | | Output directory for `*.pdb` portable debug symbol files (requires `--debug-symbols PortablePdb` and `--dll`) |
| `--fhir <dir>` | | Output directory for FHIR `Library-*.json` and `Measure-*.json` resources |
| `--libraries <dir>` | | FHIR Libraries-only output (use with `--measures`; mutually exclusive with `--fhir`) |
| `--measures <dir>` | | FHIR Measures-only output (use with `--libraries`; mutually exclusive with `--fhir`) |
| `--canonical-root-url <url>` | | Root canonical URL embedded in generated FHIR resources |
| `--override-utc-date-time <dt>` | | Override the timestamp written into FHIR resources (e.g. `1970-01-01T00:00:00Z` for reproducible builds) |
| `--json-pretty` | | Emit pretty-printed JSON for FHIR output |
| `--cs-namespace <ns>` | | C# namespace for generated code (e.g. `MyCompany.MyCqlLibraries`) |
| `--debug-symbols <mode>` | | `None` (default), `PortablePdb`, or `Embedded` — see [Debug symbols](#debug-symbols) |
| `--flatten-dir-hierarchy` | | Place all outputs in the root output directory, ignoring input subdirectories |

**Example — produce FHIR resources and C# code:**

```shell
cql-package elm \
  --elm  input/elm \
  --cql  input/cql \
  --fhir output/fhir \
  --cs   output/csharp \
  --json-pretty
```

---

### `cql` — CQL → ELM → C# / DLL / FHIR

Reads CQL source files, compiles them to ELM in-process, then continues the same pipeline as the `elm` command.

> ⚠️ **The built-in CQL-to-ELM compiler is NOT production ready.** It supports only basic CQL. For production use, generate ELM with the Java tooling and run `cql-package elm` instead. See the [disclaimer](#disclaimer).

**Usage:** `cql-package cql [options]`

| Option | Required | Description |
|--------|----------|-------------|
| `--cql <dir>` | ✅ | Input directory containing `*.cql` files (searched recursively) |
| `--elm <dir>` | | Output directory for generated ELM `*.json` files |
| `--cs <dir>` | | Output directory for generated `*.g.cs` C# source files |
| `--dll <dir>` | | Output directory for compiled `*.dll` .NET assemblies |
| `--pdb <dir>` | | Output directory for `*.pdb` portable debug symbol files |
| `--fhir <dir>` | | Output directory for FHIR `Library-*.json` and `Measure-*.json` resources |
| `--libraries <dir>` | | FHIR Libraries-only output (use with `--measures`; mutually exclusive with `--fhir`) |
| `--measures <dir>` | | FHIR Measures-only output (use with `--libraries`; mutually exclusive with `--fhir`) |
| `--canonical-root-url <url>` | | Root canonical URL embedded in generated FHIR resources |
| `--override-utc-date-time <dt>` | | Override the timestamp in generated FHIR resources |
| `--json-pretty` | | Emit pretty-printed JSON for FHIR and ELM output |
| `--cs-namespace <ns>` | | C# namespace for generated code |
| `--debug-symbols <mode>` | | `None` (default), `PortablePdb`, or `Embedded` |
| `--flatten-dir-hierarchy` | | Flatten output directory structure |

**Example:**

```shell
cql-package cql \
  --cql  input/cql \
  --fhir output/fhir \
  --cs   output/csharp \
  --json-pretty
```

---

### `extract-library-attachments` — Unpack a FHIR Library

> ⚠️ **Alpha feature** — behavior may change in future releases.

Extracts embedded attachments (CQL, ELM, C#, DLL, PDB) from a FHIR Library resource into separate files.

**Usage:** `cql-package extract-library-attachments [options]`

| Option | Required | Description |
|--------|----------|-------------|
| `--library-file <file>` | ✅ | Input FHIR Library resource JSON file |
| `--cql-dir <dir>` | at least one | Output directory for extracted `*.cql` files |
| `--elm-dir <dir>` | at least one | Output directory for extracted `*.json` ELM files |
| `--csharp-dir <dir>` | at least one | Output directory for extracted `*.g.cs` C# files |
| `--dll-dir <dir>` | at least one | Output directory for extracted `*.dll` assemblies |
| `--pdb-dir <dir>` | at least one | Output directory for extracted `*.pdb` symbol files |

**Example — extract all attachments:**

```shell
cql-package extract-library-attachments \
  --library-file Library-MyMeasure.json \
  --cql-dir    output/cql \
  --elm-dir    output/elm \
  --csharp-dir output/csharp \
  --dll-dir    output/dll \
  --pdb-dir    output/pdb
```

---

### `replace-library-attachments` — Update a FHIR Library

> ⚠️ **Alpha feature** — behavior may change in future releases.

Replaces or adds specific attachments in an existing FHIR Library resource. If `--library-out-file` is omitted the source file is updated in-place.

> **Note:** Replacing the ELM attachment (`--elm-file`) automatically overwrites the CQL parameter values in the FHIR Library resource with the values from the new ELM file.

**Usage:** `cql-package replace-library-attachments [options]`

| Option | Required | Description |
|--------|----------|-------------|
| `--library-file <file>` | ✅ | FHIR Library resource to read |
| `--library-out-file <file>` | | Write the updated library here (source file is copied and left unchanged) |
| `--cql-file <file>` | at least one | CQL file to embed as `+cql` attachment |
| `--elm-file <file>` | at least one | ELM JSON file to embed as `+elm` attachment |
| `--csharp-file <file>` | at least one | C# file to embed as `+csharp` attachment |
| `--dll-file <file>` | at least one | DLL file to embed as `+dll` attachment |
| `--pdb-file <file>` | at least one | PDB file to embed as `+pdb` attachment |
| `--json-pretty` | | Emit pretty-printed JSON for the output |

**Example — update ELM and keep original file:**

```shell
cql-package replace-library-attachments \
  --library-file     Library-MyMeasure.json \
  --library-out-file Library-MyMeasure-v2.json \
  --elm-file         UpdatedMeasure.json
```

---

## Common Options

All commands share the following logging options:

| Option | Description |
|--------|-------------|
| `--log-file <path>` | Write log output to this file (no file logging if omitted) |
| `--log-append` | Append to the log file instead of overwriting |
| `--console-log-level <level>` | Minimum log level for console output |
| `--file-log-level <level>` | Minimum log level for file output |

Log levels: `Trace`, `Debug`, `Information`, `Warning`, `Error`, `Critical`, `None`

## Debug Symbols

The `--debug-symbols` option controls how debug information is generated when producing .NET assemblies:

| Mode | Effect |
|------|--------|
| `None` (default) | Optimized compilation, no debug symbols |
| `PortablePdb` | No optimizations; separate `.pdb` files written to `--pdb` directory (requires `--dll`) |
| `Embedded` | No optimizations; C# source and debug symbols embedded directly in the `.dll` — enables step-through debugging without separate files |

## Disclaimer

The `cql` command includes a .NET-based CQL-to-ELM compiler that is **not production ready** and only supports basic CQL. For production use, generate ELM files with the Java-based [CQL-to-ELM CLI](https://github.com/cqframework/clinical_quality_language) and run `cql-package elm`. See the full disclaimer in `cql-package --help`.

The Java tooling version used to generate ELM files must match the version configured in the packager. The expected version is set in `Demo/Cql/Build/Java-Dependencies-Vars.ps1` (and `.sh`).

## Further Reading

- [PackagerCLI source and full reference](../Cql/PackagerCLI/README.md)
- [Demo projects and build pipeline](demo-projects.md) — how PackagerCLI integrates into the MSBuild pipeline
- [Getting started](getting-started.md) — prerequisites and first steps
- [cqframework/clinical_quality_language](https://github.com/cqframework/clinical_quality_language) — Java CQL-to-ELM tool
