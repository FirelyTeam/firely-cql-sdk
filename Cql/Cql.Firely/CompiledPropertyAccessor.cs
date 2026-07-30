/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Linq.Expressions;

#nullable enable

namespace Hl7.Cql.Fhir
{
    /// <summary>
    /// Provides getters for properties that are read repeatedly, compiled once per property and cached.
    /// </summary>
    internal static class CompiledPropertyAccessor
    {
        private static readonly ConcurrentDictionary<PropertyInfo, Func<object, object?>> Accessors = new(GetterIdentityComparer.Instance);

        /// <summary>
        /// Returns a getter for <paramref name="property"/>. The getter returns <see langword="null"/> when the
        /// instance passed to it is not of the property's declaring type.
        /// </summary>
        public static Func<object, object?> For(PropertyInfo property) =>
            Accessors.GetOrAdd(property, Compile);

        private static Func<object, object?> Compile(PropertyInfo property)
        {
            // Only an instance getter on a closed type without index parameters can be compiled;
            // anything else keeps using reflection.
            if (property.GetGetMethod(nonPublic: false) is not { IsStatic: false } getter
                || property.DeclaringType is not { ContainsGenericParameters: false } declaringType
                || property.GetIndexParameters().Length > 0)
            {
                return property.GetValue;
            }

            var instance = Expression.Parameter(typeof(object), "instance");

            // The type test keeps instances that do not have the property at all out of the getter, since the
            // caller filters over a heterogeneous set of resources and expects no value rather than an exception.
            var body = Expression.Condition(
                Expression.TypeIs(instance, declaringType),
                Expression.Convert(Expression.Call(Expression.Convert(instance, declaringType), getter), typeof(object)),
                Expression.Constant(null, typeof(object))
            );

            return Expression.Lambda<Func<object, object?>>(body, instance).Compile();
        }

        /// <summary>
        /// Compares properties by the getter they resolve to, so that separate <see cref="PropertyInfo"/> instances
        /// describing the same property share one compiled getter. Without this, wrappers such as
        /// <see cref="FhirModelPropertyInfo"/> - which are created anew on every lookup and do not implement
        /// value equality - would each add an entry to a cache that lives as long as the process.
        /// </summary>
        private sealed class GetterIdentityComparer : IEqualityComparer<PropertyInfo>
        {
            public static readonly GetterIdentityComparer Instance = new();

            public bool Equals(PropertyInfo? x, PropertyInfo? y) =>
                x is null || y is null ? ReferenceEquals(x, y) : Identity(x).Equals(Identity(y));

            public int GetHashCode(PropertyInfo obj) => Identity(obj).GetHashCode();

            private static MemberInfo Identity(PropertyInfo property) => property.GetGetMethod(nonPublic: true) ?? (MemberInfo)property;
        }
    }
}

#nullable disable
