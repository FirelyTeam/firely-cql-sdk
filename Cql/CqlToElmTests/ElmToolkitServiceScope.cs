namespace Hl7.Cql.CqlToElm.Test;

internal class ElmToolkitServiceScope(IServiceScope serviceScope) : IServiceScope {
    public void Dispose() => serviceScope.Dispose();
    public IServiceProvider ServiceProvider => serviceScope.ServiceProvider;
}