using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Cql.Extensions;
using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using Expression = Hl7.Cql.Elm.Expression;

namespace Hl7.Cql.CqlToElm.Test;

internal static class CqlFluentToolkitExtensions
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

    private static CqlLibraryString FHIRHelpers { get; } = CqlLibraryString.Parse(File.ReadAllText(@"Input\FHIRHelpers-4.0.1.cql"));

    public static CqlFluentToolkit AddFHIRHelpers(this CqlFluentToolkit cqlFluentToolkit) => cqlFluentToolkit.AddCqlLibraryString(FHIRHelpers);

    public static Library MakeLibrary(
        this CqlFluentToolkit cqlFluentToolkit,
        string cql,
        params string[] expectedErrors)
    {
        var cqlLibraryString = CqlLibraryString.Parse(cql);

        var library = cqlFluentToolkit
                      .AddCqlLibraryString(cqlLibraryString)
                      .ProcessCqlToElm()
                      .CqlToElmConversions[cqlLibraryString.VersionedLibraryIdentifier]
                      .ElmLibrary!;

        if (expectedErrors.Any())
            library.ShouldReportError(expectedErrors);
        else
            library.ShouldSucceed();

        return library;
    }

    public static Library MakeLibraryFromExpression(
        this CqlFluentToolkit cqlFluentToolkit,
        string expression,
        string[]? expectedErrors = null,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "")
    {
        string cql = $"""
                      library Test version '1.0.0'

                      define private "{memberName}": {expression}
                      """;
        var lib = cqlFluentToolkit.MakeLibrary(cql, expectedErrors ?? []);
        return lib;
    }

    public static Expression Expression(
        this CqlFluentToolkit cqlFluentToolkit,
        string expression,
        [System.Runtime.CompilerServices.CallerMemberName]
        string memberName = "")
    {
        return cqlFluentToolkit.MakeLibraryFromExpression(expression, memberName: memberName).statements[0].expression;
    }
}