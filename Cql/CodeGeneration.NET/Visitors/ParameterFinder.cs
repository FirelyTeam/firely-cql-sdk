/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System.Collections.Generic;
using System.Linq.Expressions;

namespace Hl7.Cql.CodeGeneration.NET.Visitors
{
    internal class ParameterFinder : ExpressionVisitor
    {
        public IList<ParameterExpression> Parameters { get; } = new List<ParameterExpression>();


        protected override Expression VisitParameter(ParameterExpression node)
        {
            if (!Parameters.Contains(node))
                Parameters.Add(node);
            return base.VisitParameter(node);
        }
    }
}
