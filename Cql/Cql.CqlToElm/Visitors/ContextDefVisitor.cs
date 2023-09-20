using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class ContextDefVisitor : Visitor<ContextDef>
    {
        public ContextDefVisitor(IServiceProvider services) : base(services)
        {
        }

        //    : 'context' (modelIdentifier '.')? identifier
        public override ContextDef VisitContextDefinition([NotNull] cqlParser.ContextDefinitionContext context)
        {
            var child = context.GetChild(1);
            if (child is cqlParser.IdentifierContext identifier)
            {
                var id = identifier.Parse();
                return new ContextDef
                {
                    localId = NextId(),
                    locator = context.Locator(),
                    name = id,
                };
            }
            else if (child is cqlParser.QualifiedIdentifierContext qualifiedIdentifier)
            {

            }
            throw Critical("Invalid context declaration");
        }

    }
}
