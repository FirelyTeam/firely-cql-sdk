using Microsoft.Extensions.DependencyInjection;

namespace Hl7.Cql.Abstractions;

/// <summary>
/// Represents a library service.
/// </summary>
public interface ILibraryService
{
    /// <summary>
    /// Adds the library service to the specified service collection.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The modified service collection.</returns>
    public static abstract void AddLibraryService(IServiceCollection services);
}
