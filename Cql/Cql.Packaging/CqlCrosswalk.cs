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
    public class CqlCrosswalk
    {
        internal TypeResolver TypeResolver { get; private set; }
        internal ModelInspector ModelInspector { get; private set; }

        /// <summary>
        /// Creates a new instance with the specified type resovler and the default model inspector
        /// </summary>
        /// <param name="typeResolver">the type resolver</param>
        public CqlCrosswalk(TypeResolver typeResolver) : this(typeResolver, ModelInfo.ModelInspector)
        {
        }

        /// <summary>
        /// Creates a new instance with the specified type resovler
        /// </summary>
        /// <param name="typeResolver">the type resolver</param>
        /// <param name="modelInspector">the model inspector</param>
        public CqlCrosswalk(TypeResolver typeResolver, ModelInspector modelInspector)
        {
            TypeResolver = typeResolver;
            ModelInspector = modelInspector;
        }

        /// <summary>
        /// Given a static FHIR type, returns the corresponding Type mapping (if any)
        /// </summary>
        /// <param name="fhirType">the static FHIR type</param>
        /// <returns>the Type mapping, or null</returns>
        public TypeEntry? TypeEntryFor(FHIRAllTypes fhirType)
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
                    return new TypeEntry(fhirType, CqlPrimitiveType.Quantity);
                case FHIRAllTypes.Any:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Any);
                case FHIRAllTypes.String:
                case FHIRAllTypes.Base64Binary:
                case FHIRAllTypes.Id:
                case FHIRAllTypes.Markdown:
                case FHIRAllTypes.Oid:
                case FHIRAllTypes.Uri:
                case FHIRAllTypes.Uuid:
                case FHIRAllTypes.Xhtml:
                    return new TypeEntry(fhirType, CqlPrimitiveType.String);
                case FHIRAllTypes.Boolean:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Boolean);
                case FHIRAllTypes.Code:
                case FHIRAllTypes.Coding:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Code);
                case FHIRAllTypes.CodeableConcept:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Concept);
                case FHIRAllTypes.CodeSystem:
                    return new TypeEntry(fhirType, CqlPrimitiveType.CodeSystem);
                case FHIRAllTypes.Date:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Date);
                case FHIRAllTypes.DateTime:
                case FHIRAllTypes.Instant:
                    return new TypeEntry(fhirType, CqlPrimitiveType.DateTime);
                case FHIRAllTypes.Time:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Time);
                case FHIRAllTypes.Decimal:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Decimal);
                case FHIRAllTypes.Integer:
                case FHIRAllTypes.UnsignedInt:
                case FHIRAllTypes.PositiveInt:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Integer);
                case FHIRAllTypes.Range:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Interval, new TypeEntry(FHIRAllTypes.Quantity, CqlPrimitiveType.Quantity));
                case FHIRAllTypes.Ratio:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Interval, new TypeEntry(FHIRAllTypes.Quantity, CqlPrimitiveType.Quantity));
                case FHIRAllTypes.List:
                    return new TypeEntry(fhirType, CqlPrimitiveType.List, new TypeEntry(FHIRAllTypes.Any, CqlPrimitiveType.Any));
                case FHIRAllTypes.Period:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Interval, new TypeEntry(FHIRAllTypes.DateTime, CqlPrimitiveType.DateTime));
                default:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Fhir);
            }
        }

        /// <summary>
        /// Given a CQL type, returns the corresponding FHIR type (if any)
        /// </summary>
        /// <param name="cqlType">the base CQL type</param>
        /// <param name="elementType">an element CQL type, used if <paramref name="cqlType"/> is a collection</param>
        /// <returns>the corresponding Type mapping, or null</returns>
        /// <exception cref="ArgumentNullException">throws if <paramref name="cqlType"/> is a collection, but <paramref name="elementType"/> was not provided.</exception>
        public TypeEntry? TypeEntryFor(CqlPrimitiveType cqlType, TypeEntry? elementType = null)
        {
            switch (cqlType)
            {
                case CqlPrimitiveType.Any:
                    return new TypeEntry(FHIRAllTypes.Any, cqlType);
                case CqlPrimitiveType.Boolean:
                    return new TypeEntry(FHIRAllTypes.Boolean, cqlType);
                case CqlPrimitiveType.Code:
                    return new TypeEntry(FHIRAllTypes.Code, cqlType);
                case CqlPrimitiveType.CodeSystem:
                    return new TypeEntry(FHIRAllTypes.CodeSystem, cqlType);
                case CqlPrimitiveType.Concept:
                    return new TypeEntry(FHIRAllTypes.CodeableConcept, cqlType);
                case CqlPrimitiveType.Date:
                    return new TypeEntry(FHIRAllTypes.Date, cqlType);
                case CqlPrimitiveType.DateTime:
                    return new TypeEntry(FHIRAllTypes.DateTime, cqlType);
                case CqlPrimitiveType.Decimal:
                    return new TypeEntry(FHIRAllTypes.Decimal, cqlType);
                case CqlPrimitiveType.List:
                    if (elementType is null || elementType.CqlType is null)
                        throw new ArgumentNullException($"List types must specify an element type.", nameof(elementType));
                    return new TypeEntry(FHIRAllTypes.List, cqlType, elementType);
                case CqlPrimitiveType.Integer:
                    return new TypeEntry(FHIRAllTypes.Integer, cqlType);
                case CqlPrimitiveType.Interval:
                    if (elementType is null || elementType.CqlType is null)
                        throw new ArgumentNullException($"Interval types must specify an element (point) type.", nameof(elementType));
                    switch (elementType.CqlType)
                    {
                        case CqlPrimitiveType.Date:
                            return new TypeEntry(FHIRAllTypes.Period, cqlType, TypeEntryFor(FHIRAllTypes.Date));
                        case CqlPrimitiveType.DateTime:
                            return new TypeEntry(FHIRAllTypes.Period, cqlType, TypeEntryFor(FHIRAllTypes.DateTime));
                        case CqlPrimitiveType.Decimal:
                            return new TypeEntry(FHIRAllTypes.Range, cqlType, TypeEntryFor(FHIRAllTypes.Decimal));
                        case CqlPrimitiveType.Integer:
                            return new TypeEntry(FHIRAllTypes.Range, cqlType, TypeEntryFor(FHIRAllTypes.Decimal));
                        case CqlPrimitiveType.Quantity:
                            return new TypeEntry(FHIRAllTypes.Range, cqlType, TypeEntryFor(FHIRAllTypes.Quantity));
                        case CqlPrimitiveType.Ratio:
                            return new TypeEntry(FHIRAllTypes.Ratio, cqlType);
                        case CqlPrimitiveType.Time:
                            return new TypeEntry(FHIRAllTypes.Range, cqlType, TypeEntryFor(FHIRAllTypes.Duration));
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
                    return new TypeEntry(FHIRAllTypes.Quantity, cqlType);
                case CqlPrimitiveType.Ratio:
                    return new TypeEntry(FHIRAllTypes.Ratio, cqlType);
                case CqlPrimitiveType.String:
                    return new TypeEntry(FHIRAllTypes.String, cqlType);
                case CqlPrimitiveType.Time:
                    return new TypeEntry(FHIRAllTypes.Time, cqlType);
                case CqlPrimitiveType.ValueSet:
                    return new TypeEntry(FHIRAllTypes.ValueSet, cqlType);
                case CqlPrimitiveType.Tuple:
                    return new TypeEntry(FHIRAllTypes.Basic, cqlType);
                case CqlPrimitiveType.Fhir:
                    return new TypeEntry(FHIRAllTypes.Resource, cqlType);
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
        public TypeEntry? TypeEntryFor(Type type)
        {
            var fhirTypeName = ModelInspector.GetFhirTypeNameForType(type);
            if (fhirTypeName is not null)
            {
                return TypeEntryFor(fhirTypeName);
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
                var elementEntry = TypeEntryFor(elementType!);
                if (elementEntry is null)
                    return null;
                return TypeEntryFor(CqlPrimitiveType.List, elementEntry);
            }
            if (type.IsPrimitive || type.IsValueType || type == typeof(string))
            {
                var fhirType = PrimitiveToFhir(type);
                if (fhirType == null) return null;

                return TypeEntryFor(fhirType.Value);
            }

            return null;
        }

        /// <summary>
        /// Given an ELM type specifier, returns the corresponding Type mapping
        /// </summary>
        /// <param name="resultTypeSpecifier">the ELM type</param>
        /// <returns>the Type mapping, if any</returns>
        public TypeEntry? TypeEntryFor(Elm.TypeSpecifier? resultTypeSpecifier)
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
                    return new TypeEntry(FHIRAllTypes.Basic, CqlPrimitiveType.Tuple);
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
        public TypeEntry? TypeEntryFor(string? name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                var runtimeType = TypeResolver.ResolveType(name);
                if (string.IsNullOrWhiteSpace(name))
                    return null;
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
        public TypeEntry? TypeEntryFor(Elm.Element element) =>
            TypeEntryFor(element.resultTypeSpecifier);

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
    public record TypeEntry(
      FHIRAllTypes? FhirType,
      CqlPrimitiveType? CqlType,
      TypeEntry? ElementType = null
    );
}