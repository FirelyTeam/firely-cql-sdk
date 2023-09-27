using Antlr4.Runtime.Tree;
using Hl7.Cql.CqlToElm.Grammar;
using System;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal static class Keyword
    {
        public static CqlKeyword[] Parse(this cqlParser.KeywordContext context)
        {
            var text = context.GetText();
            return Parse(text);
        }

        public static CqlKeyword[] Parse(IParseTree tree) => Parse(tree.GetText());

        public static CqlKeyword[] Parse(string text)
        {
            var parts = text.Split(' ');
            var keywords = parts
                .Select(part =>
                {
                    if (Enum.TryParse<CqlKeyword>(part, true, out var keyword))
                        return keyword;
                    else throw new NotImplementedException($"Keyword '{part}' is not understood");
                })
                .ToArray();
            return keywords;
        }
    }
}
