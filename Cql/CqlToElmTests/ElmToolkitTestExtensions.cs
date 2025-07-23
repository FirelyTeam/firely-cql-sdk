/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Invocation.Toolkit;

namespace Hl7.Cql.CqlToElm.Test;

using Expression = Hl7.Cql.Elm.Expression;

internal static class ElmToolkitTestExtensions
{
    public static LibrarySetCSharpCodeGenerator GetLibrarySetCSharpCodeGenerator(this ElmToolkit elmToolkit) =>
        elmToolkit.ServiceProvider.GetRequiredService<LibrarySetCSharpCodeGenerator>();

    public static AssemblyCompiler GetAssemblyCompiler(this ElmToolkit elmToolkit) =>
        elmToolkit.ServiceProvider.GetRequiredService<AssemblyCompiler>();

    public static Scope CreateScope(this ElmToolkit elmToolkit) =>
        new (elmToolkit.ServiceProvider.CreateScope());

    public static LibraryExpressionBuilder GetLibraryExpressionBuilder(this Scope elmFluentFluentToolkitScope) =>
        elmFluentFluentToolkitScope.ServiceProvider.GetRequiredService<LibraryExpressionBuilder>();

    internal class Scope(IServiceScope serviceScope) : IServiceScope
    {
        public void Dispose() => serviceScope.Dispose();
        public IServiceProvider ServiceProvider => serviceScope.ServiceProvider;
    }

    private static Library Library { get; } = new(identifier: new VersionedIdentifier { id = "Lambdas", version = "1.0.0" });

    internal static void UseLibrarySetInvoker(
        this ElmToolkit elmToolkit,
        Library library,
        Action<LibrarySetInvoker> useLibrarySetInvoker,
        string name = "") =>
        elmToolkit
            .AddElmLibraries(library)
            .UseLibrarySetInvoker(useLibrarySetInvoker, name);

    internal static CqlDefinitionDictionary ProcessLibrary(
        this ElmToolkit elmToolkit,
        Library library)
    {
        using var scope = elmToolkit.CreateScope();
        var libraryExpressionBuilder = scope.GetLibraryExpressionBuilder();
        return libraryExpressionBuilder.ProcessLibrary(library);
    }

    internal static LambdaExpression Lambda(
        this ElmToolkit elmToolkit,
        Expression expression)
    {
        using var scope = elmToolkit.CreateScope();
        var libraryExpressionBuilder = scope.GetLibraryExpressionBuilder();

        CqlDefinitionDictionary definitions = new();
        var ctx = libraryExpressionBuilder.NewExpressionBuilderContext(Library, definitions);
        System.Linq.Expressions.Expression translated = ctx.TranslateArg(expression);
        var contextParameter = CqlExpressions.ParameterExpression;
        LambdaExpression lambda = System.Linq.Expressions.Expression.Lambda(translated, contextParameter);
        return lambda;
    }
}
