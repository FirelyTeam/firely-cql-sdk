/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
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
        protected readonly Dictionary<string, Type> Types;

        /// <nodoc/>
        public BaseTypeResolver() =>
            Types = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase) {
                { "{urn:hl7-org:elm-types:r1}Any"       , AnyType        },
                { "{urn:hl7-org:elm-types:r1}Date"      , DateType       },
                { "{urn:hl7-org:elm-types:r1}DateTime"  , DateTimeType   },
                { "{urn:hl7-org:elm-types:r1}Quantity"  , QuantityType   },
                { "{urn:hl7-org:elm-types:r1}Integer"   , IntegerType    },
                { "{urn:hl7-org:elm-types:r1}Long"      , LongType       },
                { "{urn:hl7-org:elm-types:r1}Boolean"   , BooleanType    },
                { "{urn:hl7-org:elm-types:r1}String"    , StringType     },
                { "{urn:hl7-org:elm-types:r1}Decimal"   , DecimalType    },
                { "{urn:hl7-org:elm-types:r1}Ratio"     , RatioType      },
                { "{urn:hl7-org:elm-types:r1}Code"      , CodeType       },
                { "{urn:hl7-org:elm-types:r1}CodeSystem", CodeSystemType },
                { "{urn:hl7-org:elm-types:r1}Concept"   , ConceptType    },
                { "{urn:hl7-org:elm-types:r1}Time"      , TimeType       },
                { "{urn:hl7-org:elm-types:r1}ValueSet"  , ValueSetType   },
                { "{urn:hl7-org:elm-types:r1}Vocabulary", VocabularyType },
            };

        /// <inheritdoc />
        internal override Type AnyType => typeof(object);

        /// <inheritdoc />
        internal override Type DateType => typeof(CqlDate);

        /// <inheritdoc />
        internal override Type DateTimeType => typeof(CqlDateTime);

        /// <inheritdoc />
        internal override Type QuantityType => typeof(CqlQuantity);

        /// <inheritdoc />
        internal override Type IntegerType => typeof(int?);

        /// <inheritdoc />
        internal override Type LongType => typeof(long?);

        /// <inheritdoc />
        internal override Type BooleanType => typeof(bool?);

        /// <inheritdoc />
        internal override Type StringType => typeof(string);

        /// <inheritdoc />
        internal override Type DecimalType => typeof(decimal?);

        /// <inheritdoc />
        internal override Type RatioType => typeof(CqlRatio);

        /// <inheritdoc />
        internal override Type CodeType => typeof(CqlCode);

        /// <inheritdoc />
        internal override Type CodeSystemType => typeof(CqlCodeSystem);

        /// <inheritdoc />
        internal override Type ConceptType => typeof(CqlConcept);

        /// <inheritdoc />
        internal override Type TimeType => typeof(CqlTime);

        /// <inheritdoc />
        internal override Type ValueSetType => typeof(CqlValueSet);

        /// <inheritdoc />
        internal override Type VocabularyType => typeof(CqlVocabulary);

        /// <inheritdoc/>
        internal override Type IntervalType(Type pointType) =>
            pointType is not null
                ? typeof(CqlInterval<>).MakeGenericType(pointType)
                : throw new ArgumentNullException(nameof(pointType));

        /// <inheritdoc/>
        internal sealed override PropertyInfo? GetProperty(Type type, string propertyName)
        {
            if (type.IsTupleBaseType())
            {
                // This code only executes during the building of the LINQ expression tree, not at runtime
                var properties = type.GetProperties();
                foreach (var prop in properties)
                {
                    var cqlDeclaration = prop.GetCustomAttribute<CqlDeclarationAttribute>();
                    if (cqlDeclaration != null && cqlDeclaration.Name == propertyName)
                        return prop;
                }
            }
            else if (type.IsCqlValueTuple())
            {
                throw new NotSupportedException("It is not expected that the CQL runtime query the properties of a value type.");

                // If it turns out that this is needed, we can implement it, but since the metadata
                // is only available from the CqlTupleMetadata that is available from the first element
                // of the tuple, it is not clear how to implement this given only the type.
            }
            return GetPropertyCore(type, propertyName);
        }

        /// <summary>
        /// Additional logic get retrieve a <see cref="PropertyInfo"/> by name for a given type.
        /// </summary>
        protected virtual PropertyInfo? GetPropertyCore(Type type, string propertyName) =>
            type.GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance);

        /// <inheritdoc/>
        public override Type? ResolveType(string typeSpecifier, bool throwError = true)
        {
            var correctedTypeSpecifier = CorrectQiCoreExtensionTypes(typeSpecifier);

            if (Types.TryGetValue(correctedTypeSpecifier, out var type))
                return type;

            if (throwError)
                throw new ArgumentException($"Type {correctedTypeSpecifier} is not bound", nameof(typeSpecifier));

            return null;
        }

        private static string CorrectQiCoreExtensionTypes(string typeSpecifier) =>
            typeSpecifier switch
            {
                "{http://hl7.org/fhir}NotDoneRecorded" => "{http://hl7.org/fhir}dateTime",
                "{http://hl7.org/fhir}EncounterProcedureExtension" => "{http://hl7.org/fhir}Extension",
                _ => typeSpecifier
            };

        /// <inheritdoc/>
        public override Type? GetListElementType(Type type, bool throwError = false)
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

                else if (throwError) throw new NotSupportedException();
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

            if (throwError)
                throw new NotSupportedException();
            else return null;
        }
    }
}
