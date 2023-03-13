
using Ncqa.Cql.Runtime.Primitives;

namespace Ncqa.Cql.Runtime.Conversion
{
    public interface IUnitConverter
    {
        CqlQuantity? ChangeUnits(CqlQuantity source, string ucumUnits);
    }
}
