using Hl7.Cql.Compiler;

namespace CqlSdkPrototype.Elm.Internal;

internal class ElmToolkitScopedState(IServiceScope scope) : IDisposable
{
    public LibrarySetExpressionBuilder LibrarySetExpressionBuilder { get; } = scope.ServiceProvider.GetRequiredService<LibrarySetExpressionBuilder>();

    public void Dispose() => scope.Dispose();
}