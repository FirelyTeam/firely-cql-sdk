using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal partial class ExpressionVisitor : Visitor<Expression>
    {
        public ExpressionVisitor(IModelProvider provider,
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
            var elements = context
                .expression()
                .Select(Visit)
                .ToArray();
            if (elements.Length == 0)
                return new List()
                    .WithLocator(context.Locator())
                    .WithResultType((typeSpecifier ?? SystemTypes.AnyType).ToListType());
            else
            {
                var nonNullElements = elements
                    .Except(elements
                        .OfType<Null>()
                        .Where(@null => @null.resultTypeSpecifier == SystemTypes.AnyType))
                    .ToArray();
                var distinctTypes = nonNullElements
                    .Select(ele => ele.resultTypeSpecifier)
                    .Distinct()
                    .ToArray();
                var typedElements = new Expression[elements.Length];
                TypeSpecifier elementType;
                if (distinctTypes.Length == 1)
                {
                    elementType = distinctTypes[0];
                }
                else if (distinctTypes.All(NumericTypeSpecifierComparer.IsNumeric))
                {
                    elementType = distinctTypes.Max()!;
                }
                else
                {
                    Array.Copy(elements, typedElements, elements.Length);
                    elementType = SystemTypes.AnyType;
                }

                for (int i = 0; i < elements.Length; i++)
                {
                    var ei = elements[i];
                    var result = InvocationBuilder.BuildImplicitCast(ei, elementType, out var _);
                    if (result.Success)
                        typedElements[i] = result.Result;
                    else if (!string.IsNullOrWhiteSpace(result.Error))
                        typedElements[i] = ei.AddError(result.Error);
                }

                return new List
                {
                    element = typedElements,
                }
                .WithLocator(context.Locator())
                .WithResultType(elementType.ToListType());
            }

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
