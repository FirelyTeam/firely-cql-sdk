using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Invocation.Extensions;

namespace CqlSdkPrototype.Elm.Extensions;

public static partial class ElmFluentToolkitExtensions
{
    public static ElmFluentToolkit ProcessCqlToAssemblies(
        this CqlFluentToolkit cqlToolkit) =>
        cqlToolkit
            .ProcessCqlToElm()
            .CreateElmApi()
            .ProcessElmToAssemblies();
}
