/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;

namespace Hl7.Cql.Abstractions.Infrastructure;

internal static class TypeExtensions
{
    /// <summary>
    /// Checks if the specified type is nullable and returns it via <paramref name="underlyingType"/>
    /// </summary>
    /// <param name="type">The type to check.</param>
    /// <param name="underlyingType">The underlying type for nullable.</param>
    /// <returns>True if the type is nullable, false otherwise.</returns>
    public static bool IsNullableValueType(this Type type, out Type underlyingType)
    {
        var nullableUnderlying = Nullable.GetUnderlyingType(type);
        var isNullableValueType = nullableUnderlying != null;
        underlyingType = nullableUnderlying ?? type;
        return isNullableValueType;
    }

    /// <summary>
    /// Checks if the specified type is nullable.
    /// </summary>
    /// <param name="type">The type to check.</param>
    /// <param name="nonNullableType">The non-nullable type.</param>
    /// <returns>True if the type is nullable, false otherwise.</returns>
    public static bool IsNullable(this Type type, out Type nonNullableType)
    {
        nonNullableType = type;

        if (type.IsValueType)
        {
            if (!IsNullableValueType(type, out var underlyingType))
                return false;

            nonNullableType = underlyingType;
        }

        return true;
    }

    public static Type MakeNullable(this Type type)
    {
        if (IsNullable(type, out var nonNullableType))
            return type;

        Debug.Assert(type.IsValueType);
        var nullableType = typeof(Nullable<>).MakeGenericType(nonNullableType);
        return nullableType;
    }

    /// <summary>
    /// Checks if the specified type is an enum or a nullable enum.
    /// </summary>
    /// <param name="type">The type to check.</param>
    /// <returns>True if the type is an enum or a nullable enum, false otherwise.</returns>
    public static bool IsEnum(this Type type)
    {
        if (type.IsEnum)
            return true;

        if (IsNullableValueType(type, out var underlyingType) && underlyingType.IsEnum)
            return true;

        return false;
    }

    /// <summary>
    /// Checks if the specified type is implementing the specified generic type definition.
    /// </summary>
    /// <param name="type">The type to check.</param>
    /// <param name="genericTypeDefinition">The generic type definition to check against.</param>
    /// <returns>True if the type is implementing the generic type definition, false otherwise.</returns>
    public static bool IsImplementingGenericTypeDefinition(this Type type, Type genericTypeDefinition)
    {
        if (!genericTypeDefinition.IsGenericTypeDefinition)
            throw new ArgumentException("Must be a generic type definition.", nameof(genericTypeDefinition));

        if (type.IsGenericType && type.GetGenericTypeDefinition() == genericTypeDefinition)
            return true;

        var hasInterfaceImplementing = type.GetInterfaces()
            .Where(ifc => ifc.IsGenericType)
            .Select(ifc => ifc.GetGenericTypeDefinition())
            .Any(ifc => ifc == genericTypeDefinition);
        return hasInterfaceImplementing;
    }

    /// <summary>
    /// Gets the base type of the specified type.
    /// Calling this method instead of <see cref="Type.BaseType"/> fixes the issue
    /// when getting the base type for a generic type definition, which becomes a
    /// constructed generic type, instead of remaining a generic type definition.
    /// </summary>
    /// <example>
    /// <code>
    /// // Shows the quirks when getting base type on a generic type definition. Here we expected to see true, but that turns out to be not the case
    /// Assert.IsFalse(typeof(MyGenericClassDerived&lt;>).BaseType == typeof(MyGenericClassBase&lt;>));
    ///
    /// // Why are they not the same? Because BaseType returns the constructed generic base type, while it should have remained a generic type definition.
    /// Assert.IsTrue(typeof(MyGenericClassDerived&lt;>).IsGenericTypeDefinition);
    /// Assert.IsTrue(typeof(MyGenericClassDerived&lt;>).BaseType!.IsConstructedGenericType);
    /// Assert.IsFalse(typeof(MyGenericClassDerived&lt;>).BaseType!.IsGenericTypeDefinition);
    ///
    /// // So, when getting the base type on a type definition, we always have to request the generic type definition of that!
    /// Assert.IsTrue(typeof(MyGenericClassDerived&lt;>).BaseType!.GetGenericTypeDefinition() == typeof(MyGenericClassBase&lt;>));
    /// </code>
    /// </example>
    public static Type? BaseTypeFixed(this Type type) =>
        (type, type.BaseType) switch
        {
            ({ IsGenericTypeDefinition: true }, { IsConstructedGenericType: true } b) => b.GetGenericTypeDefinition(),
            var (_, b)                                                                => b,
        };


    /// <summary>
    /// Determines if <paramref name="obj"/> is null or default.
    /// </summary>
    /// <remarks>Only use this method where <typeparamref name="TObject"/> is <see cref="object"/>.</remarks>
    /// <typeparam name="TObject">Must always be <see cref="System.Object"/>.</typeparam>
    public static bool IsObjectNullOrDefault<TObject>(
        [NotNullWhen(true)]
        this TObject? obj)
    {
        if (typeof(TObject) != typeof(object))
            throw new NotSupportedException(
            "Although this method is generic, it is intended to be used on System.Object only. "
            + "There are better alternatives to check for default on specific types.");

        if (obj == null)
            return true; // Null is considered the default for reference types

        var type = obj.GetType();
        if (!type.IsValueType)
            return false; // Non-obj types can't have a default obj

        var defaultValue = DefaultValueByType.GetOrAdd(type, GetDefaultValue);
        return Equals(defaultValue, obj);
    }

    private static readonly ConcurrentDictionary<Type, object> DefaultValueByType = new();

    private static object GetDefaultValue(Type type)
    {
        // Using expressions is more performant than Activator.CreateInstance(type)
        var defaultValueFunc = Expression.Lambda<Func<object>>(
            Expression.Convert(Expression.Default(type), typeof(object))
        ).Compile();

        return defaultValueFunc();
    }
}