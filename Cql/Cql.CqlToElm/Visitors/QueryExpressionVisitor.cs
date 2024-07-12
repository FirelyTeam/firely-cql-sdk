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
            var scope = LibraryBuilder.EnterScope();
            {
                foreach (var qs in source)
                {
                    LibraryBuilder.CurrentScope.TryAdd(qs);
                }
                var hasScalarSource = source.All(s => s.resultTypeSpecifier is not ListTypeSpecifier);
                query.let = handleLetClause(context.letClause());
                query.relationship = handleRelationship(context.queryInclusionClause());
                var @return = handleReturn(context.returnClause(), hasScalarSource);
                if (@return?.resultTypeSpecifier is null)
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
                else
                    returnType = @return.resultTypeSpecifier;
                query.@return = @return;
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
            LetClause[] handleLetClause(cqlParser.LetClauseContext letClauseContext)
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
                        if (!LibraryBuilder.CurrentScope.TryAdd(letClause))
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
                            using (var scope = LibraryBuilder.EnterScope())
                            {
                                // add the with alias to scope while visiting the such that.
                                if (LibraryBuilder.CurrentScope.TryAdd(aqs))
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
                        using (LibraryBuilder.EnterScope())
                        {
                            var thisType = returnType switch
                            {
                                ListTypeSpecifier lt => lt.elementType,
                                _ => returnType
                            };
                            var @this = new IdentifierRef { name = "$this" }.WithResultType(thisType);
                            LibraryBuilder.CurrentScope.TryAdd(@this);
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

            ReturnClause? handleReturn(cqlParser.ReturnClauseContext? returnClauseCtx, bool isScalarSource)
            {
                if (returnClauseCtx is null)
                    return null;
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
                    alias = ctx.alias().GetText()
                };
                if (expression.resultTypeSpecifier is null)
                    throw new InvalidOperationException($"Expression has a null result type specifier");
                return source
                    .WithLocator(ctx.Locator())
                    .WithResultType(expression.resultTypeSpecifier);
            }
        }

      
    }
}
