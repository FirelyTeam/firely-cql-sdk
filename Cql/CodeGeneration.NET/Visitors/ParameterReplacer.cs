/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections.Generic;
using System.Linq.Expressions;

namespace Hl7.Cql.CodeGeneration.NET.Visitors
{

    /// <summary>
    /// This visitor travels a (subtree), replacing ParameterExpressions, where the 'key' in the dictionary
    /// is the parameter to replace, and the value is the replacement.
    /// </summary>
    internal class ParameterReplacer : ExpressionVisitor
    {
        public ParameterReplacer(IDictionary<ParameterExpression, ParameterExpression>? replacements = null)
        {
            Replacements = replacements ?? new Dictionary<ParameterExpression, ParameterExpression>();
        }

        public IDictionary<ParameterExpression, ParameterExpression> Replacements { get; }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            if (Replacements.TryGetValue(node, out var replacement))
                return replacement;
            else
                return base.VisitParameter(node);
        }
    }
}
