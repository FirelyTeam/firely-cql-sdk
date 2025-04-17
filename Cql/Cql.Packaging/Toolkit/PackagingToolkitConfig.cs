using System.Collections.ObjectModel;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Packaging.Toolkit;

/// <summary>
/// Configuration settings for the <see cref="PackagingToolkit"/>.
/// </summary>
public record PackagingToolkitConfig(
    string CanonicalRootUrl = "",
    SysDateTime? OverrideDate = null,
    IReadOnlyDictionary<CqlLibraryIdentifier, string>? FixedLibraryCanonicals = null)
{
    public IReadOnlyDictionary<CqlLibraryIdentifier, string> FixedLibraryCanonicals { get; init; }
        = FixedLibraryCanonicals ?? ReadOnlyDictionary<CqlLibraryIdentifier, string>.Empty;

    /// <summary>
    /// The default configuration for the CQL toolkit.
    /// </summary>
    public static PackagingToolkitConfig Default { get; } = new();
}