using CqlSdkPrototype.Cql.Fluent;
using CqlSdkPrototype.Invocation.Extensions;

namespace CqlSdkPrototype.Elm.Fluent.Extensions;

public static partial class FluentElmToolkitExtensions
{
    public static FluentElmToolkit ProcessCqlToAssemblies(
        this FluentCqlToolkit cqlToolkit) =>
        cqlToolkit
            .ProcessCqlToElm()
            .CreateElmApi()
            .ProcessElmToAssemblies();
}
