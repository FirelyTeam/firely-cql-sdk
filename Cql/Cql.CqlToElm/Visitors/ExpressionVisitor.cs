using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Linq;
using System.Reflection;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal partial class ExpressionVisitor : Visitor<Expression>
    {
        public ExpressionVisitor(IModelProvider provider,
            IOptions<CqlToElmOptions> options,
            LibraryBuilder libraryBuilder,
            TypeSpecifierVisitor typeSpecifierVisitor,
            LocalIdentifierProvider localIdentifierProvider,
            InvocationBuilder invocationBuilder,
            CoercionProvider coercionProvider,
            ElmFactory elmFactory,
            MessageProvider messageProvider) : base(localIdentifierProvider, invocationBuilder)
        {
            ModelProvider = provider;
            LibraryBuilder = libraryBuilder;
            TypeSpecifierVisitor = typeSpecifierVisitor;
            CoercionProvider = coercionProvider;
            ElmFactory = elmFactory;
            Messaging = messageProvider;
            Options = options.Value;
        }


        #region Privates
        private IModelProvider ModelProvider { get; }
        private CqlToElmOptions Options { get; }
        private TypeSpecifierVisitor TypeSpecifierVisitor { get; }
        private LibraryBuilder LibraryBuilder { get; }
        private CoercionProvider CoercionProvider { get; }
        private ElmFactory ElmFactory { get; }
        private MessageProvider Messaging { get; }
        #endregion

        // 'Interval' ('['|'(') expression ',' expression (']'|')')
        // TODO: make a system function & validate it
        // validation API would need access to config options
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

            // When enabled, allow Interval<Any> to be created for Interval[null, null].
            // This is normally disabled.
            if ((Options.AllowNullIntervals ?? false)
                && low is Null 
                && low.resultTypeSpecifier == SystemTypes.AnyType
                && high is Null
                && high.resultTypeSpecifier == SystemTypes.AnyType)
            {
                return new Interval { low = low, high = high, lowClosed = lowClosed, highClosed = highClosed }
                    .WithLocator(context.Locator())
                    .WithResultType(SystemTypes.AnyType.ToIntervalType());
            }

            var intervalSelector = InvocationBuilder.MatchSignature(SystemLibrary.Interval, 
                low, 
                high, 
                ElmFactory.Literal(lowClosed), ElmFactory.Literal(highClosed));

            if (intervalSelector.Compatible)
            {
                
                var interval = InvocationBuilder.Invoke(intervalSelector);
                // TODO: this should be incorporated in the validation framework
                // The validation framework is static and can't accept configuration options :(
                if (Options.ValidateIntervals ?? false)
                {
                    if (intervalSelector.Function.resultTypeSpecifier is IntervalTypeSpecifier intervalType)
                    {
                        var pointType = intervalType.pointType;
                        if (pointType.IsOrderedType())
                        {
                            if (low is Quantity lowQuantity && high is Quantity highQuantity
                                && !UnitsAreCompatible(lowQuantity.unit, highQuantity.unit))
                            {
                                interval.AddError($"Intervals of quantities must be of compatible units.");
                            }
                        }
                    }
                    else throw new InvalidOperationException($"Interval selector function's return type is not an interval."); // should only happen if SystemLibrary is broken
                }
                return interval
                    .WithLocator(context.Locator());
            }
            else
                return new Interval()
                    .AddError(Messaging.CouldNotResolveFunction("Interval", low.resultTypeSpecifier, high.resultTypeSpecifier))
                    .WithLocator(context.Locator())
                    .WithResultType(low.resultTypeSpecifier.ToIntervalType());
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
                return new List() { element = Array.Empty<Expression>(), }
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
                TypeSpecifier elementType = SystemTypes.AnyType;
                if (distinctTypes.Length == 1)
                {
                    elementType = distinctTypes[0];
                }
                else
                {
                    var numericTypes = distinctTypes
                        .OfType<NamedTypeSpecifier>()
                        .Where(NumericTypeSpecifierComparer.IsNumeric)
                        .ToArray();
                    if (numericTypes.Length > 0 && numericTypes.Length == distinctTypes.Length)
                    {
                        elementType = numericTypes.Max(NumericTypeSpecifierComparer.Default)!;
                    }
                }

                for (int i = 0; i < elements.Length; i++)
                {
                    var ei = elements[i];
                    var result = CoercionProvider.Coerce(ei, elementType);
                    if (result.Success)
                        typedElements[i] = result.Result;
                    else
                    {
                        typedElements[i] = ei.AddError($"Expected an expression of type '{elementType}', but found an expression of type '{ei.resultTypeSpecifier}'.");
                    }
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
            var contextName = context.contextIdentifier()?.GetText();
            var codePath = context.codePath()?.GetText();
            var codeComparator = context.codeComparator()?.GetText();
            var contextTerm = context.terminology();
            var terminology = contextTerm is null ? null : Visit(contextTerm);
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

        public override Expression VisitTerminology([Antlr4.Runtime.Misc.NotNull] cqlParser.TerminologyContext context)
        {
            var qie = context.qualifiedIdentifierExpression();
            var e = context.expression();
            if (e is not null)
                throw new NotImplementedException();
            return Visit(qie);
        }


        protected Expression ErrorMessage(string message, string locator)
        {
            return new Message()
            {
                message = ElmFactory.Literal(message),
                source = new Null().WithResultType(SystemTypes.AnyType)
            }
            .AddError(message)
            .WithLocator(locator)
            .WithResultType(SystemTypes.AnyType);
        }

        private Expression VisitBinaryWithPrecision(OverloadedFunctionDef systemFunction,
            Antlr4.Runtime.ParserRuleContext context,
            cqlParser.PluralDateTimePrecisionContext precisionContext,
            cqlParser.ExpressionTermContext[] expressionTerms)
        {
            var precision = Precision(precisionContext);
            var lhs = Visit(expressionTerms[0]);
            var rhs = Visit(expressionTerms[1]);

            var expression = precision switch
            {
                { } => InvocationBuilder.Invoke(systemFunction, lhs, rhs, precision),
                _ => InvocationBuilder.Invoke(systemFunction, lhs, rhs),
            };
            return expression
                .WithId()
                .WithLocator(context.Locator());
            ;
        }

        private Literal? Precision(cqlParser.PluralDateTimePrecisionContext context)
        {
            if (context is null)
                return null;
            else
            {
                var name = Enum.GetName(context.Parse());
                if (name is null)
                    return null;
                else return ElmFactory.Literal(name);
            }
        }
        private Literal? Precision(cqlParser.DateTimePrecisionSpecifierContext context)
        {
            var dtp = context?.dateTimePrecision();
            if (dtp is null)
                return null;
            else
            {
                var name = Enum.GetName(dtp.Parse());
                if (name is null)
                    return null;
                else return ElmFactory.Literal(name);
            }
        }

        private Literal? Precision(cqlParser.DateTimeComponentContext context)
        {
            var dtp = context?.dateTimePrecision();
            if (dtp is null)
                return null;
            else
            {
                var name = Enum.GetName(dtp.Parse());
                if (name is null)
                    return null;
                else return ElmFactory.Literal(name);
            }
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
