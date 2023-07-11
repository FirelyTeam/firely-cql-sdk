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
            comparers.Register(typeof(Canonical), new IValueComparer<string?>());
            comparers.Register(typeof(Code), new IValueComparer<string?>());
            comparers.Register(typeof(Date), new IValueComparer<string?>());
            comparers.Register(typeof(FhirBoolean), new IValueComparer<bool?>());
            comparers.Register(typeof(FhirDateTime), new IValueComparer<string?>());
            comparers.Register(typeof(FhirDecimal), new IValueComparer<decimal?>());
            comparers.Register(typeof(FhirString), new IValueComparer<string?>());
            comparers.Register(typeof(FhirUri), new IValueComparer<string?>());
            comparers.Register(typeof(FhirUrl), new IValueComparer<string?>());
            comparers.Register(typeof(Id), new IValueComparer<string>());
            comparers.Register(typeof(Integer), new IValueComparer<int?>());
            comparers.Register(typeof(Instant), new IValueComparer<DateTimeOffset?>());
            comparers.Register(typeof(Markdown), new IValueComparer<string?>());
            comparers.Register(typeof(Oid), new IValueComparer<string?>());
            comparers.Register(typeof(PositiveInt), new IValueComparer<int?>());
            comparers.Register(typeof(Time), new IValueComparer<string?>());
            comparers.Register(typeof(UnsignedInt), new IValueComparer<int?>());
            comparers.Register(typeof(Uuid), new IValueComparer<string?>());

            comparers.Register(typeof(Identifier), new IdentifierComparer(comparers, comparers));
            return comparers;
        }
    }
}
