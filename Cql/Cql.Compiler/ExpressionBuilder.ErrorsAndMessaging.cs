using Hl7.Cql.Abstractions;
using System.Linq.Expressions;
using Hl7.Cql.Abstractions.Infrastructure;

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
            if (source is ConstantExpression { Value: null } constant)
            {
                // create an explicit "null as object" so the generic type can be inferred in source code.
                source = constant.ExprConvert(constant.Type);
            }

            var call = _operatorsBinder.BindToMethod(CqlOperator.Message, source, code, severity, message);
            if (condition.Type.IsNullable(out _))
            {
                condition = Expression.Coalesce(condition, Expression.Constant(false, typeof(bool)));
            }

            return Expression.Condition(condition, call, source);
        }
    }
}
