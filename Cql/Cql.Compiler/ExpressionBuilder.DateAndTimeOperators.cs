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
                    return BindCqlOperator(CqlOperator.IntervalAfterInterval, left, right, precision);
                }
                else
                {
                    return BindCqlOperator(CqlOperator.IntervalAfterElement, left, right, precision);
                }
            }
            else if (IsInterval(right.Type, out var rightElementType))
            {
                return BindCqlOperator(CqlOperator.ElementAfterInterval, left, right, precision);
            }
            else
            {
                return BindCqlOperator(CqlOperator.After, left, right, precision);
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
                    return BindCqlOperator(CqlOperator.IntervalBeforeInterval, left, right, precision);

                }
                else
                {
                    return BindCqlOperator(CqlOperator.IntervalBeforeElement, left, right, precision);
                }
            }
            else if (IsInterval(right.Type, out var rightElementType))
            {
                return BindCqlOperator(CqlOperator.ElementBeforeInterval, left, right, precision);
            }
            else
            {
                return BindCqlOperator(CqlOperator.Before, left, right, precision);
            }
        }
        protected Expression Date(Elm.Date e)
        {
            var year = (e.year != null) ? TranslateExpression(e.year) : Expression.Constant(null, typeof(int?));
            var month = (e.month != null) ? TranslateExpression(e.month) : Expression.Constant(null, typeof(int?));
            var day = (e.day != null) ? TranslateExpression(e.day) : Expression.Constant(null, typeof(int?));

            return BindCqlOperator(CqlOperator.Date, year, month, day);
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

            return BindCqlOperator(CqlOperator.DateTime, year, month, day, hour, minute, second, milliseconds, offset);
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
                    return BindCqlOperator(CqlOperator.DateTimeComponent, op, Precision(e.precision, e.precisionSpecified));
                default:
                    throw new NotSupportedException($"Unsupported date time component: {e.precision}");
            }
        }

        private Expression DateFrom(Elm.DateFrom dfe)
        {
            var op = TranslateExpression(dfe.operand!);
            return BindCqlOperator(CqlOperator.DateComponent, op);
        }

        protected Expression? DifferenceBetween(Elm.DifferenceBetween e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            var precision = Precision(e.precision, e.precisionSpecified);
            return BindCqlOperator(CqlOperator.DifferenceBetween, left, right, precision);
        }

        protected Expression DurationBetween(Elm.DurationBetween e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            var precision = Precision(e.precision, e.precisionSpecified);
            return BindCqlOperator(CqlOperator.DurationBetween, left, right, precision);
        }

        protected Expression? Now(Elm.Now now) =>
            BindCqlOperator(CqlOperator.Now, LibraryDefinitionsBuilder.ContextParameter);

        protected Expression? SameAs(Elm.SameAs e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (!IsInterval(right.Type, out var rightElementType))
                    throw this.NewExpressionBuildingException();

                return BindCqlOperator(CqlOperator.IntervalSameAs, LibraryDefinitionsBuilder.ContextParameter,
                    left, right, precision);
            }
            else
            {
                return BindCqlOperator(CqlOperator.SameAs, left, right, precision);
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

                return BindCqlOperator(CqlOperator.IntervalSameOrAfter,
                    left, right, precision);
            }
            else
            {
                return BindCqlOperator(CqlOperator.SameOrAfter, left, right, precision);
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

                return BindCqlOperator(CqlOperator.IntervalSameOrBefore,
                    left, right, precision);
            }

            return BindCqlOperator(CqlOperator.SameOrBefore, left, right, precision);
        }

        protected Expression Time(Elm.Time e)
        {
            var hour = e.hour != null ? TranslateExpression(e.hour) : Expression.Constant(null, typeof(int?));
            var minute = e.minute != null ? TranslateExpression(e.minute) : Expression.Constant(null, typeof(int?));
            var second = e.second != null ? TranslateExpression(e.second) : Expression.Constant(null, typeof(int?));
            var millisecond = e.millisecond != null ? TranslateExpression(e.millisecond) : Expression.Constant(null, typeof(int?));
            return BindCqlOperator(CqlOperator.Time, hour, minute, second, millisecond);
        }
    }
}
