using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Internal;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;

namespace Hl7.Cql.CqlToElm.Test;

internal static class ElmServiceProviderAccessorForTesting
{
    public static LibrarySetCSharpCodeGenerator GetLibrarySetCSharpCodeGenerator(this IServiceProviderAccessor<ElmToolkit> elmFluentToolkit) =>
        elmFluentToolkit.ServiceProvider.GetRequiredService<LibrarySetCSharpCodeGenerator>();

    public static AssemblyCompiler GetAssemblyCompiler(this IServiceProviderAccessor<ElmToolkit> elmFluentToolkit) =>
        elmFluentToolkit.ServiceProvider.GetRequiredService<AssemblyCompiler>();

    public static Scope CreateScope(this IServiceProviderAccessor<ElmToolkit> elmFluentToolkit) =>
        new (elmFluentToolkit.ServiceProvider.CreateScope());

    public static LibraryExpressionBuilder GetLibraryExpressionBuilder(this Scope elmFluentFluentToolkitScope) =>
        elmFluentFluentToolkitScope.ServiceProvider.GetRequiredService<LibraryExpressionBuilder>();

    internal class Scope(IServiceScope serviceScope) : IServiceScope
    {
        public void Dispose() => serviceScope.Dispose();
        public IServiceProvider ServiceProvider => serviceScope.ServiceProvider;
    }
}