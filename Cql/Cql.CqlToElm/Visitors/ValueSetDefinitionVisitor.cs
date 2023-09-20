using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class ValueSetDefinitionVisitor : Visitor<ValueSetDef>
    {
        public ValueSetDefinitionVisitor(IServiceProvider isp) : base(isp)
        {
        }

        //  : accessModifier? 'valueset' identifier ':' valuesetId ('version' versionSpecifier)? codesystems?
        public override ValueSetDef VisitValuesetDefinition([NotNull] cqlParser.ValuesetDefinitionContext context)
        {
            var valueSetDef = new ValueSetDef();

            valueSetDef.accessLevel = context.accessModifier().Parse();
            valueSetDef.name = context.identifier().Parse();
            valueSetDef.id = context.valuesetId().STRING().ParseString();
            valueSetDef.version = context.versionSpecifier()?.STRING().ParseString();

            if (context.codesystems() is { } codesystems)
            {
                valueSetDef.codeSystem = codesystems.codesystemIdentifier().Select(csi =>
                    csi.Parse()).ToArray();
            }

            valueSetDef.localId = NextId();
            valueSetDef.locator = context.Locator();

            return valueSetDef;
        }
    }
}



