using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class CodeSystemIdentifierVisitor : Visitor<CodeSystemRef>
    {
        public CodeSystemIdentifierVisitor(IServiceProvider services) : base(services)
        {
        }

        // : (libraryIdentifier '.')? identifier
        public override CodeSystemRef VisitCodesystemIdentifier([NotNull] cqlParser.CodesystemIdentifierContext context)
        {
            var csRef = new CodeSystemRef
            {
                libraryName = context.libraryIdentifier()?.identifier().Parse(),
                name = context.identifier().Parse(),
                localId = NextId(),
                locator = context.Locator()
            };
            return csRef;
        }
    }
}
