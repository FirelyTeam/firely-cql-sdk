# Copilot Instructions for Firely CQL SDK

This document contains development guidelines and instructions for maintaining consistency across the Firely CQL SDK repository when using GitHub Copilot or making changes.

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
9. **System.* namespaces must be added to `GlobalUsings.cs`, not directly in C# files** - All `System.*` using statements (e.g., `System.Linq`, `System.Collections.Generic`, `System.ComponentModel`) should be centralized in the project's `GlobalUsings.cs` file. Never add them directly to individual `.cs` files. Check `GlobalUsings.cs` first before adding any using statement.
10. **Always use the latest C# language features** when appropriate:
   - Use collection expressions `[]` instead of `new[] { ... }` for arrays and collections
   - Use target-typed `new()` expressions when the type is clear from context
   - Use pattern matching and switch expressions where applicable
   - Use record types for immutable data structures
   - Use nullable reference types and null-conditional operators
   - Use string interpolation instead of `string.Format` or concatenation
   - **DO NOT use extension type syntax (`extension<T>(T self)`)** for projects that target .NET 8 - extension types are a C# 14 / .NET 10+ feature and will cause compilation errors in multi-targeted projects
11. **Local functions must use camelCase naming** - Local functions (functions defined inside methods) should start with a lowercase letter (e.g., `processItem()`, not `ProcessItem()`)

### Code Generation
- **When modifying code generation logic in `CodeGeneration.NET`**: The generated C# code does not have `#nullable enable` directives, so:
  - Do not use nullable reference type operators (`?`, `!`) in generated code
  - Avoid null-conditional operators (`?.`, `??`) that assume nullable reference type context
  - Use traditional null checks instead of nullable reference type annotations
  - This applies only to the *generated* code output, not to the code generator implementation itself

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
- **ASCII art diagrams in markdown**: When creating diagrams using line and box drawing characters (e.g., `│`, `┌`, `─`), wrap them in `<pre style="line-height:1; font-family:Consolas, monospace;">` ... `</pre>` tags instead of code fences (` ``` `). This prevents unwanted line spacing that breaks the visual appearance of ASCII art
  - **Important**: Content between `<pre>` tags is treated as HTML/XML, so proper escaping is required:
    - Use `&lt;` for `<` (e.g., `MyClass&lt;T&gt;` instead of `MyClass<T>`)
    - Use `&gt;` for `>` when it could be interpreted as an XML tag
    - Use `&amp;` for `&`
    - Example: `PolymorphicObjectJsonConverter&lt;T&gt;` not `PolymorphicObjectJsonConverter<T>`

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
3. **LibraryInvoker version policy**: 
   - **Only support the current version**: The SDK only supports libraries generated with the current `GeneratorToolVersion`
   - **Remove old invokers**: When creating a new `LibraryInstanceInvoker_X_Y`, remove all previous version invokers (e.g., remove `LibraryInstanceInvoker_5_0.cs` when creating `LibraryInstanceInvoker_6_0.cs`)
   - **Update LibraryInvoker.cs**: Remove version checks for old invokers from the `TryCreate` method
   - **No backward compatibility**: Libraries generated with older versions must be regenerated with the current version to be used
4. **Create new invoker if needed**: For major version changes, a new `LibraryInstanceInvoker_X_Y` is required
5. **Examples**:
   - Adding `CqlFunctionParameterAttribute` → Minor version increment (3.0.0.0 → 3.1.0.0)
   - Changing method signatures → Major version increment (3.0.0.0 → 4.0.0.0) + create new invoker
   - Fixing identifier normalization → Patch version increment (3.0.0.0 → 3.0.1.0)

### Generating ELM Files from CQL
When adding CQL files (e.g., to `CoreTests\Input\ELM\HL7`), follow these steps to generate the ELM JSON files:

1. **Enable CQL to ELM conversion**: Find the commented out property `CqlToElmEnabled` in the csproj (e.g., `<!-- <CqlToElmEnabled>true</CqlToElmEnabled> -->`) and uncomment it to set `CqlToElmEnabled` to `true`
2. **Build the project**: Build that particular csproj, which will generate the ELM files
3. **Verify generation**: Confirm that all ELM files are generated for each CQL file. The directory for the ELM files can be discovered in the `ElmDirectory` property in the csproj file
4. **Restore setting**: Roll back step 1 by commenting out `CqlToElmEnabled=true`

### Regenerating C# Files from ELM
When making changes to the code generator (`CodeGeneration.NET` project) or when ELM files are updated, you need to regenerate the C# library files:

#### For CoreTests Project
The CoreTests project has generated C# files in `Cql/CoreTests/CSharp/*.g.cs`. To regenerate them:

1. **Enable C# generation**: The `ElmToCSharpEnabled` property can be set in two places:
   - **For single project**: Add `<ElmToCSharpEnabled>true</ElmToCSharpEnabled>` in the csproj file between the imports of `packaging-tooling.props` and `packaging-tooling.Targets.xml`
   - **For all projects globally**: Set `<ElmToCSharpEnabled>true</ElmToCSharpEnabled>` in `packaging-tooling.props` (uncomment existing line or add)
   - Prefer project-level setting when focusing on one project
2. **Clean existing generated files**: Remove old generated files to force regeneration:
   ```bash
   rm -rf Cql/CoreTests/CSharp/*.g.cs
   ```
3. **Build the project**: Build CoreTests which will trigger code generation:
   ```bash
   dotnet build Cql/CoreTests/CoreTests.csproj -c Release
   ```
4. **Verify generation**: Check that all `*.g.cs` files are created in `Cql/CoreTests/CSharp/` directory
5. **Restore setting**: Remove or comment out the `ElmToCSharpEnabled=true` setting added in step 1
6. **Restore from git if needed**: If generation fails, restore the files from git:
   ```bash
   git checkout HEAD -- Cql/CoreTests/CSharp/*.g.cs
   ```

#### Code Generation Process
The build process uses MSBuild targets defined in `packaging-tooling.Targets.xml`:
- **ElmToCSharp.Targets.xml**: Defines the `GenerateCSharp` target that runs `PackagerCLI` to generate C# from ELM
- **Conditional execution**: Generation only runs when `ElmToCSharpEnabled='true'` and `PackagerCLI` executable exists
- **Properties needed**:
  - `ElmDirectory`: Path to ELM JSON files (e.g., `$(MSBuildProjectDirectory)/Input/ELM/HL7`)
  - `CSharpDirectory`: Output path for generated C# files (e.g., `$(MSBuildProjectDirectory)/CSharp`)
  - `LibrarySet`: Name of the library set being generated

#### When to Regenerate
Always regenerate C# files after:
- Modifying code generator logic in `CodeGeneration.NET`
- Updating `GeneratorToolVersion` 
- Changing code generation templates or patterns
- Updating ELM files
- Adding new libraries to test projects

#### Troubleshooting
- **Files not generated**: Check that `PackagerCLI` is built first: `dotnet build Cql/PackagerCLI/PackagerCLI.csproj`
- **Wrong generated code**: Ensure you're using the correct `ToolTargetFramework` (typically `net10.0`)
- **Missing dependencies**: Build the entire solution first: `dotnet build Cql-Sdk.slnf -c Release`

## Naming Conventions
- Use `CqlSdk` prefix for SDK-related example projects
- Use `Hl7.Cql` namespace prefix for core SDK assemblies
- Follow existing patterns in the codebase for consistency