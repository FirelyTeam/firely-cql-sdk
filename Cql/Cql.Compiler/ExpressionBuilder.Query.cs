namespace Hl7.Cql.Compiler;

using Hl7.Cql.Abstractions;
using Hl7.Cql.Elm;
using System;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using elm = Hl7.Cql.Elm;
using Expression = System.Linq.Expressions.Expression;

using ExpressionElementPairForIdentifier = System.Collections.Generic.KeyValuePair<string, (System.Linq.Expressions.Expression, Hl7.Cql.Elm.Element)>;


internal partial class ExpressionBuilder
{
    protected Expression Query(elm.Query query, ExpressionBuilderContext ctx)
    {
        return query.source?.Length switch
        {
            null or 0 => throw ctx.NewExpressionBuildingException("Queries must define at least 1 source"),
            1 => SingleSourceQuery(query, ctx),
            _ => MultiSourceQuery(query, ctx),
        };
    }
        
    protected Expression SingleSourceQuery(Query query, ExpressionBuilderContext ctx)
    {
        var querySource = query.source.Single();
        var querySourceAlias = !string.IsNullOrWhiteSpace(querySource.alias)
            ? querySource.alias
            : throw ctx.NewExpressionBuildingException("Only aliased query sources are supported.");

        if (querySource.expression is null)
            throw ctx.NewExpressionBuildingException("Query sources must have an expression");

        var source = TranslateExpression(querySource.expression, ctx);
        
        var promotedSource = false;
        // promote single objects into enumerables so where works
        if (!IsOrImplementsIEnumerableOfT(source.Type))
        {
            var arrayInit = Expression.NewArrayInit(source.Type, source);
            source = arrayInit;
            promotedSource = true;
        }
       
        var @return = source;

        Type elementType = _typeManager.Resolver.GetListElementType(@return.Type, @throw: true)!;

        var rootScopeParameterName = ExpressionBuilderContext.NormalizeIdentifier(querySourceAlias);
        var rootScopeParameter = Expression.Parameter(elementType, rootScopeParameterName);
        ctx = ctx.WithScope(querySourceAlias, rootScopeParameter, querySource.expression);
        
        if (query.let != null)
        {
            foreach (var let in query.let)
            {
                var expression = TranslateExpression(let.expression!, ctx);
                ctx = ctx.WithScope(let.identifier!, expression, let.expression!);
            }
        }

        // handle with/such-that
        if (query.relationship is not null)
        {
            foreach (var relationship in query.relationship)
            {
                ctx = ctx.Deeper(relationship);

                var selectManyLambda = WithToSelectManyBody(rootScopeParameter, relationship, ctx);

                var selectManyCall = ctx.OperatorBinding.Bind(CqlOperator.SelectMany, ctx.RuntimeContextParameter,
                    @return, selectManyLambda);
                if (relationship is Without)
                {
                    var callExcept = ctx.OperatorBinding.Bind(CqlOperator.ListExcept, ctx.RuntimeContextParameter,
                        @return, selectManyCall);
                    @return = callExcept;
                }
                else
                {
                    @return = selectManyCall;
                }

                ctx = ctx.Pop();
            }
        }
            
        // 20240312 EK: refactoring made this redundant, but I am not sure it really is, so I am keeping
        // it around. It was used to redefine the type for the "rootScopeParameter", which used to be defined
        // inside every if statement here (so for where, return, etc).
        // -----
        // The element type may have changed
        // elementType = TypeManager.Resolver.GetListElementType(@return.Type, @throw: true)!;

        if (query.where != null)
        {
            ctx = ctx.Deeper(query.where);
            
            var whereBody = TranslateExpression(query.where, ctx);
            var whereLambda = Expression.Lambda(whereBody, rootScopeParameter);
            var callWhere = ctx.OperatorBinding.Bind(CqlOperator.Where, ctx.RuntimeContextParameter, @return, whereLambda);
            @return = callWhere;

            ctx = ctx.Pop();
        }

        if (query.@return != null)
        {
            ctx = ctx.Deeper(query.@return);

            var selectBody = TranslateExpression(query.@return.expression!, ctx);
            var selectLambda = Expression.Lambda(selectBody, rootScopeParameter);
            var callSelect = ctx.OperatorBinding.Bind(CqlOperator.Select, ctx.RuntimeContextParameter, @return, selectLambda);
            @return = callSelect;

            ctx = ctx.Pop();
        }

        if (query.aggregate != null)
        {
            ctx = ctx.Deeper(query.aggregate);

            var resultAlias = query.aggregate.identifier!;
            Type? resultType = null;
            if (query.aggregate.resultTypeSpecifier != null)
            {
                resultType = _typeManager.TypeFor(query.aggregate.resultTypeSpecifier, ctx);
            }
            else if (!string.IsNullOrWhiteSpace(query.aggregate.resultTypeName.Name!))
            {
                resultType = _typeManager.Resolver.ResolveType(query.aggregate.resultTypeName.Name!);
            }

            if (resultType is null)
                throw ctx.NewExpressionBuildingException($"Could not resolve aggregate query result type for query {query.localId} at {query.locator}");

            var resultParameter = Expression.Parameter(resultType, resultAlias);
            var subContext = ctx.WithScope(resultAlias!, resultParameter, query.aggregate);
            var startingValue = TranslateExpression(query.aggregate.starting!, subContext);

            var lambdaBody = TranslateExpression(query.aggregate.expression!, subContext);
            var lambda = Expression.Lambda(lambdaBody, resultParameter, rootScopeParameter);
            var aggregateCall = ctx.OperatorBinding.Bind(CqlOperator.Aggregate, subContext.RuntimeContextParameter, @return, lambda, startingValue);
            @return = aggregateCall;

            ctx = ctx.Pop();
        }


        //[System.Xml.Serialization.XmlIncludeAttribute(typeof(ByExpression))]
        //[System.Xml.Serialization.XmlIncludeAttribute(typeof(ByColumn))]
        //[System.Xml.Serialization.XmlIncludeAttribute(typeof(ByDirection))]
        if (query.sort != null && query.sort.by != null && query.sort.by.Length > 0)
        {
            ctx = ctx.Deeper(query.sort);

            foreach (var by in query.sort.by)
            {
                ctx = ctx.Deeper(by);

                ListSortDirection order = ExtensionMethods.ListSortOrder(by.direction);
                if (by is ByExpression byExpression)
                {
                    var parameterName = "@this";
                    var returnElementType = _typeManager.Resolver.GetListElementType(@return.Type, true)!;
                    var sortMemberParameter = Expression.Parameter(returnElementType, parameterName);
                    var subContext = ctx.WithImpliedAlias(parameterName!, sortMemberParameter, byExpression.expression);
                    var sortMemberExpression = TranslateExpression(byExpression.expression, subContext);
                    var lambdaBody = Expression.Convert(sortMemberExpression, typeof(object));
                    var sortLambda = Expression.Lambda(lambdaBody, sortMemberParameter);
                    var sort = ctx.OperatorBinding.Bind(CqlOperator.SortBy, ctx.RuntimeContextParameter,
                        @return, sortLambda, Expression.Constant(order, typeof(ListSortDirection)));
                    @return = sort;
                }
                else if (by is ByColumn byColumn)
                {
                    var parameterName = "@this";
                    var returnElementType = _typeManager.Resolver.GetListElementType(@return.Type, true)!;
                    var sortMemberParameter = Expression.Parameter(returnElementType, parameterName);
                    var pathMemberType = _typeManager.TypeFor(byColumn, ctx);
                    if (pathMemberType == null)
                    {
                        throw ctx.NewExpressionBuildingException($"Type specifier {by.resultTypeName} at {by.locator ?? "unknown"} could not be resolved.");
                    }
                    var pathExpression = PropertyHelper(sortMemberParameter, byColumn.path, pathMemberType!, ctx);
                    var lambdaBody = Expression.Convert(pathExpression, typeof(object));
                    var sortLambda = Expression.Lambda(lambdaBody, sortMemberParameter);
                    var sort = ctx.OperatorBinding.Bind(CqlOperator.SortBy, ctx.RuntimeContextParameter,
                        @return, sortLambda, Expression.Constant(order, typeof(ListSortDirection)));
                    @return = sort;
                }
                else
                {
                    var sort = ctx.OperatorBinding.Bind(CqlOperator.Sort, ctx.RuntimeContextParameter,
                        @return, Expression.Constant(order, typeof(ListSortDirection)));
                    @return = sort;
                }

                ctx = ctx.Pop();
            }

            ctx = ctx.Pop();
        }

        // Because we promoted the source to a list, we now have to demote the result again.
        if (promotedSource)
        {
            var callSingle = ctx.OperatorBinding.Bind(CqlOperator.Single, ctx.RuntimeContextParameter, @return);
            @return = callSingle;
        }
        
        return @return;
    }
    protected Expression MultiSourceQuery(Query query, ExpressionBuilderContext ctx)
    {
        // The technique here is to create a cross product of all the query sources.
        // The combinations will be stored in a tuple whose fields are named by source alias.
        // we will then create an expression that creates this cross-product of tuples,
        // and use that as the singular query source for subsequent parts of the query.
        var tupleSpecifier = new elm.TupleTypeSpecifier
        {
            element = query.source.Select(source =>
            {
                return new TupleElementDefinition
                {
                    name = source.alias ?? throw ctx.NewExpressionBuildingException("Missing alias for multi-source query; this is illegal"),
                    elementType = source.resultTypeSpecifier,
                };
            }).ToArray(),
        };
        var multiSourceTupleType = _typeManager.TupleTypeFor(tupleSpecifier, ctx, (type) =>
            IsOrImplementsIEnumerableOfT(type)
                ? _typeManager.Resolver.GetListElementType(type, true)!
                : throw new NotSupportedException("Query sources must be lists."));
        var crossJoinedSource = CrossJoin(query.source!, multiSourceTupleType, ctx);
        var source = crossJoinedSource;

        var isSingle = false;
        if (!IsOrImplementsIEnumerableOfT(source.Type))
        {
            var arrayInit = Expression.NewArrayInit(source.Type, source);
            source = arrayInit;
            isSingle = true;
        }

        var @return = source;
        
        if (query.let != null)
        {
            foreach (var let in query.let)
            {
                var expression = TranslateExpression(let.expression!, ctx);
                ctx = ctx.WithScope(let.identifier!, expression, let.expression!);
            }
        }
        
        if (query.relationship is not null)
        {
            foreach (var relationship in query.relationship)
            {
                var selectManyLambda = WithToSelectManyBody(multiSourceTupleType, relationship, ctx);

                var selectManyCall = ctx.OperatorBinding.Bind(CqlOperator.SelectMany, ctx.RuntimeContextParameter,
                    @return, selectManyLambda);
                if (relationship is Without)
                {
                    var callExcept = ctx.OperatorBinding.Bind(CqlOperator.ListExcept, ctx.RuntimeContextParameter,
                        @return, selectManyCall);
                    @return = callExcept;
                }
                else
                {
                    @return = selectManyCall;
                }
            }
        }

        var elementType = _typeManager.Resolver.GetListElementType(@return.Type, true)!;
        if (query.where != null)
        {
            var parameterName = TypeNameToIdentifier(elementType, ctx);

            var whereLambdaParameter = Expression.Parameter(multiSourceTupleType, parameterName);
            var scopes =
                (
                    from property in multiSourceTupleType!.GetProperties()
                    let propertyAccess = Expression.Property(whereLambdaParameter, property)
                    select new ExpressionElementPairForIdentifier(property.Name, (propertyAccess, query.@where))
                )
                .ToArray();
            var subContext = ctx.WithScopes(scopes);
            
            var whereBody = TranslateExpression(query.where, subContext);
            var whereLambda = Expression.Lambda(whereBody, whereLambdaParameter);
            var callWhere = ctx.OperatorBinding.Bind(CqlOperator.Where, ctx.RuntimeContextParameter, @return, whereLambda);
            @return = callWhere;
        }



        if (query.@return != null)
        {
            var parameterName = TypeNameToIdentifier(elementType, ctx);
            var selectLambdaParameter = Expression.Parameter(elementType, parameterName);

            var scopes =
                (
                    from property in multiSourceTupleType!.GetProperties()
                    let propertyAccess = Expression.Property(selectLambdaParameter, property)
                    select new ExpressionElementPairForIdentifier(property.Name, (propertyAccess, query.@return))
                )
                .ToArray();
            var subContext = ctx.WithScopes(scopes);

            var selectBody = TranslateExpression(query.@return.expression!, subContext);
            var selectLambda = Expression.Lambda(selectBody, selectLambdaParameter);
            var callSelect = ctx.OperatorBinding.Bind(CqlOperator.Select, ctx.RuntimeContextParameter, @return, selectLambda);
            @return = callSelect;
        }

        if (query.aggregate != null)
        {
            if (query.aggregate is AggregateClause)
            {
                var parameterName = TypeNameToIdentifier(elementType, ctx);
                var sourceParameter = Expression.Parameter(multiSourceTupleType, parameterName);
                var scopes =
                    (
                        from property in multiSourceTupleType!.GetProperties()
                        let propertyAccess = Expression.Property(sourceParameter, property)
                        select new ExpressionElementPairForIdentifier(property.Name, (propertyAccess, query))
                    )
                    .ToArray();
                var subContext = ctx.WithScopes(scopes);

                var resultAlias = query.aggregate.identifier!;
                Type? resultType = null;
                if (query.aggregate.resultTypeSpecifier != null)
                {
                    resultType = _typeManager.TypeFor(query.aggregate.resultTypeSpecifier, ctx);
                }
                else if (!string.IsNullOrWhiteSpace(query.aggregate.resultTypeName.Name!))
                {
                    resultType = _typeManager.Resolver.ResolveType(query.aggregate.resultTypeName.Name!);
                }

                if (resultType is null)
                    throw ctx.NewExpressionBuildingException($"Could not resolve aggregate query result type for query {query.localId} at {query.locator}");

                var resultParameter = Expression.Parameter(resultType, resultAlias);

                subContext = subContext.WithScope(resultAlias, resultParameter, query.aggregate);

                var startingValue = TranslateExpression(query.aggregate.starting!, subContext);

                var lambdaBody = TranslateExpression(query.aggregate.expression!, subContext);
                var lambda = Expression.Lambda(lambdaBody, resultParameter, sourceParameter);
                var aggregateCall = ctx.OperatorBinding.Bind(CqlOperator.Aggregate, subContext.RuntimeContextParameter, @return, lambda, startingValue);
                @return = aggregateCall;
            }
            else
            {
                throw new NotImplementedException($"Aggregate type {query.aggregate.GetType().Name} is not yet implemented.").WithContext(ctx);
            }
        }

        if (query.sort != null && query.sort.by != null && query.sort.by.Length > 0)
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

        if (isSingle)
        {
            var returnElementType = _typeManager.Resolver.GetListElementType(@return.Type);
            var callSingle = ctx.OperatorBinding.Bind(CqlOperator.Single, ctx.RuntimeContextParameter, @return);
            @return = callSingle;
        }

        return @return;
    }

    protected LambdaExpression WithToSelectManyBody(ParameterExpression rootScopeParameter,
        RelationshipClause with,
        ExpressionBuilderContext ctx)
    {
        if (with.expression == null)
            throw ctx.NewExpressionBuildingException($"With must have a 'source' expression.");
        if (with.suchThat == null)
            throw ctx.NewExpressionBuildingException($"With must have a 'such that' expression.");

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
        var source = TranslateExpression(with.expression, ctx);
        if (!IsOrImplementsIEnumerableOfT(source.Type))
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
        var whereContext = ctx.WithScope(with.alias!, whereLambdaParameter, with);
        var suchThatBody = TranslateExpression(with.suchThat, whereContext);

        var whereLambda = Expression.Lambda(suchThatBody, whereLambdaParameter);
        var callWhereOnSource = ctx.OperatorBinding.Bind(CqlOperator.Where, ctx.RuntimeContextParameter, source, whereLambda);

        var selectLambdaParameter = Expression.Parameter(sourceElementType, with.alias);
        var selectBody = rootScopeParameter; // P => E
        var selectLambda = Expression.Lambda(selectBody, selectLambdaParameter);
        var callSelectOnWhere = ctx.OperatorBinding.Bind(CqlOperator.Select, ctx.RuntimeContextParameter, callWhereOnSource, selectLambda);
        var selectManyLambda = Expression.Lambda(callSelectOnWhere, rootScopeParameter);

        return selectManyLambda;
    }

    protected LambdaExpression WithToSelectManyBody(Type tupleType,
        RelationshipClause with,
        ExpressionBuilderContext ctx)
    {
        if (with.expression == null)
            throw ctx.NewExpressionBuildingException($"With must have a source expression.");
        if (with.suchThat == null)
            throw ctx.NewExpressionBuildingException($"With must have a suchthat expression.");

        //define "With Such That":
        //from [Encounter] enc,
        //  [Observation] obs
        //  with[Condition] P
        //   such that P.onset during E.period
        //     and P.abatement after end of E.period

        // A tuple type is created e.g.:
        // class Tuple1
        // {
        //      Encounter enc { get; set; }
        //      Observation obs { get; set; }
        // }
        //  We then cross join all combinations of encs and observations into an IEnumerable<TupleT>
        //  In the CQL, "enc" and "obs" are valid scopes in the with and such-that clauses.
        //  They need to resolve to property accessors
        //  on the lambda parameter we create for the SelectMany call.
        //  IEnumerable<Tuple1> source = <cross join expression>;
        //
        //  source
        //    .SelectMany(T => 
        //        bundle.Entry.ByResourceType<Condition>() // <-- 
        //            .Where(P => true) // such that goes here, in place of "true"
        //            .Select(P => E));

        var selectManyParameter = Expression.Parameter(tupleType, TypeNameToIdentifier(tupleType, ctx));
        var scopes = (from property in tupleType.GetProperties()
                let propertyAccess = Expression.Property(selectManyParameter, property)
                select new ExpressionElementPairForIdentifier(property.Name, (propertyAccess, with)))
            .ToArray();
        var selectManyContext = ctx.WithScopes(scopes);

        var source = TranslateExpression(with.expression, selectManyContext);
        var sourceElementType = _typeManager.Resolver.GetListElementType(source.Type)!;

        var whereLambdaParameter = Expression.Parameter(sourceElementType, with.alias);
        var whereContext = selectManyContext.WithScope(with.alias!, whereLambdaParameter, with);
        var suchThatBody = TranslateExpression(with.suchThat, whereContext);
        var whereLambda = Expression.Lambda(suchThatBody, whereLambdaParameter);
        var callWhereOnSource = ctx.OperatorBinding.Bind(CqlOperator.Where, ctx.RuntimeContextParameter, source, whereLambda);

        var selectLambdaParameter = Expression.Parameter(sourceElementType, with.alias);
        var selectBody = selectManyParameter; // P => E
        var selectLambda = Expression.Lambda(selectBody, selectLambdaParameter);
        var callSelectOnWhere = ctx.OperatorBinding.Bind(CqlOperator.Select, ctx.RuntimeContextParameter, callWhereOnSource, selectLambda);

        var selectManyLambda = Expression.Lambda(callSelectOnWhere, selectManyParameter);
        return selectManyLambda;
    }

        
}