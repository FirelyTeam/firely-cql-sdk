# Copilot Testing Instructions for CQL SDK

This document provides comprehensive testing instructions for the Firely CQL SDK to ensure full test coverage when making changes.

## Build and Test Overview

The CQL SDK uses Azure Pipelines for CI/CD with multiple stages. For complete testing, you need to:

1. **Build the main solution** - `Cql-Sdk-All.sln`
2. **Package using the filtered solution** - `Cql-Sdk.slnf` 
3. **Run all test projects**
4. **Build demo projects** that depend on the SDK

## Required .NET and Java Versions

- **.NET SDK**: 8.0.x (as specified in build/variables.yml)
- **Java**: OpenJDK 17+ (required for CQL-to-ELM generation via Maven)
- **Maven**: 3.9+ (required for downloading Java CQL tooling)
- **Build Configuration**: Release
- **Target Platform**: Cross-platform (Windows/Linux/macOS)

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

## Java Tooling and ELM Generation

The CQL SDK uses Java-based tooling for converting CQL files to ELM (Expression Logical Model) format. This is essential for full testing coverage.

### Java Setup Verification
```bash
# Verify Java and Maven are available
java -version    # Should be Java 17+
mvn -version     # Should be Maven 3.9+
```

### ELM Generation Process
```bash
# Download Java CQL tooling via Maven (executed in Demo/Cql/Build/)
cd Demo/Cql/Build
mvn dependency:copy-dependencies

# Build projects with ELM generation enabled
dotnet build Demo/Measures.Authoring/Measures.Authoring.csproj --configuration Release
```

The ELM generation uses:
- **Maven POM**: `Demo/Cql/Build/pom.xml` - Defines CQL-to-ELM CLI version (currently 3.27.0)
- **Maven Targets**: `Demo/Cql/Build/Mvn.Targets.xml` - MSBuild integration for Maven
- **CQL to ELM**: `Demo/Cql/Build/CqlToElm.Targets.xml` - Converts .cql files to .json ELM
- **ELM to C#**: `Demo/Cql/Build/ElmToCSharp.Targets.xml` - Generates C# from ELM

### Common ELM Issues

1. **Missing Generated Files**: If tests fail with "Source file '*.g.cs' could not be found"
   - Check if Maven downloaded dependencies: `Demo/Cql/Build/target/dependency/`
   - Rebuild with ELM generation: `dotnet build -p:ElmToCSharpEnabled=true`

2. **Java Version Conflicts**: CQL tooling requires Java 17+
3. **Path Issues**: Some test files use Windows-style paths (`Input\Path`) that fail on Linux

## Step-by-Step Testing Process

### 1. Initial Setup
```bash
# Ensure .NET 8.0 and Java 17+ are available
dotnet --version
java -version
mvn -version

# Restore all dependencies (without GitHub packages for public builds)
dotnet restore Cql-Sdk.slnf
```

### 2. Download Java CQL Tooling
```bash
# Download Maven dependencies for CQL-to-ELM conversion
cd Demo/Cql/Build
mvn dependency:copy-dependencies
cd ../../..
```

### 3. Build Core SDK
```bash
# Build the main solution in Release configuration
dotnet build Cql-Sdk.slnf --configuration Release --no-restore
```

### 4. Run Core Tests (Expected: Some failures due to cross-platform path issues)
```bash
# Run all test projects individually to isolate failures
dotnet test Cql/CoreTests/CoreTests.csproj --configuration Release --no-build
dotnet test Cql/CqlToElmTests/CqlToElmTests.csproj --configuration Release --no-build
```

### 5. Test Demo Projects with ELM Generation
```bash
# Build demo projects that generate ELM and C# files
dotnet build Demo/Measures.Authoring/Measures.Authoring.csproj --configuration Release --no-restore
dotnet build Demo/CLI/CLI.csproj --configuration Release --no-restore
dotnet build Demo/Measures.Demo/Measures.Demo.csproj --configuration Release --no-restore
dotnet build Demo/Measures.CMS/Measures.CMS.csproj --configuration Release --no-restore
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

### 4. **Cross-Platform Path Issues**
- Hardcoded Windows paths like `@"Input\ELM\Libs\file.json"` fail on Linux/macOS
- Use `Path.Combine()` or forward slashes for cross-platform compatibility
- Common in test files that reference Input directories

### 5. **Null Reference Issues**
- SDK6 has stricter null checking
- Add null-conditional operators where needed
- Check for nullable reference warnings

### 6. **Code Generation Issues**
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

### Submodule and Authentication Issues

**Note for Copilot Users**: This repository includes NCQA copyrighted submodules that may not be accessible in all environments:

```
submodules/Ncqa.DQIC/             # NCQA proprietary code
submodules/Firely.Cql.Sdk.Integration.Runner/  # May require GitHub auth
```

If submodules are empty or inaccessible:
- Focus testing on core projects: `Cql-Sdk.slnf` (filtered solution)
- Avoid building `Cql-Sdk-All.sln` which includes submodules
- Use public NuGet feeds only: `dotnet restore Cql-Sdk.slnf`

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