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
        public IModelProvider ModelProvider => Services.GetRequiredService<IModelProvider>();

        // 'using' qualifiedIdentifier ('version' versionSpecifier)? ('called' localIdentifier)?
        public override UsingDef VisitUsingDefinition([NotNull] cqlParser.UsingDefinitionContext context)
        {
            var usingDef = new UsingDef();

            var (ns, id) = context.qualifiedIdentifier().Parse();

            usingDef.version = context.versionSpecifier()?.STRING().ParseString();
            usingDef.localIdentifier = string.IsNullOrWhiteSpace(ns) ? $"{id}" : $"{ns}.{id}";
            var model = ModelProvider.ModelFromName(usingDef.localIdentifier, usingDef.version)
                ?? throw new InvalidOperationException($"Model {usingDef.localIdentifier} version {usingDef.version ?? "<unspecified>"} is not available.");
            usingDef.uri = model.url;

            if (context.localIdentifier() is { } localId)
                usingDef.localIdentifier = localId.identifier().Parse();
            usingDef.localId = NextId();
            usingDef.locator = context.Locator();

            return usingDef;
        }
    }
}
