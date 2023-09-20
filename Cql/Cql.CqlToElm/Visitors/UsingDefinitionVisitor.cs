using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class UsingDefinitionVisitor : Visitor<UsingDef>
    {
        public UsingDefinitionVisitor(IServiceProvider services) : base(services)
        {
        }
        public QualifiedIdentifierVisitor QualifiedIdentifierVisitor => Services.GetRequiredService<QualifiedIdentifierVisitor>();
        public IModelProvider ModelProvider => Services.GetRequiredService<IModelProvider>();

        // 'using' qualifiedIdentifier ('version' versionSpecifier)? ('called' localIdentifier)?
        public override UsingDef VisitUsingDefinition([NotNull] cqlParser.UsingDefinitionContext context)
        {
            var usingDef = new UsingDef();

            var nameChild = context.GetChild(1);
            var (ns, id) = QualifiedIdentifierVisitor.Visit(nameChild);
            var versionChild = context.GetChild(3);
            if (versionChild is cqlParser.VersionSpecifierContext)
                usingDef.version = versionChild.GetStringLiteral();
            if (string.IsNullOrWhiteSpace(ns))
                usingDef.localIdentifier = $"{id}";
            else
                usingDef.localIdentifier = $"{ns}.{id}";
            var model = ModelProvider.ModelFromName(usingDef.localIdentifier, usingDef.version)
                ?? throw new InvalidOperationException($"Model {usingDef.localIdentifier} version {usingDef.version ?? "<unspecified>"} is not available.");
            usingDef.uri = model.url;
            var lastChild = context.GetChild(context.ChildCount - 1);
            if (lastChild is cqlParser.LocalIdentifierContext localIdentifierContext)
            {
                usingDef.localIdentifier = localIdentifierContext.GetText();
            }
            usingDef.localId = NextId();
            usingDef.locator = context.Locator();

            return usingDef;
        }
    }
}
