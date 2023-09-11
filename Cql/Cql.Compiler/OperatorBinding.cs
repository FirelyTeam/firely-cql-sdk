/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using System.Linq.Expressions;

namespace Hl7.Cql.Compiler
{
    /// <summary>
    /// Binds <see cref="CqlOperator"/>s to <see cref="Expression"/>s.
    /// </summary>
    internal abstract class OperatorBinding
    {
        /// <summary>
        /// Binds <paramref name="operator"/> to an <see cref="Expression"/>.
        /// </summary>
        /// <param name="operator">The operator to bind.</param>
        /// <param name="runtimeContext">The <see cref="Expression"/> that provides access to the <c>CqlContext</c>.</param>
        /// <param name="parameters">Zero or more parameter <see cref="Expression"/>s.  The number and order of expressions is dependent on <paramref name="operator"/>.</param>
        /// <returns>An expression that implements <paramref name="operator"/>.</returns>
        public abstract Expression Bind(CqlOperator @operator, Expression runtimeContext, params Expression[] parameters);
    }
}
