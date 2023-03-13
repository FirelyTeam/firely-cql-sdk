using Ncqa.Cql.Runtime;

namespace Ncqa.Cql.Runtime.Comparers
{
    /// <summary>
    /// Comparison is performed by closing the intervals via <see cref="BuiltIns.Predecessor{T}(T)" /> and <see cref="BuiltIns.Successor{T}(T)"/>
    /// </summary>
    public abstract class IntervalCqlComparer : ICqlComparer
    {
        protected IntervalCqlComparer(CqlComparers comparers, ICqlOperators operators)
        {
            Comparers = comparers ?? throw new System.ArgumentNullException(nameof(comparers));
            Operators = operators ?? throw new System.ArgumentNullException(nameof(operators));
        }

        public CqlComparers Comparers { get; }
        public ICqlOperators Operators { get; }

        public abstract int? Compare(object x, object y, string? precision = null);

        public bool? Equals(object x, object y, string? precision = null)
        {
            var compare = Compare(x, y, precision);
            if (compare == 0)
                return true;
            else if (compare == null)
                return null;
            else return false;
        }

        public bool Equivalent(object x, object y, string? precision = null) =>
            Compare(x, y, precision) == 0 ? true : false;

        public int GetHashCode(object x) =>
            x == null
            ? typeof(object).GetHashCode()
            : x.ToString()!.GetHashCode();

    }
}