/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using Hl7.Cql.Comparers;
using Hl7.Cql.Conversion;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Fhir
{
    /// <summary>
    /// Defines behavior options to configure the CQL context for FHIR model binding.
    /// </summary>
    public class FhirCqlContextOptions
    {
        /// <summary>
        /// Gets the default CQL options.
        /// </summary>
        public static readonly FhirCqlContextOptions Default = new();

        /// <summary>
        /// When not <see langword="null"/>, all FHIR resource types will be compared only by their <see cref="Resource.Id"/> property
        /// using the value of this property.
        /// When <see langword="null"/>, FHIR resources will compared using Tuple equality behavior as defined in the specification.
        /// </summary>
        public StringComparer? ResourceIdComparer { get; init; } = StringComparer.OrdinalIgnoreCase;

        /// <summary>
        /// Defines the behavior when checking if a code exists in a collection of codes.
        /// </summary>
        public CodeInOperatorSemantics CodeInOperatorType { get; init; } = CodeInOperatorSemantics.Equivalent;

        /// <summary>
        /// Enum to house the options for checking if a <see cref="Code"/> exists in a list of <see cref="Code"/>
        /// </summary>
        public enum CodeInOperatorSemantics
        {
            /// <summary>
            /// Forces the use of the <see cref="CqlCodeCqlComparer"/>
            /// </summary>
            Equals,
            /// <summary>
            /// Forces the use of the <see cref="CqlCodeCqlEquivalentComparer"/>
            /// </summary>
            Equivalent
        }

        /// <summary>
        /// The default LRU cache to use is in the <see cref="FhirTypeConverter"/> is <c>10000</c>, unless otherwise overriden here.
        /// </summary>
        /// <remarks>Changing this value, will create a new <see cref="TypeConverter"/>, unless a custom one was provided in <see cref="OverrideTypeConverter"/>.</remarks>
        public int? OverrideFhirTypeConverterCacheSize { get; init; }

        /// <summary>
        /// The default <see cref="ModelInspector"/> to use is <see cref="ModelInfo.ModelInspector"/>, unless otherwise overriden here.
        /// </summary>
        /// <remarks>Changing this value, will create a new <see cref="TypeConverter"/>, unless a custom one was provided in <see cref="OverrideTypeConverter"/>.</remarks>
        public ModelInspector? OverrideModelInspector { get; init; }

        /// <summary>
        /// The default <see cref="TypeConverter"/> to use is <see cref="FhirTypeConverter.Create(ModelInspector,Nullable{int})"/>, unless otherwise overriden here.
        /// </summary>
        public TypeConverter? OverrideTypeConverter { get; init; }
    }
}
