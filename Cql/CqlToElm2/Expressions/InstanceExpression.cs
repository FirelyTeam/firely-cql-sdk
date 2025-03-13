using Hl7.Cql.CqlToElm2.Symbols;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Expressions;
internal class InstanceExpression : Expression
{
    public InstanceExpression(TypeSymbol type, Dictionary<string,Expression> values) : base(type)
    {
        Values = values.AsReadOnly();
    }

    public ReadOnlyDictionary<string, Expression> Values { get; }

}
