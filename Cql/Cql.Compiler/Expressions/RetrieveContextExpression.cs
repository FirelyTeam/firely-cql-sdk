using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Compiler
{
    internal class RetrieveContextExpression: Expression
    {
        private static readonly PropertyInfo operatorsProperty =
            typeof(CqlContext).GetProperty(nameof(CqlContext.Operators))!;

        public RetrieveContextExpression(Type type,
            Expression cqlContextParameter,
            ParameterExpression retrieveContextParameter)
        {
            Type = type;
            CqlContextParameter = cqlContextParameter;
            RetrieveContextParameter = retrieveContextParameter;
        }

        public override ExpressionType NodeType => ExpressionType.Extension;

        public override bool CanReduce => true;

        public override Expression Reduce()
        {
            var operators = Property(CqlContextParameter, operatorsProperty)!;

            var retrieveMethod = operatorsProperty.PropertyType.GetMethod(nameof(ICqlOperators.RetrieveByValueSet))!;
            var typedRetrieve = retrieveMethod.MakeGenericMethod(Type);
            var source = Call(operators, typedRetrieve, Default(typeof(CqlValueSet)), Default(typeof(PropertyInfo)));

            var singleGenericMethod = operatorsProperty.PropertyType.GetMethod(nameof(ICqlOperators.SingleOrNull))!;
            var singleMethod = singleGenericMethod.MakeGenericMethod(Type);
            var callSingle = Call(operators, singleMethod, source);

            var test = NotEqual(RetrieveContextParameter, Default(RetrieveContextParameter.Type));
            var conditional = Condition(test, RetrieveContextParameter, callSingle);

            return conditional;
        }

        public override Type Type { get; }
        public Expression CqlContextParameter { get; }
        public ParameterExpression RetrieveContextParameter { get; }
    }
}
