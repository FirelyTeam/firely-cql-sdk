using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using Hl7.Cql.Iso8601;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal partial class ExpressionVisitor
    {
        private QuantityVisitor QuantityVisitor => Services.GetRequiredService<QuantityVisitor>();
        private TupleElementVisitor TupleElementVisitor => Services.GetRequiredService<TupleElementVisitor>();

        private readonly Regex DecimalExpression = new Regex(@"^-?\d*(\.\d+)$", RegexOptions.Compiled);

        public override Expression VisitBooleanLiteral([Antlr4.Runtime.Misc.NotNull] cqlParser.BooleanLiteralContext context)
        {
            var value = context.GetText();
            var typeSpecifier = NamedType(BooleanTypeName, context);
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

        public override Expression VisitDateLiteral([Antlr4.Runtime.Misc.NotNull] cqlParser.DateLiteralContext context)
        {
            var dateType = NamedType(DateTypeName, context);
            var dateLiteral = new Date
            {
                localId = NextId(),
                locator = context.Locator(),
                resultTypeName = dateType.name,
                resultTypeSpecifier = dateType,
            };
            if (DateIso8601.TryParse(context.GetText()[1..], out var date))
            {
                var integerType = NamedType(IntegerTypeName, context);
                var startLine = context.Start.Line;
                int startCol = context.Start.Column;
                dateLiteral.year = new Literal
                {
                    value = date!.Year.ToString(CultureInfo.InvariantCulture),
                    localId = NextId(),
                    locator = FormatLocator(startLine, startCol, startLine, startCol + 4),
                    resultTypeName = integerType.name,
                    valueType = integerType.name,
                    resultTypeSpecifier = integerType,
                };
                if (date.Precision > Iso8601.DateTimePrecision.Year)
                    dateLiteral.month = new Literal
                    {
                        value = date.Month.ToString(),
                        localId = NextId(),
                        locator = FormatLocator(startLine + 5, startCol, startLine, startCol + 7),
                        resultTypeName = integerType.name,
                        valueType = integerType.name,
                        resultTypeSpecifier = integerType,
                    };
                if (date.Precision > Iso8601.DateTimePrecision.Month)
                    dateLiteral.day = new Literal
                    {
                        value = date.Day.ToString(),
                        localId = NextId(),
                        locator = FormatLocator(startLine + 8, startCol, startLine, startCol + 10),
                        resultTypeName = integerType.name,
                        valueType = integerType.name,
                        resultTypeSpecifier = integerType,
                    };
            }
            else
            {
                throw Critical($"Invalid date {date}");
            }
            return dateLiteral;
        }

        public override Expression VisitDateTimeLiteral([Antlr4.Runtime.Misc.NotNull] cqlParser.DateTimeLiteralContext context)
        {
            var dateTimeType = NamedType(DateTimeTypeName, context);
            var dateTimeLiteral = new Elm.DateTime
            {
                localId = NextId(),
                locator = context.Locator(),
                resultTypeName = dateTimeType.name,
                resultTypeSpecifier = dateTimeType,
            };
            if (DateTimeIso8601.TryParse(context.GetText()[1..], out var dateTime))
            {
                var integerType = NamedType(IntegerTypeName, context);
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
                    var decimalType = NamedType(DecimalTypeName, context);
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
                typeSpecifier = NamedType(LongTypeName, context);
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
            var typeSpecifier = NamedType(AnyTypeName, context);
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
                typeSpecifier = NamedType(DecimalTypeName, context);
            }
            else if (int.TryParse(value, out var i))
            {
                typeSpecifier = NamedType(IntegerTypeName, context);
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
            base.Visit(context.GetChild(1));

        public override Expression VisitPolarityExpressionTerm([Antlr4.Runtime.Misc.NotNull] cqlParser.PolarityExpressionTermContext context)
        {
            var sign = context.GetChild(0).GetText();
            var expression = Visit(context.GetChild(1));
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
            var (decimalValue, unit) = QuantityVisitor.Visit(context.GetChild(0));
            var quantityType = NamedType(QuantityTypeName, context); 
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
            var ratioType = NamedType(ModelProvider.QualifiedTypeName(SystemModel, "Ratio"), context);
            var quantityType = NamedType(QuantityTypeName, context); 
            var rc = context.GetChild(0);

            var numChild = rc.GetChild(0) as cqlParser.QuantityContext;
            var denomChild = rc.GetChild(2) as cqlParser.QuantityContext;
            var (numValue, numUnit) = QuantityVisitor.Visit(numChild);
            var (denomValue, denomUnit) = QuantityVisitor.Visit(denomChild);

            var ratio = new Ratio
            {
                localId = NextId(),
                locator = context.Locator(),
                resultTypeName = ratioType.name,
                resultTypeSpecifier = ratioType,
                numerator = new Quantity
                {
                    localId = NextId(),
                    locator = numChild!.Locator(),
                    value = numValue,
                    unit = numUnit,
                    resultTypeName = quantityType.name,
                    resultTypeSpecifier = quantityType,
                    valueSpecified = true,
                },
                denominator = new Quantity
                {
                    localId = NextId(),
                    locator = denomChild!.Locator(),
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
            var value = context.GetText().AsSpan().Detick().ToString();
            var typeSpecifier = NamedType(StringTypeName, context);

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
            var timeType = NamedType(TimeTypeName, context);
            var timeLiteral = new Time
            {
                localId = NextId(),
                locator = context.Locator(),
                resultTypeName = timeType.name,
                resultTypeSpecifier = timeType,
            };
            if (TimeIso8601.TryParse(context.GetText()[2..], out var time))
            {
                var integerType = NamedType(IntegerTypeName, context);
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

        public override Expression VisitTupleSelector([Antlr4.Runtime.Misc.NotNull] cqlParser.TupleSelectorContext context)
        {
            int terminalCount, i;
            if (context.GetChild(0).GetText() == "Tuple")
            {
                terminalCount = 3;
                i = 2;
            }
            else
            {
                terminalCount = 2;
                i = 1;
            }

            var elementCount = context.ChildCount - terminalCount;
            if ((elementCount & 0x1) == 1)
                elementCount = (elementCount >> 1) + 1;
            else
                elementCount >>= 1;
            var resultType = new TupleTypeSpecifier
            {
                element = new TupleElementDefinition[elementCount],
            };
            var tuple = new Elm.Tuple
            {
                element = new TupleElement[elementCount],
                localId = NextId(),
                locator = context.Locator(),
                resultTypeSpecifier = resultType,
            };
            for (int j = 0; i < context.ChildCount; i += 2)
            {
                tuple.element[j] = TupleElementVisitor.Visit(context.GetChild(i));
                resultType.element[j] = new TupleElementDefinition
                {
                    name = tuple.element[j].name,
                    elementType = tuple.element[j].value.resultTypeSpecifier,
                };
                j++;
            }
            return tuple;
        }

    }
}
