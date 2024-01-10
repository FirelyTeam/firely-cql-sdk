/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Hl7.Cql.Runtime
{
    /// <summary>
    /// Provides default resolution of CQL System types to .NET types.
    /// </summary>
    public abstract class BaseTypeResolver : TypeResolver
    {
        /// <summary>
        /// Mapping from CQL typerefs to .NET types.
        /// </summary>
        protected readonly Dictionary<string, Type> Types = new(StringComparer.OrdinalIgnoreCase) {
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
            { "{urn:hl7-org:elm-types:r1}Vocabulary", typeof(CqlVocabulary) },
        };

        /// <inheritdoc/>
        internal override Type AnyType => Types["{urn:hl7-org:elm-types:r1}Any"];

        /// <inheritdoc/>
        internal override Type BooleanType => Types["{urn:hl7-org:elm-types:r1}Boolean"];

        /// <inheritdoc/>
        internal override Type CodeType => Types["{urn:hl7-org:elm-types:r1}Code"];

        /// <inheritdoc/>
        internal override Type CodeSystemType => Types["{urn:hl7-org:elm-types:r1}CodeSystem"];

        /// <inheritdoc/>
        internal override Type ConceptType => Types["{urn:hl7-org:elm-types:r1}Concept"];

        /// <inheritdoc/>
        internal override Type DateType => Types["{urn:hl7-org:elm-types:r1}Date"];

        /// <inheritdoc/>
        internal override Type DateTimeType => Types["{urn:hl7-org:elm-types:r1}DateTime"];

        /// <inheritdoc/>
        internal override Type DecimalType => Types["{urn:hl7-org:elm-types:r1}Decimal"];

        /// <inheritdoc/>
        internal override Type LongType => Types["{urn:hl7-org:elm-types:r1}Long"];

        /// <inheritdoc/>
        internal override Type IntegerType => Types["{urn:hl7-org:elm-types:r1}Integer"];

        /// <inheritdoc/>
        internal override Type IntervalType(Type pointType) =>
            pointType is not null
            ? typeof(CqlInterval<>).MakeGenericType(pointType)
            : throw new ArgumentNullException(nameof(pointType));

        /// <inheritdoc/>
        internal override Type QuantityType => Types["{urn:hl7-org:elm-types:r1}Quantity"];

        /// <inheritdoc/>
        internal override Type RatioType => Types["{urn:hl7-org:elm-types:r1}Ratio"];

        /// <inheritdoc/>
        internal override Type StringType => Types["{urn:hl7-org:elm-types:r1}String"];

        /// <inheritdoc/>
        internal override Type TimeType => Types["{urn:hl7-org:elm-types:r1}Time"];

        /// <inheritdoc/>
        internal override Type ValueSetType => Types["{urn:hl7-org:elm-types:r1}ValueSet"];

        /// <inheritdoc/>
        internal override Type VocabularyType => Types["{urn:hl7-org:elm-types:r1}Vocabulary"];

        /// <inheritdoc/>
        internal sealed override PropertyInfo? GetProperty(Type type, string propertyName)
        {
            if (typeof(TupleBaseType).IsAssignableFrom(type))
            {
                var properties = type.GetProperties();
                foreach (var prop in properties)
                {
                    var cqlDeclaration = prop.GetCustomAttribute<CqlDeclarationAttribute>();
                    if (cqlDeclaration != null && cqlDeclaration.Name == propertyName)
                        return prop;
                }

            }

            return GetPropertyCore(type, propertyName);
        }

        /// <inheritdoc/>
        protected virtual PropertyInfo? GetPropertyCore(Type type, string propertyName) =>
            type.GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance);

        /// <inheritdoc/>
        public override Type? ResolveType(string typeSpecifier)
        {
            if (Types.TryGetValue(typeSpecifier, out var type))
                return type;
            else throw new ArgumentException($"Type {typeSpecifier} is not bound", nameof(typeSpecifier));
        }

        /// <inheritdoc/>
        public override bool ImplementsGenericInterface(Type type, Type genericInterfaceTypeDefinition)
        {
            if (type == typeof(string))
                return false;
            return (type.IsGenericType && type.GetGenericTypeDefinition() == genericInterfaceTypeDefinition)
                || type.GetInterfaces()
                    .Where(ifc => ifc.IsGenericType)
                    .Select(ifc => ifc.GetGenericTypeDefinition())
                    .Any(ifc => ifc == genericInterfaceTypeDefinition);
        }

        /// <inheritdoc/>
        public override Type? GetListElementType(Type type, bool @throw = false)
        {
            if (type.IsGenericType)
            {
                var genericTypeDefinition = type.GetGenericTypeDefinition();
                if (genericTypeDefinition == typeof(IEnumerable<>) 
                     || genericTypeDefinition == typeof(List<>) 
                     || genericTypeDefinition == typeof(ICollection<>)
                ) 
                    return type.GetGenericArguments()[0];

                // handle LINQ cast iterators, where iterators, selects, etc.
                if (genericTypeDefinition.GetInterfaces().Contains(typeof(System.Collections.IEnumerable)) 
                    && genericTypeDefinition.Namespace == "System.Linq"
                    && type.GenericTypeArguments.Length == 1)
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
                    return GetListElementType(enumerableInterface);
            }

            if (@throw)
                throw new NotSupportedException();
            else return null;
        }
    }
}
