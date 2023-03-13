using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public abstract class ConvertsToExpression: UnaryExpression
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
