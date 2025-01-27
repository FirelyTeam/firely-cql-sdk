using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Runtime.Extensions;

namespace CqlSdkPrototype.Elm.Extensions;

public static partial class ElmToolkitExtensions
{
    public static IElmFluentToolkit ProcessCqlToAssemblies(
        this ICqlFluentToolkit cqlToolkit) =>
        cqlToolkit
            .ProcessCqlToElm()
            .CreateElmApi()
            .ProcessElmToAssemblies();
}
