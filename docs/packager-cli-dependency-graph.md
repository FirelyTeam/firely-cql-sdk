# PackagerCLI

## Service Dependencies (excl Logger and Options)

```mermaid
classDiagram
    direction LR

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
        class Expression{
        }

        class Library{
        }

        class LibrarySet{
        }

        class LibraryDefinitionBuilderSettings {
        }

        class IExpressionBuilderFactory {
        }

        class ExpressionBuilder{
        }

        class ILibraryExpressionBuilderFactory {
        }

        class LibraryExpressionBuilder{
        }

        class ILibrarySetExpressionBuilderFactory {
        }

        class LibrarySetExpressionBuilder{
        }

        class LibraryDefinitionsBuilder {
%%            ProcessLibrarySet(librarySet : LibrarySet) DefinitionDictionary<LambdaExpression>
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

    CqlCompilerFactory --> ILibrarySetExpressionBuilderFactory : inherits
    CqlCompilerFactory --> ILibraryExpressionBuilderFactory : inherits
    CqlCompilerFactory --> IExpressionBuilderFactory : inherits
   
    CqlOperatorsBinder --> OperatorsBinder : inherits
    CqlContextBinder --> ContextBinder : inherits
    WriteToFileCSharpCodeStreamPostProcessor --> CSharpCodeStreamPostProcessor : inherits
    WriteToFileFhirResourcePostProcessor --> FhirResourcePostProcessor : inherits

    %% Injected Dependencies

    CSharpCodeStreamPostProcessor ..> AssemblyCompiler : injected\n(optional)
    CSharpLibrarySetToStreamsWriter ..> AssemblyCompiler : injected
    TypeManager ..> AssemblyCompiler : injected
    
    Expression ..> ExpressionBuilder : processed by

    CqlCompilerFactory ..> LibraryDefinitionsBuilder : created by
    ILibrarySetExpressionBuilderFactory ..> LibraryDefinitionsBuilder : injected
    ILibraryExpressionBuilderFactory ..> LibraryDefinitionsBuilder : injected

    ILibrarySetExpressionBuilderFactory ..> LibrarySetExpressionBuilder : created by
    ILibraryExpressionBuilderFactory ..> LibrarySetExpressionBuilder : injected
    LibrarySet ..> LibrarySetExpressionBuilder : processed by

    ILibraryExpressionBuilderFactory ..> LibraryExpressionBuilder : created by
    IExpressionBuilderFactory ..> LibrarySetExpressionBuilder : injected
    LibraryDefinitionBuilderSettings ..> LibrarySetExpressionBuilder : injected
    Library ..> LibraryExpressionBuilder : processed by
    LibrarySetExpressionBuilder ..> LibrarySetExpressionBuilder : outer context of

    IExpressionBuilderFactory ..> ExpressionBuilder : created by
    OperatorsBinder ..> ExpressionBuilder : injected
    TypeManager ..> ExpressionBuilder : injected
    TypeConverter ..> ExpressionBuilder : injected
    TypeResolver ..> ExpressionBuilder : injected
    ContextBinder ..> ExpressionBuilder : injected
    LibraryDefinitionBuilderSettings ..> ExpressionBuilder : injected
    LibraryExpressionBuilder ..> ExpressionBuilder : outer context of

    AssemblyCompiler ..> CqlToResourcePackagingPipeline : injected
    LibraryDefinitionsBuilder ..> CqlToResourcePackagingPipeline : injected
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

