using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class AccessModifierVisitor : Visitor<AccessModifier>
    {
        public AccessModifierVisitor(IServiceProvider services) : base(services)
        {
        }

        public override AccessModifier VisitAccessModifier([NotNull] cqlParser.AccessModifierContext context) =>
            context.GetText().ToLower() switch
            {
                "public" => AccessModifier.Public,
                "private" => AccessModifier.Private,
                _ => throw new InvalidOperationException($"Access modifier {context.GetText()} is not supported")
            };
    }
}
