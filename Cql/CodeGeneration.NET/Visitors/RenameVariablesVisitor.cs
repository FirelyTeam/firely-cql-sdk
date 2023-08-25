/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Hl7.Cql.CodeGeneration.NET.Visitors
{
    /// <summary>
    /// This visitor finds the blocks in the expression tree which have variables
    /// with no names, and assigns them new names using a NameGenerator.
    /// </summary>
    internal class RenameVariablesVisitor : ExpressionVisitor
    {
        private readonly VariableNameGenerator initialNameGenerator;
        private bool useInitialGenerator = true;

        private readonly Stack<Dictionary<ParameterExpression, ParameterExpression>> _replacementStack = new();

        public RenameVariablesVisitor(VariableNameGenerator nameGenerator)
        {
            this.initialNameGenerator = nameGenerator;
        }

        protected override Expression VisitBlock(BlockExpression node)
        {
            var localNameGenerator = useInitialGenerator ? initialNameGenerator : initialNameGenerator.ForNewScope(node.Variables);
            useInitialGenerator = false;

            var parametersToName = node.Variables.Where(v => v.Name is null);
            var replacementDictionary = new Dictionary<ParameterExpression, ParameterExpression>();

            foreach (var parameterToName in parametersToName)
            {
                var newName = localNameGenerator.Next();
                var newParameter = Expression.Parameter(parameterToName.Type, newName);
                replacementDictionary.Add(parameterToName, newParameter);
            }

            _replacementStack.Push(replacementDictionary);
            var visitedExpression = base.VisitBlock(node);
            _replacementStack.Pop();

            return visitedExpression;
        }

        protected override Expression VisitParameter(ParameterExpression node) =>
            _replacementStack
                .Select(s => s.GetValueOrDefault(node))
                .FirstOrDefault(n => n is not null) ?? node;
    }
}

