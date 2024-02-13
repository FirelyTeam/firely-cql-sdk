using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Elm
{
    internal interface IHasPrecision
    {
        DateTimePrecision precision { get; set; }
        bool precisionSpecified { get; set; }
    }

    partial class Contains : IHasPrecision { }
    partial class DifferenceBetween : IHasPrecision { }
    partial class DurationBetween : IHasPrecision { }
    partial class In : IHasPrecision { }
    partial class IncludedIn: IHasPrecision { }
    partial class Includes : IHasPrecision { }
    partial class ProperContains : IHasPrecision { }
    partial class ProperIn : IHasPrecision { }
    partial class ProperIncludedIn : IHasPrecision { }
    partial class ProperIncludes : IHasPrecision { }





}
