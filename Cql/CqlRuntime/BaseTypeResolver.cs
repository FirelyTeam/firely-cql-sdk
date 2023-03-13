using Ncqa.Cql.Runtime.Primitives;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Ncqa.Cql.Runtime
{
    public abstract class BaseTypeResolver : TypeResolver
    {
        protected readonly Dictionary<string, Type> Types = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase) {
            { "{urn:hl7-org:elm-types:r1}Any", typeof(object) },
            { "{urn:hl7-org:elm-types:r1}Date", typeof(CqlDate) },
            { "{urn:hl7-org:elm-types:r1}DateTime", typeof(CqlDateTime) },
            { "{urn:hl7-org:elm-types:r1}Quantity", typeof(CqlQuantity) },
            { "{urn:hl7-org:elm-types:r1}Integer", typeof(int?) },
            { "{urn:hl7-org:elm-types:r1}Long", typeof(long?) },
            { "{urn:hl7-org:elm-types:r1}Boolean", typeof(bool?) },
            { "{urn:hl7-org:elm-types:r1}String", typeof(string) },
            { "{urn:hl7-org:elm-types:r1}Decimal", typeof(decimal?) },
            { "{urn:hl7-org:elm-types:r1}Ratio", typeof(CqlRatio) },
            { "{urn:hl7-org:elm-types:r1}Code", typeof(CqlCode) },
            { "{urn:hl7-org:elm-types:r1}CodeSystem", typeof(CqlCodeSystem) },
            { "{urn:hl7-org:elm-types:r1}Concept", typeof(CqlConcept) },
            { "{urn:hl7-org:elm-types:r1}Time", typeof(CqlTime) },
            { "{urn:hl7-org:elm-types:r1}ValueSet", typeof(CqlValueSet) },
            { "{urn:hl7-org:elm-types:r1}Vocabulary", typeof(Vocabulary) },
        };
        public override Type AnyType => Types["{urn:hl7-org:elm-types:r1}Any"];

        public override Type BooleanType => Types["{urn:hl7-org:elm-types:r1}Boolean"];

        public override Type CodeType => Types["{urn:hl7-org:elm-types:r1}Code"];

        public override Type CodeSystemType => Types["{urn:hl7-org:elm-types:r1}CodeSystem"];

        public override Type ConceptType => Types["{urn:hl7-org:elm-types:r1}Concept"];

        public override Type DateType => Types["{urn:hl7-org:elm-types:r1}Date"];

        public override Type DateTimeType => Types["{urn:hl7-org:elm-types:r1}DateTime"];

        public override Type DecimalType => Types["{urn:hl7-org:elm-types:r1}Decimal"];

        public override Type LongType => Types["{urn:hl7-org:elm-types:r1}Long"];

        public override Type IntegerType => Types["{urn:hl7-org:elm-types:r1}Integer"];

        public override Type IntervalType(Type pointType) =>
            pointType is not null
            ? typeof(CqlInterval<>).MakeGenericType(pointType)
            : throw new ArgumentNullException(nameof(pointType));

        public override Type QuantityType => Types["{urn:hl7-org:elm-types:r1}Quantity"];

        public override Type RatioType => Types["{urn:hl7-org:elm-types:r1}Ratio"];
        public override Type StringType => Types["{urn:hl7-org:elm-types:r1}String"];

        public override Type TimeType => Types["{urn:hl7-org:elm-types:r1}Time"];

        public override Type ValueSetType => Types["{urn:hl7-org:elm-types:r1}ValueSet"];

        public override Type VocabularyType => Types["{urn:hl7-org:elm-types:r1}Vocabulary"];

        public override PropertyInfo? GetProperty(Type type, string propertyName)
        {
            if (typeof(TupleBaseType).IsAssignableFrom(type))
            {
                var properties = type.GetProperties();
                foreach(var prop in properties)
                {
                    var cqlDeclaration = prop.GetCustomAttribute<CqlDeclarationAttribute>();
                    if (cqlDeclaration != null && cqlDeclaration.Name == propertyName)
                        return prop;
                }

            }

            return type.GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance);
        }

        public override Type? ResolveType(string typeSpecifier)
        {
            if (Types.TryGetValue(typeSpecifier, out var type))
                return type;
            else throw new ArgumentException($"Type {typeSpecifier} is not bound", nameof(typeSpecifier));
        }

        public override bool IsListType(Type type, Type genericInterfaceTypeDefinition)
        {
            if (type == typeof(string))
                return false;
            return (type.IsGenericType && type.GetGenericTypeDefinition() == genericInterfaceTypeDefinition)
                || type.GetInterfaces()
                    .Where(ifc => ifc.IsGenericType)
                    .Select(ifc => ifc.GetGenericTypeDefinition())
                    .Any(ifc => ifc == genericInterfaceTypeDefinition);
        }

        public override Type? GetElementType(Type type) => GetElementType(type, true);
        public override Type? GetElementType(Type type, bool @throw)
        {
            if (type.IsGenericType)
            {
                var genericTypeDefinition = type.GetGenericTypeDefinition();
                if (genericTypeDefinition == typeof(IEnumerable<>))
                    return type.GetGenericArguments()[0];
                else if (genericTypeDefinition == typeof(List<>))
                    return type.GetGenericArguments()[0];
                else if (genericTypeDefinition == typeof(ICollection<>))
                    return type.GetGenericArguments()[0];
                else if (@throw) throw new NotSupportedException();
                else return null;
            }
            else if (type.IsArray)
                return type.GetElementType()!;
            else
            {
                var enumerableInterface = type.GetInterfaces()
                    .SingleOrDefault(ifc => ifc.IsGenericType
                        && ifc.GetGenericTypeDefinition() == typeof(IEnumerable<>));
                if (enumerableInterface != null)
                    return GetElementType(enumerableInterface);
            }

            if (@throw)
                throw new NotSupportedException();
            else return null;
        }
    }
}
