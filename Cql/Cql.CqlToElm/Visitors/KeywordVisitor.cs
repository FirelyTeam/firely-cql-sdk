using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class KeywordVisitor: Visitor<CqlKeyword[]>
    {
        public KeywordVisitor(IServiceProvider services) : base(services)
        {
        }

        public override CqlKeyword[] VisitKeyword([NotNull] cqlParser.KeywordContext context)
        {
            var text = context.GetText();
            return Parse(text);
        }

        public CqlKeyword[] Parse(string text)
        {
            var parts = text.Split(' ');
            var keywords = parts
                .Select(part =>
                {
                    if (Enum.TryParse<CqlKeyword>(part, true, out var keyword))
                        return keyword;
                    else throw Critical($"Keyword {part} is not understood");
                })
                .ToArray();
            return keywords;
        }
    }
}
