# vNext Release Notes

## Breaking Changes

TBD

## Features

### PackagerCLI — improved startup banner and command-line display

**Usage help banner**

The usage/help output now includes the app name, build configuration (omitted when `Release`), version, and .NET runtime version in the `Description` field:

```
Description:
  Hl7.Cql.Packager (Debug) v2.6.0 running on .NET 8.0.25
  ------------------------------------------------------
```

**Command execution banner**

When running a command, the startup log now includes additional OS and architecture information, and the command-line arguments are formatted across multiple lines for readability. Named arguments (`--arg value`) are kept together on one line with values column-aligned, while the command and flags each appear on their own line:

```
= Hl7.Cql.Packager (Debug) v2.6.0 ===============

- Environment -----------------------------------
  Path :
    D:\firely-cql-sdk\Cql\PackagerCLI\bin\Debug\net8.0\Hl7.Cql.Packager.dll
  Command Line Args :
    elm
    --cql      D:\...\input\cql
    --elm      D:\...\Elm
    --fhir     D:\...\Resources
    --cs       D:\...\CSharp
    --log-file packager.log
  Current Time         : 2026-03-25T11:20:59.7601948+01:00
  Current Directory    : D:\firely-cql-sdk\Cql\PackagerCLI\bin\Debug\net8.0
  .NET Runtime         : 8.0.25
  OS / Architecture    : Microsoft Windows 10.0.26220 / X64
```

## Fixes

TBD
