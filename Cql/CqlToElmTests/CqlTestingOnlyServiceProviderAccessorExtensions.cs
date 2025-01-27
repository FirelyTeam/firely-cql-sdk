using CqlSdkPrototype.Internal;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Builtin;

namespace CqlSdkPrototype.Cql.Internal;

internal static class CqlTestingOnlyServiceProviderAccessorExtensions
{
    private static TService GetCqlRequiredService<TService>(this ITestingOnlyServiceProviderAccessor<CqlApi> spAccessor) where TService : notnull =>
        spAccessor.ServiceProvider.GetRequiredService<TService>();

    public static CqlToElmConverter GetCqlToElmConverter(this ITestingOnlyServiceProviderAccessor<CqlApi> spAccessor) =>
        spAccessor.GetCqlRequiredService<CqlToElmConverter>();

    public static CoercionProvider GetCoercionProvider(this ITestingOnlyServiceProviderAccessor<CqlApi> spAccessor) =>
        spAccessor.GetCqlRequiredService<CoercionProvider>();

    public static ElmFactory GetElmFactory(this ITestingOnlyServiceProviderAccessor<CqlApi> spAccessor) =>
        spAccessor.GetCqlRequiredService<ElmFactory>();

    public static MessageProvider GetMessageProvider(this ITestingOnlyServiceProviderAccessor<CqlApi> spAccessor) =>
        spAccessor.GetCqlRequiredService<MessageProvider>();

    public static InvocationBuilder GetInvocationBuilder(this ITestingOnlyServiceProviderAccessor<CqlApi> spAccessor) =>
        spAccessor.GetCqlRequiredService<InvocationBuilder>();

    public static SystemLibrary GetSystemLibrary(this ITestingOnlyServiceProviderAccessor<CqlApi> spAccessor) =>
        spAccessor.GetCqlRequiredService<SystemLibrary>();
}