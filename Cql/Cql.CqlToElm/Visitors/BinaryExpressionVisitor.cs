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

            return @operator switch
            {
                "=" => (Expression)SystemLibrary.Equal.Call(ModelProvider, context, lhs, rhs),
                "!=" => (Expression)SystemLibrary.NotEqual.Call(ModelProvider, context, lhs, rhs),
                "~" => (Expression)SystemLibrary.Equivalent.Call(ModelProvider, context, lhs, rhs),
                "!~" => (Expression)SystemLibrary.Not.Call(ModelProvider, context,
                                        SystemLibrary.Equivalent.Call(ModelProvider, context, lhs, rhs)),
                _ => throw new InvalidOperationException($"Parser returned unknown token '{@operator}' in equality expression."),
            };
        }

        //  expression 'implies' expression                                                               #impliesExpression
        public override Expression VisitImpliesExpression([NotNull] cqlParser.ImpliesExpressionContext context)
        {
            var expressions = context.expression();
            var lhs = Visit(expressions[0]);
            var rhs = Visit(expressions[1]);

            return SystemLibrary.Implies.Call(ModelProvider, context, lhs, rhs);
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
                ">" => SystemLibrary.Greater.Call(ModelProvider, context, lhs, rhs),
                ">=" => SystemLibrary.GreaterOrEqual.Call(ModelProvider, context, lhs, rhs),
                "<" => SystemLibrary.Less.Call(ModelProvider, context, lhs, rhs),
                "<=" => SystemLibrary.LessOrEqual.Call(ModelProvider, context, lhs, rhs),
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
                "*" => (Expression)SystemLibrary.Multiply.Call(ModelProvider, context, lhs, rhs),
                "/" => (Expression)SystemLibrary.Divide.Call(ModelProvider, context, lhs, rhs),
                "div" => (Expression)SystemLibrary.TruncatedDivide.Call(ModelProvider, context, lhs, rhs),
                "mod" => (Expression)SystemLibrary.Modulo.Call(ModelProvider, context, lhs, rhs),
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
                "or" => SystemLibrary.Or.Call(ModelProvider, context, lhs, rhs),
                "xor" => SystemLibrary.Xor.Call(ModelProvider, context, lhs, rhs),
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

            return SystemLibrary.Power.Call(ModelProvider, context, lhs, rhs);
        }
    }
}
