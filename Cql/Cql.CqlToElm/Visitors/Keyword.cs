using System;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal static class Keyword
    {
        public static CqlKeyword[] Parse(string text)
        {
            var parts = text.Split(' ');
            var keywords = parts
                .Select(part =>
                {
                    if (Enum.TryParse<CqlKeyword>(part, true, out var keyword))
                        return keyword;
                    else throw new InvalidOperationException($"Parser returned unrecognized keyword '{part}'.");
                })
                .ToArray();
            return keywords;
        }
    }
}
