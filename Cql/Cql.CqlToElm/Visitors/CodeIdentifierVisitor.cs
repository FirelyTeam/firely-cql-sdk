using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class CodeIdentifierVisitor : Visitor<CodeRef>
    {
        public CodeIdentifierVisitor(IServiceProvider services) : base(services)
        {
        }

        // : (libraryIdentifier '.')? identifier
        public override CodeRef VisitCodeIdentifier([NotNull] cqlParser.CodeIdentifierContext context)
        {
            var codeRef = new CodeRef
            {
                libraryName = context.libraryIdentifier()?.identifier().Parse(),
                name = context.identifier().Parse(),
                localId = NextId(),
                locator = context.Locator()
            };
            return codeRef;
        }
    }
}
