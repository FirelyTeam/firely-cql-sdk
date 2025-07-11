using Hl7.Cql.CqlToElm.Visitors;

namespace Hl7.Cql.CqlToElm;

internal static class ScopedServicesExtensions
{
    internal static LibraryVisitor GetLibraryVisitorScoped(this IServiceScope scope) => scope.ServiceProvider.GetRequiredService<LibraryVisitor>();
}