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

internal static class ResourceCanonicalBuilderFactory
{
    public static ResourceCanonicalBuilder Create(
        string rootUrl,
        IReadOnlyDictionary<CqlLibraryIdentifier, string>? fixedLibraryCanonicals = null)
    {
        rootUrl = rootUrl.EnsureEndsWith("/");
        return (
            string resourceType,
            string identifier,
            string? version = null) =>
        {
            string includeVersionString = string.IsNullOrEmpty(version) ? string.Empty : $"|{version}";
            var resultCanonical = fixedLibraryCanonicals is { Count: > 0 }
                                  && CqlLibraryIdentifier.TryParse(identifier, out var cqlLibraryIdentifier)
                                  && fixedLibraryCanonicals.TryGetValue(cqlLibraryIdentifier.Value, out var canonical)
                                      ? $"{canonical}{includeVersionString}"
                                      : $"{rootUrl}{resourceType}/{identifier}{includeVersionString}";
            return resultCanonical;
        };
    }
}