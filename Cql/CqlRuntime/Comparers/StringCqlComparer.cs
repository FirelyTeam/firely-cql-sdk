using System;

namespace Ncqa.Cql.Runtime.Comparers
{
    public class StringCqlComparer : ICqlComparer, ICqlComparer<string>
    {
        public System.StringComparer InternalComparer { get; }
        public StringCqlComparer(System.StringComparer idComparer)
        {
            InternalComparer = idComparer ?? throw new ArgumentNullException(nameof(idComparer));
        }


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
            return InternalComparer.Compare(x, y);
        }

        public bool? Equals(string x, string y, string? precision = null) => Compare(x, y, precision) == 0;

        public bool? Equals(object x, object y, string? precision = null) => Compare(x as string, y as string, precision) == 0;

        public bool Equivalent(object x, object y, string? precision = null) =>
            Equivalent(x as string, y as string, precision);

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
            var areEqual = InternalComparer.Equals(thisNormalized, otherNormalized);
            return areEqual;
        }

        public int GetHashCode(string? x) =>
            x == null
            ? typeof(string).GetHashCode()
            : x.GetHashCode();

        public int GetHashCode(object x) => GetHashCode(x as string);
    }
}
