
using Antlr4.Runtime;
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
    }
}