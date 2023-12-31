using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Primitives
{
    /// <summary>
    /// Defines that this type can be uncertain.
    /// </summary>
    /// <typeparam name="T">The element type of the uncertainty interval.</typeparam>
    public interface IUncertain<T>
    {
        /// <summary>
        /// <see langword="true" /> when this value is uncertain; otherwise, <see langword="false" />
        /// </summary>
        bool IsUncertain { get; }

        /// <summary>
        /// Gets the uncertainty interval.
        /// </summary>
        CqlInterval<T?>? Uncertainty { get; }
    }
}
