/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Fhir.Utility;

namespace Hl7.Cql.Packaging;

internal class ResourceCanonicalBuilder(string rootUrl = "") : IResourceCanonicalBuilder
{
    public static readonly ResourceCanonicalBuilder Default = new();

    private readonly string _rootUrl = rootUrl.EnsureEndsWith("/");

    public string BuildCanonical(string resourceType, string identifier, string? version = null)
    {
        string includeVersionString = string.IsNullOrEmpty(version) ? string.Empty : $"|{version}";
        string includeIdMaybeVersion = $"{_rootUrl}{resourceType}/{identifier}{includeVersionString}";
        return includeIdMaybeVersion;
    }
}