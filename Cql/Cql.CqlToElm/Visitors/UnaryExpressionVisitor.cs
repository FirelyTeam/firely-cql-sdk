using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal partial class ExpressionVisitor
    {
        // | expression 'is' 'not'? ('null' | 'true' | 'false')                                            #booleanExpression
        public override Expression VisitBooleanExpression([NotNull] cqlParser.BooleanExpressionContext context)
        {
            var lastChild = Keyword.Parse(context.children[^1]).Single();
            var isNot = Keyword.Parse(context.children[^2]).Single() == CqlKeyword.Not;
            var operand = Visit(context.expression());

            OperatorExpression boolean = lastChild switch
            {
                CqlKeyword.Null => SystemLibrary.IsNull.Build(ModelProvider, context, operand),
                CqlKeyword.True => SystemLibrary.IsTrue.Build(ModelProvider, context, operand),
                CqlKeyword.False => SystemLibrary.IsFalse.Build(ModelProvider, context, operand),
                _ => throw new InvalidOperationException($"Unexpected boolean comparison argument {lastChild}.")
            };

            if (isNot)
                boolean = SystemLibrary.Not.Build(ModelProvider, context, boolean);

            return boolean;
        }

        //     | 'singleton' 'from' expressionTerm                                             #elementExtractorExpressionTerm
        public override Expression VisitElementExtractorExpressionTerm([NotNull] cqlParser.ElementExtractorExpressionTermContext context)
        {
            var operand = Visit(context.expressionTerm());

            return SystemLibrary.SingletonFrom.Build(ModelProvider, context, operand);
        }

        //     | 'exists' expression                                                                           #existenceExpression
        public override Expression VisitExistenceExpression([NotNull] cqlParser.ExistenceExpressionContext context)
        {
            var operand = Visit(context.expression());

            return SystemLibrary.Exists.Build(ModelProvider, context, operand);
        }

        // | 'not' expression                                                                              #notExpression
        public override Expression VisitNotExpression([NotNull] cqlParser.NotExpressionContext context)
        {
            var operand = Visit(context.expression());

            return SystemLibrary.Not.Build(ModelProvider, context, operand);
        }

        //    | 'point' 'from' expressionTerm                                                 #pointExtractorExpressionTerm
        public override Expression VisitPointExtractorExpressionTerm([NotNull] cqlParser.PointExtractorExpressionTermContext context)
        {
            var operand = Visit(context.expressionTerm());

            return operand.resultTypeSpecifier switch
            {
                IntervalTypeSpecifier => SystemLibrary.PointFrom.Build(ModelProvider, context, operand),
                _ => throw UnresolvedSignature(nameof(PointFrom), operand)
            };
        }

        //    | 'predecessor' 'of' expressionTerm                                             #predecessorExpressionTerm
        public override Expression VisitPredecessorExpressionTerm([NotNull] cqlParser.PredecessorExpressionTermContext context)
        {
            var operand = Visit(context.expressionTerm());

            if (operand.resultTypeSpecifier.IsValidOrderedType())
            {
                return SystemLibrary.Predecessor.Build(ModelProvider, context, operand);
            }
            else
                throw UnresolvedSignature(nameof(Predecessor), operand);
        }

        //     | 'successor' 'of' expressionTerm                                               #successorExpressionTerm
        public override Expression VisitSuccessorExpressionTerm([NotNull] cqlParser.SuccessorExpressionTermContext context)
        {
            var operand = Visit(context.expressionTerm());

            if (operand.resultTypeSpecifier.IsValidOrderedType())
            {
                return SystemLibrary.Successor.Build(ModelProvider, context, operand);
            }
            else
                throw UnresolvedSignature(nameof(Successor), operand);
        }

        //   | ('start' | 'end') 'of' expressionTerm                                         #timeBoundaryExpressionTerm
        public override Expression VisitTimeBoundaryExpressionTerm([NotNull] cqlParser.TimeBoundaryExpressionTermContext context)
        {
            var startOrEnd = Keyword.Parse(context.GetChild(0)).Single();
            var operand = Visit(context.expressionTerm());

            if (operand.resultTypeSpecifier is IntervalTypeSpecifier)
            {
                return startOrEnd switch
                {
                    CqlKeyword.Start => SystemLibrary.Start.Build(ModelProvider, context, operand),
                    CqlKeyword.End => SystemLibrary.End.Build(ModelProvider, context, operand),
                    _ => throw UnresolvedSignature("Start", operand)
                };
            }
            else
                throw UnresolvedSignature("Start", operand);
        }

        //    ('minimum' | 'maximum') namedTypeSpecifier                                    #typeExtentExpressionTerm
        public override Expression VisitTypeExtentExpressionTerm([NotNull] cqlParser.TypeExtentExpressionTermContext context)
        {
            var extent = Keyword.Parse(context.GetChild(0)).Single();
            var typeSpecifier = (NamedTypeSpecifier)TypeSpecifierVisitor.Visit(context.namedTypeSpecifier());

            if (typeSpecifier.IsValidOrderedType())
            {
                return extent switch
                {
                    CqlKeyword.Minimum => SystemLibrary.MinValue.Build(typeSpecifier, context),
                    CqlKeyword.Maximum => SystemLibrary.MaxValue.Build(typeSpecifier, context),
                    _ => throw Critical($"Unexpected extent: {extent}")
                };
            }
            else
                throw UnresolvedSignature(extent.ToString(), new Null().WithResultType(typeSpecifier));
        }

        //   'width' expressionTerm                                                          #widthExpressionTerm
        public override Expression VisitWidthExpressionTerm([NotNull] cqlParser.WidthExpressionTermContext context)
        {
            var operand = Visit(context.expressionTerm());

            return operand.resultTypeSpecifier switch
            {
                IntervalTypeSpecifier => SystemLibrary.Width.Build(ModelProvider, context, operand),
                _ => throw UnresolvedSignature("Width", operand)
            };
        }

        //   expression ('is' | 'as') typeSpecifier  
        public override Expression VisitTypeExpression([NotNull] cqlParser.TypeExpressionContext context)
        {
            var lhs = Visit(context.expression());
            var @operator = Keyword.Parse(context.GetChild(1)).Single();
            var typeSpec = TypeSpecifierVisitor.Visit(context.typeSpecifier());

            Expression? expression = @operator switch
            {
                CqlKeyword.Is => SystemLibrary.Is.Build(typeSpec, lhs, context),
                CqlKeyword.As => SystemLibrary.As.Build(false, typeSpec, lhs, context),
                _ => throw Critical($"Unexpected operator {@operator}")
            };

            return expression;
        }

        // 'cast' expression 'as' typeSpecifier                                                          #castExpression
        public override Expression VisitCastExpression([NotNull] cqlParser.CastExpressionContext context)
        {
            var operand = Visit(context.expression());
            var typeSpecifier = TypeSpecifierVisitor.Visit(context.typeSpecifier());

            return SystemLibrary.As.Build(true, typeSpecifier, operand, context);
        }
    }
}
