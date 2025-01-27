using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Runtime.Extensions;

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
