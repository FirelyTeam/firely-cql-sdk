using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class CaseExpression : Expression
    {
        public CaseItemExpression[]? caseItem { get; set; }
        public Expression? @else { get; set; }
        /// <summary>
        /// For constructs like:
        ///     case {comparand}
        ///         when 'ms' then 'millisecond'
        ///         when 's' then 'second'
        ///         else unit
        ///     end
        /// </summary>
        public Expression? comparand { get; set; }
    }

    public class CaseItemExpression : Expression
    {
        public Expression? when { get; set; }
        public Expression? then { get; set; }
    }

}
