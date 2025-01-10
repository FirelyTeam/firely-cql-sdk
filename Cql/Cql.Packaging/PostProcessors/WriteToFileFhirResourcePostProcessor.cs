/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

/*using System.Diagnostics;
using System.Text.Json;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packaging.PostProcessors;

internal class WriteToFileFhirResourcePostProcessor(
    IOptions<FhirResourceWriterOptions> fhirResourceWriterOptions,
    ILogger<WriteToFileFhirResourcePostProcessor> logger)
    : FhirResourcePostProcessor
{
    private static readonly JsonSerializerOptions JsonSerializerOptions = new JsonSerializerOptions().ForFhir(ModelInfo.ModelInspector).Pretty();

    private readonly FhirResourceWriterOptions _fhirResourceWriterOptions = fhirResourceWriterOptions.Value;

    public override void ProcessResource(Resource resource)
    {
        ResourceFileName resourceFileName = resource switch
        {
            Library l => ResourceFileName.Create(nameof(Library), l.Id, l.Version),
            Measure m => ResourceFileName.Create(nameof(Measure), m.Id, m.Version),
            _ => throw new UnreachableException("Only expecting Library or Measure.")
        };

        var file = new FileInfo($"{Path.Combine(_fhirResourceWriterOptions.OutDirectory!.FullName, resourceFileName.FileName)}");
        logger.LogInformation("Writing FHIR Resource file: '{file}'", file.FullName);

        if (resource is Library library
            && _fhirResourceWriterOptions.OverrideDate is { } overrideDate)
        {
            const string ISO8061 = "O";
            library.Date = overrideDate.ToString(ISO8061);
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
}*/