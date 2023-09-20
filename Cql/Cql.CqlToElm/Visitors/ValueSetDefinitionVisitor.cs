using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class ValueSetDefinitionVisitor : Visitor<ValueSetDef>
    {
        public ValueSetDefinitionVisitor(IServiceProvider isp) : base(isp)
        {
        }

        private CodeSystemIdentifierVisitor CodeSystemIdentifierVisitor => Services.GetRequiredService<CodeSystemIdentifierVisitor>();

        //  : accessModifier? 'valueset' identifier ':' valuesetId ('version' versionSpecifier)? codesystems?
        public override ValueSetDef VisitValuesetDefinition([NotNull] cqlParser.ValuesetDefinitionContext context)
        {
            var valueSetDef = new ValueSetDef();
            var index = 1;
            if (context.GetChild(0) is cqlParser.AccessModifierContext amc)
            {
                valueSetDef.accessLevel = amc.Parse();
                index = 2;
            }
            else valueSetDef.accessLevel = AccessModifier.Public;

            valueSetDef.name = context.identifier().Parse();
            index += 2;
            valueSetDef.id = context.valuesetId().STRING().ParseString();
            index += 1;
            if (context.ChildCount > index)
            {
                var versionOrCs = context.GetChild(index);
                if (versionOrCs is TerminalNodeImpl)
                {
                    index += 1;
                    valueSetDef.version = context.versionSpecifier().STRING().ParseString();
                    index += 1;
                }
                if (context.ChildCount > index)
                {
                    var codeSystems = context.GetChild(index);
                    // skip codesystems and the { and don't go to }
                    var csCount = codeSystems.ChildCount - 3;
                    if ((csCount & 0x1) == 1)
                        csCount = (csCount >> 1) + 1;
                    else
                        csCount = (csCount >> 1);
                    valueSetDef.codeSystem = new CodeSystemRef[csCount];
                    var c = 0;
                    for (int i = 2; i < codeSystems.ChildCount - 1; i += 2)
                    {
                        var csRef = CodeSystemIdentifierVisitor.Visit(codeSystems.GetChild(i));
                        valueSetDef.codeSystem[c++] = csRef;
                    }
                }
            }
            valueSetDef.localId = NextId();
            valueSetDef.locator = context.Locator();

            return valueSetDef;
        }
    }
}
