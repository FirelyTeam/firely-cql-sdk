using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

using static System.Globalization.CultureInfo;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Contains various check methods for validating arguments and expressions.
/// </summary>
internal static class Check
{
    /// <summary>
    /// Throws an <see cref="ArgumentNullException"/> if the specified value is null; otherwise returns the value.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    /// <param name="value">The value to check.</param>
    /// <param name="valueExpr">The expression representing the value.</param>
    /// <returns>The specified value if it is not null.</returns>
    /// <exception cref="InvalidOperationException">It the specified value is null.</exception>
    public static T ArgNotNull<T>(
        [NotNull] this T? value,
        [CallerArgumentExpression(nameof(value))] string valueExpr = "")
    {
        if (value == null)
            throw new ArgumentNullException(valueExpr);

        return value;
    }

    /// <summary>
    /// Throws an <see cref="InvalidOperationException"/> if the specified value is null; otherwise returns the value.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    /// <param name="value">The value to check.</param>
    /// <param name="message">The optional message to include in the exception.</param>
    /// <param name="valueExpr">The expression representing the value.</param>
    /// <returns>The specified value if it is not null.</returns>
    /// <exception cref="InvalidOperationException">It the specified value is null.</exception>
    public static T NotNull<T>(
        [NotNull] this T? value,
        FormattableString? message = null,
        [CallerArgumentExpression(nameof(value))] string valueExpr = "")
    {
        if (value == null)
            throw new InvalidOperationException(message?.ToString(InvariantCulture) ?? $"Expression '{valueExpr}' must not be null.");

        return value;
    }

    /// <summary>
    /// Throws an <see cref="InvalidOperationException"/> if the specified string is null or whitespace; otherwise returns the value.
    /// </summary>
    /// <param name="value">The string to check.</param>
    /// <param name="message">The optional message to include in the exception.</param>
    /// <param name="valueExpr">The expression representing the string.</param>
    /// <returns>The specified string if it is not null or whitespace.</returns>
    /// <exception cref="InvalidOperationException">It the specified string is null or empty.</exception>
    public static string NotNullOrWhitespace(
        [NotNull] this string? value,
        FormattableString? message = null,
        [CallerArgumentExpression(nameof(value))] string valueExpr = "")
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new InvalidOperationException(message?.ToString(InvariantCulture) ?? $"Expression '{valueExpr}' must not be null or whitespace.");

        return value;
    }
}
