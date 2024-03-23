using Hl7.Cql.Abstractions;
using System.Linq.Expressions;
using Hl7.Cql.Compiler.Infrastructure;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilderContext
    {
        private Expression Message(elm.Message e)
        {
            ExpressionBuilderContext ctx = this;
            var source = ctx.TranslateExpression(e.source!);
            var condition = ctx.TranslateExpression(e.condition!);
            var code = ctx.TranslateExpression(e.code!);
            var severity = ctx.TranslateExpression(e.severity!);
            var message = ctx.TranslateExpression(e.message!);
            if (source is ConstantExpression constant && constant.Value == null)
            {
                // create an explicit "null as object" so the generic type can be inferred in source code.
                source = Expression.TypeAs(constant, constant.Type);
            }
            var call = ctx.OperatorBinding.Bind(CqlOperator.Message, ctx.RuntimeContextParameter, source, code, severity, message);
            if (condition.Type.IsNullable())
            {
                condition = Expression.Coalesce(condition, Expression.Constant(false, typeof(bool)));
            }

            return Expression.Condition(condition, call, source);
        }
    }
}
