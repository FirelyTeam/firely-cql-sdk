/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm.Expressions
{
    public class CollapseExpression : Expression
    {
        /// <summary>
        /// One or two parameters; the first is always a List of Intervals.  The second is optional and defines a precision.
        /// </summary>
        public Expression[]? operand { get; set; }


    }
}
