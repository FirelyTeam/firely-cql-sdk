/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Exceptions;

namespace Hl7.Cql.Primitives;

/// <summary>
/// An <see cref="ICqlArithmeticError"/> raised when the UCUM year unit <c>"a"</c> is used
/// in a date/time arithmetic calculation.
/// </summary>
/// <remarks>
/// Per the CQL specification (§3232) and FHIRPath semantics, the UCUM unit <c>"a"</c> is a
/// definite-duration quantity. Using it above days in date/time arithmetic will end evaluation
/// and signal an error. Use the calendar duration unit <c>"year"</c> or <c>"years"</c> instead.
/// </remarks>
public readonly record struct CqlUcumYearArithmeticError : ICqlArithmeticError
{
    /// <inheritdoc/>
    public string GetMessage() =>
        "If a definite-duration time-valued unit above days (or weeks) appears in a date/time arithmetic calculation, " +
        "the evaluation will end and signal an error to the calling environment. " +
        "Use 'year' or 'years' instead of UCUM unit 'a'.";
}

/// <summary>
/// An <see cref="ICqlArithmeticError"/> raised when the UCUM month unit <c>"mo"</c> is used
/// in a date/time arithmetic calculation.
/// </summary>
/// <remarks>
/// Per the CQL specification (§3232) and FHIRPath semantics, the UCUM unit <c>"mo"</c> is a
/// definite-duration quantity. Using it above days in date/time arithmetic will end evaluation
/// and signal an error. Use the calendar duration unit <c>"month"</c> or <c>"months"</c> instead.
/// </remarks>
public readonly record struct CqlUcumMonthArithmeticError : ICqlArithmeticError
{
    /// <inheritdoc/>
    public string GetMessage() =>
        "If a definite-duration time-valued unit above days (or weeks) appears in a date/time arithmetic calculation, " +
        "the evaluation will end and signal an error to the calling environment. " +
        "Use 'month' or 'months' instead of UCUM unit 'mo'.";
}

/// <summary>
/// An <see cref="ICqlError"/> raised when the <c>point from</c> operator is applied to an
/// interval that is not a unit interval.
/// </summary>
/// <remarks>
/// Per the CQL specification (§9.B, Point From), extracting a point from an interval that is not
/// a unit interval signals an error to the calling environment. A null closed boundary is
/// the minimum or maximum value of the point type, so an interval with two of them spans the
/// whole domain.
/// </remarks>
/// <param name="Low">The interval's low boundary value.</param>
/// <param name="High">The interval's high boundary value.</param>
/// <param name="LowClosed">Whether the interval's low boundary is closed.</param>
/// <param name="HighClosed">Whether the interval's high boundary is closed.</param>
public readonly record struct CqlPointFromNonUnitIntervalError(
    object? Low,
    object? High,
    bool LowClosed,
    bool HighClosed) : ICqlError
{
    /// <inheritdoc/>
    public string GetMessage() =>
        "The point from operator requires a unit interval, but was given " +
        $"{(LowClosed ? "[" : "(")}{Low?.ToString() ?? "null"}, {High?.ToString() ?? "null"}{(HighClosed ? "]" : ")")}.";
}

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
