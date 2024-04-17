#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Elm;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        protected Expression After(Elm.After e)
        {
            var expr = TranslateExpressions(e.operand[0], e.operand[1], e.precisionOrNull())!;
            var leftIsCqlInterval = expr[0].Type.IsCqlInterval(out _);
            var rightIsCqlInterval = expr[1].Type.IsCqlInterval(out _);
            var method = (leftIsCqlInterval, rightIsCqlInterval) switch
            {
                (true, true)  => CqlOperator.IntervalAfterInterval,
                (true, false) => CqlOperator.IntervalAfterElement,
                (false, true) => CqlOperator.ElementAfterInterval,
                _             => CqlOperator.After
            };
            return BindCqlOperator(method, expr);
        }

        protected Expression? Before(Elm.Before e)
        {
            var expr = TranslateExpressions(e.operand[0], e.operand[1], e.precisionOrNull())!;
            var leftIsCqlInterval = expr[0].Type.IsCqlInterval(out _);
            var rightIsCqlInterval = expr[1].Type.IsCqlInterval(out _);
            var method = (leftIsCqlInterval, rightIsCqlInterval) switch
            {
                (true, true)  => CqlOperator.IntervalBeforeInterval,
                (true, false) => CqlOperator.IntervalBeforeElement,
                (false, true) => CqlOperator.ElementBeforeInterval,
                _             => CqlOperator.Before
            };
            return BindCqlOperator(method, expr);
        }

        protected Expression DateTime(Elm.DateTime e)
        {
            var offset = e.timezoneOffset is { } tzo ? TranslateExpression(tzo) : NullConstantExpression.Int32;
            if (offset.Type != typeof(decimal?))
            {
                offset = ChangeType(offset, typeof(decimal?));
            }

            return BindCqlOperator(CqlOperator.DateTime,
                e.year,
                e.month,
                e.day,
                e.hour,
                e.minute,
                e.second,
                e.millisecond,
                offset);
        }

        protected Expression? SameAs(Elm.SameAs e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            var precision = e.precisionOrNull();
            if (left.Type.IsCqlInterval(out _))
            {
                return right.Type.IsCqlInterval(out _)
                    ? BindCqlOperator(CqlOperator.IntervalSameAs, left, right, precision)
                    : throw this.NewExpressionBuildingException();
            }

            return BindCqlOperator(CqlOperator.SameAs, left, right, precision);
        }

        protected Expression SameOrAfter(Elm.SameOrAfter e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            var precision = e.precisionOrNull();
            if (left.Type.IsCqlInterval(out _))
            {
                return right.Type.IsCqlInterval(out _)
                    ? BindCqlOperator(CqlOperator.IntervalSameOrAfter, left, right, precision)
                    : throw this.NewExpressionBuildingException();
            }

            return BindCqlOperator(CqlOperator.SameOrAfter, left, right, precision);
        }

        protected Expression SameOrBefore(Elm.SameOrBefore e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            var precision = e.precisionOrNull();

            if (left.Type.IsCqlInterval(out _))
            {
                return right.Type.IsCqlInterval(out _)
                    ? BindCqlOperator(CqlOperator.IntervalSameOrBefore, left, right, precision)
                    : throw this.NewExpressionBuildingException();
            }

            return BindCqlOperator(CqlOperator.SameOrBefore, left, right, precision);
        }
    }
}
