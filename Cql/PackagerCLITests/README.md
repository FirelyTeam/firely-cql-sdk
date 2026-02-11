# PackagerCLI Tests

This project contains unit tests for the PackagerCLI tool.

## Test Coverage

### ProgramTests.cs
Tests for the main Program entry point and command-line argument parsing:
- Help commands for all subcommands (--help, cql, elm, library-extract-attachments)
- Version command
- Invalid command handling
- Missing required arguments validation
- Command-specific argument requirements

### ExitCodeTests.cs
Tests for exit code behavior in various scenarios:
- Success scenarios return exit code 0
- Missing required arguments return non-zero exit codes
- Non-existent directories return error codes
- Missing output directories return error codes

## Running Tests

From the repository root:
```bash
dotnet test Cql/PackagerCLITests/PackagerCLITests.csproj
```

From the solution:
```bash
dotnet test Cql-Sdk.slnf --filter "FullyQualifiedName~PackagerCLITests"
```

## Adding New Tests

When adding new tests:
1. Follow the Arrange-Act-Assert pattern
2. Use FluentAssertions for assertions (e.g., `.Should().Be()`)
3. Provide descriptive test names that explain the scenario
4. Add clear assertion messages explaining the expected behavior

## Test Framework

- **Testing Framework**: MSTest
- **Assertion Library**: FluentAssertions
- **Target Framework**: net10.0
