using CqlSdkPrototype.Cql.Extensibility;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.Cql;
using Hl7.Cql.Runtime.Hosting;

public static partial class CqlApiExtensions
{
    internal static ILogger<TCqlApi> GetLogger<TCqlApi>(
        this TCqlApi self)
        where TCqlApi : ICqlApi<TCqlApi>
    {
        return self.Options.ServiceProvider.GetLogger<TCqlApi>()!;
    }


}