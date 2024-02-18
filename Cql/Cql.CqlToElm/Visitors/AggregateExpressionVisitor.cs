using Antlr4.Runtime.Misc;
using Hl7.Cql.Abstractions;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal partial class ExpressionVisitor
    {
        //  ('expand' | 'collapse') expression ('per' (dateTimePrecision | expression))?
        public override Expression VisitSetAggregateExpressionTerm([NotNull] cqlParser.SetAggregateExpressionTermContext context)
        {
            var keyword = Keyword.Parse(context.GetChild(0));
            var expressions = context.expression();
            var dtp = context.dateTimePrecision()?.Parse();
            if (expressions.Length == 1)
            {
                if (dtp != null)
                {
                    return keyword switch
                    {
                        CqlKeyword.Collapse => HandleCollapse(context, Visit(expressions[0]), dtp.Value),
                        CqlKeyword.Expand => HandleExpand(context, Visit(expressions[0]), dtp.Value),
                        _ => throw new NotImplementedException()
                    };
                }
                else
                {
                    return keyword switch
                    {
                        CqlKeyword.Collapse => HandleCollapse(context, Visit(expressions[0])),
                        CqlKeyword.Expand => HandleExpand(context, Visit(expressions[0])),
                        _ => throw new NotImplementedException()
                    };
                }
            }
            else
            {
                var per = Visit(expressions[1]);
                if (per is Literal literal)
                    per = InvocationBuilder.Invoke(SystemLibrary.ToQuantity, per)
                        .WithLocator(expressions[1].Locator());
                     
                return keyword switch
                {
                    CqlKeyword.Collapse => HandleCollapse(context, Visit(expressions[0]), per),
                    CqlKeyword.Expand => HandleExpand(context, Visit(expressions[0]), per),
                    _ => throw new NotImplementedException()
                };

            }
        }

        private Expression HandleCollapse(cqlParser.SetAggregateExpressionTermContext context, Expression expression)
        {
            var collapse = new Collapse()
            {
                operand = new[] { expression }
            };
            return collapse
                .WithResultType(expression.resultTypeSpecifier)
                .WithLocator(context.Locator());
        }
        private Expression HandleCollapse(cqlParser.SetAggregateExpressionTermContext context, Expression expression, DateTimePrecision dateTimePrecision)
        {
            var collapse = new Collapse();
            var unit = Enum.GetName(dateTimePrecision)?.ToLowerInvariant();
            if (unit is null)
                collapse.AddError($"Unit {dateTimePrecision} is not recognized");
            collapse.operand = new[]
            {
                expression,
                new Quantity
                {
                    value = 1m,
                    unit = unit,
                }
            };
            return collapse
                .WithResultType(expression.resultTypeSpecifier)
                .WithLocator(context.Locator());
        }
        private Expression HandleCollapse(cqlParser.SetAggregateExpressionTermContext context, Expression expression, Expression per)
        {
            var collapse = new Collapse()
            {
                operand = new[] { expression, per }
            };
            return collapse
                .WithResultType(expression.resultTypeSpecifier)
                .WithLocator(context.Locator());
        }
        private Expression HandleExpand(cqlParser.SetAggregateExpressionTermContext context, Expression expression)
        {
            var expand = new Expand()
            {
                operand = new[] 
                { 
                    expression, 
                    new Null().WithResultType(SystemTypes.QuantityType) 
                }
            };
            return expand
                .WithResultType(expression.resultTypeSpecifier)
                .WithLocator(context.Locator());

        }

        private Expression HandleExpand(cqlParser.SetAggregateExpressionTermContext context, Expression expression, DateTimePrecision dateTimePrecision)
        {
            var expand = new Expand();
            var unit = Enum.GetName(dateTimePrecision)?.ToLowerInvariant();
            if (unit is null)
                expand.AddError($"Unit {dateTimePrecision} is not recognized");
            expand.operand = new[]
            {
                    expression,
                    new Quantity
                    {
                        value = 1m,
                        unit = unit,
                    }
            };
            return expand
                .WithResultType(expression.resultTypeSpecifier)
                .WithLocator(context.Locator());
        }

        private Expression HandleExpand(cqlParser.SetAggregateExpressionTermContext context, Expression expression, Expression per)
        {
            Debug.Assert(per.resultTypeSpecifier == SystemTypes.QuantityType);
            var expand = new Expand()
            {
                operand = new[]
                {
                    expression,
                    per
                }
            };
            return expand
                .WithResultType(expression.resultTypeSpecifier)
                .WithLocator(context.Locator());
        }

    }
}
