using Hl7.Cql.Comparers;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Firely.Comparers
{
    internal class IValueComparer<T> : CqlComparerBase<IValue<T>>
    {
        public override int? Compare(IValue<T>? x, IValue<T>? y, string? precision) =>
            x == null || y == null || x.Value == null || y.Value == null
            ? null
            : Comparer<T>.Default.Compare(x.Value, y.Value);

        public override bool Equivalent(IValue<T>? x, IValue<T>? y, string? precision) => Compare(x, y, precision) == 0;

        public override int GetHashCode(IValue<T> x)
        {
            if (x == null || x.Value == null)
                return typeof(Integer).GetHashCode();
            return x.Value.GetHashCode();
        }

    }
}
