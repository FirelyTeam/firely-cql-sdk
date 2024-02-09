/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Hl7.Cql.Abstractions
{
    /// <summary>
    /// Resolves the .NET type for the given ELM type specifier.
    /// </summary>
    public abstract class TypeResolver
    {
        #region CQL types defined in section 1
        /// <summary>
        /// The type to use for <c>CqlPrimitiveType.Any</c>.
        /// </summary>
        internal abstract Type AnyType { get; }
        /// <summary>
        /// The type to use for <c>CqlPrimitiveType.Boolean</c>.
        /// </summary>
        internal abstract Type BooleanType { get; }
        /// <summary>
        /// The type to use for <c>CqlPrimitiveType.Code</c>.
        /// </summary>
        internal abstract Type CodeType { get; }
        /// <summary>
        /// The type to use for <c>CqlPrimitiveType.CodeSystem</c>.
        /// </summary>
        internal abstract Type CodeSystemType { get; }
        /// <summary>
        /// The type to use for <c>CqlPrimitiveType.Concept</c>.
        /// </summary>
        internal abstract Type ConceptType { get; }
        /// <summary>
        /// The type to use for <c>CqlPrimitiveType.Date</c>.
        /// </summary>
        internal abstract Type DateType { get; }
        /// <summary>
        /// The type to use for <c>CqlPrimitiveType.DateTime</c>.
        /// </summary>
        internal abstract Type DateTimeType { get; }
        /// <summary>
        /// The type to use for <c>CqlPrimitiveType.Decimal</c>.
        /// </summary>
        internal abstract Type DecimalType { get; }
        /// <summary>
        /// The type to use for <c>CqlPrimitiveType.Long</c>.
        /// </summary>
        internal abstract Type LongType { get; }
        /// <summary>
        /// The type to use for <c>CqlPrimitiveType.Interval</c>.
        /// </summary>
        /// <param name="pointType">The type of this interval.</param>
        internal abstract Type IntervalType(Type pointType);
        /// <summary>
        /// The type to use for <c>CqlPrimitiveType.Integer</c>.
        /// </summary>
        internal abstract Type IntegerType { get; }
        /// <summary>
        /// The type to use for <c>CqlPrimitiveType.Quantity</c>.
        /// </summary>
        internal abstract Type QuantityType { get; }
        /// <summary>
        /// The type to use for <c>CqlPrimitiveType.Ratio</c>.
        /// </summary>
        internal abstract Type RatioType { get; }
        /// <summary>
        /// The type to use for <c>CqlPrimitiveType.String</c>.
        /// </summary>
        internal abstract Type StringType { get; }
        /// <summary>
        /// The type to use for <c>CqlPrimitiveType.Time</c>.
        /// </summary>
        internal abstract Type TimeType { get; }
        /// <summary>
        /// The type to use for <c>CqlPrimitiveType.ValueSet</c>.
        /// </summary>
        internal abstract Type ValueSetType { get; }
        /// <summary>
        /// The type to use for <c>CqlPrimitiveType.Vocabulary</c>.
        /// </summary>
        internal abstract Type VocabularyType { get; }

        #endregion

        /// <summary>
        /// Resolves the .NET type for the given ELM type specifier.
        /// </summary>
        /// <param name="typeSpecifier">The ELM type specifier.</param>
        /// <returns>The .NET type to use.</returns>
        public abstract Type? ResolveType(string typeSpecifier);

        /// <summary>
        /// Returns <see langword="true"/> if <paramref name="type"/> implements the generic interface specified by <paramref name="genericInterfaceTypeDefinition"/>.
        /// </summary>
        /// <remarks>
        /// This is typically used in conjunction with <see cref="GetListElementType(Type, bool)"/>, where
        /// <paramref name="genericInterfaceTypeDefinition"/> is <see cref="IEnumerable{T}"/>.
        /// </remarks>
        /// <param name="type">The type to check.</param>
        /// <param name="genericInterfaceTypeDefinition">The generic type definition.</param>
        /// <returns></returns>
        public abstract bool ImplementsGenericInterface(Type type, Type genericInterfaceTypeDefinition);
        /// <summary>
        /// Gets the list element type of <paramref name="type"/>.
        /// </summary>
        /// <param name="type">The type whose element to return.</param>
        /// <param name="throw">If <see langword="true"/>, this method will throw an <see cref="ArgumentException"/> if the type does not have an element type.</param>
        /// <returns>The element type, or <see langword="null"/> if <paramref name="throw"/> is <see langword="false"/></returns>
        public abstract Type? GetListElementType(Type type, bool @throw = false);

        /// <summary>
        /// Gets the primary code path used in retrieve short-hand notation e.g., <code>[Condition: "value set"]</code>
        /// </summary>
        /// <param name="typeSpecifier">The ELM type specifier.</param>
        /// <returns>The .NET property for the primary code path, or <see langword="null"/> if none exists.</returns>
        internal abstract PropertyInfo? GetPrimaryCodePath(string typeSpecifier);

        /// <summary>
        /// Gets the property for the given path.
        /// </summary>
        /// <remarks>
        /// For simple models this can be as simple as <see cref="Type.GetProperty(string)"/>, but in some cases
        /// (e.g., where the type is an <see cref="Enum"/>) this logic can get more complicated.
        /// </remarks>
        /// <param name="type">The .NET type</param>
        /// <param name="propertyName">The property name.</param>
        /// <returns>The .NET property for the path, or <see langword="null"/> if none exists.</returns>
        internal abstract PropertyInfo? GetProperty(Type type, string propertyName);

        /// <summary>
        /// Gets the type used to model the concept of a Patient.
        /// For FHIR models, this would be the type used to model the <see href="https://www.hl7.org/fhir/patient.html" /> resource.
        /// </summary>
        /// <remarks>
        /// This is defined on CQL models to allow for the implementation of age operators.
        /// </remarks>
        internal abstract Type? PatientType { get; }
        /// <summary>
        /// Gets the property on <see cref="PatientType"/> that represents the patient's birthdate.
        /// </summary>
        /// <remarks>
        /// This is defined on CQL models to allow for the implementation of age operators.
        /// </remarks>
        internal abstract PropertyInfo? PatientBirthDateProperty { get; }

        /// <summary>
        /// Gets the assemblies that contain types that this type resolver resolves for 
        /// model types, e.g. in the http://hl7.org/fhir namespace.  This property may,
        /// but is not required to, return types resolved from the System namespace, e.g.
        /// Cql.Primitives.
        /// </summary>
        internal abstract IEnumerable<Assembly> ModelAssemblies { get; }
        /// <summary>
        /// Gets the namespaces of the types that this type resolver resolves for 
        /// model types, e.g. in the http://hl7.org/fhir namespace.  This property may,
        /// but is not required to, return types resolved from the System namespace, e.g.
        /// Cql.Primitives.
        /// </summary>
        internal abstract IEnumerable<string> ModelNamespaces { get; }

        /// <summary>
        /// Gets any aliases for types that conflict with commonly imported .NET types.
        /// </summary>
        /// <remarks>
        /// The base implementation aliases the FHIR Range type to whatever type
        /// <see cref="ResolveType(string)"/> returns when passed "{http://hl7.org/fhir}"
        /// to avoid conflicts with <see cref="Range"/>.
        /// </remarks>
        internal virtual IEnumerable<(string alias, string type)> Aliases =>
            Enumerable.Empty<(string alias, string type)>();

        /// <summary>
        /// Returns whether the source object should be used for the given property.
        /// </summary>
        /// <remarks>
        /// This is primarily used when using FhirDateTime types and trying to access the value property.
        /// It causes an unncessary string parse into a CqlDateTime object when we have a FhirDateTime to CqlDateTime converter
        /// that is much more performant.
        /// </remarks>
        /// <param name="type">The .NET type</param>
        /// <param name="propertyName">The property name.</param>
        internal abstract bool ShouldUseSourceObject(Type type, string propertyName);

    }
}
