using Hl7.Cql.Abstractions;
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
    public class CqlInteger: IAddable<CqlInteger?>, IUncertain<int?>, ICqlComparable<CqlInteger>
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
        /// <remarks>
        /// If <paramref name="lowUncertainty"/> is equal to <paramref name="highUncertainty"/>, then this integer
        /// will not be uncertain and it's <see cref="Value"/> will be equal to both <paramref name="lowUncertainty"/> and <paramref name="highUncertainty"/>.
        /// </remarks>
        /// <param name="lowUncertainty">The low value of the uncertainty.</param>
        /// <param name="highUncertainty">The high value of the uncertainty.</param>
        public CqlInteger(int? lowUncertainty, int? highUncertainty)
        {
            if (lowUncertainty == highUncertainty)
                Value = lowUncertainty;
            else
            {
                Uncertainty = new CqlInterval<int?>(lowUncertainty, highUncertainty, true, true);
            }
        
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
            if (value == null)
                return null;
            else if (IsUncertain)
            {
                if (value.IsUncertain)
                {
                    int? low;
                    if (Uncertainty!.low == null || value.Uncertainty!.low == null)
                        low = null;
                    else 
                        low = Uncertainty.low + value.Uncertainty.high;
                    int? high;
                    if (Uncertainty!.high == null || value.Uncertainty!.high == null)
                        high = null;
                    else 
                        high = Uncertainty.high + value.Uncertainty.high;
                    return new CqlInteger(low, high);
                }
                else
                {
                    int? low;
                    if (Uncertainty!.low == null)
                        low = null;
                    else 
                        low = Uncertainty.low + value.Value;
                    int? high;
                    if (Uncertainty!.high == null)
                        high = null;
                    else 
                        high = Uncertainty.high + value.Value;
                    return new CqlInteger(low, high);
                }
            }
            else if (value.IsUncertain)
            {
                int? low;
                if (value.Uncertainty!.low == null)
                    low = null;
                else 
                    low = value.Uncertainty.low + Value;
                int? high;
                if (value.Uncertainty!.high == null)
                    high = null;
                else 
                    high = value.Uncertainty.high + Value;
                return new CqlInteger(low, high);
            }
            else
            {
                if (Value == null)
                    return null;
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

        /// <summary>
        /// Compares two integers.  If both integers are uncertain, the uncertainty ranges will be compared.
        /// <para>
        /// When comparing two ranges of integers, we consider both the lower and upper bounds of each range. 
        /// To determine which range is larger or smaller, we  compare the lower bounds first. 
        /// If the lower bound of one range is greater than the lower bound of the other, then that range is larger. 
        /// If the lower bounds are equal, we then compare the upper bounds to finalize the comparison.
        /// </para>
        /// <para>
        /// When one value is uncertain and the other is not, we determine whether the certain value lies
        /// strictly before or strictly after the uncertainty interval of the other.  If so, we return that comparison.
        /// If the certain value lies inclusively within the uncertainty interval, we return <see langword="null"/>.
        /// </para>
        /// <para>
        /// When both values are certain, we use <see cref="Comparer{T}.Default"/>.
        /// </para>
        /// <param name="other">The other value to compare against this value.</param>
        /// <param name="precision">Unused for integer types.</param>
        /// <returns>
        /// A negative number if this value comes before <paramref name="other"/>, 0 if they are equal, 
        /// a positive number if this value comes after <paramref name="other"/>, or <see langword="null" /> if any
        /// comparison can't be done because one of the operands are <see langword="null" />.
        /// </returns>
        /// </summary>
        public int? CompareTo(CqlInteger? other, string? precision = null)
        {
            if (other == null)
                return null;
            else if (IsUncertain)
            {
                if (other.IsUncertain)
                {
                    int? lowCompare;
                    if (Uncertainty!.low == null || other.Uncertainty!.low == null)
                        lowCompare = null;
                    else
                        lowCompare = Comparer<int>.Default.Compare(Uncertainty.low.Value, other.Uncertainty.low.Value);
                    if (lowCompare == null)
                        return null;
                    else if (lowCompare == 0)
                    {
                        if (Uncertainty!.high == null || other.Uncertainty!.high == null)
                            return null;
                        else
                            return Comparer<int>.Default.Compare(Uncertainty.high.Value, other.Uncertainty.high.Value);
                    }
                    else return lowCompare;
                }
                else
                {
                    // this value is uncertain and the other is not
                    if (other.Value == null || Uncertainty!.low == null)
                        return null;
                    else
                    {
                        var lowCompare = Comparer<int>.Default.Compare(Uncertainty.low.Value, other.Value.Value);
                        if (lowCompare > 0) // this uncertainty starts after other's value
                            return lowCompare;
                        else
                        {
                            // the other value starts after this uncertainty's low point
                            if (Uncertainty!.high == null)
                                return null;
                            var highCompare = Comparer<int>.Default.Compare(Uncertainty.high.Value, other.Value.Value);
                            if (highCompare < 0) // this uncertainty ends before other's value
                                return highCompare;
                            else 
                                return null; // the other value falls within this uncertainty range
                        }
                    }
                }
            }
            else if (other.IsUncertain)
            {
                // this value is not uncertain and the other is uncertain
                if (Value == null || other.Uncertainty!.low == null)
                    return null;
                else
                {
                    var lowCompare = Comparer<int>.Default.Compare(Value.Value, other.Uncertainty.low.Value);
                    if (lowCompare < 0) // this value is smaller than other uncertainty's low point
                        return lowCompare;
                    else
                    {
                        // the other uncertainty starts after this value
                        if (other.Uncertainty!.high == null)
                            return null;
                        var highCompare = Comparer<int>.Default.Compare(Value.Value, other.Uncertainty.high.Value);
                        if (highCompare > 0) // this value falls within other uncertainty range
                            return highCompare;
                        else
                            return null; // other uncertainty ends after this value
                    }
                }
            }
            else
            {
                // Both values are certain, compare them directly
                if (Value == null || other.Value == null)
                    return null; // Handle the case where either value is null based on your requirements.
                else
                    return Comparer<int>.Default.Compare(Value.Value, other.Value.Value);
            }
        }
    }
}
