/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using Hl7.Cql.Abstractions;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using System.Reflection;

namespace Hl7.Cql.Packaging
{
    /// <summary>
    /// Defines the type mapping between Cql, ELM, and FHIR types
    /// </summary>
    public class CqlTypeToFhirTypeMapper
    {
        internal TypeResolver TypeResolver { get; private set; }
        internal ModelInspector ModelInspector { get; private set; }

        /// <summary>
        /// Creates a new instance with the specified type resovler and the default model inspector
        /// </summary>
        /// <param name="typeResolver">the type resolver</param>
        public CqlTypeToFhirTypeMapper(TypeResolver typeResolver) : this(typeResolver, ModelInfo.ModelInspector)
        {
        }

        /// <summary>
        /// Creates a new instance with the specified type resovler
        /// </summary>
        /// <param name="typeResolver">the type resolver</param>
        /// <param name="modelInspector">the model inspector</param>
        public CqlTypeToFhirTypeMapper(TypeResolver typeResolver, ModelInspector modelInspector)
        {
            TypeResolver = typeResolver;
            ModelInspector = modelInspector;
        }

        /// <summary>
        /// Given a static FHIR type, returns the corresponding Type mapping (if any)
        /// </summary>
        /// <param name="fhirType">the static FHIR type</param>
        /// <returns>the Type mapping, or null</returns>
        public CqlTypeToFhirMapping? TypeEntryFor(FHIRAllTypes fhirType)
        {
            switch (fhirType)
            {
                case FHIRAllTypes.Age:
                case FHIRAllTypes.Count:
                case FHIRAllTypes.Distance:
                case FHIRAllTypes.Duration:
                case FHIRAllTypes.Money:
                case FHIRAllTypes.Quantity:
                case FHIRAllTypes.SimpleQuantity:
                    return new CqlTypeToFhirMapping(fhirType, CqlPrimitiveType.Quantity);
                case FHIRAllTypes.Any:
                    return new CqlTypeToFhirMapping(fhirType, CqlPrimitiveType.Any);
                case FHIRAllTypes.String:
                case FHIRAllTypes.Base64Binary:
                case FHIRAllTypes.Id:
                case FHIRAllTypes.Markdown:
                case FHIRAllTypes.Oid:
                case FHIRAllTypes.Uri:
                case FHIRAllTypes.Uuid:
                case FHIRAllTypes.Xhtml:
                    return new CqlTypeToFhirMapping(fhirType, CqlPrimitiveType.String);
                case FHIRAllTypes.Boolean:
                    return new CqlTypeToFhirMapping(fhirType, CqlPrimitiveType.Boolean);
                case FHIRAllTypes.Code:
                case FHIRAllTypes.Coding:
                    return new CqlTypeToFhirMapping(fhirType, CqlPrimitiveType.Code);
                case FHIRAllTypes.CodeableConcept:
                    return new CqlTypeToFhirMapping(fhirType, CqlPrimitiveType.Concept);
                case FHIRAllTypes.CodeSystem:
                    return new CqlTypeToFhirMapping(fhirType, CqlPrimitiveType.CodeSystem);
                case FHIRAllTypes.Date:
                    return new CqlTypeToFhirMapping(fhirType, CqlPrimitiveType.Date);
                case FHIRAllTypes.DateTime:
                case FHIRAllTypes.Instant:
                    return new CqlTypeToFhirMapping(fhirType, CqlPrimitiveType.DateTime);
                case FHIRAllTypes.Time:
                    return new CqlTypeToFhirMapping(fhirType, CqlPrimitiveType.Time);
                case FHIRAllTypes.Decimal:
                    return new CqlTypeToFhirMapping(fhirType, CqlPrimitiveType.Decimal);
                case FHIRAllTypes.Integer:
                case FHIRAllTypes.UnsignedInt:
                case FHIRAllTypes.PositiveInt:
                    return new CqlTypeToFhirMapping(fhirType, CqlPrimitiveType.Integer);
                case FHIRAllTypes.Range:
                    return new CqlTypeToFhirMapping(fhirType, CqlPrimitiveType.Interval, new CqlTypeToFhirMapping(FHIRAllTypes.Quantity, CqlPrimitiveType.Quantity));
                case FHIRAllTypes.Ratio:
                    return new CqlTypeToFhirMapping(fhirType, CqlPrimitiveType.Interval, new CqlTypeToFhirMapping(FHIRAllTypes.Quantity, CqlPrimitiveType.Quantity));
                case FHIRAllTypes.List:
                    return new CqlTypeToFhirMapping(fhirType, CqlPrimitiveType.List, new CqlTypeToFhirMapping(FHIRAllTypes.Any, CqlPrimitiveType.Any));
                case FHIRAllTypes.Period:
                    return new CqlTypeToFhirMapping(fhirType, CqlPrimitiveType.Interval, new CqlTypeToFhirMapping(FHIRAllTypes.DateTime, CqlPrimitiveType.DateTime));
                default:
                    return new CqlTypeToFhirMapping(fhirType, CqlPrimitiveType.Fhir);
            }
        }

        /// <summary>
        /// Given a CQL type, returns the corresponding FHIR type (if any)
        /// </summary>
        /// <param name="cqlType">the base CQL type</param>
        /// <param name="elementType">an element CQL type, used if <paramref name="cqlType"/> is a collection</param>
        /// <returns>the corresponding Type mapping, or null</returns>
        /// <exception cref="ArgumentNullException">throws if <paramref name="cqlType"/> is a collection, but <paramref name="elementType"/> was not provided.</exception>
        public CqlTypeToFhirMapping? TypeEntryFor(CqlPrimitiveType cqlType, CqlTypeToFhirMapping? elementType = null)
        {
            switch (cqlType)
            {
                case CqlPrimitiveType.Any:
                    return new CqlTypeToFhirMapping(FHIRAllTypes.Any, cqlType);
                case CqlPrimitiveType.Boolean:
                    return new CqlTypeToFhirMapping(FHIRAllTypes.Boolean, cqlType);
                case CqlPrimitiveType.Code:
                    return new CqlTypeToFhirMapping(FHIRAllTypes.Code, cqlType);
                case CqlPrimitiveType.CodeSystem:
                    return new CqlTypeToFhirMapping(FHIRAllTypes.CodeSystem, cqlType);
                case CqlPrimitiveType.Concept:
                    return new CqlTypeToFhirMapping(FHIRAllTypes.CodeableConcept, cqlType);
                case CqlPrimitiveType.Date:
                    return new CqlTypeToFhirMapping(FHIRAllTypes.Date, cqlType);
                case CqlPrimitiveType.DateTime:
                    return new CqlTypeToFhirMapping(FHIRAllTypes.DateTime, cqlType);
                case CqlPrimitiveType.Decimal:
                    return new CqlTypeToFhirMapping(FHIRAllTypes.Decimal, cqlType);
                case CqlPrimitiveType.List:
                    if (elementType is null || elementType.CqlType is null)
                        throw new ArgumentNullException($"List types must specify an element type.", nameof(elementType));
                    return new CqlTypeToFhirMapping(FHIRAllTypes.List, cqlType, elementType);
                case CqlPrimitiveType.Integer:
                    return new CqlTypeToFhirMapping(FHIRAllTypes.Integer, cqlType);
                case CqlPrimitiveType.Interval:
                    if (elementType is null || elementType.CqlType is null)
                        throw new ArgumentNullException($"Interval types must specify an element (point) type.", nameof(elementType));
                    switch (elementType.CqlType)
                    {
                        case CqlPrimitiveType.Date:
                            return new CqlTypeToFhirMapping(FHIRAllTypes.Period, cqlType, TypeEntryFor(FHIRAllTypes.Date));
                        case CqlPrimitiveType.DateTime:
                            return new CqlTypeToFhirMapping(FHIRAllTypes.Period, cqlType, TypeEntryFor(FHIRAllTypes.DateTime));
                        case CqlPrimitiveType.Decimal:
                            return new CqlTypeToFhirMapping(FHIRAllTypes.Range, cqlType, TypeEntryFor(FHIRAllTypes.Decimal));
                        case CqlPrimitiveType.Integer:
                            return new CqlTypeToFhirMapping(FHIRAllTypes.Range, cqlType, TypeEntryFor(FHIRAllTypes.Integer));
                        case CqlPrimitiveType.Quantity:
                            return new CqlTypeToFhirMapping(FHIRAllTypes.Range, cqlType, TypeEntryFor(FHIRAllTypes.Quantity));
                        case CqlPrimitiveType.Ratio:
                            return new CqlTypeToFhirMapping(FHIRAllTypes.Ratio, cqlType);
                        case CqlPrimitiveType.Time:
                            return new CqlTypeToFhirMapping(FHIRAllTypes.Range, cqlType, TypeEntryFor(FHIRAllTypes.Duration));
                        case CqlPrimitiveType.Any:
                        case CqlPrimitiveType.Boolean:
                        case CqlPrimitiveType.Code:
                        case CqlPrimitiveType.CodeSystem:
                        case CqlPrimitiveType.Concept:
                        case CqlPrimitiveType.List:
                        case CqlPrimitiveType.Interval:
                        case CqlPrimitiveType.String:
                        case CqlPrimitiveType.ValueSet:
                        case CqlPrimitiveType.Vocabulary:
                        default:
                            return null;
                    }
                case CqlPrimitiveType.Quantity:
                    return new CqlTypeToFhirMapping(FHIRAllTypes.Quantity, cqlType);
                case CqlPrimitiveType.Ratio:
                    return new CqlTypeToFhirMapping(FHIRAllTypes.Ratio, cqlType);
                case CqlPrimitiveType.String:
                    return new CqlTypeToFhirMapping(FHIRAllTypes.String, cqlType);
                case CqlPrimitiveType.Time:
                    return new CqlTypeToFhirMapping(FHIRAllTypes.Time, cqlType);
                case CqlPrimitiveType.ValueSet:
                    return new CqlTypeToFhirMapping(FHIRAllTypes.ValueSet, cqlType);
                case CqlPrimitiveType.Tuple:
                    return new CqlTypeToFhirMapping(FHIRAllTypes.Basic, cqlType);
                case CqlPrimitiveType.Fhir:
                    return new CqlTypeToFhirMapping(FHIRAllTypes.Resource, cqlType);
                case CqlPrimitiveType.Vocabulary:
                default:
                    return null;
            }
        }

        /// <summary>
        /// Given a type, return the Type mapping (if any).
        /// </summary>
        /// <param name="type">the type</param>
        /// <returns>the Type mapping, or null</returns>
        public CqlTypeToFhirMapping? TypeEntryFor(Type type)
        {
            if (type.IsPrimitive || type.IsValueType || type == typeof(string))
            {
                var fhirType = PrimitiveToFhir(type);
                if (fhirType == null) return null;

                return TypeEntryFor(fhirType.Value);
            }

            var fhirTypeName = ModelInspector.GetFhirTypeNameForType(type);
            if (fhirTypeName is not null)
            {
                return TypeEntryFor($"{{http://hl7.org/fhir}}{fhirTypeName}");
            }
            var cqlPrimitiveAttribute = type.GetCustomAttribute<CqlPrimitiveTypeAttribute>(true);
            if (cqlPrimitiveAttribute is not null)
            {
                if (cqlPrimitiveAttribute.Type == CqlPrimitiveType.Interval)
                {
                    if (type.IsGenericType)
                    {
                        var gtd = type.GetGenericTypeDefinition();
                        if (gtd == typeof(CqlInterval<>))
                        {
                            var genericArg = type.GetGenericArguments().Single();
                            var pointType = TypeEntryFor(genericArg);
                            if (pointType is not null)
                            {
                                return TypeEntryFor(cqlPrimitiveAttribute.Type, pointType!);
                            }
                        }
                    }
                    return null;
                }
                return TypeEntryFor(cqlPrimitiveAttribute.Type);
            }
            if (IsOrImplementsIEnumerableOfT(type))
            {
                var elementType = TypeResolver.GetListElementType(type);
                if (elementType is null)
                    return null;
                var elementEntry = TypeEntryFor(elementType!);
                if (elementEntry is null)
                    return null;
                return TypeEntryFor(CqlPrimitiveType.List, elementEntry);
            }

            return null;
        }

        /// <summary>
        /// Given an ELM type specifier, returns the corresponding Type mapping
        /// </summary>
        /// <param name="resultTypeSpecifier">the ELM type</param>
        /// <returns>the Type mapping, if any</returns>
        public CqlTypeToFhirMapping? TypeEntryFor(Elm.TypeSpecifier? resultTypeSpecifier)
        {
            if (resultTypeSpecifier is null)
                return null;
            switch (resultTypeSpecifier)
            {
                case IntervalTypeSpecifier interval:
                    {
                        if (interval.pointType is null)
                            return null;
                        var pointType = TypeEntryFor(interval.pointType);
                        return TypeEntryFor(CqlPrimitiveType.Interval, pointType);
                    }
                case ListTypeSpecifier list:
                    if (list.elementType is null)
                        return null;
                    var elementType = TypeEntryFor(list.elementType);
                    if (elementType is null)
                        return null;
                    return TypeEntryFor(CqlPrimitiveType.List, elementType);
                case NamedTypeSpecifier named:
                    return TypeEntryFor(named.name.Name);
                case ChoiceTypeSpecifier:
                case TupleTypeSpecifier:
                    return new CqlTypeToFhirMapping(FHIRAllTypes.Basic, CqlPrimitiveType.Tuple);
                default:
                    break;
            }
            return null;
        }

        /// <summary>
        /// Given a type by name, reutrn the corresponding type info
        /// </summary>
        /// <param name="name">the name of the type</param>
        /// <returns>the type info</returns>
        public CqlTypeToFhirMapping? TypeEntryFor(string? name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                if (name.StartsWith("{urn:hl7-org:elm-types:r1}"))
                {
                    int prefixLength = "{urn:hl7-org:elm-types:r1}".Length;
                    var remainder = name.Substring(prefixLength);
                    if (Enum.TryParse<CqlPrimitiveType>(remainder, true, out var primitiveType))
                        return TypeEntryFor(primitiveType);
                    else
                        return null;
                }
                else if (name.StartsWith("{http://hl7.org/fhir}"))
                {
                    int prefixLength = "{http://hl7.org/fhir}".Length;
                    var remainder = name.Substring(prefixLength);
                    var split = remainder.Split('.');
                    if (ModelInfo.FhirTypeNameToFhirType(split[0]) is FHIRAllTypes primitiveType)
                        return TypeEntryFor(primitiveType);

                    return null;
                }
                else
                    return null;
            }
            else return null;
        }

        /// <summary>
        /// Given an ELM element, return the Type mapping info
        /// </summary>
        /// <param name="element">the ELM element</param>
        /// <returns>the Type mapping, or null</returns>
        public CqlTypeToFhirMapping? TypeEntryFor(Elm.Element element)
        {
            return element switch
            {
                Elm.Literal literal => TypeEntryFor(literal.valueType.Name),
                _ => element.resultTypeName != null ? TypeEntryFor(element.resultTypeName.Name) : TypeEntryFor(element.resultTypeSpecifier)
            };
        }
        private bool IsOrImplementsIEnumerableOfT(Type type) => TypeResolver.ImplementsGenericInterface(type, typeof(IEnumerable<>));

        private FHIRAllTypes? PrimitiveToFhir(Type type)
        {
            if (Nullable.GetUnderlyingType(type) != null)
            {
                return PrimitiveToFhir(Nullable.GetUnderlyingType(type)!);
            }

            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Int32:
                    return FHIRAllTypes.Integer;
                case TypeCode.Decimal:
                    return FHIRAllTypes.Decimal;
                case TypeCode.String:
                    return FHIRAllTypes.String;
                case TypeCode.Boolean:
                    return FHIRAllTypes.Boolean;
                default:
                    return null;
            }
        }
    }

    /// <summary>
    /// Contains information about type mappings between CQL and FHIR type
    /// </summary>
    /// <param name="FhirType">the FHIR type</param>
    /// <param name="CqlType">the CQL type</param>
    /// <param name="ElementType">the element type, if the base type is a collection</param>
    public record CqlTypeToFhirMapping(
      FHIRAllTypes? FhirType,
      CqlPrimitiveType? CqlType,
      CqlTypeToFhirMapping? ElementType = null
    );
}