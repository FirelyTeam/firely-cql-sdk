using Antlr4.Runtime.Tree;
using System;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal static class Keyword
    {
        public static CqlKeyword? ParseKeyword(this IParseTree tree)
        {
            var text = tree.GetText().Replace(' ', '_');
            return Enum.TryParse<CqlKeyword>(text, ignoreCase: true, out var keyword) ? keyword : null;
        }
    }
}
