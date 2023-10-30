using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Linq;
using System.Xml;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal partial class ExpressionVisitor
    {
        //   expression 'and' expression                                                                   #andExpression
        public override Expression VisitAndExpression([NotNull] cqlParser.AndExpressionContext context)
        {
            var expressions = context.expression();
            var lhs = Visit(expressions[0]);
            var rhs = Visit(expressions[1]);

            var and = SystemLibrary.And.Call(ModelProvider, context, lhs, rhs);
            return and;
        }

        // expressionTerm('+' | '-' | '&') expressionTerm                               #additionExpressionTerm
        public override Expression VisitAdditionExpressionTerm([NotNull] cqlParser.AdditionExpressionTermContext context)
        {
            var terms = context.expressionTerm();
            var lhs = Visit(terms[0]);
            var @operator = context.GetChild(1).GetText();
            var rhs = Visit(terms[1]);

            Expression result = 
                @operator switch
                {
                    "+" => SystemLibrary.Add.Concat(SystemLibrary.AddDateTime).Call(ModelProvider, context, lhs, rhs),
                    "-" => SystemLibrary.Subtract.Concat(SystemLibrary.SubtractDateTime).Call(ModelProvider, context, lhs, rhs),
                    "&" => SystemLibrary.Concatenate.Call(ModelProvider, context, lhs, rhs),
                    _ => throw new InvalidOperationException($"Parser returned unknown token '{@operator}' in addition expression."),
                };

            return result;
        }

        //    | 'difference' 'in' pluralDateTimePrecision 'between' expressionTerm 'and' expressionTerm       #differenceBetweenExpression
        public override Expression VisitDifferenceBetweenExpression([NotNull] cqlParser.DifferenceBetweenExpressionContext context)
        {
            var precision = context.pluralDateTimePrecision().Parse();

            var expressionTerms = context.expressionTerm();
            var lhs = Visit(expressionTerms[0]);
            var rhs = Visit(expressionTerms[1]);

            var call = (DifferenceBetween)SystemLibrary.DifferenceBetween.Call(ModelProvider, context, lhs, rhs);
            call.precision = precision;
            call.precisionSpecified = true;

            var selectedType = call.operand[0].resultTypeName;

            if (selectedType == DateTypeQName)
            {
                if (!(precision is DateTimePrecision.Year or DateTimePrecision.Month or DateTimePrecision.Week or DateTimePrecision.Day))
                    throw Critical($"Unit {precision} is not allowed for operands of type {DateTypeQName}");
            }
            else if (selectedType == TimeTypeQName)
            {
                if (!(precision is DateTimePrecision.Hour or DateTimePrecision.Minute or DateTimePrecision.Second or DateTimePrecision.Millisecond))
                    throw Critical($"Unit {precision} is not allowed for operands of type {DateTypeQName}");
            }

            return call;        
        }

        //     | ('duration' 'in')? pluralDateTimePrecision 'between' expressionTerm 'and' expressionTerm      #durationBetweenExpression
        public override Expression VisitDurationBetweenExpression([NotNull] cqlParser.DurationBetweenExpressionContext context)
        {
            var precision = context.pluralDateTimePrecision().Parse();

            var terms = context.expressionTerm();
            var lhs = Visit(terms[0]);
            var rhs = Visit(terms[1]);

            var call = (DurationBetween)SystemLibrary.DurationBetween.Call(ModelProvider, context, lhs, rhs);
            call.precision = precision;
            call.precisionSpecified = true;

            var selectedType = call.operand[0].resultTypeName;

            if (selectedType == DateTypeQName)
            {
                if (!(precision is DateTimePrecision.Year or DateTimePrecision.Month or DateTimePrecision.Week or DateTimePrecision.Day))
                    throw Critical($"Unit {precision} is not allowed for operands of type {DateTypeQName}");
            }
            else if (lhs.resultTypeName == TimeTypeQName)
            {
                if (!(precision is DateTimePrecision.Hour or DateTimePrecision.Minute or DateTimePrecision.Second or DateTimePrecision.Millisecond))
                throw Critical($"Unit {precision} is not allowed for operands of type {DateTypeQName}");

            }

            return call;
        }

        // | expression ('=' | '!=' | '~' | '!~') expression                                               #equalityExpression
        public override Expression VisitEqualityExpression([NotNull] cqlParser.EqualityExpressionContext context)
        {
            var expressions = context.expression();
            var lhs = Visit(expressions[0]);
            var @operator = context.GetChild(1).GetText();
            var rhs = Visit(expressions[1]);

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

        //  expression 'implies' expression                                                               #impliesExpression
        public override Expression VisitImpliesExpression([NotNull] cqlParser.ImpliesExpressionContext context)
        {
            var expressions = context.expression();
            var lhs = Visit(expressions[0]);
            var rhs = Visit(expressions[1]);

            return SystemLibrary.Implies.Call(ModelProvider, context, lhs, rhs);
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

        //     | expression ('or' | 'xor') expression                                                          #orExpression
        public override Expression VisitOrExpression([NotNull] cqlParser.OrExpressionContext context)
        {
            var expressions = context.expression();
            var lhs = Visit(expressions[0]);
            var @operator = context.GetChild(1)!.GetText();
            var rhs = Visit(expressions[1]);

            Expression result = @operator switch
            {
                "or" => SystemLibrary.Or.Call(ModelProvider, context, lhs, rhs),
                "xor" => SystemLibrary.Xor.Call(ModelProvider, context, lhs, rhs),
                _ => throw new InvalidOperationException($"Parser returned unknown token '{@operator}' in (x)or expression.")
            };

            return result;
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
    }
}
