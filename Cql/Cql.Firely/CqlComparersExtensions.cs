using Hl7.Cql.Comparers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Firely
{
    public static class CqlComparersExtensions
    {
        public static CqlComparers AddFirelyComparers(this CqlComparers comparers)
        {
            return comparers;
        }
    }
}
