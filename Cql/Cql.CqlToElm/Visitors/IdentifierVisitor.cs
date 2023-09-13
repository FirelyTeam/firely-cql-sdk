using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class IdentifierVisitor: Visitor<string>
    {
        public IdentifierVisitor(IServiceProvider services) : base(services)
        {
        }

        public override string VisitIdentifier([NotNull] cqlParser.IdentifierContext context) =>
            context.GetText().AsSpan().Dequote().ToString();
    }
}
