# PackagerCLI Diagrams
The diagram is split into two, the first one showing the high-level dependencies for the application, and the second the detailed dependencies for expression building.

### Application Dependencies (excl Logger and Options)

```mermaid
classDiagram
    direction TB

    %% HACK: Mermaid doesnt support commas withing generic, so use a similar looking character (﹐)

    namespace CSharpCode_Generate_And_Compile {
        class AssemblyCompiler {
%%            Compile(librarySet : LibrarySet,definitions : DefinitionDictionary~LambdaExpression~? = null) IDictionary~string, AssemblyData~
        }

        class CSharpLibrarySetToStreamsWriter {
        }

        class CSharpCodeStreamPostProcessor {
            ProcessStream(name : string, stream : Stream) void
        }

        class WriteToFileCSharpCodeStreamPostProcessor {
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
        class TypeManager {
            get_TypeResolver() TypeResolver
            get_TupleTypes() IEnumerable~Type~
        }

    
        class TypeResolver {
        }
%%    }

    %% Inheritance  

    CqlOperatorsBinder --> OperatorsBinder : inherits
    CqlContextBinder --> ContextBinder : inherits
    WriteToFileCSharpCodeStreamPostProcessor --> CSharpCodeStreamPostProcessor : inherits
    WriteToFileFhirResourcePostProcessor --> FhirResourcePostProcessor : inherits

    %% Injected Dependencies

    CSharpCodeStreamPostProcessor ..> AssemblyCompiler : injected\n(optional)
    CSharpLibrarySetToStreamsWriter ..> AssemblyCompiler : injected
    TypeManager ..> AssemblyCompiler : injected
    
    AssemblyCompiler ..> CqlToResourcePackagingPipeline : injected
    ILibrarySetExpressionBuilder ..> CqlToResourcePackagingPipeline : injected
    ResourcePackager ..> CqlToResourcePackagingPipeline : injected 
    
    OptionsConsoleDumper ..> PackagerCliProgram : injected 
    CqlToResourcePackagingPipeline ..> PackagerCliProgram : injected
      
    TypeResolver ..> CqlOperatorsBinder : injected
    TypeConverter ..> CqlOperatorsBinder : injected

    ModelInspector ..> TypeConverter : injected  

    TypeResolver ..> TypeManager : injected

    TypeResolver ..> ResourcePackager : injected
    FhirResourcePostProcessor ..> ResourcePackager : injected\n(optional) 
    
    TypeResolver ..> CSharpLibrarySetToStreamsWriter : injected
```



### Expression Builder Dependencies (excl Logger and Options)

```mermaid
classDiagram
    direction TB

    %% HACK: Mermaid doesnt support commas withing generic, so use a similar looking character (﹐)

%%    namespace Expression_Building {
        class ILibrarySetExpressionBuilderContext{
        }

        class LibrarySetExpressionBuilder_Context {
        }

        class LibrarySetExpressionBuilder{
        }

        class ILibraryExpressionBuilderContext{
        }

        class LibraryExpressionBuilder_Context {
        }

        class LibraryExpressionBuilder{
        }
        
        class ExpressionBuilderSettings {
        }

        class IExpressionBuilderFactory {
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
        class TypeManager {
            get_TypeResolver() TypeResolver
            get_TupleTypes() IEnumerable~Type~
        }

    
        class TypeResolver {
        }
%%    }

    %% Inheritance  

    LibrarySetExpressionBuilder_Context --> ILibrarySetExpressionBuilderContext : implements
    LibraryExpressionBuilder_Context --> ILibraryExpressionBuilderContext : implements

    CqlContextBinder --> ContextBinder : inherits
    CqlOperatorsBinder --> OperatorsBinder : inherits

    %% Injected Dependencies

    LibraryExpressionBuilder ..> LibrarySetExpressionBuilder : injected

    LibrarySetExpressionBuilder ..> LibrarySetExpressionBuilder_Context : injected
    DefinitionDictionary~LambdaExpression~ ..> LibrarySetExpressionBuilder_Context : injected
    LibrarySet ..> LibrarySetExpressionBuilder_Context : injected

    IExpressionBuilderFactory ..> LibraryExpressionBuilder : injected

    LibraryExpressionBuilder ..> LibraryExpressionBuilder_Context : injected
    Library ..> LibraryExpressionBuilder_Context : injected
    DefinitionDictionary~LambdaExpression~ ..> LibraryExpressionBuilder_Context : injected
    ILibraryExpressionBuilderContext ..> LibraryExpressionBuilder_Context : injected (optional)

    ExpressionBuilder ..> IExpressionBuilderFactory : created by

    OperatorsBinder ..> ExpressionBuilder : injected
    TypeManager ..> ExpressionBuilder : injected
    TypeConverter ..> ExpressionBuilder : injected
    TypeResolver ..> ExpressionBuilder : injected
    ContextBinder ..> ExpressionBuilder : injected
    ExpressionBuilderSettings ..> ExpressionBuilder : injected
    ILibraryExpressionBuilderContext ..> ExpressionBuilder : injected
    
    LibrarySetExpressionBuilder ..> CqlToResourcePackagingPipeline : injected

    TypeResolver ..> CqlOperatorsBinder : injected
    TypeConverter ..> CqlOperatorsBinder : injected

    ModelInspector ..> TypeConverter : injected  

    TypeResolver ..> TypeManager : injected
```


