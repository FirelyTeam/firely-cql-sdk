using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class TupleElementDefinitionVisitor : Visitor<TupleElementDefinition>
    {
        public TupleElementDefinitionVisitor(IServiceProvider services) : base(services)
        {
        }

        public TypeSpecifierVisitor TypeSpecifierVisitor => Services.GetRequiredService<TypeSpecifierVisitor>();

        public override TupleElementDefinition VisitTupleElementDefinition([NotNull] cqlParser.TupleElementDefinitionContext context)
        {
            var name = context.GetChild(0).GetText();
            var type = TypeSpecifierVisitor.Visit(context.GetChild(1));
            var ted = new TupleElementDefinition
            {
                name = name,
                elementType = type,
                localId = NextId(),
                locator = context.Locator(),
            };
            return ted;
        }
    }
}
