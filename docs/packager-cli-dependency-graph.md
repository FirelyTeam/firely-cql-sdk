# PackagerCLI Diagrams
The diagram is split into two, the first one showing the high-level dependencies for the application, and the second the detailed dependencies for expression building.

### CQL SDK Service Dependencies

Remarks
* Excl Logger and Options
* Cyan classes indicate scoped services
* All others are singleton services
* Classes are group by their respective projects

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
        class CSharpCodeGenerator { }
        class AssemblyCompiler { }
    }

    namespace Packaging {
        class ResourcePackager { }
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

    TypeToCSharpConverter ..> CSharpCodeGenerator : injected
    TypeResolver ..> CSharpCodeGenerator : injected

    TypeResolver ..> AssemblyCompiler : injected

    TypeResolver ..> ResourcePackager : injected
```