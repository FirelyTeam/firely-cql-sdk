using System.Linq.Expressions;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler.Expressions;

namespace Hl7.Cql.Compiler.Builders
{
    internal partial class ExpressionBuilder
    {
        private Expression Message(Elm.Message e)
        {
            var source = Translate(e.source!);
            var condition = Translate(e.condition!);
            var code = Translate(e.code!);
            var severity = Translate(e.severity!);
            var message = Translate(e.message!);
            if (source is ConstantExpression { Value: null } constant)
            {
                // create an explicit "null as object" so the generic type can be inferred in source code.
                source = constant.ConvertExpression(constant.Type);
            }

            var call = BindCqlOperator(CqlOperator.Message, null, source, code, severity, message);
            if (condition.Type.IsNullableValueType(out _))
            {
                condition = Expression.Coalesce(condition, Expression.Constant(false, typeof(bool)));
            }

            return Expression.Condition(condition, call, source);
        }
    }
}
