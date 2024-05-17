/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using Hl7.Fhir.Model;

namespace Hl7.Cql.Packaging;

#pragma warning disable CS1591
internal readonly record struct LibraryPackageCallbacks
{
    public LibraryPackageCallbacks(
        Action<Resource>? afterPackageMutator = null,
        Func<Resource, string>? buildUrlFromResource = null)
    {
        _afterPackageMutator = afterPackageMutator;
        _buildUrlFromResource = buildUrlFromResource;
    }

    private readonly Action<Resource>? _afterPackageMutator;
    private readonly Func<Resource, string>? _buildUrlFromResource;

    public string BuildUrlFromResource(Resource resource) =>
        _buildUrlFromResource?.Invoke(resource) ?? "#";

    public void MutateResource(Resource resource) =>
        _afterPackageMutator?.Invoke(resource);
}