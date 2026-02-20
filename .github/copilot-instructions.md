# Copilot Instructions for Firely CQL SDK

**Version:** 2.5.0

This document contains development guidelines and instructions for maintaining consistency across the Firely CQL SDK repository when using GitHub Copilot or making changes.

## Table of Contents

- [1. User Workflow Preferences](#1-user-workflow-preferences)
  - [1.1 Discuss Before Implementing](#11-discuss-before-implementing)
  - [1.2 Instruction for PR AI](#12-instruction-for-pr-ai)
  - [1.3 Managing Copilot Instructions](#13-managing-copilot-instructions)
  - [1.4 Terminal and Command Execution](#14-terminal-and-command-execution)
- [2. InternalsVisibleTo Configuration](#2-internalsvisibleto-configuration)
  - [2.1 Overview](#21-overview)
  - [2.2 Format](#22-format)
  - [2.3 Example](#23-example)
  - [2.4 Key Points](#24-key-points)
- [3. Project Structure](#3-project-structure)
  - [3.1 SDK Projects](#31-sdk-projects)
  - [3.2 Examples](#32-examples)
- [4. Development Guidelines](#4-development-guidelines)
  - [4.1 File Headers](#41-file-headers)
  - [4.2 Making Changes](#42-making-changes)
  - [4.3 Project References](#43-project-references)
  - [4.4 Documentation](#44-documentation)
- [5. Build and Test](#5-build-and-test)
  - [5.1 General Build Requirements](#51-general-build-requirements)
  - [5.2 Cross-Platform Compatibility](#52-cross-platform-compatibility)
  - [5.3 Code Generation Version Management](#53-code-generation-version-management)
  - [5.4 Generating ELM Files from CQL](#54-generating-elm-files-from-cql)
- [6. Naming Conventions](#6-naming-conventions)
- [7. FHIR Library Resource Handling](#7-fhir-library-resource-handling)
  - [7.1 Library.Name vs Library.Id](#71-libraryname-vs-libraryid)
  - [7.2 Library Identifier Construction](#72-library-identifier-construction)
- [8. CQL Specification Conformance](#8-cql-specification-conformance)
  - [8.1 Authoritative Specification Source](#81-authoritative-specification-source)
  - [8.2 When to Check Specification](#82-when-to-check-specification)
  - [8.3 Specification Location](#83-specification-location)
- [9. CQL Evaluation Exceptions](#9-cql-evaluation-exceptions)
  - [9.1 Exception Hierarchy](#91-exception-hierarchy)
  - [9.2 When to Use CqlEvaluationException](#92-when-to-use-clevaluationexception)
  - [9.3 Key Points](#93-key-points)

## 1. User Workflow Preferences

### 1.1 Discuss Before Implementing
1.1.1 When user asks for ideas, suggestions, or "what would be the best way to..." questions, **DISCUSS OPTIONS FIRST**

1.1.2 Present 2-3 approaches with pros/cons

1.1.3 Wait for user to choose an approach before implementing

1.1.4 DO NOT immediately implement solutions when user asks for ideas

1.1.5 User will explicitly ask to proceed with implementation when ready

### 1.2 Instruction for PR AI
1.2.1 When I ask you to update or improve the Pull Request description, follow these requirements:

   1.2.1.1 **Analyze the entire set of commits in this PR's branch**

   1.2.1.2 **Incorporate all changes made across the full diff**, not just the snippet I'm currently discussing

   1.2.1.3 **Summarize the full scope and intent of the work** done throughout the branch

   1.2.1.4 The PR description should always reflect:
   
      1.2.1.4.1 the whole branch history

      1.2.1.4.2 the complete set of code changes

      1.2.1.4.3 architectural decisions

      1.2.1.4.4 reasoning behind changes

      1.2.1.4.5 any breaking changes or migrations

      1.2.1.4.6 anything meaningful discovered during review discussions

1.2.2 **DO NOT** base the PR description only on the last change request or a summary of my prompt

1.2.3 Your goal: **Maintain a comprehensive, up-to-date PR description that represents the entire branch's work, not just the latest prompt**

### 1.3 Managing Copilot Instructions
1.3.1 When user provides memory-based instructions (e.g., "remember", "never do", "always do"), add them to this copilot instructions file

1.3.2 After updating the instructions, confirm the update by:

   1.3.2.1 If the instruction already existed: State "This instruction already exists in section [heading number]"

   1.3.2.2 If newly added: State "Added to copilot instructions as section [heading number]"

1.3.3 When making changes to this file, increment the version number according to semantic versioning:

   1.3.3.1 **Major version** (x.0.0): Structural changes or major reorganization

   1.3.3.2 **Minor version** (x.y.0): New instructions or sections added

   1.3.3.3 **Patch version** (x.y.z): Clarifications, fixes, or minor edits to existing instructions

1.3.4 **When making changes to this file, always update the Table of Contents** to reflect any added, removed, or renamed sections

### 1.4 Terminal and Command Execution
1.4.1 **CRITICAL - PowerShell Non-Interactive Mode**: When running PowerShell commands via `run_in_terminal`, **ALWAYS** use non-interactive mode by adding the `-NonInteractive` flag (e.g., `pwsh -NonInteractive -Command "..."`) to prevent commands from hanging waiting for user input

1.4.2 Avoid creating interactive shells like `pwsh` or `dotnet repl` unless explicitly requested by the user

## 2. InternalsVisibleTo Configuration

### 2.1 Overview
2.1.1 Always add `InternalsVisibleTo` attributes in `.csproj` files, never in `AssemblyInfo.cs` files

### 2.2 Format
2.2.1 Use the following format in csproj files:

```xml
<ItemGroup>
    <InternalsVisibleTo Include="ProjectName" Key="$(LibraryPKHash)" />
</ItemGroup>
```

### 2.3 Example
2.3.1 Example configuration:

```xml
<ItemGroup>
    <InternalsVisibleTo Include="Hl7.Cql.Runtime" Key="$(LibraryPKHash)" />
    <InternalsVisibleTo Include="CoreTests" Key="$(LibraryPKHash)" />
    <InternalsVisibleTo Include="CqlSdkExamplesPreview" Key="$(LibraryPKHash)" />
</ItemGroup>
```

### 2.4 Key Points
2.4.1 Always use the `Key="$(LibraryPKHash)"` attribute for signed assemblies

2.4.2 Add to existing `<ItemGroup>` containing other `InternalsVisibleTo` entries if available

2.4.3 Create a new `<ItemGroup>` if none exists

2.4.4 Never modify or create `AssemblyInfo.cs` files for this purpose

## 3. Project Structure

### 3.1 SDK Projects
3.1.1 Core SDK projects are located in the `Cql/` directory:

   3.1.1.1 `Cql.Abstractions` - Base abstractions and interfaces

   3.1.1.2 `Cql.Runtime` - Runtime and execution engine

   3.1.1.3 `Cql.Invocation` - Core invocation and toolkit functionality

   3.1.1.4 `CodeGeneration.NET` - Code generation features

### 3.2 Examples
3.2.1 `Examples/CqlSdkExamples/` - Public examples using stable APIs

3.2.2 `Examples/CqlSdkExamplesPreview/` - Preview examples with access to internal/experimental APIs

## 4. Development Guidelines

### 4.1 File Headers

#### 4.1.1 Overview
4.1.1.1 Copyright header requirements for C# source files (*.cs, excluding *.g.cs generated files)

#### 4.1.2 For NEW Files (files being created)
4.1.2.1 Use this header format with "Firely, NCQA" and the current year:

```csharp
/*
 * Copyright (c) <CURRENT_YEAR>, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
```

#### 4.1.3 For EXISTING Files
4.1.3.1 **DO NOT modify existing copyright headers** in files that already have them
4.1.3.2 Leave existing headers exactly as they are (e.g., "NCQA and contributors" should remain unchanged)
4.1.3.3 **When making changes to a file and Firely is not listed as contributor, add it as "Firely, NCQA and contributors"**

#### 4.1.4 Header Guidelines
4.1.4.1 Use the current year in the copyright notice for new files only (replace `<CURRENT_YEAR>` with the actual current year, e.g., 2026 for files created in 2026)

4.1.4.2 For new files, include "Firely, NCQA and contributors" in the copyright line

4.1.4.3 Place header at the very top of the file, after any `#pragma` directives if present

4.1.4.4 Generated files (*.g.cs) do not require headers

4.1.4.5 **Never update or modify existing copyright headers in existing files**

### 4.2 Making Changes
4.2.1 Use minimal, surgical changes - modify as few lines as possible

4.2.2 Maintain existing code structure and patterns

4.2.3 Run builds and tests to validate changes

4.2.4 Use existing project conventions and naming patterns

4.2.5 **Always ensure blank lines contain no spaces** - blank lines must be completely empty

4.2.6 **When adding new utility files or functionality that are only used internally, keep those types as `internal`, not `public`** - Only expose public APIs when they are intended for external consumption

4.2.7 **When creating new files or modifying existing ones, always remove unused usings at the top of the file** - Keep using statements clean and only include what is actually used

4.2.8 **Do not add duplicate usings in files where the using is already included globally in `GlobalUsings.cs`** - Check GlobalUsings.cs first to avoid redundant using statements

4.2.9 **Always use the latest C# language features** when appropriate:
   4.2.9.1 Use collection expressions `[]` instead of `new[] { ... }` for arrays and collections

   4.2.9.2 Use target-typed `new()` expressions when the type is clear from context

   4.2.9.3 Use pattern matching and switch expressions where applicable

   4.2.9.4 Use record types for immutable data structures

   4.2.9.5 Use nullable reference types and null-conditional operators

   4.2.9.6 Use string interpolation instead of `string.Format` or concatenation

4.2.10 **Local functions must use camelCase naming** - Local functions (functions defined inside methods) should start with a lowercase letter (e.g., `processItem()`, not `ProcessItem()`)

### 4.3 Project References
4.3.1 When adding internal access, ensure the requesting project is appropriate for internal API usage

4.3.2 Preview/test projects can access internals, production projects should use public APIs

4.3.3 Always validate that internal access is truly needed

### 4.4 Documentation
4.4.1 Update README files when adding new projects or significant features

4.4.2 **When adding dependencies, also update the README's Dependencies section**

4.4.3 Document experimental features clearly in preview projects

4.4.4 Maintain clear separation between stable and experimental examples

4.4.5 **IMPORTANT: Do not add C# code samples in Usage sections for internal-only projects**
   4.4.5.1 If a project is primarily used internally or through higher-level APIs, avoid providing code examples

   4.4.5.2 Only include code samples for packages that have clear public usage patterns designed for direct consumer use

   4.4.5.3 Remove any placeholder or comment-only code blocks from documentation

   4.4.5.4 Internal packages should describe what they do but not show how to use them directly

## 5. Build and Test

### 5.1 General Build Requirements
5.1.1 **Always use `Cql-Sdk.slnf` to build the solution** - This is because `Cql-Sdk-All.sln` contains submodules to which you do not have access to

5.1.2 Always run `dotnet build` to validate changes

5.1.3 Run relevant tests after modifications

5.1.4 Check that new projects are included in solution files (`*.sln`)

### 5.2 Cross-Platform Compatibility
5.2.1 **CRITICAL**: Any changes to build scripts or project files MUST work on both Windows and non-Windows operating systems (Linux, macOS, WSL)

#### 5.2.2 Requirements for Script Changes
5.2.2.1 **Always maintain both PowerShell (.ps1) and Bash (.sh) script variants** with equivalent functionality

5.2.2.2 Use OS-conditional logic in MSBuild targets: `Condition="'$(OS)' == 'Windows_NT'"` for Windows, `Condition="'$(OS)' != 'Windows_NT'"` for Unix

5.2.2.3 Ensure Bash scripts are executable: `chmod +x script.sh`

5.2.2.4 Test changes on both platforms when possible, or verify OS-conditional logic is correct

#### 5.2.3 Requirements for Path Changes
5.2.3.1 **Use correct case for all directory paths** - Unix filesystems are case-sensitive

5.2.3.2 Verify paths match actual directory names exactly (e.g., `Input/ELM/HL7` not `input/elm/hl7`)

5.2.3.3 Avoid hardcoded path separators - use MSBuild properties like `$(MSBuildThisFileDirectory)`

5.2.3.4 Test that paths work on case-insensitive (Windows) and case-sensitive (Unix) filesystems

#### 5.2.4 Platform-Specific Considerations
5.2.4.1 **Executable extensions**: Windows uses `.exe`, Unix does not - handle conditionally

5.2.4.2 **Line endings**: Git should handle automatically, but be aware of CRLF (Windows) vs LF (Unix)

5.2.4.3 **Shell availability**: Use `pwsh` for PowerShell, `bash` for Bash - don't assume shell locations

5.2.4.4 **File locking**: Use portable mechanisms (e.g., directory-based locking with `mkdir`) instead of platform-specific tools like `flock` (not available on macOS by default)

### 5.3 Code Generation Version Management
5.3.1 **When modifying C# code generation logic, always update the `LibrarySetCSharpCodeGenerator.GeneratorToolVersion`**:
   5.3.1.1 **Locate the version**: The version is hardcoded in `CodeGeneration.NET/_CODE GENERATOR VERSION_.cs` as `GeneratorToolVersion`

   5.3.1.2 **Apply semantic versioning**:
      5.3.1.2.1 **Major version** (x.0.0.0): Breaking changes to generated code that require new `LibraryInstanceInvoker` support

      5.3.1.2.2 **Minor version** (x.y.0.0): Non-breaking additions like new attributes or functionality

      5.3.1.2.3 **Patch version** (x.y.z.0): Bug fixes that don't change the generated API

   5.3.1.3 **Check compatibility**: Ensure `LibraryInstanceInvoker_3_0.SupportsVersion` covers the new version range

   5.3.1.4 **Create new invoker if needed**: For major version changes, a new `LibraryInstanceInvoker_X_Y` may be required

   5.3.1.5 **Examples**:
      5.3.1.5.1 Adding `CqlFunctionParameterAttribute` → Minor version increment (3.0.0.0 → 3.1.0.0)

      5.3.1.5.2 Changing method signatures → Major version increment (3.0.0.0 → 4.0.0.0)

      5.3.1.5.3 Fixing identifier normalization → Patch version increment (3.0.0.0 → 3.0.1.0)

### 5.4 Generating ELM Files from CQL
5.4.1 When adding CQL files (e.g., to `CoreTests\Input\ELM\HL7`), follow these steps to generate the ELM JSON files:
   5.4.1.1 **Enable CQL to ELM conversion**: Find the commented out property `CqlToElmEnabled` in the csproj (e.g., `<!-- <CqlToElmEnabled>true</CqlToElmEnabled> -->`) and uncomment it to set `CqlToElmEnabled` to `true`

   5.4.1.2 **Build the project**: Build that particular csproj, which will generate the ELM files

   5.4.1.3 **Verify generation**: Confirm that all ELM files are generated for each CQL file. The directory for the ELM files can be discovered in the `ElmDirectory` property in the csproj file

   5.4.1.4 **Restore setting**: Roll back step 1 by commenting out `CqlToElmEnabled=true`

## 6. Naming Conventions
6.1 Use `CqlSdk` prefix for SDK-related example projects

6.2 Use `Hl7.Cql` namespace prefix for core SDK assemblies

6.3 Follow existing patterns in the codebase for consistency

## 7. FHIR Library Resource Handling

### 7.1 Library.Name vs Library.Id
7.1.1 **CRITICAL**: `library.Name` and `library.Id` are NOT interchangeable and serve different purposes

7.1.2 **`library.Name`**: The canonical identifier/name used for library identification and versioning (e.g., "MyLibrary")
   7.1.2.1 Use this when constructing `CqlVersionedLibraryIdentifier` or building canonical URLs

   7.1.2.2 This is the name that appears in CQL `library` declarations

   7.1.2.3 Required for library packaging and identification workflows

7.1.3 **`library.Id`**: The FHIR resource identifier, typically a generated or assigned ID (e.g., "Library/abc123")
   7.1.3.1 Use this for resource identification within a FHIR server

   7.1.3.2 NOT suitable for library name/version identification

7.1.4 **DO NOT** use code like: `var name = library.Name ?? library.Id;`

7.1.5 **DO** validate that `library.Name` exists when it's required:

```csharp
if (string.IsNullOrWhiteSpace(library.Name))
{
    logger.LogError("FHIR Library must have a Name property.");
    return ExitCode.InvalidLibraryJson;
}
```

### 7.2 Library Identifier Construction
7.2.1 Always use `CqlVersionedLibraryIdentifier` for parsing and formatting library names and versions:

```csharp
// Creating from separate name and version
var identifier = CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion(library.Name, library.Version);

// Using the identifier (automatically formats as "name-version")
string formatted = identifier.ToString();
```

## 8. CQL Specification Conformance

### 8.1 Authoritative Specification Source
8.1.1 **CRITICAL**: Always use `/spec/condensed/` as the authoritative CQL specification for all development work

8.1.2 The condensed specification is a markdown version of the official CQL 1.5.3 Release 1 Errata 2 specification

8.1.3 **DO NOT** rely on external URLs (cql.hl7.org) as they may be blocked or unavailable

8.1.4 **IMPORTANT**: If external spec URLs (cql.hl7.org) become accessible during your work, clearly notify the user that the external specification is now reachable. This indicates the local spec in the repository may need updating.

8.1.5 The condensed spec contains all specification content without web assets (CSS, JS, images)

### 8.2 When to Check Specification
8.2.1 **Before implementing any CQL operator or function**: Verify behavior against `/spec/condensed/09-b-cqlreference.md`

8.2.2 **During code reviews**: Check that implementation matches specification requirements

8.2.3 **When fixing bugs**: Confirm the expected behavior from the specification before making changes

8.2.4 **When writing tests**: Ensure test expectations align with specification examples and semantics

8.2.5 **When adding new features**: Verify feature requirements and edge cases from the specification

### 8.3 Specification Location
8.3.1 **Main CQL reference**: `/spec/condensed/09-b-cqlreference.md` (operator and function definitions)

8.3.2 **Language semantics**: `/spec/condensed/05-languagesemantics.md`

8.3.3 **Type system**: `/spec/condensed/03-developersguide.md`

8.3.4 **ELM specification**: `/spec/condensed/elm.md`

8.3.5 **Test examples**: `/spec/condensed/tests.md`

8.3.6 **Time interval calculations**: `/spec/condensed/15-h-timeintervalcalculations.md`

8.3.7 **Complete list**: See `/spec/condensed/README.md` for all available specification sections

8.3.8 **Conformance reports**: See `/spec/report/` for known deviations and issue templates

## 9. CQL Evaluation Exceptions

### 9.1 Exception Hierarchy
9.1.1 Two exception types are defined in `Hl7.Cql.Abstractions` (assembly `Hl7.Cql.Abstractions`) for errors raised during CQL evaluation:

- **`CqlException`** (`Hl7.Cql.Exceptions`) — public abstract base exception; message is derived from an `ICqlError` payload
- **`CqlException<TError>`** (`Hl7.Cql.Exceptions`) — generic concrete exception wrapping a strongly-typed `ICqlError` struct payload

9.1.2 To define a new CQL evaluation error, create a `public readonly record struct` implementing `ICqlError`.
**IMPORTANT**: The struct must accept the **metadata** (raw facts like a unit name or value) as constructor parameters, NOT a pre-built message string. `GetMessage()` is responsible for constructing the human-readable message from that metadata:

```csharp
// ✅ CORRECT — struct holds metadata, GetMessage() constructs the message
public readonly record struct CqlArithmeticError(string Unit, string CalendarEquivalent) : ICqlError
{
    public string GetMessage() =>
        $"If a definite-quantity duration above days (or weeks) appears in a date/time arithmetic " +
        $"calculation, the evaluation will end and signal an error to the calling environment. " +
        $"Use '{CalendarEquivalent}' instead of UCUM unit '{Unit}'.";
}

// ❌ WRONG — do NOT pass a pre-built message string
public readonly record struct CqlArithmeticError(string Message) : ICqlError
{
    public string GetMessage() => Message;  // anti-pattern
}

// Throw it:
throw new CqlArithmeticError("a", "year").ToException();
// Catch it:
catch (CqlException<CqlArithmeticError> e) { ... }
```

### 9.2 When to Use CqlException
9.2.1 **ALWAYS** create a specific `ICqlError` struct and throw it as `CqlException<TError>` for any exception that should be raised during the evaluation of a CQL expression, instead of using general .NET exceptions like `InvalidOperationException` or `ArgumentException`.

9.2.2 Examples of when to use `CqlException<TError>`:
   - Spec-mandated errors during date/time arithmetic (use `CqlArithmeticError`)
   - Type mismatch errors at evaluation time
   - Division by zero or other arithmetic failures
   - Any error the CQL spec says "signals an error to the calling environment"

9.2.3 General .NET exceptions (`ArgumentException`, `InvalidOperationException`) are still appropriate for programming errors in the primitives layer (`Cql.Abstractions`), since those types cannot reference `Cql.Runtime`.

### 9.3 Key Points
9.3.1 Exception classes live in the `Cql.Abstractions` project, namespace `Hl7.Cql.Exceptions`

9.3.2 The throw site for CQL evaluation errors is in `CqlOperators` (in `Cql.Runtime`), not in the primitive types (`CqlDate`, `CqlDateTime`, etc. in `Cql.Abstractions`)

9.3.3 `Cql.Abstractions` cannot reference `Cql.Runtime` (circular dependency); primitive methods may throw general .NET exceptions for invalid input, which are caught and re-thrown as `CqlException<TError>` by the operator layer

9.3.4 New evaluation exception types should be added to `Cql/Cql.Abstractions/Abstractions/Exceptions/` and registered in `Cql/Cql.Abstractions/PublicAPI.Unshipped.txt`
