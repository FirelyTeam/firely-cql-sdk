using Hl7.Cql.Comparers;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Fhir
{
    /// <summary>
    /// Defines behavior options to configure the Firely CQL model binding.
    /// </summary>
    public class FhirModelBindingOptions
    {
        /// <summary>
        /// Gets the default CQL options.
        /// </summary>
        public static readonly FhirModelBindingOptions Default = new();

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
        /// The size of the LRU cache to use for the resource packager.
        /// </summary>
        public int LRUCacheSize { get; init; } = 10000;
    }
}
