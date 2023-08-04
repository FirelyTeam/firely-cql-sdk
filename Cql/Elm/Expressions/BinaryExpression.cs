/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm.Expressions
{
    public abstract class BinaryExpression : Expression
    {
        public Expression[]? operand { get; set; }
    }

    public class AddExpression : BinaryExpression { }
    public class AndExpression : BinaryExpression { }
    public class CanConvertQuantityExpression : BinaryExpression { }

    /// <summary>
    /// The &amp; operator for strings in CQL
    /// </summary>
    public class ConcatenateExpression : BinaryExpression { }
    public class ConvertQuantityExpression : BinaryExpression { }
    public class DivideExpression : BinaryExpression { }
    public class EndsWithExpression : BinaryExpression { }
    public class EqualExpression : BinaryExpression { }
    public class EquivalentExpression : BinaryExpression { }
    public class ExceptExpression : BinaryExpression { }
    public class ExpandExpression : BinaryExpression { }

    public class GreaterExpression : BinaryExpression { }
    public class GreaterOrEqualExpression : BinaryExpression { }
    public class HighBoundaryExpression : BinaryExpression { }
    public class IndexerExpression : BinaryExpression { }
    public class IntersectExpression : BinaryExpression { }
    public class LessExpression : BinaryExpression { }
    public class LessOrEqualExpression : BinaryExpression { }
    public class LogExpression : BinaryExpression { }

    public class LowBoundaryExpression : BinaryExpression { }
    public class MatchesExpression : BinaryExpression { }
    public class ModuloExpression : BinaryExpression { }
    public class MultiplyExpression : BinaryExpression { }

    public class OrExpression : BinaryExpression { }
    public class PowerExpression : BinaryExpression { }
    public class StartsWithExpression : BinaryExpression { }
    public class SubtractExpression : BinaryExpression { }
    public class UnionExpression : BinaryExpression { }
    public class TruncatedDivideExpression : BinaryExpression { }
    public class XorExpression : BinaryExpression { }
}
