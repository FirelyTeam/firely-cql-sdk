﻿using System.Text.Json;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packaging.PostProcessors;

internal class WriteToFileFhirResourcePostProcessor : FhirResourcePostProcessor
{
    private static readonly JsonSerializerOptions JsonSerializerOptions = new JsonSerializerOptions().ForFhir(ModelInfo.ModelInspector).Pretty();

    private readonly FhirResourceWriterOptions _fhirResourceWriterOptions;
    private readonly ILogger<WriteToFileFhirResourcePostProcessor> _logger;

    public WriteToFileFhirResourcePostProcessor(
        IOptions<FhirResourceWriterOptions> fhirResourceWriterOptions,
        ILogger<WriteToFileFhirResourcePostProcessor> logger)
    {
        _fhirResourceWriterOptions = fhirResourceWriterOptions.Value;
        _logger = logger;
    }

    public override void ProcessResource(Resource resource)
    {
        var file = new FileInfo($"{Path.Combine(_fhirResourceWriterOptions.OutDirectory!.FullName, resource.Id)}.json");
        _logger.LogInformation("Writing FHIR Resource file: '{file}'", file.FullName);

        if (resource is Library library
            && _fhirResourceWriterOptions.OverrideDate is { } overrideDate)
        {
            library.Date = overrideDate.ToString("u");
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