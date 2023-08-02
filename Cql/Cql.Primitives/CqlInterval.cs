using System;

namespace Hl7.Cql.Primitives
{
    /// <summary>
    /// Implements the System Interval type.
    /// </summary>
    [CqlPrimitiveType(CqlPrimitiveType.Interval)]
    public class CqlInterval<T>
    {
        /// <summary>
        /// Returns a null point interval of this type.
        /// This instance is provided as a convenience for test cases, but should not be used otherwise.
        /// </summary>
        internal static readonly CqlInterval<T> PointNull = new();

        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="low">The low value.</param>
        /// <param name="high">The high value.</param>
        /// <param name="lowClosed">Whether this value is closed on its low end.</param>
        /// <param name="highClosed">Whether this value is closed on its high end.</param>
        /// <exception cref="ArgumentNullException">If both <paramref name="low"/> and <paramref name="high"/> are null.</exception>
        public CqlInterval(T low, T high, bool lowClosed, bool highClosed)
        {
            this.low = low;
            this.high = high;
            this.lowClosed = lowClosed;
            this.highClosed = highClosed;
            String = new Lazy<string>(() => $"{(this.lowClosed ?? false ? "[" : "(")}{this.low}, {this.high}{(this.highClosed ?? false ? "]" : ")")}");
        }

        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <remarks>
        /// It is possible to express <paramref name="lowClosed"/> and <paramref name="highClosed"/> as null in ELM,
        /// but not possible in the CQL language.
        /// </remarks>
        /// <param name="low">The low value.</param>
        /// <param name="high">The high value.</param>
        /// <param name="lowClosed">Whether this value is closed on its low end.</param>
        /// <param name="highClosed">Whether this value is closed on its high end.</param>
        /// <exception cref="ArgumentNullException">If both <paramref name="low"/> and <paramref name="high"/> are null.</exception>
        public CqlInterval(T low, T high, bool? lowClosed, bool? highClosed)
        {
            this.low = low;
            this.high = high;
            this.lowClosed = lowClosed ?? false;
            this.highClosed = highClosed ?? false;
            String = new Lazy<string>(() => $"{(this.lowClosed ?? false ? "[" : "(")}{this.low}, {this.high}{(this.highClosed ?? false ? "]" : ")")}");
        }


        private CqlInterval()
        {
            low = (T)((object)null!);
            high = (T)((object)null!);
            lowClosed = false;
            highClosed = false;
            String = new Lazy<string>(() => $"[null, null]");
        }

        /// <summary>
        /// Gets the low value of this interval.
        /// </summary>
        public T low { get; }
        /// <summary>
        /// Gets the high value of this interval.
        /// </summary>
        public T high { get; }

        /// <summary>
        /// If <see langword="true"/>, include the low value in comparisons, else, exclude it (e.g., [x,y] is a closed interval)
        /// </summary>
        public bool? lowClosed { get; }

        /// <summary>
        /// If <see langword="true"/>, include the high value in comparisons, else, exclude it (e.g., [x,y] is a closed interval)
        /// </summary>
        public bool? highClosed { get; }

        private readonly Lazy<string> String;

        /// <summary>
        /// Gets a string representation of this interval.
        /// </summary>
        public override string? ToString() => String?.Value ?? "[]";

        /// <summary>
        /// Gets the hash code of the result of <see cref="ToString"/>.
        /// </summary>
        public override int GetHashCode() => String?.Value?.GetHashCode() ?? 0;

        /// <summary>
        /// Compares this object to <paramref name="obj"/> for equality.
        /// </summary>
        /// <param name="obj">The object to compare against this value.</param>
        /// <returns><see langword="true"/> if equal.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj is CqlInterval<T> other)
            {
                return ToString() == other.ToString();
            }
            return false;
        }

    }

}
