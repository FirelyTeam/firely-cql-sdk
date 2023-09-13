using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class QuantityVisitor: Visitor<(decimal value, string unit)>
    {

        public QuantityVisitor(IServiceProvider services) : base(services)
        {
        }

        private static readonly Dictionary<string, string> QuantityKeywords = new Dictionary<string, string>
        {
            { "year", "a" },
            { "years", "a" },
            { "month", "mo" },
            { "months", "mo" },
            { "week", "wk" },
            { "weeks", "wk" },
            { "day", "d" },
            { "days", "d" },
            { "hour", "h" },
            { "hours", "h" },
            { "minute", "min" },
            { "minutes", "min" },
            { "second", "s" },
            { "seconds", "s" },
            { "millisecond", "ms" },
            { "milliseconds", "ms" },
        };


        public override (decimal value, string unit) VisitQuantity([NotNull] cqlParser.QuantityContext context)
        {
            var value = context.GetChild(0).GetText();
            if (!decimal.TryParse(value, out var decimalValue))
                throw Critical($"Value {value} is not a valid decimal.");

            var unitText = context.GetChild(1).GetText();
            if (!QuantityKeywords.TryGetValue(unitText, out var unit))
                unit = unitText.AsSpan().Detick().ToString();

            return (decimalValue, unit);
        }
    }
}
