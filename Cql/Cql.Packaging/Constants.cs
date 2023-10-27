/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Packaging
{
    /// <summary>
    /// Constant values used when packaging measures
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Measure group code system
        /// </summary>
        public const string MeasureGroupCodeSystem = "https://ncqa.org/fhir/CodeSystem/measure-group";
        /// <summary>
        /// Extension ID added to parameters for the list element type value
        /// </summary>
        public const string ParameterElementTypeExtensionUri = "https://ncqa.org/fhir/StructureDefinition/ext-parameter.list-element-type";
        /// <summary>
        /// Extension ID added to parameters for the canonical URI value
        /// </summary>
        public const string ParameterCanonicalUri = "https://ncqa.org/fhir/StructureDefinition/ext-parameter.canonical-uri";
        /// <summary>
        /// Extension ID added to parameters for the access level value
        /// </summary>
        public const string ParameterAccessLevel = "https://ncqa.org/fhir/StructureDefinition/ext-parameter.access-level";
        /// <summary>
        /// Extension ID added to parameters for the CQL type value
        /// </summary>
        public const string ParameterCqlType = "https://ncqa.org/fhir/StructureDefinition/ext-parameter.cql-type";
        /// <summary>
        /// Extension ID added to parameters for the CQL list element type value
        /// </summary>
        public const string ParameterCqlElementType = "https://ncqa.org/fhir/StructureDefinition/ext-parameter.cql-element-type";
        /// <summary>
        /// Extension ID added to parameters for the CQL default value
        /// </summary>
        public const string ParameterCqlDefaultValue = "https://ncqa.org/fhir/StructureDefinition/ext-parameter.cql-default-value";
        /// <summary>
        /// Extension ID added to parameters for the CQL default value type
        /// </summary>
        public const string ParameterCqlDefaultValueType = "https://ncqa.org/fhir/StructureDefinition/ext-parameter.cql-default-type";
    }
}
