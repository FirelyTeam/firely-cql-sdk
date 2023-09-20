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

        //: accessModifier? 'code' identifier ':' codeId 'from' codesystemIdentifier displayClause?
        public override CodeDef VisitCodeDefinition([NotNull] cqlParser.CodeDefinitionContext context)
        {
            return new()
            {
                accessLevel = context.accessModifier().Parse(),
                name = context.identifier().Parse(),
                id = context.codeId().STRING().ParseString(),
                codeSystem = CodeSystemIdentifierVisitor.Visit(context.codesystemIdentifier()),
                display = context.displayClause()?.STRING()?.ParseString(),

                localId = NextId(),
                locator = context.Locator()
            };
        }
    }
}
