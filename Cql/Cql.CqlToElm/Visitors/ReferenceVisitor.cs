using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal partial class ExpressionVisitor
    {    
        //  identifier | keywordIdentifier
        public override Expression VisitReferentialIdentifier([NotNull] cqlParser.ReferentialIdentifierContext context)
        {           
            if (context.identifier() is {} identifierContext)
            {
                var identifier = identifierContext.Parse()!;
                var @ref = LibraryContext.Ref(null, identifier)?.WithLocator(context.Locator());
                if (@ref != null)
                    return @ref;
                else
                    throw new InvalidOperationException($"Unable to resolve identifier {identifier}");
            }
            else if (context.keywordIdentifier() is {} qualifiedIdentifierContext)
            {
                throw new NotImplementedException();
            }
            else
                throw new InvalidOperationException($"Unexpected referential identifier child");
        }
    }
}
