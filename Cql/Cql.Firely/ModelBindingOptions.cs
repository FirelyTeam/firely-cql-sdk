using Hl7.Fhir.Model;

namespace Hl7.Cql.Firely
{
    /// <summary>
    /// Defines behavior options to configure the Firely CQL model binding.
    /// </summary>
    public class ModelBindingOptions
    {
        /// <summary>
        /// Gets the default CQL options.
        /// </summary>
        public static readonly ModelBindingOptions Default = new();

        /// <summary>
        /// When not <see langword="null"/>, all FHIR resource types will be compared only by their <see cref="Resource.Id"/> property
        /// using the value of this property.
        /// When <see langword="null"/>, FHIR resources will compared using Tuple equality behavior as defined in the specification.
        /// </summary>
        public StringComparer? ResourceIdComparer { get; init; } = StringComparer.OrdinalIgnoreCase;

    }
}
