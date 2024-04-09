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
using Expression = System.Linq.Expressions.Expression;
using Hl7.Cql.Elm;

using ExpressionElementPairForIdentifier = System.Collections.Generic.KeyValuePair<string, (System.Linq.Expressions.Expression, Hl7.Cql.Elm.Element)>;

namespace Hl7.Cql.Compiler;

internal partial class ExpressionBuilder
{
    protected Expression Query(Query query)
    {
        var sourceLength = query.source?.Length ?? 0;

#if DEBUG // REVIEW: For debugging purposes right now - might delete at a later stage
        var lines = ReadCqlLines(query);
        var sources = ReadSources();

        (string alias, Type sourceType, bool isEnumerationType)[] ReadSources() => query.source!
            .SelectToArray(s =>
            {
                var sourceType = TranslateExpression(s.expression).Type;
                var isEnumerationType = IsOrImplementsIEnumerableOfT(sourceType);
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

            var elmFilePath = LibraryContext.Library.OriginalFilePath;
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
#endif

        return QueryImpl(query);
    }

    protected Expression QueryImpl(Query query)
    {
        ExpressionBuilder ctx = this;

        var sources = query.source;
        if (sources.Length == 0)
        {
            throw ctx.NewExpressionBuildingException("Queries must define at least 1 source");
        }

        ParameterExpression scopeParameter;

        var (@return, isSourcesPromoted) = ctx.ProcessQuerySources(query);
        var isAnySourcePromoted = isSourcesPromoted.Any(isSourcePromoted => isSourcePromoted);
        var returnType = ctx._typeManager.Resolver.GetListElementType(@return.Type, true)!;
        var returnElementType = ctx._typeManager.Resolver.GetListElementType(@return.Type, true)!;
        if (returnElementType != returnType)
            throw ctx.NewExpressionBuildingException(
                $"Expected element type {returnType.Name} but got {returnElementType.Name}");

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
                    from property in returnType!.GetProperties()
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
                var callSelect = ctx._operatorBinding.Bind(CqlOperator.Select, LibraryDefinitionsBuilder.ContextParameter, @return, selectLambda);
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

        return ctx.TryDemoteSource(query, @return, isAnySourcePromoted);
    }

    protected Expression TryDemoteSource(
        Query query,
        Expression source,
        bool isSourcePromoted)
    {
        // Because we promoted the source to a list, we now have to demote the result again.
        if (isSourcePromoted)
        {
            var callSingle = _operatorBinding.Bind(CqlOperator.Single, LibraryDefinitionsBuilder.ContextParameter, source);
            source = callSingle;

        }

        if (query.resultTypeSpecifier is Elm.ListTypeSpecifier && !IsOrImplementsIEnumerableOfT(source.Type))
        {
            source = Expression.NewArrayInit(source.Type, source);
        }

        return source;
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

        var tryPromoteSourceExpressions = sourceExpressions.SelectToArray(expr => TryPromoteSource(expr));
        var promotedSourceExpressions = tryPromoteSourceExpressions.SelectToArray(s => s.source);
        var isSourcesPromoted = tryPromoteSourceExpressions.SelectToArray(s => s.isSourcePromoted);

        if (promotedSourceExpressions.Any(promotedSource => !IsOrImplementsIEnumerableOfT(promotedSource.Type)))
            throw this.NewExpressionBuildingException("A promoted source must have a type that is enumerable.");

        // Only one source, so no need for cross-joining. Return as-is.
        if (sources.Length == 1)
            return (promotedSourceExpressions[0], isSourcesPromoted);

        var crossJoinedValueTupleResultsExpression = _operatorBinding.Bind(
            CqlOperator.CrossJoin,
            LibraryDefinitionsBuilder.ContextParameter,
            promotedSourceExpressions);

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

        var crossJoinedCqlTupleResultsExpression = _operatorBinding.Bind(
            CqlOperator.Select,
            LibraryDefinitionsBuilder.ContextParameter,
            crossJoinedValueTupleResultsExpression,
            selectExpression);

        return (crossJoinedCqlTupleResultsExpression, isSourcesPromoted)!;
    }

    private (Expression joinedSource, bool[] isSourcePromoted) CrossJoin(
        Query multiSourceQuery,
        Type tupleType)
    {
        //var a = new int[] { 1, 2, 3 };
        //var b = new int[] { 4, 5, 6 };
        //var c = new int[] { 7, 8, 9 };

        //var result = a
        //    .SelectMany(_a =>
        //        b.SelectMany(_b =>
        //            c.Select(_c => new { _a, _b, _c, })))
        //    .ToArray();
        //Assert.AreEqual(27, result.Length);

        //var result2 =
        //    a.SelectMany(_a => b, (__a, _b) => new { __a, _b })
        //        .SelectMany(ab => c, (_ab, _c) => new { _ab.__a, _ab._b, _c })
        //            .ToArray();

        AliasedQuerySource[] sources = multiSourceQuery.source;
        if (sources.Length < 2) throw this.NewExpressionBuildingException($"This method should only be called for 2 or more query sources");

        bool[] isSourcePromotedArr = new bool[sources.Length];

        // the first pair are special as they are not working off of a partially built tuple,
        // they are working only off of the initial selectmany parameters.
        var source0 = sources[0];
        var firstExpression = TranslateExpression(source0.expression!);
        (firstExpression, isSourcePromotedArr[0]) = TryPromoteSource(firstExpression);
        var firstElementType = _typeManager.Resolver.GetListElementType(firstExpression.Type)!;

        var source1 = sources[1];
        var secondExpression = TranslateExpression(source1.expression!);
        (secondExpression, isSourcePromotedArr[1]) = TryPromoteSource(secondExpression);
        var secondElementType = _typeManager.Resolver.GetListElementType(secondExpression.Type)!;

        var firstLambdaParameter = Expression.Parameter(firstElementType, $"_{source0.alias}");
        var firstSelectManyParameter = Expression.Lambda(secondExpression, firstLambdaParameter);

        var secondLambdaParameter = Expression.Parameter(secondElementType, $"_{source1.alias}");
        var newTuple = Expression.New(tupleType);
        var memberInit = Expression.MemberInit(newTuple,
            Expression.Bind(tupleType.GetProperty(source0.alias)!, firstLambdaParameter),
            Expression.Bind(tupleType.GetProperty(source1.alias)!, secondLambdaParameter));
        var secondSelectManyParameter = Expression.Lambda(memberInit, firstLambdaParameter, secondLambdaParameter);

        var callSelectMany = _operatorBinding.Bind(
            CqlOperator.SelectManyResults,
            LibraryDefinitionsBuilder.ContextParameter,
            firstExpression,
            firstSelectManyParameter,
            secondSelectManyParameter);

        for (int i = 2; i < sources.Length; i++)
        {
            var source = sources[i];

            var sourceExpression = TranslateExpression(source.expression!);
            (sourceExpression, isSourcePromotedArr[i]) = TryPromoteSource(sourceExpression);
            string message = $"{sourceExpression.Type} was expected to be a list type.";
            var sourceElementType = _typeManager.Resolver.GetListElementType(sourceExpression.Type) ?? throw this.NewExpressionBuildingException(message);

            var parameterName = string.Join(string.Empty, sources.Take(i).Select(st => st.alias));
            var parameter = Expression.Parameter(tupleType, $"_{parameterName}");
            var p1 = Expression.Lambda(sourceExpression, parameter);

            // .SelectMany(ab => c, (ab,c) => new Tuple { x = ab.x,  y = ab.y, c = c } )
            var ab = Expression.Parameter(tupleType, parameterName);
            var c = Expression.Parameter(sourceElementType, $"_{source.alias}");
            var bindings = new MemberAssignment[i + 1];
            for (int j = 0; j < i; j++)
            {
                var prop = tupleType.GetProperty(sources[j].alias)!;
                bindings[j] = Expression.Bind(prop, Expression.Property(ab, prop));
            }

            bindings[i] = Expression.Bind(tupleType.GetProperty(source.alias)!, c);
            newTuple = Expression.New(tupleType);
            memberInit = Expression.MemberInit(newTuple, bindings);
            var p2 = Expression.Lambda(memberInit, ab, c);

            var callAgain = _operatorBinding.Bind(CqlOperator.SelectManyResults,
                LibraryDefinitionsBuilder.ContextParameter,
                callSelectMany,
                p1,
                p2);
            callSelectMany = callAgain;
        }

        return (callSelectMany, isSourcePromotedArr);
    }

    private (Expression source, bool isSourcePromoted) TryPromoteSource(Expression source)
    {
        var isSourcePromoted = false;
        // promote single objects into enumerables so where works
        if (!IsOrImplementsIEnumerableOfT(source.Type))
        {
            var arrayInit = Expression.NewArrayInit(source.Type, source);
            source = arrayInit;
            isSourcePromoted = true;
        }

        return (source, isSourcePromoted);
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
                            var sort = _operatorBinding.Bind(CqlOperator.SortBy, LibraryDefinitionsBuilder.ContextParameter,
                                @return, sortLambda, Expression.Constant(order, typeof(ListSortDirection)));
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
                            var sort = _operatorBinding.Bind(CqlOperator.SortBy, LibraryDefinitionsBuilder.ContextParameter,
                                @return, sortLambda, Expression.Constant(order, typeof(ListSortDirection)));
                            return sort;
                        }
                        default:
                        {
                            var sort = _operatorBinding.Bind(CqlOperator.ListSort, LibraryDefinitionsBuilder.ContextParameter,
                                @return, Expression.Constant(order, typeof(ListSortDirection)));
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

    protected LambdaExpression WithToSelectManyBody(
        Type tupleType,
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


    protected Expression Where(
        Elm.Expression queryWhere,
        ParameterExpression sourceParameter,
        Expression @return)
    {
        using (PushElement(queryWhere))
        {
            var whereBody = TranslateExpression(queryWhere);
            var whereLambda = Expression.Lambda(whereBody, sourceParameter);
            var callWhere = _operatorBinding.Bind(CqlOperator.Where, LibraryDefinitionsBuilder.ContextParameter, @return, whereLambda);
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
            var aggregateCall = _operatorBinding.Bind(CqlOperator.Aggregate,
                LibraryDefinitionsBuilder.ContextParameter, @return, lambda, startingValue);
            return aggregateCall;
        }
    }

}

internal static class Extensions
{
    public static T[] SelectToArray<TIn, T>(
        this IReadOnlyCollection<TIn> source,
        Func<TIn, T> select) =>
        SelectToArray(source.AsEnumerable(), source.Count, select);

    public static T[] SelectToArray<TIn, T>(
        this IEnumerable<TIn> source,
        int sourceLength,
        Func<TIn, T> select)
    {
        T[] array = new T[sourceLength];
        int i = -1;
        foreach (var item in source)
        {
            ++i;
            array[i] = select(item);
        }

        return array;
    }
}