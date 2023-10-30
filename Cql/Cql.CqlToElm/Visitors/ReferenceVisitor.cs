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
            string? identifier;

            if (context.identifier() is { } identifierContext)
                identifier = identifierContext.Parse()!;
            else if (context.keywordIdentifier() is { } kwi)
                identifier = kwi.GetText();
            else
                throw new InvalidOperationException($"Unexpected referential identifier child.");

            var reference = LibraryContext.Ref(null, identifier);
            reference ??= new Null { resultTypeSpecifier = SystemTypes.AnyType }
                .AddError("Unable to resolve identifier {identifier}.", ErrorType.semantic);

            return reference.WithLocator(context.Locator());
        }
    }
}
