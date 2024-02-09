using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Hl7.Cql.Compiler
{
    internal static class Extensions
    {
        public static string OrEmptyString(this string? value)
            => value ?? "";

        public static T[] OrEmptyArray<T>(this T[]? array) 
            => array ?? Array.Empty<T>();

        public static IReadOnlyCollection<T> OrEmptyCollection<T>(this IReadOnlyCollection<T>? collection) 
            => collection ?? Array.Empty<T>();

        public static IEnumerable<T> OrEmptyEnumerable<T>(this IEnumerable<T>? enumerable) 
            => enumerable ?? Enumerable.Empty<T>();

        public static T ArgNotNull<T>(
            [NotNull] this T? value,
            [CallerArgumentExpression(nameof(value))] string valueExpr = "")
        {
            if (value == null)
                throw new ArgumentNullException(valueExpr);
            return value;
        }

        public static T CheckNotNull<T>(
            [NotNull] this T? value, 
            [CallerArgumentExpression(nameof(value))] string valueExpr = "", 
            FormattableString? message = null)
        {
            if (value == null)
                throw new InvalidOperationException(message?.ToString(null) ?? $"Expression '{valueExpr}' must not be null.");
            return value;
        }

        public static string CheckNotNullOrWhitespace(
            [NotNull] this string? value,
            [CallerArgumentExpression(nameof(value))] string valueExpr = "",
            FormattableString? message = null)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new InvalidOperationException(message?.ToString(null) ?? $"Expression '{valueExpr}' must not be null or whitespace.");
            return value;
        }
    }
}
