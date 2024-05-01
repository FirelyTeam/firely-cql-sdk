/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
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
            // Every nested block can introduce new named parameters that we should not rename, so 
            // we'll start by creating a new generator with the blocks variables/parameters
            var localNameGenerator = useInitialGenerator ? initialNameGenerator : initialNameGenerator.ForNewScope(node.Variables);
            useInitialGenerator = false;

            var replacementDictionary = new Dictionary<ParameterExpression, ParameterExpression>();

            // Go over the variables introduced in this block and assign them a name.
            foreach (var parameterToName in node.Variables)
            {
                var newName = localNameGenerator.Next();
                var newParameter = Expression.Parameter(parameterToName.Type, newName);
                replacementDictionary.Add(parameterToName, newParameter);
            }

            // Since we are visiting the children to do a rename of these variables deeper down
            // as well, push these renames on the stack, which will hold the renames for all nested
            // blocks representing the lexical scopes.
            _replacementStack.Push(replacementDictionary);
            var visitedExpression = base.VisitBlock(node);
            _replacementStack.Pop();

            return visitedExpression;
        }

        /// <summary>
        /// Replace the parameters in the replacements, looking up from our scope.
        /// </summary>
        protected override Expression VisitParameter(ParameterExpression node) =>
            _replacementStack
                .Select(s => s.GetValueOrDefault(node))
                .FirstOrDefault(n => n is not null) ?? node;
    }
}

