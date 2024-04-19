#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Elm;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler.Builders
{
    internal partial class ExpressionBuilder
    {
        protected Expression? SameAs(Elm.SameAs e)
        {
            var expr = TranslateAll([.. e.operand[..2], e.precisionOrNull()])!;
            var method = (leftIsCqlInterval: expr[0].Type.IsCqlInterval(out _), rightIsCqlInterval: expr[1].Type.IsCqlInterval(out _)) switch
            {
                (true, true)  => CqlOperator.IntervalSameAs,
                (true, false) => throw this.NewExpressionBuildingException(),
                _             => CqlOperator.SameAs
            }; // @TODO: Cast - Move to CqlOperatorsBinder
            return BindCqlOperator(method, null, expr);
        }

        protected Expression SameOrAfter(Elm.SameOrAfter e)
        {
            var expr = TranslateAll([.. e.operand[..2], e.precisionOrNull()])!;
            var method = (leftIsCqlInterval: expr[0].Type.IsCqlInterval(out _), rightIsCqlInterval: expr[1].Type.IsCqlInterval(out _)) switch
            {
                (true, true)  => CqlOperator.IntervalSameOrAfter,
                (true, false) => throw this.NewExpressionBuildingException(),
                _             => CqlOperator.SameOrAfter
            }; // @TODO: Cast - Move to CqlOperatorsBinder
            return BindCqlOperator(method, null, expr);
        }

        protected Expression SameOrBefore(Elm.SameOrBefore e)
        {
            var expr = TranslateAll([.. e.operand[..2], e.precisionOrNull()])!;
            var method = (leftIsCqlInterval: expr[0].Type.IsCqlInterval(out _), rightIsCqlInterval: expr[1].Type.IsCqlInterval(out _)) switch
            {
                (true, true)  => CqlOperator.IntervalSameOrBefore,
                (true, false) => throw this.NewExpressionBuildingException(),
                _             => CqlOperator.SameOrBefore
            }; // @TODO: Cast - Move to CqlOperatorsBinder
            return BindCqlOperator(method, null, expr);
        }
    }
}
