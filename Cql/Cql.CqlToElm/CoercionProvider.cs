using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// Implements type conversion according to the rules defined by the specification. 
    /// </summary>
    /// <seealso href="https://cql.hl7.org/03-developersguide.html#conversion-precedence"/>
    internal class CoercionProvider
    {
        public CoercionProvider(IModelProvider modelProvider, IOptions<CqlToElmOptions> options)
        {
            ModelProvider = modelProvider;
            Options = options.Value;
        }

        private IModelProvider ModelProvider { get; }
        private CqlToElmOptions Options { get; }


        public CoercionResult<Expression> Coerce(Expression expression, TypeSpecifier to)
        {
            // Checking the cost also determines the kind of conversion, if any, we can do.
            var cost = GetCoercionCost(expression.resultTypeSpecifier, to);
            // Next we apply the conversion.  
            return cost switch
            {
                CoercionCost.ExactMatch => new(expression, cost),
                // Usually, it is a non-strict As, which has the effect of retyping the expression.
                CoercionCost.Subtype => new(As(expression, to), cost),
                CoercionCost.Compatible => new(As(expression, to), cost),
                CoercionCost.Cast => new(As(expression, to), cost),
                CoercionCost.ImplicitToSimpleType => new(ImplicitCastToSimple(expression, to), cost),
                CoercionCost.ImplicitToClassType => new(ImplicitCastToClass(expression, to), cost),
                // For promotions and demotions, it involves constructing other expressions.
                CoercionCost.IntervalPromotion when to is IntervalTypeSpecifier toInterval => new(ToInterval(expression, toInterval), cost),
                CoercionCost.ListDemotion => new(FromList(expression, to), cost),
                CoercionCost.IntervalDemotion => new(FromInterval(expression, to), cost),
                CoercionCost.ListPromotion when to is ListTypeSpecifier toList => new(ToList(expression, toList), cost),
                // For incompatible conversions, the expression remains unchanged.
                CoercionCost.Incompatible => new(expression, cost),
                _ => throw new InvalidOperationException($"Unexpected cost: {Enum.GetName(cost)}")
            };

            // These are the conversions.
            Expression As(Expression expression, TypeSpecifier type)
            {
                if (expression.resultTypeSpecifier == type)
                    return expression;
                else return new As
                {
                    operand = expression,
                    asTypeSpecifier = type,
                    asType = type is NamedTypeSpecifier nts ? nts.name : null,
                    locator = expression.locator,
                }.WithResultType(type);
            }

            Expression ImplicitCastToSimple(Expression expression, TypeSpecifier type)
            {
                Expression convert;
                if (type == SystemTypes.BooleanType)
                    convert = new ToBoolean { operand = expression };
                else if (type == SystemTypes.IntegerType)
                    convert = new ToInteger { operand = expression };
                else if (type == SystemTypes.LongType)
                    convert = new ToLong { operand = expression };
                else if (type == SystemTypes.DecimalType)
                    convert = new ToDecimal { operand = expression };
                else if (type == SystemTypes.StringType)
                    convert = new ToString { operand = expression };
                else
                    convert = new As
                    {
                        operand = expression,
                        asTypeSpecifier = type,
                        asType = type is NamedTypeSpecifier nts ? nts.name : null
                    };
                return convert
                    .WithLocator(expression.locator)
                    .WithResultType(type);
            }

            Expression ImplicitCastToClass(Expression expression, TypeSpecifier to)
            {
                Expression convert;
                if (to == SystemTypes.QuantityType)
                    convert = new ToQuantity { operand = expression };
                else if (to == SystemTypes.DateType)
                    convert = new ToDate { operand = expression };
                else if (to == SystemTypes.DateTimeType)
                    convert = new ToDateTime { operand = expression };
                else if (to == SystemTypes.TimeType)
                    convert = new ToTime { operand = expression };
                else if (to == SystemTypes.ConceptType)
                    convert = new ToConcept { operand = expression };
                else if (to == SystemTypes.RatioType)
                    convert = new ToRatio { operand = expression };
                else
                {
                    var fr = FunctionRefForModelConversion(expression.resultTypeSpecifier, to);
                    if (fr is not null)
                    {
                        fr.operand = new[] { expression };
                        fr.WithResultType(to);
                        return fr;
                    }
                    else
                    {
                        convert = new As
                        {
                            operand = expression,
                            asTypeSpecifier = to,
                            asType = to is NamedTypeSpecifier nts ? nts.name : null
                        };
                    }
                }
                return convert
                    .WithLocator(expression.locator)
                    .WithResultType(to);
            }


            Interval ToInterval(Expression expression, IntervalTypeSpecifier type) =>
                new Interval { low = As(expression, type.pointType), high = As(expression, type.pointType), highClosed = true, lowClosed = true }.WithResultType(type);

            Expression FromList(Expression list, TypeSpecifier to) =>
                As(new SingletonFrom { operand = list }.WithResultType(to), to);

            Expression FromInterval(Expression interval, TypeSpecifier to) =>
                As(new Start { operand = interval }.WithResultType(to), to);

            Expression ToList(Expression expression, ListTypeSpecifier to) =>
                new ToList { operand = As(expression, to.elementType) }.WithResultType(to);
        }

        /// <summary>
        /// Computes the cost of conversion according to the specification's conversion precendence rules.
        /// </summary>
        /// <seealso href="https://cql.hl7.org/03-developersguide.html#conversion-precedence"/>
        public CoercionCost GetCoercionCost(TypeSpecifier fromType, TypeSpecifier to)
        {
            if (IsExactMatch(fromType, to))
                return CoercionCost.ExactMatch;
            // Do not coerce to an invalid interval type - comes before subtype because every interval type
            // is a subtype of Interval<Any>, which is not a valid interval type.
            else if (to is IntervalTypeSpecifier toInterval && !IsValidIntervalType(toInterval))
                return CoercionCost.Incompatible;
            else if (IsSubtype(fromType, to))
                return CoercionCost.Subtype;
            else if (IsCompatible(fromType, to))
                return CoercionCost.Compatible;
            else if (CanBeCast(fromType, to))
                return CoercionCost.Cast;
            else if (HasImplicitConversion(fromType, to))
            {
                if (IsSimpleType(to))
                    return CoercionCost.ImplicitToSimpleType;
                else if (IsClassType(to))
                    return CoercionCost.ImplicitToClassType;
                else return CoercionCost.Incompatible;
            }
            else if ((Options.EnableIntervalPromotion ?? false)
                && to is IntervalTypeSpecifier promotableInterval
                && CanBePromoted(fromType, promotableInterval))
                return CoercionCost.IntervalPromotion;
            else if ((Options.EnableListDemotion ?? false)
                && fromType is ListTypeSpecifier listType && CanBeDemoted(listType, to))
                return CoercionCost.ListDemotion;
            else if ((Options.EnableIntervalDemotion ?? false)
                && fromType is IntervalTypeSpecifier demotableInterval && CanBeDemoted(demotableInterval, to))
                return CoercionCost.IntervalDemotion;
            else if ((Options.EnableListPromotion ?? false)
                && to is ListTypeSpecifier promotableListType && CanBePromoted(fromType, promotableListType))
                return CoercionCost.ListPromotion;
            else
                return CoercionCost.Incompatible;
        }

        // All types exactly match Any
        internal bool IsExactMatch(TypeSpecifier from, TypeSpecifier to) =>
            from == to;

        internal bool IsSubtype(TypeSpecifier from, TypeSpecifier to) =>
            from.IsSubtypeOf(to, ModelProvider);

        // The spec language is:
        // If the invocation type is compatible with the declared type of the argument (e.g., the invocation type is Any)
        // Update: per Bryn, this conversion is specifically to allow the null keyword to be passed to functions without casting.
        internal bool IsCompatible(TypeSpecifier from, TypeSpecifier to) =>
            from == SystemTypes.AnyType;

        internal bool CanBeCast(TypeSpecifier from, TypeSpecifier to)
        {
            // Casting is the operation of treating a value of some base type as a more specific type at run-time. 
            if (IsSubtype(to, from))
                return true;
            else if (from is ChoiceTypeSpecifier fromChoice)
            {
                if (to is ChoiceTypeSpecifier toChoice)
                    return fromChoice.choice?.Any(ft => toChoice.choice?.Any(tt => CanBeCast(ft, tt)) ?? false) ?? false;
                else
                    return fromChoice.choice?.Any(ft => CanBeCast(ft, to)) ?? false;
            }
            else if (to is ChoiceTypeSpecifier toChoice)
            {
                return toChoice.choice?.Any(tt => CanBeCast(from, tt)) ?? false;
            }
            else if (from is ListTypeSpecifier fromList && to is ListTypeSpecifier toList)
                return CanBeCast(fromList.elementType, toList.elementType);
            else if (from is IntervalTypeSpecifier fromInterval && to is IntervalTypeSpecifier toInterval)
                return CanBeCast(fromInterval.pointType, toInterval.pointType);
            else return false;
        }

        // Implicit conversions table is here:
        // https://cql.hl7.org/09-b-cqlreference.html#convert
        internal bool HasImplicitConversion(TypeSpecifier from, TypeSpecifier to)
        {
            if (from is ChoiceTypeSpecifier fromChoice)
            {
                if (to is ChoiceTypeSpecifier toChoice)
                    return fromChoice.choice?.Any(ft => toChoice.choice?.Any(tt => HasImplicitConversion(ft, tt)) ?? false) ?? false;
                else
                    return fromChoice.choice?.Any(ft => HasImplicitConversion(ft, to)) ?? false;
            }
            else if (to is ChoiceTypeSpecifier toChoice)
            {
                return toChoice.choice?.Any(tt => HasImplicitConversion(from, tt)) ?? false;
            }
            else if (from == SystemTypes.IntegerType
                && (to == SystemTypes.LongType || to == SystemTypes.DecimalType || to == SystemTypes.QuantityType))
                return true;
            else if (from == SystemTypes.LongType
                && (to == SystemTypes.DecimalType || to == SystemTypes.QuantityType))
                return true;
            else if (from == SystemTypes.DecimalType
                && to == SystemTypes.QuantityType)
                return true;
            else if (from == SystemTypes.DateType
                && to == SystemTypes.DateTimeType)
                return true;
            else if (from == SystemTypes.CodeType
                && to == SystemTypes.ConceptType)
                return true;
            // Tuple types are compatible if:
            // * every element in from exists in to
            // * every element in to exists in from
            // * every element in from is implicitly convertible to the element in to
            else if (from is TupleTypeSpecifier fromTuple
                && to is TupleTypeSpecifier toTupleType)
            {
                if (fromTuple.element?.Length != toTupleType.element?.Length)
                    return false;
                for (int i = 0; i < fromTuple.element?.Length; i++)
                {
                    var fromElement = fromTuple.element[i];
                    var fromElementType = fromElement.elementType;
                    var found = false;
                    for (int j = 0; j < toTupleType.element?.Length; j++)
                    {
                        var toElement = toTupleType.element[j];
                        var toElementType = toElement.elementType;
                        if (fromElement.name == toElement.name)
                        {
                            // written for easier debugging
                            if (IsExactMatch(fromElementType, toElementType))
                                return true;
                            else if (IsSubtype(fromElementType, toElementType))
                                return true;
                            else if (CanBeCast(fromElementType, toElementType))
                                return true;
                            else if (HasImplicitConversion(fromElementType, toElementType))
                                return true;
                        }
                    }
                    if (!found)
                        return false;
                }
            }
            else if (HasImplicitConversionThroughModel(from, to))
                return true;
            return false;
        }

        internal bool IsSimpleType(TypeSpecifier typeSpecifier)
        {
            if (typeSpecifier is NamedTypeSpecifier fromNts)
            {
                var typeInfo = ModelProvider.FindTypeInfoByNamedType(fromNts);
                return typeInfo.Type is Model.SimpleTypeInfo;
            }
            return false;
        }

        internal bool IsClassType(TypeSpecifier typeSpecifier)
        {
            if (typeSpecifier is IntervalTypeSpecifier || typeSpecifier is ListTypeSpecifier)
                return true;
            if (typeSpecifier is NamedTypeSpecifier fromNts)
            {
                var typeInfo = ModelProvider.FindTypeInfoByNamedType(fromNts);
                return typeInfo.Type is Model.ClassInfo;
            }
            return false;
        }

        // The declared type is an interval and the invocation type can be promoted to an interval of that type
        // Presumably 
        internal bool CanBePromoted(TypeSpecifier from, IntervalTypeSpecifier to) =>
            GetCoercionCost(from, to.pointType) != CoercionCost.Incompatible;

        internal bool CanBeDemoted(ListTypeSpecifier from, TypeSpecifier to) =>
            GetCoercionCost(from.elementType, to) != CoercionCost.Incompatible;

        // The invocation type of the argument is an interval and can be demoted to the declared type
        // Note that whether an interval is a point interval or not cannot be known at compile time.
        // This type of conversion will issue a warning and could fail at runtime.
        internal bool CanBeDemoted(IntervalTypeSpecifier from, TypeSpecifier to) =>
            GetCoercionCost(from.pointType, to) != CoercionCost.Incompatible;

        // The declared type is a list and the invocation type can be promoted to a list of that type
        internal bool CanBePromoted(TypeSpecifier from, ListTypeSpecifier to) =>
            GetCoercionCost(from, to.elementType) != CoercionCost.Incompatible;

        internal bool CanBeExplicitlyCast(TypeSpecifier from, TypeSpecifier to) =>
            IsSubtype(from, to) || CanBeCast(from, to);

        internal bool IsValidIntervalType(IntervalTypeSpecifier typeSpecifier) =>
            SystemTypes.IntervalPointTypes.Contains(typeSpecifier.pointType);

        internal bool HasConversionToIntervalThroughModel(TypeSpecifier type, [NotNullWhen(true)] out TypeSpecifier? intervalPointType)
        {
            if (type is NamedTypeSpecifier fromNts)
            {
                if (ModelProvider.TryMakeQualifiedNameFromType(fromNts, out var fromQualified)
                    && ModelProvider.TryGetConversionFunctions(fromQualified!, out var tuples))
                {
                    for (int i = 0; i < tuples!.Length; i++)
                    {
                        var tuple = tuples[i];
                        var to = tuple.To.Trim();
                        if (to.StartsWith("Interval<"))
                        {
                            var pointTypeName = to[9..^1];
                            var typeName = ModelProvider.TryGetUrlPrefixedName(pointTypeName);
                            intervalPointType = new NamedTypeSpecifier { name = new System.Xml.XmlQualifiedName(typeName) };
                            return true;
                        }
                    }
                }
            }
            intervalPointType = null;
            return false;
        }

        internal bool HasImplicitConversionThroughModel(TypeSpecifier from, TypeSpecifier to) =>
            FunctionRefForModelConversion(from, to) is not null;

        private FunctionRef? FunctionRefForModelConversion(TypeSpecifier from, TypeSpecifier to)
        {
            var fromValue = typeString(from);
            var toValue = typeString(to);
            if (fromValue is not null && toValue is not null)
            {
                if (ModelProvider.TryGetConversionFunctionName(fromValue, toValue, out var qualifiedFunctionName))
                {
                    var lastDot = qualifiedFunctionName!.LastIndexOf('.');
                    if (lastDot >= 0)
                    {
                        var libraryName = qualifiedFunctionName[..lastDot];
                        var functionName = qualifiedFunctionName[(lastDot + 1)..];
                        var @ref = new FunctionRef
                        {
                            libraryName = libraryName,
                            name = functionName,
                        };
                        return @ref;
                    }
                }
            }
            return null;
            string? typeString(TypeSpecifier type) =>
                type switch
                {
                    NamedTypeSpecifier nts when ModelProvider.TryMakeQualifiedNameFromType(nts, out var fromQualified) => fromQualified,
                    IntervalTypeSpecifier interval => $"Interval<{typeString(interval.pointType)}>",
                    ListTypeSpecifier list => $"List<{typeString(list.elementType)}>",
                    _ => null
                };
        }


    }
}
