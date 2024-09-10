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

    namespace Abstractions {
        class TypeResolver {
        }
    }

    class BaseTypeResolver {
    }

    class FhirTypeResolver {
    }

    namespace Expression_Building {
        class LibrarySetExpressionBuilder {
        }
    }

    %% Style Scoped services
    style CqlToResourcePackagingPipeline stroke:#066,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style PackagerCliProgram stroke:#066,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    style LibrarySetExpressionBuilder stroke:#066,stroke-width:2px,color:#fff,stroke-dasharray: 5 5

    %% Inheritance  

    BaseTypeResolver --> TypeResolver : inherits
    FhirTypeResolver --> BaseTypeResolver : inherits
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
    ResourcePackager ..> CqlToResourcePackagingPipeline : injected 
    LibrarySetExpressionBuilder ..> CqlToResourcePackagingPipeline : injected
    
    OptionsConsoleDumper ..> PackagerCliProgram : injected 
    CqlToResourcePackagingPipeline ..> PackagerCliProgram : injected
      
    TypeResolver ..> ResourcePackager : injected
    FhirResourcePostProcessor ..> ResourcePackager : injected\n(optional) 
    
    TypeResolver ..> CSharpLibrarySetToStreamsWriter : injected
```


### Expression Builder Dependencies (excl Logger and Options)

```mermaid
classDiagram
    direction LR

    %% HACK: Mermaid doesnt support commas withing generic, so use a similar looking character (﹐)

%%    namespace Expression_Building {
        class LibrarySetExpressionBuilder{
        }

        class LibraryExpressionBuilder{
        }
        
        class ExpressionBuilderSettings {
        }

        class ExpressionBuilder{
        }

        class CqlOperatorsBinder {
        }

        class CqlContextBinder{
		}

        class TypeConverter {
        }

        class ModelInspector {
        }

        class TupleBuilderCache {
        }
            
        class TypeResolver {
        }

        class BaseTypeResolver {
		}

        class FhirTypeResolver {
		}
%%    }

    %% Style Scoped services
    style PackagerCliProgram stroke:#066,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
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

