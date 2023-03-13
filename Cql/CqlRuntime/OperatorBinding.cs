using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Linq;

namespace Ncqa.Cql.Runtime
{
    public abstract class OperatorBinding
    {
        public abstract Expression Bind(CqlOperator @operator, Expression runtimeContext, params Expression[] parameters);
    }
}
