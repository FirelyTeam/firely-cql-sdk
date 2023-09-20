using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;

namespace Hl7.Cql.CqlToElm
{
    internal static class Extensions
    {
        public static string GetStringLiteral(this IParseTree tree)
        {
            return tree.GetText().AsSpan().Detick().ToString();
        }

        public static ReadOnlySpan<char> Detick(this ReadOnlySpan<char> str)
        {
            if (str[0] == '\'' && str[^1] == '\'')
                return str[1..^1];
            else return str;
        }

        public static ReadOnlySpan<char> Dequote(this ReadOnlySpan<char> str)
        {
            if (str[0] == '"' && str[^1] == '"')
                return str[1..^1];
            else return str;
        }

        public static string Locator(this ParserRuleContext ctx) =>
            $"{ctx.Start.Line}:{ctx.Start.Column}-{ctx.Stop.Line}:{ctx.Stop.Column}";

        public static string? Locator(this IParseTree pt)
        {
            if (pt is ParserRuleContext ctx)
                return $"{ctx.Start.Line}:{ctx.Start.Column}-{ctx.Stop.Line}:{ctx.Stop.Column}";
            return null;
        }

    }

}
