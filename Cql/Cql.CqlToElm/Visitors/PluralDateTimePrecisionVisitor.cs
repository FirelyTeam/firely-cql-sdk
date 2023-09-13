using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class PluralDateTimePrecisionVisitor : Visitor<DateTimePrecision?>
    {
        public PluralDateTimePrecisionVisitor(IServiceProvider services) : base(services)
        {
        }

        public override DateTimePrecision? VisitPluralDateTimePrecision([NotNull] cqlParser.PluralDateTimePrecisionContext context) =>
            context.GetText() switch
            {
                "years" => DateTimePrecision.Year,
                "months" => DateTimePrecision.Month,
                "weeks" => DateTimePrecision.Week,
                "days" => DateTimePrecision.Day,
                "hours" => DateTimePrecision.Hour,
                "minutes" => DateTimePrecision.Minute,
                "seconds" => DateTimePrecision.Second,
                "milliseconds" => DateTimePrecision.Millisecond,
                _ => null
            };
    }
}
