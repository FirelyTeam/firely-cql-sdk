# Output .NET runtime version in PackagerCLI banner

## Summary

Improves the `Hl7.Cql.Packager` CLI startup experience by surfacing the
application name, version, build configuration, and host environment details
in two places: the usage/help description and the command-execution log.
The command-line arguments in the log are also reformatted to be easier to
read at a glance.

---

## Changes

### `Program.cs`

- Added static properties `ApplicationName`, `ApplicationVersion`,
  `BuildConfiguration`, and `ApplicationNameAndVersion`:
  - `BuildConfiguration` is omitted from the display when it is `"Release"`,
    so non-Release builds show e.g. `Hl7.Cql.Packager (Debug) v2.6.0`.
  - `ApplicationNameAndVersion` composes name + optional config label + version.
- Added `ApplicationHeader` that appends the .NET runtime description
  (e.g. `running on .NET 8.0.25`).
- Prepended `ApplicationHeader` and a matching separator line to the CLI
  `Description` string so that `--help` output now reads:

  ```
  Description:
    Hl7.Cql.Packager (Debug) v2.6.0 running on .NET 8.0.25
    -------------------------------------------------------
  
    Utilities for converting CQL or ELM into other artefacts ...
  ```

### `OptionsConsoleDumper.cs`

- Replaced the `"- PackageCLI ---"` fixed-text banner with a dynamic
  `= {ApplicationNameAndVersion} ===` header.
- Added `Build` and `Version` fields to the startup log.
- Added `.NET Runtime` and `OS / Architecture` fields to the Environment
  section, using `RuntimeInformation.FrameworkDescription` and
  `RuntimeInformation.OSDescription` / `RuntimeInformation.OSArchitecture`.
- Reformatted `Path` and `Command Line Args` so the value appears on a new
  indented line below the label (consistent with how long values are
  displayed in other tools).
- Extracted a private static `FormatCommandLineArgs(string[] args)` method
  that formats arguments across multiple lines:
  - The command (first arg) appears on its own line.
  - Named args (`--arg value`) are kept together on one line, with values
    column-aligned to the longest arg name.
  - Flags (`--switch`) each appear on their own line.

  Example output:
  ```
  = Hl7.Cql.Packager (Debug) v2.6.0 ===============

  - Environment -----------------------------------
    Path :
      D:\...\Hl7.Cql.Packager.dll
    Command Line Args :
      elm
      --cql      D:\...\input\cql
      --elm      D:\...\Elm
      --fhir     D:\...\Resources
      --cs       D:\...\CSharp
      --log-file packager.log
    Current Time         : 2026-03-25T11:20:59.7601948+01:00
    Current Directory    : D:\...
    .NET Runtime         : 8.0.25
    OS / Architecture    : Microsoft Windows 10.0.26220 / X64
  ```

### `GlobalUsings.cs`

- Added `global using System.Runtime.InteropServices;` to support
  `RuntimeInformation` references.

### `docs/vnext-release-notes.md`

- Documented both improvements under the Features section.

---

## Motivation

Previously the CLI banner showed only a static `"- PackageCLI ---"` heading
with no version or environment context. Operators diagnosing issues had to
inspect the assembly or run `--version` separately. The new banner makes
support and debugging easier by recording all relevant runtime details
directly in the log output.
