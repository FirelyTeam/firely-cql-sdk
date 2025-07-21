/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using Hl7.Fhir.Model;

namespace Hl7.Cql.Packaging;

internal static class ResourceExtensions
{
    public static ResourceFileName GetResourceFileName(this Resource resource)
    {
        ResourceFileName resourceFileName = resource switch
        {
            Library l => ResourceFileName.Create(nameof(Library), l.Name ?? "", l.Version),
            Measure m => ResourceFileName.Create(nameof(Measure), m.Name ?? "", m.Version),
            _ => throw new UnreachableException("Only expecting Library or Measure.")
        };
        return resourceFileName;
    }
}
