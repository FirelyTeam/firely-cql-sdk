using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal partial class ExpressionVisitor
    {
        /*
         * referentialIdentifier
                : identifier
                | keywordIdentifier
                ;      
        */
        public override Expression VisitReferentialIdentifier([NotNull] cqlParser.ReferentialIdentifierContext context)
        {
            var child = context.GetChild(0);
            if (child is cqlParser.IdentifierContext identifierContext)
            {
                var identifier = identifierContext.Parse()
                    ?? throw new InvalidOperationException($"Expecting non-null identifer");
                var @ref = LibraryContext.Ref(null, identifier)?.WithLocator(context.Locator());
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
