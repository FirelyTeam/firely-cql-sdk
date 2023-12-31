using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Primitives
{
    /// <summary>
    /// Defines an integer with its 
    /// </summary>
    public class CqlInteger: IAddable<CqlInteger?>, IUncertain<int?>
    {
        /// <summary>
        /// Creates a certain integer.
        /// </summary>
        /// <param name="value">The certain value of this integer.</param>
        public CqlInteger(int? value)
        {
            Value = value;
        }

        /// <summary>
        /// Creates an uncertain integer.
        /// </summary>
        /// <param name="lowUncertainty">The low value of the uncertainty.</param>
        /// <param name="highUncertainty">The high value of the uncertainty.</param>
        public CqlInteger(int? lowUncertainty, int? highUncertainty)
        {
            Uncertainty = new CqlInterval<int?>(lowUncertainty, highUncertainty, true, true);
        }

        /// <summary>
        /// Used for unit tests only.
        /// </summary>
        internal static CqlInteger PointNullUncertainty =>
            new CqlInteger(null) { Uncertainty = CqlInterval<int?>.PointNull };

        /// <summary>
        /// Converts <paramref name="value"/> to a <see cref="CqlInteger"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        public static implicit operator CqlInteger(int? value) => new CqlInteger(value);

        /// <summary>
        /// The value of this integer.
        /// </summary>
        public int? Value { get; }

        /// <inheritdoc />
        public bool IsUncertain => Uncertainty != null;

        /// <inheritdoc />
        public CqlInterval<int?>? Uncertainty { get; private set; }

        /// <inheritdoc />
        public CqlInteger? Add(CqlInteger? value)
        {
            if (value == null || value == null)
                return null;
            else if (IsUncertain)
            {
                if (value.IsUncertain)
                {
                    int? low;
                    if (Uncertainty!.low == null || value.Uncertainty!.low == null)
                        low = null;
                    else low = Uncertainty.low + value.Uncertainty.high;
                    int? high;
                    if (Uncertainty!.high == null || value.Uncertainty!.high == null)
                        high = null;
                    else high = Uncertainty.high + value.Uncertainty.high;
                    return new CqlInteger(low, high);
                }
                else
                {
                    int? low;
                    if (Uncertainty!.low == null)
                        low = null;
                    else low = Uncertainty.low + value.Value;
                    int? high;
                    if (Uncertainty!.high == null)
                        high = null;
                    else high = Uncertainty.high + value.Value;
                    return new CqlInteger(low, high);
                }
            }
            else if (value.IsUncertain)
            {
                int? low;
                if (value.Uncertainty!.low == null)
                    low = null;
                else low = value.Uncertainty.low + Value;
                int? high;
                if (value.Uncertainty!.high == null)
                    high = null;
                else high = value.Uncertainty.high + Value;
                return new CqlInteger(low, high);
            }
            else
            {
                var sum = Value + value.Value;
                return new CqlInteger(sum);
            }
        }

        /// <inheritdoc />
        public static CqlInteger? operator +(CqlInteger? x, CqlInteger? y)
        {
            if (x == null || y == null)
                return null;
            else return x.Add(y);
        } 

        /// <inheritdoc />
        public CqlInteger? Subtract(CqlInteger? value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public static CqlInteger? operator -(CqlInteger? x, CqlInteger? y)
        {
            if (x == null || y == null)
                return null;
            else return x.Subtract(y);
        }
    }
}
