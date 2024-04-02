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
                    return _operatorBinding.Bind(CqlOperator.IntervalAfterInterval, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
                }
                else
                {
                    return _operatorBinding.Bind(CqlOperator.IntervalAfterElement, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
                }
            }
            else if (IsInterval(right.Type, out var rightElementType))
            {
                return _operatorBinding.Bind(CqlOperator.ElementAfterInterval, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
            }
            else
            {
                return _operatorBinding.Bind(CqlOperator.After, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
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
                    return _operatorBinding.Bind(CqlOperator.IntervalBeforeInterval, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);

                }
                else
                {
                    return _operatorBinding.Bind(CqlOperator.IntervalBeforeElement, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
                }
            }
            else if (IsInterval(right.Type, out var rightElementType))
            {
                return _operatorBinding.Bind(CqlOperator.ElementBeforeInterval, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
            }
            else
            {
                return _operatorBinding.Bind(CqlOperator.Before, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
            }
        }
        protected Expression Date(Elm.Date e)
        {
            var year = (e.year != null) ? TranslateExpression(e.year) : Expression.Constant(null, typeof(int?));
            var month = (e.month != null) ? TranslateExpression(e.month) : Expression.Constant(null, typeof(int?));
            var day = (e.day != null) ? TranslateExpression(e.day) : Expression.Constant(null, typeof(int?));

            return _operatorBinding.Bind(CqlOperator.Date, LibraryDefinitionsBuilder.ContextParameter, year, month, day);
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

            return _operatorBinding.Bind(CqlOperator.DateTime, LibraryDefinitionsBuilder.ContextParameter, year, month, day, hour, minute, second, milliseconds, offset);
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
                    return _operatorBinding.Bind(CqlOperator.DateTimeComponent, LibraryDefinitionsBuilder.ContextParameter, op, Precision(e.precision, e.precisionSpecified));
                default:
                    throw new NotSupportedException($"Unsupported date time component: {e.precision}");
            }
        }

        private Expression DateFrom(Elm.DateFrom dfe)
        {
            var op = TranslateExpression(dfe.operand!);
            return _operatorBinding.Bind(CqlOperator.DateComponent, LibraryDefinitionsBuilder.ContextParameter, op);
        }

        protected Expression? DifferenceBetween(Elm.DifferenceBetween e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            var precision = Precision(e.precision, e.precisionSpecified);
            return _operatorBinding.Bind(CqlOperator.DifferenceBetween, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
        }

        protected Expression DurationBetween(Elm.DurationBetween e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            var precision = Precision(e.precision, e.precisionSpecified);
            return _operatorBinding.Bind(CqlOperator.DurationBetween, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
        }

        protected Expression? Now(Elm.Now now) =>
            _operatorBinding.Bind(CqlOperator.Now, LibraryDefinitionsBuilder.ContextParameter);

        protected Expression? SameAs(Elm.SameAs e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return _operatorBinding.Bind(CqlOperator.IntervalSameAs, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
                }
                else
                    throw this.NewExpressionBuildingException();
            }
            else
            {
                return _operatorBinding.Bind(CqlOperator.SameAs, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
            }
        }

        protected Expression SameOrAfter(Elm.SameOrAfter e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return _operatorBinding.Bind(CqlOperator.IntervalSameOrAfter, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
                }
                else
                    throw this.NewExpressionBuildingException();
            }
            else
            {
                return _operatorBinding.Bind(CqlOperator.SameOrAfter, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
            }
        }

        protected Expression SameOrBefore(Elm.SameOrBefore e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return _operatorBinding.Bind(CqlOperator.IntervalSameOrBefore, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
                }
                else
                    throw this.NewExpressionBuildingException();
            }
            else
            {
                return _operatorBinding.Bind(CqlOperator.SameOrBefore, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
            }
        }

        protected Expression Time(Elm.Time e)
        {
            var hour = e.hour != null ? TranslateExpression(e.hour) : Expression.Constant(null, typeof(int?));
            var minute = e.minute != null ? TranslateExpression(e.minute) : Expression.Constant(null, typeof(int?));
            var second = e.second != null ? TranslateExpression(e.second) : Expression.Constant(null, typeof(int?));
            var millisecond = e.millisecond != null ? TranslateExpression(e.millisecond) : Expression.Constant(null, typeof(int?));
            return _operatorBinding.Bind(CqlOperator.Time, LibraryDefinitionsBuilder.ContextParameter, hour, minute, second, millisecond);
        }

        protected Expression? TimeOfDay(Elm.TimeOfDay e) =>
            _operatorBinding.Bind(CqlOperator.TimeOfDay, LibraryDefinitionsBuilder.ContextParameter);

        protected Expression? TimezoneOffsetFrom(Elm.TimezoneOffsetFrom e) =>
            UnaryOperator(CqlOperator.TimeZoneComponent, e);

        protected Expression? Today(Elm.Today e) =>
            _operatorBinding.Bind(CqlOperator.Today, LibraryDefinitionsBuilder.ContextParameter);
    }
}
