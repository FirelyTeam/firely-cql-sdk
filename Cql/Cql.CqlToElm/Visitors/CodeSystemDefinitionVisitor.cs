using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class CodeSystemDefinitionVisitor : Visitor<CodeSystemDef>
    {
        public CodeSystemDefinitionVisitor(IServiceProvider isp) : base(isp)
        {
        }


        //accessModifier? 'codesystem' identifier ':' codesystemId('version' versionSpecifier)?
        public override CodeSystemDef VisitCodesystemDefinition([NotNull] cqlParser.CodesystemDefinitionContext context)
        {
            var codeSystemDef = new CodeSystemDef();

            codeSystemDef.accessLevel = context.accessModifier().Parse();
            codeSystemDef.name = context.identifier().Parse();
            codeSystemDef.id = context.codesystemId().STRING().ParseString();
            codeSystemDef.version = context.versionSpecifier()?.STRING()?.ParseString();

            codeSystemDef.localId = NextId();
            codeSystemDef.locator = context.Locator();

            return codeSystemDef;
        }
    }
}
