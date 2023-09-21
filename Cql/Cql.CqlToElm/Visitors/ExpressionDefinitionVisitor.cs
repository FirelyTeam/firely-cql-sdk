using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class ExpressionDefinitionVisitor : Visitor<ExpressionDef>
    {
        public ExpressionDefinitionVisitor(IServiceProvider services) : base(services)
        {
        }

        private ExpressionVisitor ExpressionVisitor => Services.GetRequiredService<ExpressionVisitor>();


        // 'define' accessModifier? identifier ':' expression
        public override ExpressionDef VisitExpressionDefinition([NotNull] cqlParser.ExpressionDefinitionContext context)
        {
            var def = new ExpressionDef
            {
                accessLevel = context.accessModifier().Parse(),
                name = context.identifier().Parse(),
                expression = ExpressionVisitor.Visit(context.expression()),
                localId = NextId(),
                locator = context.Locator()
            };
            return def;
        }
    }
}
