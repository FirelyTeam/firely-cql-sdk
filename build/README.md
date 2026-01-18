# Build and CI/CD Pipeline Documentation

This directory contains Azure Pipelines configuration for building, testing, and deploying the Firely CQL SDK.

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
- `vmImage`: VM image for build agents
- `DOTNET_CORE_SDK`: .NET SDK version to use
- API keys for package deployment
- **Test project configuration** (new):
  - `multiTargetTestProjects`: Projects tested on both .NET 8 and .NET 10
  - `net10OnlyTestProjects`: Projects tested only on .NET 10
  - `excludedTestProjects`: Projects excluded from all test runs

### `build-test-sign.yml`
Azure Pipelines template for building, testing (multi-framework), and signing assemblies. This template implements three parallel jobs:
- **Build, Test and Sign for .NET 8**: Builds, tests, signs, and packages for .NET 8
- **Build, Test and Sign for .NET 10**: Builds, tests, signs, and packages for .NET 10  
- **Build and IntegrationRunner Test for .NET 10**: Builds and tests integration tests (no signing/packaging)

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
The SDK targets both .NET 8 (LTS) and .NET 10 (LTS) to provide performance benefits while maintaining compatibility. The `build-test-sign.yml` template implements three parallel jobs that build, test, and sign for both frameworks to verify identical behavior.

### Test Project Configuration

All test project specifications are now centralized in `variables.yml`:

**Multi-Target Tests** (tested on both .NET 8 and .NET 10):
- `Cql/CoreTests/CoreTests.csproj`
- `Cql/CqlToElmTests/CqlToElmTests.csproj`

**.NET 10 Only Tests**:
- `submodules/Firely.Cql.Sdk.Integration.Runner/IntegrationRunner/IntegrationRunner.csproj`
- `Demo/Test.Measures.Demo/Test.Measures.Demo.csproj`

**Excluded Tests**:
- `tools/XsdToCSharpConverterTests/XsdToCSharpConverterTests.csproj` - Internal tool tests
- `submodules/Ncqa.DQIC/Ncqa.HT.DeckTests/Ncqa.HT.DeckTests.csproj`
- `submodules/Ncqa.DQIC/Ncqa.HT.MeasuresTests/Ncqa.HT.MeasuresTests.csproj`

### Architecture

The multi-framework testing stage reads configuration from `variables.yml`:

```yaml
- stage: multiFrameworkTests
  displayName: 'Multi-Framework Testing'
  dependsOn: buildAndTest
  condition: succeeded()
  jobs:
  - template: build-test-sign.yml
    parameters:
      dotNetCoreVersion: $(DOTNET_CORE_SDK)
      multiTargetTestProjects: $(multiTargetTestProjects)
      net10OnlyTestProjects: $(net10OnlyTestProjects)
      buildConfiguration: $(buildConfiguration)
      checkoutSubmodules: 'true'
```

### Modifying Test Configuration

To add, remove, or change test projects, edit `variables.yml`:

```yaml
variables:
  multiTargetTestProjects: |
    Cql/CoreTests/CoreTests.csproj
    Cql/CqlToElmTests/CqlToElmTests.csproj
    # Add new multi-target test here
  
  net10OnlyTestProjects: |
    submodules/Firely.Cql.Sdk.Integration.Runner/IntegrationRunner/IntegrationRunner.csproj
    Demo/Test.Measures.Demo/Test.Measures.Demo.csproj
    # Add new .NET 10-only test here
```

### Usage

The multi-framework testing stage is already integrated into `azure-pipelines.yml` and will run automatically on every build after the main build stage succeeds.

#### Running Tests Locally

Test both frameworks locally before pushing:

**Windows (PowerShell)**:
```powershell
# Test all projects against both frameworks
.\test-multiframework.ps1

# Test specific project against both frameworks
.\test-multiframework.ps1 -TestProject CoreTests
```

**Linux/macOS (Bash)**:
```bash
# Test all projects against both frameworks
./test-multiframework.sh

# Test specific project against both frameworks
./test-multiframework.sh CoreTests
```

**Manual Testing**:
```bash
# Test CoreTests on .NET 8
dotnet test Cql/CoreTests/CoreTests.csproj --framework net8.0

# Test CoreTests on .NET 10
dotnet test Cql/CoreTests/CoreTests.csproj --framework net10.0

# Test all multi-target projects on both frameworks
dotnet test --framework net8.0
dotnet test --framework net10.0
```

### What It Does

The multi-framework test template creates two parallel jobs:

**Job 1: TestNet8**
- Tests multi-target projects on .NET 8
- Publishes test results as "Tests on .NET 8"
- Collects code coverage for .NET 8

**Job 2: TestNet10**
- Tests multi-target projects on .NET 10
- Tests .NET 10-only projects on .NET 10
- Publishes test results as "Tests on .NET 10"
- Collects code coverage for .NET 10

**Job 3: CompareTestResults**
- Runs after both TestNet8 and TestNet10 complete
- Compares test results to identify framework-specific issues
- Reports whether tests pass on both frameworks or if there are differences

### Benefits

- ✅ **Early Detection**: Catches framework-specific issues before merging
- ✅ **Confidence**: Verifies identical behavior across both LTS frameworks
- ✅ **Visibility**: Separate test results make it easy to identify framework-specific failures
- ✅ **Coverage**: Code coverage collected for both frameworks
- ✅ **Efficiency**: Parallel execution doesn't significantly increase build time

### Test Results

Test results are published with framework-specific titles:
- "Tests on .NET 8" - Shows .NET 8 test results
- "Tests on .NET 10" - Shows .NET 10 test results

Code coverage is published separately for each framework, allowing comparison of coverage metrics.

### Current Status

**Status**: ✅ **Active** - Multi-framework testing is fully integrated and runs on every build.

The pipeline configuration:
- Multi-target tests (CoreTests, CqlToElmTests) run on both .NET 8 and .NET 10
- .NET 10-only tests (IntegrationRunner, Test.Measures.Demo) run only on .NET 10
- Excluded tests are commented out in the main build stage and not included in multi-framework testing

### Modifying Test Configuration

To add or remove tests from multi-framework testing:

1. **Edit `azure-pipelines.yml`**: Update the `multiFrameworkTests` stage parameters
   ```yaml
   multiTargetTestProjects: |
     Cql/CoreTests/CoreTests.csproj
     Cql/CqlToElmTests/CqlToElmTests.csproj
     # Add new multi-target tests here
   
   net10OnlyTestProjects: |
     submodules/Firely.Cql.Sdk.Integration.Runner/IntegrationRunner/IntegrationRunner.csproj
     Demo/Test.Measures.Demo/Test.Measures.Demo.csproj
     # Add new .NET 10-only tests here
   ```

2. **Update main build stage**: Comment out tests in the `testProjects` parameter that are now in multi-framework testing

3. **Commit and push**: The pipeline will automatically use the new configuration

### Troubleshooting

**Issue**: Tests fail on one framework but pass on another
- **Solution**: This indicates a framework-specific issue. Check for:
  - Different API behavior between frameworks
  - Framework-specific bugs
  - Dependencies with different versions
  - Conditional compilation issues

**Issue**: "Framework not found" error
- **Solution**: Ensure both .NET 8 and .NET 10 SDKs are installed
  - The pipeline template automatically installs both SDKs
  - Locally: `dotnet --list-sdks` to verify installation

**Issue**: Test results not showing for a framework
- **Solution**: Check that the project file includes both target frameworks:
  ```xml
  <TargetFrameworks>net8.0;net10.0</TargetFrameworks>
  ```

## Microsoft Best Practices

This implementation follows Microsoft's recommendations for multi-targeting:

1. **Explicit Framework Testing**: Tests run explicitly against each target framework using `--framework` parameter
2. **Parallel Execution**: Leverages Azure Pipelines jobs to test frameworks in parallel
3. **Separate Results**: Framework-specific test results aid debugging
4. **SDK Installation**: Installs all required SDK versions before testing
5. **Code Coverage**: Collects coverage for each framework independently

Reference: [Multi-targeting in .NET](https://learn.microsoft.com/en-us/dotnet/standard/frameworks)

## Additional Resources

- [Azure Pipelines .NET Core task](https://learn.microsoft.com/en-us/azure/devops/pipelines/tasks/reference/dotnet-core-cli-v2)
- [Testing multi-targeted projects](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices#testing-multi-targeted-projects)
- [.NET 10 Release Notes](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-10)
