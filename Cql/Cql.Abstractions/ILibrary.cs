namespace Hl7.Cql.Abstractions;

/// <summary>
/// The base interface for generated CQL libraries.
/// </summary>
public interface ILibrary
{
    /// <summary>
    /// Gets the name of the library.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Gets the version of the library.
    /// </summary>
    string Version { get; }

    /// <summary>
    /// Gets the dependencies of the library.
    /// </summary>
    ILibrary[] Dependencies { get; }
}