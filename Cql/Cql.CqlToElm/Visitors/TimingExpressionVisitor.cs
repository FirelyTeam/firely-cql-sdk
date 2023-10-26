using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal partial class ExpressionVisitor
    {
        //     | expression intervalOperatorPhrase expression                                                  #timingExpression
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
                cqlParser.BeforeOrAfterIntervalOperatorPhraseContext => throw new NotImplementedException(),
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
                var kw0 = context.GetChild(0).GetText();
                var kw1 = context.GetChild(1).GetText();

                var properly = kw0 == "properly" || kw1 == "properly";

                if (kw0 == "starts")
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
                else if (kw0 == "ends")
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
                else if (kw1 == "occurs")
                {
                    throw new NotImplementedException("Within with an 'occurs' is not yet implemented.");
                }

                var (value, unit) = context.quantity().Parse();

                var quantity = new Quantity
                {
                    localId = NextId(),
                    locator = context.quantity().Locator(),
                    value = value,
                    valueSpecified = true,
                    unit = unit,
                }.WithResultType(SystemTypes.QuantityType);

                var startEnd = context.children[^1].GetText();

                if (startEnd == "start")
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
                else if (startEnd == "end")
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
                        resultTypeSpecifier = subtract.resultTypeSpecifier!.ToIntervalType(),
                    };

                    if (lhs is Elm.Interval)
                    {
                        rhs = new Elm.ToList
                        {
                            localId = NextId(),
                            locator = rhs.locator,
                            resultTypeSpecifier = lhs.resultTypeSpecifier!.ToListType(),
                            operand = rhs,
                        };
                    }

                    var @in = new In
                    {
                        localId = NextId(),
                        locator = context.Locator(),
                        operand = new[] { lhs, rhs },
                    }.WithResultType(SystemTypes.BooleanType);

                    return @in;
                }
                else
                    throw new NotImplementedException("Properly within is not yet implemented.");
            }

            //| ('starts' | 'ends' | 'occurs')? 'properly'? ('during' | 'included in') dateTimePrecisionSpecifier?                    #includedInIntervalOperatorPhrase
            Expression HandleIncludedIn(cqlParser.IncludedInIntervalOperatorPhraseContext context,
                    Expression lhs,
                    Expression rhs)
            {
                bool properly = false;
                DateTimePrecision? dtp = null;

                var index = 0;
                var kw0 = context.GetChild(index).ParseKeyword();
                if (kw0 is not null)
                {
                    var keyword = kw0;
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
                        var kw1 = child.ParseKeyword();
                        if (kw1 == CqlKeyword.Properly)
                        {
                            properly = true;
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
                    }.WithResultType(SystemTypes.BooleanType),
                    _ => new IncludedIn
                    {
                        localId = NextId(),
                        locator = context.Locator(),
                        operand = new[] { lhs, rhs },
                        precision = dtp ?? default,
                        precisionSpecified = dtp.HasValue,
                    }.WithResultType(SystemTypes.BooleanType),
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

                var boa = context.ChildCount > 1 && context.GetChild(1) is ITerminalNode term ?
                    term.GetText() : null;

                BinaryExpression result = boa switch
                {
                    null => new Overlaps
                    {
                        precisionSpecified = dtPrecision is not null,
                        precision = dtPrecision ?? default,
                    },

                    "before" => new OverlapsBefore
                    {
                        precisionSpecified = dtPrecision is not null,
                        precision = dtPrecision ?? default,
                    },

                    "after" => new OverlapsAfter
                    {
                        precisionSpecified = dtPrecision is not null,
                        precision = dtPrecision ?? default,
                    },
                    _ => throw new InvalidOperationException($"Parser returned unknown token '{boa}' in an overlaps interval expression.")
                };

                result.operand = new[] { lhs, rhs };
                return result.WithResultType(SystemTypes.BooleanType).WithLocator(context.Locator());
            }
        }

        // | 'meets'('before' | 'after') ? dateTimePrecisionSpecifier ?                                                             #meetsIntervalOperatorPhrase
        private static Expression HandleMeets(cqlParser.MeetsIntervalOperatorPhraseContext context,
                Expression lhs,
                Expression rhs)
        {
            DateTimePrecision? precision = context.dateTimePrecisionSpecifier()?.dateTimePrecision().Parse();

            var boa = context.ChildCount > 1 && context.GetChild(1) is ITerminalNode term ? term.GetText() : null;

            BinaryExpression result = boa switch
            {
                null => new Meets
                {
                    precisionSpecified = precision is not null,
                    precision = precision ?? default,
                },
                "before" => new MeetsBefore
                {
                    precisionSpecified = precision is not null,
                    precision = precision ?? default,
                },
                "after" => new MeetsAfter
                {
                    precisionSpecified = precision is not null,
                    precision = precision ?? default,
                },
                _ => throw new InvalidOperationException($"Parser returned unknown token '{boa}' in a meets interval expression.")
            };

            result.operand = new[] { lhs, rhs };
            return result.WithResultType(SystemTypes.BooleanType).WithLocator(context.Locator());
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
            }.WithResultType(SystemTypes.BooleanType);
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
            }.WithResultType(SystemTypes.BooleanType);
        }

        //| 'properly'? 'includes' dateTimePrecisionSpecifier? ('start' | 'end')?
        private Expression HandleIncludes(cqlParser.IncludesIntervalOperatorPhraseContext context,
                Expression lhs,
                Expression rhs)
        {
            var firstKeyword = context.GetChild(0).GetText();
            var properly = firstKeyword == "properly";

            DateTimePrecision? precision = context.dateTimePrecisionSpecifier() is { } dtp ? dtp.dateTimePrecision().Parse() : null;

            var startEnd = context.children[^1].GetText();

            var rhsPointType = PointType(rhs.resultTypeSpecifier);
            var locator = context.children[^1].Locator()!;

            if (startEnd == "start")
            {
                rhs = new Start
                {
                    operand = rhs,
                }.WithLocator(locator).WithResultType(rhsPointType!);
            }
            else if (startEnd == "end")
            {
                rhs = new End
                {
                    operand = rhs,
                }.WithLocator(locator).WithResultType(rhsPointType!);
            }

            BinaryExpression includes = properly
              ? new ProperIncludes() { precision = precision ?? default, precisionSpecified = precision.HasValue }
              : new Includes() { precision = precision ?? default, precisionSpecified = precision.HasValue };
            includes.localId = NextId();
            includes.locator = context.Locator();
            includes.operand = new[] { lhs, rhs };
            return includes.WithResultType(SystemTypes.BooleanType);
        }

        //: ('starts' | 'ends' | 'occurs')? 'same' dateTimePrecision? (relativeQualifier | 'as') ('start' | 'end')?               #concurrentWithIntervalOperatorPhrase
        private static Expression HandleConcurrentWith(cqlParser.ConcurrentWithIntervalOperatorPhraseContext context,
                Expression lhs,
                Expression rhs)
        {
            var skipPointConversion = context.ChildCount == 3 && context.dateTimePrecision() is not null;

            var qualifier = (context.relativeQualifier() is { } tree ? tree.ParseKeyword() : CqlKeyword.As) ??
                throw new InvalidOperationException($"Parser returned an unknown relative time qualifier '{context.relativeQualifier().GetText()}' in a concurrent-with interval expression.");

            if (!skipPointConversion)
            {
                var leftPoint = context.GetChild(0).ParseKeyword() switch
                {
                    CqlKeyword.Same => CqlKeyword.Occurs,
                    CqlKeyword.Starts => CqlKeyword.Starts,
                    CqlKeyword.Ends => CqlKeyword.Ends,
                    CqlKeyword.Occurs => CqlKeyword.Occurs,
                    _ => throw new InvalidOperationException($"Parser returned an unknown keyword '{context.GetChild(0).GetText()}' at the start of a concurrent-with interval expression.")
                };
                var leftLocator = context.GetChild(0).Locator()!;

                var rightPoint = context.children[^1].ParseKeyword() switch
                {
                    CqlKeyword.Start => CqlKeyword.Start,
                    CqlKeyword.End => CqlKeyword.End,
                    var q when qualifier == q => CqlKeyword.Occurs,
                    _ => throw new InvalidOperationException($"Parser returned an unknown keyword '{context.children[^1].GetText()}' at the end of a concurrent-with interval expression.")
                };
                var rightLocator = context.children[^1].Locator()!;

                var lhsPointType = PointType(lhs.resultTypeSpecifier)!;

                lhs = leftPoint switch
                {
                    CqlKeyword.Starts => new Start
                    {
                        operand = lhs,
                    }.WithLocator(leftLocator).WithResultType(lhsPointType),
                    CqlKeyword.Ends => new End
                    {
                        operand = lhs,
                    }.WithLocator(leftLocator).WithResultType(lhsPointType),
                    _ => lhs,
                };

                if (lhs.resultTypeSpecifier is not IntervalTypeSpecifier && rightPoint == CqlKeyword.Occurs)
                {
                    lhs = new Elm.Interval
                    {
                        low = lhs,
                        high = lhs,
                    }.WithLocator(leftLocator).WithResultType(lhsPointType.ToIntervalType());
                }

                var rhsPointType = PointType(rhs.resultTypeSpecifier)!;

                rhs = rightPoint switch
                {
                    CqlKeyword.Start => new Start
                    {
                        operand = rhs,
                    }.WithLocator(rightLocator).WithResultType(rhsPointType),
                    CqlKeyword.End => new End
                    {
                        operand = rhs,
                    }.WithLocator(rightLocator).WithResultType(rhsPointType),
                    _ => rhs,
                };

                if (rhs.resultTypeSpecifier is not IntervalTypeSpecifier && leftPoint == CqlKeyword.Occurs)
                {
                    rhs = new Elm.Interval
                    {
                        low = rhs,
                        high = rhs,
                    }.WithLocator(rightLocator).WithResultType(rhsPointType.ToIntervalType());
                }
            }

            var precision = context.dateTimePrecision()?.Parse() ?? default;

            return qualifier switch
            {
                CqlKeyword.Or_Before => new SameOrBefore
                {
                    precision = precision,
                    precisionSpecified = true,
                    operand = new[] { lhs, rhs },
                }.WithResultType(SystemTypes.BooleanType).WithLocator(context.Locator()),
                CqlKeyword.Or_After => new SameOrAfter
                {
                    precision = precision,
                    precisionSpecified = true,
                    operand = new[] { lhs, rhs },
                }.WithResultType(SystemTypes.BooleanType).WithLocator(context.Locator()),
                CqlKeyword.As => new SameAs
                {
                    precision = precision,
                    precisionSpecified = true,
                    operand = new[] { lhs, rhs },
                }.WithResultType(SystemTypes.BooleanType).WithLocator(context.Locator()),
                _ => throw new InvalidOperationException("Cannot happen, we have already checked for all possible values of qualifier.")
            };
        }
    }
}