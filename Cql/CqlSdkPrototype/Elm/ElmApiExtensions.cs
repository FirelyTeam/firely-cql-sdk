using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Elm.Extensibility;
using CqlSdkPrototype.Runtime;
using Hl7.Cql.Runtime.Hosting;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.Elm;

public static partial class ElmApiExtensions
{
    internal static ILogger<TElmApi> GetLogger<TElmApi>(
        this TElmApi self)
        where TElmApi : IElmApi<TElmApi>
    {
        return self.Options.ServiceProvider.GetLogger<TElmApi>()!;
    }

    public static ElmApi Compile(
        this CqlApi cqlApi)
    {
        return cqlApi
            .Translate()
            .CreateElmApi()
            .Compile();
    }
}