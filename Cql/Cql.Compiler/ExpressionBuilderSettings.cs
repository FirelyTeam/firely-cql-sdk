/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;

namespace Hl7.Cql.Compiler
{
    /// <summary>
    /// Describes settings to control the behavior of <see cref="ExpressionBuilder"/>
    /// </summary>
    internal class ExpressionBuilderSettings
    {
        /// <summary>
        /// Allows a child scope to redefine an existing parent scope.  Default is <see langword="true" />
        /// </summary>
        /// <remarks>
        /// For example, consider this query:
        ///
        /// IinCC X
        ///    return 
        ///    (
        ///        Tuple
        ///        {
        ///            sdate: start of X,
        ///            edate: 
        ///            end of X,
        ///            ndate: 
        ///            end of X + System.Quantity { value: DDiff, unit: 'day' }
        ///        } 
        ///    ) X
        ///         return Tuple 
        ///         {
        ///             CInterval: Interval[X.sdate, X.edate],
        ///             RInterval: Interval[X.sdate, X.ndate]
        ///         }
        ///
        /// Here, X is being used twice, because the source is a subquery.  X is used in the subquery and is also used
        /// in the main query.  ELM does not limit the scope of the first X to only the subquery as it probably should.
        /// </remarks>
        public bool AllowScopeRedefinition { get; set; } = true;

        /// <summary>
        /// When <see langword="true"/>, functions declared external will throw <see cref="NotImplementedException"/> at runtime
        /// if they are not found in <see cref="ExpressionBuilder.CustomImplementations"/>.  When <see langword="false"/>, an
        /// <see cref="InvalidOperationException"/> will be thrown during compilation if they are not found in <see cref="ExpressionBuilder.CustomImplementations"/>.
        /// The default value is <see langword="true"/>.
        /// </summary>
        public bool AllowUnresolvedExternals { get; set; } = true;

    }
}
