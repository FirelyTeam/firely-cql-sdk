using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Reflection;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal partial class ExpressionVisitor : Visitor<Expression>
    {
        public ExpressionVisitor(IModelProvider provider,
            IConfiguration configuration,
            ConverterContext converterContext,
            LibraryBuilder libraryBuilder,
            TypeSpecifierVisitor typeSpecifierVisitor,
            LocalIdentifierProvider localIdentifierProvider,
            InvocationBuilder invocationBuilder) : base(localIdentifierProvider, invocationBuilder)
        {
            ModelProvider = provider;
            Configuration = configuration;
            ConverterContext = converterContext;
            LibraryBuilder = libraryBuilder;
            TypeSpecifierVisitor = typeSpecifierVisitor;
        }


        #region Privates
        private readonly IModelProvider ModelProvider;
        private readonly TypeSpecifierVisitor TypeSpecifierVisitor;

        public IConfiguration Configuration { get; }
        public ConverterContext ConverterContext { get; }
        public LibraryBuilder LibraryBuilder { get; }
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
            var lowType = low.resultTypeSpecifier;
            var highType = high.resultTypeSpecifier;

            TypeSpecifier pointType = SystemTypes.AnyType;
            if (lowType.IsNumericType() && highType.IsNumericType())
                pointType = new[] { lowType, highType }.Max(NumericTypeSpecifierComparer.Default)!;
            else
            {
                if ((low is Null || lowType == SystemTypes.AnyType) 
                    && (high is not Null && highType != SystemTypes.AnyType))
                    pointType = highType;
                else pointType = lowType;
            }

            var lowCast = InvocationBuilder.BuildImplicitCast(low, pointType, out var _l);
            var highCast = InvocationBuilder.BuildImplicitCast(high, pointType, out var _h);

            if (!lowCast.Success && lowCast.Error is not null)
                low.AddError(lowCast.Error ?? $"Could not convert low interval value to {pointType}");
            else low = lowCast.Result;
            if (!highCast.Success && highCast.Error is not null)
                high.AddError(highCast.Error ?? $"Could not convert high interval value to {pointType}");
            else high = highCast.Result;

            var interval = new Interval
            {
                high = high,
                low = low,
                highClosed = highClosed,
                lowClosed = lowClosed,
            }
            .WithLocator(context.Locator())
            .WithResultType(pointType.ToIntervalType());

            var validate = Option(o => o.ValidateIntervals);
            if (validate)
            {
                if (pointType.IsValidOrderedType())
                {
                    if (low is Quantity lowQuantity && high is Quantity highQuantity
                        && !UnitsAreCompatible(lowQuantity.unit, highQuantity.unit))
                    {
                        interval.AddError($"Intervals of quantities must be of compatible units.");
                    }
                }
                else if (low is not Null || high is not Null) // the Interval(null,null) case is handled separately below.
                {
                    interval.AddError($"Intervals can only be constructed for orderable types ({string.Join(", ", SystemTypes.ValidOrderedTypes)}). Type {pointType} is not allowed.");
                }
            }
            var allowNullIntervals = Option(o => o.AllowNullIntervals);
            if (!allowNullIntervals && low is Null && high is Null)
            {
                interval.AddError($"Intervals whose low and high values are null are not allowed.");
            }

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

        public T Option<T>(System.Linq.Expressions.Expression<Func<CqlToElmOptions, T>> propertyExpression)
            where T : IConvertible
        {
            string key;
            if (propertyExpression.Body is System.Linq.Expressions.MemberExpression me)
                key = me.Member.Name;
            else throw new ArgumentException($"Lambda body is not a MemberExpression", nameof(propertyExpression));
            var value = Configuration[key];
            if (value is null)
            {
                if (me.Member is PropertyInfo property)
                    return (T)property.GetValue(CqlToElmOptions.Default)!;
                else if (me.Member is FieldInfo field)
                    return (T)field.GetValue(CqlToElmOptions.Default)!;
                else throw new ArgumentException($"Member {key} is neither a field nor a property.", nameof(propertyExpression));
            }
            var t = (T)System.Convert.ChangeType(value, typeof(T), System.Globalization.CultureInfo.InvariantCulture);
            return t;
        }
        public T Option<T>(System.Linq.Expressions.Expression<Func<CqlToElmOptions, T?>> propertyExpression)
            where T : struct, IConvertible
        {
            string key;
            if (propertyExpression.Body is System.Linq.Expressions.MemberExpression me)
                key = me.Member.Name;
            else throw new ArgumentException($"Lambda body is not a MemberExpression", nameof(propertyExpression));
            var value = Configuration[key];
            if (value is null)
            {
                if (me.Member is PropertyInfo property)
                    return (T)property.GetValue(CqlToElmOptions.Default)!;
                else if (me.Member is FieldInfo field)
                    return (T)field.GetValue(CqlToElmOptions.Default)!;
                else throw new ArgumentException($"Member {key} is neither a field nor a property.", nameof(propertyExpression));
            }
            var t = (T)System.Convert.ChangeType(value, typeof(T), System.Globalization.CultureInfo.InvariantCulture);
            return t;
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
