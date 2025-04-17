/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Runtime.CompilerServices;
using System.Text;

namespace Hl7.Cql.Invocation.Toolkit;

internal static class StringBuilderExtensions
{
    public static StringBuilder RemoveEnd(this StringBuilder sb, int length)
    {
        if (length > 0 && sb.Length >= length)
            sb.Remove(sb.Length - length, length);
        return sb;
    }

    public static StringBuilder AppendMember<T>(
        this StringBuilder sb,
        T value,
        [CallerArgumentExpression(nameof(value))]
        string member = "") =>
        sb.Append(member).Append(": ").Append(value).Append(", ");

    public static StringBuilder AppendMemberIf<T>(
        this StringBuilder sb,
        T value,
        bool condition,
        [CallerArgumentExpression(nameof(value))]
        string member = "") =>
        condition ? sb.AppendMember(value, member) : sb;

    public static StringBuilder StartBrace() => new("{");

    public static string EndBrace(this StringBuilder sb) =>
        sb.RemoveEnd(2).Append("}").ToString();
}