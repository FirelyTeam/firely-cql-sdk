namespace Hl7.Cql.Compiler;

using Abstractions;
using Elm;
using System;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using elm = Elm;
using Expression = System.Linq.Expressions.Expression;

using ExpressionElementPairForIdentifier = System.Collections.Generic.KeyValuePair<string, (System.Linq.Expressions.Expression, Elm.Element)>;


internal partial class ExpressionBuilder
{
    protected Expression Query(Query query)
    {
        return query.source?.Length switch
        {
            null or 0 => throw this.NewExpressionBuildingException("Queries must define at least 1 source"),
            1 => SingleSourceQuery(query),
            _ => MultiSourceQuery(query),
        };
    }
        
    protected Expression SingleSourceQuery(Query query)
    {
        ExpressionBuilder ctx = this;
        var querySource = query.source.Single();
        var querySourceAlias = !string.IsNullOrWhiteSpace(querySource.alias)
            ? querySource.alias
            : throw ctx.NewExpressionBuildingException("Only aliased query sources are supported.");

        if (querySource.expression is null)
            throw ctx.NewExpressionBuildingException("Query sources must have an expression");

        var source = ctx.TranslateExpression(querySource.expression);
        
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

        var rootScopeParameterName = NormalizeIdentifier(querySourceAlias);
        var rootScopeParameter = Expression.Parameter(elementType, rootScopeParameterName);
        ctx = WithScope(querySourceAlias, rootScopeParameter, querySource.expression);
        
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
                using var _ = ctx.PushElement(relationship);

                var selectManyLambda = ctx.WithToSelectManyBody(rootScopeParameter, relationship);

                var selectManyCall = ctx._operatorBinding.Bind(CqlOperator.SelectMany, LibraryDefinitionsBuilder.ContextParameter,
                    @return, selectManyLambda);
                if (relationship is Without)
                {
                    var callExcept = ctx._operatorBinding.Bind(CqlOperator.ListExcept, LibraryDefinitionsBuilder.ContextParameter,
                        @return, selectManyCall);
                    @return = callExcept;
                }
                else
                {
                    @return = selectManyCall;
                }
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
            using var _ = ctx.PushElement(query.where);
            
            var whereBody = ctx.TranslateExpression(query.where);
            var whereLambda = Expression.Lambda(whereBody, rootScopeParameter);
            var callWhere = ctx._operatorBinding.Bind(CqlOperator.Where, LibraryDefinitionsBuilder.ContextParameter, @return, whereLambda);
            @return = callWhere;
        }

        if (query.@return != null)
        {
            using var _ = ctx.PushElement(query.@return);

            var selectBody = ctx.TranslateExpression(query.@return.expression!);
            var selectLambda = Expression.Lambda(selectBody, rootScopeParameter);
            var callSelect = ctx._operatorBinding.Bind(CqlOperator.Select, LibraryDefinitionsBuilder.ContextParameter, @return, selectLambda);
            @return = callSelect;
        }

        if (query.aggregate != null)
        {
            using var _ = ctx.PushElement(query.aggregate);

            var resultAlias = query.aggregate.identifier!;
            Type? resultType = null;
            if (query.aggregate.resultTypeSpecifier != null)
            {
                resultType = TypeFor(query.aggregate.resultTypeSpecifier);
            }
            else if (!string.IsNullOrWhiteSpace(query.aggregate.resultTypeName.Name!))
            {
                resultType = _typeManager.Resolver.ResolveType(query.aggregate.resultTypeName.Name!);
            }

            if (resultType is null)
                throw ctx.NewExpressionBuildingException($"Could not resolve aggregate query result type for query {query.localId} at {query.locator}");

            var resultParameter = Expression.Parameter(resultType, resultAlias);
            var subContext = ctx.WithScope(resultAlias!, resultParameter, query.aggregate);
            var startingValue = subContext.TranslateExpression(query.aggregate.starting!);

            var lambdaBody = subContext.TranslateExpression(query.aggregate.expression!);
            var lambda = Expression.Lambda(lambdaBody, resultParameter, rootScopeParameter);
            var aggregateCall = ctx._operatorBinding.Bind(CqlOperator.Aggregate, LibraryDefinitionsBuilder.ContextParameter, @return, lambda, startingValue);
            @return = aggregateCall;
        }


        //[System.Xml.Serialization.XmlIncludeAttribute(typeof(ByExpression))]
        //[System.Xml.Serialization.XmlIncludeAttribute(typeof(ByColumn))]
        //[System.Xml.Serialization.XmlIncludeAttribute(typeof(ByDirection))]
        if (query.sort != null && query.sort.by != null && query.sort.by.Length > 0)
        {
            using var _ = ctx.PushElement(query.sort);

            foreach (var by in query.sort.by)
            {
                using var _2 = ctx.PushElement(by);

                ListSortDirection order = by.direction.ListSortOrder();
                if (by is ByExpression byExpression)
                {
                    var parameterName = "@this";
                    var returnElementType = ctx._typeManager.Resolver.GetListElementType(@return.Type, true)!;
                    var sortMemberParameter = Expression.Parameter(returnElementType, parameterName);
                    var subContext = ctx.WithImpliedAlias(parameterName!, sortMemberParameter, byExpression.expression);
                    var sortMemberExpression = subContext.TranslateExpression(byExpression.expression);
                    var lambdaBody = Expression.Convert(sortMemberExpression, typeof(object));
                    var sortLambda = Expression.Lambda(lambdaBody, sortMemberParameter);
                    var sort = ctx._operatorBinding.Bind(CqlOperator.SortBy, LibraryDefinitionsBuilder.ContextParameter,
                        @return, sortLambda, Expression.Constant(order, typeof(ListSortDirection)));
                    @return = sort;
                }
                else if (by is ByColumn byColumn)
                {
                    var parameterName = "@this";
                    var returnElementType = ctx._typeManager.Resolver.GetListElementType(@return.Type, true)!;
                    var sortMemberParameter = Expression.Parameter(returnElementType, parameterName);
                    var pathMemberType = ctx.TypeFor(byColumn);
                    if (pathMemberType == null)
                    {
                        throw ctx.NewExpressionBuildingException($"Type specifier {by.resultTypeName} at {by.locator ?? "unknown"} could not be resolved.");
                    }
                    var pathExpression = ctx.PropertyHelper(sortMemberParameter, byColumn.path, pathMemberType!);
                    var lambdaBody = Expression.Convert(pathExpression, typeof(object));
                    var sortLambda = Expression.Lambda(lambdaBody, sortMemberParameter);
                    var sort = ctx._operatorBinding.Bind(CqlOperator.SortBy, LibraryDefinitionsBuilder.ContextParameter,
                        @return, sortLambda, Expression.Constant(order, typeof(ListSortDirection)));
                    @return = sort;
                }
                else
                {
                    var sort = ctx._operatorBinding.Bind(CqlOperator.Sort, LibraryDefinitionsBuilder.ContextParameter,
                        @return, Expression.Constant(order, typeof(ListSortDirection)));
                    @return = sort;
                }
            }
        }

        // Because we promoted the source to a list, we now have to demote the result again.
        if (promotedSource)
        {
            var callSingle = ctx._operatorBinding.Bind(CqlOperator.Single, LibraryDefinitionsBuilder.ContextParameter, @return);
            @return = callSingle;
        }
        
        return @return;
    }

    protected Expression MultiSourceQuery(Query query)
    {
        ExpressionBuilder ctx = this;
        // The technique here is to create a cross product of all the query sources.
        // The combinations will be stored in a tuple whose fields are named by source alias.
        // we will then create an expression that creates this cross-product of tuples,
        // and use that as the singular query source for subsequent parts of the query.
        var tupleSpecifier = new TupleTypeSpecifier
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
        var multiSourceTupleType = TupleTypeFor(tupleSpecifier, (type) => 
            IsOrImplementsIEnumerableOfT(type)
                ? _typeManager.Resolver.GetListElementType(type, true)!
                : throw new NotSupportedException("Query sources must be lists."));
        var crossJoinedSource = ctx.CrossJoin(query.source!, multiSourceTupleType);
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
                var expression = ctx.TranslateExpression(let.expression!);
                ctx = ctx.WithScope(let.identifier!, expression, let.expression!);
            }
        }
        
        if (query.relationship is not null)
        {
            foreach (var relationship in query.relationship)
            {
                var selectManyLambda = ctx.WithToSelectManyBody(multiSourceTupleType, relationship);

                var selectManyCall = ctx._operatorBinding.Bind(CqlOperator.SelectMany, LibraryDefinitionsBuilder.ContextParameter,
                    @return, selectManyLambda);
                if (relationship is Without)
                {
                    var callExcept = ctx._operatorBinding.Bind(CqlOperator.ListExcept, LibraryDefinitionsBuilder.ContextParameter,
                        @return, selectManyCall);
                    @return = callExcept;
                }
                else
                {
                    @return = selectManyCall;
                }
            }
        }

        var elementType = ctx._typeManager.Resolver.GetListElementType(@return.Type, true)!;
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
            
            var whereBody = subContext.TranslateExpression(query.where);
            var whereLambda = Expression.Lambda(whereBody, whereLambdaParameter);
            var callWhere = ctx._operatorBinding.Bind(CqlOperator.Where, LibraryDefinitionsBuilder.ContextParameter, @return, whereLambda);
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

            var selectBody = subContext.TranslateExpression(query.@return.expression!);
            var selectLambda = Expression.Lambda(selectBody, selectLambdaParameter);
            var callSelect = ctx._operatorBinding.Bind(CqlOperator.Select, LibraryDefinitionsBuilder.ContextParameter, @return, selectLambda);
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
                    resultType = ctx.TypeFor(query.aggregate.resultTypeSpecifier);
                }
                else if (!string.IsNullOrWhiteSpace(query.aggregate.resultTypeName.Name!))
                {
                    resultType = ctx._typeManager.Resolver.ResolveType(query.aggregate.resultTypeName.Name!);
                }

                if (resultType is null)
                    throw ctx.NewExpressionBuildingException($"Could not resolve aggregate query result type for query {query.localId} at {query.locator}");

                var resultParameter = Expression.Parameter(resultType, resultAlias);

                subContext = subContext.WithScope(resultAlias, resultParameter, query.aggregate);

                var startingValue = subContext.TranslateExpression(query.aggregate.starting!);

                var lambdaBody = subContext.TranslateExpression(query.aggregate.expression!);
                var lambda = Expression.Lambda(lambdaBody, resultParameter, sourceParameter);
                var aggregateCall = ctx._operatorBinding.Bind(CqlOperator.Aggregate, LibraryDefinitionsBuilder.ContextParameter, @return, lambda, startingValue);
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
            var callSingle = ctx._operatorBinding.Bind(CqlOperator.Single, LibraryDefinitionsBuilder.ContextParameter, @return);
            @return = callSingle;
        }

        return @return;
    }

    protected LambdaExpression WithToSelectManyBody(ParameterExpression rootScopeParameter,
        RelationshipClause with)
    {
        if (with.expression == null)
            throw this.NewExpressionBuildingException($"With must have a 'source' expression.");
        if (with.suchThat == null)
            throw this.NewExpressionBuildingException($"With must have a 'such that' expression.");

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
        var whereContext = WithScope(with.alias!, whereLambdaParameter, with);
        var suchThatBody = whereContext.TranslateExpression(with.suchThat);

        var whereLambda = Expression.Lambda(suchThatBody, whereLambdaParameter);
        var callWhereOnSource = _operatorBinding.Bind(CqlOperator.Where, LibraryDefinitionsBuilder.ContextParameter, source, whereLambda);

        var selectLambdaParameter = Expression.Parameter(sourceElementType, with.alias);
        var selectBody = rootScopeParameter; // P => E
        var selectLambda = Expression.Lambda(selectBody, selectLambdaParameter);
        var callSelectOnWhere = _operatorBinding.Bind(CqlOperator.Select, LibraryDefinitionsBuilder.ContextParameter, callWhereOnSource, selectLambda);
        var selectManyLambda = Expression.Lambda(callSelectOnWhere, rootScopeParameter);

        return selectManyLambda;
    }

    protected LambdaExpression WithToSelectManyBody(Type tupleType,
        RelationshipClause with)
    {
        if (with.expression == null)
            throw this.NewExpressionBuildingException($"With must have a source expression.");
        if (with.suchThat == null)
            throw this.NewExpressionBuildingException($"With must have a suchthat expression.");

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

        var selectManyParameter = Expression.Parameter(tupleType, TypeNameToIdentifier(tupleType, this));
        var scopes = (from property in tupleType.GetProperties()
                let propertyAccess = Expression.Property(selectManyParameter, property)
                select new ExpressionElementPairForIdentifier(property.Name, (propertyAccess, with)))
            .ToArray();
        var selectManyContext = WithScopes(scopes);

        var source = selectManyContext.TranslateExpression(with.expression);
        var sourceElementType = _typeManager.Resolver.GetListElementType(source.Type)!;

        var whereLambdaParameter = Expression.Parameter(sourceElementType, with.alias);
        var whereContext = selectManyContext.WithScope(with.alias!, whereLambdaParameter, with);
        var suchThatBody = selectManyContext.TranslateExpression(with.suchThat);
        var whereLambda = Expression.Lambda(suchThatBody, whereLambdaParameter);
        var callWhereOnSource = _operatorBinding.Bind(CqlOperator.Where, LibraryDefinitionsBuilder.ContextParameter, source, whereLambda);

        var selectLambdaParameter = Expression.Parameter(sourceElementType, with.alias);
        var selectBody = selectManyParameter; // P => E
        var selectLambda = Expression.Lambda(selectBody, selectLambdaParameter);
        var callSelectOnWhere = _operatorBinding.Bind(CqlOperator.Select, LibraryDefinitionsBuilder.ContextParameter, callWhereOnSource, selectLambda);

        var selectManyLambda = Expression.Lambda(callSelectOnWhere, selectManyParameter);
        return selectManyLambda;
    }

        
}