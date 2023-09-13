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
    internal class CodeDefinitionVisitor : Visitor<CodeDef>
    {
        public CodeDefinitionVisitor(IServiceProvider services) : base(services)
        {
        }
        private AccessModifierVisitor AccessModifierVisitor => Services.GetRequiredService<AccessModifierVisitor>();
        private CodeSystemIdentifierVisitor CodeSystemIdentifierVisitor => Services.GetRequiredService<CodeSystemIdentifierVisitor>();
        private IdentifierVisitor IdentifierVisitor => Services.GetRequiredService<IdentifierVisitor>();



        //: accessModifier? 'code' identifier ':' codeId 'from' codesystemIdentifier displayClause?
        public override CodeDef VisitCodeDefinition([NotNull] cqlParser.CodeDefinitionContext context)
        {
            var codeDef = new CodeDef();
            var index = 1;
            if (context.GetChild(0) is cqlParser.AccessModifierContext amc)
            {
                codeDef.accessLevel = AccessModifierVisitor.Visit(amc);
                index = 2;
            }
            else codeDef.accessLevel = AccessModifier.Public;

            codeDef.name = IdentifierVisitor.Visit(context.GetChild(index));
            index += 2;
            codeDef.id = context.GetChild(index).GetText().AsSpan().Detick().ToString();
            index += 2;
            codeDef.codeSystem = CodeSystemIdentifierVisitor.Visit(context.GetChild(index));
            index += 1;
            if (index < context.ChildCount)
            {
                var display = context.GetChild(index);
                codeDef.display = display.GetChild(1).GetText().AsSpan().Detick().ToString(); 
            }

            codeDef.localId = NextId();
            codeDef.locator = context.Locator();
            return codeDef;
        }
    }
}
