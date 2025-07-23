# CQL SDK Examples Preview

This project provides examples for internal and experimental features of the Firely CQL SDK that are not yet available to external projects.

## Purpose

When developing new features for the Firely CQL SDK, they are often kept internal (or flagged with `ExperimentalAttribute`) until they become stable. This preview project has special access to these internal features through `InternalsVisibleTo` attributes, allowing developers to:

- Test experimental features before they become public API
- Create examples for internal functionality
- Prototype new capabilities
- Debug internal behavior

## Internal Access

This project has been granted internal access to the following SDK projects through `InternalsVisibleTo` attributes:

- `Hl7.Cql.Invocation` - Core invocation and toolkit functionality
- `Hl7.Cql.Runtime` - Runtime and execution engine
- `Hl7.Cql.Abstractions` - Base abstractions and comparers
- `Hl7.Cql.CodeGeneration.NET` - Code generation features

## Running the Example

```bash
cd Examples/CqlSdkExamplesPreview
dotnet run
```

The example demonstrates:
1. Basic CQL execution (same as the public examples)
2. Access to internal SDK features (like `StringBuilderExtensions.AppendMember`)

## Differences from CqlSdkExamples

Unlike the main `CqlSdkExamples` project, this preview project:

- Can access `internal` classes, methods, and properties from SDK projects
- Is intended for SDK developers and contributors
- May use unstable APIs that could change in future versions
- Has a simpler structure focused on demonstrating internal features

## Adding New Examples

To add examples for new internal features:

1. Create a new example method in `Program.cs`
2. Access the internal APIs you need to demonstrate
3. Document any experimental features being used
4. Test that the example works with both Debug and Release builds

## Important Notes

- This project is for development and testing purposes only
- Internal APIs may change without notice
- Examples here should not be used as production code patterns
- When internal features become public, consider moving examples to the main `CqlSdkExamples` project