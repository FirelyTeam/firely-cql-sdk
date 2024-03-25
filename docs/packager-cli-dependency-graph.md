# PackagerCLI

## Service Dependencies (excl Logger and Options)

```mermaid
classDiagram
    direction BT

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

        class ExpressionBuilder{
        }

        class LibraryExpressionBuilder{
        }

        class LibrarySetExpressionBuilder{
        }

        class LibraryDefinitionsBuilder {
%%            ProcessLibrarySet(librarySet : LibrarySet) DefinitionDictionary<LambdaExpression>
        }

        class OperatorBinding {
        }

        class CqlOperatorsBinding {
        }

        class TypeConverter {
        }

        class ModelInspector {
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

   
    CqlOperatorsBinding --> OperatorBinding : inherits
    WriteToFileCSharpCodeStreamPostProcessor --> CSharpCodeStreamPostProcessor : inherits
    WriteToFileFhirResourcePostProcessor --> FhirResourcePostProcessor : inherits

    %% Injected Dependencies

    CSharpCodeStreamPostProcessor ..> AssemblyCompiler : injected\n(optional)
    CSharpLibrarySetToStreamsWriter ..> AssemblyCompiler : injected
    TypeManager ..> AssemblyCompiler : injected
    
    Expression ..> ExpressionBuilder : processed by

    ExpressionBuilder ..> LibraryExpressionBuilder : created by
    Library ..> LibraryExpressionBuilder : processed by

    LibraryExpressionBuilder ..> LibrarySetExpressionBuilder : created by
    LibrarySet ..> LibrarySetExpressionBuilder : processed by

    AssemblyCompiler ..> CqlToResourcePackagingPipeline : injected
    LibraryDefinitionsBuilder ..> CqlToResourcePackagingPipeline : injected
    ResourcePackager ..> CqlToResourcePackagingPipeline : injected 
    
    OptionsConsoleDumper ..> PackagerCliProgram : injected 
    CqlToResourcePackagingPipeline ..> PackagerCliProgram : injected
      
    TypeResolver ..> CqlOperatorsBinding : injected
    TypeConverter ..> CqlOperatorsBinding : injected

    ModelInspector ..> TypeConverter : injected  

    OperatorBinding ..> LibraryDefinitionsBuilder : injected
    TypeManager ..> LibraryDefinitionsBuilder : injected
    LibrarySetExpressionBuilder ..> LibraryDefinitionsBuilder : created by

    TypeResolver ..> TypeManager : injected

    TypeResolver ..> ResourcePackager : injected
    FhirResourcePostProcessor ..> ResourcePackager : injected\n(optional) 
    
    TypeResolver ..> CSharpLibrarySetToStreamsWriter : injected
```

