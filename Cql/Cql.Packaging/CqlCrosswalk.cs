using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
namespace Hl7.Cql.Packaging
{
    public class CqlCrosswalk
    {
        public TypeResolver TypeResolver { get; private set; }
        
        public CqlCrosswalk(TypeResolver typeResolver)
        {
            TypeResolver = typeResolver;
        }
        
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
                    if (Enum.TryParse<CqlPrimitiveType>(remainder, out var primitiveType))
                        return TypeEntryFor(primitiveType);
                    else
                        return null;
                }
                else if (name.StartsWith("{http://hl7.org/fhir}"))
                {
                    int prefixLength = "{http://hl7.org/fhir}".Length;
                    var remainder = name.Substring(prefixLength);
                    var split = remainder.Split('.');
                    if (Enum.TryParse<FHIRAllTypes>(split[0], out var fhirType))
                        return TypeEntryFor(fhirType);
                    else
                        return null;
                }
                else
                    return null;
            }
            else return null;
        }
        
        public TypeEntry? TypeEntryFor(Elm.Element element) =>
            TypeEntryFor(element.resultTypeSpecifier);

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

    public class TypeEntry
    {
        public TypeEntry(FHIRAllTypes fhirType, CqlPrimitiveType cqlType, TypeEntry? elementType = null)
        {
            FhirType = fhirType;
            CqlType = cqlType;
            ElementType = elementType;
        }

        public FHIRAllTypes? FhirType { get; set; }
        public CqlPrimitiveType? CqlType { get; set; }
        public TypeEntry? ElementType { get; set; } = null;
    }
}
