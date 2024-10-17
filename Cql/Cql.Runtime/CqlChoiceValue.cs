using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Runtime;

/// <summary>
/// Represents a choice type that can hold a value of any of the specified types.
/// </summary>
public class CqlChoiceValue
{
    /// <summary>
    /// Gets or sets the value of the choice type.
    /// </summary>
    public object? Value { get; init; }

    /// <summary>
    /// Creates a choice type based on the specified choice types.
    /// </summary>
    /// <param name="choiceTypes">The array of choice types.</param>
    /// <returns>The created choice type.</returns>
    public static Type MakeChoiceType(Type[] choiceTypes) =>
        choiceTypes.Length switch
        {
            // This could be better distributed, but it's not worth the effort
            0 => throw new ArgumentException("At least one choice type must be provided.", nameof(choiceTypes)),
            1 => typeof(CqlChoiceValue<>).MakeGenericType(choiceTypes),
            2 => typeof(CqlChoiceValue<,>).MakeGenericType(choiceTypes),
            3 => typeof(CqlChoiceValue<,,>).MakeGenericType(choiceTypes),
            4 => typeof(CqlChoiceValue<,,,>).MakeGenericType(choiceTypes),
            5 => typeof(CqlChoiceValue<,,,,>).MakeGenericType(choiceTypes),
            6 => typeof(CqlChoiceValue<,,,,,>).MakeGenericType(choiceTypes),
            7 => typeof(CqlChoiceValue<,,,,,,>).MakeGenericType(choiceTypes),
            8 => typeof(CqlChoiceValue<,,,,,,,>).MakeGenericType(choiceTypes),
            _ => typeof(CqlChoiceValue<,,,,,,,>).MakeGenericType([.. choiceTypes[..7], MakeChoiceType(choiceTypes[8..])])
        };
}

/// <summary>
/// Represents a choice type with a single choice.
/// </summary>
/// <typeparam name="T1">The type of the choice.</typeparam>
public class CqlChoiceValue<T1> : CqlChoiceValue { }

/// <summary>
/// Represents a choice type with two choices.
/// </summary>
/// <typeparam name="T1">The type of the first choice.</typeparam>
/// <typeparam name="T2">The type of the second choice.</typeparam>
public class CqlChoiceValue<T1, T2> : CqlChoiceValue<T1> { }

/// <summary>
/// Represents a choice type with three choices.
/// </summary>
/// <typeparam name="T1">The type of the first choice.</typeparam>
/// <typeparam name="T2">The type of the second choice.</typeparam>
/// <typeparam name="T3">The type of the third choice.</typeparam>
public class CqlChoiceValue<T1, T2, T3> : CqlChoiceValue<T1, T2> { }

/// <summary>
/// Represents a choice type with four choices.
/// </summary>
/// <typeparam name="T1">The type of the first choice.</typeparam>
/// <typeparam name="T2">The type of the second choice.</typeparam>
/// <typeparam name="T3">The type of the third choice.</typeparam>
/// <typeparam name="T4">The type of the fourth choice.</typeparam>
public class CqlChoiceValue<T1, T2, T3, T4> : CqlChoiceValue<T1, T2, T3> { }

/// <summary>
/// Represents a choice type with five choices.
/// </summary>
/// <typeparam name="T1">The type of the first choice.</typeparam>
/// <typeparam name="T2">The type of the second choice.</typeparam>
/// <typeparam name="T3">The type of the third choice.</typeparam>
/// <typeparam name="T4">The type of the fourth choice.</typeparam>
/// <typeparam name="T5">The type of the fifth choice.</typeparam>
public class CqlChoiceValue<T1, T2, T3, T4, T5> : CqlChoiceValue<T1, T2, T3, T4> { }

/// <summary>
/// Represents a choice type with six choices.
/// </summary>
/// <typeparam name="T1">The type of the first choice.</typeparam>
/// <typeparam name="T2">The type of the second choice.</typeparam>
/// <typeparam name="T3">The type of the third choice.</typeparam>
/// <typeparam name="T4">The type of the fourth choice.</typeparam>
/// <typeparam name="T5">The type of the fifth choice.</typeparam>
/// <typeparam name="T6">The type of the sixth choice.</typeparam>
public class CqlChoiceValue<T1, T2, T3, T4, T5, T6> : CqlChoiceValue<T1, T2, T3, T4, T5> { }

/// <summary>
/// Represents a choice type with seven choices.
/// </summary>
/// <typeparam name="T1">The type of the first choice.</typeparam>
/// <typeparam name="T2">The type of the second choice.</typeparam>
/// <typeparam name="T3">The type of the third choice.</typeparam>
/// <typeparam name="T4">The type of the fourth choice.</typeparam>
/// <typeparam name="T5">The type of the fifth choice.</typeparam>
/// <typeparam name="T6">The type of the sixth choice.</typeparam>
/// <typeparam name="T7">The type of the seventh choice.</typeparam>
public class CqlChoiceValue<T1, T2, T3, T4, T5, T6, T7> : CqlChoiceValue<T1, T2, T3, T4, T5, T6> { }

/// <summary>
/// Represents a choice type with eight choices.
/// </summary>
/// <typeparam name="T1">The type of the first choice.</typeparam>
/// <typeparam name="T2">The type of the second choice.</typeparam>
/// <typeparam name="T3">The type of the third choice.</typeparam>
/// <typeparam name="T4">The type of the fourth choice.</typeparam>
/// <typeparam name="T5">The type of the fifth choice.</typeparam>
/// <typeparam name="T6">The type of the sixth choice.</typeparam>
/// <typeparam name="T7">The type of the seventh choice.</typeparam>
/// <typeparam name="T8">The type of the eighth choice.</typeparam>
public class CqlChoiceValue<T1, T2, T3, T4, T5, T6, T7, T8> : CqlChoiceValue<T1, T2, T3, T4, T5, T6, T7> { }

internal static class CqlChoiceValueExtensions
{
    /// <summary>
    /// Determines whether the specified type is a choice type.
    /// </summary>
    /// <param name="type">The type to check.</param>
    /// <returns><c>true</c> if the type is a choice type; otherwise, <c>false</c>.</returns>
    public static bool IsChoiceType(this Type type) =>
        type.IsAssignableTo(typeof(CqlChoiceValue));
}



