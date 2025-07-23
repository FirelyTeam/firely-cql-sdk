/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.CodeGeneration.NET.Visitors
{
    internal class ParameterFinder : ExpressionVisitor
    {
        private readonly HashSet<ParameterExpression> _parameters = new();
        public IEnumerable<ParameterExpression> Parameters => _parameters;

        protected override Expression VisitParameter(ParameterExpression node)
        {
            _parameters.Add(node);
            return base.VisitParameter(node);
        }
    }
}
