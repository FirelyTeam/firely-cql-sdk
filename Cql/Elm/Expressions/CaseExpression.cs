/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm.Expressions
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
