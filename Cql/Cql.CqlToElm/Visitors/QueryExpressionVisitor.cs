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
            using (LibraryBuilder.EnterScope())
            {
                foreach (var qs in source)
                {
                    LibraryBuilder.CurrentScope.TryAdd(qs);
                }
                // in single source queries, the sort term is unqualified, e.g.:
                //      from intervals i sort by low asc               
                // low is a member of i, and would normally not resolve.
                // by defining $this, we allow low to resolve later.
                if (source.Length == 1)
                    LibraryBuilder.CurrentScope.TryAdd(new AliasedQuerySource
                    {
                        alias = "$this",
                        expression = source[0].expression,
                        resultTypeSpecifier = source[0].resultTypeSpecifier,
                    });

                var sort = visitSort(context.sortClause());
                var @return = visitReturn(context.returnClause()); // pass aliases & lets?
                TypeSpecifier returnType = @return?.resultTypeSpecifier ??
                    (returnType = source.Length == 1
                        ? source[0].resultTypeSpecifier
                        : SystemTypes.AnyType.ToListType());
                var query = new Query()
                {
                    source = source,
                    sort = sort!,
                    @return = @return,
                };
                if (query.source.Length == 0)
                    query.AddError($"At least one source is required for this query");
                return query
                    .WithId()
                    .WithLocator(context.Locator())
                    .WithResultType(returnType);
            }

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
                        if (expression.resultTypeSpecifier is null)
                            throw new InvalidOperationException($"Expression has a null result type specifier");
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

            ReturnClause? visitReturn(cqlParser.ReturnClauseContext? returnClauseCtx)
            {
                if (returnClauseCtx is null)
                    return null;
                // set the scope to include aliases & lets?
                var expression = Visit(returnClauseCtx);
                var rc = new ReturnClause
                {
                    expression = expression,
                };
                // return clauses have list types, even though their expressions generally do not.
                return rc
                    .WithLocator(returnClauseCtx.Locator())
                    .WithResultType(expression.resultTypeSpecifier.ToListType());
            }
        }

    }
}
