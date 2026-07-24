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
