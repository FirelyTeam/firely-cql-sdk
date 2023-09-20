using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class VersionedIdentifierVisitor : Visitor<VersionedIdentifier>
    {
        public VersionedIdentifierVisitor(IServiceProvider services) : base(services)
        {
        }

        //    : 'library' qualifiedIdentifier ('version' versionSpecifier)?
        public override VersionedIdentifier VisitLibraryDefinition([NotNull] cqlParser.LibraryDefinitionContext context)
        {
            var id = context.qualifiedIdentifier().Parse();

            var versionedIdentifier = new VersionedIdentifier
            {
                id = id.id,
                system = id.qualifier,
                version = context.versionSpecifier()?.STRING().ParseString()
            };
            return versionedIdentifier;
        }
    }
}
