using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal partial class ExpressionVisitor
    {
        public override Expression VisitQuery([NotNull] cqlParser.QueryContext context)
        {
            var source = visitSource(context.sourceClause());
            var sort = visitSort(context.sortClause());
            var query = new Query()
            {
                source = source,
                sort = sort!,
            };
            if (query.source.Length == 0)
                query.AddError($"At least one source is required for this query");
            return query
                .WithLocator(context.Locator())
                .WithResultType(SystemTypes.AnyType);


            AliasedQuerySource[] visitSource(cqlParser.SourceClauseContext sourceClauseCtx) =>
                sourceClauseCtx?.aliasedQuerySource()?.Select(ctx =>
                    {
                        var querySourceCtx = ctx.querySource();

                        Expression expression;

                        var sourceRetrieve = querySourceCtx.retrieve();

                        if (sourceRetrieve is not null)
                            expression = Visit(sourceRetrieve);
                        else
                        {
                            var sourceExpression = querySourceCtx.expression();
                            if (sourceExpression is not null)
                                expression = Visit(sourceExpression);
                            else
                            {
                                expression = Visit(querySourceCtx.qualifiedIdentifierExpression());
                            }
                        }
                        var source = new AliasedQuerySource()
                        {
                            expression = expression,
                            alias = ctx.alias().GetText()
                        };
                        return source
                            .WithLocator(context.Locator())
                            .WithResultType(expression.resultTypeSpecifier);
                    })
                .ToArray() ?? Array.Empty<AliasedQuerySource>();

            SortClause? visitSort(cqlParser.SortClauseContext sortClauseCtx)
            {
                if (sortClauseCtx is null)
                    return null;

                var sortByItemCtx = sortClauseCtx.sortByItem();
                SortByItem[] items;
                if (sortByItemCtx is not null && sortByItemCtx.Length > 0)
                {
                    items = sortClauseCtx.sortByItem()?.Select(ctx =>
                    {
                        var termExpression = Visit(ctx.expressionTerm());
                        var byExpression = new ByExpression()
                        {
                            expression = termExpression,
                        };
                        if (Enum.TryParse<SortDirection>(ctx.sortDirection().GetText(), out var direction))
                        {
                            byExpression.direction = direction;
                            byExpression.directionSpecified = true;
                        }
                        else
                            byExpression.AddError($"Sort direction {ctx.sortDirection().GetText()} not recognized");
                        return byExpression
                            .WithLocator(ctx.Locator());
                    })
                    .ToArray() ?? Array.Empty<SortByItem>();
                }
                else
                {
                    var sortDirectionContext = sortClauseCtx.sortDirection();
                    if (Enum.TryParse<SortDirection>(sortDirectionContext.GetText(), out var direction))
                    {
                        items = new SortByItem[]
                        {
                            new ByDirection { direction = direction, directionSpecified = true }
                                .WithLocator(sortDirectionContext.Locator())
                        };
                    }
                    else items = Array.Empty<SortByItem>();
                }
                var sortClause = new SortClause()
                {
                    by = items,
                };
                return sortClause // sorts don't have result types
                    .WithLocator(sortClauseCtx.Locator());
            }

        }

    }
}
