# 5. Build and Test

Parent document: [../copilot-instructions.md](../copilot-instructions.md)

## 5.0. Table of Contents

- [5. Build and Test](#5-build-and-test)
- [5.0. Table of Contents](#50-table-of-contents)
- [5.1. General Build Requirements](#51-general-build-requirements)
- [5.2. Cross-Platform Compatibility](#52-cross-platform-compatibility)
- [5.3. Code Generation Version Management](#53-code-generation-version-management)
- [5.4. Generating ELM Files from CQL](#54-generating-elm-files-from-cql)

## 5.1. General Build Requirements

5.1.1 **Always use `Cql-Sdk.slnf` to build the solution** - This is because `Cql-Sdk-All.sln` contains submodules to which you do not have access to

5.1.2 Always run `dotnet build` to validate changes

5.1.3 Run relevant tests after modifications

5.1.4 Check that new projects are included in solution files (`*.sln`)

## 5.2. Cross-Platform Compatibility

5.2.1 **CRITICAL**: Any changes to build scripts or project files MUST work on both Windows and non-Windows operating systems (Linux, macOS, WSL)

### 5.2.2. Requirements for Script Changes

5.2.2.1 **Always maintain both PowerShell (.ps1) and Bash (.sh) script variants** with equivalent functionality

5.2.2.2 Use OS-conditional logic in MSBuild targets: `Condition="'$(OS)' == 'Windows_NT'"` for Windows, `Condition="'$(OS)' != 'Windows_NT'"` for Unix

5.2.2.3 Ensure Bash scripts are executable: `chmod +x script.sh`

5.2.2.4 Test changes on both platforms when possible, or verify OS-conditional logic is correct

### 5.2.3. Requirements for Path Changes

5.2.3.1 **Use correct case for all directory paths** - Unix filesystems are case-sensitive

5.2.3.2 Verify paths match actual directory names exactly (e.g., `Input/ELM/HL7` not `input/elm/hl7`)

5.2.3.3 Avoid hardcoded path separators - use MSBuild properties like `$(MSBuildThisFileDirectory)`

5.2.3.4 Test that paths work on case-insensitive (Windows) and case-sensitive (Unix) filesystems

### 5.2.4. Platform-Specific Considerations

5.2.4.1 **Executable extensions**: Windows uses `.exe`, Unix does not - handle conditionally

5.2.4.2 **Line endings**: Git should handle automatically, but be aware of CRLF (Windows) vs LF (Unix)

5.2.4.3 **Shell availability**: Use `pwsh` for PowerShell, `bash` for Bash - don't assume shell locations

5.2.4.4 **File locking**: Use portable mechanisms (e.g., directory-based locking with `mkdir`) instead of platform-specific tools like `flock` (not available on macOS by default)

## 5.3. Code Generation Version Management

5.3.1 **What counts as a code generation change**: Any change that alters the C# emitted for CQL libraries requires a `GeneratorToolVersion` update, regardless of which project the change lives in. This includes:
5.3.1.1 Changes in `CodeGeneration.NET` (the C# writer itself)

5.3.1.2 Changes in `Cql.Compiler` that affect the expression trees being emitted — for example, `CqlOperatorsBinder` selecting a different `ICqlOperators` method or overload (e.g., binding `Coalesce<T>` instead of `CoalesceValueTypes<T>`), changed generic type arguments, or changed conversions

5.3.1.3 Changes to `ICqlOperators` signatures or constraints that flow into generated call sites

5.3.2 **When modifying C# code generation logic, always update the `LibrarySetCSharpCodeGenerator.GeneratorToolVersion`**:
5.3.2.1 **Locate the version**: The version is hardcoded in `CodeGeneration.NET/_CODE GENERATOR VERSION_.cs` as `GeneratorToolVersion`

5.3.2.2 **Apply semantic versioning**:
5.3.2.2.1 **Major version** (x.0.0.0): Breaking changes to generated code that require new `LibraryInstanceInvoker` support

      5.3.2.2.2 **Minor version** (x.y.0.0): Non-breaking additions like new attributes or functionality

      5.3.2.2.3 **Patch version** (x.y.z.0): Bug fixes that don't change the generated API

5.3.2.3 **Check compatibility**: Ensure the current `LibraryInstanceInvoker_X_Y.SupportsVersion` covers the new version (check `MinSupportedGeneratorToolVersion` and `FirstUnsupportedGeneratorToolVersion` in `Cql.Invocation/Toolkit/Internal/LibraryInvoker.X.Y.cs`)

5.3.2.4 **Create new invoker if needed**: For major version changes, a new `LibraryInstanceInvoker_X_Y` may be required

5.3.2.5 **Regenerate checked-in generated code**: The version is embedded in every checked-in `*.g.cs` file via `GeneratedCodeAttribute` (e.g., `CoreTests/CSharp`, Demo library sets). Regenerate these libraries as part of the same pull request so the embedded version matches

5.3.2.6 **Examples**:
5.3.2.6.1 Adding `CqlFunctionParameterAttribute` → Minor version increment (3.0.0.0 → 3.1.0.0)

      5.3.2.6.2 Changing method signatures → Major version increment (3.0.0.0 → 4.0.0.0)

      5.3.2.6.3 Fixing identifier normalization → Patch version increment (3.0.0.0 → 3.0.1.0)

      5.3.2.6.4 Binder emits a different `ICqlOperators` method for the same CQL (e.g., `CoalesceValueTypes<T>` → `Coalesce<T>`) → Patch version increment (5.1.0.0 → 5.1.1.0)

## 5.4. Generating ELM Files from CQL

5.4.1 When adding CQL files (e.g., to `CoreTests\Input\ELM\HL7`), follow these steps to generate the ELM JSON files:
5.4.1.1 **Enable CQL to ELM conversion**: Find the commented out property `CqlToolingEnabled` in the csproj (e.g., `<!-- <CqlToolingEnabled>true</CqlToolingEnabled> -->`) and uncomment it to set `CqlToolingEnabled` to `true`

5.4.1.2 **Build the project**: Build that particular csproj, which will generate the ELM files

5.4.1.3 **Verify generation**: Confirm that all ELM files are generated for each CQL file. The directory for the ELM files can be discovered in the `ElmDirectory` property in the csproj file

5.4.1.4 **Restore setting**: Roll back step 1 by commenting out `CqlToolingEnabled=true`
