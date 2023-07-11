using Hl7.Cql.Comparers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hl7.Fhir.Model;
using Hl7.Cql.Firely.Comparers;

namespace Hl7.Cql.Firely
{
    public static class CqlComparersExtensions
    {
        public static CqlComparers AddFirelyComparers(this CqlComparers comparers)
        {
            comparers.Register(typeof(FhirDecimal), new IValueComparer<decimal?>());
            comparers.Register(typeof(Id), new IValueComparer<string>());
            comparers.Register(typeof(Identifier), new IValueComparer<int?>());
            comparers.Register(typeof(Integer), new IValueComparer<int?>());
            return comparers;
        }
    }
}
