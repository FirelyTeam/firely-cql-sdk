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
    internal partial class ExpressionBuilderContext
    {
        protected Expression After(elm.After e)
        {
            var left = this.TranslateExpression(e!.operand![0]!);
            var right = this.TranslateExpression(e.operand[1]!);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return this.OperatorBinding.Bind(CqlOperator.IntervalAfterInterval, this.RuntimeContextParameter, left, right, precision);
                }
                else
                {
                    return this.OperatorBinding.Bind(CqlOperator.IntervalAfterElement, this.RuntimeContextParameter, left, right, precision);
                }
            }
            else if (IsInterval(right.Type, out var rightElementType))
            {
                return this.OperatorBinding.Bind(CqlOperator.ElementAfterInterval, this.RuntimeContextParameter, left, right, precision);
            }
            else
            {
                return this.OperatorBinding.Bind(CqlOperator.After, this.RuntimeContextParameter, left, right, precision);
            }
        }

        protected Expression? Before(elm.Before e)
        {
            var left = this.TranslateExpression(e!.operand![0]!);
            var right = this.TranslateExpression(e.operand[1]!);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return this.OperatorBinding.Bind(CqlOperator.IntervalBeforeInterval, this.RuntimeContextParameter, left, right, precision);

                }
                else
                {
                    return this.OperatorBinding.Bind(CqlOperator.IntervalBeforeElement, this.RuntimeContextParameter, left, right, precision);
                }
            }
            else if (IsInterval(right.Type, out var rightElementType))
            {
                return this.OperatorBinding.Bind(CqlOperator.ElementBeforeInterval, this.RuntimeContextParameter, left, right, precision);
            }
            else
            {
                return this.OperatorBinding.Bind(CqlOperator.Before, this.RuntimeContextParameter, left, right, precision);
            }
        }
        protected Expression Date(elm.Date e)
        {
            var year = (e.year != null) ? this.TranslateExpression(e.year) : Expression.Constant(null, typeof(int?));
            var month = (e.month != null) ? this.TranslateExpression(e.month) : Expression.Constant(null, typeof(int?));
            var day = (e.day != null) ? this.TranslateExpression(e.day) : Expression.Constant(null, typeof(int?));

            return this.OperatorBinding.Bind(CqlOperator.Date, this.RuntimeContextParameter, year, month, day);
        }

        protected Expression DateTime(elm.DateTime e)
        {
            var year = e.year != null ? this.TranslateExpression(e.year) : Expression.Constant(null, typeof(int?));
            var month = e.month != null ? this.TranslateExpression(e.month) : Expression.Constant(null, typeof(int?));
            var day = e.day != null ? this.TranslateExpression(e.day) : Expression.Constant(null, typeof(int?));
            var hour = e.hour != null ? this.TranslateExpression(e.hour) : Expression.Constant(null, typeof(int?));
            var minute = e.minute != null ? this.TranslateExpression(e.minute) : Expression.Constant(null, typeof(int?));
            var second = e.second != null ? this.TranslateExpression(e.second) : Expression.Constant(null, typeof(int?));
            var milliseconds = e.millisecond != null ? this.TranslateExpression(e.millisecond) : Expression.Constant(null, typeof(int?));
            var offset = e.timezoneOffset != null ? this.TranslateExpression(e.timezoneOffset) : Expression.Constant(null, typeof(int?));
            if (offset.Type != typeof(decimal?))
            {
                offset = this.ChangeType(offset, typeof(decimal?));
            }

            return this.OperatorBinding.Bind(CqlOperator.DateTime, this.RuntimeContextParameter, year, month, day, hour, minute, second, milliseconds, offset);
        }

        /// <remarks>See https://cql.hl7.org/02-authorsguide.html#datetime-operators</remarks>
        protected Expression DateTimeComponentFrom(elm.DateTimeComponentFrom e)
        {
            var op = this.TranslateExpression(e.operand!);
            switch (e.precision)
            {
                case elm.DateTimePrecision.Day:
                case elm.DateTimePrecision.Month:
                case elm.DateTimePrecision.Year:
                case elm.DateTimePrecision.Hour:
                case elm.DateTimePrecision.Minute:
                case elm.DateTimePrecision.Second:
                case elm.DateTimePrecision.Millisecond:
                    return this.OperatorBinding.Bind(CqlOperator.DateTimeComponent, this.RuntimeContextParameter, op, Precision(e.precision, e.precisionSpecified));
                default:
                    throw new NotSupportedException($"Unsupported date time component: {e.precision}");
            }
        }

        private Expression DateFrom(elm.DateFrom dfe)
        {
            var op = this.TranslateExpression(dfe.operand!);
            return this.OperatorBinding.Bind(CqlOperator.DateComponent, this.RuntimeContextParameter, op);
        }

        protected Expression? DifferenceBetween(elm.DifferenceBetween e)
        {
            var left = this.TranslateExpression(e.operand![0]);
            var right = this.TranslateExpression(e.operand![1]);
            var precision = Precision(e.precision, e.precisionSpecified);
            return this.OperatorBinding.Bind(CqlOperator.DifferenceBetween, this.RuntimeContextParameter, left, right, precision);
        }

        protected Expression DurationBetween(elm.DurationBetween e)
        {
            var left = this.TranslateExpression(e.operand![0]);
            var right = this.TranslateExpression(e.operand![1]);
            var precision = Precision(e.precision, e.precisionSpecified);
            return this.OperatorBinding.Bind(CqlOperator.DurationBetween, this.RuntimeContextParameter, left, right, precision);
        }

        protected Expression? Now(elm.Now now) =>
            OperatorBinding.Bind(CqlOperator.Now, RuntimeContextParameter);

        protected Expression? SameAs(elm.SameAs e)
        {
            var left = this.TranslateExpression(e.operand![0]);
            var right = this.TranslateExpression(e.operand![1]);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return this.OperatorBinding.Bind(CqlOperator.IntervalSameAs, this.RuntimeContextParameter, left, right, precision);
                }
                else
                    throw this.NewExpressionBuildingException();
            }
            else
            {
                return this.OperatorBinding.Bind(CqlOperator.SameAs, this.RuntimeContextParameter, left, right, precision);
            }
        }

        protected Expression SameOrAfter(elm.SameOrAfter e)
        {
            var left = this.TranslateExpression(e.operand![0]);
            var right = this.TranslateExpression(e.operand![1]);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return this.OperatorBinding.Bind(CqlOperator.IntervalSameOrAfter, this.RuntimeContextParameter, left, right, precision);
                }
                else
                    throw this.NewExpressionBuildingException();
            }
            else
            {
                return this.OperatorBinding.Bind(CqlOperator.SameOrAfter, this.RuntimeContextParameter, left, right, precision);
            }
        }

        protected Expression SameOrBefore(elm.SameOrBefore e)
        {
            var left = this.TranslateExpression(e.operand![0]);
            var right = this.TranslateExpression(e.operand![1]);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return this.OperatorBinding.Bind(CqlOperator.IntervalSameOrBefore, this.RuntimeContextParameter, left, right, precision);
                }
                else
                    throw this.NewExpressionBuildingException();
            }
            else
            {
                return this.OperatorBinding.Bind(CqlOperator.SameOrBefore, this.RuntimeContextParameter, left, right, precision);
            }
        }

        protected Expression Time(elm.Time e)
        {
            var hour = e.hour != null ? this.TranslateExpression(e.hour) : Expression.Constant(null, typeof(int?));
            var minute = e.minute != null ? this.TranslateExpression(e.minute) : Expression.Constant(null, typeof(int?));
            var second = e.second != null ? this.TranslateExpression(e.second) : Expression.Constant(null, typeof(int?));
            var millisecond = e.millisecond != null ? this.TranslateExpression(e.millisecond) : Expression.Constant(null, typeof(int?));
            return this.OperatorBinding.Bind(CqlOperator.Time, this.RuntimeContextParameter, hour, minute, second, millisecond);
        }

        protected Expression? TimeOfDay(elm.TimeOfDay e) =>
            OperatorBinding.Bind(CqlOperator.TimeOfDay, RuntimeContextParameter);

        protected Expression? TimezoneOffsetFrom(elm.TimezoneOffsetFrom e) =>
            UnaryOperator(CqlOperator.TimeZoneComponent, e);

        protected Expression? Today(elm.Today e) =>
            OperatorBinding.Bind(CqlOperator.Today, RuntimeContextParameter);
    }
}
