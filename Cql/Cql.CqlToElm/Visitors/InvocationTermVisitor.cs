using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal partial class ExpressionVisitor
    {
        public override Expression VisitReferentialIdentifier([NotNull] cqlParser.ReferentialIdentifierContext context)
        {
            var identifier = context.Parse();

            var success = LibraryBuilder.CurrentScope!.TryGetRef(null, identifier, out var definitionRef);
            var result = definitionRef ?? new Null { resultTypeSpecifier = SystemTypes.AnyType };

            if (!success)
                result.AddError($"Unable to resolve identifier {identifier}.", ErrorType.semantic);

            return result.WithLocator(context.Locator());
        }

        // : referentialIdentifier             #memberInvocation
        public override Expression VisitMemberInvocation([NotNull] cqlParser.MemberInvocationContext context)
        {
            // Note: this rule is a misnomer, as it is not meant to retrieve a member in a path expression, but is called when we're
            // dealing with the beginning of a path, or just a single "reference" to a definition.
            // We need some smarts here to make this work in context, since this CAN also be parsed as the qualifier in a path
            // when the root of the path starts with a qualifier, not a definition.
            return Visit(context.referentialIdentifier());
        }

        // | function                          #functionInvocation
        public override Expression VisitFunctionInvocation([NotNull] cqlParser.FunctionInvocationContext context)
        {
            throw new NotImplementedException("Function invocations not yet implemented.");
        }

        // | '$this'                           #thisInvocation
        public override Expression VisitThisInvocation([NotNull] cqlParser.ThisInvocationContext context)
        {
            throw new NotImplementedException("$this invocations not yet implemented.");
        }

        // | '$index'                          #indexInvocation
        public override Expression VisitIndexInvocation([NotNull] cqlParser.IndexInvocationContext context)
        {
            throw new NotImplementedException("$index invocations not yet implemented.");
        }

        // | '$total'                          #totalInvocation
        public override Expression VisitTotalInvocation([NotNull] cqlParser.TotalInvocationContext context)
        {
            throw new NotImplementedException("$total invocations not yet implemented.");
        }
    }

}
