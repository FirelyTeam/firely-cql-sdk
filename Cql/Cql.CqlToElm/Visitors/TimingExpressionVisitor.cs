using Antlr4.Runtime.Tree;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal partial class ExpressionVisitor
    {
        internal static bool EnableDebugAssertions = true;

        //     | expression intervalOperatorPhrase expression                                                  #timingExpression
        public override Expression VisitTimingExpression([NotNull] cqlParser.TimingExpressionContext context)
        {
            var expressionChildren = context.expression();
            var lhs = Visit(expressionChildren[0]);
            var rhs = Visit(expressionChildren[1]);

            return context.intervalOperatorPhrase() switch
            {
                cqlParser.ConcurrentWithIntervalOperatorPhraseContext ctx => HandleConcurrentWith(ctx, lhs, rhs),
                cqlParser.IncludesIntervalOperatorPhraseContext ctx       => HandleIncludes(ctx, lhs, rhs),
                cqlParser.IncludedInIntervalOperatorPhraseContext ctx     => HandleIncludedIn(ctx, lhs, rhs),
                cqlParser.BeforeOrAfterIntervalOperatorPhraseContext ctx  => HandleBeforeOrAfter(ctx, lhs, rhs),
                cqlParser.WithinIntervalOperatorPhraseContext ctx         => HandleWithin(ctx, lhs, rhs),
                cqlParser.MeetsIntervalOperatorPhraseContext ctx          => HandleMeets(ctx, lhs, rhs),
                cqlParser.OverlapsIntervalOperatorPhraseContext ctx       => HandleOverlaps(ctx, lhs, rhs),
                cqlParser.StartsIntervalOperatorPhraseContext ctx         => HandleStarts(ctx, lhs, rhs),
                cqlParser.EndsIntervalOperatorPhraseContext ctx           => HandleEnds(ctx, lhs, rhs),

                _ => throw new NotImplementedException()
            };
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
                Debug.Assert(!EnableDebugAssertions || expression.GetErrors().Length == 0);
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
                Debug.Assert(!EnableDebugAssertions || expression.GetErrors().Length == 0);
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
            // This is a straight port from
            // https://github.com/cqframework/clinical_quality_language/blob/67145e3444eb126c3d4ae44c7e98c0ed222bc0c5/Src/java/cql-to-elm/src/main/java/org/cqframework/cql/cql2elm/Cql2ElmVisitor.java#L2169
            // with some minor adjustments to fit the C# style and conventions.
            // Written with the help of GTP-4.1, using the following prompt:
            // "Here is some Java code that parses the BeforeOrAfterIntervalOperatorPhrase: <insert Java code here>.
            // Port this code to C# and replace the current HandleBeforeOrAfter. Where Java creates Elm nodes (e.g. in Java of.createSameOrBefore),
            // use the equivalent C# call with the InvocationBuilder, for example InvocationBuilder.Invoke(SystemLibrary.SameOrBefore) is the same as the Java above."
            Expression left = lhs;
            Expression right = rhs;

            bool isBefore = false;
            bool isInclusive = false;

            // Handle point selectors (starts/ends/start/end)
            foreach (var child in context.children)
            {
                switch (child.GetText())
                {
                    case "starts":
                        left = InvocationBuilder.Invoke(SystemLibrary.Start, left);
                        continue;
                    case "ends":
                        left = InvocationBuilder.Invoke(SystemLibrary.End, left);
                        continue;
                    case "start":
                        right = InvocationBuilder.Invoke(SystemLibrary.Start, right);
                        continue;
                    case "end":
                        right = InvocationBuilder.Invoke(SystemLibrary.End, right);
                        continue;
                }
            }

            // Parse temporal relationship
            foreach (var child in context.temporalRelationship().children)
            {
                switch (child.GetText())
                {
                    case "before":
                        isBefore = true;
                        continue;
                    case "on or":
                    case "or on":
                        isInclusive = true;
                        continue;
                }
            }

            var dateTimePrecision = context.dateTimePrecisionSpecifier()?.dateTimePrecision();

            // No quantity offset
            if (context.quantityOffset() == null)
            {
                if (isInclusive)
                {
                    if (isBefore)
                    {
                        var args = dateTimePrecision != null
                            ? new[] { left, right, Precision(dateTimePrecision) }
                            : new[] { left, right };
                        return InvocationBuilder.Invoke(SystemLibrary.SameOrBefore, args)
                            .WithLocator(context.Locator());
                    }
                    else
                    {
                        var args = dateTimePrecision != null
                            ? new[] { left, right, Precision(dateTimePrecision) }
                            : new[] { left, right };
                        return InvocationBuilder.Invoke(SystemLibrary.SameOrAfter, args)
                            .WithLocator(context.Locator());
                    }
                }
                else
                {
                    if (isBefore)
                    {
                        var args = dateTimePrecision != null
                            ? new[] { left, right, Precision(dateTimePrecision) }
                            : new[] { left, right };
                        return InvocationBuilder.Invoke(SystemLibrary.Before, args)
                            .WithLocator(context.Locator());
                    }
                    else
                    {
                        var args = dateTimePrecision != null
                            ? new[] { left, right, Precision(dateTimePrecision) }
                            : new[] { left, right };
                        return InvocationBuilder.Invoke(SystemLibrary.After, args)
                            .WithLocator(context.Locator());
                    }
                }
            }
            else
            {
                // With quantity offset
                var quantity = Visit(context.quantityOffset().quantity());

                // Adjust left/right for interval types
                if (left.resultTypeSpecifier is IntervalTypeSpecifier)
                {
                    if (isBefore)
                        left = InvocationBuilder.Invoke(SystemLibrary.End, left);
                    else
                        left = InvocationBuilder.Invoke(SystemLibrary.Start, left);
                }
                if (right.resultTypeSpecifier is IntervalTypeSpecifier)
                {
                    if (isBefore)
                        right = InvocationBuilder.Invoke(SystemLibrary.Start, right);
                    else
                        right = InvocationBuilder.Invoke(SystemLibrary.End, right);
                }

                var offsetRel = context.quantityOffset().offsetRelativeQualifier();
                var exclRel = context.quantityOffset().exclusiveRelativeQualifier();

                if (offsetRel == null && exclRel == null)
                {
                    // Use SameAs
                    if (isBefore)
                        right = InvocationBuilder.Invoke(SystemLibrary.Subtract, right, quantity);
                    else
                        right = InvocationBuilder.Invoke(SystemLibrary.Add, right, quantity);

                    var args = dateTimePrecision != null
                        ? new[] { left, right, Precision(dateTimePrecision) }
                        : new[] { left, right };
                    return InvocationBuilder.Invoke(SystemLibrary.Same, args)
                        .WithLocator(context.Locator());
                }
                else
                {
                    var isOffsetInclusive = offsetRel != null;
                    var qualifier = offsetRel?.GetText() ?? exclRel.GetText();

                    switch (qualifier)
                    {
                        case "more than":
                        case "or more":
                            // For More Than/Or More, Use a Before/After/SameOrBefore/SameOrAfter
                            if (isBefore)
                            {
                                right = InvocationBuilder.Invoke(SystemLibrary.Subtract, right, quantity);

                                var args = dateTimePrecision != null
                                    ? new[] { left, right, Precision(dateTimePrecision) }
                                    : new[] { left, right };

                                if (!isOffsetInclusive)
                                {
                                    return InvocationBuilder.Invoke(SystemLibrary.Before, args)
                                        .WithLocator(context.Locator());
                                }
                                else
                                {
                                    return InvocationBuilder.Invoke(SystemLibrary.SameOrBefore, args)
                                        .WithLocator(context.Locator());
                                }
                            }
                            else
                            {
                                right = InvocationBuilder.Invoke(SystemLibrary.Add, right, quantity);

                                var args = dateTimePrecision != null
                                    ? new[] { left, right, Precision(dateTimePrecision) }
                                    : new[] { left, right };

                                if (!isOffsetInclusive)
                                {
                                    return InvocationBuilder.Invoke(SystemLibrary.After, args)
                                        .WithLocator(context.Locator());
                                }
                                else
                                {
                                    return InvocationBuilder.Invoke(SystemLibrary.SameOrAfter, args)
                                        .WithLocator(context.Locator());
                                }
                            }

                        case "less than":
                        case "or less":
                            // For Less Than/Or Less, Use an In
                            Expression lowerBound;
                            Expression upperBound;
                            if (isBefore)
                            {
                                lowerBound = InvocationBuilder.Invoke(SystemLibrary.Subtract, right, quantity);
                                upperBound = right;
                            }
                            else
                            {
                                lowerBound = right;
                                upperBound = InvocationBuilder.Invoke(SystemLibrary.Add, right, quantity);
                            }

                            // 3 days or less before -> [B - 3 days, B)
                            // less than 3 days before -> (B - 3 days, B)
                            // 3 days or less after -> (B, B + 3 days]
                            // less than 3 days after -> (B, B + 3 days)
                            var interval = isBefore
                                               ? InvocationBuilder.Invoke(
                                                   SystemLibrary.Interval,
                                                   lowerBound, upperBound, ElmFactory.Literal(isOffsetInclusive), ElmFactory.Literal(isInclusive)) :
                                               InvocationBuilder.Invoke(
                                                   SystemLibrary.Interval,
                                                   lowerBound, upperBound, ElmFactory.Literal(isInclusive), ElmFactory.Literal(isOffsetInclusive));

                            var inArgs = dateTimePrecision != null
                                ? new[] { left, interval, Precision(dateTimePrecision) }
                                : new[] { left, interval };

                            var @in = InvocationBuilder.Invoke(SystemLibrary.In, inArgs).WithLocator(context.Locator());

                            // If the offset or comparison is inclusive, add a null check for B to ensure correct interpretation
                            if (isOffsetInclusive || isInclusive)
                            {
                                var nullTest = InvocationBuilder.Invoke(SystemLibrary.IsNull, right);
                                var notNullTest = InvocationBuilder.Invoke(SystemLibrary.Not, nullTest);
                                var and = InvocationBuilder.Invoke(SystemLibrary.And, @in, notNullTest);
                                return and.WithLocator(context.Locator());
                            }

                            // Otherwise, return the constructed in
                            return @in;
                    }
                }
            }

            throw new InvalidOperationException("Unable to resolve interval operator phrase.");
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