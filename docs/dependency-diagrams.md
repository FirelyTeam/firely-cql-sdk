# Toolkit Services Dependency Diagrams
These diagrams represent the internal dependencies of the CQL SDK toolkit services.

Each diagram is authored as a Mermaid flowchart (grouped into `subgraph` boxes per project, with each
type shown as a title + one-line description) and rendered to a `.svg` ahead of time (see
[tools/mermaid/](../tools/mermaid/)) rather than relying on GitHub's inline Mermaid renderer, which
does not reliably support every Mermaid feature used here (`subgraph` grouping, HTML node labels,
multi-target `style` directives). If you edit a diagram, edit its `.mmd` source file and regenerate
the `.svg` — see [tools/mermaid/README.md](../tools/mermaid/README.md).

## ElmToolkitServices Dependency Diagram

Services for compiling ELM to C# code and .NET assemblies.

**Remarks:**
* Excludes Logger and Options for clarity
* Cyan classes indicate scoped services
* All others are singleton services
* Classes are grouped by their respective projects

Mermaid source: [dependency-diagrams.elm-toolkit-services.mmd](diagrams/dependency-diagrams.elm-toolkit-services.mmd)

![ElmToolkitServices Dependency Diagram](diagrams/dependency-diagrams.elm-toolkit-services.svg)

| Type | Project | Description |
| --- | --- | --- |
| `LibrarySetCodeBuilder` | Compiler | Builds C# code-model definitions for every library in a library set — the top of the ELM→C# pipeline. |
| `LibraryCodeBuilder` | Compiler | Processes a single library's ELM definitions into a `CqlDefinitionDictionary` of C# code-model members. |
| `CodeBuilder` | Compiler | Builds the C# code-model expression tree for one CQL/ELM expression definition. |
| `CodeBuilderSettings` | Compiler | Configuration flags controlling `CodeBuilder` behavior (e.g. scope-redefinition rules). |
| `TupleBuilderCache` | Compiler | Creates and caches dynamically-generated CQL tuple types for the current library set. |
| `CqlContextBinder` | Compiler | Binds ELM parameter/context references to `CqlContext` runtime method calls. |
| `CqlOperatorsBinder` | Compiler | Resolves an ELM operator/function call to the matching `ICqlOperators` method overload. |
| `LibraryPreprocessorBuilder` | Compiler | Creates a `LibraryPreprocessor` that runs a preparatory pass over a library set before code building. |
| `TypeToCSharpConverter` | CodeGeneration | Formats .NET `Type`/`TypeInfo` values as C# source-code type-name syntax (including CQL tuple types) for the emitted code. |
| `LibrarySetCSharpCodeGenerator` | CodeGeneration | Turns the built `CqlDefinition` dictionary into per-library .NET C# classes (usings, tuple metadata, singleton/`ILibrary` boilerplate). |
| `AssemblyCompiler` | CodeGeneration | Compiles the generated C# source into an in-memory .NET assembly via Roslyn. |
| `ICacheKeyGenerator` | CodeGeneration | Abstraction for generating a deterministic cache key for a library/definition pair. |
| `DeterministicIdGenerator` | CodeGeneration | SHA256-hash-based `ICacheKeyGenerator` implementation, salted per library set. |
| `TypeResolver` | Abstraction | Abstract base defining how ELM type specifiers map to .NET `Type`s. |
| `BaseTypeResolver` | Runtime | `TypeResolver` implementation providing the default CQL System-type-to-.NET mappings. |
| `TypeConverter` | Runtime | Runtime value-conversion engine used to coerce values between CQL/.NET types. |
| `FhirTypeResolver` | Fhir | `BaseTypeResolver` extended with FHIR resource/type mappings, built from a Firely SDK `ModelInspector`. |
| `ModelInspector` | Fhir *(external)* | External Firely .NET SDK type (`Hl7.Fhir.Introspection`) that reflects over FHIR POCO classes to expose their type/property metadata. |

## PackagingToolkitServices Dependency Diagram

Services for packaging CQL libraries as FHIR Library resources.

**Remarks:**
* Excludes Logger and Options for clarity
* All services are singleton services
* Classes are grouped by their respective projects
* `ResourceCanonicalBuilder` is a delegate, not a class — shown as a class here only for diagram simplicity
* `CqlTypeToFhirTypeMapper` is registered in this container but is never DI-injected anywhere; `ResourcePackager` builds its own instance manually from its injected `TypeResolver`
* `ModelInspector` is an external type from the Firely .NET SDK (`Hl7.Fhir.Introspection`), not source declared in this repo

Mermaid source: [dependency-diagrams.packaging-toolkit-services.mmd](diagrams/dependency-diagrams.packaging-toolkit-services.mmd)

![PackagingToolkitServices Dependency Diagram](diagrams/dependency-diagrams.packaging-toolkit-services.svg)

| Type | Project | Description |
| --- | --- | --- |
| `ResourcePackager` | Packaging | Packages a compiled ELM/C#/assembly bundle for one library into FHIR `Library` (and optionally `Measure`) resources. |
| `ResourceCanonicalBuilder` | Packaging *(delegate)* | Builds a FHIR resource's canonical URL from its type, identifier, and version. |
| `CqlTypeToFhirTypeMapper` | Packaging | Maps CQL/ELM types to their corresponding FHIR type representations for packaging. |
| `TypeResolver` | Abstraction | Abstract base defining how ELM type specifiers map to .NET `Type`s. |
| `BaseTypeResolver` | Runtime | `TypeResolver` implementation providing the default CQL System-type-to-.NET mappings. |
| `FhirTypeResolver` | Fhir | `BaseTypeResolver` extended with FHIR resource/type mappings, built from a Firely SDK `ModelInspector`. |
| `ModelInspector` | Fhir *(external)* | External Firely .NET SDK type (`Hl7.Fhir.Introspection`) that reflects over FHIR POCO classes to expose their type/property metadata. |

## CqlToolkitServices Dependency Diagram

Services for translating CQL to ELM format.

**Remarks:**
* Excludes Logger and Options for clarity
* All services are singleton services except `LibraryVisitor` (scoped); `LibraryVisitor.DefinitionVisitor`, `ExpressionVisitor` and `TypeSpecifierVisitor` (transient factories, created per-`LibraryBuilder` via a `Func<LibraryBuilder, T>` factory delegate); and `LocalIdentifierProvider` (plain transient)
* Classes are grouped by their respective projects
* `DefinitionVisitor` below is the nested class `LibraryVisitor.DefinitionVisitor`
* `BuiltinModelProvider` is the concrete `IModelProvider` implementation actually registered by this toolkit

Mermaid source: [dependency-diagrams.cql-toolkit-services.mmd](diagrams/dependency-diagrams.cql-toolkit-services.mmd)

![CqlToolkitServices Dependency Diagram](diagrams/dependency-diagrams.cql-toolkit-services.svg)

| Type | Project | Description |
| --- | --- | --- |
| `CqlToElmConverter` | CqlToElm | Entry point that parses CQL source text and drives translation into an ELM `Library`. |
| `LibraryBuilderProvider` | CqlToElm | `ILibraryProvider` implementation that resolves an `include`d library, translating it from CQL on demand if not already built. |
| `LibraryVisitor` | CqlToElm | ANTLR visitor that walks a parsed CQL library (using/include/parameter/code/valueset/concept definitions and statements) into a `LibraryBuilder`. |
| `DefinitionVisitor` | CqlToElm | `LibraryVisitor`'s nested visitor for CQL definitions (`include`, `codesystem`, `valueset`, `code`, `concept`, `parameter`, expression/function/context definitions). |
| `ExpressionVisitor` | CqlToElm | ANTLR visitor that translates CQL expression syntax into ELM `Expression` nodes. |
| `TypeSpecifierVisitor` | CqlToElm | ANTLR visitor that translates CQL type-specifier syntax (`Interval<T>`, `Choice<...>`, etc.) into ELM `TypeSpecifier`s. |
| `ILibraryProvider` | CqlToElm | Abstraction for resolving an included library by name/version during translation. |
| `IModelProvider` | CqlToElm | Abstraction for looking up a data model's types and conversion functions by URI/name. |
| `CoercionProvider` | CqlToElm | Implements CQL's implicit-conversion/coercion-cost rules between expression types. |
| `ElmFactory` | CqlToElm | Builds ELM invocation/function-reference nodes for a resolved operator or function call. |
| `SystemLibrary` | CqlToElm | The built-in ELM `Library` containing every CQL-spec system operator/function definition. |
| `StreamInspector` | CqlToElm | Detects whether an input stream is CQL text or ELM JSON/XML and identifies its library. |
| `InvocationBuilder` | CqlToElm | Builds the implicit-cast expression chain for a function/operator call's arguments, per the CQL conversion-precedence rules. |
| `LocalIdentifierProvider` | CqlToElm | Generates unique local identifiers used while building ELM expression trees. |
| `MessageProvider` | CqlToElm | Produces localized diagnostic/error messages for the CQL-to-ELM translator. |
| `BuiltinModelProvider` | CqlToElm | Default `IModelProvider` implementation backed by an in-memory set of registered `ModelInfo`s. |
| `ModelInfo` | Model | Generated ELM `modelInfo` schema class describing a data model's available types and conversion functions (e.g. the FHIR or System model). |
