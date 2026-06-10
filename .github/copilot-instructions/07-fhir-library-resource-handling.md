# 07. FHIR Library Resource Handling

## 7.1 Library.Name vs Library.Id

7.1.1 Library.Name and Library.Id are not interchangeable and serve different purposes.

7.1.2 library.Name is the canonical identifier used for library identification and versioning (for example, MyLibrary).

7.1.2.1 Use this when constructing CqlVersionedLibraryIdentifier or building canonical URLs.

7.1.2.2 This is the name that appears in CQL library declarations.

7.1.2.3 Required for library packaging and identification workflows.

7.1.3 library.Id is the FHIR resource identifier, typically a generated or assigned ID (for example, Library/abc123).

7.1.3.1 Use this for resource identification within a FHIR server.

7.1.3.2 Not suitable for library name/version identification.

7.1.4 Do not use code like: var name = library.Name ?? library.Id;

7.1.5 Do validate that library.Name exists when required:

```csharp
if (string.IsNullOrWhiteSpace(library.Name))
{
    logger.LogError("FHIR Library must have a Name property.");
    return ExitCode.InvalidLibraryJson;
}
```

## 7.2 Library Identifier Construction

7.2.1 Always use CqlVersionedLibraryIdentifier for parsing and formatting library names and versions:

```csharp
var identifier = CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion(library.Name, library.Version);
string formatted = identifier.ToString();
```
