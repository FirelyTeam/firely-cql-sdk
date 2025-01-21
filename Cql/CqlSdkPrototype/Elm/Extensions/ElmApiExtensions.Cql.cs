using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Invocation.Extensions;

namespace CqlSdkPrototype.Elm.Extensions;

public static partial class ElmApiExtensions
{
    public static ElmApi Compile(
        this CqlApi cqlApi)
    {
        return cqlApi
               .Translate()
               .CreateElmApi()
               .Compile();
    }

}
