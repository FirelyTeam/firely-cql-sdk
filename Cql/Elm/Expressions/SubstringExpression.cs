using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class SubstringExpression: Expression
    {
        public Expression? stringToSub { get; set; }

        public Expression? startIndex { get; set; }

        public Expression? length { get; set; }

    }
}
