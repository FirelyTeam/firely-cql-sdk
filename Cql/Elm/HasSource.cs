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

    partial class Descendents : IHasSource { }
    partial class First: IHasSource { }
    partial class IndexOf : IHasSource { }
    public partial class Last: IHasSource { }
}
