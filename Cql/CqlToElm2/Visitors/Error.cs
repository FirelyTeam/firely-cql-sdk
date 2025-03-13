using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Visitors;
internal class Error
{
    public ErrorType Type { get; }
    public object[] Details { get; }

    public Error(ErrorType type, params object[] details)
    {
        Type = type;
        Details = details;
    }
}
