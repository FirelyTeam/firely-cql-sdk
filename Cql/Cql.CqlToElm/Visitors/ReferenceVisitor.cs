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
    partial class ExpressionVisitor
    {
        public override Expression VisitReferentialIdentifier([NotNull] cqlParser.ReferentialIdentifierContext context)
        {
            var child = context.GetChild(0);
            if (child is cqlParser.IdentifierContext identifierContext)
            {
                var identifier = IdentifierVisitor.Visit(child)
                    ?? throw new InvalidOperationException($"Expecting non-null identifer");
                var @ref = LibraryContext.Ref(null, identifier, identifierContext);
                if (@ref != null)
                    return @ref;
                else
                    throw Critical($"Unable to resolve identifier {identifier}");
            }
            else if (child is cqlParser.QualifiedIdentifierContext qualifiedIdentifierContext)
            {
                throw new NotImplementedException();
            }
            else
                throw new InvalidOperationException($"Unexpected referential identifier child");
        }
    }
}
