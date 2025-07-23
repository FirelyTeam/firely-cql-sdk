/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace Hl7.Cql.Fhir.Extensions;

/// <summary>
/// Provides extension methods for deserializing JSON to FHIR domain resources.
/// </summary>
public static class FhirDeserializationExtensions
{
    private static readonly JsonSerializerOptions Options = BuildJsonSerializerOptions();

    /// <summary>
    /// Builds the JSON serializer options for FHIR serialization.
    /// </summary>
    /// <returns>The configured <see cref="JsonSerializerOptions"/>.</returns>
    private static JsonSerializerOptions BuildJsonSerializerOptions()
    {
        var o = new JsonSerializerOptions().ForFhir(ModelInfo.ModelInspector);
        o.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        return o;
    }

    /// <summary>
    /// Deserializes a JSON stream to a FHIR domain resource.
    /// </summary>
    /// <typeparam name="TDomainResource">The type of the FHIR domain resource.</typeparam>
    /// <param name="jsonStream">The JSON stream to deserialize.</param>
    /// <param name="configureOptions">The optional callback to mutate the <see cref="JsonSerializerOptions"/>.</param>
    /// <returns>The deserialized FHIR domain resource.</returns>
    /// <exception cref="ArgumentException">Thrown when the stream cannot be deserialized to the specified type.</exception>
    public static TDomainResource DeserializeJsonToFhir<TDomainResource>(
        this Stream jsonStream,
        Mutator<JsonSerializerOptions>? configureOptions = null)
        where TDomainResource : DomainResource =>
        JsonSerializer.Deserialize<TDomainResource>(jsonStream, configureOptions == null ? Options : configureOptions(new (Options)))
        ?? throw new ArgumentException($"Unable to deserialize this stream as {typeof(TDomainResource).Name}");

    /// <summary>
    /// Deserializes a JSON string to a FHIR domain resource.
    /// </summary>
    /// <typeparam name="TDomainResource">The type of the FHIR domain resource.</typeparam>
    /// <param name="jsonString">The JSON string to deserialize.</param>
    /// <param name="configureOptions">The optional callback to mutate the <see cref="JsonSerializerOptions"/>.</param>
    /// <returns>The deserialized FHIR domain resource.</returns>
    /// <exception cref="ArgumentException">Thrown when the string cannot be deserialized to the specified type.</exception>
    public static TDomainResource DeserializeJsonToFhir<TDomainResource>(
        this string jsonString,
        Mutator<JsonSerializerOptions>? configureOptions = null)
        where TDomainResource : DomainResource =>
        JsonSerializer.Deserialize<TDomainResource>(jsonString, configureOptions == null ? Options : configureOptions(new(Options)))
        ?? throw new ArgumentException($"Unable to deserialize this string as {typeof(TDomainResource).Name}");

    /// <summary>
    /// Deserializes a JSON character span to a FHIR domain resource.
    /// </summary>
    /// <typeparam name="TDomainResource">The type of the FHIR domain resource.</typeparam>
    /// <param name="jsonCharSpan">The JSON character span to deserialize.</param>
    /// <param name="configureOptions">The optional callback to mutate the <see cref="JsonSerializerOptions"/>.</param>
    /// <returns>The deserialized FHIR domain resource.</returns>
    /// <exception cref="ArgumentException">Thrown when the character span cannot be deserialized to the specified type.</exception>
    public static TDomainResource DeserializeJsonToFhir<TDomainResource>(
        this ReadOnlySpan<char> jsonCharSpan,
        Mutator<JsonSerializerOptions>? configureOptions = null)
        where TDomainResource : DomainResource =>
        JsonSerializer.Deserialize<TDomainResource>(jsonCharSpan, configureOptions == null ? Options : configureOptions(new(Options)))
        ?? throw new ArgumentException($"Unable to deserialize this character span as {typeof(TDomainResource).Name}");
}
