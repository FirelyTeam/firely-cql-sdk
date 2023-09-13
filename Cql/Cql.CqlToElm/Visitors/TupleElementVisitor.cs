using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class TupleElementVisitor: Visitor<TupleElement>
    {
        public TupleElementVisitor(IServiceProvider services) : base(services)
        {
        }

        public ExpressionVisitor ExpressionVisitor => Services.GetRequiredService<ExpressionVisitor>();

        public override TupleElement VisitTupleElementSelector([NotNull] cqlParser.TupleElementSelectorContext context)
        {
            var name = context.GetChild(0).GetText();
            var expression = ExpressionVisitor.Visit(context.GetChild(2));
            var te = new TupleElement
            {
                name = name,
                value = expression,
            };
            return te;
        }
    }
}
