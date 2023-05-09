using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using AgileObjects.ReadableExpressions;

namespace Ncqa.Cql.CodeGeneration.NET.Visitors
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

        public override Expression Visit(Expression node)
        {
            switch (node.NodeType)
            {
                case ExpressionType.Call:
                case ExpressionType.NewArrayInit:
                case ExpressionType.MemberInit:
                case ExpressionType.Lambda:
                    return base.Visit(node);
                default:
                    return node;
            }
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            return ToBlock(node);

        }

        private Expression ToBlock(Expression node)
        {
            var elvTransformer = new ExtractLocalVariablesTransformer(NameGenerator);
            var newMethodCall = elvTransformer.Visit(node);
            LabelTarget returnLabelTarget = Expression.Label(newMethodCall.Type);
            LabelExpression @return = Expression.Label(returnLabelTarget, newMethodCall);
            if (elvTransformer.LocalAssignments.Any())
            {
                var parameters = elvTransformer.LocalAssignments
                    .Select(b => (ParameterExpression)b.Left);
                var all = elvTransformer.LocalAssignments.Concat(new Expression[] { @return });

                var block = DeclareLocals ? Expression.Block(parameters, all) : Expression.Block(all);
                var deduper = new LocalVariableDeduper(ScopeReservedVariables);
                var deduped = deduper.Visit(block);
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
                return Expression.Block(@return);
            }
        }

        // Not used currently.  Generates too many confusing locals
        protected override Expression VisitConditional(ConditionalExpression node)
        {
            var elvTransformer = new ExtractLocalVariablesTransformer(NameGenerator);
            var newNode = elvTransformer.Visit(node);
            LabelTarget returnLabelTarget = Expression.Label(newNode.Type);
            LabelExpression @return = Expression.Label(returnLabelTarget, newNode);
            if (elvTransformer.LocalAssignments.Any())
            {
                foreach (var assignment in elvTransformer.LocalAssignments)
                {
                    var asString = assignment.ToReadableString();
                }

                var parameters = elvTransformer.LocalAssignments
                    .Select(b => (ParameterExpression)b.Left);
                var all = elvTransformer.LocalAssignments.Concat(new Expression[] { @return });
                var newBlock = DeclareLocals ? Expression.Block(parameters, all) : Expression.Block(all);
                return newBlock;
            }
            else return Expression.Block(@return);
        }

        protected override Expression VisitMemberInit(MemberInitExpression node)
        {
            return ToBlock(node);
        }

        protected override Expression VisitNewArray(NewArrayExpression node)
        {
            return ToBlock(node);
        }

        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            var newBody = Visit(node.Body);
            var newLambda = Expression.Lambda(newBody, node.Parameters);
            return newLambda;
        }
    }
}
