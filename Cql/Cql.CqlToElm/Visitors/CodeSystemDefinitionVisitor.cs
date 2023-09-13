using Antlr4.Runtime.Misc;
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
    internal class CodeSystemDefinitionVisitor : Visitor<CodeSystemDef>
    {
        public CodeSystemDefinitionVisitor(IServiceProvider isp) : base(isp)
        {
        }

        private AccessModifierVisitor AccessModifierVisitor => Services.GetRequiredService<AccessModifierVisitor>();
        private IdentifierVisitor IdentifierVisitor => Services.GetRequiredService<IdentifierVisitor>();

        //accessModifier? 'codesystem' identifier ':' codesystemId('version' versionSpecifier)?
        public override CodeSystemDef VisitCodesystemDefinition([NotNull] cqlParser.CodesystemDefinitionContext context)
        {
            var codeSystemDef = new CodeSystemDef();
            var index = 1;
            if (context.GetChild(0) is cqlParser.AccessModifierContext amc)
            {
                codeSystemDef.accessLevel = AccessModifierVisitor.Visit(amc);
                index = 2;
            }
            else codeSystemDef.accessLevel = AccessModifier.Public;

            codeSystemDef.name = IdentifierVisitor.Visit(context.GetChild(index));
            index += 2;
            codeSystemDef.id = context.GetChild(index).GetText().AsSpan().Detick().ToString();
            index += 2;
            if (context.children.Count > index)
            {
                codeSystemDef.version = context.GetChild(index).GetText().AsSpan().Detick().ToString();
            }
            codeSystemDef.localId = NextId();
            codeSystemDef.locator = context.Locator();

            return codeSystemDef;
        }
    }
}
