/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Fhir.Serialization.Extensions;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Fhir.Serialization;

/// <summary>
/// Provides utility methods for working with JSON serialization and deserialization of FHIR resources.
/// </summary>
/// <remarks>This class contains methods designed to facilitate the creation of JSON serialization options
/// tailored for FHIR resources, ensuring compatibility with FHIR-specific structures and conventions. It also includes
/// support for advanced features such as CQL tuple deserialization.</remarks>
public static class FhirJsonDeserializationUtility
{
    /// <summary>
    /// Creates a configured <see cref="JsonSerializerOptions"/> instance for serializing FHIR resources.
    /// </summary>
    ///
    /// <remarks>
    /// The returned <see cref="JsonSerializerOptions"/> is tailored for FHIR-specific serialization
    /// needs, ensuring compatibility with FHIR resource structures and conventions.
    /// CQL tuple deserialization support is also added.
    /// </remarks>
    ///
    /// <param name="inspector">An optional <see cref="ModelInspector"/> instance used to customize the serialization behavior.
    /// If not provided, the default <see cref="ModelInfo.ModelInspector"/> is used.
    /// </param>
    ///
    /// <returns>
    /// A configured <see cref="JsonSerializerOptions"/> instance with FHIR-specific settings,
    /// including cycle reference handling and support for CQL tuple deserialization.
    /// </returns>
    public static JsonSerializerOptions CreateFhirJsonSerializerOptions(
        ModelInspector? inspector = null) =>
        (inspector ?? ModelInfo.ModelInspector).CreateJsonSerializerOptions();
}