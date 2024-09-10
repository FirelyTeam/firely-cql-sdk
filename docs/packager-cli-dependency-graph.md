# PackagerCLI Diagrams
The diagram is split into two, the first one showing the high-level dependencies for the application, and the second the detailed dependencies for expression building.

### Cql Compiler Service Dependencies

Remarks
* Excl Logger and Options
* Cyan dotted outline classes indicate scoped services
* All others are singleton services

```mermaid
classDiagram
    direction LR

    %% HACK: Mermaid doesnt support commas withing generic, so use a similar looking character (﹐)

    class LibrarySetExpressionBuilder{ }
    class LibraryExpressionBuilder { }        
    class ExpressionBuilder { }
    class TupleBuilderCache { } 

    %% Style Scoped services
    style TupleBuilderCache stroke:#066,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style LibrarySetExpressionBuilder stroke:#066,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style LibraryExpressionBuilder stroke:#066,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style ExpressionBuilder stroke:#066,stroke-width:2px,color:#fff,stroke-dasharray: 5 5

    %% Inheritance  

    BaseTypeResolver --> TypeResolver : inherits
    FhirTypeResolver --> BaseTypeResolver : inherits

    %% Injected Dependencies

    LibraryExpressionBuilder ..> LibrarySetExpressionBuilder : injected

    ExpressionBuilder ..> LibraryExpressionBuilder : injected

    CqlOperatorsBinder ..> ExpressionBuilder : injected
    TupleBuilderCache ..> ExpressionBuilder : injected
    TypeResolver ..> ExpressionBuilder : injected
    CqlContextBinder ..> ExpressionBuilder : injected
    ExpressionBuilderSettings ..> ExpressionBuilder : injected

    TypeResolver ..> CqlOperatorsBinder : injected
    TypeConverter ..> CqlOperatorsBinder : injected

    ModelInspector ..> TypeConverter : injected  
```

### Cql Code Generation Service Dependencies

Remarks
* Excl Logger and Options
* Cyan dotted outline classes indicate scoped services
* All others are singleton services

```mermaid
classDiagram
    direction LR

    %% HACK: Mermaid doesnt support commas withing generic, so use a similar looking character (﹐)

    %% Inheritance  

    WriteToFileCSharpCodeStreamPostProcessor --> CSharpCodeStreamPostProcessor : inherits
    WriteToFileAssemblyDataPostProcessor --> AssemblyDataPostProcessor : inherits

    %% Injected Dependencies

    TypeToCSharpConverter ..> CSharpLibrarySetToStreamsWriter : injected

    AssemblyDataPostProcessor ..> AssemblyCompiler : injected\n(optional)
    CSharpCodeStreamPostProcessor ..> AssemblyCompiler : injected\n(optional)
    CSharpLibrarySetToStreamsWriter ..> AssemblyCompiler : injected
    TypeResolver ..> AssemblyCompiler : injected
    
    TypeResolver ..> CSharpLibrarySetToStreamsWriter : injected
```

### Cql Packager Service Dependencies

Remarks
* Excl Logger and Options
* Cyan dotted outline classes indicate scoped services
* All others are singleton services

```mermaid
classDiagram
    direction LR

    %% HACK: Mermaid doesnt support commas withing generic, so use a similar looking character (﹐)

    class CqlToResourcePackagingPipeline { }
    class PackagerCliProgram { }
    class LibrarySetExpressionBuilder { }

    %% Style Scoped services
    style CqlToResourcePackagingPipeline stroke:#066,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style PackagerCliProgram stroke:#066,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style LibrarySetExpressionBuilder stroke:#066,stroke-width:2px,color:#fff,stroke-dasharray: 5 5

    %% Inheritance  

    BaseTypeResolver --> TypeResolver : inherits
    FhirTypeResolver --> BaseTypeResolver : inherits
    WriteToFileFhirResourcePostProcessor --> FhirResourcePostProcessor : inherits

    %% Injected Dependencies

    AssemblyCompiler ..> CqlToResourcePackagingPipeline : injected
    ResourcePackager ..> CqlToResourcePackagingPipeline : injected 
    LibrarySetExpressionBuilder ..> CqlToResourcePackagingPipeline : injected
    
    OptionsConsoleDumper ..> PackagerCliProgram : injected 
    CqlToResourcePackagingPipeline ..> PackagerCliProgram : injected
      
    TypeResolver ..> ResourcePackager : injected
    FhirResourcePostProcessor ..> ResourcePackager : injected\n(optional) 
```


