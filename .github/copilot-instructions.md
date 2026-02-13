# Copilot Instructions for Firely CQL SDK

This document contains development guidelines and instructions for maintaining consistency across the Firely CQL SDK repository when using GitHub Copilot or making changes.

## User Workflow Preferences

**IMPORTANT: Discuss Before Implementing**
- When user asks for ideas, suggestions, or "what would be the best way to..." questions, **DISCUSS OPTIONS FIRST**
- Present 2-3 approaches with pros/cons
- Wait for user to choose an approach before implementing
- DO NOT immediately implement solutions when user asks for ideas
- User will explicitly ask to proceed with implementation when ready

**PR Description Requirements**
- When user adds new instructions or requirements, the PR description **MUST include ALL work in the branch**, not just changes scoped to the last instructions
- Provide comprehensive summary of the entire branch's changes
- Include context from initial implementation through all subsequent modifications

## InternalsVisibleTo Configuration

**IMPORTANT**: Always add `InternalsVisibleTo` attributes in `.csproj` files, never in `AssemblyInfo.cs` files.

### Format
Use the following format in csproj files:

```xml
<ItemGroup>
    <InternalsVisibleTo Include="ProjectName" Key="$(LibraryPKHash)" />
</ItemGroup>
```

### Example
```xml
<ItemGroup>
    <InternalsVisibleTo Include="Hl7.Cql.Runtime" Key="$(LibraryPKHash)" />
    <InternalsVisibleTo Include="CoreTests" Key="$(LibraryPKHash)" />
    <InternalsVisibleTo Include="CqlSdkExamplesPreview" Key="$(LibraryPKHash)" />
</ItemGroup>
```

### Key Points
- Always use the `Key="$(LibraryPKHash)"` attribute for signed assemblies
- Add to existing `<ItemGroup>` containing other `InternalsVisibleTo` entries if available
- Create a new `<ItemGroup>` if none exists
- Never modify or create `AssemblyInfo.cs` files for this purpose

## Project Structure

### SDK Projects
Core SDK projects are located in the `Cql/` directory:
- `Cql.Abstractions` - Base abstractions and interfaces
- `Cql.Runtime` - Runtime and execution engine
- `Cql.Invocation` - Core invocation and toolkit functionality
- `CodeGeneration.NET` - Code generation features

### Examples
- `Examples/CqlSdkExamples/` - Public examples using stable APIs
- `Examples/CqlSdkExamplesPreview/` - Preview examples with access to internal/experimental APIs

## Development Guidelines

### File Headers
**IMPORTANT**: Copyright header requirements for C# source files (*.cs, excluding *.g.cs generated files):

#### For NEW Files (files being created)
Use this header format with "Firely, NCQA" and the current year:
```csharp
/*
 * Copyright (c) <CURRENT_YEAR>, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
```

#### For EXISTING Files
- **DO NOT modify existing copyright headers** in files that already have them
- Leave existing headers exactly as they are (e.g., "NCQA and contributors" should remain unchanged)
- **When making changes to a file and Firely is not listed as contributor, add it as "Firely, NCQA and contributors"**

#### Header Guidelines
- Use the current year in the copyright notice for new files only (replace `<CURRENT_YEAR>` with the actual current year, e.g., 2026 for files created in 2026)
- **Never update or modify the copyright year in existing files**
- For new files, include "Firely, NCQA and contributors" in the copyright line
- Place header at the very top of the file, after any `#pragma` directives if present
- Generated files (*.g.cs) do not require headers
- **Never update or modify existing copyright headers in existing files**

### Making Changes
1. Use minimal, surgical changes - modify as few lines as possible
2. Maintain existing code structure and patterns
3. Run builds and tests to validate changes
4. Use existing project conventions and naming patterns
5. **Always ensure blank lines contain no spaces** - blank lines must be completely empty
6. **When adding new utility files or functionality that are only used internally, keep those types as `internal`, not `public`** - Only expose public APIs when they are intended for external consumption
7. **When creating new files or modifying existing ones, always remove unused usings at the top of the file** - Keep using statements clean and only include what is actually used
8. **Do not add duplicate usings in files where the using is already included globally in `GlobalUsings.cs`** - Check GlobalUsings.cs first to avoid redundant using statements
9. **Always use the latest C# language features** when appropriate:
   - Use collection expressions `[]` instead of `new[] { ... }` for arrays and collections
   - Use target-typed `new()` expressions when the type is clear from context
   - Use pattern matching and switch expressions where applicable
   - Use record types for immutable data structures
   - Use nullable reference types and null-conditional operators
   - Use string interpolation instead of `string.Format` or concatenation
10. **Local functions must use camelCase naming** - Local functions (functions defined inside methods) should start with a lowercase letter (e.g., `processItem()`, not `ProcessItem()`)

### Project References
- When adding internal access, ensure the requesting project is appropriate for internal API usage
- Preview/test projects can access internals, production projects should use public APIs
- Always validate that internal access is truly needed

### Documentation
- Update README files when adding new projects or significant features
- **When adding dependencies, also update the README's Dependencies section**
- Document experimental features clearly in preview projects
- Maintain clear separation between stable and experimental examples
- **IMPORTANT: Do not add C# code samples in Usage sections for internal-only projects**
  - If a project is primarily used internally or through higher-level APIs, avoid providing code examples
  - Only include code samples for packages that have clear public usage patterns designed for direct consumer use
  - Remove any placeholder or comment-only code blocks from documentation
  - Internal packages should describe what they do but not show how to use them directly

## Build and Test
- **Always use `Cql-Sdk.slnf` to build the solution** - This is because `Cql-Sdk-All.sln` contains submodules to which you do not have access to
- Always run `dotnet build` to validate changes
- Run relevant tests after modifications
- Check that new projects are included in solution files (`*.sln`)

### Cross-Platform Compatibility
**CRITICAL**: Any changes to build scripts or project files MUST work on both Windows and non-Windows operating systems (Linux, macOS, WSL).

#### Requirements for Script Changes
- **Always maintain both PowerShell (.ps1) and Bash (.sh) script variants** with equivalent functionality
- Use OS-conditional logic in MSBuild targets: `Condition="'$(OS)' == 'Windows_NT'"` for Windows, `Condition="'$(OS)' != 'Windows_NT'"` for Unix
- Ensure Bash scripts are executable: `chmod +x script.sh`
- Test changes on both platforms when possible, or verify OS-conditional logic is correct

#### Requirements for Path Changes
- **Use correct case for all directory paths** - Unix filesystems are case-sensitive
- Verify paths match actual directory names exactly (e.g., `Input/ELM/HL7` not `input/elm/hl7`)
- Avoid hardcoded path separators - use MSBuild properties like `$(MSBuildThisFileDirectory)`
- Test that paths work on case-insensitive (Windows) and case-sensitive (Unix) filesystems

#### Platform-Specific Considerations
- **Executable extensions**: Windows uses `.exe`, Unix does not - handle conditionally
- **Line endings**: Git should handle automatically, but be aware of CRLF (Windows) vs LF (Unix)
- **Shell availability**: Use `pwsh` for PowerShell, `bash` for Bash - don't assume shell locations
- **File locking**: Use portable mechanisms (e.g., directory-based locking with `mkdir`) instead of platform-specific tools like `flock` (not available on macOS by default)
- **PowerShell non-interactive mode**: When running PowerShell commands via `run_command_in_terminal`, always use non-interactive mode by adding the `-NonInteractive` flag (e.g., `pwsh -NonInteractive -Command "..."`) to prevent commands from hanging waiting for user input

### Code Generation Version Management
**When modifying C# code generation logic, always update the `LibrarySetCSharpCodeGenerator.GeneratorToolVersion`**:

1. **Locate the version**: The version is hardcoded in `CodeGeneration.NET/_CODE GENERATOR VERSION_.cs` as `GeneratorToolVersion`
2. **Apply semantic versioning**: 
   - **Major version** (x.0.0.0): Breaking changes to generated code that require new `LibraryInstanceInvoker` support
   - **Minor version** (x.y.0.0): Non-breaking additions like new attributes or functionality
   - **Patch version** (x.y.z.0): Bug fixes that don't change the generated API
3. **Check compatibility**: Ensure `LibraryInstanceInvoker_3_0.SupportsVersion` covers the new version range
4. **Create new invoker if needed**: For major version changes, a new `LibraryInstanceInvoker_X_Y` may be required
5. **Examples**:
   - Adding `CqlFunctionParameterAttribute` → Minor version increment (3.0.0.0 → 3.1.0.0)
   - Changing method signatures → Major version increment (3.0.0.0 → 4.0.0.0)
   - Fixing identifier normalization → Patch version increment (3.0.0.0 → 3.0.1.0)

### Generating ELM Files from CQL
When adding CQL files (e.g., to `CoreTests\Input\ELM\HL7`), follow these steps to generate the ELM JSON files:

1. **Enable CQL to ELM conversion**: Find the commented out property `CqlToElmEnabled` in the csproj (e.g., `<!-- <CqlToElmEnabled>true</CqlToElmEnabled> -->`) and uncomment it to set `CqlToElmEnabled` to `true`
2. **Build the project**: Build that particular csproj, which will generate the ELM files
3. **Verify generation**: Confirm that all ELM files are generated for each CQL file. The directory for the ELM files can be discovered in the `ElmDirectory` property in the csproj file
4. **Restore setting**: Roll back step 1 by commenting out `CqlToElmEnabled=true`

## Naming Conventions
- Use `CqlSdk` prefix for SDK-related example projects
- Use `Hl7.Cql` namespace prefix for core SDK assemblies
- Follow existing patterns in the codebase for consistency

## FHIR Library Resource Handling

### Library.Name vs Library.Id
**CRITICAL**: `library.Name` and `library.Id` are NOT interchangeable and serve different purposes:

- **`library.Name`**: The canonical identifier/name used for library identification and versioning (e.g., "MyLibrary")
  - Use this when constructing `CqlVersionedLibraryIdentifier` or building canonical URLs
  - This is the name that appears in CQL `library` declarations
  - Required for library packaging and identification workflows

- **`library.Id`**: The FHIR resource identifier, typically a generated or assigned ID (e.g., "Library/abc123")
  - Use this for resource identification within a FHIR server
  - NOT suitable for library name/version identification

**DO NOT** use code like: `var name = library.Name ?? library.Id;`

**DO** validate that `library.Name` exists when it's required:
```csharp
if (string.IsNullOrWhiteSpace(library.Name))
{
    logger.LogError("FHIR Library must have a Name property.");
    return ExitCode.InvalidLibraryJson;
}
```

### Library Identifier Construction
Always use `CqlVersionedLibraryIdentifier` for parsing and formatting library names and versions:

```csharp
// Creating from separate name and version
var identifier = CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion(library.Name, library.Version);

// Using the identifier (automatically formats as "name-version")
string formatted = identifier.ToString();
```

### PowerShell Command Execution
When generating PowerShell commands in the future, ensure they are 100% non-interactive by using `pwsh -NonInteractive -Command "<your actual command>"` to prevent hanging the terminal. Avoid creating interactive shells like `pwsh` or `dotnet repl`.
