/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm.Expressions
{
    public class SourceExpression : Expression
    {
        public string? alias { get; set; }
        public Expression? expression { get; set; }
        /// <summary>
        /// Not sure what is needed exactly but since the names above are confusing me I added the the variables that align more closely with what will be passed in
        /// </summary>
        public string? name { get; set; }
        public SourceExpression? source { get; set; }
    }
}
