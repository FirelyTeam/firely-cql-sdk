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
    internal class VersionedIdentifierVisitor : Visitor<VersionedIdentifier>
    {
        public VersionedIdentifierVisitor(IServiceProvider services) : base(services)
        {
        }

        public QualifiedIdentifierVisitor QualifiedIdentifierVisitor => Services.GetRequiredService<QualifiedIdentifierVisitor>();

        public override VersionedIdentifier VisitLibraryDefinition([NotNull] cqlParser.LibraryDefinitionContext context)
        {
            var id = QualifiedIdentifierVisitor.Visit(context.GetChild(1));
            string version = string.Empty;
            if (context.ChildCount == 4)
                version = context.GetChild(3).GetText().AsSpan().Detick().ToString();
            var versionedIdentifier = new VersionedIdentifier
            {
                id = id.id,
                system = id.qualifier,
                version = version,
            };
            return versionedIdentifier;
        }
    }
}
