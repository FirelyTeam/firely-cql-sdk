/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Runtime.Serialization;

namespace Hl7.Cql.Fhir.Serialization.Extensions;

/// <summary>
/// Provides extension methods for configuring and enhancing <see cref="JsonSerializerOptions"/>  with additional
/// functionality specific to FHIR (Fast Healthcare Interoperability Resources) and CQL (Clinical Quality Language)
/// workflows.
/// </summary>
/// <remarks>This static class includes methods to add support for deserializing CQL tuples and to create 
/// customized <see cref="JsonSerializerOptions"/> instances by applying user-defined modifications.  These extensions
/// are designed to simplify JSON serialization and deserialization scenarios  in healthcare and clinical quality
/// applications.</remarks>
public static class JsonSerializerOptionsFhirExtensions
{
    /// <summary>
    /// Adds support for deserializing CQL tuples to the specified <see cref="JsonSerializerOptions"/> instance.
    /// </summary>
    /// <remarks>This method registers a custom converter to handle the deserialization of CQL tuples,
    /// enabling seamless integration with JSON serialization and deserialization workflows.</remarks>
    /// <param name="options">The <see cref="JsonSerializerOptions"/> instance to which the CQL tuple deserialization support will be added.
    /// Cannot be <see langword="null"/>.</param>
    /// <returns>The modified <see cref="JsonSerializerOptions"/> instance with CQL tuple deserialization support enabled.</returns>
    public static JsonSerializerOptions AddCqlTupleDeserializationSupport(
        this JsonSerializerOptions options)
    {
        // Add CQL tuple converter for automatic serialization of CQL tuples
        options.Converters.Add(new CqlValueTupleJsonConverterFactory());
        return options;
    }

    /// <summary>
    /// Creates a new <see cref="JsonSerializerOptions"/> instance by applying the specified mutator function to the
    /// current options, or returns the original options if the mutator is <see langword="null"/>.
    /// </summary>
    ///
    /// <param name="options">The existing <see cref="JsonSerializerOptions"/> instance to use as the base for mutation.</param>
    ///
    /// <param name="configureOptions">
    /// A delegate that defines the modifications to apply to a new <see cref="JsonSerializerOptions"/> instance.  If
    /// <see langword="null"/>, the method returns the original <paramref name="options"/> instance.
    /// </param>
    ///
    /// <returns>
    /// A new <see cref="JsonSerializerOptions"/> instance with the applied modifications, or the original
    /// <paramref name="options"/> instance if <paramref name="configureOptions"/> is <see langword="null"/>.
    /// </returns>
    public static JsonSerializerOptions Mutate(
        this JsonSerializerOptions options,
        Mutator<JsonSerializerOptions>? configureOptions) =>
        configureOptions == null ? options : configureOptions(new(options));
}