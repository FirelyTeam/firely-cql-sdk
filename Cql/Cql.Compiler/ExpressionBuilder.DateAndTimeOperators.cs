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

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        protected Expression After(Elm.After e)
        {
            var left = TranslateExpression(e!.operand![0]!);
            var right = TranslateExpression(e.operand[1]!);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return _operatorBinder.BindToMethod(CqlOperator.IntervalAfterInterval, left, right, precision);
                }
                else
                {
                    return _operatorBinder.BindToMethod(CqlOperator.IntervalAfterElement, left, right, precision);
                }
            }
            else if (IsInterval(right.Type, out var rightElementType))
            {
                return _operatorBinder.BindToMethod(CqlOperator.ElementAfterInterval, left, right, precision);
            }
            else
            {
                return _operatorBinder.BindToMethod(CqlOperator.After, left, right, precision);
            }
        }

        protected Expression? Before(Elm.Before e)
        {
            var left = TranslateExpression(e!.operand![0]!);
            var right = TranslateExpression(e.operand[1]!);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return _operatorBinder.BindToMethod(CqlOperator.IntervalBeforeInterval, left, right, precision);
                }
                else
                {
                    return _operatorBinder.BindToMethod(CqlOperator.IntervalBeforeElement, left, right, precision);
                }
            }
            else if (IsInterval(right.Type, out var rightElementType))
            {
                return _operatorBinder.BindToMethod(CqlOperator.ElementBeforeInterval, left, right, precision);
            }
            else
            {
                return _operatorBinder.BindToMethod(CqlOperator.Before, left, right, precision);
            }
        }
        protected Expression Date(Elm.Date e)
        {
            var year = (e.year != null) ? TranslateExpression(e.year) : CqlExpressions.Null_ConstantExpression<int?>();
            var month = (e.month != null) ? TranslateExpression(e.month) : CqlExpressions.Null_ConstantExpression<int?>();
            var day = (e.day != null) ? TranslateExpression(e.day) : CqlExpressions.Null_ConstantExpression<int?>();

            return _operatorBinder.BindToMethod(CqlOperator.Date, year, month, day);
        }

        protected Expression DateTime(Elm.DateTime e)
        {
            var year = e.year != null ? TranslateExpression(e.year) : CqlExpressions.Null_ConstantExpression<int?>();
            var month = e.month != null ? TranslateExpression(e.month) : CqlExpressions.Null_ConstantExpression<int?>();
            var day = e.day != null ? TranslateExpression(e.day) : CqlExpressions.Null_ConstantExpression<int?>();
            var hour = e.hour != null ? TranslateExpression(e.hour) : CqlExpressions.Null_ConstantExpression<int?>();
            var minute = e.minute != null ? TranslateExpression(e.minute) : CqlExpressions.Null_ConstantExpression<int?>();
            var second = e.second != null ? TranslateExpression(e.second) : CqlExpressions.Null_ConstantExpression<int?>();
            var milliseconds = e.millisecond != null ? TranslateExpression(e.millisecond) : CqlExpressions.Null_ConstantExpression<int?>();
            var offset = e.timezoneOffset != null ? TranslateExpression(e.timezoneOffset) : CqlExpressions.Null_ConstantExpression<int?>();
            if (offset.Type != typeof(decimal?))
            {
                offset = ChangeType(offset, typeof(decimal?));
            }

            return _operatorBinder.BindToMethod(CqlOperator.DateTime, year, month, day, hour, minute, second, milliseconds, offset);
        }

        /// <remarks>See https://cql.hl7.org/02-authorsguide.html#datetime-operators</remarks>
        protected Expression DateTimeComponentFrom(Elm.DateTimeComponentFrom e)
        {
            var op = TranslateExpression(e.operand!);
            switch (e.precision)
            {
                case Elm.DateTimePrecision.Day:
                case Elm.DateTimePrecision.Month:
                case Elm.DateTimePrecision.Year:
                case Elm.DateTimePrecision.Hour:
                case Elm.DateTimePrecision.Minute:
                case Elm.DateTimePrecision.Second:
                case Elm.DateTimePrecision.Millisecond:
                    return _operatorBinder.BindToMethod(CqlOperator.DateTimeComponent, op, Precision(e.precision, e.precisionSpecified));
                default:
                    throw new NotSupportedException($"Unsupported date time component: {e.precision}");
            }
        }

        protected Expression? SameAs(Elm.SameAs e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (!IsInterval(right.Type, out var rightElementType))
                    throw this.NewExpressionBuildingException();

                return _operatorBinder.BindToMethod(CqlOperator.IntervalSameAs, left, right, precision);
            }
            else
            {
                return _operatorBinder.BindToMethod(CqlOperator.SameAs, left, right, precision);
            }
        }

        protected Expression SameOrAfter(Elm.SameOrAfter e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (!IsInterval(right.Type, out var rightElementType))
                    throw this.NewExpressionBuildingException();

                return _operatorBinder.BindToMethod(CqlOperator.IntervalSameOrAfter, left, right, precision);
            }
            else
            {
                return _operatorBinder.BindToMethod(CqlOperator.SameOrAfter, left, right, precision);
            }
        }

        protected Expression SameOrBefore(Elm.SameOrBefore e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            var precision = Precision(e.precision, e.precisionSpecified);

            if (IsInterval(left.Type, out var leftElementType))
            {
                if (!IsInterval(right.Type, out var rightElementType))
                    throw this.NewExpressionBuildingException();

                return _operatorBinder.BindToMethod(CqlOperator.IntervalSameOrBefore, left, right, precision);
            }

            return _operatorBinder.BindToMethod(CqlOperator.SameOrBefore, left, right, precision);
        }

        protected Expression Time(Elm.Time e)
        {
            var hour = e.hour != null ? TranslateExpression(e.hour) : CqlExpressions.Null_ConstantExpression<int?>();
            var minute = e.minute != null ? TranslateExpression(e.minute) : CqlExpressions.Null_ConstantExpression<int?>();
            var second = e.second != null ? TranslateExpression(e.second) : CqlExpressions.Null_ConstantExpression<int?>();
            var millisecond = e.millisecond != null ? TranslateExpression(e.millisecond) : CqlExpressions.Null_ConstantExpression<int?>();
            return _operatorBinder.BindToMethod(CqlOperator.Time, hour, minute, second, millisecond);
        }
    }
}
