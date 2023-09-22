using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Xml;

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

            UnaryExpression unary = lastChild switch
            {
                "null" => new IsNull() { operand = operand },
                "true" => new IsTrue() { operand = operand.CastNull(BooleanTypeName) },
                "false" => new IsFalse() { operand = operand.CastNull(BooleanTypeName) },
                _ => throw new InvalidOperationException($"Unexpected boolean comparison argument {lastChild}.")
            };

            unary = unary.WithLocator(context).WithNamedType(BooleanTypeName);

            if (isNot)
            {
                unary = new Not
                {
                    operand = unary,
                }.WithLocator(context).WithNamedType(BooleanTypeName);
            }

            return unary;
        }

        // singleton from
        public override Expression VisitElementExtractorExpressionTerm([NotNull] cqlParser.ElementExtractorExpressionTermContext context)
        {
            var operand = Visit(context.GetChild(2));
            if (operand.resultTypeSpecifier is ListTypeSpecifier lts)
            {
                var elementType = lts.elementType;
                XmlQualifiedName? typeName;
                if (elementType is NamedTypeSpecifier nts)
                    typeName = nts.name;
                else typeName = null;
                var singleton = new SingletonFrom
                {
                    localId = NextId(),
                    locator = context.Locator(),
                    operand = operand,
                    resultTypeName = typeName,
                    resultTypeSpecifier = elementType
                };
                return singleton;
            }
            else
            {
                UnresolvedSignature("Singleton", operand);
                return base.VisitElementExtractorExpressionTerm(context);
            }
        }

        public override Expression VisitExistenceExpression([NotNull] cqlParser.ExistenceExpressionContext context)
        {
            var operand = Visit(context.GetChild(1));
            if (operand is Null)
            {
                var listAnyType = ListType(NamedType(AnyTypeName, context), context);
                operand = new As
                {
                    operand = operand,
                    localId = NextId(),
                    locator = operand.locator,
                    asTypeSpecifier = listAnyType,
                    resultTypeSpecifier = listAnyType,
                };
            }
            if (operand.resultTypeSpecifier is not ListTypeSpecifier)
                UnresolvedSignature("Exists", operand);
            var exists = new Exists
            {
                localId = NextId(),
                locator = context.Locator(),
                operand = operand,
                resultTypeName = new XmlQualifiedName(BooleanTypeName),
                resultTypeSpecifier = NamedType(BooleanTypeName, context),
            };
            return exists;
        }

        public override Expression VisitNotExpression([NotNull] cqlParser.NotExpressionContext context)
        {
            var operand = Visit(context.GetChild(1));
            if (operand is Null)
                operand = new As
                {
                    operand = operand,
                    localId = NextId(),
                    locator = operand.locator,
                    asType = new XmlQualifiedName(BooleanTypeName),
                    asTypeSpecifier = NamedType(BooleanTypeName, context),
                    resultTypeName = new XmlQualifiedName(BooleanTypeName),
                    resultTypeSpecifier = NamedType(BooleanTypeName, context),
                };
            if (operand.resultTypeName?.Name != BooleanTypeName)
                UnresolvedSignature("Not", operand);
            var not = new Not
            {
                localId = NextId(),
                locator = context.Locator(),
                operand = operand,
                resultTypeName = new XmlQualifiedName(BooleanTypeName),
                resultTypeSpecifier = NamedType(BooleanTypeName, context),
            };
            return not;
        }

        public override Expression VisitPointExtractorExpressionTerm([NotNull] cqlParser.PointExtractorExpressionTermContext context)
        {
            var operand = Visit(context.GetChild(2));
            if (operand.resultTypeSpecifier is IntervalTypeSpecifier its)
            {
                var pointType = its.pointType;
                XmlQualifiedName? typeName;
                if (pointType is NamedTypeSpecifier nts)
                    typeName = nts.name;
                else typeName = null;
                var point = new PointFrom
                {
                    localId = NextId(),
                    locator = context.Locator(),
                    operand = operand,
                    resultTypeName = typeName,
                    resultTypeSpecifier = pointType
                };
                return point;
            }
            else
            {
                UnresolvedSignature("Point", operand);
                return base.VisitPointExtractorExpressionTerm(context);
            }
        }

        public override Expression VisitPredecessorExpressionTerm([NotNull] cqlParser.PredecessorExpressionTermContext context)
        {
            var operand = Visit(context.GetChild(2));
            var predecessor = new Predecessor
            {
                localId = NextId(),
                locator = context.Locator(),
                operand = operand,
                resultTypeName = operand.resultTypeName,
                resultTypeSpecifier = operand.resultTypeSpecifier
            };
            return predecessor;
        }

        public override Expression VisitSuccessorExpressionTerm([NotNull] cqlParser.SuccessorExpressionTermContext context)
        {
            var operand = Visit(context.GetChild(2));
            var successor = new Successor
            {
                localId = NextId(),
                locator = context.Locator(),
                operand = operand,
                resultTypeName = operand.resultTypeName,
                resultTypeSpecifier = operand.resultTypeSpecifier
            };
            return successor;
        }

        //   | ('start' | 'end') 'of' expressionTerm                                         #timeBoundaryExpressionTerm
        public override Expression VisitTimeBoundaryExpressionTerm([NotNull] cqlParser.TimeBoundaryExpressionTermContext context)
        {
            var kw = Keyword.Parse(context.GetChild(0).GetText());
            if (kw?.Length == 1)
            {
                var operand = Visit(context.GetChild(2))
                    ?? throw UnresolvedSignature(context.GetChild(0).GetText());
                if (operand.resultTypeSpecifier is IntervalTypeSpecifier its)
                {
                    var pointType = PointType(its);
                    if (kw[0] == CqlKeyword.Start)
                    {

                        var start = new Start
                        {
                            resultTypeSpecifier = pointType,
                            localId = NextId(),
                            locator = context.Locator(),
                            operand = operand,
                        };
                        if (start.resultTypeSpecifier is NamedTypeSpecifier nts)
                            start.resultTypeName = nts.name;
                        return start;
                    }
                    else if (kw[0] == CqlKeyword.End)
                    {
                        var end = new End
                        {
                            resultTypeSpecifier = pointType,
                            localId = NextId(),
                            locator = context.Locator(),
                            operand = operand,
                        };
                        if (end.resultTypeSpecifier is NamedTypeSpecifier nts)
                            end.resultTypeName = nts.name;
                        return end;
                    }
                    throw UnresolvedSignature("Start", operand);

                }
            }
            throw UnresolvedSignature("Start");
        }

        public override Expression VisitTypeExtentExpressionTerm([NotNull] cqlParser.TypeExtentExpressionTermContext context)
        {
            var extent = context.GetChild(0).GetText().ToLower();
            var dataType = context.GetChild(1).GetText();
            var typeName = ModelProvider.QualifiedTypeName(SystemModel, dataType);
            if (extent == "minimum")
            {
                var min = new MinValue
                {
                    resultTypeName = new XmlQualifiedName(typeName),
                    resultTypeSpecifier = NamedType(typeName, context),
                    localId = NextId(),
                    locator = context.Locator(),
                    valueType = new XmlQualifiedName(typeName)
                };
                return min;
            }
            else if (extent == "maximum")
            {
                var max = new MaxValue
                {
                    resultTypeName = new XmlQualifiedName(typeName),
                    resultTypeSpecifier = NamedType(typeName, context),
                    localId = NextId(),
                    locator = context.Locator(),
                    valueType = new XmlQualifiedName(typeName)
                };
                return max;
            }
            else
            {
                throw Critical($"Unexpected extent: {extent}");
            }
        }

        public override Expression VisitWidthExpressionTerm([NotNull] cqlParser.WidthExpressionTermContext context)
        {
            var operand = Visit(context.GetChild(2));
            if (operand.resultTypeSpecifier is IntervalTypeSpecifier its)
            {
                var pointType = its.pointType;
                XmlQualifiedName? typeName;
                if (pointType is NamedTypeSpecifier nts)
                    typeName = nts.name;
                else typeName = null;
                var width = new Width
                {
                    localId = NextId(),
                    locator = context.Locator(),
                    operand = operand,
                    resultTypeName = typeName,
                    resultTypeSpecifier = pointType
                };
                return width;
            }
            else
            {
                UnresolvedSignature("Width", operand);
                return base.VisitWidthExpressionTerm(context);
            }
        }
    }
}
