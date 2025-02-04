using CqlSdkPrototype.Cql.Fluent;
using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Elm.Fluent.Extensions;

namespace CqlSdkPrototype.Invocation.Fluent.Extensions;

public static class FluentCqlToolkitExtensions
{

#pragma warning disable RS0026 // Do not add multiple public overloads with optional parameters
    public static LibrarySetInvoker ToLibrarySetInvoker(
#pragma warning restore RS0026
        this FluentCqlToolkit cqlToolkit,
        Func<ElmToAssemblyCompilerConfig, ElmToAssemblyCompilerConfig>? configureElmToAssemblySettings = null,/*
        Func<LibrarySetInvokerBuilderConfig, LibrarySetInvokerBuilderConfig>? configureLibrarySetInvokerBuilderSettings = null,*/
        string name = "")
    {
        return cqlToolkit
               .TranslateCqlToElm()
               .ToFluentElmToolkit(configureElmToAssemblySettings)
               .ToLibrarySetInvoker(name/*, configureLibrarySetInvokerBuilderSettings*/);
    }
}