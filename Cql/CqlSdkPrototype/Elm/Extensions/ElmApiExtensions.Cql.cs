using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Runtime.Extensions;

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
