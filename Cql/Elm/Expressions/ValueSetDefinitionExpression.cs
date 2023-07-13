/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm.Expressions;

namespace Hl7.Cql.Elm
{
    public class ValueSetDefinitionExpression : Expression
    {
        public string? id { get; set; }
        public string? name { get; set; }
        public string? version { get; set; }
    }
}
