/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;
using System;

namespace Hl7.Cql.Compiler
{
    /// <summary>
    /// Describes settings to control the behavior of <see cref="ExpressionBuilder"/>
    /// </summary>
    /// <param name="AllowScopeRedefinition"></param>
    /// <param name="AllowUnresolvedExternals"></param>
#pragma warning disable RS0016 // Add public types and members to the declared API
    internal record ExpressionBuilderOptions(
        bool AllowScopeRedefinition = true, 
        bool AllowUnresolvedExternals = true)
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
        public bool AllowScopeRedefinition { get; init; } = AllowScopeRedefinition;

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
        public bool AllowUnresolvedExternals { get; init; } = AllowUnresolvedExternals;
    }
#pragma warning restore RS0016 // Add public types and members to the declared API
}
