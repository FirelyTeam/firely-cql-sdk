/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Fhir.Utility;

namespace Hl7.Cql.Packaging;

internal class ResourceUriBuilder(string rootUrl) : IResourceCanonicalBuilder
{
    public string RootUrl { get; } = rootUrl.EnsureEndsWith("/");

    public string BuildCanonical(string resourceType, string identifier, string? version = null)
    {
        string includeVersionString = string.IsNullOrEmpty(version) ? string.Empty : $"|{version}";
        string includeIdMaybeVersion = $"{RootUrl}{resourceType}/{identifier}{includeVersionString}";
        return includeIdMaybeVersion;
    }
}