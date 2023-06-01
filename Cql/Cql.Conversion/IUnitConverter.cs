
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Conversion
{
    /// <summary>
    /// Defines a method to convert a <see cref="CqlQuantity"/> to a new quantity with different units.
    /// </summary>
    public interface IUnitConverter
    {
        /// <summary>
        /// Converts <paramref name="source"/> to <paramref name="ucumUnits"/>.
        /// </summary>
        /// <param name="source">The quantity whose units to change.</param>
        /// <param name="ucumUnits">The desired units.</param>
        /// <returns>A quantity expressed in new units, or <see langword="null"/> if the conversion is not supported.</returns>
        CqlQuantity? ChangeUnits(CqlQuantity source, string ucumUnits);
    }
}
