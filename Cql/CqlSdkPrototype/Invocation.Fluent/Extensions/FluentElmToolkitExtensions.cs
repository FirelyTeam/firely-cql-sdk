using CqlSdkPrototype.Cql.Fluent;
using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Elm.Fluent.Extensions;

namespace CqlSdkPrototype.Invocation.Fluent.Extensions;

public static partial class FluentElmToolkitExtensions
{

#pragma warning disable RS0026 // Do not add multiple public overloads with optional parameters
    public static LibrarySetInvoker CreateLibrarySetInvoker(
#pragma warning restore RS0026
        this FluentCqlToolkit cqlToolkit,
        Func<ElmToAssemblySettings, ElmToAssemblySettings>? configureElmToAssemblySettings = null,
        Func<LibrarySetInvokerBuilderSettings, LibrarySetInvokerBuilderSettings>? configureLibrarySetInvokerBuilderSettings = null,
        string name = "")
    {
        return cqlToolkit
               .ProcessCqlToElm()
               .ToFluentElmToolkit(configureElmToAssemblySettings)
               .CreateLibrarySetInvoker(name, configureLibrarySetInvokerBuilderSettings);
    }
}