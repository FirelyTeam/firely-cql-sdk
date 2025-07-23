# CQL SDK Examples Preview

This project provides a comprehensive examples framework for internal and experimental features of the Firely CQL SDK that are not yet available to external projects.

## Purpose

When developing new features for the Firely CQL SDK, they are often kept internal (or flagged with `ExperimentalAttribute`) until they become stable. This preview project has special access to these internal features through `InternalsVisibleTo` attributes, allowing developers to:

- Test experimental features before they become public API
- Create structured examples for internal functionality
- Prototype new capabilities
- Debug internal behavior

## Project Structure

This project follows the same structured approach as `CqlSdkExamples`, with individual example directories and a centralized runner system:

```
CqlSdkExamplesPreview/
├── 000 Run All/           # Run all examples sequentially
├── Program.cs             # Main example picker and utilities
├── Main.cs                # Entry point
├── Properties/            # Launch settings for debugging
└── README.md
```

## Internal Access

This project has been granted internal access to the following SDK projects through `InternalsVisibleTo` attributes:

- `Hl7.Cql.Invocation` - Core invocation and toolkit functionality
- `Hl7.Cql.Runtime` - Runtime and execution engine
- `Hl7.Cql.Abstractions` - Base abstractions and comparers
- `Hl7.Cql.CodeGeneration.NET` - Code generation features

## Running Examples

### Run All Examples
```bash
cd Examples/CqlSdkExamplesPreview
dotnet run 000
```

### Run Specific Example
```bash
cd Examples/CqlSdkExamplesPreview
dotnet run <example-code>
```

### Available Examples
- `000` - Run All: Executes all available examples sequentially

*Note: Additional examples will be added as internal features are developed.*

## Development Setup

The project includes MSBuild tasks that automatically:
- Update current directory references in example code
- Configure launch settings for debugging
- Handle project dependencies and build configurations

### Project Reference Options

The project supports multiple dependency configurations:

1. **Project References** (default): Direct references for debugging SDK code
2. **Local NuGet Packages**: Built with `build-local-nuget.ps1`
3. **Public NuGet Packages**: From the official NuGet feed

## Differences from CqlSdkExamples

Unlike the main `CqlSdkExamples` project, this preview project:

- Can access `internal` classes, methods, and properties from SDK projects
- Is intended for SDK developers and contributors
- May use unstable APIs that could change in future versions
- Focuses specifically on experimental and internal functionality
- Uses the same structured framework but for preview features

## Adding New Examples

To add examples for new internal features:

1. **Create Example Directory**: Add a new numbered directory (e.g., `100 My Internal Feature/`)
2. **Add Program.cs**: Create `Program.cs` in the directory with your example code
3. **Update Switch Statement**: Add your example code to the switch in `Program.cs`
4. **Update RunAll**: Add your example to the `RunAll()` method in `000 Run All/Program.cs`
5. **Test**: Verify the example works with both Debug and Release builds

### Example Template

```csharp
namespace CqlSdkExamplesPreview;

partial class Program
{
    void MyInternalFeatureExample()
    {
        SetCurrentDirectory(Path.Combine(InitialCurrentDirectory, "100 My Internal Feature"));
        
        // Your example code using internal APIs
        Console.WriteLine("Demonstrating internal feature...");
        
        // Access internal types and members here
    }
}
```

## Important Notes

- This project is for development and testing purposes only
- Internal APIs may change without notice
- Examples here should not be used as production code patterns
- When internal features become public, consider moving examples to the main `CqlSdkExamples` project
- The build system automatically manages directory references and launch settings during development