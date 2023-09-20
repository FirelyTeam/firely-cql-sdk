using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class CodeSystemDefinitionVisitor : Visitor<CodeSystemDef>
    {
        public CodeSystemDefinitionVisitor(IServiceProvider isp) : base(isp)
        {
        }

        private IdentifierVisitor IdentifierVisitor => Services.GetRequiredService<IdentifierVisitor>();

        //accessModifier? 'codesystem' identifier ':' codesystemId('version' versionSpecifier)?
        public override CodeSystemDef VisitCodesystemDefinition([NotNull] cqlParser.CodesystemDefinitionContext context)
        {
            var codeSystemDef = new CodeSystemDef();

            codeSystemDef.accessLevel = context.accessModifier().Parse();
            codeSystemDef.name = IdentifierVisitor.Visit(context.identifier());
            codeSystemDef.id = context.codesystemId().GetStringLiteral();

            if (context.versionSpecifier() is { } vs)
            {
                codeSystemDef.version = vs.GetStringLiteral();
            }
            codeSystemDef.localId = NextId();
            codeSystemDef.locator = context.Locator();

            return codeSystemDef;
        }
    }
}
