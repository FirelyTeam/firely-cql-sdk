/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Fhir.Introspection;
using Hl7.Fhir.Serialization;

namespace Hl7.Cql.Fhir.Serialization.Extensions;

/// <summary>
/// Creates and configures a <see cref="JsonSerializerOptions"/> instance for serializing FHIR resources.
/// </summary>
/// <remarks>The returned <see cref="JsonSerializerOptions"/> is tailored for FHIR-specific serialization needs,
/// ensuring compatibility with FHIR resource structures and conventions. CQL tuple deserialization support is also
/// added.</remarks>
public static class ModelInspectorFhirExtensions
{
    /// <summary>
    /// Creates and configures a <see cref="JsonSerializerOptions"/> instance for serializing FHIR resources.
    /// </summary>
    ///
    /// <remarks>
    /// The returned <see cref="JsonSerializerOptions"/> is tailored for FHIR-specific serialization
    /// needs, ensuring compatibility with FHIR resource structures and conventions.
    /// CQL tuple deserialization support is also added.
    /// </remarks>
    ///
    /// <param name="modelInspector">
    /// The <see cref="ModelInspector"/> instance used to customize the serialization options for FHIR models.
    /// </param>
    ///
    /// <returns>
    /// A configured <see cref="JsonSerializerOptions"/> instance with FHIR-specific settings,
    /// including cycle reference handling and support for CQL tuple deserialization.
    /// </returns>
    public static JsonSerializerOptions CreateJsonSerializerOptions(
        this ModelInspector modelInspector)
    {
        var o = new JsonSerializerOptions().ForFhir(modelInspector);
        o.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        o.AddCqlTupleDeserializationSupport();
        return o;
    }
}