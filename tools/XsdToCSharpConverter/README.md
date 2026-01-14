# XSD to C# Converter

A cross-platform wrapper tool for generating C# classes from XSD schema files with post-processing capabilities.

## Overview

This tool provides a command-line interface for converting XSD (XML Schema Definition) files to C# classes. It wraps the existing `xsd.exe` tool from the .NET Framework SDK to ensure compatibility with existing generated code, while adding additional features like customizable post-processing of the generated output.

## Purpose

This tool was created to replace the manual XSD-to-C# conversion process used in the Firely CQL SDK. The previous approach used a batch script (`Elm.g.cs-Generate.cmd`) that directly called `xsd.exe` and performed post-processing steps. This tool consolidates that functionality into a single, maintainable C# application.

## Requirements

- .NET 8.0 or later (to build and run the tool)
- Windows operating system
- .NET Framework SDK with `xsd.exe` tool installed

**Note**: The tool currently requires Windows because it wraps the `xsd.exe` tool from the .NET Framework SDK. Future versions may support cross-platform XSD processing with alternative code generators.

## Building

To build the tool:

```bash
cd tools/XsdToCSharpConverter
dotnet build
```

This produces the executable `xsd2cs.dll` (or `xsd2cs.exe` on Windows with self-contained publish).

## Usage

### Basic Syntax

```
xsd2cs [options] schema1.xsd [schema2.xsd ...]
```

### Options

- `/c` - Generate classes (default mode)
- `/o:<path>` - Output directory for generated files
- `/n:<namespace>` - Namespace for generated classes
- `/q` - Suppress xsd.exe console output
- `--post-process` - Enable post-processing of generated files

### Examples

Generate C# classes from multiple XSD files:
```bash
xsd2cs /c /o:.. /n:Hl7.Cql.Elm library.xsd expression.xsd clinicalexpression.xsd
```

Suppress console output:
```bash
xsd2cs /c /q /o:.. /n:Hl7.Cql.Elm schema.xsd
```

## How It Works

1. **Parse Arguments**: The tool parses command-line arguments in the same format as `xsd.exe`
2. **Locate xsd.exe**: It searches for `xsd.exe` in common .NET Framework SDK locations
3. **Generate Code**: It calls `xsd.exe` with the provided arguments
4. **Post-Process**: If requested, it can perform custom post-processing on the generated file (e.g., adding custom headers, pragma directives)

## Future Enhancements

Future versions of this tool may include:

- Native XSD parsing and code generation without dependency on `xsd.exe`
- Cross-platform support (Linux, macOS)
- Nullable reference type annotations in generated code
- Support for modern C# language features
- Customizable code templates

## Integration with Build Process

This tool is designed to be used in place of the old `Elm.g.cs-Generate.cmd` batch script. It is **not** included in the main solution file (`Cql-Sdk.slnf`) and is not part of the regular build process. It should be run manually when XSD schemas are updated.

## License

This project is licensed under the BSD 3-Clause license. See the LICENSE file in the repository root for details.
