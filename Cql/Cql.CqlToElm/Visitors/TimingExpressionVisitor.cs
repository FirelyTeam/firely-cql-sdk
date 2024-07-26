using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq;

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
                cqlParser.BeforeOrAfterIntervalOperatorPhraseContext ctx => HandleBeforeOrAfter(ctx, lhs, rhs),
                cqlParser.WithinIntervalOperatorPhraseContext ctx => HandleWithin(ctx, lhs, rhs),
                cqlParser.MeetsIntervalOperatorPhraseContext ctx => HandleMeets(ctx, lhs, rhs),
                cqlParser.OverlapsIntervalOperatorPhraseContext ctx => HandleOverlaps(ctx, lhs, rhs),
                cqlParser.StartsIntervalOperatorPhraseContext ctx => HandleStarts(ctx, lhs, rhs),
                cqlParser.EndsIntervalOperatorPhraseContext ctx => HandleEnds(ctx, lhs, rhs),

                _ => throw new NotImplementedException()
            }; ;
        }

        private Expression HandleWithin(cqlParser.WithinIntervalOperatorPhraseContext context, Expression lhs, Expression rhs)
        {
            var kw0 = context.GetChild(0).GetText();
            var kw1 = context.GetChild(1).GetText();

            var properly = kw0 == "properly" || kw1 == "properly";
            var lhsPointType = PointType(lhs.resultTypeSpecifier);

            lhs = kw0 switch
            {
                "starts" => InvocationBuilder.Invoke(SystemLibrary.Start, lhs),
                "ends" => InvocationBuilder.Invoke(SystemLibrary.End, lhs),
                "occurs" => throw new NotImplementedException("Occurs is not supported yet"),
                _ => lhs
            };
            var (value, unit) = context.quantity().Parse();

            var quantity = ElmFactory.Quantity(value, unit);

            var kwLast = context.children[^1].GetText();

            var rhsClosed = properly ? ElmFactory.Literal(false) : ElmFactory.Literal(true);

            if (rhs.resultTypeSpecifier is IntervalTypeSpecifier)
            {
                if (kwLast == "start" || kwLast == "end")
                {
                    var intervalArgs = kwLast switch
                    {
                        "start" => new[]
                        {
                        InvocationBuilder.Invoke(SystemLibrary.Subtract,
                            [InvocationBuilder.Invoke(SystemLibrary.Start, rhs), quantity]),
                        InvocationBuilder.Invoke(SystemLibrary.Add,
                            [InvocationBuilder.Invoke(SystemLibrary.Start, rhs), quantity]),
                        rhsClosed,
                        rhsClosed,
                    },
                        "end" => new[]
                        {
                        InvocationBuilder.Invoke(SystemLibrary.Subtract,
                            [InvocationBuilder.Invoke(SystemLibrary.End, rhs), quantity]),
                        InvocationBuilder.Invoke(SystemLibrary.Add,
                            [InvocationBuilder.Invoke(SystemLibrary.End, rhs), quantity]),
                        rhsClosed,
                        rhsClosed,
                    },
                        _ => null // impossible
                    };
                    rhs = InvocationBuilder.Invoke(SystemLibrary.Interval, intervalArgs!);
                }
                else
                {
                    var intervalArgs = new[]
                    {
                        InvocationBuilder.Invoke(SystemLibrary.Subtract,
                            [InvocationBuilder.Invoke(SystemLibrary.Start, rhs), quantity]),
                        InvocationBuilder.Invoke(SystemLibrary.Add,
                            [InvocationBuilder.Invoke(SystemLibrary.End, rhs), quantity]),
                        rhsClosed,
                        rhsClosed,
                };
                    rhs = InvocationBuilder.Invoke(SystemLibrary.Interval, intervalArgs!);
                }
            }
            else
            {
                var intervalArgs = new[]
                {
                    rhs, rhs, ElmFactory.Literal(true), ElmFactory.Literal(true),
                };
                rhs = InvocationBuilder.Invoke(SystemLibrary.Interval, intervalArgs!);
            }

            var @in = (In)InvocationBuilder.Invoke(SystemLibrary.In, lhs, rhs);
            return @in
                .WithId()
                .WithLocator(context.Locator());
        }

        private Expression HandleIncludedIn(cqlParser.IncludedInIntervalOperatorPhraseContext context, Expression lhs, Expression rhs)
        {
            bool properly = false;
            var firstToken = context.GetChild(0).GetText();
            if (firstToken == "starts")
            {
                if (lhs.resultTypeSpecifier is IntervalTypeSpecifier lhsInterval)
                    lhs = new Start { operand = lhs }.WithResultType(lhsInterval.pointType);
                else return new In()
                        .WithLocator(context.Locator())
                        .WithId()
                        .WithResultType(SystemTypes.BooleanType)
                        .AddError(Messaging.CouldNotResolveFunction("Start", lhs.resultTypeSpecifier));
            }
            else if (firstToken == "ends")
            {
                if (lhs.resultTypeSpecifier is IntervalTypeSpecifier lhsInterval)
                    lhs = new End { operand = lhs }.WithResultType(lhsInterval.pointType);
                else return new In()
                        .WithLocator(context.Locator())
                        .WithId()
                        .WithResultType(SystemTypes.BooleanType)
                        .AddError(Messaging.CouldNotResolveFunction("End", lhs.resultTypeSpecifier));
            }
            else if (firstToken == "properly")
                properly = true;
            if (context.ChildCount > 1)
            {
                var secondToken = context.GetChild(1).GetText();
                if (secondToken == "properly")
                    properly = true;
            }
            var precision = Precision(context.dateTimePrecisionSpecifier());

            var args = precision is null ? new[] { lhs, rhs } : new[] { lhs, rhs, precision };

            // If we use only the overload matching here, we will end up with the wrong pick.
            // Specifically, expressions like:
            // Interval[1, 10] included in Interval[null, null]
            // Will cause the generic operand T to be cheapestly resolved as Any matching the
            // T, Interval<T> overload, which produces a ProperIn.
            // This is incorrect, as this expression should be a ProperIncludedIn.
            Expression expression;
            if (properly)
            {
                expression = lhs.resultTypeSpecifier switch
                {
                    IntervalTypeSpecifier or ListTypeSpecifier => InvocationBuilder.Invoke(SystemLibrary.ProperIncludedIn, args),
                    _ => InvocationBuilder.Invoke(SystemLibrary.ProperIn, args)
                };
                Debug.Assert(expression.GetErrors().Length == 0);
                return expression
                    .WithId()
                    .WithLocator(context.Locator());
            }
            else
            {
                expression = lhs.resultTypeSpecifier switch
                {
                    IntervalTypeSpecifier or ListTypeSpecifier => InvocationBuilder.Invoke(SystemLibrary.IncludedIn, args),
                    _ => InvocationBuilder.Invoke(SystemLibrary.In, args),

                };
                Debug.Assert(expression.GetErrors().Length == 0);
                return expression
                    .WithId()
                    .WithLocator(context.Locator());
            }
        }

        private Expression HandleOverlaps(cqlParser.OverlapsIntervalOperatorPhraseContext context, Expression lhs, Expression rhs)
        {
            var boa = context.ChildCount > 1 && context.GetChild(1) is ITerminalNode term ?
                term.GetText() : null;
            var precision = Precision(context.dateTimePrecisionSpecifier());
            var args = precision is null ? new[] { lhs, rhs } : new[] { lhs, rhs, precision };

            SystemFunction function = boa switch
            {
                null => SystemLibrary.Overlaps,
                "before" => SystemLibrary.OverlapsBefore,
                "after" => SystemLibrary.OverlapsAfter,
                _ => throw new InvalidOperationException($"Parser returned unknown token '{boa}' in an overlaps interval expression.")
            };
            var expression = InvocationBuilder.Invoke(function, args);
            return expression
                .WithId()
                .WithLocator(context.Locator());
        }

        // ('starts' | 'ends' | 'occurs')? quantityOffset? temporalRelationship dateTimePrecisionSpecifier? ('start' | 'end')? 
        private Expression HandleBeforeOrAfter(cqlParser.BeforeOrAfterIntervalOperatorPhraseContext context,
            Expression lhs,
            Expression rhs)
        {
            var relationship = context.temporalRelationship();
            if (relationship.ChildCount == 1)
            {
                var keyword = Keyword.Parse(relationship.GetChild(0));
                return keyword switch
                {
                    CqlKeyword.After => HandleAfter(context, lhs, rhs),
                    CqlKeyword.Before => HandleBefore(context, lhs, rhs),
                    _ => throw new NotImplementedException()
                };
            }
            else
            {
                var keyword1 = Keyword.Parse(relationship.GetChild(0));
                var keyword2 = Keyword.Parse(relationship.GetChild(1));
                return keyword1 switch
                {
                    CqlKeyword.On_Or when keyword2 is CqlKeyword.After => HandleOnOrAfter(context, lhs, rhs),
                    CqlKeyword.On_Or when keyword2 is CqlKeyword.Before => HandleOnOrBefore(context, lhs, rhs),
                    CqlKeyword.After when keyword2 is CqlKeyword.On_Or => throw new NotImplementedException(),
                    CqlKeyword.Before when keyword2 is CqlKeyword.On_Or => throw new NotImplementedException(),
                    _ => throw new NotImplementedException()
                };
            }
            throw new NotImplementedException();
        }

        private Expression HandleBefore(cqlParser.BeforeOrAfterIntervalOperatorPhraseContext context, Expression lhs, Expression rhs)
        {
            DateTimePrecision? precision = context.dateTimePrecisionSpecifier()?.dateTimePrecision().Parse();
            var before = new Before()
            {
                operand = new Expression[] { lhs, rhs },
            };
            if (precision.HasValue)
            {
                before.precision = precision.Value;
                before.precisionSpecified = true;
            }
            else
            {
                before.precisionSpecified = false;
            }
            return before
                .WithResultType(SystemTypes.BooleanType)
                .WithLocator(context.Locator());
        }
        private Expression HandleOnOrBefore(cqlParser.BeforeOrAfterIntervalOperatorPhraseContext context, Expression lhs, Expression rhs)
        {
            var precision = Precision(context.dateTimePrecisionSpecifier());
            (lhs, rhs) = (lhs.resultTypeSpecifier, rhs.resultTypeSpecifier) switch
            {
                (IntervalTypeSpecifier, not IntervalTypeSpecifier) => (lhs, PointInterval(rhs)),
                (not IntervalTypeSpecifier, IntervalTypeSpecifier) => (PointInterval(lhs), rhs),
                _ => (lhs, rhs)
            };
            var args = precision is null ? new[] { lhs, rhs } : new[] { lhs, rhs, precision };
            var expression = InvocationBuilder.Invoke(SystemLibrary.SameOrBefore, args);
            return expression
                .WithResultType(SystemTypes.BooleanType)
                .WithLocator(context.Locator());
        }
        private Expression HandleAfter(cqlParser.BeforeOrAfterIntervalOperatorPhraseContext context, Expression lhs, Expression rhs)
        {
            DateTimePrecision? precision = context.dateTimePrecisionSpecifier()?.dateTimePrecision().Parse();
            var after = new After()
            {
                operand = new Expression[] { lhs, rhs },
            };
            if (precision.HasValue)
            {
                after.precision = precision.Value;
                after.precisionSpecified = true;
            }
            else
            {
                after.precisionSpecified = false;
            }
            return after
                .WithResultType(SystemTypes.BooleanType)
                .WithLocator(context.Locator());
        }
        private Expression HandleOnOrAfter(cqlParser.BeforeOrAfterIntervalOperatorPhraseContext context, Expression lhs, Expression rhs)
        {
            var precision = Precision(context.dateTimePrecisionSpecifier());

            // These timing phrases have complicated operand setups.
            // Depending on the phrase, setup lhs and rhs operands.
            cqlParser.QuantityOffsetContext? offset;
            if (lhs.resultTypeSpecifier is IntervalTypeSpecifier lhsInterval
                && (offset = context.quantityOffset()) != null)
            {
                var quantity = Visit(offset.quantity());
                // or more | or less
                var offsetRelative = offset.offsetRelativeQualifier()?.GetText();
                if (offsetRelative is not null)
                {
                    if (offsetRelative == "or more")
                    {
                        if (rhs.resultTypeSpecifier is IntervalTypeSpecifier rhsInterval)
                        {
                            rhs = new Start
                            {
                                operand = rhs
                            }.WithResultType(rhsInterval.pointType);
                        }
                        lhs = new Start { operand = lhs, }
                            .WithResultType(lhsInterval.pointType);

                        rhs = new Add { operand = new Expression[] { rhs, quantity, } }
                            .WithResultType(rhs.resultTypeSpecifier);
                    }
                    else if (offsetRelative == "or less")
                    {
                        // this case is an exception.
                        // this mirrors the generation done for this operator by the reference cql-to-elm implementation
                        // it's weird
                        var @in = new In
                        {
                            operand = new Expression[]
                            {
                                    new Start { operand = lhs }.WithResultType(lhsInterval.pointType),
                                    new Elm.Interval
                                    {
                                        low = rhs,
                                        high = new Add
                                        {
                                            operand = new[]
                                            {
                                                rhs,
                                                quantity
                                            }
                                        }.WithResultType(rhs.resultTypeSpecifier)
                                    }.WithResultType(lhsInterval.resultTypeSpecifier)
                            }
                        }.WithResultType(SystemTypes.BooleanType);
                        if (precision != null)
                        {
                            if (Enum.TryParse<DateTimePrecision>(precision.value, out var dtp))
                            {
                                @in.precisionSpecified = true;
                                @in.precision = dtp;
                            }
                            else @in.AddError($"Unknown precision '{precision.value}'.");
                        }
                        var not = new Not
                        {
                            operand = new IsNull
                            {
                                operand = rhs
                            }.WithResultType(SystemTypes.BooleanType)
                        }.WithResultType(SystemTypes.BooleanType);
                        var and = new And
                        {
                            operand = new Expression[] { @in, not }
                        }.WithResultType(SystemTypes.BooleanType);
                        return and
                            .WithId()
                            .WithLocator(context.Locator());
                    }
                }
                // less than | more than
                var exclusiveRelative = offset.exclusiveRelativeQualifier();
                if (exclusiveRelative is not null)
                {
                    throw new NotImplementedException();
                }
            }
            (lhs, rhs) = (lhs.resultTypeSpecifier, rhs.resultTypeSpecifier) switch
            {
                (IntervalTypeSpecifier, not IntervalTypeSpecifier) => (lhs, PointInterval(rhs)),
                (not IntervalTypeSpecifier, IntervalTypeSpecifier) => (PointInterval(lhs), rhs),
                _ => (lhs, rhs)
            };
            var args = precision is null ? new Expression[] { lhs, rhs } : new Expression[] { lhs, rhs, precision };
            var expression = InvocationBuilder.Invoke(SystemLibrary.SameOrAfter, args);
            return expression
                .WithId()
                .WithLocator(context.Locator());
        }

        // | 'meets'('before' | 'after') ? dateTimePrecisionSpecifier ?                                                             #meetsIntervalOperatorPhrase
        private Expression HandleMeets(cqlParser.MeetsIntervalOperatorPhraseContext context,
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
            var dtp = context.dateTimePrecisionSpecifier();
            Expression expression;
            if (dtp is null)
                expression = InvocationBuilder.Invoke(SystemLibrary.Starts, lhs, rhs);
            else
            {
                var precision = Precision(dtp);
                expression = precision switch
                {
                    { } => InvocationBuilder.Invoke(SystemLibrary.Starts, lhs, rhs, precision),
                    _ => InvocationBuilder.Invoke(SystemLibrary.Starts, lhs, rhs),
                };
            }
            return expression
                .WithId()
                .WithLocator(context.Locator());
        }

        // | 'ends' dateTimePrecisionSpecifier?                                                                                    #endsIntervalOperatorPhrase
        private Expression HandleEnds(cqlParser.EndsIntervalOperatorPhraseContext context,
                Expression lhs,
                Expression rhs)
        {
            var dtp = context.dateTimePrecisionSpecifier();
            Expression expression;
            if (dtp is null)
                expression = InvocationBuilder.Invoke(SystemLibrary.Ends, lhs, rhs);
            else
            {
                var precision = Precision(dtp);
                expression = precision switch
                {
                    { } => InvocationBuilder.Invoke(SystemLibrary.Ends, lhs, rhs, precision),
                    _ => InvocationBuilder.Invoke(SystemLibrary.Ends, lhs, rhs),
                };
            }
            return expression
                .WithId()
                .WithLocator(context.Locator());
        }

        //| 'properly'? 'includes' dateTimePrecisionSpecifier? ('start' | 'end')?
        private Expression HandleIncludes(cqlParser.IncludesIntervalOperatorPhraseContext context,
                Expression lhs,
                Expression rhs)
        {
            var firstKeyword = context.GetChild(0).GetText();
            var properly = firstKeyword == "properly";

            var precision = Precision(context.dateTimePrecisionSpecifier());

            var startEnd = context.children[^1].GetText();
            var rhsPointType = PointType(rhs.resultTypeSpecifier);
            var startEndLocator = context.children[^1].Locator()!;

            // IntervalIncludes for 2 intervals
            // IntervalContains for 1 interval, 1 point
            if (startEnd == "start")
            {
                rhs = new Start
                {
                    operand = rhs,
                }.WithLocator(startEndLocator).WithResultType(rhsPointType!);
            }
            else if (startEnd == "end")
            {
                rhs = new End
                {
                    operand = rhs,
                }.WithLocator(startEndLocator).WithResultType(rhsPointType!);
            }

            var args = precision is null ? new[] { lhs, rhs } : new[] { lhs, rhs, precision };

            if (properly)
                return InvocationBuilder.Invoke(SystemLibrary.ProperIncludes, args)
                    .WithId()
                    .WithLocator(context.Locator());
            else
                return InvocationBuilder.Invoke(SystemLibrary.Includes, args)
                    .WithId()
                    .WithLocator(context.Locator());
        }

        //: ('starts' | 'ends' | 'occurs')? 'same' dateTimePrecision? (relativeQualifier | 'as') ('start' | 'end')?               #concurrentWithIntervalOperatorPhrase
        private Expression HandleConcurrentWith(cqlParser.ConcurrentWithIntervalOperatorPhraseContext context,
                Expression lhs,
                Expression rhs)
        {
            var skipPointConversion = context.ChildCount == 3 && context.dateTimePrecision() is not null;

            var qualifier = (context.relativeQualifier() is { } tree ? tree.Parse() : CqlKeyword.As) ??
                throw new InvalidOperationException($"Parser returned an unknown relative time qualifier '{context.relativeQualifier().GetText()}' in a concurrent-with interval expression.");

            if (!skipPointConversion)
            {
                var leftPoint = context.GetChild(0).Parse() switch
                {
                    CqlKeyword.Same => CqlKeyword.Occurs,
                    CqlKeyword.Starts => CqlKeyword.Starts,
                    CqlKeyword.Ends => CqlKeyword.Ends,
                    CqlKeyword.Occurs => CqlKeyword.Occurs,
                    _ => throw new InvalidOperationException($"Parser returned an unknown keyword '{context.GetChild(0).GetText()}' at the start of a concurrent-with interval expression.")
                };
                var leftLocator = context.GetChild(0).Locator()!;

                var rightPoint = context.children[^1].Parse() switch
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

        private If PointInterval(Expression point) =>
                new If
                {
                    condition = new IsNull
                    {
                        operand = point
                    }.WithResultType(SystemTypes.BooleanType),
                    then = new As
                    {
                        operand = new Null(),
                        asTypeSpecifier = point.resultTypeSpecifier.ToIntervalType()
                    }.WithResultType(point.resultTypeSpecifier.ToIntervalType()),
                    @else = new Elm.Interval
                    {
                        low = point,
                        high = point,
                        lowClosed = true,
                        highClosed = true,
                    }.WithResultType(point.resultTypeSpecifier.ToIntervalType())
                }.WithResultType(point.resultTypeSpecifier.ToIntervalType());
    }
}