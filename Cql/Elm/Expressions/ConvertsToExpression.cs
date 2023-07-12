/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm.Expressions
{
    public abstract class ConvertsToExpression : UnaryExpression
    {
        public TypeSpecifierExpression? toTypeSpecifier { get; set; }

        public string? toType { get; set; }

    }
    public class ConvertsToBooleanExpression : ConvertsToExpression { }
    public class ConvertsToDateExpression : ConvertsToExpression { }
    public class ConvertsToDateTimeExpression : ConvertsToExpression { }
    public class ConvertsToDecimalExpression : ConvertsToExpression { }
    public class ConvertsToLongExpression : ConvertsToExpression { }
    public class ConvertsToIntegerExpression : ConvertsToExpression { }
    public class ConvertsToQuantityExpression : ConvertsToExpression { }
    public class ConvertsToStringExpression : ConvertsToExpression { }
    public class ConvertsToTimeExpression : ConvertsToExpression { }
}
