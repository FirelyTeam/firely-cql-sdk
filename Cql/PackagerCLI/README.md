# HL7 CQL Packager

A .NET tool that packages CQL, ELM, and build outputs into a FHIR Library resource.

## Overview

The HL7 CQL Packager performs the following steps:

1. **Translation**: Converts ELM JSON files into Linq.Expressions, then translates these expressions into C# code. Each ELM file is converted into a class, with each function within that file becoming a public method in the class.
2. **Compilation**: Compiles the generated C# code into a single assembly per ELM file.
3. **Packaging**: Packages the assembly (and optionally the original CQL, ELM, and C# source code) into a FHIR Library resource, creating one resource per original ELM file.

## Getting Started

### Installation

Install the packager tool globally using the following command:

```shell
dotnet tool install Hl7.Cql.Packager --global --prerelease
```

> **Note**: The `--prerelease` option is required because only prerelease versions are currently available.

### Prerequisites

The tool does not convert CQL into ELM. You need to use the existing Java-based tooling for this conversion.

## Usage

Run the tool with the following command:

```shell
cql-package --elm <directory> --cql <directory> [options]
```

### Mandatory Parameters

- `--elm <directory>`: Specifies the root directory for the ELM files. This parameter is required.
- `--cql <directory>`: Specifies the root directory for the CQL files. This parameter is required.

### Optional Parameters

- `[--fhir <directory>]`: Specifies the output directory for the FHIR resources
- `[--cs <directory>]`: Specifies the output directory for generated C# code
- `[--cs-typeformat <var|explicit>]`: Specifies whether to use 'var' (default) or explicit types in the generated C# output
- `[--dll <directory>]`: Specifies the DLL output directory
- `[--log-debug <true|false>]`: Enable debug logging or not (default)
- `[--canonical-root-url <url>]`: Specifies the root url used for the resource canonical. If omitted a '#' will be used.
- `[--override-utc-date-time <ISO8601-date-time>]`: Defines the UTC date to override in the generated FHIR resource libraries (example: 2000-12-31T23:59:59.99Z). If omitted the current date time will be used.

### Example

```
cql-package --elm Elm\json --cql Cql\input --fhir c:\packager-output-fhir --cs c:\packager-output-cs
```

This command packages the ELM and CQL files from the specified directories and writes the generated FHIR Resources and C# code to the respective directories.

## Further Reading

The CQL Packager tool is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). More information can be found at [Firely’s documentation site](https://docs.fire.ly/projects/Firely-NET-SDK/en/latest/cql/cql-packager.html).
