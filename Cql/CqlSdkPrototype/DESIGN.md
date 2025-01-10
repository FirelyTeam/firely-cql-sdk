Work for #580 

This PR is a prototype for the CQL public API. 

## Target Consumers of API:
- Basic: Developers using API as-is. We will write stable versioned API for this group.
- Advanced: Developers wanting to extend the API. This group may extend functionality of the API writing extension methods on the interfaces provided under namespaces ending with ".Extensibility". (May have to pick a better name at a later stage for this). These interfaces are not considered part of the basic API and not considered stable.

## APIs
Split into multiple APIs: 
- CQL API 
  - Core
    - add CQL strings
    - convert CQL to ELM
    - access to generated ELM
  - Extensions
    - add CQL from files, directories, etc.
    - save ELM to directories
    - invoke runtime definitions (via ELM, then Runtime API)
- ELM API
  - Core
    - add ELM libraries
    - convert ELM -> C# -> .NET assemblies + debug symbols -> FHIR Resources (library, measure, etc.))

      At no point between ELM and the ultimate outputs is it allowed to modify or inject the intermediate artifacts, e.g. changing the C#, or adding additional DLLs into a FHIR resource is not allowed
    - access to generated C#, assemblies, debug symbols, FHIR Resources
    - ❓ signing assemblies
    - ❓ access to warnings and errors via property
  - Extensions
    - add ELM from CQL API output
    - add ELM from files, directories, etc.
    - save C# to directories
    - save assemblies to directories
    - save debug symbols to directories
    - save FHIR Resources to directories
    - invoke runtime definitions (via Runtime API)
- Runtime API
  - extract assemblies from FHIR Resources (Extension?)
  - add assembly bytes with optional debug symbols bytes
  - provide access to assemblies
  - allow dynamically invoking definitions given a library name/version and the definition name

## Considerations:
- Keeping it very simple for users of the API
- API divided into basic/public/stable and advanced/"internal"/beta
- ~Error handling will be available through an Errors property instead of exceptions~
- Error handling - allow best effort processing, ignoring errors.  Each stage 
- Single-threaded, synchronous operations
- Choosing specialized types (e.g. `DirectoryInfo`, `CqlVersionedIdentifier`) over strings
- ~Immutable compilation units~
- Using files, strings and byte arrays as input and output. No streams (considered advanced)
- Only focused on translating, not on introspection of libraries
- Extending the API possible with extension methods using "advanced" interfaces
- Advanced features available through interfaces and implemented as explicit in derived types
  - Introspection of cql or elm
  - Streams?
  - Internal access to services?