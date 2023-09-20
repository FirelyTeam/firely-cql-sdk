using Antlr4.Runtime.Tree;
using Hl7.Cql.CqlToElm.Grammar;
using System;
using System.Text.RegularExpressions;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal static class TerminalParsers
    {
        public static string? ParseIdentifier(this ITerminalNode? terminal)
        {
            if (terminal is null) return null;
            if (terminal.Symbol.Type != cqlParser.IDENTIFIER)
                throw new InvalidOperationException($"Expected IDENTIFIER token, got {terminal.Symbol.Type}");

            return terminal.Symbol.Text;
        }

        public static string? ParseQuotedIdentifier(this ITerminalNode? terminal)
        {
            if (terminal is null) return null;
            if (terminal.Symbol.Type != cqlParser.QUOTEDIDENTIFIER)
                throw new InvalidOperationException($"Expected QUOTEDIDENTIFIER token, got {terminal.Symbol.Type}");

            var str = terminal.Symbol.Text;
            if (str[0] == '\"' && str[^1] == '\"')
                str = str[1..^1];
            else
                throw new InvalidOperationException("Expected QUOTEDIDENTIFIER token to start and end with double quote.");

            return Regex.Unescape(str);
        }

        public static string? ParseDelimitedIdentifier(this ITerminalNode? terminal)
        {
            if (terminal is null) return null;
            if (terminal.Symbol.Type != cqlParser.DELIMITEDIDENTIFIER)
                throw new InvalidOperationException($"Expected DELIMITEDIDENTIFIER token, got {terminal.Symbol.Type}");

            var str = terminal.Symbol.Text;
            if (str[0] == '`' && str[^1] == '`')
                str = str[1..^1];
            else
                throw new InvalidOperationException("Expected DELIMITEDIDENTIFIER token to start and end with a backtick.");

            return Regex.Unescape(str);
        }
        public static string? ParseString(this ITerminalNode? terminal)
        {
            if (terminal is null) return null;
            if (terminal.Symbol.Type != cqlParser.STRING)
                throw new InvalidOperationException($"Expected STRING token, got {terminal.Symbol.Type}");

            var str = terminal.Symbol.Text;
            if (str[0] == '\'' && str[^1] == '\'')
                str = str[1..^1];
            else
                throw new InvalidOperationException("Expected STRING token to start and end with single quote.");

            return Regex.Unescape(str);
        }
    }
}
