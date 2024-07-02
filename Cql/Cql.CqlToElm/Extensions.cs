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

        public static string Locator(this ParserRuleContext context)
        {
            return context switch
            {
                StringLocatorRuleContext jlr => jlr.Locator,
                _ => $"{context.Start.Line}:{context.Start.Column}-{context.Stop.Line}:{context.Stop.Column}"
            };
        }

        public static string? Locator(this IParseTree pt) => pt is ParserRuleContext ctx ? ctx.Locator() : null;

    }
}
