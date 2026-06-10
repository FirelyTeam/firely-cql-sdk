# 7. FHIR Library Resource Handling

Parent document: [../copilot-instructions.md](../copilot-instructions.md)

## 7.0. Table of Contents

- [7. FHIR Library Resource Handling](#7-fhir-library-resource-handling)
- [7.0. Table of Contents](#70-table-of-contents)
- [7.1. Library.Name vs Library.Id](#71-libraryname-vs-libraryid)
- [7.2. Library Identifier Construction](#72-library-identifier-construction)

## 7.1. Library.Name vs Library.Id

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

## 7.2. Library Identifier Construction

7.2.1 Always use `CqlVersionedLibraryIdentifier` for parsing and formatting library names and versions:

```csharp
// Creating from separate name and version
var identifier = CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion(library.Name, library.Version);

// Using the identifier (automatically formats as "name-version")
string formatted = identifier.ToString();
```