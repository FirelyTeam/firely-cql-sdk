using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using Hl7.Cql.Iso8601;
using System;
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
            Literal literal;
            if (bool.TryParse(value, out var bv))
                literal = ElmFactory.Literal(bv);
            else 
                literal = ElmFactory.Literal(value)
                    .AddError($"Unable to parse '{value}' as a boolean value.");
            return literal
                .WithLocator(context.Locator());
        }

        public override Expression VisitDateLiteral([Antlr4.Runtime.Misc.NotNull] cqlParser.DateLiteralContext context)
        {
            var dateLiteral = new Date
            {
            }
            .WithLocator(context.Locator())
            .WithResultType(SystemTypes.DateType);

            var dateText = context.GetText()[1..];

            if (DateIso8601.TryParse(dateText, out var date) && date is not null)
            {
                var startLine = context.Start.Line;
                int startCol = context.Start.Column;

                dateLiteral.year = ElmFactory.Literal(date!.Year)
                    .WithLocator(FormatLocator(startLine, startCol, startLine, startCol + 4));

                if (date.Precision > Iso8601.DateTimePrecision.Year && date.Month is not null)
                {
                    dateLiteral.month = ElmFactory.Literal(date.Month.Value)
                        .WithLocator(FormatLocator(startLine + 5, startCol, startLine, startCol + 7));
                }

                if (date.Precision > Iso8601.DateTimePrecision.Month && date.Day is not null)
                {
                    dateLiteral.day = ElmFactory.Literal(date.Day.Value)
                        .WithLocator(FormatLocator(startLine + 8, startCol, startLine, startCol + 10));
                }
                return dateLiteral;
            }
            else
            {
                return dateLiteral.AddError($"Unparseable date literal '{dateText}'.", ErrorType.syntax);
            }
        }

        public override Expression VisitDateTimeLiteral([Antlr4.Runtime.Misc.NotNull] cqlParser.DateTimeLiteralContext context)
        {
            var dateTimeLiteral = new Elm.DateTime
            {
            }.WithLocator(context.Locator()).WithResultType(SystemTypes.DateTimeType);

            var dateText = context.GetText()[1..];
            if (dateText.EndsWith("T"))
                dateText = dateText[0..^1];

            if (DateTimeIso8601.TryParse(dateText, out var dateTime) && dateTime is not null)
            {
                var integerType = SystemTypes.IntegerType;
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
                if (dateTime.Precision > Iso8601.DateTimePrecision.Year && dateTime.Month.HasValue)
                    dateTimeLiteral.month = new Literal
                    {
                        value = dateTime.Month.Value.ToString(CultureInfo.InvariantCulture),
                        localId = NextId(),
                        locator = FormatLocator(startLine + 5, startCol, startLine, startCol + 7),
                        resultTypeName = integerType.name,
                        valueType = integerType.name,
                        resultTypeSpecifier = integerType,
                    };
                if (dateTime.Precision > Iso8601.DateTimePrecision.Month && dateTime.Day.HasValue)
                    dateTimeLiteral.day = new Literal
                    {
                        value = dateTime.Day.Value.ToString(CultureInfo.InvariantCulture),
                        localId = NextId(),
                        locator = FormatLocator(startLine + 8, startCol, startLine, startCol + 10),
                        resultTypeName = integerType.name,
                        valueType = integerType.name,
                        resultTypeSpecifier = integerType,
                    };
                if (dateTime.Precision > Iso8601.DateTimePrecision.Day && dateTime.Hour.HasValue)
                    dateTimeLiteral.hour = new Literal
                    {
                        value = dateTime.Hour.Value.ToString(CultureInfo.InvariantCulture),
                        localId = NextId(),
                        locator = FormatLocator(startLine + 11, startCol, startLine, startCol + 13),
                        resultTypeName = integerType.name,
                        valueType = integerType.name,
                        resultTypeSpecifier = integerType,
                    };
                if (dateTime.Precision > Iso8601.DateTimePrecision.Hour && dateTime.Minute.HasValue)
                    dateTimeLiteral.minute = new Literal
                    {
                        value = dateTime.Minute.Value.ToString(CultureInfo.InvariantCulture),
                        localId = NextId(),
                        locator = FormatLocator(startLine + 14, startCol, startLine, startCol + 16),
                        resultTypeName = integerType.name,
                        valueType = integerType.name,
                        resultTypeSpecifier = integerType,
                    };
                if (dateTime.Precision > Iso8601.DateTimePrecision.Minute && dateTime.Second.HasValue)
                    dateTimeLiteral.second = new Literal
                    {
                        value = dateTime.Second.Value.ToString(CultureInfo.InvariantCulture),
                        localId = NextId(),
                        locator = FormatLocator(startLine + 17, startCol, startLine, startCol + 19),
                        resultTypeName = integerType.name,
                        valueType = integerType.name,
                        resultTypeSpecifier = integerType,
                    };
                if (dateTime.Precision > Iso8601.DateTimePrecision.Second && dateTime.Millisecond.HasValue)
                    dateTimeLiteral.millisecond = new Literal
                    {
                        value = dateTime.Millisecond.Value.ToString(CultureInfo.InvariantCulture),
                        localId = NextId(),
                        locator = FormatLocator(startLine + 17, startCol, startLine, startCol + 19),
                        resultTypeName = integerType.name,
                        valueType = integerType.name,
                        resultTypeSpecifier = integerType,
                    };
                if (dateTime.RationalOffset.HasValue)
                {
                    var decimalType = SystemTypes.DecimalType;
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

                return dateTimeLiteral;
            }
            else
            {
                return dateTimeLiteral.AddError($"Unparseable date/time literal '{dateText}'.", ErrorType.syntax);
            }

        }

        public override Expression VisitLongNumberLiteral([Antlr4.Runtime.Misc.NotNull] cqlParser.LongNumberLiteralContext context)
        {
            if (!bool.TryParse(Configuration[nameof(CqlToElmOptions.ValidateLiterals)] ?? bool.FalseString, out var validateLiterals))
                validateLiterals = true;

            var valueText = context.GetText()[..^1];

            Literal literal;
            if (long.TryParse(valueText, out long longValue))
                literal = ElmFactory.Literal(longValue);
            else
            {
                literal = ElmFactory.Literal(valueText)
                    .WithResultType(SystemTypes.LongType);
                literal.valueType = SystemTypes.LongType.name;
                if (validateLiterals)
                    literal.AddError($"Unparseable long literal {valueText}.", ErrorType.syntax);
            }
            return literal
                .WithLocator(context.Locator());
        }

        public override Expression VisitNullLiteral([Antlr4.Runtime.Misc.NotNull] cqlParser.NullLiteralContext context)
        {
            var @null = new Null
            {
                valueType = SystemTypes.AnyType.name,
            };

            return @null
                .WithLocator(context.Locator())
                .WithResultType(SystemTypes.AnyType);
        }

        public override Expression VisitNumberLiteral([Antlr4.Runtime.Misc.NotNull] cqlParser.NumberLiteralContext context)
        {
            var value = context.GetText();
            var literal = new Literal
            {
                value = value,
            };

            var validateLiterals = Option(o => o.ValidateLiterals);

            NamedTypeSpecifier? typeSpecifier = null;

            if (DecimalExpression.IsMatch(value))
            {
                var abs = value;
                if (abs.StartsWith('-'))
                    abs = abs[1..];
                var parts = abs.Split('.');

                if (validateLiterals)
                {
                    if (parts.Sum(p => p.Length) > 28)
                    {
                        literal.AddError("Decimal literals cannot be longer than 28 digits.", ErrorType.syntax);
                    }
                    else if (parts.Length > 1 && parts[1].Length > 8)
                    {
                        literal.AddError("Decimal literals cannot have a mantissa longer than 8 digits.", ErrorType.syntax);
                    }
                }
                typeSpecifier = SystemTypes.DecimalType;
            }
            else if (int.TryParse(value, out var i))
                typeSpecifier = SystemTypes.IntegerType;
            else if (long.TryParse(value, out var l) && !Option(o => o.LongsRequireSuffix))
            {
                typeSpecifier = SystemTypes.LongType;
            }

            else if (validateLiterals)
                return literal.AddError($"Unparseable numeric literal '{value}'.", ErrorType.syntax);
            else
            {
                typeSpecifier = SystemTypes.AnyType;
            }
            literal.valueType = typeSpecifier.name;
            return literal
                .WithLocator(context.Locator())
                .WithResultType(typeSpecifier);
        }

        public override Expression VisitParenthesizedTerm([Antlr4.Runtime.Misc.NotNull] cqlParser.ParenthesizedTermContext context) =>
            Visit(context.expression());

        //   | ('+' | '-') expressionTerm                                                    #polarityExpressionTerm
        public override Expression VisitPolarityExpressionTerm([Antlr4.Runtime.Misc.NotNull] cqlParser.PolarityExpressionTermContext context)
        {
            var text = context.GetText();
            if (text == "-2147483648")
                return ElmFactory.Literal(-2147483648)
                    .WithLocator(context.Locator());
            else if (text == "-9223372036854775808L")
                return ElmFactory.Literal(-9223372036854775808L)
                    .WithLocator(context.Locator());
            else if (text == "-99999999999999999999.99999999")
                return ElmFactory.Literal(-99999999999999999999.99999999m)
                    .WithLocator(context.Locator());
            else
            {
                var sign = context.GetChild(0).GetText();
                var expression = Visit(context.expressionTerm());

                if (expression is Literal literal)
                {
                    literal.value = apply(sign, literal.value);
                    return literal;
                }
                else if (sign == "-")
                {
                    if (expression is Quantity quantity)
                    {
                        quantity.value *= -1;
                        return quantity;
                    }
                    else
                    {
                        return new Negate
                        {
                            operand = expression,
                        }
                        .WithLocator(context.Locator())
                        .WithResultType(expression.resultTypeSpecifier);
                    }
                }
                else return expression;

                string apply(string polarity, string number)
                {
                    if (polarity == "-")
                    {
                        if (number.StartsWith("-"))
                        {
                            return number.Substring(1);
                        }
                        else
                        {
                            return "-" + number;
                        }
                    }
                    else
                    {
                        return number;
                    }
                }
            }
        }

        public override Expression VisitQuantityLiteral([Antlr4.Runtime.Misc.NotNull] cqlParser.QuantityLiteralContext context)
        {
            var (decimalValue, unit) = context.quantity().Parse();
            var quantity = new Quantity
            {
                localId = NextId(),
                locator = context.Locator(),
                value = decimalValue,
                unit = unit,
                valueSpecified = true,
            }.WithResultType(SystemTypes.QuantityType);
            return quantity;
        }

        public override Expression VisitQuantity([Antlr4.Runtime.Misc.NotNull] cqlParser.QuantityContext context)
        {
            var quantity = new Quantity();
            var unit = context.unit()?.GetText();
            if (string.IsNullOrWhiteSpace(unit))
            {
                quantity.AddError($"Unit is missing");
            }
            else
            {
                quantity.unit = unit ?? "1";
            }
            if (!decimal.TryParse(context.NUMBER().GetText(), out var value))
            {
                quantity.AddError($"Could not parse {context.NUMBER()} as a number.");
            }
            else
            {
                quantity.value = value;
                quantity.valueSpecified = true;
            }
            return quantity
                .WithLocator(context.Locator())
                .WithResultType(SystemTypes.QuantityType);
        }

        public override Expression VisitRatioLiteral([Antlr4.Runtime.Misc.NotNull] cqlParser.RatioLiteralContext context)
        {
            var ratioType = SystemTypes.RatioType;
            var quantityType = SystemTypes.QuantityType;
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

            var literal = new Literal
            {
                value = value,
                valueType = SystemTypes.StringType.name,
            }.WithLocator(context.Locator()).WithResultType(SystemTypes.StringType);
            return literal;
        }

        public override Expression VisitTimeLiteral([Antlr4.Runtime.Misc.NotNull] cqlParser.TimeLiteralContext context)
        {
            var literalText = context.GetText()[2..];

            var timeLiteral = new Time
            {
                localId = NextId(),
                locator = context.Locator(),
            }.WithLocator(context.Locator()).WithResultType(SystemTypes.TimeType);

            if (TimeIso8601.TryParse(literalText, out var time))
            {
                var integerType = SystemTypes.IntegerType;
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
                if (time.Precision > Iso8601.DateTimePrecision.Hour && time.Minute.HasValue)
                    timeLiteral.minute = new Literal
                    {
                        value = time.Minute.Value.ToString(CultureInfo.InvariantCulture),
                        localId = NextId(),
                        locator = FormatLocator(startLine + 14, startCol, startLine, startCol + 16),
                        resultTypeName = integerType.name,
                        valueType = integerType.name,
                        resultTypeSpecifier = integerType,
                    };
                if (time.Precision > Iso8601.DateTimePrecision.Minute && time.Second.HasValue)
                    timeLiteral.second = new Literal
                    {
                        value = time.Second.Value.ToString(CultureInfo.InvariantCulture),
                        localId = NextId(),
                        locator = FormatLocator(startLine + 17, startCol, startLine, startCol + 19),
                        resultTypeName = integerType.name,
                        valueType = integerType.name,
                        resultTypeSpecifier = integerType,
                    };
                if (time.Precision > Iso8601.DateTimePrecision.Second && time.Millisecond.HasValue)
                    timeLiteral.millisecond = new Literal
                    {
                        value = time.Millisecond.Value.ToString(CultureInfo.InvariantCulture),
                        localId = NextId(),
                        locator = FormatLocator(startLine + 17, startCol, startLine, startCol + 19),
                        resultTypeName = integerType.name,
                        valueType = integerType.name,
                        resultTypeSpecifier = integerType,
                    };

                return timeLiteral;
            }
            else
            {
                return timeLiteral.AddError($"Unparseable time literal '{literalText}'.", ErrorType.syntax);
            }

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

            var tuple = new Elm.Tuple
            {
                element = tupleElements,
            }.WithLocator(context.Locator()).WithResultType(resultType);

            return tuple;
        }

    }
}
