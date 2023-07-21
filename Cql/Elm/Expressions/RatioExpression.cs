/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm.Expressions
{
    public class RatioExpression : Expression
    {
        public RatioSide? numerator { get; set; }
        public RatioSide? denominator { get; set; }
    }

    public class RatioSide
    {
        public int? value { get; set; }
        public string? unit { get; set; }
    }

}
