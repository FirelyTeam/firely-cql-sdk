using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Internal;
using Hl7.Cql.CqlToElm.Builtin;

namespace Hl7.Cql.CqlToElm.Test;

internal static class CqlServiceProviderAccessorForTesting
{
    private static TService GetCqlRequiredService<TService>(this IServiceProviderAccessorForTesting<CqlToolkit> spAccessor) where TService : notnull =>
        spAccessor.ServiceProvider.GetRequiredService<TService>();

    public static CqlToElmConverter GetCqlToElmConverter(this IServiceProviderAccessorForTesting<CqlToolkit> spAccessor) =>
        spAccessor.GetCqlRequiredService<CqlToElmConverter>();

    public static CoercionProvider GetCoercionProvider(this IServiceProviderAccessorForTesting<CqlToolkit> spAccessor) =>
        spAccessor.GetCqlRequiredService<CoercionProvider>();

    public static ElmFactory GetElmFactory(this IServiceProviderAccessorForTesting<CqlToolkit> spAccessor) =>
        spAccessor.GetCqlRequiredService<ElmFactory>();

    public static MessageProvider GetMessageProvider(this IServiceProviderAccessorForTesting<CqlToolkit> spAccessor) =>
        spAccessor.GetCqlRequiredService<MessageProvider>();

    public static InvocationBuilder GetInvocationBuilder(this IServiceProviderAccessorForTesting<CqlToolkit> spAccessor) =>
        spAccessor.GetCqlRequiredService<InvocationBuilder>();

    public static SystemLibrary GetSystemLibrary(this IServiceProviderAccessorForTesting<CqlToolkit> spAccessor) =>
        spAccessor.GetCqlRequiredService<SystemLibrary>();
}