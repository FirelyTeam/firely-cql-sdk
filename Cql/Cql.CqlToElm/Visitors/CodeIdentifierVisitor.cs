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
    internal class CodeIdentifierVisitor : Visitor<CodeRef>
    {
        public CodeIdentifierVisitor(IServiceProvider services) : base(services)
        {
        }

        private IdentifierVisitor IdentifierVisitor => Services.GetRequiredService<IdentifierVisitor>();

        // : (libraryIdentifier '.')? identifier
        public override CodeRef VisitCodeIdentifier([NotNull] cqlParser.CodeIdentifierContext context)
        {
            var codeRef = new CodeRef();

            if (context.ChildCount > 2)
            {
                codeRef.libraryName = IdentifierVisitor.Visit(context.GetChild(0));
                codeRef.name = IdentifierVisitor.Visit(context.GetChild(2));
            }
            else
                codeRef.name = IdentifierVisitor.Visit(context.GetChild(0));
            
            codeRef.localId = NextId();
            codeRef.locator = context.Locator();
            return codeRef;
        }
    }
}
