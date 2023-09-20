using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class CodeDefinitionVisitor : Visitor<CodeDef>
    {
        public CodeDefinitionVisitor(IServiceProvider services) : base(services)
        {
        }

        private CodeSystemIdentifierVisitor CodeSystemIdentifierVisitor => Services.GetRequiredService<CodeSystemIdentifierVisitor>();
        private IdentifierVisitor IdentifierVisitor => Services.GetRequiredService<IdentifierVisitor>();

        //: accessModifier? 'code' identifier ':' codeId 'from' codesystemIdentifier displayClause?
        public override CodeDef VisitCodeDefinition([NotNull] cqlParser.CodeDefinitionContext context)
        {
            var codeDef = new CodeDef();

            codeDef.accessLevel = context.accessModifier().Parse();
            codeDef.name = IdentifierVisitor.Visit(context.identifier());
            codeDef.id = context.codeId().GetStringLiteral();
            codeDef.codeSystem = CodeSystemIdentifierVisitor.Visit(context.codesystemIdentifier());

            if (context.displayClause() is { } display)
                codeDef.display = display.STRING().GetStringLiteral();

            codeDef.localId = NextId();
            codeDef.locator = context.Locator();
            return codeDef;
        }
    }
}
