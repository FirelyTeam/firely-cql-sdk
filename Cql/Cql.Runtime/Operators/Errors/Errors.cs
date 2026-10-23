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
/// An <see cref="ICqlEvaluationError"/> raised when the <c>singleton from</c> operator is applied to a
/// list with more than one element.
/// </summary>
/// <remarks>
/// Per the CQL specification (§9.B, Singleton From), "If the list contains more than one element,
/// a run-time error is thrown."
/// </remarks>
public readonly record struct CqlSingletonFromMultipleElementsError : ICqlEvaluationError
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

/// <summary>
/// An <see cref="ICqlEvaluationError"/> raised when the Date, DateTime or Time operator is given components that do
/// not form a value of that type.
/// </summary>
/// <remarks>
/// Per the CQL specification (Appendix B - CQL Reference, sections "Date", "DateTime" and "Time" under "Types"), "CQL
/// supports date values in the range @0001-01-01 to @9999-12-31", DateTime values "in the range
/// @0001-01-01T00:00:00.0 to @9999-12-31T23:59:59.999" and time values "in the range @T00:00:00.0 to @T23:59:59.999";
/// the operators of the same names (section "Date and Time Operators") add that "no component may be specified at a
/// precision below an unspecified precision". Components outside those bounds are invalid input, which signals an
/// error to the calling environment rather than resulting in null.
/// </remarks>
public readonly record struct CqlInvalidDateTimeComponentsError : ICqlEvaluationError
{
    internal CqlInvalidDateTimeComponentsError(
        string type,
        int? year,
        int? month,
        int? day,
        int? hour,
        int? minute,
        int? second,
        int? millisecond,
        decimal? timezoneOffset)
    {
        Type = type;
        Year = year;
        Month = month;
        Day = day;
        Hour = hour;
        Minute = minute;
        Second = second;
        Millisecond = millisecond;
        TimezoneOffset = timezoneOffset;
    }

    /// <summary>The CQL type being constructed: <c>Date</c>, <c>DateTime</c> or <c>Time</c>.</summary>
    public string Type { get; }

    /// <summary>The year component, or <see langword="null"/> when not given.</summary>
    public int? Year { get; }

    /// <summary>The month component, or <see langword="null"/> when not given.</summary>
    public int? Month { get; }

    /// <summary>The day component, or <see langword="null"/> when not given.</summary>
    public int? Day { get; }

    /// <summary>The hour component, or <see langword="null"/> when not given.</summary>
    public int? Hour { get; }

    /// <summary>The minute component, or <see langword="null"/> when not given.</summary>
    public int? Minute { get; }

    /// <summary>The second component, or <see langword="null"/> when not given.</summary>
    public int? Second { get; }

    /// <summary>The millisecond component, or <see langword="null"/> when not given.</summary>
    public int? Millisecond { get; }

    /// <summary>The timezone offset in hours, or <see langword="null"/> when not given.</summary>
    public decimal? TimezoneOffset { get; }

    /// <inheritdoc/>
    public string GetMessage()
    {
        var components = new (string Name, object? Value)[]
            {
                ("year", Year), ("month", Month), ("day", Day), ("hour", Hour), ("minute", Minute),
                ("second", Second), ("millisecond", Millisecond), ("timezone offset", TimezoneOffset),
            }
            .Where(c => c.Value is not null)
            .Select(c => string.Create(CultureInfo.InvariantCulture, $"{c.Name} {c.Value}"));
        return $"The components {string.Join(", ", components)} do not form a valid {Type}: each component must lie "
            + "within the range of the type, and no component may be given below one that is not.";
    }
}

/// <summary>
/// An <see cref="ICqlEvaluationError"/> raised when an interval of Integer or Long, or a list of them, is expanded by
/// a per whose value has a decimal portion.
/// </summary>
/// <remarks>
/// Per the CQL specification (Appendix B - CQL Reference, section "Interval Operators", "Expand"), "The expand operator
/// returns the set of intervals of size per for all the intervals in the input, or the list of points covering the
/// range of the given interval, if invoked on a single interval", and "For numeric intervals, adding the per to the
/// lower boundary produces a more precise value for the output intervals". A per with a decimal portion therefore
/// produces Decimal points, which the Integer and Long overloads cannot return, so the expansion signals an error to
/// the calling environment.
/// </remarks>
public readonly record struct CqlExpandFractionalPerError : ICqlEvaluationError
{
    internal CqlExpandFractionalPerError(decimal perValue, string? perUnit, string pointType)
    {
        PerValue = perValue;
        PerUnit = perUnit;
        PointType = pointType;
    }

    /// <summary>The value of the per quantity.</summary>
    public decimal PerValue { get; }

    /// <summary>The unit of the per quantity, or <see langword="null"/> when it has none.</summary>
    public string? PerUnit { get; }

    /// <summary>The CQL point type of the expanded interval: <c>Integer</c> or <c>Long</c>.</summary>
    public string PointType { get; }

    /// <inheritdoc/>
    public string GetMessage() =>
        string.Create(CultureInfo.InvariantCulture,
            $"Expanding an interval of {PointType} per {PerValue} '{PerUnit ?? "1"}' would produce Decimal points, which the {PointType} overloads of expand do not support: ")
        + "the specification defines the result as \"the list of points covering the range of the given interval\" in steps of size per, "
        + "and \"for numeric intervals, adding the per to the lower boundary produces a more precise value\".";
}

/// <summary>
/// An <see cref="ICqlEvaluationError"/> raised when the <c>point from</c> operator is applied to an
/// interval that is not a unit interval.
/// </summary>
/// <remarks>
/// Per the CQL specification (§9.B, Point From), extracting a point from an interval that is not
/// a unit interval signals an error to the calling environment. A null closed boundary is
/// the minimum or maximum value of the point type, so an interval with two of them spans the
/// whole domain.
/// </remarks>
public readonly record struct CqlPointFromNonUnitIntervalError : ICqlEvaluationError
{
    internal CqlPointFromNonUnitIntervalError(
        object? low,
        object? high,
        bool lowClosed,
        bool highClosed)
    {
        Low = low;
        High = high;
        LowClosed = lowClosed;
        HighClosed = highClosed;
    }

    /// <summary>The interval's low boundary value.</summary>
    public object? Low { get; }

    /// <summary>The interval's high boundary value.</summary>
    public object? High { get; }

    /// <summary>Whether the interval's low boundary is closed.</summary>
    public bool LowClosed { get; }

    /// <summary>Whether the interval's high boundary is closed.</summary>
    public bool HighClosed { get; }

    /// <inheritdoc/>
    public string GetMessage() =>
        "The point from operator requires a unit interval, but was given " +
        $"{(LowClosed ? "[" : "(")}{Low?.ToString() ?? "null"}, {High?.ToString() ?? "null"}{(HighClosed ? "]" : ")")}.";
}
