using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace Hl7.Cql.CqlToElm
{
    internal static class Extensions
    {

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
