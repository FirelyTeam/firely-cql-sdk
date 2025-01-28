using CqlSdkPrototype.Cql.Fluent;
using CqlSdkPrototype.Cql.Fluent.Extensions;
using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using Expression = Hl7.Cql.Elm.Expression;

namespace Hl7.Cql.CqlToElm.Test;

internal static class FluentCqlToolkitExtensions
{
    private static TService GetCqlRequiredService<TService>(this FluentCqlToolkit fluentCqlToolkit) where TService : notnull =>
        fluentCqlToolkit.ServiceProvider.GetRequiredService<TService>();

    public static CqlToElmConverter GetCqlToElmConverter(this FluentCqlToolkit fluentCqlToolkit) =>
        fluentCqlToolkit.GetCqlRequiredService<CqlToElmConverter>();

    public static CoercionProvider GetCoercionProvider(this FluentCqlToolkit fluentCqlToolkit) =>
        fluentCqlToolkit.GetCqlRequiredService<CoercionProvider>();

    public static ElmFactory GetElmFactory(this FluentCqlToolkit fluentCqlToolkit) =>
        fluentCqlToolkit.GetCqlRequiredService<ElmFactory>();

    public static MessageProvider GetMessageProvider(this FluentCqlToolkit fluentCqlToolkit) =>
        fluentCqlToolkit.GetCqlRequiredService<MessageProvider>();

    public static InvocationBuilder GetInvocationBuilder(this FluentCqlToolkit fluentCqlToolkit) =>
        fluentCqlToolkit.GetCqlRequiredService<InvocationBuilder>();

    public static SystemLibrary GetSystemLibrary(this FluentCqlToolkit fluentCqlToolkit) =>
        fluentCqlToolkit.GetCqlRequiredService<SystemLibrary>();

    private static CqlLibraryString FHIRHelpers { get; } = CqlLibraryString.Parse(File.ReadAllText(@"Input\FHIRHelpers-4.0.1.cql"));

    public static FluentCqlToolkit AddFHIRHelpers(this FluentCqlToolkit fluentCqlToolkit) => fluentCqlToolkit.AddCqlLibraryString(FHIRHelpers);

    public static Library MakeLibrary(
        this FluentCqlToolkit fluentCqlToolkit,
        string cql,
        params string[] expectedErrors)
    {
        var cqlLibraryString = CqlLibraryString.Parse(cql);

        var library = fluentCqlToolkit
                      .AddCqlLibraryString(cqlLibraryString)
                      .TranslateCqlToElm()
                      .CqlToElmConversions[cqlLibraryString.VersionedLibraryIdentifier]
                      .ElmLibrary!;

        if (expectedErrors.Any())
            library.ShouldReportError(expectedErrors);
        else
            library.ShouldSucceed();

        return library;
    }

    public static Library MakeLibraryFromExpression(
        this FluentCqlToolkit fluentCqlToolkit,
        string expression,
        string[]? expectedErrors = null,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "")
    {
        string cql = $"""
                      library Test version '1.0.0'

                      define private "{memberName}": {expression}
                      """;
        var lib = fluentCqlToolkit.MakeLibrary(cql, expectedErrors ?? []);
        return lib;
    }

    public static Expression Expression(
        this FluentCqlToolkit fluentCqlToolkit,
        string expression,
        [System.Runtime.CompilerServices.CallerMemberName]
        string memberName = "")
    {
        return fluentCqlToolkit.MakeLibraryFromExpression(expression, memberName: memberName).statements[0].expression;
    }
}