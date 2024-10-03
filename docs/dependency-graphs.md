# Service Dependency Graphs

## Table of Contents
1. [CQL Runtime](#h2-cql-runtime)
1. [CQL to ELM](#h2-cql-to-elm)
1. [CQL Packager SDK (with dependencies: Code Generation and Compiler)](#h2-cql-packager)

<a name="h2-cql-runtime"></a>
## CQL Runtime

**Legend**
  * Exclude dependencies to  `ILogger<T>` and `IOptions<T>`
  * <span style="background:#055">Cyan</span> classes indicate scoped services
  * <span style="background:#505">Purple</span> classes indicate transient services
  * <span style="background:#555">Gray</span> classes indicate types not registered by the service provider
  * <span style="background:#550">Brown</span> classes indicate singleton services
  * Classes are group by their respective project groups

```mermaid

classDiagram

    direction LR

    namespace Microsoft {
        class DateTimeOffset { }
    }

    namespace Runtime {
        class CqlContext { }
        class ICqlOperators { }
        class CqlOperators { }
        class DefinitionDictionary_Delegate_ { }
        class FhirCqlContext { }
        class FhirModelBindingSetup { }
        class IDataSource { }
        class IValueSetDictionary { }
        class FhirModelBindingOptions { }
    }

    %% Style Singleton Types as Brown
    
    %% style IServiceProvider fill:#550

    %% Style Scoped Types as Cyan
    
    %% style LibraryBuilder fill:#055

    %% Style Transient Types as Purple

    %% style LocalIdentifierProvider fill: #505

    %% Style Non-Services Types as Gray

    %% style LibraryInfo fill: #555

    %% Inheritance  

    CqlOperators --> ICqlOperators : inherits
    
    %% Dependencies

    FhirCqlContext ..> CqlContext : created by
    ICqlOperators ..> CqlContext : injected by\nFhirCqlContext.ForBundle
    DefinitionDictionary_Delegate_ ..> CqlContext : injected by\nFhirCqlContext.ForBundle

    IDataSource ..> FhirModelBindingSetup : injected by\nFhirCqlContext.ForBundle
    IValueSetDictionary ..> FhirModelBindingSetup : injected by\nFhirCqlContext.ForBundle
    FhirModelBindingOptions ..> FhirModelBindingSetup : injected by\nFhirCqlContext.ForBundle
    DateTimeOffset ..> FhirModelBindingSetup : injected by\nFhirCqlContext.ForBundle
```


<a name="h2-cql-to-elm"></a>
## CQL to ELM

NOTE: This is a work in progress

**Legend**
  * Exclude dependencies to  `ILogger<T>` and `IOptions<T>`
  * <span style="background:#055">Cyan</span> classes indicate scoped services
  * <span style="background:#505">Purple</span> classes indicate transient services
  * <span style="background:#555">Gray</span> classes indicate types not registered by the service provider
  * <span style="background:#550">Brown</span> classes indicate singleton services
  * Classes are group by their respective projects

```mermaid

classDiagram

    direction LR

    namespace Microsoft {
        class IServiceProvider { }
        class CultureInfo { }
    }

    namespace CqlToElm {
        class CqlToElmConverter { }
        class StreamInspector { }
        class FileSystemLibraryProvider { }
        class LibraryBuilder { }
        class LibraryInfo { }
        class CoercionProvider { }
        class ElmFactory { }
        class SystemLibrary { }
        class StreamInspector { }
        class InvocationBuilder { }
        class LocalIdentifierProvider { }
        class DiskStreamProvider { }
        class IModelProvider { }
        class MessageProvider { }
        class ILibraryProvider { }
        class MemoryLibraryProvider { }
        class BuiltinModelProvider { }
        class IStreamProvider { }
        class ISymbolScope { }
        class LibraryVisitor { }
        class DefinitionVisitor { }
    }

    namespace CqlModel {
        class ModelInfo { }
    }

    %% Style Singleton Types as Brown
    
    style CqlToElmConverter fill:#550
    style CoercionProvider fill:#550
    style ElmFactory fill:#550
    style SystemLibrary fill:#550
    style StreamInspector fill:#550
    style InvocationBuilder fill:#550
    style LocalIdentifierProvider fill:#550
    style IModelProvider fill:#550
    style MessageProvider fill:#550
    style IServiceProvider fill:#550
    style BuiltinModelProvider fill:#550

    %% Style Scoped Types as Cyan
    
    style LibraryBuilder fill:#055

    %% Style Transient Types as Purple

    style LocalIdentifierProvider fill: #505

    %% Style Non-Services Types as Gray

    style LibraryInfo fill: #555
    style ILibraryProvider fill: #555
    style FileSystemLibraryProvider fill: #555
    style MemoryLibraryProvider fill: #555
    style ModelInfo fill: #555
    style CultureInfo fill: #555
    style DiskStreamProvider fill: #555
    style IStreamProvider fill: #555
    style LibraryVisitor fill: #555
    style ISymbolScope fill: #555
    style DefinitionVisitor fill: #555

    %% Inheritance  

    DiskStreamProvider --> IStreamProvider : inherits
    MemoryLibraryProvider --> ILibraryProvider : inherits
    FileSystemLibraryProvider --> ILibraryProvider : inherits
    BuiltinModelProvider --> IModelProvider : inherits
    SystemLibrary --> ISymbolScope : inherits
    
    %% Dependencies

    CultureInfo ..> MessageProvider : injected

    CoercionProvider ..> ElmFactory : injected
    MessageProvider ..> ElmFactory : injected

    ModelInfo ..> BuiltinModelProvider : injected as params[]

    IModelProvider ..> CoercionProvider : injected

    IModelProvider ..> InvocationBuilder : injected
    CoercionProvider ..> InvocationBuilder : injected
    ElmFactory ..> InvocationBuilder : injected
    MessageProvider ..> InvocationBuilder : injected

    LibraryBuilder ..> LibraryInfo : assigned to Library property\nby FileSystemLibraryProvider

    StreamInspector ..> FileSystemLibraryProvider : injected
    LibraryBuilder ..> FileSystemLibraryProvider : created scoped\nin TryResolveLibrary()
    CqlToElmConverter ..> FileSystemLibraryProvider : injected
    IServiceProvider ..> FileSystemLibraryProvider : injected

    LibraryBuilder ..> DefinitionVisitor : injected
    IServiceProvider ..> DefinitionVisitor : injected    
    InvocationBuilder ..> DefinitionVisitor : created in ctor  

    LibraryBuilder ..> CqlToElmConverter : created scoped\nin ConvertLibrary()
    IServiceProvider ..> CqlToElmConverter : injected  
    
    SystemLibrary ..> LibraryVisitor : created in SystemLibrary
    IModelProvider ..> LibraryVisitor : created in ModelProvider
    LocalIdentifierProvider ..> LibraryVisitor : created in VisitLibrary()
    DefinitionVisitor ..> LibraryVisitor : created in VisitLibrary()
    LibraryBuilder ..> LibraryVisitor : created in VisitLibrary()
    IServiceProvider ..> LibraryVisitor : injected    

```

### CQL to ELM Code Smells
* `IServiceProvider` must not be used directly in the code
* Scoped services leak out of the scope into data objects e.g. `LibraryBuilder` into `LibraryInfo`
* Services leak out their dependencies by making them public properties e.g.
  * `LibraryBuilder` exposes `FileSystemLibraryProvider`
  * `LibraryInfo` exposes `LibraryBuilder library`
  * `CqlToElmConverter` exposes `IServiceProvider Services`, `ILogger<CqlToElmConverter> Logger`
  * `LibraryVisitor` exposes `IServiceProvider Services`, `SystemLibrary SystemLibrary`
* `CqlToElmConverter` is also a factory for `LibraryBuilder`, see `GetBuilder` method
* `SystemLibrary` is a singleton service but it is not used as a service


 <a name="h2-cql-packager"></a>

## CQL Packager SDK (with dependencies: Code Generation and Compiler)

** Legend **
* Exclude dependencies to  `ILogger<T>` and `IOptions<T>`
* <span style="background:#055">Cyan</span> classes indicate scoped services
* <span style="background:#550">Brown</span> classes indicate singleton services
* Classes are group by their respective projects

```mermaid

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
        class CSharpCodeStreamPostProcessor { }
        class WriteToFileCSharpCodeStreamPostProcessor { }
        class StubCSharpCodeStreamPostProcessor { }
        class AssemblyDataPostProcessor { }
        class WriteToFileAssemblyDataPostProcessor { }
        class StubAssemblyDataPostProcessor { }
        class TypeToCSharpConverter { }
        class CSharpLibrarySetToStreamsWriter { }
        class AssemblyCompiler { }
    }

    namespace Packaging {
        class FhirResourcePostProcessor { }
        class WriteToFileFhirResourcePostProcessor { }
        class StubFhirResourcePostProcessor { }
        class CqlToResourcePackagingPipeline { }
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

    %% Style Singleton Types as Brown
    
    style FhirTypeResolver fill:#550
    style BaseTypeResolver fill:#550
    style ModelInspector fill:#550
    style TypeConverter fill:#550
    style WriteToFileAssemblyDataPostProcessor fill:#550
    style StubAssemblyDataPostProcessor fill:#550
    style WriteToFileCSharpCodeStreamPostProcessor fill:#550
    style StubCSharpCodeStreamPostProcessor fill:#550
    style TypeToCSharpConverter fill:#550
    style TypeResolver fill:#550
    style AssemblyDataPostProcessor fill:#550
    style CSharpCodeStreamPostProcessor fill:#550
    style CSharpLibrarySetToStreamsWriter fill:#550
    style AssemblyCompiler fill:#550
    style WriteToFileFhirResourcePostProcessor fill:#550
    style StubFhirResourcePostProcessor fill:#550
    style CqlOperatorsBinder fill:#550
    style CqlContextBinder fill:#550
    style ExpressionBuilderSettings fill:#550
    style FhirResourcePostProcessor fill:#550
    style ResourcePackager fill:#550

    %% Style Scoped Types as Cyan

    style LibrarySetExpressionBuilder fill:#055
    style LibraryExpressionBuilder fill:#055
    style ExpressionBuilder fill:#055
    style TupleBuilderCache fill:#055
    style CqlToResourcePackagingPipeline fill:#055

    %% Inheritance  

    BaseTypeResolver --> TypeResolver : inherits
    FhirTypeResolver --> BaseTypeResolver : inherits
    WriteToFileCSharpCodeStreamPostProcessor --> CSharpCodeStreamPostProcessor : inherits
    StubCSharpCodeStreamPostProcessor --> CSharpCodeStreamPostProcessor : inherits
    WriteToFileAssemblyDataPostProcessor --> AssemblyDataPostProcessor : inherits
    StubAssemblyDataPostProcessor --> AssemblyDataPostProcessor : inherits
    WriteToFileFhirResourcePostProcessor --> FhirResourcePostProcessor : inherits
    StubFhirResourcePostProcessor --> FhirResourcePostProcessor : inherits

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

    TypeToCSharpConverter ..> CSharpLibrarySetToStreamsWriter : injected

    AssemblyDataPostProcessor ..> AssemblyCompiler : injected\n(optional)
    CSharpCodeStreamPostProcessor ..> AssemblyCompiler : injected\n(optional)
    CSharpLibrarySetToStreamsWriter ..> AssemblyCompiler : injected
    TypeResolver ..> AssemblyCompiler : injected

    TypeResolver ..> CSharpLibrarySetToStreamsWriter : injected

    AssemblyCompiler ..> CqlToResourcePackagingPipeline : injected
    ResourcePackager ..> CqlToResourcePackagingPipeline : injected 
    LibrarySetExpressionBuilder ..> CqlToResourcePackagingPipeline : injected

    TypeResolver ..> ResourcePackager : injected
    FhirResourcePostProcessor ..> ResourcePackager : injected\n(optional) 
```
