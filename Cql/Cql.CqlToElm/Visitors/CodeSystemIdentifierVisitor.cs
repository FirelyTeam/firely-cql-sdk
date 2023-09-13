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
    internal class CodeSystemIdentifierVisitor : Visitor<CodeSystemRef>
    {
        public CodeSystemIdentifierVisitor(IServiceProvider services) : base(services)
        {
        }

        private IdentifierVisitor IdentifierVisitor => Services.GetRequiredService<IdentifierVisitor>();

        // : (libraryIdentifier '.')? identifier
        public override CodeSystemRef VisitCodesystemIdentifier([NotNull] cqlParser.CodesystemIdentifierContext context)
        {
            var csRef = new CodeSystemRef();

            if (context.ChildCount > 2)
            {
                csRef.libraryName = IdentifierVisitor.Visit(context.GetChild(0));
                csRef.name = IdentifierVisitor.Visit(context.GetChild(2));
            }
            else
                csRef.name = IdentifierVisitor.Visit(context.GetChild(0));

            csRef.localId = NextId();
            csRef.locator = context.Locator();
            return csRef;
        }
    }
}
