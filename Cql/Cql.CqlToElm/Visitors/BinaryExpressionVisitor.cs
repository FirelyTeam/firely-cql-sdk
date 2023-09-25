using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Globalization;
using System.Xml;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal partial class ExpressionVisitor
    {
        public override Expression VisitAndExpression([NotNull] cqlParser.AndExpressionContext context)
        {
            var lhs = Visit(context.GetChild(0)!)!;
            var rhs = Visit(context.GetChild(2)!)!;

            if (lhs is Null)
                lhs = new As
                {
                    operand = lhs,
                    localId = NextId(),
                    locator = lhs.locator,
                    asType = BooleanTypeQName,
                    asTypeSpecifier = NamedType(BooleanTypeQName, context),
                    resultTypeName = BooleanTypeQName,
                    resultTypeSpecifier = NamedType(BooleanTypeQName, context),
                };
            if (rhs is Null)
                rhs = new As
                {
                    operand = rhs,
                    localId = NextId(),
                    locator = rhs.locator,
                    asType = BooleanTypeQName,
                    asTypeSpecifier = NamedType(BooleanTypeQName, context),
                    resultTypeName = BooleanTypeQName,
                    resultTypeSpecifier = NamedType(BooleanTypeQName, context),
                };


            if (lhs.resultTypeName != BooleanTypeQName
                || rhs.resultTypeName != BooleanTypeQName)
                UnresolvedSignature("And", lhs, rhs);
            var and = new And
            {
                localId = NextId(),
                locator = context.Locator(),
                operand = new[] { lhs, rhs },
                resultTypeName = BooleanTypeQName,
                resultTypeSpecifier = NamedType(BooleanTypeQName, context),
            };
            return and;
        }

        public override Expression VisitAdditionExpressionTerm([NotNull] cqlParser.AdditionExpressionTermContext context)
        {
            var lhsChild = context.GetChild(0) as cqlParser.ExpressionTermContext;
            var rhsChild = context.GetChild(2) as cqlParser.ExpressionTermContext;

            var lhs = Visit(lhsChild!)!;
            var @operator = context.GetChild(1).GetText();
            var rhs = Visit(rhsChild!)!;

            #region Operand conversions

            if (lhs is Null)
            {
                if (rhs is Null)
                {
                    throw Critical($"Cannot add null to null");
                }
                else
                {
                    lhs = new As
                    {
                        operand = lhs,
                        localId = NextId(),
                        locator = lhs.locator,
                        asType = rhs!.resultTypeName,
                        asTypeSpecifier = NamedType(rhs!.resultTypeName, context),
                        resultTypeName = new XmlQualifiedName(rhs!.resultTypeName.Name),
                        resultTypeSpecifier = NamedType(rhs!.resultTypeName, context),
                    };
                }
            }
            else if (rhs is Null)
            {
                NamedTypeSpecifier? asType = null;
                if (lhs.resultTypeName == DateTypeQName
                    || lhs.resultTypeName == DateTimeTypeQName
                    || lhs.resultTypeName == TimeTypeQName)
                {
                    asType = NamedType(QuantityTypeQName, context);
                }
                else
                {
                    asType = NamedType(lhs!.resultTypeName, context);
                }
                rhs = new As
                {
                    operand = rhs,
                    localId = NextId(),
                    locator = rhs.locator,
                    asType = new XmlQualifiedName(asType.name.Name),
                    asTypeSpecifier = asType,
                    resultTypeName = new XmlQualifiedName(asType.name.Name),
                    resultTypeSpecifier = NamedType(asType.name, context),
                };
            }
            else if (lhs.resultTypeName == IntegerTypeQName)
            {
                if (rhs.resultTypeName == DecimalTypeQName)
                    lhs = new ToDecimal
                    {
                        operand = lhs,
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = DecimalTypeQName,
                        resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                    };
                else if (rhs.resultTypeName == LongTypeQName)
                    lhs = new ToLong
                    {
                        operand = lhs,
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = LongTypeQName,
                        resultTypeSpecifier = NamedType(LongTypeQName, context),
                    };
                else if (rhs.resultTypeName == QuantityTypeQName)
                    lhs = new ToQuantity
                    {
                        operand = new ToDecimal
                        {
                            operand = lhs,
                            localId = NextId(),
                            locator = lhs.locator,
                            resultTypeName = DecimalTypeQName,
                            resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                        },
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = QuantityTypeQName,
                        resultTypeSpecifier = NamedType(QuantityTypeQName, context),
                    };
            }
            else if (lhs.resultTypeName == LongTypeQName)
            {
                if (rhs.resultTypeName == DecimalTypeQName)
                    lhs = new ToDecimal
                    {
                        operand = lhs,
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = DecimalTypeQName,
                        resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                    };
                else if (rhs.resultTypeName == IntegerTypeQName)
                    rhs = new ToLong
                    {
                        operand = rhs,
                        localId = NextId(),
                        locator = rhs.locator,
                        resultTypeName = LongTypeQName,
                        resultTypeSpecifier = NamedType(LongTypeQName, context),
                    };
                else if (rhs.resultTypeName == QuantityTypeQName)
                    lhs = new ToQuantity
                    {
                        operand = new ToDecimal
                        {
                            operand = lhs,
                            localId = NextId(),
                            locator = lhs.locator,
                            resultTypeName = DecimalTypeQName,
                            resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                        },
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = QuantityTypeQName,
                        resultTypeSpecifier = NamedType(QuantityTypeQName, context),
                    };
            }
            else if (lhs.resultTypeName == DecimalTypeQName)
            {
                if (rhs.resultTypeName == LongTypeQName)
                    rhs = new ToDecimal
                    {
                        operand = rhs,
                        localId = NextId(),
                        locator = rhs.locator,
                        resultTypeName = DecimalTypeQName,
                        resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                    };
                else if (rhs.resultTypeName == IntegerTypeQName)
                    rhs = new ToDecimal
                    {
                        operand = rhs,
                        localId = NextId(),
                        locator = rhs.locator,
                        resultTypeName = DecimalTypeQName,
                        resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                    };
                else if (rhs.resultTypeName == QuantityTypeQName)
                    lhs = new ToQuantity
                    {
                        operand = lhs,
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = QuantityTypeQName,
                        resultTypeSpecifier = NamedType(QuantityTypeQName, context),
                    };
            }
            else if (lhs.resultTypeName == QuantityTypeQName)
            {
                if (rhs.resultTypeName == IntegerTypeQName || rhs.resultTypeName == LongTypeQName)
                    rhs = new ToQuantity
                    {
                        operand = new ToDecimal
                        {
                            operand = rhs,
                            localId = NextId(),
                            locator = rhs.locator,
                            resultTypeName = DecimalTypeQName,
                            resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                        },
                        localId = NextId(),
                        locator = rhs.locator,
                        resultTypeName = QuantityTypeQName,
                        resultTypeSpecifier = NamedType(QuantityTypeQName, context),
                    };
                else if (rhs.resultTypeName == DecimalTypeQName)
                    rhs = new ToQuantity
                    {
                        operand = rhs,
                        localId = NextId(),
                        locator = rhs.locator,
                        resultTypeName = QuantityTypeQName,
                        resultTypeSpecifier = NamedType(QuantityTypeQName, context),
                    };
                else if (rhs.resultTypeName != QuantityTypeQName)
                    throw Critical($"Quantity can only be added to numeric types (Integer, Long, Decimal) and Quantity types.  The type of the second operand is {rhs.resultTypeName}.");
            }
            else if (lhs.resultTypeName == DateTypeQName)
            {
                if (rhs.resultTypeName != QuantityTypeQName)
                    throw Critical($"Only Quantity values can be added to Date values.  The type of the second operand is {rhs.resultTypeName}.");
            }
            else if (lhs.resultTypeName == DateTimeTypeQName)
            {
                if (rhs.resultTypeName != QuantityTypeQName)
                    throw Critical($"Only Quantity values can be added to DateTime values.  The type of the second operand is {rhs.resultTypeName}.");
            }
            else if (lhs.resultTypeName == TimeTypeQName)
            {
                if (rhs.resultTypeName != QuantityTypeQName)
                    throw Critical($"Only Quantity values can be added to Time values.  The type of the second operand is {rhs.resultTypeName}.");
            }

            #endregion

            Expression? expression = null;

            switch (@operator)
            {
                case "+":
                    expression = new Add
                    {
                        operand = new[] { lhs, rhs },
                        resultTypeName = lhs.resultTypeName,
                        resultTypeSpecifier = NamedType(lhs.resultTypeName, context)
                    };
                    break;
                case "-":
                    expression = new Subtract
                    {
                        operand = new[] { lhs, rhs },
                        resultTypeName = lhs.resultTypeName,
                        resultTypeSpecifier = NamedType(lhs.resultTypeName, context)
                    };
                    if (lhs.resultTypeName == QuantityTypeQName)
                    {
                        if (rhs.resultTypeName == DateTypeQName
                            || rhs.resultTypeName == DateTimeTypeQName
                            || rhs.resultTypeName == TimeTypeQName)
                            throw Critical($"Date, DateTime, and Time values cannot be subtracted from Quantity values.");
                    }
                    break;
                case "&":
                    if (lhs.resultTypeName != StringTypeQName
                        && rhs.resultTypeName != StringTypeQName)
                    {
                        throw Critical($"Operator & is only defined for string types, not {lhs.resultTypeName} and {rhs.resultTypeName}");
                    }
                    expression = new Concatenate
                    {
                        operand = new[] { lhs, rhs },
                        resultTypeName = lhs.resultTypeName,
                        resultTypeSpecifier = NamedType(lhs.resultTypeName, context)
                    };
                    break;
                default:
                    throw Critical($"Unexpected arithmetic operator {@operator}");
            }
            expression!.localId = NextId();
            expression.locator = context.Locator();
            return expression;

        }

        //    | 'difference' 'in' pluralDateTimePrecision 'between' expressionTerm 'and' expressionTerm       #differenceBetweenExpression
        public override Expression VisitDifferenceBetweenExpression([NotNull] cqlParser.DifferenceBetweenExpressionContext context)
        {
            var precision = context.pluralDateTimePrecision().Parse();

            var lhs = Visit(context.GetChild(4));
            var rhs = Visit(context.GetChild(6));

            if (lhs is Null)
            {
                if (rhs is not Null)
                {
                    lhs = new As
                    {
                        operand = lhs,
                        localId = NextId(),
                        locator = lhs.locator,
                        asType = rhs!.resultTypeName,
                        asTypeSpecifier = NamedType(rhs!.resultTypeName, context),
                        resultTypeName = rhs!.resultTypeName,
                        resultTypeSpecifier = NamedType(rhs!.resultTypeName, context),
                    };
                }
            }
            else if (rhs is Null)
            {
                var asType = NamedType(lhs!.resultTypeName, context);
                rhs = new As
                {
                    operand = rhs,
                    localId = NextId(),
                    locator = rhs.locator,
                    asType = new XmlQualifiedName(asType.name.Name),
                    asTypeSpecifier = asType,
                    resultTypeName = new XmlQualifiedName(asType.name.Name),
                    resultTypeSpecifier = NamedType(asType.name, context),
                };
            }

            if (lhs.resultTypeName?.Name == null
                || rhs.resultTypeName?.Name == null
                || lhs.resultTypeName!.Name != rhs.resultTypeName!.Name)
            {
                UnresolvedSignature("Difference", lhs, rhs);
            }
            if (lhs.resultTypeName == DateTypeQName)
            {
                if (precision == DateTimePrecision.Year
                    || precision == DateTimePrecision.Month
                    || precision == DateTimePrecision.Week
                    || precision == DateTimePrecision.Day)
                {
                    return new DifferenceBetween
                    {
                        precision = precision,
                        localId = NextId(),
                        locator = context.Locator(),
                        operand = new[] { lhs, rhs },
                        precisionSpecified = true,
                        resultTypeName = IntegerTypeQName,
                        resultTypeSpecifier = NamedType(IntegerTypeQName, context)
                    };
                }
                else throw Critical($"Unit {precision} is not allowed for operands of type {DateTypeQName}");
            }
            else if (lhs.resultTypeName == TimeTypeQName)
            {
                if (precision == DateTimePrecision.Hour
                    || precision == DateTimePrecision.Minute
                    || precision == DateTimePrecision.Second
                    || precision == DateTimePrecision.Millisecond)
                {
                    return new DifferenceBetween
                    {
                        precision = precision,
                        localId = NextId(),
                        locator = context.Locator(),
                        operand = new[] { lhs, rhs },
                        precisionSpecified = true,
                        resultTypeName = IntegerTypeQName,
                        resultTypeSpecifier = NamedType(IntegerTypeQName, context)
                    };
                }
                else throw Critical($"Unit {precision.ToString()} is not allowed for operands of type {DateTypeQName}");

            }
            else if (lhs.resultTypeName == DateTimeTypeQName)
            {
                return new DifferenceBetween
                {
                    precision = precision,
                    localId = NextId(),
                    locator = context.Locator(),
                    operand = new[] { lhs, rhs },
                    precisionSpecified = true,
                    resultTypeName = IntegerTypeQName,
                    resultTypeSpecifier = NamedType(IntegerTypeQName, context)
                };
            }
            else throw UnresolvedSignature("Difference", lhs, rhs);
        }

        //     | ('duration' 'in')? pluralDateTimePrecision 'between' expressionTerm 'and' expressionTerm      #durationBetweenExpression
        public override Expression VisitDurationBetweenExpression([NotNull] cqlParser.DurationBetweenExpressionContext context)
        {
            int lhsIndex, rhsIndex;
            if (context.ChildCount == 7)
            {
                lhsIndex = 4;
                rhsIndex = 6;
            }
            else
            {
                lhsIndex = 2;
                rhsIndex = 4;
            }

            var precision = context.pluralDateTimePrecision().Parse();

            var lhs = Visit(context.GetChild(lhsIndex));
            var rhs = Visit(context.GetChild(rhsIndex));

            if (lhs is Null)
            {
                if (rhs is not Null)
                {
                    lhs = new As
                    {
                        operand = lhs,
                        localId = NextId(),
                        locator = lhs.locator,
                        asType = rhs!.resultTypeName,
                        asTypeSpecifier = NamedType(rhs!.resultTypeName, context),
                        resultTypeName = rhs!.resultTypeName,
                        resultTypeSpecifier = NamedType(rhs!.resultTypeName, context),
                    };
                }
            }
            else if (rhs is Null)
            {
                var asType = NamedType(lhs!.resultTypeName, context);
                rhs = new As
                {
                    operand = rhs,
                    localId = NextId(),
                    locator = rhs.locator,
                    asType = asType.name,
                    asTypeSpecifier = asType,
                    resultTypeName = asType.name,
                    resultTypeSpecifier = NamedType(asType.name, context),
                };
            }

            if (lhs.resultTypeName?.Name == null
                || rhs.resultTypeName?.Name == null
                || lhs.resultTypeName!.Name != rhs.resultTypeName!.Name)
            {
                UnresolvedSignature("Duration", lhs, rhs);
            }
            if (lhs.resultTypeName == DateTypeQName)
            {
                if (precision == DateTimePrecision.Year
                    || precision == DateTimePrecision.Month
                    || precision == DateTimePrecision.Week
                    || precision == DateTimePrecision.Day)
                {
                    return new DurationBetween
                    {
                        precision = precision,
                        localId = NextId(),
                        locator = context.Locator(),
                        operand = new[] { lhs, rhs },
                        precisionSpecified = true,
                        resultTypeName = IntegerTypeQName,
                        resultTypeSpecifier = NamedType(IntegerTypeQName, context)
                    };
                }
                else throw Critical($"Unit {precision.ToString()} is not allowed for operands of type {DateTypeQName}");
            }
            else if (lhs.resultTypeName == TimeTypeQName)
            {
                if (precision == DateTimePrecision.Hour
                    || precision == DateTimePrecision.Minute
                    || precision == DateTimePrecision.Second
                    || precision == DateTimePrecision.Millisecond)
                {
                    return new DurationBetween
                    {
                        precision = precision,
                        localId = NextId(),
                        locator = context.Locator(),
                        operand = new[] { lhs, rhs },
                        precisionSpecified = true,
                        resultTypeName = IntegerTypeQName,
                        resultTypeSpecifier = NamedType(IntegerTypeQName, context)
                    };
                }
                else throw Critical($"Unit {precision.ToString()} is not allowed for operands of type {DateTypeQName}");

            }
            else if (lhs.resultTypeName == DateTimeTypeQName)
            {
                return new DurationBetween
                {
                    precision = precision,
                    localId = NextId(),
                    locator = context.Locator(),
                    operand = new[] { lhs, rhs },
                    precisionSpecified = true,
                    resultTypeName = IntegerTypeQName,
                    resultTypeSpecifier = NamedType(IntegerTypeQName, context)
                };
            }
            else throw UnresolvedSignature("Duration", lhs, rhs);
        }

        public override Expression VisitEqualityExpression([NotNull] cqlParser.EqualityExpressionContext context)
        {
            var lhsChild = context.GetChild(0);
            var rhsChild = context.GetChild(2);

            var lhs = Visit(lhsChild!)!;
            var @operator = context.GetChild(1).GetText();
            var rhs = Visit(rhsChild!)!;

            #region Operand conversions

            if (lhs is Null)
            {
                if (rhs is not Null)
                {
                    lhs = new As
                    {
                        operand = lhs,
                        localId = NextId(),
                        locator = lhs.locator,
                        asType = rhs!.resultTypeName,
                        asTypeSpecifier = NamedType(rhs!.resultTypeName, context),
                        resultTypeName = rhs!.resultTypeName,
                        resultTypeSpecifier = NamedType(rhs!.resultTypeName, context),
                    };
                }
            }
            else if (rhs is Null)
            {
                var asType = NamedType(lhs!.resultTypeName, context);
                rhs = new As
                {
                    operand = rhs,
                    localId = NextId(),
                    locator = rhs.locator,
                    asType = new XmlQualifiedName(asType.name.Name),
                    asTypeSpecifier = asType,
                    resultTypeName = new XmlQualifiedName(asType.name.Name),
                    resultTypeSpecifier = NamedType(asType.name, context),
                };
            }
            else if (lhs.resultTypeName == IntegerTypeQName)
            {
                if (rhs.resultTypeName == DecimalTypeQName)
                    lhs = new ToDecimal
                    {
                        operand = lhs,
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = DecimalTypeQName,
                        resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                    };
                else if (rhs.resultTypeName == LongTypeQName)
                    lhs = new ToLong
                    {
                        operand = lhs,
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = LongTypeQName,
                        resultTypeSpecifier = NamedType(LongTypeQName, context),
                    };
                else if (rhs.resultTypeName == QuantityTypeQName)
                    lhs = new ToQuantity
                    {
                        operand = new ToDecimal
                        {
                            operand = lhs,
                            localId = NextId(),
                            locator = lhs.locator,
                            resultTypeName = DecimalTypeQName,
                            resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                        },
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = QuantityTypeQName,
                        resultTypeSpecifier = NamedType(QuantityTypeQName, context),
                    };
            }
            else if (lhs.resultTypeName == LongTypeQName)
            {
                if (rhs.resultTypeName == DecimalTypeQName)
                    lhs = new ToDecimal
                    {
                        operand = lhs,
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = DecimalTypeQName,
                        resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                    };
                else if (rhs.resultTypeName == IntegerTypeQName)
                    rhs = new ToLong
                    {
                        operand = rhs,
                        localId = NextId(),
                        locator = rhs.locator,
                        resultTypeName = LongTypeQName,
                        resultTypeSpecifier = NamedType(LongTypeQName, context),
                    };
                else if (rhs.resultTypeName == QuantityTypeQName)
                    lhs = new ToQuantity
                    {
                        operand = new ToDecimal
                        {
                            operand = lhs,
                            localId = NextId(),
                            locator = lhs.locator,
                            resultTypeName = DecimalTypeQName,
                            resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                        },
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = QuantityTypeQName,
                        resultTypeSpecifier = NamedType(QuantityTypeQName, context),
                    };
            }
            else if (lhs.resultTypeName == DecimalTypeQName)
            {
                if (rhs.resultTypeName == LongTypeQName)
                    rhs = new ToDecimal
                    {
                        operand = rhs,
                        localId = NextId(),
                        locator = rhs.locator,
                        resultTypeName = DecimalTypeQName,
                        resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                    };
                else if (rhs.resultTypeName == IntegerTypeQName)
                    rhs = new ToDecimal
                    {
                        operand = rhs,
                        localId = NextId(),
                        locator = rhs.locator,
                        resultTypeName = DecimalTypeQName,
                        resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                    };
                else if (rhs.resultTypeName == QuantityTypeQName)
                    lhs = new ToQuantity
                    {
                        operand = lhs,
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = QuantityTypeQName,
                        resultTypeSpecifier = NamedType(QuantityTypeQName, context),
                    };
            }
            else if (lhs.resultTypeName == QuantityTypeQName)
            {
                if (rhs.resultTypeName == IntegerTypeQName || rhs.resultTypeName == LongTypeQName)
                    rhs = new ToQuantity
                    {
                        operand = new ToDecimal
                        {
                            operand = rhs,
                            localId = NextId(),
                            locator = rhs.locator,
                            resultTypeName = DecimalTypeQName,
                            resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                        },
                        localId = NextId(),
                        locator = rhs.locator,
                        resultTypeName = QuantityTypeQName,
                        resultTypeSpecifier = NamedType(QuantityTypeQName, context),
                    };
                else if (rhs.resultTypeName == DecimalTypeQName)
                    rhs = new ToQuantity
                    {
                        operand = rhs,
                        localId = NextId(),
                        locator = rhs.locator,
                        resultTypeName = QuantityTypeQName,
                        resultTypeSpecifier = NamedType(QuantityTypeQName, context),
                    };
                else if (rhs.resultTypeName != QuantityTypeQName)
                    throw Critical($"Quantity can only be compared to numeric types (Integer, Long, Decimal) and Quantity types.  The type of the second operand is {rhs.resultTypeName}.");
            }
            else if (lhs.resultTypeName == DateTypeQName)
            {
                if (rhs.resultTypeName != DateTypeQName)
                    throw Critical($"Only Date values can be compared to Date values.  The type of the second operand is {rhs.resultTypeName}.");
            }
            else if (lhs.resultTypeName == DateTimeTypeQName)
            {
                if (rhs.resultTypeName != DateTimeTypeQName)
                    throw Critical($"Only DateTime values can be added to DateTime values.  The type of the second operand is {rhs.resultTypeName}.");
            }
            else if (lhs.resultTypeName == TimeTypeQName)
            {
                if (rhs.resultTypeName != TimeTypeQName)
                    throw Critical($"Only Time values can be added to Time values.  The type of the second operand is {rhs.resultTypeName}.");
            }

            #endregion

            Expression? expression = null;

            switch (@operator)
            {
                case "=":
                    expression = new Equal
                    {
                        operand = new[] { lhs, rhs },
                        resultTypeName = BooleanTypeQName,
                        resultTypeSpecifier = NamedType(BooleanTypeQName, context)
                    };
                    break;
                case "!=":
                    expression = new NotEqual
                    {
                        operand = new[] { lhs, rhs },
                        resultTypeName = BooleanTypeQName,
                        resultTypeSpecifier = NamedType(BooleanTypeQName, context)
                    };
                    break;
                case "~":
                    expression = new Equivalent
                    {
                        operand = new[] { lhs, rhs },
                        resultTypeName = BooleanTypeQName,
                        resultTypeSpecifier = NamedType(BooleanTypeQName, context)
                    };
                    break;
                case "!~":
                    expression = new Not
                    {
                        operand = new Equivalent
                        {
                            operand = new[] { lhs, rhs },
                            resultTypeName = BooleanTypeQName,
                            resultTypeSpecifier = NamedType(BooleanTypeQName, context),
                            localId = NextId(),
                            locator = context.Locator(),
                        },
                        resultTypeName = BooleanTypeQName,
                        resultTypeSpecifier = NamedType(BooleanTypeQName, context)
                    };
                    break;
                default:
                    throw Critical($"Unexpected equality operator {@operator}");

            }
            expression!.localId = NextId();
            expression.locator = context.Locator();
            return expression;
        }

        public override Expression VisitImpliesExpression([NotNull] cqlParser.ImpliesExpressionContext context)
        {
            var lhs = Visit(context.GetChild(0)!)!;
            var rhs = Visit(context.GetChild(2)!)!;

            if (lhs is Null)
                lhs = new As
                {
                    operand = lhs,
                    localId = NextId(),
                    locator = lhs.locator,
                    asType = BooleanTypeQName,
                    asTypeSpecifier = NamedType(BooleanTypeQName, context),
                    resultTypeName = BooleanTypeQName,
                    resultTypeSpecifier = NamedType(BooleanTypeQName, context),
                };
            if (rhs is Null)
                rhs = new As
                {
                    operand = rhs,
                    localId = NextId(),
                    locator = rhs.locator,
                    asType = BooleanTypeQName,
                    asTypeSpecifier = NamedType(BooleanTypeQName, context),
                    resultTypeName = BooleanTypeQName,
                    resultTypeSpecifier = NamedType(BooleanTypeQName, context),
                };


            if (lhs.resultTypeName != BooleanTypeQName
                || rhs.resultTypeName != BooleanTypeQName)
                UnresolvedSignature("Implies", lhs, rhs);
            var implies = new Implies
            {
                localId = NextId(),
                locator = context.Locator(),
                operand = new[] { lhs, rhs },
                resultTypeName = BooleanTypeQName,
                resultTypeSpecifier = NamedType(BooleanTypeQName, context),
            };
            return implies;
        }

        public override Expression VisitInequalityExpression([NotNull] cqlParser.InequalityExpressionContext context)
        {
            var lhsChild = context.GetChild(0);
            var rhsChild = context.GetChild(2);

            var lhs = Visit(lhsChild!)!;
            var @operator = context.GetChild(1).GetText();
            var rhs = Visit(rhsChild!)!;

            #region Operand conversions

            if (lhs is Null)
            {
                if (rhs is not Null)
                {
                    lhs = new As
                    {
                        operand = lhs,
                        localId = NextId(),
                        locator = lhs.locator,
                        asType = rhs!.resultTypeName,
                        asTypeSpecifier = NamedType(rhs!.resultTypeName, context),
                        resultTypeName = rhs!.resultTypeName,
                        resultTypeSpecifier = NamedType(rhs!.resultTypeName, context),
                    };
                }
            }
            else if (rhs is Null)
            {
                var asType = NamedType(lhs!.resultTypeName, context);
                rhs = new As
                {
                    operand = rhs,
                    localId = NextId(),
                    locator = rhs.locator,
                    asType = new XmlQualifiedName(asType.name.Name),
                    asTypeSpecifier = asType,
                    resultTypeName = new XmlQualifiedName(asType.name.Name),
                    resultTypeSpecifier = NamedType(asType.name, context),
                };
            }
            else if (lhs.resultTypeName == IntegerTypeQName)
            {
                if (rhs.resultTypeName == DecimalTypeQName)
                    lhs = new ToDecimal
                    {
                        operand = lhs,
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = DecimalTypeQName,
                        resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                    };
                else if (rhs.resultTypeName == LongTypeQName)
                    lhs = new ToLong
                    {
                        operand = lhs,
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = LongTypeQName,
                        resultTypeSpecifier = NamedType(LongTypeQName, context),
                    };
                else if (rhs.resultTypeName == QuantityTypeQName)
                    lhs = new ToQuantity
                    {
                        operand = new ToDecimal
                        {
                            operand = lhs,
                            localId = NextId(),
                            locator = lhs.locator,
                            resultTypeName = DecimalTypeQName,
                            resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                        },
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = QuantityTypeQName,
                        resultTypeSpecifier = NamedType(QuantityTypeQName, context),
                    };
            }
            else if (lhs.resultTypeName == LongTypeQName)
            {
                if (rhs.resultTypeName == DecimalTypeQName)
                    lhs = new ToDecimal
                    {
                        operand = lhs,
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = DecimalTypeQName,
                        resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                    };
                else if (rhs.resultTypeName == IntegerTypeQName)
                    rhs = new ToLong
                    {
                        operand = rhs,
                        localId = NextId(),
                        locator = rhs.locator,
                        resultTypeName = LongTypeQName,
                        resultTypeSpecifier = NamedType(LongTypeQName, context),
                    };
                else if (rhs.resultTypeName == QuantityTypeQName)
                    lhs = new ToQuantity
                    {
                        operand = new ToDecimal
                        {
                            operand = lhs,
                            localId = NextId(),
                            locator = lhs.locator,
                            resultTypeName = DecimalTypeQName,
                            resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                        },
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = QuantityTypeQName,
                        resultTypeSpecifier = NamedType(QuantityTypeQName, context),
                    };
            }
            else if (lhs.resultTypeName == DecimalTypeQName)
            {
                if (rhs.resultTypeName == LongTypeQName)
                    rhs = new ToDecimal
                    {
                        operand = rhs,
                        localId = NextId(),
                        locator = rhs.locator,
                        resultTypeName = DecimalTypeQName,
                        resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                    };
                else if (rhs.resultTypeName == IntegerTypeQName)
                    rhs = new ToDecimal
                    {
                        operand = rhs,
                        localId = NextId(),
                        locator = rhs.locator,
                        resultTypeName = DecimalTypeQName,
                        resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                    };
                else if (rhs.resultTypeName == QuantityTypeQName)
                    lhs = new ToQuantity
                    {
                        operand = lhs,
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = QuantityTypeQName,
                        resultTypeSpecifier = NamedType(QuantityTypeQName, context),
                    };
            }
            else if (lhs.resultTypeName == QuantityTypeQName)
            {
                if (rhs.resultTypeName == IntegerTypeQName || rhs.resultTypeName == LongTypeQName)
                    rhs = new ToQuantity
                    {
                        operand = new ToDecimal
                        {
                            operand = rhs,
                            localId = NextId(),
                            locator = rhs.locator,
                            resultTypeName = DecimalTypeQName,
                            resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                        },
                        localId = NextId(),
                        locator = rhs.locator,
                        resultTypeName = QuantityTypeQName,
                        resultTypeSpecifier = NamedType(QuantityTypeQName, context),
                    };
                else if (rhs.resultTypeName == DecimalTypeQName)
                    rhs = new ToQuantity
                    {
                        operand = rhs,
                        localId = NextId(),
                        locator = rhs.locator,
                        resultTypeName = QuantityTypeQName,
                        resultTypeSpecifier = NamedType(QuantityTypeQName, context),
                    };
                else if (rhs.resultTypeName != QuantityTypeQName)
                    throw Critical($"Quantity can only be compared to numeric types (Integer, Long, Decimal) and Quantity types.  The type of the second operand is {rhs.resultTypeName}.");
            }
            else if (lhs.resultTypeName == DateTypeQName)
            {
                if (rhs.resultTypeName != DateTypeQName)
                    throw Critical($"Only Date values can be compared to Date values.  The type of the second operand is {rhs.resultTypeName}.");
            }
            else if (lhs.resultTypeName == DateTimeTypeQName)
            {
                if (rhs.resultTypeName != DateTimeTypeQName)
                    throw Critical($"Only DateTime values can be added to DateTime values.  The type of the second operand is {rhs.resultTypeName}.");
            }
            else if (lhs.resultTypeName == TimeTypeQName)
            {
                if (rhs.resultTypeName != TimeTypeQName)
                    throw Critical($"Only Time values can be added to Time values.  The type of the second operand is {rhs.resultTypeName}.");
            }

            #endregion

            Expression? expression = null;

            switch (@operator)
            {
                case ">":
                    expression = new Greater
                    {
                        operand = new[] { lhs, rhs },
                        resultTypeName = BooleanTypeQName,
                        resultTypeSpecifier = NamedType(BooleanTypeQName, context)
                    };
                    break;
                case ">=":
                    expression = new GreaterOrEqual
                    {
                        operand = new[] { lhs, rhs },
                        resultTypeName = BooleanTypeQName,
                        resultTypeSpecifier = NamedType(BooleanTypeQName, context)
                    };
                    break;
                case "<":
                    expression = new Less
                    {
                        operand = new[] { lhs, rhs },
                        resultTypeName = BooleanTypeQName,
                        resultTypeSpecifier = NamedType(BooleanTypeQName, context)
                    };
                    break;
                case "<=":
                    expression = new LessOrEqual
                    {
                        operand = new[] { lhs, rhs },
                        resultTypeName = BooleanTypeQName,
                        resultTypeSpecifier = NamedType(BooleanTypeQName, context)
                    };
                    break;
                default:
                    throw Critical($"Unexpected inequality operator {@operator}");
            }
            expression!.localId = NextId();
            expression.locator = context.Locator();
            return expression;
        }

        public override Expression VisitMultiplicationExpressionTerm([NotNull] cqlParser.MultiplicationExpressionTermContext context)
        {
            var lhsChild = context.GetChild(0) as cqlParser.ExpressionTermContext;
            var rhsChild = context.GetChild(2) as cqlParser.ExpressionTermContext;

            var lhs = Visit(lhsChild!)!;
            var @operator = context.GetChild(1).GetText();
            var rhs = Visit(rhsChild!)!;

            #region Operand conversions

            if (lhs is Null)
            {
                if (rhs is Null)
                {
                    throw Critical($"Cannot add null to null");
                }
                else
                {
                    lhs = new As
                    {
                        operand = lhs,
                        localId = NextId(),
                        locator = lhs.locator,
                        asType = rhs!.resultTypeName,
                        asTypeSpecifier = NamedType(rhs!.resultTypeName, context),
                        resultTypeName = rhs!.resultTypeName,
                        resultTypeSpecifier = NamedType(rhs!.resultTypeName, context),
                    };
                }
            }
            else if (rhs is Null)
            {
                rhs = new As
                {
                    operand = rhs,
                    localId = NextId(),
                    locator = rhs.locator,
                    asType = lhs!.resultTypeName,
                    asTypeSpecifier = NamedType(lhs!.resultTypeName, context),
                    resultTypeName = lhs!.resultTypeName,
                    resultTypeSpecifier = NamedType(lhs!.resultTypeName, context),
                };
            }
            else if (lhs.resultTypeName == IntegerTypeQName)
            {
                if (rhs.resultTypeName == DecimalTypeQName)
                    lhs = new ToDecimal
                    {
                        operand = lhs,
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = DecimalTypeQName,
                        resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                    };
                else if (rhs.resultTypeName == LongTypeQName)
                    lhs = new ToLong
                    {
                        operand = lhs,
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = LongTypeQName,
                        resultTypeSpecifier = NamedType(LongTypeQName, context),
                    };
                else if (rhs.resultTypeName == QuantityTypeQName)
                    lhs = new ToQuantity
                    {
                        operand = new ToDecimal
                        {
                            operand = lhs,
                            localId = NextId(),
                            locator = lhs.locator,
                            resultTypeName = DecimalTypeQName,
                            resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                        },
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = QuantityTypeQName,
                        resultTypeSpecifier = NamedType(QuantityTypeQName, context),
                    };
            }
            else if (lhs.resultTypeName == LongTypeQName)
            {
                if (rhs.resultTypeName == DecimalTypeQName)
                    lhs = new ToDecimal
                    {
                        operand = lhs,
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = DecimalTypeQName,
                        resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                    };
                else if (rhs.resultTypeName == IntegerTypeQName)
                    rhs = new ToLong
                    {
                        operand = rhs,
                        localId = NextId(),
                        locator = rhs.locator,
                        resultTypeName = LongTypeQName,
                        resultTypeSpecifier = NamedType(LongTypeQName, context),
                    };
                else if (rhs.resultTypeName == QuantityTypeQName)
                    lhs = new ToQuantity
                    {
                        operand = new ToDecimal
                        {
                            operand = lhs,
                            localId = NextId(),
                            locator = lhs.locator,
                            resultTypeName = DecimalTypeQName,
                            resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                        },
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = QuantityTypeQName,
                        resultTypeSpecifier = NamedType(QuantityTypeQName, context),
                    };
            }
            else if (lhs.resultTypeName == DecimalTypeQName)
            {
                if (rhs.resultTypeName == LongTypeQName)
                    rhs = new ToDecimal
                    {
                        operand = rhs,
                        localId = NextId(),
                        locator = rhs.locator,
                        resultTypeName = DecimalTypeQName,
                        resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                    };
                else if (rhs.resultTypeName == IntegerTypeQName)
                    rhs = new ToDecimal
                    {
                        operand = rhs,
                        localId = NextId(),
                        locator = rhs.locator,
                        resultTypeName = DecimalTypeQName,
                        resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                    };
                else if (rhs.resultTypeName == QuantityTypeQName)
                    lhs = new ToQuantity
                    {
                        operand = lhs,
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = QuantityTypeQName,
                        resultTypeSpecifier = NamedType(QuantityTypeQName, context),
                    };
            }
            else if (lhs.resultTypeName == QuantityTypeQName)
            {
                if (rhs.resultTypeName == IntegerTypeQName || rhs.resultTypeName == LongTypeQName)
                    rhs = new ToQuantity
                    {
                        operand = new ToDecimal
                        {
                            operand = rhs,
                            localId = NextId(),
                            locator = rhs.locator,
                            resultTypeName = DecimalTypeQName,
                            resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                        },
                        localId = NextId(),
                        locator = rhs.locator,
                        resultTypeName = QuantityTypeQName,
                        resultTypeSpecifier = NamedType(QuantityTypeQName, context),
                    };
                else if (rhs.resultTypeName == DecimalTypeQName)
                    rhs = new ToQuantity
                    {
                        operand = rhs,
                        localId = NextId(),
                        locator = rhs.locator,
                        resultTypeName = QuantityTypeQName,
                        resultTypeSpecifier = NamedType(QuantityTypeQName, context),
                    };
                else if (rhs.resultTypeName != QuantityTypeQName)
                    throw Critical($"Quantity can only be added to numeric types (Integer, Long, Decimal) and Quantity types.  The type of the second operand is {rhs.resultTypeName}.");
            }
            else
                throw Critical($"Multiplication is only defined for numeric and quantity types.  The type of the first operand is {lhs.resultTypeName}.");

            #endregion

            Expression? expression = null;

            switch (@operator)
            {
                case "*":
                    expression = new Multiply
                    {
                        operand = new[] { lhs, rhs },
                        resultTypeName = lhs.resultTypeName,
                        resultTypeSpecifier = NamedType(lhs.resultTypeName, context)
                    };
                    break;
                case "/":
                    // When invoked with Integer or Long arguments, the arguments will be implicitly converted to Decimal.
                    if (lhs.resultTypeName == IntegerTypeQName
                        || lhs.resultTypeName == LongTypeQName)
                    {
                        if (lhs is As @as)
                        {
                            @as.asType = DecimalTypeQName;
                            @as.asTypeSpecifier = NamedType(DecimalTypeQName, context);
                            @as.resultTypeName = DecimalTypeQName;
                            @as.resultTypeSpecifier = NamedType(DecimalTypeQName, context);
                        }
                        else
                        {
                            lhs = new ToDecimal
                            {
                                operand = lhs,
                                localId = NextId(),
                                locator = lhs.locator,
                                resultTypeName = DecimalTypeQName,
                                resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                            };
                        }
                    }
                    if (rhs.resultTypeName == IntegerTypeQName
                        || rhs.resultTypeName == LongTypeQName)
                    {
                        if (rhs is As @as)
                        {
                            @as.asType = DecimalTypeQName;
                            @as.asTypeSpecifier = NamedType(DecimalTypeQName, context);
                            @as.resultTypeName = DecimalTypeQName;
                            @as.resultTypeSpecifier = NamedType(DecimalTypeQName, context);
                        }
                        else
                        {
                            rhs = new ToDecimal
                            {
                                operand = rhs,
                                localId = NextId(),
                                locator = rhs.locator,
                                resultTypeName = DecimalTypeQName,
                                resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                            };
                        }
                    }
                    expression = new Divide
                    {
                        operand = new[] { lhs, rhs },
                        resultTypeName = lhs.resultTypeName,
                        resultTypeSpecifier = NamedType(lhs.resultTypeName, context)
                    };
                    break;
                case "div":
                    expression = new TruncatedDivide
                    {
                        operand = new[] { lhs, rhs },
                        resultTypeName = lhs.resultTypeName,
                        resultTypeSpecifier = NamedType(lhs.resultTypeName, context)
                    };
                    break;
                case "mod":
                    expression = new Modulo
                    {
                        operand = new[] { lhs, rhs },
                        resultTypeName = lhs.resultTypeName,
                        resultTypeSpecifier = NamedType(lhs.resultTypeName, context)
                    };
                    break;
                default:
                    throw Critical($"Unexpected arithmetic operator {@operator}");

            }
            expression!.localId = NextId();
            expression.locator = context.Locator();
            return expression;
        }

        public override Expression VisitOrExpression([NotNull] cqlParser.OrExpressionContext context)
        {
            var lhs = Visit(context.GetChild(0)!)!;
            var @operator = context.GetChild(1)!.GetText();
            var rhs = Visit(context.GetChild(2)!)!;

            if (lhs is Null)
                lhs = new As
                {
                    operand = lhs,
                    localId = NextId(),
                    locator = lhs.locator,
                    asType = BooleanTypeQName,
                    asTypeSpecifier = NamedType(BooleanTypeQName, context),
                    resultTypeName = BooleanTypeQName,
                    resultTypeSpecifier = NamedType(BooleanTypeQName, context),
                };
            if (rhs is Null)
                rhs = new As
                {
                    operand = rhs,
                    localId = NextId(),
                    locator = rhs.locator,
                    asType = BooleanTypeQName,
                    asTypeSpecifier = NamedType(BooleanTypeQName, context),
                    resultTypeName = BooleanTypeQName,
                    resultTypeSpecifier = NamedType(BooleanTypeQName, context),
                };

            if (lhs.resultTypeName != BooleanTypeQName
                || rhs.resultTypeName != BooleanTypeQName)
                UnresolvedSignature(CultureInfo.InvariantCulture.TextInfo.ToTitleCase(@operator), lhs, rhs);
            switch (@operator)
            {
                case "or":
                    var or = new Or
                    {
                        localId = NextId(),
                        locator = context.Locator(),
                        operand = new[] { lhs, rhs },
                        resultTypeName = BooleanTypeQName,
                        resultTypeSpecifier = NamedType(BooleanTypeQName, context),
                    };
                    return or;
                case "xor":
                    var xor = new Xor
                    {
                        localId = NextId(),
                        locator = context.Locator(),
                        operand = new[] { lhs, rhs },
                        resultTypeName = BooleanTypeQName,
                        resultTypeSpecifier = NamedType(BooleanTypeQName, context),
                    };
                    return xor;
                default:
                    throw Critical($"Unexpected operator {@operator}.");
            }
        }

        public override Expression VisitPowerExpressionTerm([NotNull] cqlParser.PowerExpressionTermContext context)
        {
            var lhsChild = context.GetChild(0) as cqlParser.ExpressionTermContext;
            var rhsChild = context.GetChild(2) as cqlParser.ExpressionTermContext;

            var lhs = Visit(lhsChild!)!;
            var @operator = context.GetChild(1).GetText();
            var rhs = Visit(rhsChild!)!;

            #region Operand conversions

            if (lhs is Null)
            {
                if (rhs is Null)
                {
                    throw Critical($"Cannot add null to null");
                }
                else
                {
                    lhs = new As
                    {
                        operand = lhs,
                        localId = NextId(),
                        locator = lhs.locator,
                        asType = rhs!.resultTypeName,
                        asTypeSpecifier = NamedType(rhs!.resultTypeName, context),
                        resultTypeName = rhs!.resultTypeName,
                        resultTypeSpecifier = NamedType(rhs!.resultTypeName, context),
                    };
                }
            }
            else if (rhs is Null)
            {
                rhs = new As
                {
                    operand = rhs,
                    localId = NextId(),
                    locator = rhs.locator,
                    asType = lhs!.resultTypeName,
                    asTypeSpecifier = NamedType(lhs!.resultTypeName, context),
                    resultTypeName = lhs!.resultTypeName,
                    resultTypeSpecifier = NamedType(lhs!.resultTypeName, context),
                };
            }
            else if (lhs.resultTypeName == IntegerTypeQName)
            {
                if (rhs.resultTypeName == DecimalTypeQName)
                    lhs = new ToDecimal
                    {
                        operand = lhs,
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = DecimalTypeQName,
                        resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                    };
                else if (rhs.resultTypeName == LongTypeQName)
                    lhs = new ToLong
                    {
                        operand = lhs,
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = LongTypeQName,
                        resultTypeSpecifier = NamedType(LongTypeQName, context),
                    };
            }
            else if (lhs.resultTypeName == LongTypeQName)
            {
                if (rhs.resultTypeName == DecimalTypeQName)
                    lhs = new ToDecimal
                    {
                        operand = lhs,
                        localId = NextId(),
                        locator = lhs.locator,
                        resultTypeName = DecimalTypeQName,
                        resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                    };
                else if (rhs.resultTypeName == IntegerTypeQName)
                    rhs = new ToLong
                    {
                        operand = rhs,
                        localId = NextId(),
                        locator = rhs.locator,
                        resultTypeName = LongTypeQName,
                        resultTypeSpecifier = NamedType(LongTypeQName, context),
                    };
            }
            else if (lhs.resultTypeName == DecimalTypeQName)
            {
                if (rhs.resultTypeName == LongTypeQName)
                    rhs = new ToDecimal
                    {
                        operand = rhs,
                        localId = NextId(),
                        locator = rhs.locator,
                        resultTypeName = DecimalTypeQName,
                        resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                    };
                else if (rhs.resultTypeName == IntegerTypeQName)
                    rhs = new ToDecimal
                    {
                        operand = rhs,
                        localId = NextId(),
                        locator = rhs.locator,
                        resultTypeName = DecimalTypeQName,
                        resultTypeSpecifier = NamedType(DecimalTypeQName, context),
                    };
            }
            else
                throw Critical($"Multiplication is only defined for numeric and quantity types.  The type of the first operand is {lhs.resultTypeName}.");

            #endregion

            var expression = new Power
            {
                operand = new[] { lhs, rhs },
                resultTypeName = lhs.resultTypeName,
                resultTypeSpecifier = NamedType(lhs.resultTypeName, context),
                localId = NextId(),
                locator = context.Locator(),
            };
            return expression;
        }

        public override Expression VisitTimingExpression([NotNull] cqlParser.TimingExpressionContext context)
        {
            var expressionChildren = context.expression();
            var lhs = Visit(expressionChildren[0]);
            var rhs = Visit(expressionChildren[1]);

            return context.intervalOperatorPhrase() switch
            {
                cqlParser.ConcurrentWithIntervalOperatorPhraseContext ctx => HandleConcurrentWith(ctx, lhs, rhs),
                cqlParser.IncludesIntervalOperatorPhraseContext ctx => HandleIncludes(ctx, lhs, rhs),
                cqlParser.IncludedInIntervalOperatorPhraseContext ctx => HandleIncludedIn(ctx, lhs, rhs),
                cqlParser.BeforeOrAfterIntervalOperatorPhraseContext ctx => throw new NotImplementedException(),
                cqlParser.WithinIntervalOperatorPhraseContext ctx => HandleWithin(ctx, lhs, rhs),
                cqlParser.MeetsIntervalOperatorPhraseContext ctx => HandleMeets(ctx, lhs, rhs),
                cqlParser.OverlapsIntervalOperatorPhraseContext ctx => HandleOverlaps(ctx, lhs, rhs),
                cqlParser.StartsIntervalOperatorPhraseContext ctx => HandleStarts(ctx, lhs, rhs),
                cqlParser.EndsIntervalOperatorPhraseContext ctx => HandleEnds(ctx, lhs, rhs),

                _ => throw new NotImplementedException()
            };

            /*
            intervalOperatorPhrase
            | ('starts' | 'ends' | 'occurs')? quantityOffset? temporalRelationship dateTimePrecisionSpecifier? ('start' | 'end')?   #beforeOrAfterIntervalOperatorPhrase
            */

            //| ('starts' | 'ends' | 'occurs')? 'properly'? 'within' quantity 'of' ('start' | 'end')?                                 #withinIntervalOperatorPhrase
            Expression HandleWithin(cqlParser.WithinIntervalOperatorPhraseContext context,
                 Expression lhs,
                 Expression rhs)
            {
                bool properly = false;
                var index = 0;

                var child = context.GetChild(index);

                var kw0 = Keyword.Parse(child.GetText());
                if (kw0.Length == 1)
                {
                    var keyword = kw0[0];
                    if (keyword == CqlKeyword.Starts)
                    {
                        var lhsPointType = PointType(lhs.resultTypeSpecifier);
                        lhs = new Start
                        {
                            operand = lhs,
                            localId = NextId(),
                            locator = context.GetChild(0).Locator()!,
                            resultTypeSpecifier = lhsPointType,
                            resultTypeName = lhsPointType?.resultTypeName
                        };
                    }
                    else if (keyword == CqlKeyword.Ends)
                    {
                        var lhsPointType = PointType(lhs.resultTypeSpecifier);
                        lhs = new End
                        {
                            operand = lhs,
                            localId = NextId(),
                            locator = context.GetChild(0).Locator()!,
                            resultTypeSpecifier = lhsPointType,
                            resultTypeName = lhsPointType?.resultTypeName
                        };
                    }
                    else if (keyword == CqlKeyword.Properly)
                    {
                        properly = true;
                    }
                }
                index++;
                child = context.GetChild(index);
                var kw1 = Keyword.Parse(child.GetText());
                if (kw1.Length == 1)
                {
                    var keyword = kw1[0];
                    if (keyword == CqlKeyword.Properly)
                    {
                        properly = true;
                    }
                }
                index++;
                child = context.GetChild(index);
                if (child is not cqlParser.QuantityContext)
                    index++;
                child = context.GetChild(index);
                var quantityTuple = context.quantity().Parse();
                var quantity = new Quantity
                {
                    localId = NextId(),
                    locator = child.Locator(),
                    resultTypeName = QuantityTypeQName,
                    resultTypeSpecifier = NamedType(QuantityTypeQName, context),
                    value = quantityTuple.value,
                    valueSpecified = true,
                    unit = quantityTuple.unit,
                };
                index += 2;
                if (index < context.ChildCount)
                {
                    child = context.GetChild(index);
                    var kwi = Keyword.Parse(child.GetText());
                    if (kwi.Length == 1)
                    {
                        var keyword = kwi[0];
                        if (keyword == CqlKeyword.Start)
                        {
                            var rhsPointType = PointType(rhs.resultTypeSpecifier);
                            rhs = new Start
                            {
                                operand = rhs,
                                localId = NextId(),
                                locator = context.GetChild(0).Locator()!,
                                resultTypeSpecifier = rhsPointType,
                                resultTypeName = rhsPointType?.resultTypeName
                            };
                        }
                        else if (keyword == CqlKeyword.Ends)
                        {
                            var rhsPointType = PointType(rhs.resultTypeSpecifier);
                            rhs = new End
                            {
                                operand = rhs,
                                localId = NextId(),
                                locator = context.GetChild(0).Locator()!,
                                resultTypeSpecifier = rhsPointType,
                                resultTypeName = rhsPointType?.resultTypeName
                            };
                        }
                    }
                }
                if (properly)
                {
                    var subtract = new Subtract
                    {
                        operand = new[] { rhs, quantity },
                        localId = NextId(),
                        locator = rhs.locator,
                        resultTypeSpecifier = rhs.resultTypeSpecifier,
                        resultTypeName = rhs.resultTypeName,
                    };
                    var add = new Add
                    {
                        operand = new[] { rhs, quantity },
                        localId = NextId(),
                        locator = rhs.locator,
                        resultTypeSpecifier = rhs.resultTypeSpecifier,
                        resultTypeName = rhs.resultTypeName,
                    };
                    rhs = new Hl7.Cql.Elm.Interval
                    {
                        low = subtract,
                        high = add,
                        lowClosed = false,
                        highClosed = false,
                        localId = NextId(),
                        locator = rhs.locator,
                        resultTypeSpecifier = IntervalType(subtract.resultTypeSpecifier!, context),
                    };
                    if (lhs is Elm.Interval)
                    {
                        rhs = new Elm.ToList
                        {
                            localId = NextId(),
                            locator = rhs.locator,
                            resultTypeSpecifier = ListType(lhs.resultTypeSpecifier!, context),
                            operand = rhs,
                        };
                    }
                    var @in = new In
                    {
                        localId = NextId(),
                        locator = context.Locator(),
                        operand = new[] { lhs, rhs },
                        resultTypeName = BooleanTypeQName,
                        resultTypeSpecifier = NamedType(BooleanTypeQName, context)
                    };
                    return @in;
                }
                if (properly || !properly)
                    throw UnresolvedSignature("Within", lhs, rhs);
                throw UnresolvedSignature("Within", lhs, rhs);
            }

            //| ('starts' | 'ends' | 'occurs')? 'properly'? ('during' | 'included in') dateTimePrecisionSpecifier?                    #includedInIntervalOperatorPhrase
            Expression HandleIncludedIn(cqlParser.IncludedInIntervalOperatorPhraseContext context,
                Expression lhs,
                Expression rhs)
            {
                bool properly = false;
                DateTimePrecision? dtp = null;

                var index = 0;
                var kw0 = Keyword.Parse(context.GetChild(index).GetText());
                if (kw0.Length == 1)
                {
                    var keyword = kw0[0];
                    if (keyword == CqlKeyword.Starts)
                    {
                        var lhsPointType = PointType(lhs.resultTypeSpecifier);
                        lhs = new Start
                        {
                            operand = lhs,
                            localId = NextId(),
                            locator = context.GetChild(0).Locator()!,
                            resultTypeSpecifier = lhsPointType,
                            resultTypeName = lhsPointType?.resultTypeName
                        };
                    }
                    else if (keyword == CqlKeyword.Ends)
                    {
                        var lhsPointType = PointType(lhs.resultTypeSpecifier);
                        lhs = new End
                        {
                            operand = lhs,
                            localId = NextId(),
                            locator = context.GetChild(0).Locator()!,
                            resultTypeSpecifier = lhsPointType,
                            resultTypeName = lhsPointType?.resultTypeName
                        };
                    }
                    else if (keyword == CqlKeyword.Properly)
                    {
                        properly = true;
                    }
                }
                index += 1;
                if (index < context.ChildCount)
                {
                    var child = context.GetChild(index);
                    if (child is cqlParser.DateTimePrecisionSpecifierContext dtpc)
                    {
                        dtp = dtpc.dateTimePrecision().Parse();
                    }
                    else
                    {
                        var kw1 = Keyword.Parse(child.GetText());
                        if (kw1.Length == 1)
                        {
                            var keyword = kw1[0];
                            if (keyword == CqlKeyword.Properly)
                            {
                                properly = true;
                            }
                        }
                    }
                    index += 1;
                }
                if (index < context.ChildCount)
                {
                    var child = context.GetChild(index);
                    if (child is cqlParser.DateTimePrecisionSpecifierContext dtpc)
                    {
                        dtp = dtpc.dateTimePrecision().Parse();
                    }
                    index += 1;
                }
                if (index < context.ChildCount)
                {
                    var child = context.GetChild(index);
                    if (child is cqlParser.DateTimePrecisionSpecifierContext dtpc)
                    {
                        dtp = dtpc.dateTimePrecision().Parse();
                    }
                    index += 1;
                }
                return properly switch
                {
                    true => new ProperIncludedIn
                    {
                        localId = NextId(),
                        locator = context.Locator(),
                        operand = new[] { lhs, rhs },
                        precision = dtp ?? default,
                        precisionSpecified = dtp.HasValue,
                        resultTypeName = BooleanTypeQName,
                        resultTypeSpecifier = NamedType(BooleanTypeQName, context),
                    },
                    _ => new IncludedIn
                    {
                        localId = NextId(),
                        locator = context.Locator(),
                        operand = new[] { lhs, rhs },
                        precision = dtp ?? default,
                        precisionSpecified = dtp.HasValue,
                        resultTypeName = BooleanTypeQName,
                        resultTypeSpecifier = NamedType(BooleanTypeQName, context),
                    }
                };
            }

            //| 'overlaps'('before' | 'after') ? dateTimePrecisionSpecifier ?                                                          #overlapsIntervalOperatorPhrase
            Expression HandleOverlaps(cqlParser.OverlapsIntervalOperatorPhraseContext context,
                Expression lhs,
                Expression rhs)
            {
                DateTimePrecision? dtPrecision =
                    context.dateTimePrecisionSpecifier() is { } p ?
                        p.dateTimePrecision().Parse() : null;

                CqlKeyword? boa = context.ChildCount > 1 && context.GetChild(1) is ITerminalNode term ?
                    Keyword.Parse(term.GetText())[0] : null;

                BinaryExpression result = boa switch
                {
                    null => new Overlaps
                    {
                        precisionSpecified = dtPrecision is not null,
                        precision = dtPrecision ?? default,
                    },

                    CqlKeyword.Before => new OverlapsBefore
                    {
                        precisionSpecified = dtPrecision is not null,
                        precision = dtPrecision ?? default,
                    },
                    CqlKeyword.After => new OverlapsAfter
                    {
                        precisionSpecified = dtPrecision is not null,
                        precision = dtPrecision ?? default,
                    },
                    _ => throw UnresolvedSignature("Overlaps", lhs, rhs)
                };

                result.operand = new[] { lhs, rhs };
                result.resultTypeName = BooleanTypeQName;
                result.resultTypeSpecifier = NamedType(BooleanTypeQName, context);
                result.localId = NextId();
                result.locator = context.Locator();

                return result;
            }
        }

        // | 'meets'('before' | 'after') ? dateTimePrecisionSpecifier ?                                                             #meetsIntervalOperatorPhrase
        private Expression HandleMeets(cqlParser.MeetsIntervalOperatorPhraseContext context,
                Expression lhs,
                Expression rhs)
        {
            DateTimePrecision? precision = context.dateTimePrecisionSpecifier()?.dateTimePrecision().Parse();

            CqlKeyword? boa = context.ChildCount > 1 && context.GetChild(1) is ITerminalNode term ?
                Keyword.Parse(term.GetText())[0] : null;

            BinaryExpression result = boa switch
            {
                null => new Meets
                {
                    precisionSpecified = precision is not null,
                    precision = precision ?? default,
                },
                CqlKeyword.Before => new MeetsBefore
                {
                    precisionSpecified = precision is not null,
                    precision = precision ?? default,
                },
                CqlKeyword.After => new MeetsAfter
                {
                    precisionSpecified = precision is not null,
                    precision = precision ?? default,
                },
                _ => throw UnresolvedSignature("Meets", lhs, rhs)
            };

            result.operand = new[] { lhs, rhs };
            result.resultTypeName = BooleanTypeQName;
            result.resultTypeSpecifier = NamedType(BooleanTypeQName, context);
            result.localId = NextId();
            result.locator = context.Locator();

            return result;
        }

        //| 'starts' dateTimePrecisionSpecifier?                                                                                  #startsIntervalOperatorPhrase
        private Expression HandleStarts(cqlParser.StartsIntervalOperatorPhraseContext context,
                Expression lhs,
                Expression rhs)
        {
            DateTimePrecision? dtPrecision = context.dateTimePrecisionSpecifier() is { } p ?
                p.dateTimePrecision().Parse() : null;

            return new Starts
            {
                localId = NextId(),
                locator = context.Locator(),
                operand = new[] { lhs, rhs },
                precisionSpecified = dtPrecision is not null,
                precision = dtPrecision ?? default,
                resultTypeName = BooleanTypeQName,
                resultTypeSpecifier = NamedType(BooleanTypeQName, context),
            };
        }

        // | 'ends' dateTimePrecisionSpecifier?                                                                                    #endsIntervalOperatorPhrase
        private Expression HandleEnds(cqlParser.EndsIntervalOperatorPhraseContext context,
                Expression lhs,
                Expression rhs)
        {
            DateTimePrecision? dtPrecision = context.dateTimePrecisionSpecifier() is { } p ?
                p.dateTimePrecision().Parse() : null;

            return new Ends
            {
                localId = NextId(),
                locator = context.Locator(),
                operand = new[] { lhs, rhs },
                precisionSpecified = dtPrecision is not null,
                precision = dtPrecision ?? default,
                resultTypeName = BooleanTypeQName,
                resultTypeSpecifier = NamedType(BooleanTypeQName, context),
            };
        }

        //| 'properly'? 'includes' dateTimePrecisionSpecifier? ('start' | 'end')?
        private Expression HandleIncludes(cqlParser.IncludesIntervalOperatorPhraseContext context,
                Expression lhs,
                Expression rhs)
        {
            var firstKeyword = Keyword.Parse(context.GetChild(0).GetText());
            if (firstKeyword.Length != 1)
                throw UnresolvedSignature("Includes", lhs, rhs);
            bool properly;
            int index;
            if (firstKeyword[0] == CqlKeyword.Properly)
            {
                properly = true;
                index = 2;
            }
            else if (firstKeyword[0] == CqlKeyword.Includes)
            {
                properly = false;
                index = 1;
            }
            else
                throw UnresolvedSignature("Includes", lhs, rhs);

            var next = context.GetChild(index);
            DateTimePrecision? precision;
            if (next is cqlParser.DateTimePrecisionSpecifierContext dto)
            {
                precision = dto.dateTimePrecision().Parse();
                index += 1;
            }
            else
                precision = null;

            if (index < context.ChildCount)
            {
                var rightPoint = Keyword.Parse(context.GetChild(index).GetText());
                var rhsPointLocator = (context.GetChild(index) as ParserRuleContext)?.Locator();
                if (rightPoint.Length == 1)
                {
                    var rhsPointType = PointType(rhs.resultTypeSpecifier);
                    if (rightPoint[0] == CqlKeyword.Start)
                    {
                        rhs = new Start
                        {
                            operand = rhs,
                            localId = NextId(),
                            locator = rhsPointLocator,
                            resultTypeSpecifier = rhsPointType,
                            resultTypeName = rhsPointType?.resultTypeName
                        };
                    }
                    else if (rightPoint[0] == CqlKeyword.End)
                    {
                        rhs = new End
                        {
                            operand = rhs,
                            localId = NextId(),
                            locator = rhsPointLocator,
                            resultTypeSpecifier = rhsPointType,
                            resultTypeName = rhsPointType?.resultTypeName
                        };
                    }
                    else throw UnresolvedSignature("Includes", lhs, rhs);
                }
                else throw UnresolvedSignature("Includes", lhs, rhs);
            }

            BinaryExpression includes = properly
              ? new ProperIncludes() { precision = precision ?? default, precisionSpecified = precision.HasValue }
              : new Includes() { precision = precision ?? default, precisionSpecified = precision.HasValue };
            includes.localId = NextId();
            includes.locator = context.Locator();
            includes.operand = new[] { lhs, rhs };
            includes.resultTypeName = BooleanTypeQName;
            includes.resultTypeSpecifier = NamedType(BooleanTypeQName, context);
            return includes;

        }

        //: ('starts' | 'ends' | 'occurs')? 'same' dateTimePrecision? (relativeQualifier | 'as') ('start' | 'end')?               #concurrentWithIntervalOperatorPhrase
        private Expression HandleConcurrentWith(cqlParser.ConcurrentWithIntervalOperatorPhraseContext context,
                Expression lhs,
                Expression rhs)
        {
            if (context.ChildCount > 3)
            {
                var firstKeyword = Keyword.Parse(context.GetChild(0).GetText());
                int index;
                CqlKeyword[] lhsPoint;
                string? lhsPointLocator;
                if (firstKeyword.Length == 1 && firstKeyword[0] == CqlKeyword.Same)
                {
                    index = 1;
                    lhsPoint = new[] { CqlKeyword.Occurs };
                    lhsPointLocator = null;
                }
                else
                {
                    lhsPoint = firstKeyword!;
                    lhsPointLocator = (context.GetChild(0) as ParserRuleContext)?.Locator();
                    index = 2;
                }

                var precision = context.dateTimePrecision().Parse();
                index += 1;
                var qualifier = Keyword.Parse(context.GetChild(index).GetText());
                index += 1;

                CqlKeyword[] rhsPoint;
                string? rhsPointLocator;
                if (index < context.ChildCount)
                {
                    rhsPoint = Keyword.Parse(context.GetChild(index).GetText());
                    rhsPointLocator = (context.GetChild(index) as ParserRuleContext)?.Locator();
                }
                else
                {
                    rhsPoint = new[] { CqlKeyword.Occurs };
                    rhsPointLocator = null;
                }

                if (lhsPoint?.Length == 1)
                {
                    var lhsPointType = PointType(lhs.resultTypeSpecifier);
                    if (lhsPoint[0] == CqlKeyword.Starts)
                    {
                        lhs = new Start
                        {
                            operand = lhs,
                            localId = NextId(),
                            locator = lhsPointLocator,
                            resultTypeSpecifier = lhsPointType,
                            resultTypeName = lhsPointType?.resultTypeName
                        };

                    }
                    else if (lhsPoint[0] == CqlKeyword.Ends)
                    {
                        lhs = new End
                        {
                            operand = lhs,
                            localId = NextId(),
                            locator = lhsPointLocator,
                            resultTypeSpecifier = lhsPointType,
                            resultTypeName = lhsPointType?.resultTypeName
                        };
                    }
                    if (rhsPoint![0] == CqlKeyword.Occurs)
                    {
                        lhs = new Elm.Interval
                        {
                            low = lhs,
                            high = lhs,
                            localId = NextId(),
                            locator = lhsPointLocator,
                            resultTypeSpecifier = IntervalType(lhsPointType!, context),
                        };
                    }
                }
                if (rhsPoint?.Length == 1)
                {
                    var rhsPointType = PointType(rhs.resultTypeSpecifier);
                    if (rhsPoint[0] == CqlKeyword.Start)
                    {
                        rhs = new Start
                        {
                            operand = rhs,
                            localId = NextId(),
                            locator = rhsPointLocator,
                            resultTypeSpecifier = rhsPointType,
                            resultTypeName = rhsPointType?.resultTypeName
                        };
                    }
                    else if (rhsPoint[0] == CqlKeyword.End)
                    {
                        rhs = new End
                        {
                            operand = rhs,
                            localId = NextId(),
                            locator = lhsPointLocator,
                            resultTypeSpecifier = rhsPointType,
                            resultTypeName = rhsPointType?.resultTypeName
                        };
                    }
                    if (lhsPoint![0] == CqlKeyword.Occurs)
                    {
                        rhs = new Elm.Interval
                        {
                            low = rhs,
                            high = rhs,
                            localId = NextId(),
                            locator = rhsPointLocator,
                            resultTypeSpecifier = IntervalType(rhsPointType!, context),
                        };
                    }
                }

                if (qualifier.Length == 2)
                {
                    if (qualifier[1] == CqlKeyword.Before)
                    {
                        var sameOrBefore = new SameOrBefore
                        {
                            localId = NextId(),
                            locator = context.Locator(),
                            precision = precision,
                            precisionSpecified = true,
                            operand = new[] { lhs, rhs },
                            resultTypeName = BooleanTypeQName,
                            resultTypeSpecifier = NamedType(BooleanTypeQName, context),
                        };
                        return sameOrBefore;
                    }
                    else if (qualifier[1] == CqlKeyword.After)
                    {
                        var sameOrAfter = new SameOrAfter
                        {
                            localId = NextId(),
                            locator = context.Locator(),
                            precision = precision,
                            precisionSpecified = true,
                            operand = new[] { lhs, rhs },
                            resultTypeName = BooleanTypeQName,
                            resultTypeSpecifier = NamedType(BooleanTypeQName, context),
                        };
                        return sameOrAfter;
                    }
                    else throw UnresolvedSignature("SameAs", lhs, rhs);
                }
                else if (qualifier.Length == 1 && qualifier[0] == CqlKeyword.As)
                {
                    var same = new SameAs
                    {
                        localId = NextId(),
                        locator = context.Locator(),
                        precision = precision,
                        precisionSpecified = true,
                        operand = new[] { lhs, rhs },
                        resultTypeName = BooleanTypeQName,
                        resultTypeSpecifier = NamedType(BooleanTypeQName, context),
                    };
                    return same;
                }
                else throw UnresolvedSignature("SameAs", lhs, rhs);
            }
            else if (context.ChildCount == 3)
            {
                var precision = context.dateTimePrecision().Parse();
                var qualifier = Keyword.Parse(context.GetChild(2).GetText());
                if (qualifier.Length == 2)
                {
                    if (qualifier[1] == CqlKeyword.Before)
                    {
                        var sameOrBefore = new SameOrBefore
                        {
                            localId = NextId(),
                            locator = context.Locator(),
                            precision = precision,
                            precisionSpecified = true,
                            operand = new[] { lhs, rhs },
                            resultTypeName = BooleanTypeQName,
                            resultTypeSpecifier = NamedType(BooleanTypeQName, context),
                        };
                        return sameOrBefore;
                    }
                    else if (qualifier[1] == CqlKeyword.After)
                    {
                        var sameOrAfter = new SameOrAfter
                        {
                            localId = NextId(),
                            locator = context.Locator(),
                            precision = precision,
                            precisionSpecified = true,
                            operand = new[] { lhs, rhs },
                            resultTypeName = BooleanTypeQName,
                            resultTypeSpecifier = NamedType(BooleanTypeQName, context),
                        };
                        return sameOrAfter;
                    }
                    else throw UnresolvedSignature("SameAs", lhs, rhs);
                }
                else if (qualifier.Length == 1 && qualifier[0] == CqlKeyword.As)
                {
                    var same = new SameAs
                    {
                        localId = NextId(),
                        locator = context.Locator(),
                        precision = precision,
                        precisionSpecified = true,
                        operand = new[] { lhs, rhs },
                        resultTypeName = BooleanTypeQName,
                        resultTypeSpecifier = NamedType(BooleanTypeQName, context),
                    };
                    return same;
                }
                else throw UnresolvedSignature("SameAs", lhs, rhs);
            }
            else throw UnresolvedSignature("SameAs", lhs, rhs);


        }

        //   expression ('is' | 'as') typeSpecifier  
        public override Expression VisitTypeExpression([NotNull] cqlParser.TypeExpressionContext context)
        {
            var lhs = Visit(context.GetChild(0)!)!;
            var @operator = context.GetChild(1)!.GetText();
            var rhs = TypeSpecifierVisitor.Visit(context.GetChild(2)!)!;

            XmlQualifiedName? rhsName = null;
            if (rhs is NamedTypeSpecifier nts && nts.name != null)
                rhsName = nts.name;
            Expression? expression = @operator switch
            {
                "is" => new Is
                {
                    isType = rhsName,
                    isTypeSpecifier = rhs,
                    localId = NextId(),
                    locator = context.Locator(),
                    operand = lhs,
                    resultTypeName = BooleanTypeQName,
                    resultTypeSpecifier = NamedType(BooleanTypeQName, context),
                },
                "as" => new As
                {
                    asType = rhsName,
                    asTypeSpecifier = rhs,
                    localId = NextId(),
                    locator = context.Locator(),
                    operand = lhs,
                    resultTypeName = rhsName,
                    resultTypeSpecifier = rhs,
                },
                _ => null
            };
            if (expression == null)
                throw Critical($"Unexpected operator {@operator}");
            else
                return expression;
        }
    }
}
