# Build and CI/CD Pipeline Documentation

This directory contains Azure Pipelines configuration for building, testing, and deploying the Firely CQL SDK.

## Files

### `azure-pipelines.yml`
Main pipeline configuration that orchestrates the complete CI/CD process:
- Checks for documentation-only changes
- Builds the solution
- Runs tests
- Deploys packages to GitHub and NuGet

### `variables.yml`
Centralized variables used across pipeline configurations:
- `buildConfiguration`: Build configuration (Release)
- `vmImage`: VM image for build agents
- `DOTNET_CORE_SDK`: .NET SDK version to use
- API keys for package deployment

### `test-multitarget.yml`
Multi-framework testing template for verifying identical behavior across .NET 8 and .NET 10.

## Multi-Framework Testing

### Overview
The SDK targets both .NET 8 (LTS) and .NET 10 (LTS) to provide performance benefits while maintaining compatibility. The `test-multitarget.yml` template enables explicit testing against both frameworks in parallel to verify identical behavior.

### Usage

#### Option 1: Add as a separate stage (Recommended)
Add a dedicated testing stage to `azure-pipelines.yml` after the build stage:

```yaml
- stage: multiFrameworkTests
  displayName: 'Multi-Framework Testing'
  dependsOn: build
  condition: and(succeeded(), ne(variables['Build.Reason'], 'PullRequest'))
  jobs:
  - template: test-multitarget.yml
    parameters:
      dotNetCoreVersion: $(DOTNET_CORE_SDK)
      testProjects: |
        **/*Tests/*Tests.csproj
        !**/Ncqa.HT.DeckTests.csproj
        !**/Ncqa.HT.MeasuresTests.csproj 
        !**/XsdToCSharpConverterTests.csproj
      buildConfiguration: $(buildConfiguration)
```

#### Option 2: Run locally for validation
Test both frameworks locally before pushing:

```bash
# Test on .NET 8
dotnet test --framework net8.0

# Test on .NET 10
dotnet test --framework net10.0

# Test both frameworks
dotnet test
```

### What It Does

The multi-framework test template:

1. **Parallel Execution**: Runs tests against .NET 8 and .NET 10 simultaneously in separate jobs
2. **Framework-Specific Results**: Publishes separate test results for each framework
3. **Code Coverage**: Collects code coverage for both frameworks
4. **Comparison Report**: Generates a summary comparing test results across frameworks
5. **Failure Detection**: Identifies framework-specific failures

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

**Note**: The `cql-base.props` file currently targets only `net10.0` temporarily. When multi-targeting is re-enabled (setting `<TargetFrameworks>net8.0;net10.0</TargetFrameworks>`), this template will automatically test both frameworks in the CI/CD pipeline.

To enable multi-framework testing in CI/CD:
1. Update `cql-base.props`: Set `<TargetFrameworks>net8.0;net10.0</TargetFrameworks>`
2. Update `azure-pipelines.yml`: Add the `multiFrameworkTests` stage as shown above
3. Commit and push - the pipeline will now test both frameworks

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
