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
        /// instance passed to it is not of the property's declaring type, and always for an indexer property,
        /// which has no value of its own to read.
        /// </summary>
        public static Func<object, object?> For(PropertyInfo property) =>
            Accessors.GetOrAdd(property, Compile);

        /// <summary>
        /// Returns a stable identity for <paramref name="property"/>: the getter it resolves to, so that separate
        /// <see cref="PropertyInfo"/> instances describing the same property share one identity. Wrappers such as
        /// <see cref="FhirModelPropertyInfo"/> are created anew on every lookup and do not implement value
        /// equality, so caches keyed by the instance itself would neither hit nor stay bounded.
        /// </summary>
        internal static MemberInfo GetterIdentity(PropertyInfo property) =>
            property.GetGetMethod(nonPublic: true) ?? (MemberInfo)property;

        private static Func<object, object?> Compile(PropertyInfo property)
        {
            if (property.GetIndexParameters().Length > 0)
                return _ => null;

            // Only an instance getter on a closed type can be compiled; anything else keeps using reflection,
            // guarded like the compiled getter: an instance that is not of the property's declaring type yields
            // no value rather than an exception, since callers filter over a heterogeneous set of resources.
            if (property.GetGetMethod(nonPublic: false) is not { IsStatic: false } getter
                || property.DeclaringType is not { ContainsGenericParameters: false } declaringType)
            {
                return instance => property.DeclaringType is { } type && type.IsInstanceOfType(instance)
                    ? property.GetValue(instance)
                    : null;
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
                x is null || y is null ? ReferenceEquals(x, y) : GetterIdentity(x).Equals(GetterIdentity(y));

            public int GetHashCode(PropertyInfo obj) => GetterIdentity(obj).GetHashCode();
        }
    }
}
