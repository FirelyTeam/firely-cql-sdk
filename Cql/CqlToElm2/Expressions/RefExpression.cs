using Hl7.Cql.CqlToElm2.Symbols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Expressions;
internal class RefExpression : Expression
{
    public RefExpression(Symbol to) : base(to.Type)
    {
        To = to;
    }

    public Symbol To { get; }


}