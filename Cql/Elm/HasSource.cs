using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Elm
{
    internal interface IHasSource
    {
        Expression source { get; set; }
    }

    partial class AllTrue : IHasSource { }
    partial class AnyTrue : IHasSource { }
    partial class Avg : IHasSource { }
    partial class Count : IHasSource { }
    partial class Descendents : IHasSource { }
    partial class First : IHasSource { }
    partial class GeometricMean : IHasSource { }
    partial class IndexOf : IHasSource { }
    partial class Last : IHasSource { }
    partial class Max : IHasSource { }
    partial class Median : IHasSource { }
    partial class Min : IHasSource { }
    partial class Mode : IHasSource { }
    partial class PopulationStdDev : IHasSource { }
    partial class PopulationVariance : IHasSource { }
    partial class Product : IHasSource { }
    partial class StdDev : IHasSource { }
    partial class Sum : IHasSource { }
    partial class Variance : IHasSource { }










}
