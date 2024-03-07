#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using System;
using System.Linq.Expressions;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        protected Expression After(elm.After e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e!.operand![0]!, ctx);
            var right = TranslateExpression(e.operand[1]!, ctx);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return ctx.OperatorBinding.Bind(CqlOperator.IntervalAfterInterval, ctx.RuntimeContextParameter, left, right, precision);
                }
                else
                {
                    return ctx.OperatorBinding.Bind(CqlOperator.IntervalAfterElement, ctx.RuntimeContextParameter, left, right, precision);
                }
            }
            else if (IsInterval(right.Type, out var rightElementType))
            {
                return ctx.OperatorBinding.Bind(CqlOperator.ElementAfterInterval, ctx.RuntimeContextParameter, left, right, precision);
            }
            else
            {
                return ctx.OperatorBinding.Bind(CqlOperator.After, ctx.RuntimeContextParameter, left, right, precision);
            }
        }

        protected Expression? Before(elm.Before e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e!.operand![0]!, ctx);
            var right = TranslateExpression(e.operand[1]!, ctx);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return ctx.OperatorBinding.Bind(CqlOperator.IntervalBeforeInterval, ctx.RuntimeContextParameter, left, right, precision);

                }
                else
                {
                    return ctx.OperatorBinding.Bind(CqlOperator.IntervalBeforeElement, ctx.RuntimeContextParameter, left, right, precision);
                }
            }
            else if (IsInterval(right.Type, out var rightElementType))
            {
                return ctx.OperatorBinding.Bind(CqlOperator.ElementBeforeInterval, ctx.RuntimeContextParameter, left, right, precision);
            }
            else
            {
                return ctx.OperatorBinding.Bind(CqlOperator.Before, ctx.RuntimeContextParameter, left, right, precision);
            }
        }
        protected Expression Date(elm.Date e, ExpressionBuilderContext ctx)
        {
            var year = (e.year != null) ? TranslateExpression(e.year, ctx) : Expression.Constant(null, typeof(int?));
            var month = (e.month != null) ? TranslateExpression(e.month, ctx) : Expression.Constant(null, typeof(int?));
            var day = (e.day != null) ? TranslateExpression(e.day, ctx) : Expression.Constant(null, typeof(int?));

            return ctx.OperatorBinding.Bind(CqlOperator.Date, ctx.RuntimeContextParameter, year, month, day);
        }

        protected Expression DateTime(elm.DateTime e, ExpressionBuilderContext ctx)
        {

            var year = e.year != null ? TranslateExpression(e.year, ctx) : Expression.Constant(null, typeof(int?));
            var month = e.month != null ? TranslateExpression(e.month, ctx) : Expression.Constant(null, typeof(int?));
            var day = e.day != null ? TranslateExpression(e.day, ctx) : Expression.Constant(null, typeof(int?));
            var hour = e.hour != null ? TranslateExpression(e.hour, ctx) : Expression.Constant(null, typeof(int?));
            var minute = e.minute != null ? TranslateExpression(e.minute, ctx) : Expression.Constant(null, typeof(int?));
            var second = e.second != null ? TranslateExpression(e.second, ctx) : Expression.Constant(null, typeof(int?));
            var milliseconds = e.millisecond != null ? TranslateExpression(e.millisecond, ctx) : Expression.Constant(null, typeof(int?));
            var offset = e.timezoneOffset != null ? TranslateExpression(e.timezoneOffset, ctx) : Expression.Constant(null, typeof(int?));
            if (offset.Type != typeof(decimal?))
            {
                offset = ChangeType(offset, typeof(decimal?), ctx);
            }

            return ctx.OperatorBinding.Bind(CqlOperator.DateTime, ctx.RuntimeContextParameter, year, month, day, hour, minute, second, milliseconds, offset);
        }

        /// <remarks>See https://cql.hl7.org/02-authorsguide.html#datetime-operators</remarks>
        protected Expression DateTimeComponentFrom(elm.DateTimeComponentFrom e, ExpressionBuilderContext ctx)
        {
            var op = TranslateExpression(e.operand!, ctx);
            switch (e.precision)
            {
                case elm.DateTimePrecision.Day:
                case elm.DateTimePrecision.Month:
                case elm.DateTimePrecision.Year:
                case elm.DateTimePrecision.Hour:
                case elm.DateTimePrecision.Minute:
                case elm.DateTimePrecision.Second:
                case elm.DateTimePrecision.Millisecond:
                    return ctx.OperatorBinding.Bind(CqlOperator.DateTimeComponent, ctx.RuntimeContextParameter, op, Precision(e.precision, e.precisionSpecified));
                default:
                    throw new NotSupportedException($"Unsupported date time component: {e.precision}");
            }
        }

        private Expression DateFrom(elm.DateFrom dfe, ExpressionBuilderContext ctx)
        {
            var op = TranslateExpression(dfe.operand!, ctx);
            return ctx.OperatorBinding.Bind(CqlOperator.DateComponent, ctx.RuntimeContextParameter, op);
        }

        protected Expression? DifferenceBetween(elm.DifferenceBetween e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            var precision = Precision(e.precision, e.precisionSpecified);
            return ctx.OperatorBinding.Bind(CqlOperator.DifferenceBetween, ctx.RuntimeContextParameter, left, right, precision);
        }

        protected Expression DurationBetween(elm.DurationBetween e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            var precision = Precision(e.precision, e.precisionSpecified);
            return ctx.OperatorBinding.Bind(CqlOperator.DurationBetween, ctx.RuntimeContextParameter, left, right, precision);
        }

        protected Expression? Now(elm.Now now, ExpressionBuilderContext ctx) =>
            ctx.OperatorBinding.Bind(CqlOperator.Now, ctx.RuntimeContextParameter);

        protected Expression? SameAs(elm.SameAs e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return ctx.OperatorBinding.Bind(CqlOperator.IntervalSameAs, ctx.RuntimeContextParameter, left, right, precision);
                }
                else
                    throw ctx.NewExpressionBuildingException();
            }
            else
            {
                return ctx.OperatorBinding.Bind(CqlOperator.SameAs, ctx.RuntimeContextParameter, left, right, precision);
            }
        }

        protected Expression SameOrAfter(elm.SameOrAfter e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return ctx.OperatorBinding.Bind(CqlOperator.IntervalSameOrAfter, ctx.RuntimeContextParameter, left, right, precision);
                }
                else
                    throw ctx.NewExpressionBuildingException();
            }
            else
            {
                return ctx.OperatorBinding.Bind(CqlOperator.SameOrAfter, ctx.RuntimeContextParameter, left, right, precision);
            }
        }

        protected Expression SameOrBefore(elm.SameOrBefore e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return ctx.OperatorBinding.Bind(CqlOperator.IntervalSameOrBefore, ctx.RuntimeContextParameter, left, right, precision);
                }
                else
                    throw ctx.NewExpressionBuildingException();
            }
            else
            {
                return ctx.OperatorBinding.Bind(CqlOperator.SameOrBefore, ctx.RuntimeContextParameter, left, right, precision);
            }
        }

        protected Expression Time(elm.Time e, ExpressionBuilderContext ctx)
        {
            var hour = e.hour != null ? TranslateExpression(e.hour, ctx) : Expression.Constant(null, typeof(int?));
            var minute = e.minute != null ? TranslateExpression(e.minute, ctx) : Expression.Constant(null, typeof(int?));
            var second = e.second != null ? TranslateExpression(e.second, ctx) : Expression.Constant(null, typeof(int?));
            var millisecond = e.millisecond != null ? TranslateExpression(e.millisecond, ctx) : Expression.Constant(null, typeof(int?));
            return ctx.OperatorBinding.Bind(CqlOperator.Time, ctx.RuntimeContextParameter, hour, minute, second, millisecond);
        }

        protected Expression? TimeOfDay(elm.TimeOfDay e, ExpressionBuilderContext ctx) =>
            ctx.OperatorBinding.Bind(CqlOperator.TimeOfDay, ctx.RuntimeContextParameter);

        protected Expression? TimezoneOffsetFrom(elm.TimezoneOffsetFrom e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.TimeZoneComponent, e, ctx);

        protected Expression? Today(elm.Today e, ExpressionBuilderContext ctx) =>
            ctx.OperatorBinding.Bind(CqlOperator.Today, ctx.RuntimeContextParameter);
    }
}
