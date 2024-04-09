using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Expression = System.Linq.Expressions.Expression;
using Hl7.Cql.Elm;

using ExpressionElementPairForIdentifier = System.Collections.Generic.KeyValuePair<string, (System.Linq.Expressions.Expression, Hl7.Cql.Elm.Element)>;

namespace Hl7.Cql.Compiler;

internal partial class ExpressionBuilder
{
    protected Expression Query(Query query)
    {
        QueryDumpDebugInfoToLog(query);

        ExpressionBuilder ctx = this;

        var sources = query.source;
        if (sources.Length == 0)
            throw ctx.NewExpressionBuildingException("Queries must define at least 1 source");

        var (@return, sourcesPreviouslySingletons) = ctx.ProcessQuerySources(query);
        var returnElementType = ctx._typeManager.Resolver.GetListElementType(@return.Type, true)!;

        ParameterExpression scopeParameter;
        if (sources.Length == 1)
        {
            var source0 = sources[0];
            var sourceParameterName = NormalizeIdentifier(source0.alias);
            scopeParameter = Expression.Parameter(returnElementType, sourceParameterName);
            ctx = ctx.WithScope(source0.alias, scopeParameter, source0.expression);
        }
        else
        {
            var sourceParameterName = TypeNameToIdentifier(returnElementType, ctx);
            scopeParameter = Expression.Parameter(returnElementType, sourceParameterName);
            var scopes =
                (
                    from property in returnElementType!.GetProperties()
                    let propertyAccess = Expression.Property(scopeParameter, property)
                    select new ExpressionElementPairForIdentifier(property.Name, (propertyAccess, query))
                )
                .ToArray();
            ctx = ctx.WithScopes(scopes);
        }

        if (query.let != null)
        {
            foreach (var let in query.let)
            {
                var expression = ctx.TranslateExpression(let.expression!);
                ctx = ctx.WithScope(let.identifier!, expression, let.expression!);
            }
        }

        // handle with/such-that
        if (query.relationship is not null)
        {
            foreach (var relationship in query.relationship)
            {
                using (ctx.PushElement(relationship))
                {
                    var selectManyLambda = ctx.WithToSelectManyBody(scopeParameter, relationship);

                    var selectManyCall = ctx.BindCqlOperator(CqlOperator.SelectMany, @return, selectManyLambda);
                    if (relationship is Without)
                    {
                        var callExcept = ctx.BindCqlOperator(CqlOperator.ListExcept, @return, selectManyCall);
                        @return = callExcept;
                    }
                    else
                    {
                        @return = selectManyCall;
                    }
                }
            }
        }
        // 20240312 EK: refactoring made this redundant, but I am not sure it really is, so I am keeping
        // it around. It was used to redefine the type for the "rootScopeParameter", which used to be defined
        // inside every if statement here (so for where, return, etc).
        // -----
        // The element type may have changed
        // elementType = TypeManager.Resolver.GetListElementType(@return.Type, @throw: true)!;
        if (query.where is { } queryWhere)
        {
            @return = ctx.Where(queryWhere, scopeParameter, @return);
        }

        if (query.@return != null)
        {
            using (ctx.PushElement(query.@return))
            {
                var selectBody = ctx.TranslateExpression(query.@return.expression!);
                var selectLambda = Expression.Lambda(selectBody, scopeParameter);
                var callSelect = ctx.BindCqlOperator(CqlOperator.Select, @return, selectLambda);
                @return = callSelect;
            }
        }

        if (query.aggregate is { } queryAggregate)
        {
            @return = ctx.AggregateClause(query, queryAggregate, scopeParameter, @return);
        }

        if (query.sort is { by.Length: > 0 })
        {
            if (sources.Length == 1)
                @return = ctx.SortClause(query, @return);
            else
            {
                throw new NotImplementedException("Sort is broken in ELM XSD?").WithContext(ctx);
                //foreach (var by in query.sort.by)
                //{
                //    var order = ListSortDirection.Ascending;
                //    if (by.direction == "desc" || by.direction == "descending")
                //        order = ListSortDirection.Descending;
                //    else if (by.direction == "asc" || by.direction == "ascending")
                //        order = ListSortDirection.Ascending;
                //    else throw ctx.NewExpressionBuildingException($"Invalid sort order {by.direction}");

                //    if (by.expression != null)
                //    {
                //        var parameterName = "@this";
                //        var returnElementType = TypeResolver.GetListElementType(@return.Type);
                //        var sortMemberParameter = Expression.Parameter(returnElementType, parameterName);
                //        var subContext = ctx.WithImpliedAlias(parameterName!, sortMemberParameter, by.expression);
                //        var sortMemberExpression = TranslateExpression(by.expression, subContext);
                //        var lambdaBody = Expression.Convert(sortMemberExpression, typeof(object));
                //        var sortLambda = System.Linq.Expressions.Expression.Lambda(lambdaBody, sortMemberParameter);
                //        var sort = Operators.Bind(CqlOperator.SortBy, ctx.RuntimeContextParameter,
                //            @return, sortLambda, Expression.Constant(order, typeof(SortOrder)));
                //        @return = sort;
                //    }
                //    else if (by.path != null && by.resultTypeName != null)
                //    {
                //        var parameterName = "@this";
                //        var returnElementType = TypeResolver.GetListElementType(@return.Type);
                //        var sortMemberParameter = Expression.Parameter(returnElementType, parameterName);
                //        var pathMemberType = TypeResolver.ResolveType(by.resultTypeName);
                //        if (pathMemberType == null)
                //        {
                //            var msg = $"Type specifier {by.resultTypeName} at {by.locator ?? "unknown"} could not be resolved.";
                //            ctx.LogError(msg);
                //            throw ctx.NewExpressionBuildingException(msg);
                //        }
                //        var pathExpression = PropertyHelper(sortMemberParameter, by.path, pathMemberType!, ctx);
                //        var lambdaBody = Expression.Convert(pathExpression, typeof(object));
                //        var sortLambda = System.Linq.Expressions.Expression.Lambda(lambdaBody, sortMemberParameter);
                //        var sort = Operators.Bind(CqlOperator.SortBy, ctx.RuntimeContextParameter,
                //            @return, sortLambda, Expression.Constant(order, typeof(SortOrder)));
                //        @return = sort;
                //    }
                //    else
                //    {
                //        var sort = Operators.Bind(CqlOperator.Sort, ctx.RuntimeContextParameter,
                //            @return, Expression.Constant(order, typeof(SortOrder)));
                //        @return = sort;
                //    }
                //}

            }
        }

        // Because we promoted the source to a list, we now have to demote the result again.
        var wereAllSourcesPreviouslySingletons = sourcesPreviouslySingletons.All(b => b);
        if (wereAllSourcesPreviouslySingletons)
        {
            @return = ctx.DemoteSourceListToSingleton(@return);
        }

        if (query.resultTypeSpecifier is Elm.ListTypeSpecifier && !ctx._typeResolver.ImplementsGenericIEnumerable(@return.Type))
        {
            @return = Expression.NewArrayInit(@return.Type, @return);
        }

        return @return;
    }

    private Expression DemoteSourceListToSingleton(Expression source)
    {
        source = BindCqlOperator(CqlOperator.Single, source);
        return source;
    }

    private (Expression source, bool sourceOriginallyASingleton) PromoteSourceSingletonToList(Expression source)
    {
        if (_typeResolver.ImplementsGenericIEnumerable(source.Type))
            return (source, false);

        source = Expression.NewArrayInit(source.Type, source);
        return (source, true);
    }



    [Conditional("DEBUG")]
    private void QueryDumpDebugInfoToLog(Query query)
    {
        var sourceLength = query.source?.Length ?? 0;
        var lines = ReadCqlLines(query);
        var sources = ReadSources();

        (string alias, Type sourceType, bool isEnumerationType)[] ReadSources() => query.source!
            .SelectToArray(s =>
            {
                var sourceType = TranslateExpression(s.expression).Type;
                var isEnumerationType = _typeResolver.ImplementsGenericIEnumerable(sourceType);
                if (isEnumerationType) sourceType = _typeManager.Resolver.GetListElementType(sourceType, true)!;
                return (
                    s.alias,
                    sourceType,
                    isEnumerationType
                );
            });

        string[]? ReadCqlLines(Element element)
        {
            if (element.locator?.Split([":", "-"], 4, StringSplitOptions.TrimEntries) is not [{ } r0, { } c0, { } r1, { } c1]) return null;

            static int ParseInt32(string s) => int.Parse(s, CultureInfo.InvariantCulture);

            var (row0, col0, row1, col1) = (ParseInt32(r0), ParseInt32(c0), ParseInt32(r1), ParseInt32(c1));

            var elmFilePath = _libraryContext.Library.OriginalFilePath;
            if (elmFilePath is null)
                return null;

            var fiElm = new FileInfo(elmFilePath);
            var fiCql = new FileInfo(Path.Combine(fiElm.Directory!.Parent!.FullName, "CQL", fiElm.Name[..^4] + "cql"));
            if (!fiCql.Exists)
                return null;

            var lines =
                System.IO.File.ReadLines(fiCql.FullName)
                    .Select((lineText, i) => (lineText, lineNum: i + 1))
                    .Where(t => t.lineNum >= row0 && t.lineNum <= row1)
                    .Select(t =>
                    {
                        var lineText = t.lineText;
                        Debug.Assert(row0 != row1 || col1 > col0);
                        if (t.lineNum == row1)
                            lineText = lineText[..(col1)] + "<<<" + lineText[(col1)..];
                        if (t.lineNum == row0)
                            lineText = lineText[..col0] + ">>>" + lineText[col0..];
                        return lineText;
                    })
                    .ToArray();
            return lines;
        }

        _logger.LogDebug(
            """
            Found {queryType} Query with {sourceCount} source(s) at: {at}
            Sources:{sources}
            CQL: {lines}
            """,
            ((ReadOnlySpan<string>)["Empty", "Single", "Multi"])[Math.Clamp(sourceLength, 0, 2)],
            sourceLength,
            DebuggerView,
            $"{string.Concat(from s in sources select $"\n\t{s.alias}: {(s.isEnumerationType ? "Enumeration" : "Singleton")} of {s.sourceType}")}",
            lines is not null ? $"{string.Concat(from l in lines select $"\n\t{l}")}" : "");
    }

    private (Expression sourceExpression, bool[] isSourcePromoted) ProcessQuerySources(Query query)
    {
        AliasedQuerySource[] sources = query.source;

        if (sources.Length is 0)
            throw this.NewExpressionBuildingException("A query must have at least one source.");

        var aliases = sources.SelectToArray(s => s.alias);
        if (aliases.Any(alias => string.IsNullOrEmpty(alias)))
            throw this.NewExpressionBuildingException("Query sources must have aliases.");

        var sourceExpressions = sources
            .SelectToArray(source => TranslateExpression(source.expression));

        // Returns a CrossJoin between IEnumerable<> of T1, T2, T3, etc and return into IEnumerable<(T1, T2, T3, etc)>
        // a) If a source is not of a list-type (ie, a singleton), it needs to be promoted to a list type.
        // b) Cross-Join
        //    IEnumerable<A> a = ...;
        //    IEnumerable<B> b = ...;
        //    IEnumerable<c> c = ...;
        //    IEnumerable<(A, B, C)> crossJoinedValueTupleResults = CrossJoin<A, B, C>(a, b, c);

        var temp = sourceExpressions.SelectToArray(expr => PromoteSourceSingletonToList(expr));
        var promotedSourceExpressions = temp.SelectToArray(s => s.source);
        var originalSourceWereSingletons = temp.SelectToArray(s => s.sourceOriginallyASingleton);

        // Only one source, so no need for cross-joining. Return as-is.
        if (sources.Length == 1)
            return (promotedSourceExpressions[0], originalSourceWereSingletons);

        var crossJoinedValueTupleResultsExpression = BindCqlOperator(CqlOperator.CrossJoin, promotedSourceExpressions);

        // Select the IEnumerable<> of value-tuples above into IEnumerable<> of our custom tuple
        // a) Create the custom tuple
        // b) Select
        //    IEnumerable<Tuple_ABC> crossJoinedCqlTupleResults = Select(
        //        crossJoinedValueTupleResults,
        //        valueTuple => {
        //            var abc = new Tuple_ABC();
        //            abc.A = t.Item1;
        //            abc.B = t.Item2;
        //            abc.C = t.Item3;
        //            return abc;
        //        });

        Type[] sourceListElementTypes = promotedSourceExpressions
            .SelectToArray(pse => this._typeManager.Resolver.GetListElementType(pse.Type, true)!);

        var aliasAndElementTypes = aliases
            .Zip(sourceListElementTypes, (alias, elementType) => (alias, elementType))
            .ToDictionary(t => t.alias, t => t.elementType);

        // IEnumerable<(A,B,C)
        var funcResultType = crossJoinedValueTupleResultsExpression.Type;

        // (A,B,C)
        const BindingFlags bfPublicInstance = BindingFlags.Public | BindingFlags.Instance;

        Type valueTupleType = _typeManager.Resolver.GetListElementType(funcResultType, true)!;
        FieldInfo[] valueTupleFields = valueTupleType.GetFields(bfPublicInstance | BindingFlags.GetField);

        Type cqlTupleType = TupleTypeFor(aliasAndElementTypes);
        PropertyInfo[] cqlTupleProperties = cqlTupleType.GetProperties(bfPublicInstance | BindingFlags.SetProperty);

        Debug.Assert(valueTupleFields.Length > 0);
        Debug.Assert(valueTupleFields.Length == cqlTupleProperties.Length);

        var valueTupleTypeParam = Expression.Parameter(valueTupleType, "_valueTuple");
        var selectExpression =
            Expression.Lambda(
                CopyValueTupleIntoCqlTuple(),
                valueTupleTypeParam);

        Expression CopyValueTupleIntoCqlTuple()
        {
            var newCqlTupleExpr = Expression.New(cqlTupleType);

            var memberAssignments = valueTupleFields
                .Zip(cqlTupleProperties, (valueTupleField, cqlTupleProp) => (valueTupleField, cqlTupleProp))
                .SelectToArray(
                    valueTupleFields.Length,
                    t => Expression.Bind(
                    t.cqlTupleProp.GetSetMethod()!,
                    Expression.Field(valueTupleTypeParam, t.valueTupleField)));

            var copyProps = Expression.MemberInit(newCqlTupleExpr, memberAssignments);
            return copyProps;
        }

        var crossJoinedCqlTupleResultsExpression = BindCqlOperator(
            CqlOperator.Select,
            crossJoinedValueTupleResultsExpression,
            selectExpression);

        return (crossJoinedCqlTupleResultsExpression, originalSourceWereSingletons)!;
    }

    protected Expression SortClause(
        Query query,
        Expression @return)
    {
        //[System.Xml.Serialization.XmlIncludeAttribute(typeof(ByExpression))]
        //[System.Xml.Serialization.XmlIncludeAttribute(typeof(ByColumn))]
        //[System.Xml.Serialization.XmlIncludeAttribute(typeof(ByDirection))]
        using (PushElement(query.sort))
        {
            foreach (var by in query.sort.by)
            {
                using (PushElement(by))
                {
                    ListSortDirection order = by.direction.ListSortOrder();
                    switch (by)
                    {
                        case ByExpression byExpression:
                        {
                            var parameterName = "@this";
                            var returnElementType = _typeManager.Resolver.GetListElementType(@return.Type, true)!;
                            var sortMemberParameter = Expression.Parameter(returnElementType, parameterName);
                            var subContext = WithImpliedAlias(parameterName!, sortMemberParameter, byExpression.expression);
                            var sortMemberExpression = subContext.TranslateExpression(byExpression.expression);
                            var lambdaBody = Expression.Convert(sortMemberExpression, typeof(object));
                            var sortLambda = Expression.Lambda(lambdaBody, sortMemberParameter);
                            var sort = BindCqlOperator(CqlOperator.SortBy, @return, sortLambda, Expression.Constant(order, typeof(ListSortDirection)));
                            return sort;
                        }
                        case ByColumn byColumn:
                        {
                            var parameterName = "@this";
                            var returnElementType = _typeManager.Resolver.GetListElementType(@return.Type, true)!;
                            var sortMemberParameter = Expression.Parameter(returnElementType, parameterName);
                            var pathMemberType = TypeFor(byColumn);
                            if (pathMemberType == null)
                            {
                                throw this.NewExpressionBuildingException($"Type specifier {by.resultTypeName} at {by.locator ?? "unknown"} could not be resolved.");
                            }
                            var pathExpression = PropertyHelper(sortMemberParameter, byColumn.path, pathMemberType!);
                            var lambdaBody = Expression.Convert(pathExpression, typeof(object));
                            var sortLambda = Expression.Lambda(lambdaBody, sortMemberParameter);
                            var sort = BindCqlOperator(CqlOperator.SortBy, @return, sortLambda, Expression.Constant(order, typeof(ListSortDirection)));
                            return sort;
                        }
                        default:
                        {
                            var sort = BindCqlOperator(CqlOperator.ListSort, @return, Expression.Constant(order, typeof(ListSortDirection)));
                            return sort;
                        }
                    }
                }
            }
        }
        return @return;
    }

    protected LambdaExpression WithToSelectManyBody(
        ParameterExpression rootScopeParameter,
        RelationshipClause with)
    {
        if (with.expression == null)
            throw this.NewExpressionBuildingException("With must have a 'source' expression.");

        if (with.suchThat == null)
            throw this.NewExpressionBuildingException("With must have a 'such that' expression.");

        //define "With Such That":
        //[Encounter] E
        //  with[Condition] P
        //   such that P.onset during E.period
        //     and P.abatement after end of E.period

        //Func<Bundle, Context, IEnumerable<Encounter>> x = (bundle, ctx) =>
        //    bundle.Entry.ByResourceType<Encounter>()
        //    .SelectMany(E =>
        //        bundle.Entry.ByResourceType<Condition>() // <--
        //            .Where(P => true) // such that goes here
        //            .Select(P => E));
        var source = TranslateExpression(with.expression);
        if (!_typeResolver.ImplementsGenericIEnumerable(source.Type))
        {
            // e.g.:
            // with "Index Prescription Start Date" IPSD
            // where IPSD is a Date
            // Promote to an array for consistency.
            var newArray = Expression.NewArrayInit(source.Type, source);
            source = newArray;
        }
        var sourceElementType = _typeManager.Resolver.GetListElementType(source.Type)!;

        var whereLambdaParameter = Expression.Parameter(sourceElementType, with.alias);
        var whereContext = WithScope(with.alias!, whereLambdaParameter, with);
        var suchThatBody = whereContext.TranslateExpression(with.suchThat);

        var whereLambda = Expression.Lambda(suchThatBody, whereLambdaParameter);
        var callWhereOnSource = BindCqlOperator(CqlOperator.Where, source, whereLambda);

        var selectLambdaParameter = Expression.Parameter(sourceElementType, with.alias);
        var selectBody = rootScopeParameter; // P => E
        var selectLambda = Expression.Lambda(selectBody, selectLambdaParameter);
        var callSelectOnWhere = BindCqlOperator(CqlOperator.Select, callWhereOnSource, selectLambda);
        var selectManyLambda = Expression.Lambda(callSelectOnWhere, rootScopeParameter);

        return selectManyLambda;
    }


    protected Expression Where(
        Elm.Expression queryWhere,
        ParameterExpression sourceParameter,
        Expression @return)
    {
        using (PushElement(queryWhere))
        {
            var whereBody = TranslateExpression(queryWhere);
            var whereLambda = Expression.Lambda(whereBody, sourceParameter);
            var callWhere = BindCqlOperator(CqlOperator.Where, @return, whereLambda);
            return callWhere;
        }
    }

    protected Expression AggregateClause(
        Query query,
        AggregateClause queryAggregate,
        ParameterExpression sourceParameter,
        Expression @return)
    {
        using (PushElement(queryAggregate))
        {
            var resultAlias = queryAggregate.identifier!;
            Type? resultType = null;
            if (queryAggregate.resultTypeSpecifier is { } typeSpecifier)
            {
                resultType = TypeFor(typeSpecifier);
            }
            else if (!string.IsNullOrWhiteSpace(queryAggregate.resultTypeName.Name!))
            {
                resultType = _typeManager.Resolver.ResolveType(queryAggregate.resultTypeName.Name!);
            }

            if (resultType is null)
                throw this.NewExpressionBuildingException(
                    $"Could not resolve aggregate query result type for query {query.localId} at {query.locator}");

            var resultParameter = Expression.Parameter(resultType, resultAlias);
            var subContext = WithScope(resultAlias!, resultParameter, queryAggregate);
            var startingValue = subContext.TranslateExpression(queryAggregate.starting!);

            var lambdaBody = subContext.TranslateExpression(queryAggregate.expression!);
            var lambda = Expression.Lambda(lambdaBody, resultParameter, sourceParameter);
            var aggregateCall = BindCqlOperator(CqlOperator.Aggregate,
                @return, lambda, startingValue);
            return aggregateCall;
        }
    }

}