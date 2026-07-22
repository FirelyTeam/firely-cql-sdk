/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.CodeModel;
using Hl7.Cql.Elm;
using Hl7.Cql.Invocation.Toolkit;

namespace Hl7.Cql.CqlToElm.Test;

using Expression = Hl7.Cql.Elm.Expression;

/// <summary>
/// Test-only service-composition helpers over the ELM-to-C# pipeline.
/// </summary>
internal static class ElmToolkitTestExtensions
{
    public static LibrarySetCSharpCodeGenerator GetLibrarySetCSharpCodeGenerator(this ElmToolkit elmToolkit) =>
        elmToolkit.ServiceProvider.GetRequiredService<LibrarySetCSharpCodeGenerator>();

    public static AssemblyCompiler GetAssemblyCompiler(this ElmToolkit elmToolkit) =>
        elmToolkit.ServiceProvider.GetRequiredService<AssemblyCompiler>();

    public static Scope CreateScope(this ElmToolkit elmToolkit) =>
        new (elmToolkit.ServiceProvider.CreateScope());

    public static LibraryCodeBuilder GetLibraryCodeBuilder(this Scope elmFluentFluentToolkitScope) =>
        elmFluentFluentToolkitScope.ServiceProvider.GetRequiredService<LibraryCodeBuilder>();

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
        var libraryCodeBuilder = scope.GetLibraryCodeBuilder();
        return libraryCodeBuilder.ProcessLibrary(library);
    }

    /// <summary>
    /// Builds an <see cref="CodeLambda"/> wrapping the translated <paramref name="expression"/>.
    /// Unlike the old (deleted) Expression-based <c>Lambda()</c>, the IR lambda carries no
    /// leading <c>CqlContext</c> parameter (the well-known <see cref="CodeContextParameter"/> is
    /// referenced directly instead) -- so this has zero declared parameters, mirroring how
    /// <see cref="CodeBuilderContext"/> builds expression-definition lambdas (see
    /// <c>CodeBuilderContext.LibraryDefs.cs</c>).
    /// </summary>
    internal static CodeLambda Lambda(
        this ElmToolkit elmToolkit,
        Expression expression)
    {
        using var scope = elmToolkit.CreateScope();
        var libraryCodeBuilder = scope.GetLibraryCodeBuilder();

        CqlDefinitionDictionary definitions = new();
        var ctx = libraryCodeBuilder.NewCodeBuilderContext(Library, definitions);
        CodeExpression translated = ctx.TranslateArg(expression);
        return new CodeLambda([], translated);
    }
}
