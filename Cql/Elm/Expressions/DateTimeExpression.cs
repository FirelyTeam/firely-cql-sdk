using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class DateTimeExpression: Expression
    {
        public Expression? year { get; set; }
        public Expression? month { get; set; }
        public Expression? day { get; set; }
        public Expression? hour { get; set; }
        public Expression? minute { get; set; }
        public Expression? second { get; set; }
        public Expression? millisecond { get; set; }
        public Expression? timezoneOffset { get; set; }

    }
}
