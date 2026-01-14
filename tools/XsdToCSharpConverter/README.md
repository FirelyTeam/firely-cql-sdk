# XSD to C# Converter

A cross-platform wrapper tool for generating C# classes from XSD schema files with post-processing capabilities.

## Overview

This tool provides a command-line interface for converting XSD (XML Schema Definition) files to C# classes. It wraps the existing `xsd.exe` tool from the .NET Framework SDK to ensure compatibility with existing generated code, while adding additional features like customizable post-processing of the generated output.

## Purpose

This tool was created to replace the manual XSD-to-C# conversion process used in the Firely CQL SDK. The previous approach used a batch script (`Elm.g.cs-Generate.cmd`) that directly called `xsd.exe` and performed post-processing steps. This tool consolidates the `xsd.exe` invocation into a single, maintainable C# application, making it easier to modify and extend in the future.

## Requirements

- .NET 8.0 or later (to build and run the tool)
- Windows operating system (currently required)
- .NET Framework SDK with `xsd.exe` tool installed

**Note**: The tool currently requires Windows because it wraps the `xsd.exe` tool from the .NET Framework SDK. This ensures that the generated output is byte-for-byte identical to the existing generated code. Future versions may support cross-platform XSD processing with alternative code generators that can also add modern C# features like nullable reference type annotations.

## Building

To build the tool:

```bash
cd tools/XsdToCSharpConverter
dotnet build
```

This produces the executable at `bin/Debug/net8.0/xsd2cs.dll`.

For a release build that can be distributed:

```bash
dotnet publish -c Release
```

## Usage

### Basic Syntax

```
dotnet xsd2cs.dll [options] schema1.xsd [schema2.xsd ...]
```

Or if published as a self-contained executable:

```
xsd2cs [options] schema1.xsd [schema2.xsd ...]
```

### Options

- `/c` - Generate classes (default mode)
- `/o:<path>` - Output directory for generated files
- `/n:<namespace>` - Namespace for generated classes
- `/q` - Suppress xsd.exe console output
- `--post-process` - Enable post-processing of generated files (reserved for future use)

### Examples

Generate C# classes from multiple XSD files:
```bash
dotnet xsd2cs.dll /c /o:.. /n:Hl7.Cql.Elm library.xsd expression.xsd clinicalexpression.xsd
```

Suppress console output:
```bash
dotnet xsd2cs.dll /c /q /o:.. /n:Hl7.Cql.Elm schema.xsd
```

## How It Works

1. **Parse Arguments**: The tool parses command-line arguments in the same format as `xsd.exe`
2. **Locate xsd.exe**: It searches for `xsd.exe` in:
   - The system PATH
   - Common .NET Framework SDK installation locations
3. **Generate Code**: It calls `xsd.exe` with the provided arguments
4. **Post-Process**: Framework for custom post-processing is available (currently handled in the calling script)

## Using with Elm.g.cs Generation

To use this tool for generating `Elm.g.cs`, see the `Elm.g.cs-Generate-v2.cmd` script in the `Cql/Elm` directory. This script:

1. Builds the tool if needed
2. Runs the tool to generate C# code from XSD files
3. Post-processes the output to add custom headers and pragma directives
4. Renames the final output

## Testing

To verify that the tool produces identical output to the original xsd.exe approach:

1. On a Windows machine with the .NET Framework SDK installed
2. Run the old `Elm.g.cs-Generate.cmd` script and save a copy of the generated `Elm.g.cs`
3. Run the new `Elm.g.cs-Generate-v2.cmd` script
4. Compare the two generated files byte-for-byte

They should be identical except for any intentional differences in the post-processing comments.

## Future Enhancements

Future versions of this tool may include:

- Native XSD parsing and code generation without dependency on `xsd.exe`
- Cross-platform support (Linux, macOS) using alternative XSD processing libraries
- Nullable reference type annotations in generated code
- Support for modern C# language features (collection expressions, record types, etc.)
- Customizable code templates and formatting options
- Built-in post-processing support with configuration files

## Integration with Build Process

This tool is designed to be used in place of the old `Elm.g.cs-Generate.cmd` batch script. It is **not** included in the main solution file (`Cql-Sdk.slnf`) and is not part of the regular build process. It should be run manually when XSD schemas are updated.

**Important**: Do not add this project to `Cql-Sdk.slnf` or any solution filter used for CI/CD builds. It is a standalone development tool.

## License

This project is licensed under the BSD 3-Clause license. See the LICENSE file in the repository root for details.
