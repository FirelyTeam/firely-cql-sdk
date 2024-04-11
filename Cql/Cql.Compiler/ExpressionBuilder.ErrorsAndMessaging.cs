using Hl7.Cql.Abstractions;
using System.Linq.Expressions;
using Hl7.Cql.Compiler.Infrastructure;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        private Expression Message(Elm.Message e)
        {
            var source = TranslateExpression(e.source!);
            var condition = TranslateExpression(e.condition!);
            var code = TranslateExpression(e.code!);
            var severity = TranslateExpression(e.severity!);
            var message = TranslateExpression(e.message!);
            if (source is ConstantExpression constant && constant.Value == null)
            {
                // create an explicit "null as object" so the generic type can be inferred in source code.
                source = Expression.TypeAs(constant, constant.Type);
            }

            Expression[] parameters = new[] { source, code, severity, message };
            var call = _operatorBinding.BindToMethod(CqlOperator.Message, parameters);
            if (condition.Type.IsNullable())
            {
                condition = Expression.Coalesce(condition, Expression.Constant(false, typeof(bool)));
            }

            return Expression.Condition(condition, call, source);
        }
    }
}
