## Main Classes Involved in Translating CQL to ELM

Here are the key classes and their roles in the CQL-to-ELM translation process:

### 1. `CqlToolkit`
- **Purpose:** High-level API for translating CQL libraries to ELM libraries.
- **Role:** Accepts CQL input, manages configuration, and exposes translation methods.

### 2. `CqlToolkitServices`
- **Purpose:** Aggregates all services and dependencies needed for translation.
- **Role:** Provides access to the converter, builder provider, and other services.

### 3. `CqlToElmConverter`
- **Purpose:** Performs the actual conversion from CQL to ELM.
- **Role:** Parses CQL and produces ELM `Library` objects, using visitors and builders.

### 4. `LibraryBuilderProvider`
- **Purpose:** Manages and resolves `LibraryBuilder` instances for each library.
- **Role:** Tracks translation state and provides builders as needed.

### 5. `LibraryVisitor`
- **Purpose:** Walks the parsed CQL syntax tree and builds ELM elements.
- **Role:** Converts CQL definitions and expressions into ELM equivalents.

### 6. `LibraryBuilder`
- **Purpose:** Builds up the ELM `Library` object during the translation.
- **Role:** Collects definitions, errors, and symbol information for the ELM output.

---

**Summary:**  
- `CqlToolkit` is the entry point.
- `CqlToolkitServices` wires up dependencies.
- `CqlToElmConverter` does the conversion.
- `LibraryVisitor` and `LibraryBuilder` handle parsing and ELM object construction.
- `LibraryBuilderProvider` manages library state and resolution.

**Diagram Representation:**
```mermaid
classDiagram
    CqlToolkit "1" --> "1" CqlToolkitServices : uses
    CqlToolkitServices "1" --> "1" CqlToElmConverter : provides
    CqlToolkitServices "1" --> "1" LibraryBuilderProvider : provides
    CqlToElmConverter "1" --> "1" LibraryVisitor : uses
    CqlToElmConverter "1" --> "1" LibraryBuilderProvider : uses
    LibraryVisitor "1" --> "1" LibraryBuilder : builds
    LibraryBuilderProvider "1" --> "*" LibraryBuilder : manages
````