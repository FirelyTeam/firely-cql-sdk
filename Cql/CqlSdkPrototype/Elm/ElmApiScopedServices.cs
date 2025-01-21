using Hl7.Cql.Compiler;

namespace CqlSdkPrototype.Elm;

internal class ElmApiScopedServices(IServiceScope scope) : IDisposable
{
    public LibrarySetExpressionBuilder LibrarySetExpressionBuilder { get; } = scope.ServiceProvider.GetRequiredService<LibrarySetExpressionBuilder>();

    public void Dispose() => scope.Dispose();
}