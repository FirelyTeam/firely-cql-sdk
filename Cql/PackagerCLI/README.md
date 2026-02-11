# HL7 CQL Packager

A .NET tool that packages CQL, ELM, and build outputs into a FHIR Library resource.


## Online Documentation

Please note that the public [online documentation for the CQL Packager](https://docs.fire.ly/projects/Firely-NET-SDK/en/latest/cql/cql-packager.html)
is in maintained in another repository: [Online PackagerCLI docs](https://github.com/FirelyTeam/firely-docs-firely-net-sdk/tree/master/cql).

Whenever making changes to the documentation, please ensure that you update the the online documentation as well.

## Overview

The HL7 CQL Packager is a utility for converting CQL or ELM into other artifacts, such as C#, .NET assemblies, or FHIR Resources. It performs the following steps:

1. **CQL to ELM Conversion**: Converts CQL files into ELM JSON files. Please read the disclaimer in the help documentation.
2. **ELM to C#**: Converts ELM JSON files into LINQ expressions, then translates those into C# code.
3. **C# to .NET DLL Compilation**: Compiles the generated C# code into .NET assemblies.
4. **Packaging to FHIR Libraries/Measures**: Packages the assembly 
   (and optionally the original CQL, ELM, and C# source code) into a FHIR Library resource, 
   creating one resource per original ELM file. 
   Where applicable, FHIR Measure resources are also generated.

## Getting Started

### Installation

Install the packager tool globally using the following command:

```shell
dotnet tool install Hl7.Cql.Packager --global --prerelease
```

> **Note**: The `--prerelease` option is required because only prerelease versions are currently available.

## Usage

Get help for the command line tool by running any of the following commands:

```shell
cql-package --help
cql-package cql --help
cql-package elm --help
cql-package library-extract-attachments --help
```

### Command Reference

The CQL Packager has three main commands:

#### `elm` Command

Start from ELM files and convert to one or more of the following outputs: C#, DLL, PDB, FHIR Resources.

**Usage:** `cql-package elm [options]`

**Required Options:**
- `--elm <directory>` - ELM input directory containing ELM files in JSON format "*.json"

**Output Options:**
- `--cs <directory>` - C# output directory for generated C# source code files "*.g.cs"
- `--dll <directory>` - DLL output directory for .NET assembly libraries "*.dll"
- `--pdb <directory>` - PDB output directory for portable debug symbol files "*.pdb"
- `--fhir <directory>` - FHIR Resource output directory for Library and Measure files in JSON format

**C# Code Generation Options:**
- `--cs-namespace <namespace>` - The C# namespace to use for generated code (e.g., "MyCompany.MyCqlLibraries"). 
  If ommitted, C# types will be generated without a namespace.

**FHIR-specific Options:**
- `--cql <directory>` - CQL input directory (REQUIRED with --fhir)
- `--canonical-root-url <url>` - The root canonical URL output in FHIR library
- `--override-utc-date-time <datetime>` - Override date output in FHIR library
- `--json-pretty` - Output JSON using multiline and indentation (for --fhir)

**Debug Options:**
- `--debug-symbols <None|PortablePdb|Embedded>` - Debug symbol generation:
  - `None` (DEFAULT) - No debug symbols, optimizations enabled
  - `PortablePdb` - Separate PDB files, no optimizations
  - `Embedded` - Debug symbols embedded in DLL with C# source

#### `cql` Command

Start from CQL files and convert to one or more of the following outputs: ELM, C#, DLL, PDB, FHIR Resources.

**Usage:** `cql-package cql [options]`

**Required Options:**
- `--cql <directory>` - CQL input directory containing CQL files "*.cql"

**Output Options:**
- `--elm <directory>` - ELM output directory for generated ELM JSON files
- `--cs <directory>` - C# output directory for generated C# source code files "*.g.cs"
- `--dll <directory>` - DLL output directory for .NET assembly libraries "*.dll"
- `--pdb <directory>` - PDB output directory for portable debug symbol files "*.pdb"
- `--fhir <directory>` - FHIR Resource output directory for Library and Measure files in JSON format

**C# Code Generation Options:**
- `--cs-namespace <namespace>` - The C# namespace to use for generated code (e.g., "MyCompany.MyCqlLibraries"). 
  If ommitted, C# types will be generated without a namespace.

**FHIR-specific Options:**
- `--canonical-root-url <url>` - The root canonical URL output in FHIR library
- `--override-utc-date-time <datetime>` - Override date output in FHIR library
- `--json-pretty` - Output JSON using multiline and indentation (for --fhir or --elm)

**Debug Options:**
- `--debug-symbols <None|PortablePdb|Embedded>` - Debug symbol generation (same as elm command)

#### `library-extract-attachments` Command

Extract attachments from a FHIR Library resource to individual files. This command is useful for extracting embedded CQL, ELM, C#, DLL, and PDB files from packaged FHIR Library resources.

**Usage:** `cql-package library-extract-attachments [options]`

**Required Options:**
- `--library-file <file>` - FHIR Library resource file in JSON format containing embedded attachments

**Output Options** (at least one must be specified):
- `--cql-dir <directory>` - CQL output directory for extracted CQL files "*.cql"
- `--elm-dir <directory>` - ELM output directory for extracted ELM JSON files "*.json"
- `--csharp-dir <directory>` - C# output directory for extracted C# source code files "*.g.cs"
- `--dll-dir <directory>` - DLL output directory for extracted .NET assembly libraries "*.dll"
- `--pdb-dir <directory>` - PDB output directory for extracted portable debug symbol files "*.pdb"

**Logging Options (all commands):**
- `--log-append` - Append to existing log file instead of clearing
- `--console-log-level <level>` - Minimum log level for console output
- `--file-log-level <level>` - Minimum log level for file output

Log levels: `Critical`, `Debug`, `Error`, `Information`, `None`, `Trace`, `Warning`

### Disclaimer

While this repository includes a .NET-based CQL to ELM converter (accessible via the `cql` command), 
it is currently in an early stage of development and only supports basic CQL translation. 
**It is NOT PRODUCTION READY.**

**The preferred and recommended approach** is to use the mature, battle-tested Java-based CQL to ELM tooling 
to generate ELM files, and then use the `elm` command from this packager to process those ELM files.
(See the getting-started.md documentation for more information, and the [Java Tooling README](https://github.com/cqframework/clinical_quality_language/blob/master/Src/java/README.md#generate-an-elm-representation-of-cql-logic)).

If you do use the `cql` command and encounter issues with the CQL to ELM conversion, 
please log them in the [Firely CQL SDK issue tracker](https://github.com/FirelyTeam/firely-cql-sdk/issues).

The version of the Java Tooling that is used to generate the ELM files must be compatible with the version of the CQL Packager you are using.
The Java tooling version is configured in `Demo/Cql/Build/Java-Dependencies-Vars.ps1` and should be kept in sync with the version referenced in this file's source code.
For more information, see the Disclaimer section in the help documentation when running `cql-package --help`.


### Examples

1. Package ELM into FHIR resources (as indented JSON) and save C# source code:

```shell
cql-package elm --elm input/elm --cql input/cql --fhir output/fhir --cs output/csharp --json-pretty
```

- Packages ELM JSON files from the directory `input/elm` into FHIR Library resources saving them to `output/fhir`.
- The CQL files in `input/cql` are included in the FHIR Library resources, if they match the ELM files by file name.
- The generated C# source code is saved to directory `output/csharp`.

2. Package CQL into FHIR resources (as indented JSON) and save C# source code:

```shell
cql-package cql --cql input/cql --fhir output/fhir --cs output/csharp --json-pretty
```

- Packages CQL files from the directory `input/cql` into FHIR Library resources saving them to `output/fhir`.
- The ELM files are included in the FHIR Library resources, but are not saved to a separate directory.
- The generated C# source code is saved to directory `output/csharp`.
- Read the disclaimer in the help.

3. Package ELM into .NET assembly DLL's, which can be stepped through in a debugger:

```shell
cql-package elm --elm input/elm --dll output/dll --debug-symbols Embedded
```

- Compiles ELM JSON files in the directory `input/elm` into .NET assemblies and saving them to `output/dll`.
- The C# and debugging symbols are embedded in the DLLs. The DLLs are compiled without any optimizations.

4. Package ELM with portable PDB files for debugging:

```shell
cql-package elm --elm input/elm --dll output/dll --pdb output/dll --debug-symbols PortablePdb
```

- Compiles ELM JSON files into .NET assemblies in `output/dll`.
- Creates separate portable PDB files in the same directory for debugging.

5. Set canonical root URL and override date for FHIR resources:

```shell
cql-package elm --elm input/elm --fhir output/fhir --canonical-root-url https://example.org/fhir/ --override-utc-date-time 2024-01-01T00:00:00Z --json-pretty
```

- Packages ELM into FHIR Library resources with a custom canonical root URL.
- Overrides the date timestamp in the generated FHIR resources.
- Outputs pretty-printed JSON.

6. Generate C# code with a custom namespace:

```shell
cql-package elm --elm input/elm --cs output/csharp --cs-namespace MyCompany.MyCqlLibraries
```

- Generates C# source code from ELM files.
- All generated C# classes will be in the `MyCompany.MyCqlLibraries` namespace.
- This is useful for organizing generated code in larger projects or avoiding naming conflicts.

7. Extract all attachments from a FHIR Library resource:

```shell
cql-package library-extract-attachments --library-file Library-MyLibrary.json --cql-dir output/cql --elm-dir output/elm --csharp-dir output/csharp --dll-dir output/dll --pdb-dir output/pdb
```

- Extracts all embedded attachments from the FHIR Library resource file `Library-MyLibrary.json`.
- CQL files are saved to `output/cql` as `*.cql`.
- ELM files are saved to `output/elm` as `*.json`.
- C# source code is saved to `output/csharp` as `*.g.cs`.
- .NET assemblies are saved to `output/dll` as `*.dll`.
- Debug symbols are saved to `output/pdb` as `*.pdb`.

8. Extract only CQL and ELM from a FHIR Library resource:

```shell
cql-package library-extract-attachments --library-file Library-MyLibrary.json --cql-dir output/cql --elm-dir output/elm
```

- Extracts only CQL and ELM attachments from the FHIR Library resource.
- Other attachment types (C#, DLL, PDB) are not extracted.

## Further Reading

This package is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). For getting started, release notes, and contribution guidelines, see the [main README](../../README.md). More information can be found at [Firely's documentation site](https://docs.fire.ly/projects/Firely-NET-SDK/en/latest/cql.html).
