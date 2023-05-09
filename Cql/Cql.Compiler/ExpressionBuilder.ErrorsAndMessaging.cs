using Ncqa.Cql.Runtime;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using elm = Ncqa.Elm.Expressions;

namespace Ncqa.Cql.MeasureCompiler
{
    public partial class ExpressionBuilder
    {
        private Expression Message(elm.MessageExpression e, ExpressionBuilderContext ctx)
        {
            var source = TranslateExpression(e.source!, ctx);
            var condition = TranslateExpression(e.condition!, ctx);
            var code = TranslateExpression(e.code!, ctx);
            var severity = TranslateExpression(e.severity!, ctx);
            var message = TranslateExpression(e.message!, ctx);
            if (source is ConstantExpression constant && constant.Value == null)
            {
                // create an explicit "null as object" so the generic type can be inferred in source code.
                source = Expression.TypeAs(constant, constant.Type);
            }
            var call = Operators.Bind(CqlOperator.Message, ctx.RuntimeContextParameter, source, code, severity, message);
            if (IsNullable(condition.Type))
            {
                condition = Expression.Coalesce(condition, Expression.Constant(false, typeof(bool)));
            }
            var conditional = Expression.Condition(condition, call, source);
            return conditional;
        }
    }
}
