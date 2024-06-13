/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using Hl7.Cql.Abstractions;

namespace Hl7.Cql.Comparers;

internal class CharCqlComparer(StringCqlComparer inner) : ICqlComparer, ICqlComparer<char?>
{
    public StringCqlComparer Inner { get; } = inner ?? throw new ArgumentNullException(nameof(inner));

    private static string? CharToString(char? c) => c?.ToString();
    private static string? ObjectAsCharToString(object? c) => (c as char?).ToString();

    public int? Compare(object? x, object? y, string? precision = null) =>
        Inner.Compare(ObjectAsCharToString(x), ObjectAsCharToString(y), precision);

    public int? Compare(char? x, char? y, string? precision = null) =>
        Inner.Compare(CharToString(x), CharToString(y), precision);

    public bool? Equals(object? x, object? y, string? precision = null) =>
        Inner.Equals(ObjectAsCharToString(x), ObjectAsCharToString(y), precision);

    public bool? Equals(char? x, char? y, string? precision = null) =>
        Inner.Equals(CharToString(x), CharToString(y), precision);

    public bool Equivalent(object? x, object? y, string? precision = null) =>
        Inner.Equivalent(ObjectAsCharToString(x), ObjectAsCharToString(y), precision);

    public bool Equivalent(char? x, char? y, string? precision = null) =>
        Inner.Equivalent(CharToString(x), CharToString(y), precision);

    public int GetHashCode(object x) =>
        Inner.GetHashCode(ObjectAsCharToString(x));

    public int GetHashCode(char? x) =>
        Inner.GetHashCode(CharToString(x));
}