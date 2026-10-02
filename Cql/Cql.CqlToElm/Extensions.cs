/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// This class is a bit of a hack, but most of the time that I need to pass in a ParserRuleContext,
    /// it's just for getting the locator. In some cases, however, I already have a locator, but not the
    /// original ParserRuleContext. This class allows me to pass in an existing locator without having to create
    /// several overloads taking either a ParserRuleContext or a string.
    /// </summary>
    internal class StringLocatorRuleContext : ParserRuleContext
    {
        public StringLocatorRuleContext(string locator) => Locator = locator;

        public string Locator { get; }
    }

    internal static class Extensions
    {

        /// <summary>
        /// The locator of the source text spanned by <paramref name="context"/>: <c>line:char-line:char</c>, with
        /// 1-based characters, running from the first character of the first token through the last character of the
        /// last token, or <c>line:char</c> when that span is a single character.
        /// </summary>
        public static string Locator(this ParserRuleContext context)
        {
            return context switch
            {
                StringLocatorRuleContext jlr => jlr.Locator,
                _ => FormatLocator(
                    context.Start.Line,
                    context.Start.Column + 1,
                    context.Stop.Line,
                    context.Stop.Column + context.Stop.Text.Length)
            };
        }

        /// <summary>
        /// Formats a locator for the span from <paramref name="startLine"/>:<paramref name="startChar"/> through
        /// <paramref name="endLine"/>:<paramref name="endChar"/>, inclusive, with 1-based characters.
        /// </summary>
        public static string FormatLocator(int startLine, int startChar, int endLine, int endChar) =>
            startLine == endLine && startChar == endChar
                ? $"{startLine}:{startChar}"
                : $"{startLine}:{startChar}-{endLine}:{endChar}";

        public static string? Locator(this IParseTree pt) => pt is ParserRuleContext ctx ? ctx.Locator() : null;

    }
}
