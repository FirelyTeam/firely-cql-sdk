using Hl7.Cql.Compiler;

namespace CqlSdkPrototype.Elm;

internal class ElmApiScopedState(IServiceScope scope) : IDisposable
{
    public LibrarySetExpressionBuilder LibrarySetExpressionBuilder { get; } = scope.ServiceProvider.GetLibrarySetExpressionBuilderScoped();

    public void Dispose() => scope.Dispose();
}