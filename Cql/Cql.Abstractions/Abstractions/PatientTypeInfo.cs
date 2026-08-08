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
    /// Holds the memoized patient type and birth-date accessor for a type resolver.
    /// Both lookups are evaluated at most once, on first access.
    /// </summary>
    internal sealed class PatientTypeInfo
    {
        private readonly Lazy<Type?> _type;
        private readonly Lazy<Func<object, object?>?> _birthDateGetter;

        /// <param name="resolveType">Strategy that returns the patient .NET type, or <see langword="null"/> if the model has no patient concept.</param>
        /// <param name="resolveBirthDateGetter">
        /// Strategy that returns a getter reading the birth date off a patient instance, given the resolved patient
        /// type. Receives the resolved patient type as its argument; only invoked when that type is non-null.
        /// </param>
        internal PatientTypeInfo(Func<Type?> resolveType, Func<Type, Func<object, object?>?> resolveBirthDateGetter)
        {
            _type = new Lazy<Type?>(resolveType);
            _birthDateGetter = new Lazy<Func<object, object?>?>(() =>
            {
                var patientType = _type.Value;
                return patientType is not null ? resolveBirthDateGetter(patientType) : null;
            });
        }

        /// <summary>Gets the patient .NET type, or <see langword="null"/> if the model has no patient concept.</summary>
        internal Type? Type => _type.Value;

        /// <summary>
        /// Gets a getter that reads the birth date off a patient instance, or <see langword="null"/> if
        /// <see cref="Type"/> is null or the model has no birth-date property.
        /// </summary>
        internal Func<object, object?>? BirthDateGetter => _birthDateGetter.Value;
    }
}
