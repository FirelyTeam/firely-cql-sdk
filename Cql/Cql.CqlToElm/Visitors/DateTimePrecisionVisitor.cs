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
    internal class DateTimePrecisionVisitor : Visitor<DateTimePrecision?>
    {
        public DateTimePrecisionVisitor(IServiceProvider services) : base(services)
        {
        }

        public override DateTimePrecision? VisitDateTimePrecision([NotNull] cqlParser.DateTimePrecisionContext context) =>
            context.GetText() switch
            {
                "year" => DateTimePrecision.Year,
                "month" => DateTimePrecision.Month,
                "week" => DateTimePrecision.Week,
                "day" => DateTimePrecision.Day,
                "hour" => DateTimePrecision.Hour,
                "minute" => DateTimePrecision.Minute,
                "second" => DateTimePrecision.Second,
                "millisecond" => DateTimePrecision.Millisecond,
                _ => null
            };
    }
}
