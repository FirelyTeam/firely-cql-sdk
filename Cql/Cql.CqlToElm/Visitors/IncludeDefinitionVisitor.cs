using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class IncludeDefinitionVisitor : Visitor<IncludeDef>
    {
        public IncludeDefinitionVisitor(IServiceProvider services) : base(services)
        {
        }

        //   : 'include' qualifiedIdentifier ('version' versionSpecifier)? ('called' localIdentifier)?
        public override IncludeDef VisitIncludeDefinition([NotNull] cqlParser.IncludeDefinitionContext context)
        {
            var includeDef = new IncludeDef();

            var qualifiedId = context.qualifiedIdentifier().Parse();
            if (string.IsNullOrWhiteSpace(qualifiedId.qualifier))
                includeDef.path = qualifiedId.id;
            else includeDef.path = $"{qualifiedId.qualifier}.{qualifiedId.id}";

            if (context.ChildCount > 2)
            {
                var child3 = context.GetChild(3);
                if (child3 is cqlParser.LocalIdentifierContext localIdContext)
                    includeDef.localIdentifier = child3.GetText();
                else
                    includeDef.version = context.versionSpecifier().STRING().ParseString();
            }
            if (context.ChildCount > 4)
                includeDef.localIdentifier = context.GetChild(5).GetText();

            includeDef.localId = NextId();
            includeDef.locator = context.Locator();

            return includeDef;
        }
    }
}
