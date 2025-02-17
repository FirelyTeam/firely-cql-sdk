using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Symbols;
internal class Error
{
    public ErrorType Type { get; }

    public Error(ErrorType type)
    {
        Type = type;
    }
}
