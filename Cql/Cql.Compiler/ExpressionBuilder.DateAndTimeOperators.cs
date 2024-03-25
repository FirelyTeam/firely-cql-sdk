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
        protected Expression After(elm.After e)
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

        protected Expression? Before(elm.Before e)
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
        protected Expression Date(elm.Date e)
        {
            var year = (e.year != null) ? TranslateExpression(e.year) : Expression.Constant(null, typeof(int?));
            var month = (e.month != null) ? TranslateExpression(e.month) : Expression.Constant(null, typeof(int?));
            var day = (e.day != null) ? TranslateExpression(e.day) : Expression.Constant(null, typeof(int?));

            return _operatorBinding.Bind(CqlOperator.Date, LibraryDefinitionsBuilder.ContextParameter, year, month, day);
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

            return _operatorBinding.Bind(CqlOperator.DateTime, LibraryDefinitionsBuilder.ContextParameter, year, month, day, hour, minute, second, milliseconds, offset);
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
                    return _operatorBinding.Bind(CqlOperator.DateTimeComponent, LibraryDefinitionsBuilder.ContextParameter, op, Precision(e.precision, e.precisionSpecified));
                default:
                    throw new NotSupportedException($"Unsupported date time component: {e.precision}");
            }
        }

        private Expression DateFrom(elm.DateFrom dfe)
        {
            var op = TranslateExpression(dfe.operand!);
            return _operatorBinding.Bind(CqlOperator.DateComponent, LibraryDefinitionsBuilder.ContextParameter, op);
        }

        protected Expression? DifferenceBetween(elm.DifferenceBetween e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            var precision = Precision(e.precision, e.precisionSpecified);
            return _operatorBinding.Bind(CqlOperator.DifferenceBetween, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
        }

        protected Expression DurationBetween(elm.DurationBetween e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            var precision = Precision(e.precision, e.precisionSpecified);
            return _operatorBinding.Bind(CqlOperator.DurationBetween, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
        }

        protected Expression? Now(elm.Now now) =>
            _operatorBinding.Bind(CqlOperator.Now, LibraryDefinitionsBuilder.ContextParameter);

        protected Expression? SameAs(elm.SameAs e)
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

        protected Expression SameOrAfter(elm.SameOrAfter e)
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

        protected Expression SameOrBefore(elm.SameOrBefore e)
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

        protected Expression Time(elm.Time e)
        {
            var hour = e.hour != null ? TranslateExpression(e.hour) : Expression.Constant(null, typeof(int?));
            var minute = e.minute != null ? TranslateExpression(e.minute) : Expression.Constant(null, typeof(int?));
            var second = e.second != null ? TranslateExpression(e.second) : Expression.Constant(null, typeof(int?));
            var millisecond = e.millisecond != null ? TranslateExpression(e.millisecond) : Expression.Constant(null, typeof(int?));
            return _operatorBinding.Bind(CqlOperator.Time, LibraryDefinitionsBuilder.ContextParameter, hour, minute, second, millisecond);
        }

        protected Expression? TimeOfDay(elm.TimeOfDay e) =>
            _operatorBinding.Bind(CqlOperator.TimeOfDay, LibraryDefinitionsBuilder.ContextParameter);

        protected Expression? TimezoneOffsetFrom(elm.TimezoneOffsetFrom e) =>
            UnaryOperator(CqlOperator.TimeZoneComponent, e);

        protected Expression? Today(elm.Today e) =>
            _operatorBinding.Bind(CqlOperator.Today, LibraryDefinitionsBuilder.ContextParameter);
    }
}
