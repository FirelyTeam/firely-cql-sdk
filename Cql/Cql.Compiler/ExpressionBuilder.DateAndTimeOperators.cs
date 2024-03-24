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
    internal partial class ContextualExpressionBuilder
    {
        protected Expression After(elm.After e)
        {
            var left = TranslateExpression(e!.operand![0]!);
            var right = TranslateExpression(e.operand[1]!);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return OperatorBinding.Bind(CqlOperator.IntervalAfterInterval, RuntimeContextParameter, left, right, precision);
                }
                else
                {
                    return OperatorBinding.Bind(CqlOperator.IntervalAfterElement, RuntimeContextParameter, left, right, precision);
                }
            }
            else if (IsInterval(right.Type, out var rightElementType))
            {
                return OperatorBinding.Bind(CqlOperator.ElementAfterInterval, RuntimeContextParameter, left, right, precision);
            }
            else
            {
                return OperatorBinding.Bind(CqlOperator.After, RuntimeContextParameter, left, right, precision);
            }
        }

        protected Expression? Before(elm.Before e)
        {
            var left = TranslateExpression(e!.operand![0]!);
            var right = TranslateExpression(e.operand[1]!);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return OperatorBinding.Bind(CqlOperator.IntervalBeforeInterval, RuntimeContextParameter, left, right, precision);

                }
                else
                {
                    return OperatorBinding.Bind(CqlOperator.IntervalBeforeElement, RuntimeContextParameter, left, right, precision);
                }
            }
            else if (IsInterval(right.Type, out var rightElementType))
            {
                return OperatorBinding.Bind(CqlOperator.ElementBeforeInterval, RuntimeContextParameter, left, right, precision);
            }
            else
            {
                return OperatorBinding.Bind(CqlOperator.Before, RuntimeContextParameter, left, right, precision);
            }
        }
        protected Expression Date(elm.Date e)
        {
            var year = (e.year != null) ? TranslateExpression(e.year) : Expression.Constant(null, typeof(int?));
            var month = (e.month != null) ? TranslateExpression(e.month) : Expression.Constant(null, typeof(int?));
            var day = (e.day != null) ? TranslateExpression(e.day) : Expression.Constant(null, typeof(int?));

            return OperatorBinding.Bind(CqlOperator.Date, RuntimeContextParameter, year, month, day);
        }

        protected Expression DateTime(elm.DateTime e)
        {
            var year = e.year != null ? TranslateExpression(e.year) : Expression.Constant(null, typeof(int?));
            var month = e.month != null ? TranslateExpression(e.month) : Expression.Constant(null, typeof(int?));
            var day = e.day != null ? TranslateExpression(e.day) : Expression.Constant(null, typeof(int?));
            var hour = e.hour != null ? TranslateExpression(e.hour) : Expression.Constant(null, typeof(int?));
            var minute = e.minute != null ? TranslateExpression(e.minute) : Expression.Constant(null, typeof(int?));
            var second = e.second != null ? TranslateExpression(e.second) : Expression.Constant(null, typeof(int?));
            var milliseconds = e.millisecond != null ? TranslateExpression(e.millisecond) : Expression.Constant(null, typeof(int?));
            var offset = e.timezoneOffset != null ? TranslateExpression(e.timezoneOffset) : Expression.Constant(null, typeof(int?));
            if (offset.Type != typeof(decimal?))
            {
                offset = ChangeType(offset, typeof(decimal?));
            }

            return OperatorBinding.Bind(CqlOperator.DateTime, RuntimeContextParameter, year, month, day, hour, minute, second, milliseconds, offset);
        }

        /// <remarks>See https://cql.hl7.org/02-authorsguide.html#datetime-operators</remarks>
        protected Expression DateTimeComponentFrom(elm.DateTimeComponentFrom e)
        {
            var op = TranslateExpression(e.operand!);
            switch (e.precision)
            {
                case elm.DateTimePrecision.Day:
                case elm.DateTimePrecision.Month:
                case elm.DateTimePrecision.Year:
                case elm.DateTimePrecision.Hour:
                case elm.DateTimePrecision.Minute:
                case elm.DateTimePrecision.Second:
                case elm.DateTimePrecision.Millisecond:
                    return OperatorBinding.Bind(CqlOperator.DateTimeComponent, RuntimeContextParameter, op, Precision(e.precision, e.precisionSpecified));
                default:
                    throw new NotSupportedException($"Unsupported date time component: {e.precision}");
            }
        }

        private Expression DateFrom(elm.DateFrom dfe)
        {
            var op = TranslateExpression(dfe.operand!);
            return OperatorBinding.Bind(CqlOperator.DateComponent, RuntimeContextParameter, op);
        }

        protected Expression? DifferenceBetween(elm.DifferenceBetween e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            var precision = Precision(e.precision, e.precisionSpecified);
            return OperatorBinding.Bind(CqlOperator.DifferenceBetween, RuntimeContextParameter, left, right, precision);
        }

        protected Expression DurationBetween(elm.DurationBetween e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            var precision = Precision(e.precision, e.precisionSpecified);
            return OperatorBinding.Bind(CqlOperator.DurationBetween, RuntimeContextParameter, left, right, precision);
        }

        protected Expression? Now(elm.Now now) =>
            OperatorBinding.Bind(CqlOperator.Now, RuntimeContextParameter);

        protected Expression? SameAs(elm.SameAs e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return OperatorBinding.Bind(CqlOperator.IntervalSameAs, RuntimeContextParameter, left, right, precision);
                }
                else
                    throw this.NewExpressionBuildingException();
            }
            else
            {
                return OperatorBinding.Bind(CqlOperator.SameAs, RuntimeContextParameter, left, right, precision);
            }
        }

        protected Expression SameOrAfter(elm.SameOrAfter e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return OperatorBinding.Bind(CqlOperator.IntervalSameOrAfter, RuntimeContextParameter, left, right, precision);
                }
                else
                    throw this.NewExpressionBuildingException();
            }
            else
            {
                return OperatorBinding.Bind(CqlOperator.SameOrAfter, RuntimeContextParameter, left, right, precision);
            }
        }

        protected Expression SameOrBefore(elm.SameOrBefore e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return OperatorBinding.Bind(CqlOperator.IntervalSameOrBefore, RuntimeContextParameter, left, right, precision);
                }
                else
                    throw this.NewExpressionBuildingException();
            }
            else
            {
                return OperatorBinding.Bind(CqlOperator.SameOrBefore, RuntimeContextParameter, left, right, precision);
            }
        }

        protected Expression Time(elm.Time e)
        {
            var hour = e.hour != null ? TranslateExpression(e.hour) : Expression.Constant(null, typeof(int?));
            var minute = e.minute != null ? TranslateExpression(e.minute) : Expression.Constant(null, typeof(int?));
            var second = e.second != null ? TranslateExpression(e.second) : Expression.Constant(null, typeof(int?));
            var millisecond = e.millisecond != null ? TranslateExpression(e.millisecond) : Expression.Constant(null, typeof(int?));
            return OperatorBinding.Bind(CqlOperator.Time, RuntimeContextParameter, hour, minute, second, millisecond);
        }

        protected Expression? TimeOfDay(elm.TimeOfDay e) =>
            OperatorBinding.Bind(CqlOperator.TimeOfDay, RuntimeContextParameter);

        protected Expression? TimezoneOffsetFrom(elm.TimezoneOffsetFrom e) =>
            UnaryOperator(CqlOperator.TimeZoneComponent, e);

        protected Expression? Today(elm.Today e) =>
            OperatorBinding.Bind(CqlOperator.Today, RuntimeContextParameter);
    }
}
