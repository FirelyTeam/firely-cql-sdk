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
        private static Expression[] RemoveNullPrecisionArg(params Expression?[] args) =>
            CqlOperatorsBinding.RemoveNullPrecisionArg(args);

        protected Expression After(Elm.After e)
        {
            var left = TranslateExpression(e!.operand![0]!);
            var right = TranslateExpression(e.operand[1]!);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return _operatorBinding.BindToMethod(CqlOperator.IntervalAfterInterval, RemoveNullPrecisionArg(left, right, precision));
                }
                else
                {
                    return _operatorBinding.BindToMethod(CqlOperator.IntervalAfterElement, RemoveNullPrecisionArg(left, right, precision));
                }
            }
            else if (IsInterval(right.Type, out var rightElementType))
            {
                return _operatorBinding.BindToMethod(CqlOperator.ElementAfterInterval, RemoveNullPrecisionArg(left, right, precision));
            }
            else
            {
                return _operatorBinding.BindToMethod(CqlOperator.After, RemoveNullPrecisionArg(left, right, precision));
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
                    return _operatorBinding.BindToMethod(CqlOperator.IntervalBeforeInterval, RemoveNullPrecisionArg(left, right, precision));
                }
                else
                {
                    return _operatorBinding.BindToMethod(CqlOperator.IntervalBeforeElement, RemoveNullPrecisionArg(left, right, precision));
                }
            }
            else if (IsInterval(right.Type, out var rightElementType))
            {
                return _operatorBinding.BindToMethod(CqlOperator.ElementBeforeInterval, RemoveNullPrecisionArg(left, right, precision));
            }
            else
            {
                return _operatorBinding.BindToMethod(CqlOperator.Before, RemoveNullPrecisionArg(left, right, precision));
            }
        }
        protected Expression Date(Elm.Date e)
        {
            var year = (e.year != null) ? TranslateExpression(e.year) : Expression.Constant(null, typeof(int?));
            var month = (e.month != null) ? TranslateExpression(e.month) : Expression.Constant(null, typeof(int?));
            var day = (e.day != null) ? TranslateExpression(e.day) : Expression.Constant(null, typeof(int?));

            return _operatorBinding.BindToMethod(CqlOperator.Date, year, month, day);
        }

        protected Expression DateTime(Elm.DateTime e)
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

            return _operatorBinding.BindToMethod(CqlOperator.DateTime, year, month, day, hour, minute, second, milliseconds, offset);
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
                    return _operatorBinding.BindToMethod(CqlOperator.DateTimeComponent, RemoveNullPrecisionArg(op, Precision(e.precision, e.precisionSpecified)));
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

                return _operatorBinding.BindToMethod(CqlOperator.IntervalSameAs, RemoveNullPrecisionArg(left, right, precision));
            }
            else
            {
                return _operatorBinding.BindToMethod(CqlOperator.SameAs, RemoveNullPrecisionArg(left, right, precision));
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

                return _operatorBinding.BindToMethod(CqlOperator.IntervalSameOrAfter, RemoveNullPrecisionArg(left, right, precision));
            }
            else
            {
                return _operatorBinding.BindToMethod(CqlOperator.SameOrAfter, RemoveNullPrecisionArg(left, right, precision));
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

                return _operatorBinding.BindToMethod(CqlOperator.IntervalSameOrBefore, RemoveNullPrecisionArg(left, right, precision));
            }

            return _operatorBinding.BindToMethod(CqlOperator.SameOrBefore, RemoveNullPrecisionArg(left, right, precision));
        }

        protected Expression Time(Elm.Time e)
        {
            var hour = e.hour != null ? TranslateExpression(e.hour) : Expression.Constant(null, typeof(int?));
            var minute = e.minute != null ? TranslateExpression(e.minute) : Expression.Constant(null, typeof(int?));
            var second = e.second != null ? TranslateExpression(e.second) : Expression.Constant(null, typeof(int?));
            var millisecond = e.millisecond != null ? TranslateExpression(e.millisecond) : Expression.Constant(null, typeof(int?));
            return _operatorBinding.BindToMethod(CqlOperator.Time, hour, minute, second, millisecond);
        }
    }
}
