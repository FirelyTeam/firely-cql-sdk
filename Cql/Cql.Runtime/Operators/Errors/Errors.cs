/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Exceptions;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Operators.Errors;

/// <summary>
/// An <see cref="ICqlError"/> raised when the <c>singleton from</c> operator is applied to a
/// list with more than one element.
/// </summary>
/// <remarks>
/// Per the CQL specification (§9.B, Singleton From), "If the list contains more than one element,
/// a run-time error is thrown."
/// </remarks>
public readonly record struct CqlSingletonFromMultipleElementsError : ICqlError
{
    internal CqlSingletonFromMultipleElementsError(
        int elementCount,
        Type elementType)
    {
        ElementCount = elementCount;
        ElementType = elementType;
    }

    /// <summary>The number of elements in the list.</summary>
    public int ElementCount { get; }

    /// <summary>The declared element type of the list.</summary>
    public Type ElementType { get; }

    /// <inheritdoc/>
    public string GetMessage() =>
        "The singleton from operator requires a list with at most one element, " +
        $"but was given a list of {ElementCount} {RenderElementTypeName(ElementType)} elements. " +
        "Use First or Last to take one element, or filter the list so that at most one element remains.";

    private static readonly Type[] ListTypeDefinitions =
    [
        typeof(IEnumerable<>),
        typeof(ICollection<>),
        typeof(IList<>),
        typeof(IReadOnlyCollection<>),
        typeof(IReadOnlyList<>),
        typeof(List<>),
    ];

    private static string RenderElementTypeName(Type type)
    {
        var nonNullableType = Nullable.GetUnderlyingType(type) ?? type;
        if (nonNullableType == typeof(object))
            return "Any";
        if (nonNullableType.IsEnum)
            return nonNullableType.Name;

        switch (Type.GetTypeCode(nonNullableType))
        {
            case TypeCode.Boolean: return "Boolean";
            case TypeCode.Int32: return "Integer";
            case TypeCode.Int64: return "Long";
            case TypeCode.Decimal: return "Decimal";
            case TypeCode.String: return "String";
        }

        if (nonNullableType.IsCqlInterval(out var pointType))
            return $"Interval<{RenderElementTypeName(pointType)}>";
        if (nonNullableType.IsCqlValueTuple() || nonNullableType.IsTupleBaseType())
            return "Tuple";
        if (nonNullableType.IsArray)
            return $"List<{RenderElementTypeName(nonNullableType.GetElementType()!)}>";
        if (nonNullableType.IsGenericType && ListTypeDefinitions.Contains(nonNullableType.GetGenericTypeDefinition()))
            return $"List<{RenderElementTypeName(nonNullableType.GetGenericArguments()[0])}>";
        if (nonNullableType.GetCustomAttribute<CqlPrimitiveTypeAttribute>() is { } primitive)
            return primitive.Type.ToString();

        var name = nonNullableType.Name;
        var arityIndex = name.IndexOf('`');
        if (arityIndex >= 0)
            name = name.Substring(0, arityIndex);
        return nonNullableType is { IsNested: true, DeclaringType: { } owner } ? $"{owner.Name}.{name}" : name;
    }
}
