/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;
using Hl7.Fhir.Utility;

namespace Hl7.Cql.Packaging;

internal delegate string ResourceCanonicalBuilder(
    string resourceType,
    string identifier,
    string? version = null);

internal static class ResourceCanonicalBuilderFactory
{
    public static ResourceCanonicalBuilder CreateWithRootUrl(
        string rootUrl,
        IReadOnlyDictionary<CqlLibraryIdentifier, string>? fixedLibraryCanonicals = null)
    {
        rootUrl = rootUrl.EnsureEndsWith("/");
        return (
            string resourceType,
            string identifier,
            string? version = null) =>
        {
            if (fixedLibraryCanonicals is { Count: > 0 }
                && CqlLibraryIdentifier.TryParse(identifier, out var cqlLibraryIdentifier)
                && fixedLibraryCanonicals.TryGetValue(cqlLibraryIdentifier, out var canonical))
            {
                return canonical;
            }

            string includeVersionString = string.IsNullOrEmpty(version) ? string.Empty : $"|{version}";
            string includeIdMaybeVersion = $"{rootUrl}{resourceType}/{identifier}{includeVersionString}";
            return includeIdMaybeVersion;
        };
    }
}