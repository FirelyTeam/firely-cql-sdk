using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Elm.Extensions;
using Hl7.Cql.CqlToElm.Toolkit;

namespace CqlSdkPrototype.Invocation.Extensions;

public static class CqlToolkitExtensions
{

#pragma warning disable RS0026 // Do not add multiple public overloads with optional parameters
    public static LibrarySetInvoker ToLibrarySetInvoker(
#pragma warning restore RS0026
        this CqlToolkit cqlToolkit,
        Func<ElmToolkitConfig, ElmToolkitConfig>? configureElmToAssemblySettings = null,/*
        Func<LibrarySetInvokerBuilderConfig, LibrarySetInvokerBuilderConfig>? configureLibrarySetInvokerBuilderSettings = null,*/
        string name = "")
    {
        return cqlToolkit
               .ConvertCqlToElm()
               .ToFluentElmToolkit(configureElmToAssemblySettings)
               .ToLibrarySetInvoker(name/*, configureLibrarySetInvokerBuilderSettings*/);
    }
}