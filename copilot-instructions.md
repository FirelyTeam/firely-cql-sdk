# Copilot Testing Instructions for CQL SDK

This document provides comprehensive testing instructions for the Firely CQL SDK to ensure full test coverage when making changes.

## Build and Test Overview

The CQL SDK uses Azure Pipelines for CI/CD with multiple stages. For complete testing, you need to:

1. **Build the main solution** - `Cql-Sdk-All.sln`
2. **Package using the filtered solution** - `Cql-Sdk.slnf` 
3. **Run all test projects**
4. **Build demo projects** that depend on the SDK

## Required .NET Version

- **.NET SDK**: 8.0.x (as specified in build/variables.yml)
- **Build Configuration**: Release
- **Target Platform**: Windows (vmImage: windows-latest)

## Critical Test Projects

Based on `azure-pipelines.yml`, these test projects must pass:

### Core Test Projects
```
Cql/CoreTests/CoreTests.csproj
Cql/CqlToElmTests/CqlToElmTests.csproj
Demo/Test.Measures.Demo/Test.Measures.Demo.csproj
```

### Integration Test Projects
```
submodules/Firely.Cql.Sdk.Integration.Runner/IntegrationRunner/IntegrationRunner.csproj
```

**Note**: Exclude `Ncqa.HT.DeckTests.csproj` - this is explicitly excluded in the pipeline.

## Demo Projects That Must Build

These demo projects are critical and often fail when SDK changes break compatibility:

```
Demo/CLI/CLI.csproj
Demo/Measures.Demo/Measures.Demo.csproj
Demo/Measures.CMS/Measures.CMS.csproj
Demo/Measures.Authoring/Measures.Authoring.csproj
```

## Submodule Projects

The repository includes git submodules that must also build:

```
submodules/Ncqa.DQIC/ (various projects)
```

## Step-by-Step Testing Process

### 1. Initial Setup
```bash
# Ensure .NET 8.0 is available
dotnet --version

# Restore all dependencies (with submodules)
dotnet restore Cql-Sdk-All.sln --source https://nuget.pkg.github.com/FirelyTeam/index.json
```

### 2. Build Core SDK
```bash
# Build the main solution in Release configuration
dotnet build Cql-Sdk-All.sln --configuration Release --no-restore
```

### 3. Run Core Tests
```bash
# Run all test projects individually to isolate failures
dotnet test Cql/CoreTests/CoreTests.csproj --configuration Release --no-build
dotnet test Cql/CqlToElmTests/CqlToElmTests.csproj --configuration Release --no-build
dotnet test Demo/Test.Measures.Demo/Test.Measures.Demo.csproj --configuration Release --no-build
```

### 4. Test Demo Projects
```bash
# Build demo projects that are commonly affected by SDK changes
dotnet build Demo/CLI/CLI.csproj --configuration Release --no-restore
dotnet build Demo/Measures.Demo/Measures.Demo.csproj --configuration Release --no-restore
dotnet build Demo/Measures.CMS/Measures.CMS.csproj --configuration Release --no-restore
dotnet build Demo/Measures.Authoring/Measures.Authoring.csproj --configuration Release --no-restore
```

### 5. Test Integration Runner
```bash
# Test the integration runner if available
dotnet test submodules/Firely.Cql.Sdk.Integration.Runner/IntegrationRunner/IntegrationRunner.csproj --configuration Release
```

### 6. Package Validation
```bash
# Test packaging solution builds correctly
dotnet build Cql-Sdk.slnf --configuration Release --no-restore
```

## Common SDK6 Migration Issues to Watch For

When upgrading to FHIR SDK6, pay attention to these common failure patterns:

### 1. **Serialization Issues**
- Look for `FhirJsonPocoDeserializerSettings` not found errors
- SDK6 renamed/moved serialization classes

### 2. **Property Access Issues** 
- `ObjectValue` → `JsonValue` property changes
- `DefinitionPath` → `Canonical` property changes  
- Missing `new` modifiers on inherited properties

### 3. **Reflection Issues**
- Ambiguous property matches (especially Code<T>.Value)
- Missing BindingFlags.DeclaredOnly in reflection calls
- ReflectionHelper class changes

### 4. **Null Reference Issues**
- SDK6 has stricter null checking
- Add null-conditional operators where needed
- Check for nullable reference warnings

### 5. **Code Generation Issues**
- PackagerCLI dependency on updated SDK methods
- Generated C# files may fail to compile if templates aren't updated

## Debugging Failed Builds

### Common Error Patterns

1. **Missing Generated Files**:
   ```
   Source file 'CSharp\*.g.cs' could not be found
   ```
   - Usually indicates PackagerCLI failed to generate code
   - Check PackagerCLI build first

2. **Type Not Found**:
   ```
   The type or namespace name 'FhirJsonPocoDeserializerSettings' could not be found
   ```
   - SDK6 compatibility issue
   - Need to update to new SDK6 equivalents

3. **Ambiguous Match**:
   ```
   Ambiguous match found for 'System.Nullable`1[...] Value'
   ```
   - Use BindingFlags.DeclaredOnly in reflection
   - Common with Code<T> properties

### Incremental Testing Strategy

1. **Start with core projects**: Elm, Cql.Runtime, Cql.Compiler
2. **Move to FHIR integration**: Cql.Firely, Cql.Packaging  
3. **Test packaging tools**: PackagerCLI
4. **Validate demos**: CLI, Measures projects
5. **Run integration tests**: Test projects

## Files to Monitor During SDK Upgrades

- `cql-base.props` - Version definitions
- `cql-demo.props` - Demo project versions
- `Cql.Firely/` - FHIR SDK integration layer
- `Cql.Packaging/` - FHIR resource packaging
- `PackagerCLI/` - Code generation tool
- `Demo/CLI/` - Command line interface

## Quick Validation Commands

```bash
# Quick smoke test - should all succeed
dotnet build Cql/Cql.Firely/Cql.Firely.csproj --configuration Release
dotnet build Cql/Cql.Packaging/Cql.Packaging.csproj --configuration Release  
dotnet build Cql/PackagerCLI/PackagerCLI.csproj --configuration Release
dotnet test Cql/CoreTests/CoreTests.csproj --configuration Release
```

If these core components build and test successfully, the SDK upgrade is likely complete.