/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace Hl7.Cql.Packaging;

internal class FhirResourceFileWriter(
    ILogger<FhirResourceFileWriter> logger)
{
    private static readonly JsonSerializerOptions JsonSerializerOptions = new JsonSerializerOptions().ForFhir(ModelInfo.ModelInspector).Pretty();

    public void SaveResource(
        Resource resource,
        DirectoryInfo outDirectory,
        DateTime? overrideDate = null)
    {
        ResourceFileName resourceFileName = resource switch
        {
            Library l => ResourceFileName.Create(nameof(Library), l.Id, l.Version),
            Measure m => ResourceFileName.Create(nameof(Measure), m.Id, m.Version),
            _ => throw new UnreachableException("Only expecting Library or Measure.")
        };

        var file = new FileInfo($"{Path.Combine(outDirectory!.FullName, resourceFileName.FileName)}");
        logger.LogInformation("Writing FHIR Resource file: '{file}'", file.FullName);

        if (resource is Library library
            && overrideDate is { } date)
        {
            const string ISO8061 = "O";
            library.Date = date.ToString(ISO8061);
            if (library.Meta is { } meta)
            {
                meta.LastUpdated = overrideDate;
            }
        }

        file.Directory!.Create();
        using var streamOut = file.OpenWrite();
        streamOut.SetLength(0); // Clears out previous contents
        JsonSerializer.Serialize(streamOut, resource, JsonSerializerOptions);
    }
}