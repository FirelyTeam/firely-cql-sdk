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
using Hl7.Cql.Compiler.Infrastructure;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        protected Expression After(Elm.After e)
        {
            var left = TranslateExpression(e.operand[0]);
            var right = TranslateExpression(e.operand[1]!);
            var precision = Precision(e);
            if (left.Type.IsCqlInterval(out _))
            {
                return _operatorsBinder.BindToMethod(right.Type.IsCqlInterval(out _)
                    ? CqlOperator.IntervalAfterInterval
                    : CqlOperator.IntervalAfterElement, left, right, precision);
            }

            return _operatorsBinder.BindToMethod(right.Type.IsCqlInterval(out _)
                ? CqlOperator.ElementAfterInterval
                : CqlOperator.After, left, right, precision);
        }

        protected Expression? Before(Elm.Before e)
        {
            var left = TranslateExpression(e!.operand[0]);
            var right = TranslateExpression(e.operand[1]!);
            var precision = Precision(e);
            if (left.Type.IsCqlInterval(out _))
            {
                return _operatorsBinder.BindToMethod(right.Type.IsCqlInterval(out _)
                    ? CqlOperator.IntervalBeforeInterval
                    : CqlOperator.IntervalBeforeElement, left, right, precision);
            }

            return _operatorsBinder.BindToMethod(right.Type.IsCqlInterval(out _)
                ? CqlOperator.ElementBeforeInterval
                : CqlOperator.Before, left, right, precision);
        }
        protected Expression Date(Elm.Date e) =>
            _operatorsBinder.BindToMethod(CqlOperator.Date,
                TranslateExpression(e.year) ?? NullConstantExpression.NullableInt32,
                TranslateExpression(e.month) ?? NullConstantExpression.NullableInt32,
                TranslateExpression(e.day) ?? NullConstantExpression.NullableInt32);

        protected Expression DateTime(Elm.DateTime e)
        {
            var offset = e.timezoneOffset is { } tzo ? TranslateExpression(tzo) : NullConstantExpression.NullableInt32;
            if (offset.Type != typeof(decimal?))
            {
                offset = ChangeType(offset, typeof(decimal?));
            }

            return _operatorsBinder.BindToMethod(CqlOperator.DateTime,
                TranslateExpression(e.year) ?? NullConstantExpression.NullableInt32,
                TranslateExpression(e.month) ?? NullConstantExpression.NullableInt32,
                TranslateExpression(e.day) ?? NullConstantExpression.NullableInt32,
                TranslateExpression(e.hour) ?? NullConstantExpression.NullableInt32,
                TranslateExpression(e.minute) ?? NullConstantExpression.NullableInt32,
                TranslateExpression(e.second) ?? NullConstantExpression.NullableInt32,
                TranslateExpression(e.millisecond) ?? NullConstantExpression.NullableInt32,
                offset);
        }

        protected Expression? SameAs(Elm.SameAs e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            var precision = Precision(e);
            if (left.Type.IsCqlInterval(out _))
            {
                return right.Type.IsCqlInterval(out _)
                    ? _operatorsBinder.BindToMethod(CqlOperator.IntervalSameAs, left, right, precision)
                    : throw this.NewExpressionBuildingException();
            }

            return _operatorsBinder.BindToMethod(CqlOperator.SameAs, left, right, precision);
        }

        protected Expression SameOrAfter(Elm.SameOrAfter e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            var precision = Precision(e);
            if (left.Type.IsCqlInterval(out _))
            {
                return right.Type.IsCqlInterval(out _)
                    ? _operatorsBinder.BindToMethod(CqlOperator.IntervalSameOrAfter, left, right, precision)
                    : throw this.NewExpressionBuildingException();
            }

            return _operatorsBinder.BindToMethod(CqlOperator.SameOrAfter, left, right, precision);
        }

        protected Expression SameOrBefore(Elm.SameOrBefore e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            var precision = Precision(e);

            if (left.Type.IsCqlInterval(out _))
            {
                return right.Type.IsCqlInterval(out _)
                    ? _operatorsBinder.BindToMethod(CqlOperator.IntervalSameOrBefore, left, right, precision)
                    : throw this.NewExpressionBuildingException();
            }

            return _operatorsBinder.BindToMethod(CqlOperator.SameOrBefore, left, right, precision);
        }

        protected Expression Time(Elm.Time e)
        {
            return _operatorsBinder.BindToMethod(CqlOperator.Time,
                TranslateExpression(e.hour) ?? NullConstantExpression.NullableInt32,
                TranslateExpression(e.minute) ?? NullConstantExpression.NullableInt32,
                TranslateExpression(e.second) ?? NullConstantExpression.NullableInt32,
                TranslateExpression(e.millisecond) ?? NullConstantExpression.NullableInt32);
        }
    }
}
