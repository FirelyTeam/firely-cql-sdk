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
    internal class ParameterFinder : ExpressionVisitor
    {
        public IList<string> Names { get; } = new List<string>();


        protected override Expression VisitParameter(ParameterExpression node)
        {
            if (node.Name != null && !Names.Contains(node.Name))
                Names.Add(node.Name);
            return base.VisitParameter(node);
        }
    }
}
