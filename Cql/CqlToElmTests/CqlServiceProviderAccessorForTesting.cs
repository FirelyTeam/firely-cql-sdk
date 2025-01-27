using CqlSdkPrototype.Cql;
using Hl7.Cql.CqlToElm.Builtin;

namespace Hl7.Cql.CqlToElm.Test;

internal static class CqlServiceProviderAccessorForTesting
{
    private static TService GetCqlRequiredService<TService>(this CqlFluentToolkit cqlFluentToolkit) where TService : notnull =>
        cqlFluentToolkit.ServiceProvider.GetRequiredService<TService>();

    public static CqlToElmConverter GetCqlToElmConverter(this CqlFluentToolkit cqlFluentToolkit) =>
        cqlFluentToolkit.GetCqlRequiredService<CqlToElmConverter>();

    public static CoercionProvider GetCoercionProvider(this CqlFluentToolkit cqlFluentToolkit) =>
        cqlFluentToolkit.GetCqlRequiredService<CoercionProvider>();

    public static ElmFactory GetElmFactory(this CqlFluentToolkit cqlFluentToolkit) =>
        cqlFluentToolkit.GetCqlRequiredService<ElmFactory>();

    public static MessageProvider GetMessageProvider(this CqlFluentToolkit cqlFluentToolkit) =>
        cqlFluentToolkit.GetCqlRequiredService<MessageProvider>();

    public static InvocationBuilder GetInvocationBuilder(this CqlFluentToolkit cqlFluentToolkit) =>
        cqlFluentToolkit.GetCqlRequiredService<InvocationBuilder>();

    public static SystemLibrary GetSystemLibrary(this CqlFluentToolkit cqlFluentToolkit) =>
        cqlFluentToolkit.GetCqlRequiredService<SystemLibrary>();
}