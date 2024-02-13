using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal partial class ExpressionVisitor
    {
        // | expression 'is' 'not'? ('null' | 'true' | 'false')                                            #booleanExpression
        public override Expression VisitBooleanExpression([NotNull] cqlParser.BooleanExpressionContext context)
        {
            var lastChild = context.children[^1].GetText();
            var isNot = context.children[^2].GetText() == "not";
            var operand = Visit(context.expression());

            Expression boolean = lastChild switch
            {
                "null" => SystemLibrary.IsNull.Call(InvocationBuilder, context, operand),
                "true" => SystemLibrary.IsTrue.Call(InvocationBuilder, context, operand),
                "false" => SystemLibrary.IsFalse.Call(InvocationBuilder, context, operand),
                _ => throw new InvalidOperationException($"Unexpected boolean comparison argument {lastChild}.")
            };

            if (isNot)
                boolean = SystemLibrary.Not.Call(InvocationBuilder, context, boolean);

            return boolean;
        }

        //     | 'singleton' 'from' expressionTerm                                             #elementExtractorExpressionTerm
        public override Expression VisitElementExtractorExpressionTerm([NotNull] cqlParser.ElementExtractorExpressionTermContext context)
        {
            var operand = Visit(context.expressionTerm());

            return SystemLibrary.SingletonFrom.Call(InvocationBuilder, context, operand);
        }

        //     | 'exists' expression                                                                           #existenceExpression
        public override Expression VisitExistenceExpression([NotNull] cqlParser.ExistenceExpressionContext context)
        {
            var operand = Visit(context.expression());

            return SystemLibrary.Exists.Call(InvocationBuilder, context, operand);
        }

        // | 'not' expression                                                                              #notExpression
        public override Expression VisitNotExpression([NotNull] cqlParser.NotExpressionContext context)
        {
            var operand = Visit(context.expression());

            return SystemLibrary.Not.Call(InvocationBuilder, context, operand);
        }

        //    | 'point' 'from' expressionTerm                                                 #pointExtractorExpressionTerm
        public override Expression VisitPointExtractorExpressionTerm([NotNull] cqlParser.PointExtractorExpressionTermContext context)
        {
            var operand = Visit(context.expressionTerm());
            return SystemLibrary.PointFrom.Call(InvocationBuilder, context, operand);
        }

        //    | 'predecessor' 'of' expressionTerm                                             #predecessorExpressionTerm
        public override Expression VisitPredecessorExpressionTerm([NotNull] cqlParser.PredecessorExpressionTermContext context)
        {
            var operand = Visit(context.expressionTerm());
            var call = SystemLibrary.Predecessor.Call(InvocationBuilder, context, operand);

            if (!operand.resultTypeSpecifier.IsValidOrderedType())
                call.AddError("Predecessor can only be applied to types that are ordered.");

            return call;
        }

        //     | 'successor' 'of' expressionTerm                                               #successorExpressionTerm
        public override Expression VisitSuccessorExpressionTerm([NotNull] cqlParser.SuccessorExpressionTermContext context)
        {
            var operand = Visit(context.expressionTerm());
            var call = SystemLibrary.Successor.Call(InvocationBuilder, context, operand);

            if (!operand.resultTypeSpecifier.IsValidOrderedType())
                call.AddError("Successor can only be applied to types that are ordered.");

            return call;
        }

        //   | ('start' | 'end') 'of' expressionTerm                                         #timeBoundaryExpressionTerm
        public override Expression VisitTimeBoundaryExpressionTerm([NotNull] cqlParser.TimeBoundaryExpressionTermContext context)
        {
            var startOrEnd = context.GetChild(0).GetText();
            var operand = Visit(context.expressionTerm());

            return startOrEnd switch
            {
                "start" => SystemLibrary.Start.Call(InvocationBuilder, context, operand),
                "end" => SystemLibrary.End.Call(InvocationBuilder, context, operand),
                _ => throw new InvalidOperationException($"Parser returned unknown start or end keyword '{startOrEnd}' in a time boundary expression.")
            };
        }

        //    ('minimum' | 'maximum') namedTypeSpecifier                                    #typeExtentExpressionTerm
        public override Expression VisitTypeExtentExpressionTerm([NotNull] cqlParser.TypeExtentExpressionTermContext context)
        {
            var extent = context.GetChild(0).GetText();
            var typeSpecifier = (NamedTypeSpecifier)TypeSpecifierVisitor.Visit(context.namedTypeSpecifier());

            Expression call = extent switch
            {
                "minimum" => SystemLibrary.MinValue.Build(typeSpecifier, context),
                "maximum" => SystemLibrary.MaxValue.Build(typeSpecifier, context),
                _ => throw new InvalidOperationException($"Parser returned unknown extent '{extent}' in a type extent expression.")
            };

            if (!typeSpecifier.IsValidOrderedType())
                call.AddError($"Can only determine {extent} for types that are ordered.");

            return call;
        }

        //   'width' expressionTerm                                                          #widthExpressionTerm
        public override Expression VisitWidthExpressionTerm([NotNull] cqlParser.WidthExpressionTermContext context)
        {
            var operand = Visit(context.expressionTerm());

            return SystemLibrary.Width.Call(InvocationBuilder, context, operand);
        }

        //   expression ('is' | 'as') typeSpecifier  
        public override Expression VisitTypeExpression([NotNull] cqlParser.TypeExpressionContext context)
        {
            var lhs = Visit(context.expression());
            var @operator = context.GetChild(1).GetText();
            var typeSpec = TypeSpecifierVisitor.Visit(context.typeSpecifier());

            Expression? expression = @operator switch
            {
                "is" => SystemLibrary.Is.Build(typeSpec, lhs, context),
                "as" => SystemLibrary.As.Build(false, typeSpec, lhs, context),
                _ => throw new InvalidOperationException($"Parser returned unknown token '{@operator}' in a type expression.")
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

        public override Expression VisitConversionExpressionTerm([NotNull] cqlParser.ConversionExpressionTermContext context)
        {
            var expression = Visit(context.expression());
            var tsContext = context.typeSpecifier();
            if (tsContext is not null)
            {
                var type = TypeSpecifierVisitor.Visit(tsContext);
                UnaryExpression convert;
                if (type is NamedTypeSpecifier nts)
                {
                    if (nts == SystemTypes.IntegerType)
                        convert = new ToInteger().WithResultType(SystemTypes.IntegerType);
                    if (nts == SystemTypes.LongType)
                        convert = new ToLong().WithResultType(SystemTypes.LongType);
                    else if (nts == SystemTypes.DecimalType)
                        convert = new ToDecimal().WithResultType(SystemTypes.DecimalType);
                    else if (nts == SystemTypes.DateTimeType)
                        convert = new ToDateTime().WithResultType(SystemTypes.DateTimeType);
                    else if (nts == SystemTypes.DateType)
                        convert = new ToDate().WithResultType(SystemTypes.DateType);
                    else if (nts == SystemTypes.ConceptType)
                        convert = new ToConcept().WithResultType(SystemTypes.ConceptType);
                    else if (nts == SystemTypes.BooleanType)
                        convert = new ToBoolean().WithResultType(SystemTypes.BooleanType);
                    else
                        convert = new Elm.Convert() { toTypeSpecifier = type }.WithResultType(type);
                }
                else {
                    convert = new Elm.Convert() { toTypeSpecifier = type }.WithResultType(type);
                }
                convert.operand = expression;
                return convert
                    .WithLocator(context.Locator());
            }
            else
            {
                var unitContext = Visit(context.unit());
            }
            throw new NotImplementedException();
        }
    }
}
