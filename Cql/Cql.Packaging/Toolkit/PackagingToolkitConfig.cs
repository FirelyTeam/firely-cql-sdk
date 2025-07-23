/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections.ObjectModel;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Packaging.Toolkit;

/// <summary>
/// Configuration settings for the <see cref="PackagingToolkit"/>.
/// </summary>
/// <param name="CanonicalRootUrl">The canonical root URL for the FHIR resources.</param>
/// <param name="OverrideDate">The date to override in the FHIR resources. If not specified, the current time will be used.</param>
/// <param name="FixedLibraryCanonicals">Mapping for special libraries with fixed canonicals, that are not rooted in the <see cref="CanonicalRootUrl"/>.</param>
public record PackagingToolkitConfig(
    string CanonicalRootUrl = "",
    SysDateTime? OverrideDate = null,
    IReadOnlyDictionary<CqlLibraryIdentifier, string>? FixedLibraryCanonicals = null)
{
    /// <summary>
    /// Mapping for special libraries with fixed canonicals, that are not rooted in the <see cref="CanonicalRootUrl"/>.
    /// </summary>
    public IReadOnlyDictionary<CqlLibraryIdentifier, string> FixedLibraryCanonicals { get; init; }
        = FixedLibraryCanonicals ?? CreateDefaultFixedLibraryCanonicals();

    private static ReadOnlyDictionary<CqlLibraryIdentifier, string> CreateDefaultFixedLibraryCanonicals() =>
        new Dictionary<CqlLibraryIdentifier, string> { { (CqlLibraryIdentifier)"FHIRHelpers", "https://fhir.org/guides/cqf/common/Library/FHIRHelpers" } }
            .AsReadOnly();

    /// <summary>
    /// The default configuration for the CQL toolkit.
    /// </summary>
    public static PackagingToolkitConfig Default { get; } = new();
}
