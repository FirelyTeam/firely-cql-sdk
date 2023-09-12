/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Generic;

namespace Hl7.Cql.Compiler
{
    /// <summary>
    /// Provides a method for altering an expression, e.g., translating a Conditional to an if/else block, or adding a call to a logging method.
    /// </summary>
    internal interface IExpressionMutator
    {
        /// <summary>
        /// Gets the keys that are required by this interceptor.
        /// Using two <see cref="IExpressionMutator"/> on the same <see cref="ExpressionBuilder"/> which require the same keys will result in an <see cref="InvalidOperationException"/>.
        /// </summary>
        public IEnumerable<(string, Type)> RuntimeContextKeys { get; }

        /// <summary>
        /// Intercepts this expression and possibly modifies it.  If no modification is desired, return <paramref name="linqExpression"/>.
        /// </summary>
        /// <param name="linqExpression">The source expression.</param>
        /// <param name="elmExpression">The corresponding ELM expression.</param>
        /// <param name="context">The build context.  Be careful modifying this value as it can have unexpected side effects (e.g., removing key from <see cref="ExpressionBuilderContext.Scopes"/> could break the builder.).</param>
        public System.Linq.Expressions.Expression Mutate(System.Linq.Expressions.Expression linqExpression,
            Elm.Element elmExpression,
            ExpressionBuilderContext context);
    }
}
