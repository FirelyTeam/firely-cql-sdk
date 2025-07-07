using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Elm;
using Expression = Hl7.Cql.Elm.Expression;

namespace Hl7.Cql.CqlToElm.Test;

internal static class CqlToolkitTestExtensions
{
    private static TService GetCqlRequiredService<TService>(this CqlToolkit cqlToolkit) where TService : notnull =>
        cqlToolkit.ServiceProvider.GetRequiredService<TService>();

    public static CqlToElmConverter GetCqlToElmConverter(this CqlToolkit cqlToolkit) =>
        cqlToolkit.GetCqlRequiredService<CqlToElmConverter>();

    public static CoercionProvider GetCoercionProvider(this CqlToolkit cqlToolkit) =>
        cqlToolkit.GetCqlRequiredService<CoercionProvider>();

    public static ElmFactory GetElmFactory(this CqlToolkit cqlToolkit) =>
        cqlToolkit.GetCqlRequiredService<ElmFactory>();

    public static MessageProvider GetMessageProvider(this CqlToolkit cqlToolkit) =>
        cqlToolkit.GetCqlRequiredService<MessageProvider>();

    public static InvocationBuilder GetInvocationBuilder(this CqlToolkit cqlToolkit) =>
        cqlToolkit.GetCqlRequiredService<InvocationBuilder>();

    public static SystemLibrary GetSystemLibrary(this CqlToolkit cqlToolkit) =>
        cqlToolkit.GetCqlRequiredService<SystemLibrary>();

    private static CqlLibraryString FHIRHelpers { get; } = CqlLibraryString.Parse(File.ReadAllText(@"Input\FHIRHelpers-4.0.1.cql"));

    public static CqlToolkit AddFHIRHelpers(this CqlToolkit cqlToolkit) => cqlToolkit.AddCqlLibraries(FHIRHelpers);

    public static Library MakeLibrary(
        this CqlToolkit cqlToolkit,
        string cql,
        params string[] expectedErrors)
    {
        var cqlLibraryString = CqlLibraryString.Parse(cql);

        var library = cqlToolkit
                      .AddCqlLibraries(cqlLibraryString)
                      .TranslateToElm()
                      .ArtifactsById[cqlLibraryString]
                      .ResultElmLibrary!;

        if (expectedErrors.Any())
            library.ShouldReportError(expectedErrors);
        else
            library.ShouldSucceed();

        return library;
    }

    public static Library MakeLibraryFromExpression(
        this CqlToolkit cqlToolkit,
        string expression,
        string[]? expectedErrors = null,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "")
    {
        string libName = string.Concat($"{memberName}{Random.Shared.Next()}{Environment.TickCount64}"
                                       .ToCharArray()
                                       .Where(Char.IsAsciiLetterOrDigit));

        string cql = $"""
                      library "{libName}" version '1.0.0'

                      define private "{memberName}": {expression}
                      """;
        var lib = cqlToolkit.MakeLibrary(cql, expectedErrors ?? []);
        return lib;
    }

    public static Expression Expression(
        this CqlToolkit cqlToolkit,
        string expression,
        [System.Runtime.CompilerServices.CallerMemberName]
        string memberName = "")
    {
        return cqlToolkit.MakeLibraryFromExpression(expression, memberName: memberName).statements[0].expression;
    }
}