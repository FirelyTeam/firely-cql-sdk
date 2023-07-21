/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm.Expressions
{
    public class IntervalExpression : Expression
    {
        public bool? lowClosed { get; set; }
        public Expression? lowClosedExpression { get; set; }

        public bool? highClosed { get; set; }
        public Expression? highClosedExpression { get; set; }

        public Expression? low { get; set; }
        public Expression? high { get; set; }
    }

}
