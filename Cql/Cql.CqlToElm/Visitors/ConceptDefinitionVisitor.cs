using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class ConceptDefinitionVisitor : Visitor<ConceptDef>
    {
        public ConceptDefinitionVisitor(IServiceProvider services) : base(services)
        {
        }
        private AccessModifierVisitor AccessModifierVisitor => Services.GetRequiredService<AccessModifierVisitor>();
        private CodeIdentifierVisitor CodeIdentifierVisitor => Services.GetRequiredService<CodeIdentifierVisitor>();

        //: accessModifier? 'concept' identifier ':' '{' codeIdentifier(',' codeIdentifier)* '}' displayClause?
        public override ConceptDef VisitConceptDefinition([NotNull] cqlParser.ConceptDefinitionContext context)
        {
            var conceptDef = new ConceptDef();
            var index = 1;
            if (context.GetChild(0) is cqlParser.AccessModifierContext amc)
            {
                conceptDef.accessLevel = AccessModifierVisitor.Visit(amc);
                index = 2;
            }
            else conceptDef.accessLevel = AccessModifier.Public;
            conceptDef.name = context.GetChild(index).GetText().AsSpan().Detick().ToString();
            var firstCodeIndex = index += 3;
            var closingBraceIndex = context.ChildCount - 1;
            var last = context.GetChild(closingBraceIndex);
            if (last is cqlParser.DisplayClauseContext)
            {
                closingBraceIndex -= 1;
                conceptDef.display = last.GetChild(1).GetText().AsSpan().Detick().ToString();
            }
            var codeCount = closingBraceIndex - firstCodeIndex;
            if ((codeCount & 0x1) == 1)
                codeCount = (codeCount >> 1) + 1;
            else 
                codeCount >>= 1;

            conceptDef.code = new CodeRef[codeCount];
            int c = 0;
            for(int i = firstCodeIndex; i < closingBraceIndex; i+=2)
            {
                conceptDef.code[c++] = CodeIdentifierVisitor.Visit(context.GetChild(i));
            }
            
            conceptDef.localId = NextId();
            conceptDef.locator = context.Locator();
            return conceptDef;
        }
    }
}
