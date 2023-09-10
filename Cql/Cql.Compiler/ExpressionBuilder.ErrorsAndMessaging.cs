using Hl7.Cql.Abstractions;
using System.Linq.Expressions;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        private Expression Message(elm.Message e, ExpressionBuilderContext ctx)
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
            var call = OperatorBinding.Bind(CqlOperator.Message, ctx.RuntimeContextParameter, source, code, severity, message);
            if (IsNullable(condition.Type))
            {
                condition = Expression.Coalesce(condition, Expression.Constant(false, typeof(bool)));
            }

            return Expression.Condition(condition, call, source);
        }
    }
}
