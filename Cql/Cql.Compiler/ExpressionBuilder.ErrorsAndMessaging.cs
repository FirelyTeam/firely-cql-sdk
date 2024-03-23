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
            var source = this.TranslateExpression(e.source!);
            var condition = this.TranslateExpression(e.condition!);
            var code = this.TranslateExpression(e.code!);
            var severity = this.TranslateExpression(e.severity!);
            var message = this.TranslateExpression(e.message!);
            if (source is ConstantExpression constant && constant.Value == null)
            {
                // create an explicit "null as object" so the generic type can be inferred in source code.
                source = Expression.TypeAs(constant, constant.Type);
            }
            var call = this.OperatorBinding.Bind(CqlOperator.Message, this.RuntimeContextParameter, source, code, severity, message);
            if (condition.Type.IsNullable())
            {
                condition = Expression.Coalesce(condition, Expression.Constant(false, typeof(bool)));
            }

            return Expression.Condition(condition, call, source);
        }
    }
}
