/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

namespace Hl7.Cql.Abstractions
{
    /// <summary>
    /// Holds the memoized patient type and birth-date property for a type resolver.
    /// Both lookups are evaluated at most once, on first access.
    /// </summary>
    internal sealed class PatientTypeInfo
    {
        private readonly Lazy<Type?> _type;
        private readonly Lazy<PropertyInfo?> _birthDateProperty;

        /// <param name="resolveType">Strategy that returns the patient .NET type, or <see langword="null"/> if the model has no patient concept.</param>
        /// <param name="resolveBirthDateProperty">
        /// Strategy that returns the birth-date <see cref="PropertyInfo"/> given the resolved patient type.
        /// Receives the resolved patient type as its argument; only invoked when that type is non-null.
        /// </param>
        internal PatientTypeInfo(Func<Type?> resolveType, Func<Type, PropertyInfo?> resolveBirthDateProperty)
        {
            _type = new Lazy<Type?>(resolveType);
            _birthDateProperty = new Lazy<PropertyInfo?>(() =>
            {
                var patientType = _type.Value;
                return patientType is not null ? resolveBirthDateProperty(patientType) : null;
            });
        }

        /// <summary>Gets the patient .NET type, or <see langword="null"/> if the model has no patient concept.</summary>
        internal Type? Type => _type.Value;

        /// <summary>Gets the birth-date property on <see cref="Type"/>, or <see langword="null"/> if <see cref="Type"/> is null or the property is absent.</summary>
        internal PropertyInfo? BirthDateProperty => _birthDateProperty.Value;
    }
}
