/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Microsoft.CodeAnalysis.CSharp;

namespace Hl7.Cql.CodeGeneration.NET;

internal static class StringExtensions
{
    public static string QuoteString(this string s) => SymbolDisplay.FormatLiteral(s, true);

    public static string EscapeKeywords(this string symbol)
    {
        var keyword = SyntaxFacts.GetKeywordKind(symbol);
        return keyword == SyntaxKind.None ? symbol : $"@{symbol}";
    }

    public static string IndentString(int indent) => new('\t', indent);


    public static string ParenthesizeIfNeeded(this string term)
    {
        term = term.Trim();

        if (IsSingleParenthesizedTerm(term))
            return term; // No need to parenthesize if already parenthesized

        // Handles cases such as:
        // 1. ((CqlInterval<CqlDate>)g_)?.lowClosed;
        //     ^-----------------------
        // 2. an_ ?? (at_ as CqlQuantity)?.value
        //    --------------------------^
        if (term.StartsWith('(') ^ term.EndsWith(')'))
            return $"({term})";

        if (term.Any(char.IsWhiteSpace))
            return $"({term})";

        return term;
    }

    // Check whether the term has matching opening and closing parentheses.
    // (so this matches "(a)" but not "(x) + (y)" nor "a + (b) + c").
    private static bool IsSingleParenthesizedTerm(string term)
    {
        var opens = 0;
        for (var index = 0; index < term.Length; index++)
        {
            opens = term[index] switch
            {
                '(' => opens + 1,
                ')' => opens - 1,
                _   => opens
            };

            if (opens == 0)
            {
                return index == term.Length - 1;
            }
        }

        throw new InvalidOperationException($"Unbalanced parentheses in expression '{term}'");
    }

#pragma warning disable SYSLIB0050 // Type or member is obsolete
    private static readonly ObjectIDGenerator Gen = new();
#pragma warning restore SYSLIB0050 // Type or member is obsolete

    public static string GetOrCreateName(ParameterExpression p) => p.Name ?? $"var{Gen.GetId(p, out _)}";
}