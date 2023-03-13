using Ncqa.Cql.Runtime;
using Ncqa.Cql.Runtime.Conversion;
using Ncqa.Cql.Runtime.Primitives;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace Ncqa.Cql.Runtime.FhirR4
{
    public class FhirOperatorsBinding : ICqlOperatorsBinding
    {
        public FhirOperatorsBinding(TypeConverter? typeConverter, TypeResolver typeResolver) : base(typeConverter, typeResolver)
        {
        }

        public override Expression Bind(CqlOperator @operator, Expression runtimeContext, params Expression[] parameters)
        {
            var @as = Expression.TypeAs(runtimeContext, typeof(FhirRuntimeContext));
            return base.Bind(@operator, @as, parameters);
        }

        protected override PropertyInfo OperatorsProperty => typeof(FhirRuntimeContext).GetProperty(nameof(FhirRuntimeContext.FhirOperators));
        protected override Type OperatorsType => typeof(FhirCqlOperators);

    }
}
