using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class AnyInValueSetExpression: Expression
    {
        public ValueSetRefExpression? valueset { get; set; }

        public Expression? codes { get; set; }

    }
}
