# Technical README for Firely CQL SDK Maintainers

This document contains technical details, assumptions, and implementation details for maintaining the Firely CQL SDK.

## Target Framework: .NET 10

The SDK targets .NET 10 (LTS) only.

### Target Framework Configuration

- **Base configuration**: `cql-base.props` sets `<TargetFrameworks>net10.0</TargetFrameworks>` and pins `<LangVersion>`
- **SDK projects**: All library projects (Hl7.Cql.*) inherit it
- **Tool projects**: Executable projects like PackagerCLI inherit it
- **Example projects**: Set `<TargetFramework>net10.0</TargetFramework>` directly

`LangVersion` is pinned rather than set to `latest`, because `latest` is compiler-wide rather than
per-target-framework: it resolves to whatever the installed SDK supports and so can differ between
machines. Raise it together with the target framework. Should the repo ever multi-target again, that
needs one Condition'd `LangVersion` per framework rather than a single value.

### System.Text.Json Type Discriminator Conflict (.NET 10 Breaking Change)

.NET 10 rejects a polymorphic type that has a JSON property named like its type discriminator. ELM JSON uses `"type"`
as the discriminator, so no ELM type may expose a JSON property named `type`.

The ELM model has none. The properties named `type` with a complex type (`ChoiceTypeSpecifier.type`,
`TupleElementDefinition.type`) carry `[JsonIgnore]`, which `XsdCodeGenerator` in `tools/XsdToCSharpConverter` adds
during generation, so `Elm.g.cs` needs no manual edits and XML serialization still uses them.

Polymorphism is System.Text.Json's native one, configured once per type by `PolymorphicTypeResolver` from the
`[XmlInclude]` attributes. Old-style discriminators on concrete types (`"type": "IncludeDef"` on an `IncludeDef`) are
accepted by registering concrete types as their own derived type in the read options only; the write options do not,
so they emit no such discriminator. `LibraryJsonSerializer.CorrectLegacyConstructs` corrects legacy JSON before it is
deserialized.

See [Cql/Elm/Serialization/README.md](../Cql/Elm/Serialization/README.md) for the architecture.

#### Framework-Agnostic Behavior
The serialization layer carries no framework-conditional code: one "type" discriminator for
polymorphism, one JSON format, and no conditional compilation.

### Custom Build Targets

Custom MSBuild targets (e.g., `ElmTooling.Targets.xml`, `CqlTooling.Targets.xml`) that generate code or artifacts are gated on `ToolTargetFramework`, so they still **run only once** should the repo multi-target again:

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

This prevents generating the same artifacts once per framework, and ensures tools use the latest framework.

### Package References

**System.Text.Json**:
- Included in the .NET 10 framework; an explicit `PackageReference` causes an NU1510 error
- There is therefore no explicit reference — it comes in transitively from dependencies

**Microsoft.CodeAnalysis.CSharp**:
- Used for runtime C# compilation in CodeGeneration.NET
- Provides cross-platform Roslyn compiler APIs
- The pinned version lives in [`Directory.Packages.props`](../Directory.Packages.props) (`MicrosoftCodeAnalysisVersion`) and is deliberately not repeated here

### Code Generation Version Management

`GeneratorToolVersion` is a separate scale from the SDK package version, which uses EffVer — see [versioning.md](versioning.md). The generator version *does* follow SemVer.

When modifying C# code generation logic in `CodeGeneration.NET`, always update `LibrarySetCSharpCodeGenerator.GeneratorToolVersion`:
- The version is in `CodeGeneration.NET/_CODE GENERATOR VERSION_.cs`
- Follow semantic versioning (major.minor.patch.build) — this applies to the **generator** version only, not to the SDK package version
- Ensure `LibraryInstanceInvoker` supports the new version range
- Regenerate libraries after version changes
- Any change here makes the next SDK release at least MESO, because consumers regenerate

## Build and Test

### Building
```bash
# Build all SDK projects (recommended - excludes submodules)
dotnet build Cql-Sdk.slnf -c Debug

```

### Testing

#### Local Testing
```bash
dotnet test Cql/CoreTests/CoreTests.csproj -c Debug
dotnet test Cql/CqlToElmTests/CqlToElmTests.csproj -c Debug
```

#### CI/CD Testing
The repository includes `build/build-test-sign.yml`, a dedicated Azure Pipelines template that builds, signs and packages once, then runs the test jobs in parallel against those artifacts.

**Configuration:**
Testing is **fully integrated** and runs automatically on every build, in a dedicated stage after the main build stage.

**Test Categories:**
1. **Unit Tests** (`unitTestProjects`):
   - `Cql/CoreTests/CoreTests.csproj` - Core SDK tests
   - `Cql/CqlToElmTests/CqlToElmTests.csproj` - CQL to ELM conversion tests

2. **Integration Tests**:
   - `submodules/Firely.Cql.Sdk.Integration.Runner/IntegrationRunner/IntegrationRunner.csproj`
   - `submodules/Firely.Cql.Sdk.Integration.Runner/Hedis2025.GoldenTests/Hedis2025.GoldenTests.csproj`

3. **Excluded Tests**:
   - `tools/XsdToCSharpConverterTests/XsdToCSharpConverterTests.csproj` - Internal tool tests
   - `Demo/Test.Measures.Demo/Test.Measures.Demo.csproj` - needs the Demo project to generate resources

**Usage:** See [build/README.md](../build/README.md) for complete documentation and configuration details.

### Cross-Platform Considerations
- **Always maintain both PowerShell (.ps1) and Bash (.sh) script variants**
- Use OS-conditional logic in MSBuild: `Condition="'$(OS)' == 'Windows_NT'"` for Windows
- **Use correct case for directory paths** - Unix filesystems are case-sensitive
- Don't hardcode path separators - use MSBuild properties
- PowerShell commands via bash should use `-NonInteractive` flag

## Conditional Compilation Symbols

The SDK uses no framework-conditional compilation, and with a single target framework there is
nothing for it to switch on. The standard symbols (`NET10_0`, `NET10_0_OR_GREATER`, ...) are
available if a future multi-targeting change needs them.

**Note**: The serialization architecture avoids conditional compilation entirely, by using automatic `[JsonIgnore]` attribute generation and System.Text.Json's native polymorphism.

## Future .NET Versions

When moving to or adding a future .NET version:
1. Update `cql-base.props` with the new target framework, and raise `LangVersion` with it
2. Test System.Text.Json behavior - the `[JsonIgnore]` solution should continue to work
3. Review whether any conditional compilation is needed (should be none)
4. Update this documentation
5. Update main README.md
6. Check all custom build targets still run only once
7. Update CI/CD pipelines (`build/variables.yml` SDK version, and the SDK install tasks in `build/build-test-sign.yml`)
8. Record the change in a `docs/releases/vnext/` fragment — adding or dropping a target framework is breaking

## Common Issues and Solutions

### Issue: Build artifacts generated multiple times
**Solution**: Ensure custom targets have `Condition="'$(TargetFramework)' == 'net10.0' Or '$(TargetFramework)' == ''"` 

### Issue: System.Text.Json serialization fails with "type" property conflicts
**Solution**: Regenerate `Elm.g.cs` using the updated `XsdCodeGenerator` which automatically adds `[JsonIgnore]` attributes to conflicting properties.

### Issue: Tests pass locally but fail on a newer runtime
**Solution**: The runtime, not just the target framework, can change behavior — a .NET 11 run of the
same binaries fails UCUM quantity arithmetic because `double`-to-`decimal` conversion is now
correctly rounded. Check the breaking-change list for the runtime in question before assuming the
test is at fault.

## Additional Resources

- [.NET 10 Breaking Changes](https://learn.microsoft.com/en-us/dotnet/core/compatibility/10.0)
- [System.Text.Json Polymorphism](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/polymorphism)
- [ELM JSON Serialization Architecture](../Cql/Elm/Serialization/README.md) - Complete technical documentation of the serialization system
