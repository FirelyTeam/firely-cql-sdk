using CqlSdkPrototype.Elm;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.CqlToElm.Test;

using Expression = Hl7.Cql.Elm.Expression;

internal static class ElmFluentToolkitExtensions
{
    public static LibrarySetCSharpCodeGenerator GetLibrarySetCSharpCodeGenerator(this ElmFluentToolkit elmFluentToolkit) =>
        elmFluentToolkit.ServiceProvider.GetRequiredService<LibrarySetCSharpCodeGenerator>();

    public static AssemblyCompiler GetAssemblyCompiler(this ElmFluentToolkit elmFluentToolkit) =>
        elmFluentToolkit.ServiceProvider.GetRequiredService<AssemblyCompiler>();

    public static Scope CreateScope(this ElmFluentToolkit elmFluentToolkit) =>
        new (elmFluentToolkit.ServiceProvider.CreateScope());

    public static LibraryExpressionBuilder GetLibraryExpressionBuilder(this Scope elmFluentFluentToolkitScope) =>
        elmFluentFluentToolkitScope.ServiceProvider.GetRequiredService<LibraryExpressionBuilder>();

    internal class Scope(IServiceScope serviceScope) : IServiceScope
    {
        public void Dispose() => serviceScope.Dispose();
        public IServiceProvider ServiceProvider => serviceScope.ServiceProvider;
    }

    private static Library Library { get; } = new(identifier: new VersionedIdentifier { id = "Lambdas", version = "1.0.0" });

    internal static DefinitionDictionary<LambdaExpression> ProcessLibrary(
        this ElmFluentToolkit elmToolkit,
        Library library)
    {
        using var scope = elmToolkit.CreateScope();
        var libraryExpressionBuilder = scope.GetLibraryExpressionBuilder();
        return libraryExpressionBuilder.ProcessLibrary(library);
    }

    internal static LambdaExpression Lambda(
        this ElmFluentToolkit elmToolkit,
        Expression expression)
    {
        using var scope = elmToolkit.CreateScope();
        var libraryExpressionBuilder = scope.GetLibraryExpressionBuilder();

        DefinitionDictionary<LambdaExpression> lambdas = new DefinitionDictionary<LambdaExpression>();
        var ctx = libraryExpressionBuilder.NewExpressionBuilderContext(Library, lambdas);
        System.Linq.Expressions.Expression translated = ctx.TranslateArg(expression);
        var contextParameter = CqlExpressions.ParameterExpression;
        LambdaExpression lambda = System.Linq.Expressions.Expression.Lambda(translated, contextParameter);
        return lambda;
    }


}