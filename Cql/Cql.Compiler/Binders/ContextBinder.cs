using System.Linq.Expressions;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Represents an abstract class for binding context information.
/// </summary>
internal abstract class ContextBinder
{
    /// <summary>
    /// Resolves the parameter with the specified library key and parameter name.
    /// </summary>
    /// <param name="libraryKey">The key of the library containing the parameter.</param>
    /// <param name="parameterName">The name of the parameter to resolve.</param>
    /// <param name="defaultValue">The default value to use if the parameter is not found.</param>
    /// <returns>The resolved parameter expression.</returns>
    public abstract Expression ResolveParameter(
        string libraryKey,
        string parameterName,
        Expression defaultValue);
}
