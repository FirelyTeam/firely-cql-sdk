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
                "null" => InvocationBuilder.Invoke(SystemLibrary.IsNull, operand),
                "true" => InvocationBuilder.Invoke(SystemLibrary.IsTrue, operand),
                "false" => InvocationBuilder.Invoke(SystemLibrary.IsFalse, operand),
                _ => throw new InvalidOperationException($"Unexpected boolean comparison argument {lastChild}.")
            };

            if (isNot)
                boolean = InvocationBuilder.Invoke(SystemLibrary.Not, boolean);

            return boolean
                .WithId()
                .WithLocator(context.Locator());
        }

        //     | 'singleton' 'from' expressionTerm                                             #elementExtractorExpressionTerm
        public override Expression VisitElementExtractorExpressionTerm([NotNull] cqlParser.ElementExtractorExpressionTermContext context)
        {
            var operand = Visit(context.expressionTerm());

            var expression = InvocationBuilder.Invoke(SystemLibrary.SingletonFrom, operand);
            return expression
                .WithId()
                .WithLocator(context.Locator());
        }

        //     | 'exists' expression                                                                           #existenceExpression
        public override Expression VisitExistenceExpression([NotNull] cqlParser.ExistenceExpressionContext context)
        {
            var operand = Visit(context.expression());

            var expression = InvocationBuilder.Invoke(SystemLibrary.Exists, operand);
            return expression
                .WithId()
                .WithLocator(context.Locator());
        }

        // | 'not' expression                                                                              #notExpression
        public override Expression VisitNotExpression([NotNull] cqlParser.NotExpressionContext context)
        {
            var operand = Visit(context.expression());
            var expression = InvocationBuilder.Invoke(SystemLibrary.Not, operand);
            return expression
                .WithId()
                .WithLocator(context.Locator());
        }

        //    | 'point' 'from' expressionTerm                                                 #pointExtractorExpressionTerm
        public override Expression VisitPointExtractorExpressionTerm([NotNull] cqlParser.PointExtractorExpressionTermContext context)
        {
            var operand = Visit(context.expressionTerm());
            var expression = InvocationBuilder.Invoke(SystemLibrary.PointFrom, operand);
            return expression
                .WithId()
                .WithLocator(context.Locator());
        }

        //    | 'predecessor' 'of' expressionTerm                                             #predecessorExpressionTerm
        public override Expression VisitPredecessorExpressionTerm([NotNull] cqlParser.PredecessorExpressionTermContext context)
        {
            var operand = Visit(context.expressionTerm());
            var expression = InvocationBuilder.Invoke(SystemLibrary.Predecessor, operand);

            if (!operand.resultTypeSpecifier.IsValidOrderedType())
                expression.AddError("Predecessor can only be applied to types that are ordered.");

            return expression
                .WithId()
                .WithLocator(context.Locator());
        }

        //     | 'successor' 'of' expressionTerm                                               #successorExpressionTerm
        public override Expression VisitSuccessorExpressionTerm([NotNull] cqlParser.SuccessorExpressionTermContext context)
        {
            var operand = Visit(context.expressionTerm());
            var expression = InvocationBuilder.Invoke(SystemLibrary.Successor, operand);

            if (!operand.resultTypeSpecifier.IsValidOrderedType())
                expression.AddError("Successor can only be applied to types that are ordered.");

            return expression
                .WithId()
                .WithLocator(context.Locator());
        }

        //   | ('start' | 'end') 'of' expressionTerm                                         #timeBoundaryExpressionTerm
        public override Expression VisitTimeBoundaryExpressionTerm([NotNull] cqlParser.TimeBoundaryExpressionTermContext context)
        {
            var startOrEnd = context.GetChild(0).GetText();
            var operand = Visit(context.expressionTerm());

            var expression = startOrEnd switch
            {
                "start" => InvocationBuilder.Invoke(SystemLibrary.Start, operand),
                "end" => InvocationBuilder.Invoke(SystemLibrary.End, operand),
                _ => throw new InvalidOperationException($"Parser returned unknown start or end keyword '{startOrEnd}' in a time boundary expression.")
            };
            return expression
                .WithId()
                .WithLocator(context.Locator());
        }

        //    ('minimum' | 'maximum') namedTypeSpecifier                                    #typeExtentExpressionTerm
        public override Expression VisitTypeExtentExpressionTerm([NotNull] cqlParser.TypeExtentExpressionTermContext context)
        {
            var extent = context.GetChild(0).GetText();
            var typeSpecifier = (NamedTypeSpecifier)TypeSpecifierVisitor.Visit(context.namedTypeSpecifier());

            Expression expression = extent switch
            {
                "minimum" => InvocationBuilder.MinValue(typeSpecifier),
                "maximum" => InvocationBuilder.MaxValue(typeSpecifier),
                _ => throw new InvalidOperationException($"Parser returned unknown extent '{extent}' in a type extent expression.")
            };

            if (!typeSpecifier.IsValidOrderedType())
                expression.AddError($"Can only determine {extent} for types that are ordered.");
            
            return expression
                .WithId()
                .WithLocator(context.Locator());
        }

        //   'width' expressionTerm                                                          #widthExpressionTerm
        public override Expression VisitWidthExpressionTerm([NotNull] cqlParser.WidthExpressionTermContext context)
        {
            var operand = Visit(context.expressionTerm());

            var expression = InvocationBuilder.Invoke(SystemLibrary.Width, operand);
            return expression
                .WithId()
                .WithLocator(context.Locator());
        }

        //   expression ('is' | 'as') typeSpecifier  
        public override Expression VisitTypeExpression([NotNull] cqlParser.TypeExpressionContext context)
        {
            var lhs = Visit(context.expression());
            var @operator = context.GetChild(1).GetText();
            var typeSpec = TypeSpecifierVisitor.Visit(context.typeSpecifier());

            Expression expression;
            if (@operator == "is")
            {
                expression = InvocationBuilder.Invoke(SystemLibrary.Is, lhs);
                if (expression is Is @is)
                {
                    @is.isTypeSpecifier = typeSpec;
                    if (typeSpec is NamedTypeSpecifier nts)
                        @is.isType = nts.name;
                }
                else throw new InvalidOperationException($"Expecting Is node; got {expression.GetType()}");
            }
            else if (@operator == "as")
            {
                var result = TypeConverter.Convert(lhs, typeSpec);
                expression = result.Result;
                if (result.Cost > ConversionCost.Cast || result.Result is not As)
                    expression
                        .AddError($"Expression of type '{expression.resultTypeSpecifier}' cannot be cast as a value of type '{typeSpec}'.");
                if (result.Error is not null)
                    expression = result.Result.AddError(result.Error);
            }
            else throw new InvalidOperationException($"Unexpected term {@operator}.  Expected 'is' or 'as'.");

            return expression
                .WithId()
                .WithLocator(context.Locator());
        }

        // 'cast' expression 'as' typeSpecifier                                                          #castExpression
        public override Expression VisitCastExpression([NotNull] cqlParser.CastExpressionContext context)
        {
            var operand = Visit(context.expression());
            var typeSpecifier = TypeSpecifierVisitor.Visit(context.typeSpecifier());
            var result = TypeConverter.Convert(operand, typeSpecifier);
            if (result.Cost <= ConversionCost.Cast && result.Result is As @as)
            {
                @as.strict = true;
                return @as
                    .WithId()
                    .WithLocator(context.Locator());
            }
            else
                return result.Result
                    .WithId()
                    .WithLocator(context.Locator())
                    .AddError($"Expression of type '{operand.resultTypeSpecifier}' cannot be cast as a value of type '{typeSpecifier}'.")
                    .WithResultType(typeSpecifier);
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
