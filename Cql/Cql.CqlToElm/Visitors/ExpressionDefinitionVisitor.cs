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
            var def = new ExpressionDef();

            if (context.GetChild(1) is cqlParser.AccessModifierContext amc)
            {
                def.accessLevel = amc.Parse();
                def.name = context.GetChild(2).GetText();
            }
            else
                def.name = context.GetChild(1).GetText();

            var ec = context.GetChild(context.ChildCount - 1);
            def.expression = ExpressionVisitor.Visit(ec);

            def.localId = NextId();
            def.locator = context.Locator();
            return def;
        }
    }
}
