using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Internal;
using Hl7.Cql.CqlToElm.Builtin;

namespace Hl7.Cql.CqlToElm.Test;

internal static class CqlTestingOnlyServiceProviderAccessorExtensions
{
    private static TService GetCqlRequiredService<TService>(this ITestingOnlyServiceProviderAccessor<CqlToolkit> spAccessor) where TService : notnull =>
        spAccessor.ServiceProvider.GetRequiredService<TService>();

    public static CqlToElmConverter GetCqlToElmConverter(this ITestingOnlyServiceProviderAccessor<CqlToolkit> spAccessor) =>
        spAccessor.GetCqlRequiredService<CqlToElmConverter>();

    public static CoercionProvider GetCoercionProvider(this ITestingOnlyServiceProviderAccessor<CqlToolkit> spAccessor) =>
        spAccessor.GetCqlRequiredService<CoercionProvider>();

    public static ElmFactory GetElmFactory(this ITestingOnlyServiceProviderAccessor<CqlToolkit> spAccessor) =>
        spAccessor.GetCqlRequiredService<ElmFactory>();

    public static MessageProvider GetMessageProvider(this ITestingOnlyServiceProviderAccessor<CqlToolkit> spAccessor) =>
        spAccessor.GetCqlRequiredService<MessageProvider>();

    public static InvocationBuilder GetInvocationBuilder(this ITestingOnlyServiceProviderAccessor<CqlToolkit> spAccessor) =>
        spAccessor.GetCqlRequiredService<InvocationBuilder>();

    public static SystemLibrary GetSystemLibrary(this ITestingOnlyServiceProviderAccessor<CqlToolkit> spAccessor) =>
        spAccessor.GetCqlRequiredService<SystemLibrary>();
}