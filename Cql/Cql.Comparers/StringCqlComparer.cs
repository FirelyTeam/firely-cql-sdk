using System;

namespace Hl7.Cql.Comparers
{
    /// <summary>
    /// Compares normalized strings given <see cref="Comparer"/>.
    /// </summary>
    /// <remarks>
    /// Strings are normalized using <see cref="String.Normalize"/>.
    /// </remarks>
    public class StringCqlComparer : ICqlComparer, ICqlComparer<string>
    {
        public System.StringComparer Comparer { get; }
        public StringCqlComparer(System.StringComparer idComparer)
        {
            Comparer = idComparer ?? throw new ArgumentNullException(nameof(idComparer));
        }

        /// <inheritdoc/>
        public int? Compare(object x, object y, string? precision = null) => Compare(x as string, y as string, null);
        public int? Compare(string? x, string? y, string? precision = null)
        {
            if (x == null)
            {
                if (y == null)
                    return 0;
                else return -1;
            }
            else if (y == null)
                return 1;
            return Comparer.Compare(x.Normalize(), y.Normalize());
        }

        /// <inheritdoc/>
        public bool? Equals(string x, string y, string? precision = null) => Compare(x, y, precision) == 0;
        
        /// <inheritdoc/>
        public bool? Equals(object x, object y, string? precision = null) => Compare(x as string, y as string, precision) == 0;

        /// <inheritdoc/>
        public bool Equivalent(object x, object y, string? precision = null) =>
            Equivalent(x as string, y as string, precision);

        /// <inheritdoc/>
        public bool Equivalent(string? x, string? y, string? precision = null)
        {
            if (x == null)
            {
                if (y == null)
                    return true;
                else return false;
            }
            else if (y == null)
                return false;
            var thisNormalized = x!.Normalize();
            var otherNormalized = y!.Normalize();
            var areEqual = Comparer.Equals(thisNormalized, otherNormalized);
            return areEqual;
        }

        /// <inheritdoc/>
        public int GetHashCode(string? x) =>
            x == null
            ? typeof(string).GetHashCode()
            : x.GetHashCode();

        /// <inheritdoc/>
        public int GetHashCode(object x) => GetHashCode(x as string);
    }
}
