/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Fhir.Serialization.Extensions;

/// <summary>
/// Provides methods for deserializing FHIR <see cref="Library"/> resources from JSON.
/// </summary>
/// <remarks>
/// Uses <see cref="BaseFhirJsonDeserializer"/> with <see cref="DeserializationMode.NoOverflow"/>
/// so that non-fatal issues (such as invalid canonical URLs) are tolerated and reported as
/// warnings rather than causing an exception.
/// </remarks>
internal static class FhirLibraryDeserializationExtensions
{
    private static readonly DeserializerSettings NoOverflowSettings =
        new DeserializerSettings().UsingMode(DeserializationMode.NoOverflow);

    /// <summary>
    /// Deserializes a FHIR <see cref="Library"/> resource from a JSON string.
    /// </summary>
    /// <param name="json">The JSON string to deserialize.</param>
    /// <param name="logger">Optional logger for reporting deserialization issues.</param>
    /// <returns>The deserialized <see cref="Library"/>.</returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when deserialization fails, or when the JSON does not represent a <see cref="Library"/> resource.
    /// </exception>
    public static Library ReadFhirLibraryFromJson(string json, ILogger? logger = null)
    {
        var parser = new BaseFhirJsonDeserializer(ModelInfo.ModelInspector, NoOverflowSettings);

        if (parser.TryDeserializeResource(json, out var resource, out var issues))
        {
            if (issues.Any())
            {
                logger?.LogWarning(
                    "Parsing JSON resource resulted in {IssueCount} issues, but deserialization succeeded. Issues: {Issues}",
                    issues.Count(),
                    string.Join("; ", issues.Select(i => i.Message)));
            }

            return resource as Library
                   ?? throw new InvalidOperationException("Deserialized resource is not a FHIR Library.");
        }

        logger?.LogError(
            "Parsing JSON resource resulted in {IssueCount} issues, processing is skipped for this item. Issues: {Issues}",
            issues.Count(),
            string.Join("; ", issues.Select(i => i.Message)));

        throw new InvalidOperationException(
            $"Failed to deserialize FHIR library from JSON. Issues: {string.Join("; ", issues.Select(i => i.Message))}");
    }

    /// <summary>
    /// Deserializes a FHIR <see cref="Library"/> resource from a JSON file.
    /// </summary>
    /// <param name="file">The JSON file to read and deserialize.</param>
    /// <param name="logger">Optional logger for reporting deserialization issues.</param>
    /// <returns>The deserialized <see cref="Library"/>.</returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when deserialization fails, or when the file does not represent a <see cref="Library"/> resource.
    /// </exception>
    public static Library ReadFhirLibraryFromFile(FileInfo file, ILogger? logger = null)
    {
        var json = File.ReadAllText(file.FullName);
        return ReadFhirLibraryFromJson(json, logger);
    }
}
