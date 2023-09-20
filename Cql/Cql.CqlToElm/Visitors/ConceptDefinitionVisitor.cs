using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class ConceptDefinitionVisitor : Visitor<ConceptDef>
    {
        public ConceptDefinitionVisitor(IServiceProvider services) : base(services)
        {
        }

        //: accessModifier? 'concept' identifier ':' '{' codeIdentifier(',' codeIdentifier)* '}' displayClause?
        public override ConceptDef VisitConceptDefinition([NotNull] cqlParser.ConceptDefinitionContext context)
        {
            var conceptDef = new ConceptDef();

            conceptDef.accessLevel = context.accessModifier().Parse();
            conceptDef.name = context.identifier().Parse();
            conceptDef.code = context.codeIdentifier().Select(ci => ci.Parse()).ToArray();
            conceptDef.display = context.displayClause()?.STRING()?.ParseString();

            conceptDef.localId = NextId();
            conceptDef.locator = context.Locator();
            return conceptDef;
        }
    }
}
