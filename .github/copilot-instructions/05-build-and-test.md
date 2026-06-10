# 05. Build and Test

## 5.1 General Build Requirements

5.1.1 Always use Cql-Sdk.slnf to build the solution because Cql-Sdk-All.sln contains submodules that may be inaccessible.

5.1.2 Always run dotnet build to validate changes.

5.1.3 Run relevant tests after modifications.

5.1.4 Check that new projects are included in solution files (*.sln).

## 5.2 Cross-Platform Compatibility

5.2.1 Any changes to build scripts or project files must work on Windows and non-Windows operating systems (Linux, macOS, WSL).

### 5.2.2 Requirements for Script Changes

5.2.2.1 Maintain both PowerShell (.ps1) and Bash (.sh) variants with equivalent functionality.

5.2.2.2 Use OS-conditional logic in MSBuild targets:

5.2.2.2.1 Condition="'$(OS)' == 'Windows_NT'" for Windows

5.2.2.2.2 Condition="'$(OS)' != 'Windows_NT'" for Unix

5.2.2.3 Ensure Bash scripts are executable with chmod +x script.sh.

5.2.2.4 Test changes on both platforms when possible, or verify OS-conditional logic is correct.

### 5.2.3 Requirements for Path Changes

5.2.3.1 Use correct case for all directory paths because Unix filesystems are case-sensitive.

5.2.3.2 Verify paths match actual directory names exactly (for example, Input/ELM/HL7 not input/elm/hl7).

5.2.3.3 Avoid hardcoded path separators and use MSBuild properties like $(MSBuildThisFileDirectory).

5.2.3.4 Test paths on case-insensitive and case-sensitive filesystems.

### 5.2.4 Platform-Specific Considerations

5.2.4.1 Executable extensions: Windows uses .exe and Unix does not. Handle conditionally.

5.2.4.2 Line endings: be aware of CRLF (Windows) versus LF (Unix).

5.2.4.3 Shell availability: use pwsh for PowerShell and bash for Bash. Do not assume locations.

5.2.4.4 File locking: use portable mechanisms (for example, directory-based locking via mkdir) instead of platform-specific tools like flock.

## 5.3 Code Generation Version Management

5.3.1 When modifying C# code generation logic, always update LibrarySetCSharpCodeGenerator.GeneratorToolVersion.

5.3.1.1 Locate version in Cql/CodeGeneration.NET/_CODE GENERATOR VERSION_.cs as GeneratorToolVersion.

5.3.1.2 Apply semantic versioning:

5.3.1.2.1 Major version (x.0.0.0): breaking changes requiring new LibraryInstanceInvoker support

5.3.1.2.2 Minor version (x.y.0.0): non-breaking additions (for example, new attributes or functionality)

5.3.1.2.3 Patch version (x.y.z.0): bug fixes without generated API changes

5.3.1.3 Check compatibility to ensure LibraryInstanceInvoker_3_0.SupportsVersion covers new version range.

5.3.1.4 Create new invoker if needed for major version changes.

5.3.1.5 Examples:

5.3.1.5.1 Adding CqlFunctionParameterAttribute: minor increment (3.0.0.0 to 3.1.0.0)

5.3.1.5.2 Changing method signatures: major increment (3.0.0.0 to 4.0.0.0)

5.3.1.5.3 Fixing identifier normalization: patch increment (3.0.0.0 to 3.0.1.0)

## 5.4 Generating ELM Files from CQL

5.4.1 When adding CQL files (for example, in Cql/CoreTests/Input/ELM/HL7), follow these steps:

5.4.1.1 Enable CQL to ELM conversion by uncommenting CqlToolingEnabled in the target csproj.

5.4.1.2 Build that csproj to generate ELM files.

5.4.1.3 Verify all ELM files are generated for each CQL file using ElmDirectory property.

5.4.1.4 Restore setting by commenting out CqlToolingEnabled=true.
