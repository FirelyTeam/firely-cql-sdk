using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal partial class ExpressionVisitor : Visitor<Expression>
    {
        public ExpressionVisitor(
            IModelProvider provider,
            ConverterContext converterContext,
            LibraryBuilder libraryBuilder,
            TypeSpecifierVisitor typeSpecifierVisitor,
            LocalIdentifierProvider localIdentifierProvider,
            InvocationBuilder invocationBuilder) : base(localIdentifierProvider, invocationBuilder)
        {
            ModelProvider = provider;
            ConverterContext = converterContext;
            LibraryBuilder = libraryBuilder;
            TypeSpecifierVisitor = typeSpecifierVisitor;
        }

        #region Privates
        private readonly IModelProvider ModelProvider;
        private readonly TypeSpecifierVisitor TypeSpecifierVisitor;

        public ConverterContext ConverterContext { get; }
        public LibraryBuilder LibraryBuilder { get; }
        #endregion

        // 'Interval' ('['|'(') expression ',' expression (']'|')')
        public override Expression VisitIntervalSelector([Antlr4.Runtime.Misc.NotNull] cqlParser.IntervalSelectorContext context)
        {
            var lowClosed = context.GetChild(1).GetText() switch
            {
                "[" => true,
                "(" => false,
                var c => throw new InvalidOperationException($"Parser returned unexpected character '{c}' in interval selector.") // this really can't happen
            };

            var highClosed = context.GetChild(5).GetText() switch
            {
                "]" => true,
                ")" => false,
                var c => throw new InvalidOperationException($"Parser returned unexpected character '{c}' in interval selector.") // this really can't happen
            };

            var expressions = context.expression();
            var low = Visit(expressions[0]);
            var high = Visit(expressions[1]);

            var pointType = low is not Null ? low.resultTypeSpecifier : high.resultTypeSpecifier;
            if (low is Null && pointType != SystemTypes.AnyType)
                low = SystemLibrary.As.Build(false, pointType, low, context);
            if (high is Null && pointType != SystemTypes.AnyType)
                high = SystemLibrary.As.Build(false, pointType, high, context);

            var interval = new Elm.Interval
            {
                high = high,
                low = low,
                highClosed = highClosed,
                lowClosed = lowClosed,
            }.WithLocator(context.Locator()).WithResultType(pointType.ToIntervalType());

            if (low.resultTypeSpecifier == high.resultTypeSpecifier)
            {
                if (pointType.IsValidOrderedType())
                {
                    if (low is Quantity lowQuantity && high is Quantity highQuantity
                        && !UnitsAreCompatible(lowQuantity.unit, highQuantity.unit))
                        interval.AddError($"Intervals of quantities must be of compatible units.");
                }
                else
                    interval.AddError($"Intervals can only be constructed for types with defined minimums and maximums. Type {pointType} is not allowed.");
            }
            else
                interval.AddError($"Interval types for low ({low.resultTypeName}) and high ({high.resultTypeName}) do not match.");

            return interval;
        }

        // : ('List' ('<' typeSpecifier '>')?)? '{' (expression (',' expression)*)? '}'
        public override Expression VisitListSelector([Antlr4.Runtime.Misc.NotNull] cqlParser.ListSelectorContext context)
        {
            var typeSpecifier = context.typeSpecifier() is { } tsContext ? TypeSpecifierVisitor.Visit(tsContext) : null;
            var elements = context.expression().Select(Visit).ToArray();

            if (!elements.Any())
            {
                return new List
                {
                    element = Array.Empty<Expression>(),
                }.WithLocator(context.Locator()).WithResultType(SystemTypes.AnyType.ToListType());
            }

            var maximalElementType = ListElementPromotion.None;
            var elementTypes = new ListElementPromotion[elements.Length];

            for (var ix = 0; ix < elements.Length; ix++)
            {
                var element = elements[ix];

                if (element.resultTypeSpecifier == SystemTypes.QuantityType)
                {
                    elementTypes[ix] = ListElementPromotion.Quantity;
                    maximalElementType = ListElementPromotion.Quantity;
                }
                else if (element.resultTypeSpecifier == SystemTypes.DecimalType)
                {
                    elementTypes[ix] = ListElementPromotion.Decimal;
                    maximalElementType = (ListElementPromotion)Math.Max((int)maximalElementType, (int)ListElementPromotion.Decimal);
                }
                else if (element.resultTypeSpecifier == SystemTypes.LongType)
                {
                    elementTypes[ix] = ListElementPromotion.Long;
                    maximalElementType = (ListElementPromotion)Math.Max((int)maximalElementType, (int)ListElementPromotion.Long);
                }
                else if (element.resultTypeSpecifier == SystemTypes.IntegerType)
                {
                    elementTypes[ix] = ListElementPromotion.Integer;
                }
            }

            for (int i = 0; i < elements.Length; i++)
                elements[i] = promote(elements[i], elementTypes[i], maximalElementType);

            Expression promote(Expression expression, ListElementPromotion from, ListElementPromotion to) =>
                from switch
                {
                    ListElementPromotion.Decimal => to switch
                    {
                        ListElementPromotion.Quantity => toQuantity(expression),
                        _ => expression
                    },
                    ListElementPromotion.Long => to switch
                    {
                        ListElementPromotion.Quantity => toQuantity(expression),
                        ListElementPromotion.Decimal => toDecimal(expression),
                        _ => expression
                    },
                    ListElementPromotion.Integer => to switch
                    {
                        ListElementPromotion.Quantity => toQuantity(expression),
                        ListElementPromotion.Decimal => toDecimal(expression),
                        ListElementPromotion.Long => toLong(expression),
                        _ => expression,
                    },
                    _ => expression,
                };

            Expression toQuantity(Expression ex) => new ToQuantity
            {
                operand = new ToDecimal
                {
                    operand = ex,
                }.WithLocator(ex.locator).WithResultType(SystemTypes.DecimalType),
            }.WithLocator(ex.locator).WithResultType(SystemTypes.QuantityType);

            Expression toDecimal(Expression ex) => new ToDecimal
            {
                operand = ex,
            }.WithLocator(ex.locator).WithResultType(SystemTypes.DecimalType);

            Expression toLong(Expression ex) => new ToLong
            {
                operand = ex,
            }.WithLocator(ex.locator).WithResultType(SystemTypes.LongType);

            var typeCount = elements
                .Select(e => e.resultTypeName)
                .Distinct()
                .Count();

            var listElementType = typeCount == 1
                ? elements[0].resultTypeSpecifier
                : SystemTypes.AnyType;

            var list = new List
            {
                element = elements,
            }.WithLocator(context.Locator()).WithResultType(listElementType.ToListType());

            return list;
        }

        //  '[' (contextIdentifier '->')? namedTypeSpecifier (':' (codePath codeComparator)? terminology)? ']'
        public override Expression VisitRetrieve([Antlr4.Runtime.Misc.NotNull] cqlParser.RetrieveContext context)
        {
            var contextName = context.contextIdentifier().GetText();
            var codePath = context.codePath().GetText();
            var codeComparator = context.codeComparator().GetText();
            var terminology = Visit(context.terminology());
            var type = (NamedTypeSpecifier)TypeSpecifierVisitor.Visit(context.namedTypeSpecifier());

            var contextExpressionRef = new ExpressionRef
            {
                name = contextName,
            };

            var retrieve = new Retrieve
            {
                dataType = type.name,
                templateId = ModelProvider.GetDefaultProfileUriForType(type),
                context = contextExpressionRef,
                codeComparator = codeComparator,
                codes = terminology,
                codeProperty = codePath,
            }.WithResultType(type.ToListType()).WithLocator(context.Locator());

            return retrieve;
        }

        protected Expression ErrorMessage(string message, string locator)
        {
            return new Message()
            {
                message = new Literal() { value = message }.WithResultType(SystemTypes.StringType),
                source = new Null().WithResultType(SystemTypes.AnyType)
            }
            .AddError(message)
            .WithLocator(locator)
            .WithResultType(SystemTypes.AnyType);
        }

        private enum ListElementPromotion
        {
            None,
            Integer,
            Long,
            Decimal,
            Quantity
        }
    }
}
