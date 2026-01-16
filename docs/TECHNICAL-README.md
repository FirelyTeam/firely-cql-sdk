# Technical README for Firely CQL SDK Maintainers

This document contains technical details, assumptions, and implementation details for maintaining the Firely CQL SDK.

## Multi-Targeting: .NET 8 and .NET 10

The SDK targets both .NET 8 (LTS) and .NET 10 (LTS) to provide performance benefits from .NET 10 while maintaining compatibility with .NET 8.

### Target Framework Configuration

- **Base configuration**: `cql-base.props` sets `<TargetFrameworks>net8.0;net10.0</TargetFrameworks>`
- **SDK projects**: All library projects (Hl7.Cql.*) target both frameworks
- **Tool projects**: Executable projects like PackagerCLI target both frameworks
- **Example projects**: May target a single framework for simplicity

### System.Text.Json Type Discriminator Conflict (.NET 10 Breaking Change)

#### Problem
.NET 10 introduced a breaking change in `System.Text.Json` where the type discriminator property name cannot conflict with actual property names in polymorphic type hierarchies. The ELM type system uses "type" as both:
1. A discriminator for polymorphic serialization (e.g., distinguishing `ChoiceTypeSpecifier` from `NamedTypeSpecifier`)
2. An actual property in some types (e.g., `ChoiceTypeSpecifier.type` is an array of `TypeSpecifier[]`)

This causes `System.InvalidOperationException` in .NET 10 when setting up polymorphism.

#### Solution
We use **conditional compilation** to handle this difference between .NET 8 and .NET 10:

**Discriminator Names:**
- **.NET 8**: Uses `"type"` as the discriminator (backward compatible with existing ELM JSON)
- **.NET 10**: Uses `"$type"` as the discriminator (avoids conflicts with actual "type" properties)

**Implementation Files:**
1. `Cql/Elm/Serialization/PolymorphicTypeResolver.cs`:
   - Uses `#if NET10_0_OR_GREATER` to conditionally set `TypeDiscriminatorPropertyName`
   - Removes "type" properties from JSON metadata before polymorphism setup

2. `Cql/Elm/Library.Serialization.cs`:
   - **Deserialization preprocessing**: Converts "type" to "$type" in .NET 10 (`CorrectLegacyConstructs`)
   - **Serialization post-processing**: Converts "$type" back to "type" in .NET 10 (`ConvertDollarTypeToType`)
   - This ensures backward compatibility - serialized output uses "type" even in .NET 10

3. `Cql/CoreTests/ElmSerializerTests.cs`:
   - Tests use conditional compilation to provide appropriate JSON for each framework
   - Direct `JsonSerializer.Deserialize` calls need framework-specific discriminators

#### Backward Compatibility
- **Reading**: Both frameworks can read ELM JSON files with "type" discriminators (via preprocessing)
- **Writing**: Both frameworks write ELM JSON files with "type" discriminators (via post-processing in .NET 10)
- **No breaking changes** for consumers of the SDK

### Custom Build Targets

Custom MSBuild targets (e.g., `ElmToCSharp.Targets.xml`, `CqlToElm.Targets.xml`) that generate code or artifacts are configured to **run only once** when multi-targeting:

```xml
<!-- Use ToolTargetFramework property to specify the latest framework -->
<PropertyGroup>
    <ToolTargetFramework>net10.0</ToolTargetFramework>
</PropertyGroup>

<!-- Add condition to only run on the tool framework -->
<Target Name="GenerateCSharp"
        Condition="'$(TargetFramework)' == '$(ToolTargetFramework)' Or '$(TargetFramework)' == ''"
        BeforeTargets="PreBuildEvent">
```

This prevents generating the same artifacts multiple times and ensures tools use the latest framework.

### Package References

**System.Text.Json**:
- .NET 8: Requires explicit PackageReference (previously included)
- .NET 10: Included in the framework, explicit reference causes NU1510 error
- **Solution**: Removed explicit PackageReference as it's transitively included from dependencies

### Code Generation Version Management

When modifying C# code generation logic in `CodeGeneration.NET`, always update `LibrarySetCSharpCodeGenerator.GeneratorToolVersion`:
- The version is in `CodeGeneration.NET/_CODE GENERATOR VERSION_.cs`
- Follow semantic versioning (major.minor.patch.build)
- Ensure `LibraryInstanceInvoker` supports the new version range
- Regenerate libraries after version changes

## Build and Test

### Building
```bash
# Build all SDK projects (recommended - excludes submodules)
dotnet build Cql-Sdk.slnf -c Debug

# Build for specific framework
dotnet build Cql-Sdk.slnf -c Debug --framework net10.0
```

### Testing
```bash
# Run tests for both frameworks
dotnet test Cql/CoreTests/CoreTests.csproj -c Debug

# Run tests for specific framework
dotnet test Cql/CoreTests/CoreTests.csproj -c Debug --framework net10.0
```

### Cross-Platform Considerations
- **Always maintain both PowerShell (.ps1) and Bash (.sh) script variants**
- Use OS-conditional logic in MSBuild: `Condition="'$(OS)' == 'Windows_NT'"` for Windows
- **Use correct case for directory paths** - Unix filesystems are case-sensitive
- Don't hardcode path separators - use MSBuild properties
- PowerShell commands via bash should use `-NonInteractive` flag

## Conditional Compilation Symbols

The SDK uses standard .NET conditional compilation symbols:
- `NET8_0`: Code specific to .NET 8
- `NET10_0`: Code specific to .NET 10
- `NET10_0_OR_GREATER`: Code for .NET 10 and later

Example:
```csharp
#if NET10_0_OR_GREATER
    const string discriminatorName = "$type";
#else
    const string discriminatorName = "type";
#endif
```

## Future .NET Versions

When adding support for future .NET versions (e.g., .NET 12 LTS):
1. Update `cql-base.props` with new target framework
2. Review conditional compilation - may need `NET12_0_OR_GREATER` checks
3. Test System.Text.Json behavior - the "$type" solution should work for .NET 10+
4. Update this documentation
5. Update main README.md
6. Test all custom build targets run only once
7. Update CI/CD pipelines

## Common Issues and Solutions

### Issue: Build artifacts generated multiple times
**Solution**: Ensure custom targets have `Condition="'$(TargetFramework)' == 'net10.0' Or '$(TargetFramework)' == ''"` 

### Issue: System.Text.Json serialization fails in .NET 10
**Solution**: Check if a "type" property conflicts with the discriminator. Use `#if NET10_0_OR_GREATER` to handle differently.

### Issue: Tests fail on one framework but pass on another
**Solution**: Use conditional compilation in tests to provide framework-appropriate JSON or setup.

## Additional Resources

- [.NET 10 Breaking Changes](https://learn.microsoft.com/en-us/dotnet/core/compatibility/10.0)
- [System.Text.Json Polymorphism](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/polymorphism)
- [Multi-Targeting in .NET](https://learn.microsoft.com/en-us/dotnet/standard/frameworks)
