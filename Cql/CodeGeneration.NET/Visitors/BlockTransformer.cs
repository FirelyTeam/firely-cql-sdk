/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Hl7.Cql.CodeGeneration.NET.Visitors
{
    /// <summary>
    /// This visitor converts some expression types to blocks (i.e., wraps them in braces).
    /// </summary>
    internal class BlockTransformer : ExpressionVisitor
    {
        public VariableNameGenerator NameGenerator { get; }
        public IEnumerable<string> ScopeReservedVariables { get; }

        public bool DeclareLocals { get; }
        public bool UseLazyBools { get; }

        public BlockTransformer(VariableNameGenerator nameGenerator, IEnumerable<string> scopeReservedVariables,
            bool declareLocals = false,
            bool useLazyBools = false)
        {
            NameGenerator = nameGenerator;
            ScopeReservedVariables = scopeReservedVariables;
            DeclareLocals = declareLocals;
            UseLazyBools = useLazyBools;
        }

        public override Expression? Visit(Expression? node) =>
            node switch
            {
                { NodeType: ExpressionType.Call or ExpressionType.NewArrayInit or ExpressionType.MemberInit } =>
                            ToBlock(node),
                _ => node,
            };

        private Expression ToBlock(Expression node)
        {
            var elvTransformer = new ExtractLocalVariablesTransformer(NameGenerator);
            var newMethodCall = elvTransformer.Visit(node);

            if (elvTransformer.LocalAssignments.Any())
            {
                var parameters = elvTransformer.LocalAssignments
                    .Select(b => (ParameterExpression)b.Left);
                var all = elvTransformer.LocalAssignments.Concat(new Expression[] { newMethodCall });

                var block = DeclareLocals ? Expression.Block(parameters, all) : Expression.Block(all);
                var deduper = new LocalVariableDeduper(ScopeReservedVariables);
                var deduped = deduper.Visit(block)
                    ?? throw new InvalidOperationException("Visit returned null");
                var result = deduped;
                if (UseLazyBools)
                {
                    var vis = new LazyBoolAssignmentVisitor();
                    var toLazies = vis.Visit(deduped);
                    var referenceLazies = new LazyBoolAccessorVisitor(vis.NewParameters)
                         .Visit(toLazies);
                    result = referenceLazies;
                }
                return result;
            }
            else
            {
                return Expression.Block(newMethodCall);
            }
        }
    }
}
