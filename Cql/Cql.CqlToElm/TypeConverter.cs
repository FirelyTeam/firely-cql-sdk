using Hl7.Cql.Elm;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
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
    internal class TypeConverter
    {
        public TypeConverter(IModelProvider modelProvider, IOptions<CqlToElmOptions> options)
        {
            ModelProvider = modelProvider;
            Options = options.Value;
        }

        public IModelProvider ModelProvider { get; }
        public CqlToElmOptions Options { get; }

        public ConversionResult<Expression> Convert(Expression expression, TypeSpecifier to)
        {
            var cost = GetConversionCost(expression.resultTypeSpecifier, to);
            if (cost == ConversionCost.Incompatible)
                return new(expression, cost, IncompatibilityMessage(expression.resultTypeSpecifier, to));
            else
                return new(expression, cost);
        }

        public ConversionCost GetConversionCost(TypeSpecifier from, TypeSpecifier to)
        {
            if (IsExactMatch(from, to))
                return ConversionCost.ExactMatch;
            else if (IsSubtype(from, to))
                return ConversionCost.Subtype;
            else if (IsCompatible(from, to))
                return ConversionCost.Compatible;
            else if (CanBeCast(from, to))
                return ConversionCost.Cast;
            else if (HasImplicitConversion(from, to))
            {
                if (IsSimpleType(to))
                    return ConversionCost.ImplicitToSimpleType;
                else if (IsClassType(to))
                    return ConversionCost.ImplicitToClassType;
                else return ConversionCost.Incompatible;
            }
            else if ((Options.EnableIntervalPromotion ?? false)
                && to is IntervalTypeSpecifier promotableInterval
                && CanBePromoted(from, promotableInterval))
                return ConversionCost.IntervalPromotion;
            else if ((Options.EnableListDemotion ?? false)
                && from is ListTypeSpecifier listType && CanBeDemoted(listType, to))
                return ConversionCost.ListDemotion;
            else if ((Options.EnableIntervalDemotion ?? false)
                && from is IntervalTypeSpecifier demotableInterval && CanBeDemoted(demotableInterval, to))
                return ConversionCost.IntervalDemotion;
            else if ((Options.EnableListPromotion ?? false)
                && to is ListTypeSpecifier promotableListType && CanBePromoted(from, promotableListType))
                return ConversionCost.ListPromotion;
            else
                return ConversionCost.Incompatible;
        }

        internal string IncompatibilityMessage(TypeSpecifier from, TypeSpecifier to) => 
            $"Expression of type '{from}' cannot be cast as a value of type '{to}'.";

        internal virtual bool IsExactMatch(TypeSpecifier argumentType, TypeSpecifier to) => argumentType == to;

        internal virtual bool IsSubtype(TypeSpecifier argumentType, TypeSpecifier to)
        {
            if (argumentType is NamedTypeSpecifier argNts && to is NamedTypeSpecifier toNts)
            {
                var argTypeInfo = ModelProvider.FindTypeInfoByNamedType(argNts);
                var toTypeInfo = ModelProvider.FindTypeInfoByNamedType(toNts);
                var toModel = toTypeInfo.Model;
                var baseType = argTypeInfo.Type.baseType;
                while (baseType != null)
                {
                    var parts = baseType.Split(".");
                    if (parts.Length > 1)
                    {
                        if (ModelProvider.TryGetModelFromName(parts[0], out var baseModel))
                        {
                            var baseTypeInfo = baseModel.FindTypeInfo(baseType);
                            if (baseTypeInfo != null)
                            {
                                if (toModel.url == baseModel.url
                                    && toTypeInfo.Type.Name() == baseTypeInfo.Name())
                                    return true;
                                else baseType = baseTypeInfo.baseType;
                            }
                            else baseType = null;
                        }
                        else baseType = null;
                    }
                }
            }
            return false;
        }

        // The spec language is:
        // If the invocation type is compatible with the declared type of the argument (e.g., the invocation type is Any)
        internal virtual bool IsCompatible(TypeSpecifier from, TypeSpecifier to)
        {
            if (from == SystemTypes.AnyType)
                return true;
            if (from is ChoiceTypeSpecifier fromChoice)
            {
                if (to is ChoiceTypeSpecifier toChoice)
                    return fromChoice.choice?.Any(ft => toChoice.choice?.Contains(ft) ?? false) ?? false;
                else fromChoice.choice?.Any(ft => ft == to);
            }
            else if (to is ChoiceTypeSpecifier toChoice)
            {
                return toChoice.choice?.Any(tt => tt == from) ?? false;
            }
            return false;
        }

        internal virtual bool CanBeCast(TypeSpecifier from, TypeSpecifier to)
        {
            // Casting is the operation of treating a value of some base type as a more specific type at run-time. 
            if (IsSubtype(to, from))
                return true;
            else return false;
        }

        // Implicit conversions table is here:
        // https://cql.hl7.org/09-b-cqlreference.html#convert
        internal virtual bool HasImplicitConversion(TypeSpecifier fromType, TypeSpecifier to)
        {

            if (fromType == SystemTypes.IntegerType
                && (to == SystemTypes.LongType || to == SystemTypes.DecimalType || to == SystemTypes.QuantityType))
                return true;
            else if (fromType == SystemTypes.LongType
                && (to == SystemTypes.DecimalType || to == SystemTypes.QuantityType))
                return true;
            else if (fromType == SystemTypes.DecimalType
                && to == SystemTypes.QuantityType)
                return true;
            else if (fromType == SystemTypes.DateType
                && to == SystemTypes.DateTimeType)
                return true;
            else if (fromType == SystemTypes.CodeType
                && to == SystemTypes.ConceptType)
                return true;
            // Tuple types are compatible if:
            // * every element in from exists in to
            // * every element in to exists in from
            // * every element in from is implicitly convertible to the element in to
            else if (fromType is TupleTypeSpecifier fromTuple
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
                            else if (IsCompatible(fromElementType, toElementType))
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
            return false;
        }

        internal virtual bool IsSimpleType(TypeSpecifier typeSpecifier)
        {
            if (typeSpecifier is NamedTypeSpecifier fromNts)
            {
                var typeInfo = ModelProvider.FindTypeInfoByNamedType(fromNts);
                return typeInfo.Type is Model.SimpleTypeInfo;
            }
            return false;
        }

        internal virtual bool IsClassType(TypeSpecifier typeSpecifier)
        {
            if (typeSpecifier is NamedTypeSpecifier fromNts)
            {
                var typeInfo = ModelProvider.FindTypeInfoByNamedType(fromNts);
                return typeInfo.Type is Model.ClassInfo;
            }
            return false;
        }

        // The declared type is an interval and the invocation type can be promoted to an interval of that type
        // Presumably 
        internal virtual bool CanBePromoted(TypeSpecifier from, IntervalTypeSpecifier to) 
        {
            var pointType = to.pointType;
            // written this way for easier debugging
            if (IsExactMatch(from, pointType))
                return true;
            else if (IsSubtype(from, pointType))
                return true;
            else if (IsCompatible(from, pointType))
                return true;
            else if (CanBeCast(from, pointType))
                return true;
            else if (HasImplicitConversion(from, pointType))
                return true;
            else return false;
        }

        internal virtual bool CanBeDemoted(ListTypeSpecifier expressionType, TypeSpecifier to)
        {
            var elementType = expressionType.elementType;
            // written this way for easier debugging
            if (IsExactMatch(elementType, to))
                return true;
            else if (IsSubtype(elementType, to))
                return true;
            else if (IsCompatible(elementType, to))
                return true;
            else if (CanBeCast(elementType, to))
                return true;
            else if (HasImplicitConversion(expressionType, to))
                return true;
            else return false;
        }

        // The invocation type of the argument is an interval and can be demoted to the declared type
        // Note that whether an interval is a point interval or not cannot be known at compile time.
        // This type of conversion will issue a warning and could fail at runtime.
        internal virtual bool CanBeDemoted(IntervalTypeSpecifier from, TypeSpecifier to)
        {
            var pointType = from.pointType;
            // written this way for easier debugging
            if (IsExactMatch(pointType, to))
                return true;
            else if (IsSubtype(pointType, to))
                return true;
            else if (IsCompatible(pointType, to))
                return true;
            else if (CanBeCast(pointType, to))
                return true;
            else if (HasImplicitConversion(from, pointType))
                return true;
            else return false;
        }

        // The declared type is a list and the invocation type can be promoted to a list of that type
        internal virtual bool CanBePromoted(TypeSpecifier from, ListTypeSpecifier to)
        {
            var elementType = to.elementType;
            // written this way for easier debugging
            if (IsExactMatch(from, elementType))
                return true;
            else if (IsSubtype(from, elementType))
                return true;
            else if (IsCompatible(from, elementType))
                return true;
            else if (CanBeCast(from, elementType))
                return true;
            else if (HasImplicitConversion(from, elementType))
                return true;
            else return false;
        }
    }

}
