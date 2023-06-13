/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm.Expressions
{
    public class TimeExpression : Expression
    {
        public Expression? hour { get; set; }
        public Expression? minute { get; set; }
        public Expression? second { get; set; }
        public Expression? millisecond { get; set; }

    }
}
