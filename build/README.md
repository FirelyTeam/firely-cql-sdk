# Build and CI/CD Pipeline Documentation

This directory contains Azure Pipelines configuration for building, testing, and deploying the Firely CQL SDK with multi-targeting support for .NET 8 (LTS) and .NET 10 (LTS).

## Files

### `azure-pipelines.yml`
Main pipeline configuration that orchestrates the complete CI/CD process with the following stages:

1. **checkForDocChangesStage**: Checks if only documentation changed (skips build if so)
2. **Build**: Builds the solution once, signs assemblies (conditionally), and packages NuGet packages
3. **Test**: Three parallel test jobs that download build artifacts and run tests
4. **deployToGitHub**: Deploys to GitHub Packages (non-PR builds only)
5. **deployToNuget**: Deploys to NuGet.org (release tags only)

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
Reusable Azure Pipelines template that implements an optimized build-once, test-parallel workflow:

**Build Stage** (single job):
- Installs .NET 8 and .NET 10 SDKs
- Caches Java dependencies (Maven) to avoid redundant downloads
- Restores NuGet packages and builds the entire solution once
- Signs assemblies using Azure Trusted Signing (conditionally - only on release tags or develop branch)
- Packages NuGet packages
- Publishes build artifacts for test jobs

**Test Stage** (three parallel jobs):
- **TestNet8**: Downloads artifacts, tests CoreTests/CqlToElmTests on .NET 8
- **TestNet10**: Downloads artifacts, tests CoreTests/CqlToElmTests on .NET 10
- **IntegrationTests**: Downloads artifacts, tests IntegrationRunner on .NET 10

Each test job only installs the .NET SDK version it needs, maximizing efficiency.

## Pipeline Architecture

### Stage Dependencies

```
┌─────────────────────────────────────────────────────────────────┐
│              checkForDocChangesStage                            │
└─────────────────────────────────────────────────────────────────┘
                              │
                              ▼
┌─────────────────────────────────────────────────────────────────┐
│               Build, Sign & Package Stage                       │
│  • Restore NuGet packages                                       │
│  • Build solution                                               │
│  • Sign assemblies (if release/develop)                         │
│  • Pack NuGet packages (on same agent - no restore needed!)     │
│  • Publish artifacts                                            │
└─────────────────────────────────────────────────────────────────┘
                              │
                              ▼
┌─────────────────────────────────────────────────────────────────┐
│                    Test Stage                                   │
│  ┌─────────────┐  ┌─────────────┐  ┌──────────────────┐        │
│  │ TestNet8    │  │ TestNet10   │  │ TestIntegration  │        │
│  └─────────────┘  └─────────────┘  └──────────────────┘        │
│                   (run in parallel)                             │
└─────────────────────────────────────────────────────────────────┘
                              │
                              ▼
┌─────────────────────────────────────────────────────────────────┐
│                 Deploy to GitHub / NuGet                        │
└─────────────────────────────────────────────────────────────────┘
```

**Key Benefits of This Architecture**:
- **Single build** - Solution is built exactly once, not duplicated across jobs
- **Java dependency caching** - Maven dependencies cached to avoid redundant downloads
- **Conditional signing** - Assemblies signed only on release tags or develop branch (not PRs), saving ~12 minutes on PR builds
- **Optimized SDK installation** - Each test job only installs the .NET version it needs
- **Maximum test parallelization** - All three test jobs start simultaneously after build completes
- **Build artifacts shared** - Test jobs download pre-built artifacts instead of rebuilding
- **All tests gate deployment** - Cannot deploy unless all test jobs succeed

## Multi-Framework Testing

### Overview
The SDK targets both .NET 8 (LTS) and .NET 10 (LTS) to leverage .NET 10 performance improvements while maintaining broad compatibility. The `build-test-sign.yml` template implements a build-once, test-parallel workflow: a single Build stage compiles the solution once, then three parallel Test jobs verify behavior across both frameworks.

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

The `Build` and `Test` stages in `azure-pipelines.yml` use the template with parameters from `variables.yml`:

```yaml
- template: build-test-sign.yml
  parameters:
    dotNetCoreVersion: $(DOTNET_CORE_SDK)
    multiTargetTestProjects: $(multiTargetTestProjects)
    net10IntegrationTestProjects: $(net10IntegrationTestProjects)
    buildConfiguration: $(buildConfiguration)
    checkoutSubmodules: 'true'
    shouldSign: ${{ ... }}  # true only for release tags or develop branch
    buildStageDependsOn: checkForDocChangesStage
    buildStageCondition: ...
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

Multi-framework testing is fully integrated into `azure-pipelines.yml` and runs automatically on every build (unless only documentation changed). The Build stage completes first, then three parallel Test jobs execute simultaneously, providing fast feedback while ensuring framework parity.

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

The `build-test-sign.yml` template creates a two-stage pipeline optimized for efficiency:

**Build Stage** (single job):
- Installs .NET 8 and .NET 10 SDKs
- Caches Java dependencies using `Cache@2` task with `Demo/Cql/Build/pom.xml` as cache key
- Restores NuGet packages
- Builds entire solution targeting both net8.0 and net10.0 (single build)
- Conditionally signs assemblies using Azure Trusted Signing (`shouldSign` parameter)
- Packages NuGet packages with proper version suffix
- Publishes build artifacts (BuildOutput) for test jobs

**Test Stage** (three parallel jobs):

**Job 1: TestNet8**
- Installs only .NET 8 SDK
- Downloads BuildOutput artifact
- Tests multi-target projects (CoreTests, CqlToElmTests) on .NET 8
- Publishes test results as "Tests on .NET 8"

**Job 2: TestNet10**
- Installs only .NET 10 SDK
- Downloads BuildOutput artifact
- Tests multi-target projects (CoreTests, CqlToElmTests) on .NET 10
- Publishes test results as "Tests on .NET 10"

**Job 3: IntegrationTests**
- Installs only .NET 10 SDK
- Downloads BuildOutput artifact
- Tests IntegrationRunner on .NET 10
- Publishes test results as "Integration Tests on .NET 10"

**Job 4: CompareTestResults**
- Runs after all three test jobs complete
- Compares test results across .NET 8 and .NET 10
- Reports framework parity status (identical vs. different behavior)
- Identifies framework-specific test failures if any

### Benefits

- ✅ **Single Build**: Solution built once, artifacts shared with test jobs
- ✅ **Java Dependency Caching**: Maven dependencies cached to avoid redundant downloads across builds
- ✅ **Conditional Signing**: Assemblies signed only on release tags or develop branch (~12 min saved on PRs)
- ✅ **Optimized SDK Installation**: Each test job installs only the .NET version it needs
- ✅ **Maximum Test Parallelization**: Three test jobs execute simultaneously after build
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

**Conditional Signing**: Signing is only performed when the `shouldSign` parameter is `true`:
- ✅ Release tags (e.g., `v1.0.0`, `refs/tags/v*`)
- ✅ Builds merged to `develop` branch
- ❌ Pull request builds (signing skipped to save ~12 minutes)

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

**Status**: ✅ **Active** - Optimized build-once, test-parallel pipeline

The pipeline executes in two stages:

**Build Stage** (single job):
- ✅ Builds solution once for both .NET 8 and .NET 10
- ✅ Caches Java dependencies (Maven)
- ✅ Signs assemblies conditionally (release tags/develop branch only)
- ✅ Packages NuGet packages
- ✅ Publishes build artifacts

**Test Stage** (three parallel jobs):
- ✅ TestNet8 - CoreTests/CqlToElmTests on .NET 8
- ✅ TestNet10 - CoreTests/CqlToElmTests on .NET 10
- ✅ IntegrationTests - IntegrationRunner on .NET 10

All test jobs must succeed before deployment stages run. This ensures:
- Framework parity (identical behavior on .NET 8 and .NET 10)
- Integration test validation
- Signed assemblies ready for distribution (when signing is enabled)

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

**Issue**: Signing is skipped unexpectedly
- **Solution**: Signing only runs on release tags or develop branch
  - Check the `shouldSign` parameter in azure-pipelines.yml
  - PR builds intentionally skip signing to save time

**Issue**: Java dependencies downloading on every build
- **Solution**: The pipeline uses `Cache@2` task to cache Maven dependencies
  - Cache key is based on `Demo/Cql/Build/pom.xml`
  - If pom.xml changes, cache is invalidated and dependencies are re-downloaded
  - Check cache hit/miss in the "Cache Java dependencies" step output

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
