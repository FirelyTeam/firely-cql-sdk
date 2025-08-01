# Toolkit Services Dependency Diagrams
These diagrams represent the internal dependencies of the CQL SDK toolkit services.
They use mermaid syntax to visualize the relationships between various components of the CQL SDK.
For the best viewing experience, it is recommended to view these diagrams in the [online mermaid editor](https://www.mermaidchart.com/).

## ElmToolkitServices Dependency Diagram

Services for compiling ELM to C# code and .NET assemblies.

**Remarks:**
* Excludes Logger and Options for clarity
* Cyan classes indicate scoped services
* All others are singleton services
* Classes are grouped by their respective projects

```mermaid
%%{init: {
    'themeVariables':{  
      'lineColor': '#888',
      'lineWidth': 4
}}}%%

classDiagram

    direction LR

    namespace Compiler {
        class LibrarySetExpressionBuilder { }    
        class LibraryExpressionBuilder { }    
        class ExpressionBuilder { }    
        class ExpressionBuilderSettings { }    
        class TupleBuilderCache { }
        class CqlContextBinder { }
        class CqlOperatorsBinder { }       
    }

    namespace CodeGeneration {
        class TypeToCSharpConverter { }
        class LibrarySetCSharpCodeGenerator { }
        class AssemblyCompiler { }
    }

    namespace Abstraction {
        class TypeResolver { }
    }

    namespace Runtime {
        class BaseTypeResolver { }
    }

    namespace Fhir {
        class FhirTypeResolver { }
        class ModelInspector { }
    }

    namespace Conversion {
        class TypeConverter { }
    }

    %% Style Scoped Types as Cyan
    style LibrarySetExpressionBuilder fill:#055
    style LibraryExpressionBuilder fill:#055
    style ExpressionBuilder fill:#055
    style TupleBuilderCache fill:#055
    
    %% Inheritance  
    BaseTypeResolver --> TypeResolver : inherits
    FhirTypeResolver --> BaseTypeResolver : inherits
    
    %% Dependencies                                                 
    LibraryExpressionBuilder ..> LibrarySetExpressionBuilder : injected
    ExpressionBuilder ..> LibraryExpressionBuilder : injected

    TypeResolver ..> ExpressionBuilder : injected
    CqlOperatorsBinder ..> ExpressionBuilder : injected
    TupleBuilderCache ..> ExpressionBuilder : injected
    CqlContextBinder ..> ExpressionBuilder : injected
    ExpressionBuilderSettings ..> ExpressionBuilder : injected

    TypeResolver ..> CqlOperatorsBinder : injected
    TypeConverter ..> CqlOperatorsBinder : injected

    ModelInspector ..> TypeConverter : injected  
    ModelInspector ..> FhirTypeResolver : injected  

    TypeToCSharpConverter ..> LibrarySetCSharpCodeGenerator : injected
    TypeResolver ..> LibrarySetCSharpCodeGenerator : injected

    TypeResolver ..> AssemblyCompiler : injected
```

## PackagingToolkitServices Dependency Diagram

Services for packaging CQL libraries as FHIR Library resources.

**Remarks:**
* Excludes Logger and Options for clarity
* All services are singleton services
* Classes are grouped by their respective projects

```mermaid
%%{init: {
    'themeVariables':{  
      'lineColor': '#888',
      'lineWidth': 4
}}}%%

classDiagram

    direction LR

    namespace Packaging {
        class ResourcePackager { }
        class ResourceCanonicalBuilder { }
        class CqlTypeToFhirTypeMapper { }
    }

    namespace Abstraction {
        class TypeResolver { }
    }

    namespace Runtime {
        class BaseTypeResolver { }
    }

    namespace Fhir {
        class FhirTypeResolver { }
        class ModelInspector { }
    }

    %% Inheritance  
    BaseTypeResolver --> TypeResolver : inherits
    FhirTypeResolver --> BaseTypeResolver : inherits
    
    %% Dependencies                                                 
    TypeResolver ..> ResourcePackager : injected
    ResourceCanonicalBuilder ..> ResourcePackager : injected
    
    ModelInspector ..> FhirTypeResolver : injected
```

## CqlToolkitServices Dependency Diagram

Services for translating CQL to ELM format.

**Remarks:**
* Excludes Logger and Options for clarity
* All services are singleton services except LibraryVisitor which is scoped
* Classes are grouped by their respective projects

```mermaid
%%{init: {
    'themeVariables':{  
      'lineColor': '#888',
      'lineWidth': 4
}}}%%

classDiagram

    direction LR

    namespace CqlToElm {
        class CqlToElmConverter { }
        class LibraryBuilderProvider { }
        class LibraryVisitor { }
        class ExpressionVisitor { }
    }

    namespace Model {
        class ModelInfo { }
        class IModelProvider { }
    }

    namespace Infrastructure {
        class ILibraryProvider { }
    }

    %% Style Scoped Types as Cyan
    style LibraryVisitor fill:#055
    
    %% Dependencies                                                 
    LibraryBuilderProvider ..> CqlToElmConverter : injected
    ILibraryProvider ..> CqlToElmConverter : injected
    IModelProvider ..> CqlToElmConverter : injected
    
    ModelInfo ..> IModelProvider : configured
    
    LibraryBuilderProvider --> ILibraryProvider : implements
```