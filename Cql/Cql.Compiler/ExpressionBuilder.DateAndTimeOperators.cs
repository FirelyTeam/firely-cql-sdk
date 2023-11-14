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
                    return OperatorBinding.Bind(CqlOperator.IntervalAfterInterval, ctx.CqlContextParameter, left, right, precision);
                }
                else
                {
                    return OperatorBinding.Bind(CqlOperator.IntervalAfterElement, ctx.CqlContextParameter, left, right, precision);
                }
            }
            else if (IsInterval(right.Type, out var rightElementType))
            {
                return OperatorBinding.Bind(CqlOperator.ElementAfterInterval, ctx.CqlContextParameter, left, right, precision);
            }
            else
            {
                return OperatorBinding.Bind(CqlOperator.After, ctx.CqlContextParameter, left, right, precision);
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
                    return OperatorBinding.Bind(CqlOperator.IntervalBeforeInterval, ctx.CqlContextParameter, left, right, precision);

                }
                else
                {
                    return OperatorBinding.Bind(CqlOperator.IntervalBeforeElement, ctx.CqlContextParameter, left, right, precision);
                }
            }
            else if (IsInterval(right.Type, out var rightElementType))
            {
                return OperatorBinding.Bind(CqlOperator.ElementBeforeInterval, ctx.CqlContextParameter, left, right, precision);
            }
            else
            {
                return OperatorBinding.Bind(CqlOperator.Before, ctx.CqlContextParameter, left, right, precision);
            }
        }
        protected Expression Date(elm.Date e, ExpressionBuilderContext ctx)
        {
            var year = (e.year != null) ? TranslateExpression(e.year, ctx) : Expression.Constant(null, typeof(int?));
            var month = (e.month != null) ? TranslateExpression(e.month, ctx) : Expression.Constant(null, typeof(int?));
            var day = (e.day != null) ? TranslateExpression(e.day, ctx) : Expression.Constant(null, typeof(int?));

            return OperatorBinding.Bind(CqlOperator.Date, ctx.CqlContextParameter, year, month, day);
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

            return OperatorBinding.Bind(CqlOperator.DateTime, ctx.CqlContextParameter, year, month, day, hour, minute, second, milliseconds, offset);
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
                    return OperatorBinding.Bind(CqlOperator.DateTimeComponent, ctx.CqlContextParameter, op, Precision(e.precision, e.precisionSpecified));
                default:
                    throw new NotSupportedException($"Unsupported date time component: {e.precision}");
            }
        }

        private Expression DateFrom(elm.DateFrom dfe, ExpressionBuilderContext ctx)
        {
            var op = TranslateExpression(dfe.operand!, ctx);
            return OperatorBinding.Bind(CqlOperator.DateComponent, ctx.CqlContextParameter, op);
        }

        protected Expression? DifferenceBetween(elm.DifferenceBetween e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            var precision = Precision(e.precision, e.precisionSpecified);
            return OperatorBinding.Bind(CqlOperator.DifferenceBetween, ctx.CqlContextParameter, left, right, precision);
        }

        protected Expression DurationBetween(elm.DurationBetween e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            var precision = Precision(e.precision, e.precisionSpecified);
            return OperatorBinding.Bind(CqlOperator.DurationBetween, ctx.CqlContextParameter, left, right, precision);
        }

        protected Expression? Now(elm.Now now, ExpressionBuilderContext ctx) =>
            OperatorBinding.Bind(CqlOperator.Now, ctx.CqlContextParameter);

        protected Expression? SameAs(elm.SameAs e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return OperatorBinding.Bind(CqlOperator.IntervalSameAs, ctx.CqlContextParameter, left, right, precision);
                }
                else
                    throw new InvalidOperationException();
            }
            else
            {
                return OperatorBinding.Bind(CqlOperator.SameAs, ctx.CqlContextParameter, left, right, precision);
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
                    return OperatorBinding.Bind(CqlOperator.IntervalSameOrAfter, ctx.CqlContextParameter, left, right, precision);
                }
                else
                    throw new InvalidOperationException();
            }
            else
            {
                return OperatorBinding.Bind(CqlOperator.SameOrAfter, ctx.CqlContextParameter, left, right, precision);
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
                    return OperatorBinding.Bind(CqlOperator.IntervalSameOrBefore, ctx.CqlContextParameter, left, right, precision);
                }
                else
                    throw new InvalidOperationException();
            }
            else
            {
                return OperatorBinding.Bind(CqlOperator.SameOrBefore, ctx.CqlContextParameter, left, right, precision);
            }
        }

        protected Expression Time(elm.Time e, ExpressionBuilderContext ctx)
        {
            var hour = e.hour != null ? TranslateExpression(e.hour, ctx) : Expression.Constant(null, typeof(int?));
            var minute = e.minute != null ? TranslateExpression(e.minute, ctx) : Expression.Constant(null, typeof(int?));
            var second = e.second != null ? TranslateExpression(e.second, ctx) : Expression.Constant(null, typeof(int?));
            var millisecond = e.millisecond != null ? TranslateExpression(e.millisecond, ctx) : Expression.Constant(null, typeof(int?));
            return OperatorBinding.Bind(CqlOperator.Time, ctx.CqlContextParameter, hour, minute, second, millisecond);
        }

        protected Expression? TimeOfDay(elm.TimeOfDay e, ExpressionBuilderContext ctx) =>
            OperatorBinding.Bind(CqlOperator.TimeOfDay, ctx.CqlContextParameter);

        protected Expression? TimezoneOffsetFrom(elm.TimezoneOffsetFrom e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.TimeZoneComponent, e, ctx);

        protected Expression? Today(elm.Today e, ExpressionBuilderContext ctx) =>
            OperatorBinding.Bind(CqlOperator.Today, ctx.CqlContextParameter);
    }
}
