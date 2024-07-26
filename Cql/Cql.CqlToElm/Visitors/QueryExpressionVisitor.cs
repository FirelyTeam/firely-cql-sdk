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

            var source = handleSource(context.sourceClause());
            var query = new Query()
            {
                source = source,
            };
            TypeSpecifier returnType;
            using (var scope = LibraryBuilder.EnterScope($"Query {context.Locator()}"))
            {
                foreach (var qs in source)
                {
                    if (scope.TryResolveSymbol(qs.alias, out var existing))
                    {
                    }
                    scope.TryAdd(qs);
                }
                var hasScalarSource = source.All(s => s.resultTypeSpecifier is not ListTypeSpecifier);
                query.let = handleLetClause(context.letClause(), scope);
                query.relationship = handleRelationship(context.queryInclusionClause());
                if (context.returnClause() is { } returnClause) {
                    var @return = handleReturn(returnClause, hasScalarSource);
                    returnType = @return.resultTypeSpecifier;
                    query.@return = @return;
                }
                else if (context.aggregateClause() is { } aggregateClause)
                {
                    var aggregate = handleAggregate(scope, aggregateClause);
                    returnType = aggregate.resultTypeSpecifier;
                    query.aggregate = aggregate;

                }
                else // neither return nor aggregate specified
                {
                    if (source.Length == 1)
                    {
                        returnType = source[0].resultTypeSpecifier;
                    }
                    else if (hasScalarSource)
                        returnType = SystemTypes.AnyType;
                    else
                        returnType = SystemTypes.AnyType.ToListType();
                }
            }
            // sorting operates on the values being returned, and nothing in the main query scope,
            // such as the retrieve aliases, are allowed to be in scope in the sort statement
            query.sort = handleSort(context.sortClause(), returnType);

            if (query.source.Length == 0)
                query.AddError($"At least one source is required for this query");
            return query
                .WithId()
                .WithLocator(context.Locator())
                .WithResultType(returnType);

            LetClause[] handleLetClause(cqlParser.LetClauseContext letClauseContext, ISymbolScope scope)
            {
                if (letClauseContext is not null)
                {
                    var letClauseItems = letClauseContext.letClauseItem();
                    var letClauses = new LetClause[letClauseItems.Length];
                    for(int i = 0; i < letClauseItems.Length; i++)
                    {
                        var item = letClauseItems[i];
                        var expr = Visit(item.expression());
                        var identifier = item.identifier().Parse();
                        var letClause = new LetClause
                        {
                            identifier = identifier,
                            expression = expr,
                        }
                        .WithLocator(item.Locator())
                        .WithResultType(expr.resultTypeSpecifier);
                        if (!scope.TryAdd(letClause))
                        {
                            // TODO: figure out how to handle scope redefinition gracefully
                        }
                        letClauses[i] = letClause;
                    }
                    return letClauses;
                }
                else return Array.Empty<LetClause>();
            }

            AliasedQuerySource[] handleSource(cqlParser.SourceClauseContext sourceClauseCtx) =>
                sourceClauseCtx?.aliasedQuerySource()?
                .Select(handleAliasedQuerySource)
                .ToArray() ?? Array.Empty<AliasedQuerySource>();

            RelationshipClause[] handleRelationship(cqlParser.QueryInclusionClauseContext[] inclusions)
            {
                if (inclusions?.Length == 0)
                    return Array.Empty<RelationshipClause>();
                else
                {
                    var rcs = new RelationshipClause[inclusions!.Length];
                    for (int i = 0; i < inclusions.Length; i++)
                    {
                        var inc = inclusions[i];
                        var withClause = inc.withClause();
                        var aqs = handleAliasedQuerySource(withClause.aliasedQuerySource());
                        if (withClause is not null)
                        {
                            Expression? suchThat = null;
                            using (var scope = LibraryBuilder.EnterScope($"With {withClause.Locator()}"))
                            {
                                // add the with alias to scope while visiting the such that.
                                if (scope.TryAdd(aqs))
                                {
                                    suchThat = Visit(withClause.expression());
                                    rcs[i] = new With
                                    {
                                        alias = aqs.alias,
                                        expression = aqs.expression,
                                        suchThat = suchThat,
                                    };
                                }
                                else {
                                    rcs[i] = new With
                                    {
                                        alias = aqs.alias,
                                        expression = aqs.expression,
                                    }.AddError(Messaging.IdentifierAlreadyInScope(aqs.alias));
                                }
                            }

                        }
                    }
                    return rcs;
                }
            }

            SortClause? handleSort(cqlParser.SortClauseContext sortClauseCtx, TypeSpecifier returnType)
            {
                if (sortClauseCtx is null)
                    return null;

                var sortByItemCtx = sortClauseCtx.sortByItem();
                SortByItem[] items;
                if (sortByItemCtx is not null && sortByItemCtx.Length > 0)
                {
                    items = sortClauseCtx.sortByItem()?.Select(ctx =>
                    {
                        using (var scope = LibraryBuilder.EnterScope($"Sort {ctx.Locator()}"))
                        {
                            var thisType = returnType switch
                            {
                                ListTypeSpecifier lt => lt.elementType,
                                _ => returnType
                            };
                            var @this = new IdentifierRef { name = "$this" }.WithResultType(thisType);
                            scope.TryAdd(@this);
                            var termExpression = Visit(ctx.expressionTerm());
                            var byExpression = new ByExpression()
                            {
                                expression = termExpression,
                            };
                            var sd = ctx.sortDirection()?.GetText() ?? "asc";
                            if (Enum.TryParse<SortDirection>(sd, out var direction))
                            {
                                byExpression.direction = direction;
                                byExpression.directionSpecified = true;
                            }
                            else
                                byExpression.AddError($"Sort direction {ctx.sortDirection().GetText()} not recognized");
                            return byExpression
                                .WithLocator(ctx.Locator());
                        }
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

            ReturnClause handleReturn(cqlParser.ReturnClauseContext returnClauseCtx,
                bool isScalarSource)
            {
                var expression = Visit(returnClauseCtx);
                var rc = new ReturnClause
                {
                    expression = expression,
                };
                var resultType = isScalarSource
                    ? expression.resultTypeSpecifier
                    : expression.resultTypeSpecifier.ToListType();
                return rc
                    .WithLocator(returnClauseCtx.Locator())
                    .WithResultType(resultType);
            }

            AliasedQuerySource handleAliasedQuerySource(cqlParser.AliasedQuerySourceContext ctx)
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
                    alias = ctx.alias().identifier().Parse(),
                };
                if (expression.resultTypeSpecifier is null)
                    throw new InvalidOperationException($"Expression has a null result type specifier");
                return source
                    .WithLocator(ctx.Locator())
                    .WithResultType(expression.resultTypeSpecifier);
            }

            AggregateClause handleAggregate(ISymbolScope queryScope, cqlParser.AggregateClauseContext acCtx)
            {
                var aggregate = new AggregateClause();
                var identifier = acCtx.identifier().Parse();
                aggregate.identifier = identifier;
                if (acCtx.children.Count > 1 && acCtx.children[1].GetText() == "distinct")
                    aggregate.distinct = true;

                var let = new LetClause {  identifier = identifier };
                if (acCtx.startingClause() is { } startingCtx)
                {
                    Expression starting;
                    if (startingCtx.simpleLiteral() is { } sl)
                        starting = Visit(sl);
                    else if (startingCtx.expression() is { } expr)
                        starting = Visit(expr);
                    else
                        throw new InvalidOperationException("Starting clause must have a simple literal or expression");

                    aggregate.starting = starting;
                    let.expression = starting;
                    let.WithResultType(starting.resultTypeSpecifier);
                }
                else
                {
                    let.expression = new Null().WithResultType(SystemTypes.AnyType);
                    let.WithResultType(SystemTypes.AnyType);
                }

                using (var aggregateScope = queryScope.EnterScope($"Aggregate Clause {acCtx.Locator()}"))
                {
                    aggregateScope.TryAdd(let);
                    aggregate.expression = Visit(acCtx.expression());
                }

                return aggregate
                    .WithLocator(acCtx.Locator())
                    .WithResultType(aggregate.expression.resultTypeSpecifier);
            }
        }

      
    }
}
