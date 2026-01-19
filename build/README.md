# Build and CI/CD Pipeline Documentation

This directory contains Azure Pipelines configuration for building, testing, and deploying the Firely CQL SDK with multi-targeting support for .NET 8 (LTS) and .NET 10 (LTS).

## Files

### `azure-pipelines.yml`
Main pipeline configuration that orchestrates the complete CI/CD process with the following stages:

1. **checkForDocChangesStage**: Checks if only documentation changed (skips build if so)
2. **buildTestAndSign**: Three parallel jobs that build, test, and sign for .NET 8 and .NET 10, plus integration tests
3. **deployToGitHub**: Deploys to GitHub Packages (non-PR builds only)
4. **deployToNuget**: Deploys to NuGet.org (release tags only)

### `variables.yml`
Centralized variables used across pipeline configurations:
- `buildConfiguration`: Build configuration (Release)
- `vmImage`: VM image for build agents (windows-latest)
- `DOTNET_CORE_SDK`: .NET SDK version (10.0.x)
- API keys for package deployment
- **Test project configuration**:
  - `multiTargetTestProjects`: Projects tested on both .NET 8 and .NET 10 (CoreTests, CqlToElmTests)
  - `net10IntegrationTestProjects`: Projects tested only on .NET 10 (IntegrationRunner)
  - `excludedTestProjects`: Projects excluded from all test runs (XsdToCSharpConverterTests, NCQA tests)

### `build-test-sign.yml`
Reusable Azure Pipelines template that implements the complete build, test, and sign workflow. This template creates three parallel jobs:
- **Build, Test and Sign for .NET 8**: Builds solution, tests CoreTests/CqlToElmTests on .NET 8, signs assemblies, packages NuGet packages
- **Build, Test and Sign for .NET 10**: Builds solution, tests CoreTests/CqlToElmTests on .NET 10, signs assemblies, packages NuGet packages  
- **Build and IntegrationRunner Test for .NET 10**: Builds solution and tests IntegrationRunner on .NET 10 (no signing/packaging)

All three jobs run in parallel to maximize efficiency while ensuring comprehensive testing across both target frameworks.

## Pipeline Architecture

### Stage Dependencies

```
checkForDocChangesStage
        ↓
buildTestAndSign (3 parallel jobs run simultaneously)
    ├─ Build, Test and Sign for .NET 8
    ├─ Build, Test and Sign for .NET 10
    └─ Build and IntegrationRunner Test for .NET 10
        ↓
  deployToGitHub (GitHub Packages)
        ↓
  deployToNuget (NuGet.org, tags only)
```

**Key Benefits of This Architecture**:
- **Zero duplicate builds** - Each job builds exactly once for its purpose
- **Maximum parallelization** - All three jobs start simultaneously
- **Integrated build/test/sign** - No sequential dependency between build and test
- **Independent integration tests** - IntegrationRunner doesn't block SDK packaging
- **All tests gate deployment** - Cannot deploy unless all three jobs succeed

## Multi-Framework Testing

### Overview
The SDK targets both .NET 8 (LTS) and .NET 10 (LTS) to leverage .NET 10 performance improvements while maintaining broad compatibility. The `build-test-sign.yml` template implements three parallel jobs that build, test, and sign for both frameworks simultaneously to verify identical behavior and eliminate duplicate builds.

### Test Project Configuration

All test project specifications are centralized in `variables.yml`:

**Multi-Target Tests** (tested on both .NET 8 and .NET 10):
- `Cql/CoreTests/CoreTests.csproj` - Core SDK unit tests
- `Cql/CqlToElmTests/CqlToElmTests.csproj` - CQL to ELM conversion tests

**.NET 10 Integration Tests** (tested only on .NET 10):
- `submodules/Firely.Cql.Sdk.Integration.Runner/IntegrationRunner/IntegrationRunner.csproj` - Integration test suite

**Excluded Tests** (not run in pipeline):
- `tools/XsdToCSharpConverterTests/XsdToCSharpConverterTests.csproj` - Internal tool tests
- `submodules/Ncqa.DQIC/Ncqa.HT.DeckTests/Ncqa.HT.DeckTests.csproj` - External NCQA tests
- `submodules/Ncqa.DQIC/Ncqa.HT.MeasuresTests/Ncqa.HT.MeasuresTests.csproj` - External NCQA tests

### Pipeline Integration

The `buildTestAndSign` stage in `azure-pipelines.yml` uses the template with parameters from `variables.yml`:

```yaml
- stage: buildTestAndSign
  displayName: 'Build, Test and Sign'
  dependsOn: checkForDocChangesStage
  jobs:
  - template: build-test-sign.yml
    parameters:
      dotNetCoreVersion: $(DOTNET_CORE_SDK)
      multiTargetTestProjects: $(multiTargetTestProjects)
      net10IntegrationTestProjects: $(net10IntegrationTestProjects)
      buildConfiguration: $(buildConfiguration)
      checkoutSubmodules: 'true'
      # Additional signing parameters...
```

### Modifying Test Configuration

To add, remove, or change test projects, edit `variables.yml`:

```yaml
variables:
  multiTargetTestProjects: |
    Cql/CoreTests/CoreTests.csproj
    Cql/CqlToElmTests/CqlToElmTests.csproj
    # Add new multi-target test projects here
  
  net10IntegrationTestProjects: |
    submodules/Firely.Cql.Sdk.Integration.Runner/IntegrationRunner/IntegrationRunner.csproj
    # Add new .NET 10-only integration test projects here
  
  excludedTestProjects: |
    !**/XsdToCSharpConverterTests.csproj
    !**/Ncqa.HT.DeckTests.csproj
    !**/Ncqa.HT.MeasuresTests.csproj
    # Add additional test exclusions here
```

### Usage

Multi-framework testing is fully integrated into `azure-pipelines.yml` and runs automatically on every build (unless only documentation changed). The three parallel jobs execute simultaneously, providing fast feedback while ensuring framework parity.

#### Running Tests Locally

Before pushing changes, verify tests pass on both target frameworks:

**Test specific projects on specific frameworks**:
```bash
# Test CoreTests on .NET 8
dotnet test Cql/CoreTests/CoreTests.csproj --framework net8.0

# Test CoreTests on .NET 10
dotnet test Cql/CoreTests/CoreTests.csproj --framework net10.0

# Test CqlToElmTests on both frameworks
dotnet test Cql/CqlToElmTests/CqlToElmTests.csproj --framework net8.0
dotnet test Cql/CqlToElmTests/CqlToElmTests.csproj --framework net10.0

# Test IntegrationRunner on .NET 10
dotnet test submodules/Firely.Cql.Sdk.Integration.Runner/IntegrationRunner/IntegrationRunner.csproj --framework net10.0
```

**Test entire solution**:
```bash
# Build entire solution for both frameworks
dotnet build Cql-Sdk.slnf --configuration Release

# Test all projects on .NET 8
dotnet test Cql-Sdk.slnf --configuration Release --framework net8.0 --no-build

# Test all projects on .NET 10
dotnet test Cql-Sdk.slnf --configuration Release --framework net10.0 --no-build
```

### What the Template Does

The `build-test-sign.yml` template creates three parallel jobs that execute simultaneously:

**Job 1: Build, Test and Sign for .NET 8**
- Installs .NET 8 SDK
- Restores NuGet packages
- Builds entire solution targeting both net8.0 and net10.0
- Tests multi-target projects (CoreTests, CqlToElmTests) on .NET 8
- Signs assemblies using Azure Trusted Signing (`dotnet sign` tool)
- Packages NuGet packages with proper version suffix
- Publishes test results as "Tests on .NET 8"
- Publishes NuGet packages artifact

**Job 2: Build, Test and Sign for .NET 10**
- Installs .NET 10 SDK
- Restores NuGet packages
- Builds entire solution targeting both net8.0 and net10.0
- Tests multi-target projects (CoreTests, CqlToElmTests) on .NET 10
- Signs assemblies using Azure Trusted Signing (`dotnet sign` tool)
- Packages NuGet packages with proper version suffix
- Publishes test results as "Tests on .NET 10"
- Publishes NuGet packages artifact (primary artifact for deployment)

**Job 3: Build and IntegrationRunner Test for .NET 10**
- Installs .NET 10 SDK
- Restores NuGet packages
- Builds entire solution targeting both net8.0 and net10.0
- Tests IntegrationRunner on .NET 10
- Publishes test results as "Integration Tests on .NET 10"
- No signing or packaging (integration tests are not deployed)

**Job 4: CompareTestResults**
- Runs after all three jobs complete
- Compares test results across .NET 8 and .NET 10
- Reports framework parity status (identical vs. different behavior)
- Identifies framework-specific test failures if any

### Benefits

- ✅ **Zero Duplicate Builds**: Each job builds once - no separate build/test/sign stages
- ✅ **Maximum Parallelization**: All three jobs execute simultaneously
- ✅ **Framework Parity Verification**: Ensures identical behavior across .NET 8 and .NET 10
- ✅ **Early Detection**: Framework-specific issues caught before deployment
- ✅ **Comprehensive Testing**: Multi-target tests + integration tests
- ✅ **Signed Artifacts**: Assemblies signed using Azure Trusted Signing
- ✅ **Fast Feedback**: Parallel execution minimizes total pipeline time
- ✅ **Deployment Gating**: All tests must pass before packages are deployed

### Test Results

Test results are published with framework-specific titles for easy identification:
- **Tests on .NET 8** - CoreTests and CqlToElmTests on .NET 8
- **Tests on .NET 10** - CoreTests and CqlToElmTests on .NET 10
- **Integration Tests on .NET 10** - IntegrationRunner on .NET 10

The CompareTestResults job reports framework parity status after all tests complete.

### Azure Trusted Signing

The pipeline uses Azure Trusted Signing to sign assemblies, matching the approach in FirelyTeam/azure-pipeline-templates:

**Signing Tool**: `dotnet sign` (version 0.9.1-beta.25379.1)
- Installed as a .NET global tool
- Requires .NET 8 runtime for compatibility
- Authenticates via Azure CLI service connection

**Signed Files**:
- All `Hl7.Cql*.dll` assemblies
- All `Ncqa.Cql*.dll` assemblies
- All `Cql.*.dll` assemblies
- `PackagerCLI.dll`
- Excludes: CodeGeneration assemblies and test assemblies

**Configuration**:
- Service Connection: `AzureTrustedSigningPrincipal`
- Endpoint: `https://weu.codesigning.azure.net/`
- Account: `FirelyCodeSigning`
- Certificate Profile: `FirelyCodeSigning`

### Current Status

**Status**: ✅ **Active** - Fully operational parallel build/test/sign pipeline

The pipeline executes three jobs in parallel:
- ✅ Build, Test and Sign for .NET 8 (multi-target tests + signing + packaging)
- ✅ Build, Test and Sign for .NET 10 (multi-target tests + signing + packaging)
- ✅ Build and IntegrationRunner Test for .NET 10 (integration tests only)

All jobs must succeed before deployment stages run. This ensures:
- Framework parity (identical behavior on .NET 8 and .NET 10)
- Integration test validation
- Signed assemblies ready for distribution

### Troubleshooting

**Issue**: Tests fail on one framework but pass on another
- **Solution**: This indicates a framework-specific issue. Check for:
  - Different API behavior between .NET 8 and .NET 10
  - Framework-specific bugs or breaking changes
  - Dependencies with different versions
  - Conditional compilation directives
  - System.Text.Json serialization differences (common in .NET 10)

**Issue**: "Framework not found" error
- **Solution**: Ensure the required .NET SDK is installed
  - The pipeline template automatically installs both .NET 8 and .NET 10 SDKs
  - Locally: `dotnet --list-sdks` to verify installation
  - Download from: https://dotnet.microsoft.com/download

**Issue**: Test results not showing for a framework
- **Solution**: Check that the project file includes both target frameworks:
  ```xml
  <TargetFrameworks>net8.0;net10.0</TargetFrameworks>
  ```

**Issue**: Signing fails with "dotnet sign: command not found"
- **Solution**: The signing tool requires .NET 8 runtime
  - Pipeline automatically installs: `dotnet --list-runtimes`
  - Verify Azure CLI authentication is configured

**Issue**: NuGet pack fails with "PackageVersion string specified 'build-YYYYMMDD-N' is invalid"
- **Solution**: Use `buildProperties: VersionSuffix=...` instead of `versioningScheme: byEnvVar`
  - Correct format generates: `1.0.0-build-YYYYMMDD-N` (valid SemVer)
  - Incorrect format generates: `build-YYYYMMDD-N` (invalid)

## Microsoft Best Practices

This implementation follows Microsoft's recommendations for multi-targeting and CI/CD:

1. **Multi-Targeting**: Uses `<TargetFrameworks>net8.0;net10.0</TargetFrameworks>` to build for both frameworks
2. **Explicit Framework Testing**: Tests run explicitly against each target framework using `--framework` parameter
3. **Parallel Execution**: Leverages Azure Pipelines jobs to test frameworks simultaneously
4. **Separate Results**: Framework-specific test results aid in debugging framework issues
5. **SDK Management**: Installs all required SDK versions before building/testing
6. **SemVer Compliance**: Uses VersionSuffix for preview builds (e.g., `1.0.0-build-20260118-1`)
7. **Code Signing**: Uses Azure Trusted Signing for secure assembly signing

## Additional Resources

- [Multi-targeting in .NET](https://learn.microsoft.com/en-us/dotnet/standard/frameworks)
- [Azure Pipelines YAML schema](https://learn.microsoft.com/en-us/azure/devops/pipelines/yaml-schema)
- [Azure Trusted Signing](https://learn.microsoft.com/en-us/azure/trusted-signing/)
- [.NET 10 Release Notes](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-10)
- [Testing multi-targeted projects](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices#testing-multi-targeted-projects)
- [NuGet Package Versioning](https://learn.microsoft.com/en-us/nuget/concepts/package-versioning)
