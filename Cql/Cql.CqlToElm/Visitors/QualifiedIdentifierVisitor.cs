using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class QualifiedIdentifierVisitor: Visitor<(string qualifier, string id)>
    {
        public QualifiedIdentifierVisitor(IServiceProvider services) : base(services)
        {
        }

        public override (string qualifier, string id) VisitQualifiedIdentifier([NotNull] cqlParser.QualifiedIdentifierContext context)
        {
            if (context.ChildCount == 3)
                return (context.GetChild(0).GetText(), context.GetChild(2).GetText());
            else return (string.Empty, context.GetChild(0).GetText());

        }

    }
}
