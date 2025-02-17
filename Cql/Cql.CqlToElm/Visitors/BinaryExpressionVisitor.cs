using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.System;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Linq;
using System.Runtime.CompilerServices;

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

            var and = InvocationBuilder.Invoke(SystemLibrary.Operators.And, lhs, rhs);
            return and
                .WithId()
                .WithLocator(context.Locator());
        }

        // expressionTerm('+' | '-' | '&') expressionTerm                               #additionExpressionTerm
        public override Expression VisitAdditionExpressionTerm([NotNull] cqlParser.AdditionExpressionTermContext context)
        {
            var terms = context.expressionTerm();
            var lhs = Visit(terms[0]);
            var @operator = context.GetChild(1).GetText();
            var rhs = Visit(terms[1]);

            var invocation = @operator switch
            {
                "+" => InvocationBuilder.Invoke(SystemLibrary.Operators.Add, lhs, rhs),
                "-" => InvocationBuilder.Invoke(SystemLibrary.Operators.Subtract, lhs, rhs),
                "&" => InvocationBuilder.Invoke(SystemLibrary.Operators.Concatenate, lhs, rhs),
                _ => throw new InvalidOperationException($"Parser returned unknown token '{@operator}' in addition expression."),
            };
            return invocation
                .WithId()
                .WithLocator(context.Locator());
        }

        //    | 'difference' 'in' pluralDateTimePrecision 'between' expressionTerm 'and' expressionTerm       #differenceBetweenExpression
        public override Expression VisitDifferenceBetweenExpression([NotNull] cqlParser.DifferenceBetweenExpressionContext context) =>
            VisitBinaryWithPrecision(SystemLibrary.Operators.DifferenceBetween, context, context.pluralDateTimePrecision(), context.expressionTerm());

        //     | ('duration' 'in')? pluralDateTimePrecision 'between' expressionTerm 'and' expressionTerm      #durationBetweenExpression
        public override Expression VisitDurationBetweenExpression([NotNull] cqlParser.DurationBetweenExpressionContext context) =>
            VisitBinaryWithPrecision(SystemLibrary.Operators.DurationBetween, context, context.pluralDateTimePrecision(), context.expressionTerm());


        // | 'duration' 'in' pluralDateTimePrecision 'of' expressionTerm                   #durationExpressionTerm
        public override Expression VisitDurationExpressionTerm([NotNull] cqlParser.DurationExpressionTermContext context) =>
             handleDurationDifference(context.pluralDateTimePrecision(), context.expressionTerm(), SystemLibrary.Operators.DurationBetween)
                .WithLocator(context.Locator());

        // | 'difference' 'in' pluralDateTimePrecision 'of' expressionTerm                   #durationExpressionTerm
        public override Expression VisitDifferenceExpressionTerm([NotNull] cqlParser.DifferenceExpressionTermContext context) =>
             handleDurationDifference(context.pluralDateTimePrecision(), context.expressionTerm(), SystemLibrary.Operators.DifferenceBetween)
                .WithLocator(context.Locator());

        private Expression handleDurationDifference(cqlParser.PluralDateTimePrecisionContext precisionContext, cqlParser.ExpressionTermContext expressionTerms, OverloadedFunctionDef systemFunction)
        {
            var precision = Precision(precisionContext);
            var operand = Visit(expressionTerms);
            Expression lhs, rhs;
            if (operand.resultTypeSpecifier is IntervalTypeSpecifier { })
            {
                lhs = InvocationBuilder.Invoke(SystemLibrary.Operators.Start, operand);
                rhs = InvocationBuilder.Invoke(SystemLibrary.Operators.End, operand);
            }
            else
            {
                // this will result in an error condition
                lhs = operand;
                rhs = operand;
            }
            var expression = precision switch
            {
                { } => InvocationBuilder.Invoke(systemFunction, lhs, rhs, precision),
                _ => InvocationBuilder.Invoke(systemFunction, lhs, rhs),
            };
            return expression
                .WithId();
               
        }




        // | expression ('=' | '!=' | '~' | '!~') expression                                               #equalityExpression
        public override Expression VisitEqualityExpression([NotNull] cqlParser.EqualityExpressionContext context)
        {
            var expressions = context.expression();
            var lhs = Visit(expressions[0]);
            var @operator = context.GetChild(1).GetText();
            var rhs = Visit(expressions[1]);

            var expression = @operator switch
            {
                "=" => InvocationBuilder.Invoke(SystemLibrary.Operators.Equal, lhs, rhs),
                "!=" => InvocationBuilder.Invoke(SystemLibrary.Operators.NotEqual, lhs, rhs),
                "~" => InvocationBuilder.Invoke(SystemLibrary.Operators.Equivalent, lhs, rhs),
                "!~" => NotEquivalent(lhs, rhs),
                _ => throw new InvalidOperationException($"Parser returned unknown token '{@operator}' in equality expression.")
            };
            return expression
                .WithId()
                .WithLocator(context.Locator());

            Expression NotEquivalent(Expression lhs, Expression rhs)
            {
                var equivalent = InvocationBuilder.Invoke(SystemLibrary.Operators.Equivalent, lhs, rhs);
                var not = InvocationBuilder.Invoke(SystemLibrary.Operators.Not, equivalent);
                return not;
            }
        }

        //  expression 'implies' expression                                                               #impliesExpression
        public override Expression VisitImpliesExpression([NotNull] cqlParser.ImpliesExpressionContext context)
        {
            var expressions = context.expression();
            var lhs = Visit(expressions[0]);
            var rhs = Visit(expressions[1]);

            return InvocationBuilder.Invoke(SystemLibrary.Operators.Implies, lhs, rhs)
                .WithId()
                .WithLocator(context.Locator());
        }

        //    | expression ('<=' | '<' | '>' | '>=') expression                                               #inequalityExpression
        public override Expression VisitInequalityExpression([NotNull] cqlParser.InequalityExpressionContext context)
        {
            var expressions = context.expression();
            var lhs = Visit(expressions[0]);
            var @operator = context.GetChild(1).GetText();
            var rhs = Visit(expressions[1]);

            Expression result = @operator switch
            {
                ">" => InvocationBuilder.Invoke(SystemLibrary.Operators.Greater, lhs, rhs),
                ">=" => InvocationBuilder.Invoke(SystemLibrary.Operators.GreaterOrEqual, lhs, rhs),
                "<" => InvocationBuilder.Invoke(SystemLibrary.Operators.Less, lhs, rhs),
                "<=" => InvocationBuilder.Invoke(SystemLibrary.Operators.LessOrEqual, lhs, rhs),
                _ => throw new InvalidOperationException($"Parser returned unknown token '{@operator}' in inequality expression."),
            };

            return result
                .WithId()
                .WithLocator(context.Locator());
        }

        // | expressionTerm ('*' | '/' | 'div' | 'mod') expressionTerm                     #multiplicationExpressionTerm
        public override Expression VisitMultiplicationExpressionTerm([NotNull] cqlParser.MultiplicationExpressionTermContext context)
        {
            var expressionTerms = context.expressionTerm();
            var lhs = Visit(expressionTerms[0]);
            var @operator = context.GetChild(1).GetText();
            var rhs = Visit(expressionTerms[1]);

            var expression = @operator switch
            {
                "*" => InvocationBuilder.Invoke(SystemLibrary.Operators.Multiply, lhs, rhs),
                "/" => InvocationBuilder.Invoke(SystemLibrary.Operators.Divide, lhs, rhs),
                "div" => InvocationBuilder.Invoke(SystemLibrary.Operators.TruncatedDivide, lhs, rhs),
                "mod" => InvocationBuilder.Invoke(SystemLibrary.Operators.Modulo, lhs, rhs),
                _ => throw new InvalidOperationException($"Parser returned unknown token '{@operator}' in multiplication expression.")
            };
            return expression
                .WithId()
                .WithLocator(context.Locator());

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
                "or" => InvocationBuilder.Invoke(SystemLibrary.Operators.Or, lhs, rhs),
                "xor" => InvocationBuilder.Invoke(SystemLibrary.Operators.Xor, lhs, rhs),
                _ => throw new InvalidOperationException($"Parser returned unknown token '{@operator}' in (x)or expression.")
            };

            return result
                .WithId()
                .WithLocator(context.Locator());
        }

        //| expressionTerm '^' expressionTerm                                             #powerExpressionTerm
        public override Expression VisitPowerExpressionTerm([NotNull] cqlParser.PowerExpressionTermContext context)
        {
            var terms = context.expressionTerm();
            var lhs = Visit(terms[0]);
            var rhs = Visit(terms[1]);

            return InvocationBuilder.Invoke(SystemLibrary.Operators.Power, lhs, rhs)
                .WithId()
                .WithLocator(context.Locator());
        }

        public override Expression VisitIndexedExpressionTerm([NotNull] cqlParser.IndexedExpressionTermContext context)
        {
            var term = Visit(context.expressionTerm());
            var index = Visit(context.expression());
            var indexer = new Indexer
            {
                operand = new[] { term, index }
            };
            TypeSpecifier type;
            if (term.resultTypeSpecifier is ListTypeSpecifier listType)
                type = listType.elementType;
            else if (term.resultTypeSpecifier is NamedTypeSpecifier namedType)
            {
                if (namedType == SystemLibrary.StringType)
                    type = SystemLibrary.StringType;
                else
                {
                    indexer.AddError($"Unable to index type {namedType.name}");
                    type = SystemLibrary.AnyType;
                }
            }
            else
            {
                indexer.AddError($"Unable to index type {term.resultTypeSpecifier}");
                type = SystemLibrary.AnyType;
            }
            return indexer
                .WithLocator(context.Locator())
                .WithResultType(type);
        }

        // expression('in' | 'contains') dateTimePrecisionSpecifier? expression
        public override Expression VisitMembershipExpression([NotNull] cqlParser.MembershipExpressionContext context)
        {
            var terms = context.expression();
            var lhs = Visit(terms[0]);
            var rhs = Visit(terms[1]);

            Expression expression;
            if (context.GetChild(1).GetText() == "in")
            {
                var precision = Precision(context.dateTimePrecisionSpecifier());
                var args = precision is null ? new Expression[] { lhs, rhs } : new Expression[] { lhs, rhs, precision };
                if (rhs.resultTypeSpecifier == SystemLibrary.ValueSetType)
                {
                    return lhs.resultTypeSpecifier switch
                    {
                        ListTypeSpecifier or =>
                            InvocationBuilder.Invoke(SystemLibrary.Operators.AnyInValueSet, lhs, rhs),
                        GenericTypeSpecifier gts when gts.type?.name?.Name == Options.LiteralTypeNames.List =>
                            InvocationBuilder.Invoke(SystemLibrary.Operators.AnyInValueSet, lhs, rhs),
                        _ =>
                            InvocationBuilder.Invoke(SystemLibrary.Operators.InValueSet, lhs, rhs),
                    };
                }
                else
                {
                    var match = InvocationBuilder.MatchSignature(SystemLibrary.Operators.In, args);
                    if (match.Compatible)
                        expression = InvocationBuilder.Invoke(match);
                    else
                        expression = new In { operand = new[] { lhs, rhs } }
                            .AddError(Messaging.CouldNotResolveFunction(SystemLibrary.Operators.In.Name, lhs, rhs))
                            .WithResultType(SystemLibrary.BooleanType);
                }
            }
            else
            {
                var match = InvocationBuilder.MatchSignature(SystemLibrary.Operators.Contains, new[] { lhs, rhs });
                if (match.Compatible)
                    expression = InvocationBuilder.Invoke(match);
                else
                    expression = new Contains { operand = new[] { lhs, rhs } }
                        .AddError(Messaging.CouldNotResolveFunction(SystemLibrary.Operators.Contains.Name, lhs, rhs))
                        .WithResultType(SystemLibrary.BooleanType);
            }
            return expression
                .WithId()
                .WithLocator(context.Locator());

        }

        // expression ('|' | 'union' | 'intersect' | 'except') expression 
        public override Expression VisitInFixSetExpression([NotNull] cqlParser.InFixSetExpressionContext context)
        {
            var expressions = context.expression();
            var left = Visit(expressions[0]);
            var right = Visit(expressions[1]);
            var function = context.GetChild(1).GetText() switch
            {
                "|" or "union" => SystemLibrary.Operators.Union,
                "except" => SystemLibrary.Operators.Except,
                "intersect" => SystemLibrary.Operators.Intersect,
                _ => throw new InvalidOperationException($"Expectiong an infix set operator; found {context.GetChild(1).GetText()}")
            };
            var result = InvocationBuilder.Invoke(function, left, right);
            return result
                .WithId()
                .WithLocator(context.Locator());
        }

        //  ('expand' | 'collapse') expression ('per' (dateTimePrecision | expression))?
        public override Expression VisitSetAggregateExpressionTerm([NotNull] cqlParser.SetAggregateExpressionTermContext context)
        {
            var keyword = Keyword.Parse(context.GetChild(0));
            var dtp = context.dateTimePrecision()?.GetText();
            var expressions = context.expression().Select(Visit).ToArray();
            var function = keyword switch
            {
                CqlKeyword.Expand => SystemLibrary.Operators.Expand,
                CqlKeyword.Collapse => SystemLibrary.Operators.Collapse,
                _ => throw new InvalidOperationException($"Expecting collapse or expand, but found {keyword}")
            };
            var arguments = dtp switch
            {
                { } units => [.. expressions, ElmFactory.Quantity(1, units)],
                _ when expressions.Length is 1 => [.. expressions, ElmFactory.Null(SystemLibrary.QuantityType)],
                _ when expressions.Length is 2 => expressions,
                _ => throw new InvalidOperationException($"Expecting 1 or 2 arguments, but found {expressions.Length}")
            };
            return InvocationBuilder.Invoke(function, arguments)
                .WithId()
                .WithLocator(context.Locator());
        }

    }
}
