# PackagerCLI Diagrams
The diagram is split into two, the first one showing the high-level dependencies for the application, and the second the detailed dependencies for expression building.

### Application Dependencies (excl Logger and Options)

Remarks
* Cyan dotted outline classes indicate scoped services.
* All others are singleton services.

```mermaid
classDiagram
    direction LR

    %% HACK: Mermaid doesnt support commas withing generic, so use a similar looking character (﹐)

    namespace CSharpCode_Generate_And_Compile {
        class AssemblyCompiler {
%%            Compile(librarySet : LibrarySet,definitions : DefinitionDictionary~LambdaExpression~? = null) IDictionary~string, AssemblyData~
        }

        class TypeToCSharpConverter {
        }

        class CSharpLibrarySetToStreamsWriter {
        }

        class CSharpCodeStreamPostProcessor {
            ProcessStream(name : string, stream : Stream) void
        }

        class WriteToFileCSharpCodeStreamPostProcessor {
        }

        class AssemblyDataPostProcessor {
            ProcessAssemblyData(name : string, assemblyData : AssemblyData) void
        }

        class WriteToFileAssemblyDataPostProcessor {
        }
    }

    namespace Expression_Building {
        class LibrarySetExpressionBuilder {
            ProcessLibrarySet(librarySet : LibrarySet) DefinitionDictionary<LambdaExpression>
        }

        class OperatorsBinder {
        }

        class CqlOperatorsBinder {
        }

        class ContextBinder{
        }

        class CqlContextBinder{
		}

        class TypeConverter {
        }

        class ModelInspector {
        }

        class CqlCompilerFactory {
        }
    }

    namespace Fhir_Resource_Building {
        class ResourcePackager {
%%            PackageResources(elmDirectory : DirectoryInfo, cqlDirectory : DirectoryInfo, resourceCanonicalRootUrl : string? = null) IReadOnlyCollection~Resource~
        }

        class FhirResourcePostProcessor {
%%            ProcessResource(resource : Resource) void
        }

        class WriteToFileFhirResourcePostProcessor {
        }
    }

    namespace Cql_To_Resource_Pipeline {
        class CqlToResourcePackagingPipeline {
        }        
    }

    namespace Application {
        class PackagerCliProgram {
        }

        class OptionsConsoleDumper {
        }
    }

%%    namespace Dependencies {
        class TupleBuilderCache {
            get_TupleTypes() IEnumerable~Type~
        }

    
        class TypeResolver {
        }
%%    }

    %% Style Scoped services
    style CqlToResourcePackagingPipeline stroke:#066,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style PackagerCliProgram stroke:#066,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style TupleBuilderCache stroke:#066,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style LibrarySetExpressionBuilder stroke:#066,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style LibraryExpressionBuilder stroke:#066,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style ExpressionBuilder stroke:#066,stroke-width:2px,color:#fff,stroke-dasharray: 5 5

    %% Inheritance  

    CqlOperatorsBinder --> OperatorsBinder : inherits
    CqlContextBinder --> ContextBinder : inherits
    WriteToFileCSharpCodeStreamPostProcessor --> CSharpCodeStreamPostProcessor : inherits
    WriteToFileAssemblyDataPostProcessor --> AssemblyDataPostProcessor : inherits
    WriteToFileFhirResourcePostProcessor --> FhirResourcePostProcessor : inherits

    %% Injected Dependencies

    TypeToCSharpConverter ..> CSharpLibrarySetToStreamsWriter : injected

    AssemblyDataPostProcessor ..> AssemblyCompiler : injected\n(optional)
    CSharpCodeStreamPostProcessor ..> AssemblyCompiler : injected\n(optional)
    CSharpLibrarySetToStreamsWriter ..> AssemblyCompiler : injected
    TypeResolver ..> AssemblyCompiler : injected
    
    AssemblyCompiler ..> CqlToResourcePackagingPipeline : injected
    ILibrarySetExpressionBuilder ..> CqlToResourcePackagingPipeline : injected
    ResourcePackager ..> CqlToResourcePackagingPipeline : injected 
    
    OptionsConsoleDumper ..> PackagerCliProgram : injected 
    CqlToResourcePackagingPipeline ..> PackagerCliProgram : injected
      
    TypeResolver ..> CqlOperatorsBinder : injected
    TypeConverter ..> CqlOperatorsBinder : injected

    ModelInspector ..> TypeConverter : injected  

    TypeResolver ..> ResourcePackager : injected
    FhirResourcePostProcessor ..> ResourcePackager : injected\n(optional) 
    
    TypeResolver ..> CSharpLibrarySetToStreamsWriter : injected
```



### Expression Builder Dependencies (excl Logger and Options)

Remarks
* Cyan dotted outline classes indicate scoped services.
* All others are singleton services.

```mermaid
classDiagram
    direction LR

    %% HACK: Mermaid doesnt support commas withing generic, so use a similar looking character (﹐)

%%    namespace Expression_Building {
        class ILibrarySetExpressionBuilderContext{
        }

        class LibrarySetExpressionBuilderContext {
        }

        class LibrarySetExpressionBuilder{
        }

        class ILibraryExpressionBuilderContext{
        }

        class LibraryExpressionBuilderContext {
        }

        class LibraryExpressionBuilder{
        }
        
        class ExpressionBuilderSettings {
        }

        class ExpressionBuilder{
        }

        class OperatorsBinder {
        }

        class CqlOperatorsBinder {
        }

        class ContextBinder{
        }

        class CqlContextBinder{
		}

        class TypeConverter {
        }

        class ModelInspector {
        }

        class CqlCompilerFactory {
        }
%%    }

    namespace Cql_To_Resource_Pipeline {
        class CqlToResourcePackagingPipeline {
        }        
    }

%%    namespace Dependencies {
        class TupleBuilderCache {
            get_TypeResolver() TypeResolver
        }

    
        class TypeResolver {
        }
%%    }

    %% Style Scoped services
    style CqlToResourcePackagingPipeline stroke:#066,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style PackagerCliProgram stroke:#066,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style TupleBuilderCache stroke:#066,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style LibrarySetExpressionBuilder stroke:#066,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style LibraryExpressionBuilder stroke:#066,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style ExpressionBuilder stroke:#066,stroke-width:2px,color:#fff,stroke-dasharray: 5 5

    %% Inheritance  

    LibrarySetExpressionBuilderContext --> ILibrarySetExpressionBuilderContext : implements
    LibraryExpressionBuilderContext --> ILibraryExpressionBuilderContext : implements

    CqlContextBinder --> ContextBinder : inherits
    CqlOperatorsBinder --> OperatorsBinder : inherits

    %% Injected Dependencies

    LibraryExpressionBuilder ..> LibrarySetExpressionBuilder : injected

    LibrarySetExpressionBuilder ..> LibrarySetExpressionBuilderContext : injected
    DefinitionDictionary~LambdaExpression~ ..> LibrarySetExpressionBuilderContext : injected
    LibrarySet ..> LibrarySetExpressionBuilderContext : injected

    ExpressionBuilder ..> LibraryExpressionBuilder : injected

    LibraryExpressionBuilder ..> LibraryExpressionBuilderContext : injected
    Library ..> LibraryExpressionBuilderContext : injected
    DefinitionDictionary~LambdaExpression~ ..> LibraryExpressionBuilderContext : injected
    ILibraryExpressionBuilderContext ..> LibraryExpressionBuilderContext : injected (optional)

    OperatorsBinder ..> ExpressionBuilder : injected
    TupleBuilderCache ..> ExpressionBuilder : injected
    TypeConverter ..> ExpressionBuilder : injected
    TypeResolver ..> ExpressionBuilder : injected
    ContextBinder ..> ExpressionBuilder : injected
    ExpressionBuilderSettings ..> ExpressionBuilder : injected
    ILibraryExpressionBuilderContext ..> ExpressionBuilder : injected
    
    LibrarySetExpressionBuilder ..> CqlToResourcePackagingPipeline : injected

    TypeResolver ..> CqlOperatorsBinder : injected
    TypeConverter ..> CqlOperatorsBinder : injected

    ModelInspector ..> TypeConverter : injected  
```

