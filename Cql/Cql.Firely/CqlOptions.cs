using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Firely
{
    /// <summary>
    /// Defines behavior options for CQL execution.
    /// </summary>
    public class CqlOptions
    {
        /// <summary>
        /// Gets the default CQL options.
        /// </summary>
        public static readonly CqlOptions Default = new CqlOptions();

        /// <summary>
        /// When not <see langword="null"/>, all FHIR resource types will be compared only by their <see cref="Resource.Id"/> property
        /// using the value of this property.
        /// When <see langword="null"/>, FHIR resources will compared using Tuple equality behavior as defined in the specification.
        /// </summary>
        public StringComparer? ResourceIdComparer { get; init; } = StringComparer.OrdinalIgnoreCase;

    }
}
