using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using Hl7.Cql.Iso8601;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal partial class ExpressionVisitor
    {
        private readonly Regex DecimalExpression = new Regex(@"^-?\d*(\.\d+)$", RegexOptions.Compiled);

        public override Expression VisitBooleanLiteral([Antlr4.Runtime.Misc.NotNull] cqlParser.BooleanLiteralContext context)
        {
            var value = context.GetText();
            var literal = new Literal
            {
                value = value,
                valueType = SystemTypes.BooleanType.name,
            }.WithResultType(SystemTypes.BooleanType).WithLocator(context.Locator());

            return literal;
        }

        public override Expression VisitDateLiteral([Antlr4.Runtime.Misc.NotNull] cqlParser.DateLiteralContext context)
        {
            var dateLiteral = new Date
            {
            }.WithResultType(SystemTypes.DateType).WithLocator(context.Locator());
            
            if (DateIso8601.TryParse(context.GetText()[1..], out var date))
            {                
                var startLine = context.Start.Line;
                int startCol = context.Start.Column;

                dateLiteral.year = new Literal
                {
                    value = date!.Year.ToString(CultureInfo.InvariantCulture),
                    valueType = SystemTypes.IntegerType.name,
                }.WithLocator(FormatLocator(startLine, startCol, startLine, startCol + 4))
                    .WithResultType(SystemTypes.IntegerType);

                if (date.Precision > Iso8601.DateTimePrecision.Year)
                {
                    dateLiteral.month = new Literal
                    {
                        value = date.Month.ToString(),
                        valueType = SystemTypes.IntegerType.name,
                    }.WithLocator(FormatLocator(startLine + 5, startCol, startLine, startCol + 7))
                        .WithResultType(SystemTypes.IntegerType);
                }

                if (date.Precision > Iso8601.DateTimePrecision.Month)
                {
                    dateLiteral.day = new Literal
                    {
                        value = date.Day.ToString(),
                        valueType = SystemTypes.IntegerType.name,
                    }.WithLocator(FormatLocator(startLine + 8, startCol, startLine, startCol + 10))
                        .WithResultType(SystemTypes.IntegerType);
                }
            }
            else
            {
                throw Critical($"Invalid date {date}");
            }
            return dateLiteral;
        }

        public override Expression VisitDateTimeLiteral([Antlr4.Runtime.Misc.NotNull] cqlParser.DateTimeLiteralContext context)
        {
            var dateTimeType = NamedType(DateTimeTypeQName, context);
            var dateTimeLiteral = new Elm.DateTime
            {
                localId = NextId(),
                locator = context.Locator(),
                resultTypeName = dateTimeType.name,
                resultTypeSpecifier = dateTimeType,
            };
            if (DateTimeIso8601.TryParse(context.GetText()[1..], out var dateTime))
            {
                var integerType = NamedType(IntegerTypeQName, context);
                var startLine = context.Start.Line;
                int startCol = context.Start.Column;
                dateTimeLiteral.year = new Literal
                {
                    value = dateTime!.Year.ToString(CultureInfo.InvariantCulture),
                    localId = NextId(),
                    locator = FormatLocator(startLine, startCol, startLine, startCol + 4),
                    resultTypeName = integerType.name,
                    valueType = integerType.name,
                    resultTypeSpecifier = integerType,
                };
                if (dateTime.Precision > Iso8601.DateTimePrecision.Year)
                    dateTimeLiteral.month = new Literal
                    {
                        value = dateTime.Month.ToString(),
                        localId = NextId(),
                        locator = FormatLocator(startLine + 5, startCol, startLine, startCol + 7),
                        resultTypeName = integerType.name,
                        valueType = integerType.name,
                        resultTypeSpecifier = integerType,
                    };
                if (dateTime.Precision > Iso8601.DateTimePrecision.Month)
                    dateTimeLiteral.day = new Literal
                    {
                        value = dateTime.Day.ToString(),
                        localId = NextId(),
                        locator = FormatLocator(startLine + 8, startCol, startLine, startCol + 10),
                        resultTypeName = integerType.name,
                        valueType = integerType.name,
                        resultTypeSpecifier = integerType,
                    };
                if (dateTime.Precision > Iso8601.DateTimePrecision.Day)
                    dateTimeLiteral.hour = new Literal
                    {
                        value = dateTime.Hour.ToString(),
                        localId = NextId(),
                        locator = FormatLocator(startLine + 11, startCol, startLine, startCol + 13),
                        resultTypeName = integerType.name,
                        valueType = integerType.name,
                        resultTypeSpecifier = integerType,
                    };
                if (dateTime.Precision > Iso8601.DateTimePrecision.Hour)
                    dateTimeLiteral.minute = new Literal
                    {
                        value = dateTime.Minute.ToString(),
                        localId = NextId(),
                        locator = FormatLocator(startLine + 14, startCol, startLine, startCol + 16),
                        resultTypeName = integerType.name,
                        valueType = integerType.name,
                        resultTypeSpecifier = integerType,
                    };
                if (dateTime.Precision > Iso8601.DateTimePrecision.Minute)
                    dateTimeLiteral.second = new Literal
                    {
                        value = dateTime.Second.ToString(),
                        localId = NextId(),
                        locator = FormatLocator(startLine + 17, startCol, startLine, startCol + 19),
                        resultTypeName = integerType.name,
                        valueType = integerType.name,
                        resultTypeSpecifier = integerType,
                    };
                if (dateTime.Precision > Iso8601.DateTimePrecision.Second)
                    dateTimeLiteral.millisecond = new Literal
                    {
                        value = dateTime.Millisecond.ToString(),
                        localId = NextId(),
                        locator = FormatLocator(startLine + 17, startCol, startLine, startCol + 19),
                        resultTypeName = integerType.name,
                        valueType = integerType.name,
                        resultTypeSpecifier = integerType,
                    };
                if (dateTime.RationalOffset.HasValue)
                {
                    var decimalType = NamedType(DecimalTypeQName, context);
                    dateTimeLiteral.timezoneOffset = new Literal
                    {
                        value = dateTime.RationalOffset.Value.ToString(CultureInfo.InvariantCulture),
                        localId = NextId(),
                        locator = FormatLocator(startLine + 21, startCol, startLine, context.Stop.Column),
                        resultTypeName = decimalType.name,
                        valueType = decimalType.name,
                        resultTypeSpecifier = decimalType,
                    };
                }
            }
            else
            {
                throw Critical($"Invalid date {dateTime}");
            }
            return dateTimeLiteral;
        }

        public override Expression VisitInvocationTerm([Antlr4.Runtime.Misc.NotNull] cqlParser.InvocationTermContext context) =>
            Visit(context.GetChild(0));

        public override Expression VisitLongNumberLiteral([Antlr4.Runtime.Misc.NotNull] cqlParser.LongNumberLiteralContext context)
        {
            var value = context.GetText()[..^1];
            NamedTypeSpecifier? typeSpecifier = null;
            if (long.TryParse(value, out long l))
            {
                typeSpecifier = NamedType(LongTypeQName, context);
            }
            else
            {
                throw Critical($"The long value {value} is not valid.");
            }
            var literal = new Literal
            {
                value = value,
                resultTypeSpecifier = typeSpecifier,
                resultTypeName = typeSpecifier!.name,
                valueType = typeSpecifier.name,
                localId = NextId(),
                locator = context.Locator()
            };
            return literal;
        }

        public override Expression VisitNullLiteral([Antlr4.Runtime.Misc.NotNull] cqlParser.NullLiteralContext context)
        {
            var typeSpecifier = NamedType(AnyTypeQName, context);
            var @null = new Null
            {
                resultTypeSpecifier = typeSpecifier,
                resultTypeName = typeSpecifier.name,
                valueType = typeSpecifier.name,
                localId = NextId(),
                locator = context.Locator()
            };
            return @null;
        }

        public override Expression VisitNumberLiteral([Antlr4.Runtime.Misc.NotNull] cqlParser.NumberLiteralContext context)
        {
            var value = context.GetText();
            NamedTypeSpecifier? typeSpecifier = null;
            if (DecimalExpression.IsMatch(value))
            {
                var abs = value;
                if (abs.StartsWith('-'))
                    abs = abs[1..];
                var parts = abs.Split('.');
                if (parts.Sum(p => p.Length) > 28)
                {
                    throw Critical("Decimal literals cannot be longer than 28 digits.");
                }
                else if (parts.Length > 1 && parts[1].Length > 8)
                {
                    throw Critical("Decimal literals cannot have a mantissa longer than 8 digits");
                }
                typeSpecifier = NamedType(DecimalTypeQName, context);
            }
            else if (int.TryParse(value, out var i))
            {
                typeSpecifier = NamedType(IntegerTypeQName, context);
            }
            else
            {
                throw Critical($"Unexpected literal value {value}");
            }
            var literal = new Literal
            {
                value = value,
                resultTypeSpecifier = typeSpecifier,
                resultTypeName = typeSpecifier!.name,
                valueType = typeSpecifier.name,
                localId = NextId(),
                locator = context.Locator(),
            };
            return literal;
        }

        public override Expression VisitParenthesizedTerm([Antlr4.Runtime.Misc.NotNull] cqlParser.ParenthesizedTermContext context) =>
            Visit(context.expression());

        //   | ('+' | '-') expressionTerm                                                    #polarityExpressionTerm
        public override Expression VisitPolarityExpressionTerm([Antlr4.Runtime.Misc.NotNull] cqlParser.PolarityExpressionTermContext context)
        {
            var sign = context.GetChild(0).GetText();
            var expression = Visit(context.expressionTerm());

            if (expression is Literal literal)
                literal.value = $"{sign}{literal.value}";
            else if (expression is Quantity quantity && sign == "-")
                quantity.value = -1 * quantity.value;
            else
                throw Critical("Expected result of polarity expression to be a literal");

            return expression;
        }

        public override Expression VisitQuantityLiteral([Antlr4.Runtime.Misc.NotNull] cqlParser.QuantityLiteralContext context)
        {
            var (decimalValue, unit) = context.quantity().Parse();
            var quantityType = NamedType(QuantityTypeQName, context);
            var quantity = new Quantity
            {
                localId = NextId(),
                locator = context.Locator(),
                value = decimalValue,
                unit = unit,
                resultTypeName = quantityType.name,
                resultTypeSpecifier = quantityType,
                valueSpecified = true,
            };
            return quantity;
        }

        public override Expression VisitRatioLiteral([Antlr4.Runtime.Misc.NotNull] cqlParser.RatioLiteralContext context)
        {
            var ratioType = NamedType(RatioTypeQName, context);
            var quantityType = NamedType(QuantityTypeQName, context);
            var quantities = context.ratio().quantity();

            var (numValue, numUnit) = quantities[0].Parse();
            var (denomValue, denomUnit) = quantities[1].Parse();

            var ratio = new Ratio
            {
                localId = NextId(),
                locator = context.Locator(),
                resultTypeName = ratioType.name,
                resultTypeSpecifier = ratioType,
                numerator = new Quantity
                {
                    localId = NextId(),
                    locator = quantities[0].Locator(),
                    value = numValue,
                    unit = numUnit,
                    resultTypeName = quantityType.name,
                    resultTypeSpecifier = quantityType,
                    valueSpecified = true,
                },
                denominator = new Quantity
                {
                    localId = NextId(),
                    locator = quantities[1].Locator(),
                    value = denomValue,
                    unit = denomUnit,
                    resultTypeName = quantityType.name,
                    resultTypeSpecifier = quantityType,
                    valueSpecified = true,
                }
            };
            return ratio;
        }

        public override Expression VisitStringLiteral([Antlr4.Runtime.Misc.NotNull] cqlParser.StringLiteralContext context)
        {
            var value = context.STRING().ParseString();
            var typeSpecifier = NamedType(StringTypeQName, context);

            var literal = new Literal
            {
                value = value,
                resultTypeSpecifier = typeSpecifier,
                resultTypeName = typeSpecifier.name,
                valueType = typeSpecifier.name,
                localId = NextId(),
                locator = context.Locator()
            };
            return literal;
        }

        public override Expression VisitTimeLiteral([Antlr4.Runtime.Misc.NotNull] cqlParser.TimeLiteralContext context)
        {
            var timeType = NamedType(TimeTypeQName, context);
            var timeLiteral = new Time
            {
                localId = NextId(),
                locator = context.Locator(),
                resultTypeName = timeType.name,
                resultTypeSpecifier = timeType,
            };
            if (TimeIso8601.TryParse(context.GetText()[2..], out var time))
            {
                var integerType = NamedType(IntegerTypeQName, context);
                var startLine = context.Start.Line;
                int startCol = context.Start.Column;
                timeLiteral.hour = new Literal
                {
                    value = time!.Hour.ToString(CultureInfo.InvariantCulture),
                    localId = NextId(),
                    locator = FormatLocator(startLine + 11, startCol, startLine, startCol + 13),
                    resultTypeName = integerType.name,
                    valueType = integerType.name,
                    resultTypeSpecifier = integerType,
                };
                if (time.Precision > Iso8601.DateTimePrecision.Hour)
                    timeLiteral.minute = new Literal
                    {
                        value = time.Minute.ToString(),
                        localId = NextId(),
                        locator = FormatLocator(startLine + 14, startCol, startLine, startCol + 16),
                        resultTypeName = integerType.name,
                        valueType = integerType.name,
                        resultTypeSpecifier = integerType,
                    };
                if (time.Precision > Iso8601.DateTimePrecision.Minute)
                    timeLiteral.second = new Literal
                    {
                        value = time.Second.ToString(),
                        localId = NextId(),
                        locator = FormatLocator(startLine + 17, startCol, startLine, startCol + 19),
                        resultTypeName = integerType.name,
                        valueType = integerType.name,
                        resultTypeSpecifier = integerType,
                    };
                if (time.Precision > Iso8601.DateTimePrecision.Second)
                    timeLiteral.millisecond = new Literal
                    {
                        value = time.Millisecond.ToString(),
                        localId = NextId(),
                        locator = FormatLocator(startLine + 17, startCol, startLine, startCol + 19),
                        resultTypeName = integerType.name,
                        valueType = integerType.name,
                        resultTypeSpecifier = integerType,
                    };
            }
            else
            {
                throw Critical($"Invalid date {time}");
            }
            return timeLiteral;
        }

        //    : 'Tuple'? '{' (':' | (tupleElementSelector (',' tupleElementSelector)*)) '}'
        public override Expression VisitTupleSelector([Antlr4.Runtime.Misc.NotNull] cqlParser.TupleSelectorContext context)
        {
            var tupleElementContexts = context.tupleElementSelector();
            var tupleElements = tupleElementContexts.Select(tec => tec.Parse(this)).ToArray(); 

            var tupleTypeElementDefs = tupleElements.Select(te => new TupleElementDefinition
            {
                name = te.name,
                elementType = te.value.resultTypeSpecifier,
            }).ToArray();

            var resultType = new TupleTypeSpecifier
            {
                element = tupleTypeElementDefs
            };

            var tuple = new Tuple
            {
                element = tupleElements,
            }.WithLocator(context.Locator()).WithResultType(resultType);

            return tuple;
        }

    }
}
