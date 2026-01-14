# XSD to C# Converter

A native, cross-platform tool for generating C# classes from XSD schema files with support for modern C# features.

## Overview

This tool provides a command-line interface for converting XSD (XML Schema Definition) files to C# classes. It includes a custom XSD parser and C# code generator that can be customized to produce modern C# code with nullable annotations and other contemporary language features.

## Purpose

This tool was created to replace the legacy `xsd.exe` tool used in the Firely CQL SDK. The previous approach relied on the Windows-only .NET Framework tool, which:
- Only runs on Windows
- Generates outdated C# code without nullable annotations
- Cannot be customized or extended
- Is no longer actively developed

This new tool provides:
- ✅ **Cross-platform support** (Windows, Linux, macOS)
- ✅ **Customizable code generation** (compatible or modern modes)
- ✅ **Nullable reference type support** (in modern mode)
- ✅ **Future extensibility** for new C# language features
- ✅ **Open source** and actively maintained

## Requirements

- .NET 8.0 or later (to build and run the tool)
- No additional dependencies

## Building

To build the tool:

```bash
cd tools/XsdToCSharpConverter
dotnet build
```

For a release build:

```bash
dotnet build -c Release
```

Or publish as a self-contained executable:

```bash
dotnet publish -c Release -r win-x64 --self-contained
dotnet publish -c Release -r linux-x64 --self-contained  
dotnet publish -c Release -r osx-x64 --self-contained
```

## Usage

### Basic Syntax

```bash
dotnet xsd2cs.dll [options] schema1.xsd [schema2.xsd ...]
```

Or if published as self-contained:

```bash
xsd2cs [options] schema1.xsd [schema2.xsd ...]
```

### Options

- `/c` - Generate classes (default mode)
- `/o:<path>` - Output directory for generated files
- `/n:<namespace>` - Namespace for generated classes
- `/out:<filename>` - Output filename (default: derived from first schema file)

### Examples

**Generate C# classes (compatible mode, matches xsd.exe output):**
```bash
dotnet xsd2cs.dll /c /o:.. /n:Hl7.Cql.Elm library.xsd expression.xsd
```

**Generate with custom output filename:**
```bash
dotnet xsd2cs.dll /c /o:.. /n:Hl7.Cql.Elm /out:elmv2.g.cs library.xsd expression.xsd
```

## How It Works

1. **Parse XSD Files**: Loads and compiles one or more XSD schema files using `System.Xml.Schema`
2. **Build Type Model**: Extracts complex types, simple types, elements, and attributes from the schemas
3. **Generate C# Code**: Creates C# classes, properties, enums, and attributes using `System.CodeDom`
4. **Apply Customizations**: Adds XML serialization attributes and applies generation mode (compatible or modern)
5. **Write Output**: Writes formatted C# code to the specified output file

## Generation Modes

### Compatible Mode (Default)

Generates C# code that matches the style and structure of the legacy `xsd.exe` tool:
- No nullable annotations
- Traditional property patterns with private fields
- Same attribute placement and naming conventions
- Compatible with existing generated code

### Modern Mode (`--modern`)

Generates contemporary C# code with:
- Nullable reference type annotations (`?` for nullable, `!` for non-null)
- Modern C# language features
- Improved code style and formatting
- Better IDE support and compile-time safety

**Note:** Modern mode is planned for future implementation. Currently, only compatible mode is fully supported.

## Using with Elm.g.cs Generation

The `Cql/Elm` directory contains updated scripts that use this tool:

**Windows:**
```cmd
cd Cql\Elm
Elm.g.cs-Generate-v2.cmd
```

**Linux/macOS:**
```bash
cd Cql/Elm
./Elm.g.cs-Generate-v2.sh
```

These scripts automatically build the tool if needed, run the generation, and perform post-processing.

## Cross-Platform Compatibility

This tool is designed to work on all platforms supported by .NET 8.0:
- ✅ Windows (x64, x86, ARM64)
- ✅ Linux (x64, ARM64)
- ✅ macOS (x64, ARM64)

No platform-specific code or dependencies are used.

## Customization

The code generator can be customized by modifying:
- `XsdCodeGenerator.cs` - Main generation logic
- `CommandLineOptions.cs` - Command-line options and modes
- Generation modes for different output styles

Future enhancements may include:
- Configuration files for code generation settings
- Templates for customizing output format
- Plugins for extending generation logic

## Integration with Build Process

This tool is **not** included in the main solution file (`Cql-Sdk.slnf`) as it's a development tool, not part of the SDK itself. It should be run manually when XSD schemas are updated.

**Important**: Do not add this project to solution filters used for CI/CD builds.

## Troubleshooting

### Schema Validation Errors

If you see errors like "Undefined complexType", ensure you're passing all related schema files together:

```bash
# Wrong - missing dependencies
xsd2cs /c library.xsd

# Correct - all schemas together
xsd2cs /c library.xsd expression.xsd clinicalexpression.xsd cqlannotations.xsd
```

### Output File Issues

By default, the output file is named after the first schema file. Use `/o:` to specify a different output directory.

## Future Enhancements

Planned features for future versions:
- Full implementation of modern mode with nullable annotations
- Support for record types and init-only properties
- Collection expressions for arrays and lists
- Pattern matching in generated code
- Custom code generation templates
- Configuration file support
- Plugin system for extensibility

## License

This project is licensed under the BSD 3-Clause license. See the LICENSE file in the repository root for details.
