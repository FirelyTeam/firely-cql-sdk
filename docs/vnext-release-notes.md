# vNext Release Notes

## Breaking Changes

### `Cql.Runtime` — List-membership operators (`Contains<T>` and `In<T>`) nullability annotations updated

The `ICqlOperators` list-membership overload signatures now explicitly model nullable element and nullable list inputs:

**Before:**
```csharp
bool? Contains<T>(IEnumerable<T?>? list, T item);
bool? In<T>(T element, IEnumerable<T> argument);
```

**After:**
```csharp
bool? Contains<T>(IEnumerable<T?>? list, T? item);
bool? In<T>(T? element, IEnumerable<T?>? argument);
```

### `Cql.Runtime` / `Cql.CqlToElm` — `Power` on `Integer`/`Long` now returns `Decimal`

`Power` overloads for integer and long operands now consistently produce a decimal result across runtime and CQL→ELM typing.
This is a breaking API/behavioral typing change for consumers that previously expected integer/long results for these overloads.

**Changed signatures:**
```csharp
decimal? Power(int? argument, int? exponent);
decimal? Power(long? argument, long? exponent);
```

### `Cql.Packaging` — `SerializeFhirResourcesToJson` signature change

`PackagingToolkit.SerializeFhirResourcesToJson` no longer accepts a `configureJsonSerializerOptions` parameter. Serialization now goes through the Firely SDK's `BaseFhirJsonSerializer` directly.

**Before:**
```csharp
toolkit.SerializeFhirResourcesToJson(resources, writeIndented: true, opts => opts.WriteIndented = true);
```

**After:**
```csharp
toolkit.SerializeFhirResourcesToJson(resources, writeIndented: true);
```

### `Cql.Invocation` — `AddAssemblyBinariesInFhirLibrariesFromDirectory` and `AddAssemblyBinariesFromFhirLibraryAndDependencies` signature change

Both methods no longer accept a `configureJsonSerializerOptions` parameter. Deserialization now uses the Firely SDK's `BaseFhirJsonDeserializer` with `DeserializationMode.NoOverflow`.

**Before:**
```csharp
toolkit.AddAssemblyBinariesInFhirLibrariesFromDirectory(dir, filePredicate: pred, configureJsonSerializerOptions: opts => { });
toolkit.AddAssemblyBinariesFromFhirLibraryAndDependencies(id, resolver, filePredicate: pred, configureJsonSerializerOptions: opts => { });
```

**After:**
```csharp
toolkit.AddAssemblyBinariesInFhirLibrariesFromDirectory(dir, filePredicate: pred);
toolkit.AddAssemblyBinariesFromFhirLibraryAndDependencies(id, resolver, filePredicate: pred);
```

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

### `Cql.Runtime` — `null in list` now returns correct Boolean result

`In<T>` and `CodeInList` now correctly implement CQL list-membership semantics for null elements:

- `null in { 1, null }` → `true` (list contains a null)
- `null in { 1, 2, 3 }` → `false` (list has no null)
- `null in {}` → `false` (empty list)
- `5 in null` → `false` (null list)

Previously, a null element always caused `null` to be returned, which violated the CQL spec.

### FHIR Library deserialization now tolerates non-conformant FHIR ids and canonical URLs

The FHIR Library JSON deserialization in `Cql.Packaging`, `Cql.Invocation`, and the PackagerCLI has been
switched from `System.Text.Json` (with strict FHIR validation) to the Firely SDK's `BaseFhirJsonDeserializer`
with `DeserializationMode.NoOverflow`. This resolves failures when loading FHIR Library resources that contain
non-conformant resource ids (e.g. underscores: `Library-BCSE_Concepts-2025.1.0`) or non-standard canonical
URL values — a common occurrence in real-world HEDIS and other measure-set bundles. Non-fatal deserialization
issues are now reported as logger warnings rather than hard exceptions.
