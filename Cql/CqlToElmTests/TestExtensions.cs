using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Cql.Extensions;
using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;
using FluentAssertions.Collections;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Expression = Hl7.Cql.Elm.Expression;
using M = Hl7.Cql.Model;

namespace Hl7.Cql.CqlToElm.Test;

internal static class TestExtensions
{
    private static CqlLibraryString FHIRHelpers { get; } = CqlLibraryString.Parse(File.ReadAllText(@"Input\FHIRHelpers-4.0.1.cql"));

    private static Library Library { get; } = new(identifier: new VersionedIdentifier { id = "Lambdas", version = "1.0.0" });

    public static ICqlFluentToolkit AddFHIRHelpers(this ICqlFluentToolkit cqlToolkit) => cqlToolkit.AddCqlLibraryString(FHIRHelpers);

    public static Library MakeLibrary(
        this ICqlFluentToolkit cqlToolkit,
        string cql,
        params string[] expectedErrors)
    {
        var cqlLibraryString = CqlLibraryString.Parse(cql);

        var library = cqlToolkit
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
        this ICqlFluentToolkit cqlToolkit,
        string expression,
        string[]? expectedErrors = null,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "")
    {
        string cql = $"""
                      library Test version '1.0.0'

                      define private "{memberName}": {expression}
                      """;
        var lib = cqlToolkit.MakeLibrary(cql, expectedErrors ?? []);
        return lib;
    }

    internal static IServiceProviderAccessor<ElmToolkit> ForTesting(this IElmFluentToolkit elmToolkit) =>
        elmToolkit.ElmToolkit;

    internal static DefinitionDictionary<LambdaExpression> ProcessLibrary(
        this IElmFluentToolkit elmToolkit,
        Library library)
    {
        using var scope = elmToolkit.ForTesting().CreateScope();
        var libraryExpressionBuilder = scope.GetLibraryExpressionBuilder();
        return libraryExpressionBuilder.ProcessLibrary(library);
    }

    internal static LambdaExpression Lambda(
        this IElmFluentToolkit elmToolkit,
        Expression expression)
    {
        using var scope = elmToolkit.ForTesting().CreateScope();
        var libraryExpressionBuilder = scope.GetLibraryExpressionBuilder();

        DefinitionDictionary<LambdaExpression> lambdas = new DefinitionDictionary<LambdaExpression>();
        var ctx = libraryExpressionBuilder.NewExpressionBuilderContext(Library, lambdas);
        System.Linq.Expressions.Expression translated = ctx.TranslateArg(expression);
        var contextParameter = CqlExpressions.ParameterExpression;
        LambdaExpression lambda = System.Linq.Expressions.Expression.Lambda(translated, contextParameter);
        return lambda;
    }

    internal static NamedTypeSpecifier ForFhir(string typeName) =>
        new() { name = M.QualifiedName.MakeQualifiedTypeName(M.Models.Fhir401, typeName) };

    public static A ContainSingleOfType<A>(this GenericCollectionAssertions<Expression> assertions) =>
        (A)(object)assertions.AllBeOfType<A>().And.ContainSingle().Subject!;

    public static Expression Expression(
        this ICqlFluentToolkit cqlToolkit,
        string expression,
        [System.Runtime.CompilerServices.CallerMemberName]
        string memberName = "")
    {
        return cqlToolkit.MakeLibraryFromExpression(expression, memberName: memberName).statements[0].expression;
    }
}