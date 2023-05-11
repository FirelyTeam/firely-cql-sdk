using System.Linq.Expressions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler
{
    /// <summary>
    /// Binds <see cref="CqlOperator"/>s to <see cref="Expression"/>s.
    /// </summary>
    /// <seealso cref="ExpressionBuilder"/>
    public abstract class OperatorBinding
    {
        /// <summary>
        /// Binds <paramref name="operator"/> to an <see cref="Expression"/>.
        /// </summary>
        /// <param name="operator">The operator to bind.</param>
        /// <param name="runtimeContext">The <see cref="Expression"/> that provides access to the <see cref="RuntimeContext"/>.</param>
        /// <param name="parameters">Zero or more parameter <see cref="Expression"/>s.  The number and order of expressions is dependent on <paramref name="operator"/>.</param>
        /// <returns>An expression that implements <paramref name="operator"/>.</returns>
        /// <seealso cref="CqlOperatorsBinding"/>
        public abstract Expression Bind(CqlOperator @operator, Expression runtimeContext, params Expression[] parameters);
    }
}
