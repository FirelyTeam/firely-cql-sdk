using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Linq;

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

            var and = SystemLibrary.And.Call(InvocationBuilder, context, lhs, rhs);
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
                    "+" => SystemLibrary.Add.Call(InvocationBuilder, context, new[] { lhs, rhs, }, out var _a),
                    "-" => SystemLibrary.Subtract.Call(InvocationBuilder, context, new[] { lhs, rhs, }, out var _s),
                    "&" => SystemLibrary.Concatenate.Call(InvocationBuilder, context, lhs, rhs),
                    _ => throw new InvalidOperationException($"Parser returned unknown token '{@operator}' in addition expression."),
                };

            return result;
        }

        //    | 'difference' 'in' pluralDateTimePrecision 'between' expressionTerm 'and' expressionTerm       #differenceBetweenExpression
        public override Expression VisitDifferenceBetweenExpression([NotNull] cqlParser.DifferenceBetweenExpressionContext context) =>
            VisitBinaryWithPrecision(SystemLibrary.DifferenceBetween, context, context.pluralDateTimePrecision(), context.expressionTerm());

        //     | ('duration' 'in')? pluralDateTimePrecision 'between' expressionTerm 'and' expressionTerm      #durationBetweenExpression
        public override Expression VisitDurationBetweenExpression([NotNull] cqlParser.DurationBetweenExpressionContext context) =>
            VisitBinaryWithPrecision(SystemLibrary.DurationBetween, context, context.pluralDateTimePrecision(), context.expressionTerm());


        // | expression ('=' | '!=' | '~' | '!~') expression                                               #equalityExpression
        public override Expression VisitEqualityExpression([NotNull] cqlParser.EqualityExpressionContext context)
        {
            var expressions = context.expression();
            var lhs = Visit(expressions[0]);
            var @operator = context.GetChild(1).GetText();
            var rhs = Visit(expressions[1]);

            return @operator switch
            {
                "=" => (Expression)SystemLibrary.Equal.Call(InvocationBuilder, context, lhs, rhs),
                "!=" => (Expression)SystemLibrary.NotEqual.Call(InvocationBuilder, context, lhs, rhs),
                "~" => (Expression)SystemLibrary.Equivalent.Call(InvocationBuilder, context, lhs, rhs),
                "!~" => (Expression)SystemLibrary.Not.Call(InvocationBuilder, context, SystemLibrary.Equivalent.Call(InvocationBuilder, context, lhs, rhs)),
                _ => throw new InvalidOperationException($"Parser returned unknown token '{@operator}' in equality expression."),
            };
        }

        //  expression 'implies' expression                                                               #impliesExpression
        public override Expression VisitImpliesExpression([NotNull] cqlParser.ImpliesExpressionContext context)
        {
            var expressions = context.expression();
            var lhs = Visit(expressions[0]);
            var rhs = Visit(expressions[1]);

            return SystemLibrary.Implies.Call(InvocationBuilder, context, lhs, rhs);
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
                ">" => SystemLibrary.Greater.Call(InvocationBuilder, context, new[] { lhs, rhs }, out var _),
                ">=" => SystemLibrary.GreaterOrEqual.Call(InvocationBuilder, context, new[] { lhs, rhs }, out var _),
                "<" => SystemLibrary.Less.Call(InvocationBuilder, context, new[] { lhs, rhs }, out var _),
                "<=" => SystemLibrary.LessOrEqual.Call(InvocationBuilder, context, new[] { lhs, rhs }, out var _),
                _ => throw new InvalidOperationException($"Parser returned unknown token '{@operator}' in inequality expression."),
            };

            return result;
        }

        // | expressionTerm ('*' | '/' | 'div' | 'mod') expressionTerm                     #multiplicationExpressionTerm
        public override Expression VisitMultiplicationExpressionTerm([NotNull] cqlParser.MultiplicationExpressionTermContext context)
        {
            var expressionTerms = context.expressionTerm();
            var lhs = Visit(expressionTerms[0]);
            var @operator = context.GetChild(1).GetText();
            var rhs = Visit(expressionTerms[1]);

            return @operator switch
            {
                "*" => SystemLibrary.Multiply.Call(InvocationBuilder, context, new[] { lhs, rhs }, out var _),
                "/" => SystemLibrary.Divide.Call(InvocationBuilder, context, new[] { lhs, rhs }, out var _),
                "div" => SystemLibrary.TruncatedDivide.Call(InvocationBuilder, context, new[] { lhs, rhs }, out var _),
                "mod" => SystemLibrary.Modulo.Call(InvocationBuilder, context, new[] { lhs, rhs }, out var _),
                _ => throw new InvalidOperationException($"Parser returned unknown token '{@operator}' in multiplication expression."),
            };
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
                "or" => SystemLibrary.Or.Call(InvocationBuilder, context, lhs, rhs),
                "xor" => SystemLibrary.Xor.Call(InvocationBuilder, context, lhs, rhs),
                _ => throw new InvalidOperationException($"Parser returned unknown token '{@operator}' in (x)or expression.")
            };

            return result;
        }

        //| expressionTerm '^' expressionTerm                                             #powerExpressionTerm
        public override Expression VisitPowerExpressionTerm([NotNull] cqlParser.PowerExpressionTermContext context)
        {
            var terms = context.expressionTerm();
            var lhs = Visit(terms[0]);
            var rhs = Visit(terms[1]);

            return SystemLibrary.Power.Call(InvocationBuilder, context, new[] { lhs, rhs }, out var _);
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
                if (namedType == SystemTypes.StringType)
                    type = SystemTypes.StringType;
                else
                {
                    indexer.AddError($"Unable to index type {namedType.name}");
                    type = SystemTypes.AnyType;
                }
            }
            else
            {
                indexer.AddError($"Unable to index type {term.resultTypeSpecifier}");
                type = SystemTypes.AnyType;
            }
            return indexer
                .WithLocator(context.Locator())
                .WithResultType(type);               
        }





    }
}
