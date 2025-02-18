using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Elm.Extensions;
using Hl7.Cql.Abstractions;

namespace CqlSdkPrototype.Invocation.Extensions;

public static class CqlToolkitExtensions
{
    public static LibrarySetInvoker CreateLibrarySetInvoker(
        this CqlToolkit cqlToolkit,
        Mutator<ElmToolkitConfig>? reconfigureElmToolkitConfig = null,
        string name = "") =>
        cqlToolkit
            .ConvertCqlToElm()
            .CreateElmToolkit(reconfigureElmToolkitConfig)
            .CreateLibrarySetInvoker(name);
}