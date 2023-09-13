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
    internal class IncludeDefinitionVisitor : Visitor<IncludeDef>
    {
        public IncludeDefinitionVisitor(IServiceProvider services) : base(services)
        {
        }

        public QualifiedIdentifierVisitor QualifiedIdentifierVisitor => Services.GetRequiredService<QualifiedIdentifierVisitor>();


        public override IncludeDef VisitIncludeDefinition([NotNull] cqlParser.IncludeDefinitionContext context)
        {
            var includeDef = new IncludeDef();

            var qualifiedId = QualifiedIdentifierVisitor.Visit(context.GetChild(1));
            if (string.IsNullOrWhiteSpace(qualifiedId.qualifier))
                includeDef.path = qualifiedId.id;
            else includeDef.path = $"{qualifiedId.qualifier}.{qualifiedId.id}";

            if (context.ChildCount > 2)
            {
                var child3 = context.GetChild(3);
                if (child3 is cqlParser.LocalIdentifierContext localIdContext)
                    includeDef.localIdentifier = child3.GetText();
                else
                    includeDef.version = context.GetChild(3).GetText().AsSpan().Detick().ToString();
            }
            if (context.ChildCount > 4)
                includeDef.localIdentifier = context.GetChild(5).GetText();

            includeDef.localId = NextId();
            includeDef.locator = context.Locator();

            return includeDef;
        }
    }
}
