using System;
using System.Linq.Expressions;
using elm = Hl7.Cql.Elm.Expressions;

namespace Hl7.Cql.Compiler
{
    public partial class ExpressionBuilder
    {
        protected Expression After(elm.AfterExpression e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e!.operand![0]!, ctx);
            var right = TranslateExpression(e.operand[1]!, ctx);
            var precision = Expression.Constant(e.precision, typeof(string));
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return Operators.Bind(CqlOperator.IntervalAfterInterval, ctx.RuntimeContextParameter, left, right, precision);
                }
                else
                {
                    return Operators.Bind(CqlOperator.IntervalAfterElement, ctx.RuntimeContextParameter, left, right, precision);
                }
            }
            else if (IsInterval(right.Type, out var rightElementType))
            {
                return Operators.Bind(CqlOperator.ElementAfterInterval, ctx.RuntimeContextParameter, left, right, precision);
            }
            else
            {
                return Operators.Bind(CqlOperator.After, ctx.RuntimeContextParameter, left, right, precision);
            }
        }

        protected Expression? Before(elm.BeforeExpression e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e!.operand![0]!, ctx);
            var right = TranslateExpression(e.operand[1]!, ctx);
            var precision = Expression.Constant(e.precision, typeof(string));
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return Operators.Bind(CqlOperator.IntervalBeforeInterval, ctx.RuntimeContextParameter, left, right, precision);

                }
                else
                {
                    return Operators.Bind(CqlOperator.IntervalBeforeElement, ctx.RuntimeContextParameter, left, right, precision);
                }
            }
            else if (IsInterval(right.Type, out var rightElementType))
            {
                return Operators.Bind(CqlOperator.ElementBeforeInterval, ctx.RuntimeContextParameter, left, right, precision);
            }
            else
            {
                return Operators.Bind(CqlOperator.Before, ctx.RuntimeContextParameter, left, right, precision);
            }
        }
        protected Expression Date(elm.DateExpression e, ExpressionBuilderContext ctx)
        {
            var year = (e.year != null) ? TranslateExpression(e.year, ctx) : Expression.Constant(null, typeof(int?));
            var month = (e.month != null) ? TranslateExpression(e.month, ctx) : Expression.Constant(null, typeof(int?));
            var day = (e.day != null) ? TranslateExpression(e.day, ctx) : Expression.Constant(null, typeof(int?));

            return Operators.Bind(CqlOperator.Date, ctx.RuntimeContextParameter, year, month, day);
        }

        protected Expression DateTime(elm.DateTimeExpression e, ExpressionBuilderContext ctx)
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

            return Operators.Bind(CqlOperator.DateTime, ctx.RuntimeContextParameter, year, month, day, hour, minute, second,  milliseconds, offset);
        }

        /// <see cref="https://cql.hl7.org/02-authorsguide.html#datetime-operators"/>
        protected Expression DateTimeComponentFrom(elm.DateTimeComponentFromExpression dtcf, ExpressionBuilderContext ctx)
        {
            var op = TranslateExpression(dtcf.operand!, ctx);
            if (!Enum.TryParse<DateTimeComponent>(dtcf.precision!.ToLowerInvariant(), out var dateTimeComponent))
                throw new ArgumentException($"Precision {dtcf.precision} is not defined", nameof(dtcf));

            switch (dateTimeComponent)
            {
                case DateTimeComponent.date:
                    return Operators.Bind(CqlOperator.DateComponent, ctx.RuntimeContextParameter, op);
                case DateTimeComponent.time:
                    return Operators.Bind(CqlOperator.TimeComponent, ctx.RuntimeContextParameter, op);
                case DateTimeComponent.timezoneoffset:
                    return Operators.Bind(CqlOperator.TimeZoneComponent, ctx.RuntimeContextParameter, op);
                case DateTimeComponent.day:
                case DateTimeComponent.month:
                case DateTimeComponent.year:
                case DateTimeComponent.hour:
                case DateTimeComponent.minute:
                case DateTimeComponent.second:
                case DateTimeComponent.millisecond:
                    return Operators.Bind(CqlOperator.DateTimeComponent, ctx.RuntimeContextParameter, op, Expression.Constant(dtcf.precision));
                default:
                    throw new NotSupportedException($"Unsupported date time component: {dtcf.precision}");
            }
        }

        private Expression DateFrom(elm.DateFromExpression dfe, ExpressionBuilderContext ctx) =>
            DateTimeComponentFrom(new elm.DateTimeComponentFromExpression
            {
                operand = dfe.operand,
                precision = "date",
                localId = dfe.localId,
                locator = dfe.locator
            }, ctx);


        protected Expression? DifferenceBetween(elm.DifferenceBetweenExpression e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            var precision = Expression.Constant(e.precision, typeof(string));
            return Operators.Bind(CqlOperator.DifferenceBetween, ctx.RuntimeContextParameter, left, right, precision);
        }

        protected Expression DurationBetween(elm.DurationBetweenExpression e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            var precision = Expression.Constant(e.precision, typeof(string));
            return Operators.Bind(CqlOperator.DurationBetween, ctx.RuntimeContextParameter, left, right, precision);
        }

        protected Expression? Now(elm.NowExpression now, ExpressionBuilderContext ctx) =>
            Operators.Bind(CqlOperator.Now, ctx.RuntimeContextParameter);

        protected Expression? SameAs(elm.SameAsExpression e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            var precision = Expression.Constant(e.precision, typeof(string));
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return Operators.Bind(CqlOperator.IntervalSameAs, ctx.RuntimeContextParameter, left, right, precision);
                }
                else
                    throw new InvalidOperationException();
            }
            else
            {
                return Operators.Bind(CqlOperator.SameAs, ctx.RuntimeContextParameter, left, right, precision);
            }
        }

        protected Expression SameOrAfter(elm.SameOrAfterExpression e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            var precision = Expression.Constant(e.precision, typeof(string));
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return Operators.Bind(CqlOperator.IntervalSameOrAfter, ctx.RuntimeContextParameter, left, right, precision);
                }
                else
                    throw new InvalidOperationException();
            }
            else
            {
                return Operators.Bind(CqlOperator.SameOrAfter, ctx.RuntimeContextParameter, left, right, precision);
            }
        }

        protected Expression SameOrBefore(elm.SameOrBeforeExpression e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            var precision = Expression.Constant(e.precision, typeof(string));
            if (IsInterval(left.Type, out var leftElementType))
            {
                if (IsInterval(right.Type, out var rightElementType))
                {
                    return Operators.Bind(CqlOperator.IntervalSameOrBefore, ctx.RuntimeContextParameter, left, right, precision);
                }
                else
                    throw new InvalidOperationException();
            }
            else
            {
                return Operators.Bind(CqlOperator.SameOrBefore, ctx.RuntimeContextParameter, left, right, precision);
            }
        }

        protected Expression Time(elm.TimeExpression e, ExpressionBuilderContext ctx)
        {
            var hour = e.hour != null ? TranslateExpression(e.hour, ctx) : Expression.Constant(null, typeof(int?));
            var minute = e.minute != null ? TranslateExpression(e.minute, ctx) : Expression.Constant(null, typeof(int?));
            var second = e.second != null ? TranslateExpression(e.second, ctx) : Expression.Constant(null, typeof(int?));
            var millisecond = e.millisecond != null ? TranslateExpression(e.millisecond, ctx) : Expression.Constant(null, typeof(int?));
            return Operators.Bind(CqlOperator.Time, ctx.RuntimeContextParameter, hour, minute, second, millisecond);
        }

        protected Expression? TimeOfDay(elm.TimeOfDayExpression e, ExpressionBuilderContext ctx) =>
            Operators.Bind(CqlOperator.TimeOfDay, ctx.RuntimeContextParameter);

        protected Expression? TimezoneOffsetFrom(elm.TimezoneOffsetFromExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.TimeZoneComponent, e, ctx);

        protected Expression? Today(elm.TodayExpression e, ExpressionBuilderContext ctx) =>
            Operators.Bind(CqlOperator.Today, ctx.RuntimeContextParameter);
    }
}
