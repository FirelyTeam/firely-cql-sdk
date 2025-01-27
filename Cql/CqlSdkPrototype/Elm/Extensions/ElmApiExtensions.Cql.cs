using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Runtime.Extensions;

namespace CqlSdkPrototype.Elm.Extensions;

public static partial class ElmApiExtensions
{
    public static ElmApi Compile(
        this CqlToolkit cqlToolkit)
    {
        return cqlToolkit
               .Translate()
               .CreateElmApi()
               .Compile();
    }

}
