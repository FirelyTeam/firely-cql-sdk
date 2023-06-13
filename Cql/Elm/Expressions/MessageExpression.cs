/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm.Expressions
{
    public class MessageExpression : Expression
    {
        public Expression? source { get; set; }
        public Expression? condition { get; set; }
        public Expression? code { get; set; }
        public Expression? severity { get; set; }
        public Expression? message { get; set; }

    }
}
