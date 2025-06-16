# HL7 CQL Packager

A .NET tool that packages CQL, ELM, and build outputs into a FHIR Library resource.

## Overview

The HL7 CQL Packager performs the following steps:

1. **CQL to ELM Conversion**: Converts CQL files into ELM JSON files.
2. **ELM to C#**: Converts ELM JSON files into Linq.Expressions, then translates these expressions into C# code. Each ELM file is converted into a class, with each function within that file becoming a public method in the class.
3. **C# to .NET DLL Compilation**: Compiles the generated C# code into a single assembly per ELM file.
4. **Packaging to FHIR Libraries/Measures**: Packages the assembly (and optionally the original CQL, ELM, and C# source code) into a FHIR Library resource, creating one resource per original ELM file. Where applicable, FHIR Measure resources are also generated.

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
```

### Example

```
cql-package elm --elm Elm\json --cql Cql\input --fhir c:\packager-output-fhir --cs c:\packager-output-cs
```

This command packages the ELM and CQL files from the specified directories and writes the generated FHIR Resources and C# code to the respective directories.

## Further Reading

The CQL Packager tool is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). More information can be found at [Firely’s documentation site](https://docs.fire.ly/projects/Firely-NET-SDK/en/latest/cql/cql-packager.html).
