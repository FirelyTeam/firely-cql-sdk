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
Use this header format with "Firely" only:
```csharp
/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
```

#### For EXISTING Files
- **DO NOT modify existing copyright headers** in files that already have them
- Leave existing headers exactly as they are (e.g., "NCQA and contributors" should remain unchanged)

#### Header Guidelines
- Use the current year (2025) in the copyright notice for new files only
- For new files, include "Firely and contributors" in the copyright line
- Place header at the very top of the file, after any `#pragma` directives if present
- Generated files (*.g.cs) do not require headers
- **Never update or modify existing copyright headers in existing files**

### Making Changes
1. Use minimal, surgical changes - modify as few lines as possible
2. Maintain existing code structure and patterns
3. Run builds and tests to validate changes
4. Use existing project conventions and naming patterns

### Project References
- When adding internal access, ensure the requesting project is appropriate for internal API usage
- Preview/test projects can access internals, production projects should use public APIs
- Always validate that internal access is truly needed

### Documentation
- Update README files when adding new projects or significant features
- Document experimental features clearly in preview projects
- Maintain clear separation between stable and experimental examples

## Build and Test
- Always run `dotnet build` to validate changes
- Run relevant tests after modifications
- Check that new projects are included in solution files (`*.sln`)

## Naming Conventions
- Use `CqlSdk` prefix for SDK-related example projects
- Use `Hl7.Cql` namespace prefix for core SDK assemblies
- Follow existing patterns in the codebase for consistency