# XSD to C# Converter (xsd2cs)

A native, cross-platform tool for generating C# classes from XSD schema files, producing output functionally identical to Microsoft's legacy `xsd.exe` tool.

## Overview

This tool provides a command-line interface for converting XSD (XML Schema Definition) files to C# classes. It uses `System.Xml.Schema` for parsing and `System.CodeDom` for code generation, ensuring cross-platform compatibility while maintaining backward compatibility with xsd.exe-generated code.

## Purpose

This tool was created to replace the legacy `xsd.exe` tool used in the Firely CQL SDK. The previous approach relied on the Windows-only .NET Framework tool, which:
- Only runs on Windows
- Cannot be customized or extended
- Is no longer actively developed
- Uses .NET Framework-only APIs (`XmlSchemaImporter`/`XmlCodeExporter`)

This new tool provides:
- ✅ **Cross-platform support** (Windows, Linux, macOS)
- ✅ **Backward compatibility** - generates functionally identical code to xsd.exe for ELM schemas
- ✅ **Feature parity for ELM needs** - arrays, inheritance, enums, attributes, abstract types
- ✅ **Modern .NET APIs** - uses System.CodeDom available on all platforms
- ✅ **Future extensibility** for nullable annotations and modern C# features
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

## Features

### Current Implementation (v1.0)

Generates C# code that matches the output of the legacy `xsd.exe` tool:
- ✅ **Full type support**: Complex types, simple types, enums, inheritance
- ✅ **Complete attribute generation**: XmlElement, XmlArray, XmlArrayItem, XmlAttribute, XmlRoot, XmlInclude, DefaultValue
- ✅ **Abstract types**: Properly marks abstract XSD types as abstract C# classes
- ✅ **Array handling**: Both array wrapper patterns and direct array elements
- ✅ **Default values**: Constructor initialization for fields with defaults
- ✅ **`*Specified` pattern**: Boolean flags for optional value type attributes
- ✅ **Mixed content**: Support for IsMixed complex types with Text property
- ✅ **Type ordering**: Root element types first, then document order
- ✅ **Exact formatting**: Block bracing style matching xsd.exe output
- ✅ **JSON discriminator conflict handling**: Automatically adds `[JsonIgnore]` to properties named `"type"` with complex types to avoid conflicts with JSON polymorphic type discriminators

### Future Enhancements

Potential features for future versions:
- **.NET 10 serialization support** - Update generated code for .NET 10's enhanced serialization features
- Nullable reference type annotations (Phase 2)
- Modern C# features: record types, init properties, collection expressions (Phase 3)
- Custom code generation templates (Phase 4)

## Using with Elm.g.cs Generation

The `Cql/Elm` directory contains a script that uses this tool:

**Windows:**
```cmd
cd Cql\Elm
Elm.g.cs-Generate-xsd2cs.cmd
```

This script automatically builds the tool if needed, runs the generation, and adds the appropriate file header.

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

## Testing

The tool includes comprehensive unit tests validating all features:

**XsdToCSharpConverterTests** (`tools/XsdToCSharpConverterTests/`):
- Round-trip JSON serialization/deserialization tests
- Tests loading from LibrarySets/Demo/Elm directory
- Validates default value initialization

**ElmSerializerTests** (`Cql/CoreTests/`):
- 13 comprehensive tests covering all quirks and features
- DefaultValueAttribute with constructor initialization
- *Specified pattern behavior
- XmlElementAttribute for array elements
- XmlIncludeAttribute for polymorphic types
- Abstract type generation
- Type ordering with XmlRootAttribute
- Tool identification (GeneratedCodeAttribute)

## License

This project is licensed under the BSD 3-Clause license. See the LICENSE file in the repository root for details.
