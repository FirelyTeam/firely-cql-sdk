/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Elm;
using Hl7.Cql.Operators;

namespace Hl7.Cql.Compiler;

using Tuple = Hl7.Cql.Elm.Tuple;
using CodeExpressionElementPairForIdentifier = System.Collections.Generic.KeyValuePair<string, (Hl7.Cql.Compiler.CodeModel.CodeExpression, Hl7.Cql.Elm.Element)>;

/// <summary>
/// Queries (query sources, where/return/aggregate/sort clauses, relationship clauses) plus
/// the property/instance/tuple construction machinery.
/// </summary>
partial class ExpressionBuilderContext
{
    #region Query

    protected CodeExpression Query(Query query)
    {
        QueryDumpDebugInfoToLog(query);

        Action popTokens = null!;

        void PushScopes(
            string? alias = null,
            params CodeExpressionElementPairForIdentifier[] kvps)
        {
            var popToken = this.PushScopes(alias, kvps);
            popTokens = (() => popToken.Pop()) + popTokens;
        }

        try
        {
            var sources = query.source;
            if (sources.Length == 0)
                throw this.NewExpressionBuildingException("Queries must define at least 1 source");

            var (@return, sourcesPreviouslySingletons) = ProcessQuerySources(query);
            var returnElementType = _typeResolver.GetListElementType(@return.Type, true)!;

            CodeLocal scopeParameter;
            if (sources.Length == 1)
            {
                var source0 = sources[0];
                var sourceParameterName = IdentifierNormalizer.Normalize(source0.alias);
                scopeParameter = new CodeLocal(returnElementType, sourceParameterName);
                PushScopes(ImpliedAlias, new CodeExpressionElementPairForIdentifier(source0.alias, ((CodeExpression)scopeParameter, (Elm.Element)source0.expression)));
            }
            else
            {
                var sourceParameterName = TypeNameToIdentifier(returnElementType, this);
                scopeParameter = new CodeLocal(returnElementType, sourceParameterName);
                var scopes =
                    (
                        from property in returnElementType!.GetProperties()
                        let propertyAccess = new CodeProperty(scopeParameter, property)
                        select new CodeExpressionElementPairForIdentifier(property.Name, (propertyAccess, (Elm.Element)query))
                    )
                    .ToArray();
                PushScopes(ImpliedAlias, scopes);
            }

            if (query.let != null)
            {
                foreach (var let in query.let)
                {
                    var expression = TranslateArg(let.expression!);
                    PushScopes(ImpliedAlias, new CodeExpressionElementPairForIdentifier(let.identifier!, (expression, (Elm.Element)let.expression!)));
                }
            }

            // handle with/such-that
            if (query.relationship is not null)
            {
                foreach (var relationship in query.relationship)
                {
                    using (PushElement(relationship))
                    {
                        // A 'with' is a semi-join and a 'without' an anti-semi-join: each source
                        // element is kept or dropped based on whether a matching related element
                        // exists, and is emitted at most once no matter how many elements match.
                        // (Ported from the old builder's eb8a22211, which fixed #1366.)
                        var existsLambda = WithToExistenceCheck(scopeParameter, relationship);
                        @return = BindCqlOperator(nameof(ICqlOperators.Where), @return, existsLambda);
                    }
                }
            }

            // 20240312 EK: refactoring made this redundant, but I am not sure it really is, so I am keeping
            // it around. It was used to redefine the type for the "rootScopeParameter", which used to be defined
            // inside every if statement here (so for where, return, etc).
            // -----
            // The element type may have changed
            // elementType = TypeResolver.GetListElementType(@return.Type, @throw: true)!;
            if (query.where is { } queryWhere)
            {
                @return = Where(queryWhere, scopeParameter, @return);
            }

            if (query.@return != null)
            {
                using (PushElement(query.@return))
                {
                    var selectBody = TranslateArg(query.@return.expression!);
                    var selectLambda = new CodeLambda([scopeParameter], selectBody);
                    var callSelect = BindCqlOperator(nameof(ICqlOperators.Select), @return, selectLambda);
                    @return = callSelect;
                    if (query.@return.distinct)
                    {
                        // NOTE(phase4): ported as-is — `qt`/`t` are computed but never used, matching
                        // the old ExpressionBuilderContext.Query's dead code.
                        var qt = query.GetTypeSpecifier();
                        var t = TypeFor(qt, false);
                        @return = BindCqlOperator(nameof(ICqlOperators.Distinct), [@return]);
                    }
                }
            }

            if (query.aggregate is { } queryAggregate)
            {
                @return = AggregateClause(query, queryAggregate, scopeParameter, @return);
            }

            if (query.sort is { by.Length: > 0 })
            {
                @return = SortClause(query, @return);
            }

            // Because we promoted the source to a list, we now have to demote the result again.
            var wereAllSourcesPreviouslySingletons = sourcesPreviouslySingletons.All(b => b);
            if (wereAllSourcesPreviouslySingletons)
            {
                @return = DemoteSourceListToSingleton(@return);
            }

            if (query.resultTypeSpecifier is ListTypeSpecifier && !_typeResolver.IsListType(@return.Type))
            {
                @return = new CodeNewArray(@return.Type, @return);
            }

            return @return;
        }
        finally
        {
            popTokens?.Invoke();
        }
    }

    private CodeExpression DemoteSourceListToSingleton(CodeExpression source)
    {
        // Do not inline this method, so that we can clearly see the pairing with the call to PromoteSourceSingletonToList
        var typeArg = _typeResolver.GetListElementType(source.Type, true);
        return BindCqlOperator(nameof(ICqlOperators.SingletonFrom), [source], [typeArg!]);
    }

    private (CodeExpression source, bool sourceOriginallyASingleton) PromoteSourceSingletonToList(CodeExpression source)
    {
        if (_typeResolver.IsListType(source.Type))
            return (source, false);

        source = new CodeNewArray(source.Type, source);
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
                                                                                            var sourceType = TranslateArg(s.expression).Type;
                                                                                            var isEnumerationType = _typeResolver.IsListType(sourceType);
                                                                                            if (isEnumerationType)
                                                                                                sourceType = _typeResolver
                                                                                                    .GetListElementType(sourceType, true)!;
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
                File.ReadLines(fiCql.FullName)
                    .Select((lineText, i) => (lineText, lineNum: i + 1))
                    .Where(t => t.lineNum >= row0 && t.lineNum <= row1)
                    .Select(t =>
                    {
                        var lineText = t.lineText;
                        Debug.Assert(row0 != row1 || col1 > col0);
                        if (t.lineNum == row1)
                        {
                            // Cannot trust the locator data in elm files to be within the bounds of the current line
                            col1 = Math.Clamp(col1, 0, lineText.Length);
                            lineText = lineText[..col1] + "<<<" + lineText[col1..];
                        }

                        if (t.lineNum == row0)
                        {
                            // Cannot trust the locator data in elm files to be within the bounds of the current line
                            col0 = Math.Clamp(col0, 0, lineText.Length);
                            lineText = lineText[..col0] + ">>>" + lineText[col0..];
                        }

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
            ((ReadOnlySpan<string>) ["Empty", "Single", "Multi"])[Math.Clamp(sourceLength, 0, 2)],
            sourceLength,
            DebuggerView,
            $"{string.Concat(from s in sources select $"\n\t{s.alias}: {(s.isEnumerationType ? "Enumeration" : "Singleton")} of {s.sourceType}")}",
            lines is not null ? $"{string.Concat(from l in lines select $"\n\t{l}")}" : "");
    }

    private (CodeExpression sourceExpression, bool[] sourcesPreviouslySingletons) ProcessQuerySources(Query query)
    {
        AliasedQuerySource[] sources = query.source;

        if (sources.Length is 0)
            throw this.NewExpressionBuildingException("A query must have at least one source.");

        var aliases = sources.SelectToArray(s => s.alias);
        if (aliases.Any(alias => string.IsNullOrEmpty(alias)))
            throw this.NewExpressionBuildingException("Query sources must have aliases.");

        var sourceExpressions = TranslateArgs(sources.SelectToArray(source => source.expression));

        // Returns a CrossJoin between IEnumerable<> of T1, T2, T3, etc and return into IEnumerable<(T1, T2, T3, etc)>
        // a) If a source is not of a list-type (ie, a singleton), it needs to be promoted to a list type.
        // b) Cross-Join
        //    IEnumerable<A> a = ...;
        //    IEnumerable<B> b = ...;
        //    IEnumerable<c> c = ...;
        //    IEnumerable<(A, B, C)> crossJoinedValueTupleResults = CrossJoin<A, B, C>(a, b, c);

        var temp = sourceExpressions.SelectToArray(expr => PromoteSourceSingletonToList(expr));
        var promotedSourceExpressions = temp.SelectToArray(s => s.source);
        var sourcesPreviouslySingletons = temp.SelectToArray(s => s.sourceOriginallyASingleton);

        // Only one source, so no need for cross-joining. Return as-is.
        if (sources.Length == 1)
            return (promotedSourceExpressions[0], sourcesPreviouslySingletons);

        var crossJoinedValueTupleResultsExpression = BindCqlOperator(nameof(ICqlOperators.CrossJoin), promotedSourceExpressions);

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
            .SelectToArray(pse => _typeResolver.GetListElementType(pse.Type, true)!);

        // IEnumerable<(A,B,C)
        var funcResultType = crossJoinedValueTupleResultsExpression.Type;

        // (A,B,C)
        const BindingFlags bfPublicInstance = BindingFlags.Public | BindingFlags.Instance;

        Type valueTupleType = _typeResolver.GetListElementType(funcResultType, true)!;
        FieldInfo[] valueTupleFields = valueTupleType.GetFields(bfPublicInstance | BindingFlags.GetField);

        Type cqlTupleType = _tupleBuilderCache.CreateOrGetTupleTypeFor(sourceListElementTypes.Zip(aliases).ToList());
        PropertyInfo[] cqlTupleProperties = cqlTupleType.GetProperties(bfPublicInstance | BindingFlags.SetProperty);

        Debug.Assert(valueTupleFields.Length > 0);
        Debug.Assert(valueTupleFields.Length == cqlTupleProperties.Length);

        var valueTupleTypeParam = new CodeLocal(valueTupleType, "_valueTuple");
        var selectExpression =
            new CodeLambda(
                [valueTupleTypeParam],
                CopyValueTupleIntoCqlTuple());

        CodeExpression CopyValueTupleIntoCqlTuple()
        {
            // NOTE(phase4): the reflection-emitted CQL tuple type is constructed via CodeTupleInit
            // (matching every element to its property by name) rather than CodeNew + CodeMemberInit,
            // per the phase-4 node-type mapping for CQL tuple types.
            var elements = valueTupleFields
                          .Zip(cqlTupleProperties, (valueTupleField, cqlTupleProp) => (valueTupleField, cqlTupleProp))
                          .SelectToArray(
                              valueTupleFields.Length,
                              t => (t.cqlTupleProp.Name, (CodeExpression)new CodeProperty(valueTupleTypeParam, t.valueTupleField)));

            var copyProps = new CodeTupleInit(cqlTupleType, elements);
            return copyProps;
        }

        var crossJoinedCqlTupleResultsExpression = BindCqlOperator(nameof(ICqlOperators.Select), crossJoinedValueTupleResultsExpression, selectExpression);

        return (crossJoinedCqlTupleResultsExpression, sourcesPreviouslySingletons)!;
    }

    protected CodeExpression SortClause(
        Query query,
        CodeExpression @return)
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
                            var returnElementType = _typeResolver.GetListElementType(@return.Type, true)!;
                            var sortMemberParameter = new CodeLocal(returnElementType, parameterName);
                            using (PushScopes(parameterName,
                                              new CodeExpressionElementPairForIdentifier(parameterName, (sortMemberParameter, (Elm.Element)byExpression.expression))))
                            {
                                var sortMemberExpression = TranslateArg(byExpression.expression);
                                var lambdaBody = _cqlOperatorsBinder.ConvertToType(sortMemberExpression, typeof(object));
                                var sortLambda = new CodeLambda([sortMemberParameter], lambdaBody);
                                return BindCqlOperator(nameof(ICqlOperators.SortBy), @return, sortLambda,
                                                       new CodeConstant(order, typeof(ListSortDirection)));
                            }
                        }
                        case ByColumn byColumn:
                        {
                            var parameterName = "@this";
                            var returnElementType = _typeResolver.GetListElementType(@return.Type, true)!;
                            var sortMemberParameter = new CodeLocal(returnElementType, parameterName);
                            var pathMemberType = TypeFor(byColumn);
                            if (pathMemberType == null)
                            {
                                throw this.NewExpressionBuildingException(
                                    $"Type specifier {by.resultTypeName} at {by.locator ?? "unknown"} could not be resolved.");
                            }

                            var pathExpression = PropertyHelper(sortMemberParameter, byColumn.path, pathMemberType!);
                            var lambdaBody = _cqlOperatorsBinder.ConvertToType(pathExpression, typeof(object));
                            var sortLambda = new CodeLambda([sortMemberParameter], lambdaBody);
                            return BindCqlOperator(nameof(ICqlOperators.SortBy), @return, sortLambda, new CodeConstant(order, typeof(ListSortDirection)));
                        }
                        default:
                        {
                            return BindCqlOperator(nameof(ICqlOperators.ListSort), @return, new CodeConstant(order, typeof(ListSortDirection)));
                        }
                    }
                }
            }
        }

        return @return;
    }

    protected CodeLambda WithToExistenceCheck(
        CodeLocal rootScopeParameter,
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
        //    .Where(E =>
        //        bundle.Entry.ByResourceType<Condition>() // <--
        //            .Where(P => true) // such that goes here
        //            .Any());          // negated for a 'without'
        var source = TranslateArg(with.expression);
        if (!_typeResolver.IsListType(source.Type))
        {
            // e.g.:
            // with "Index Prescription Start Date" IPSD
            // where IPSD is a Date
            // Promote to an array for consistency.
            var newArray = new CodeNewArray(source.Type, source);
            source = newArray;
        }

        var sourceElementType = _typeResolver.GetListElementType(source.Type)!;

        var whereLambdaParameter = new CodeLocal(sourceElementType, with.alias);
        using (PushScopes(ImpliedAlias, new CodeExpressionElementPairForIdentifier(with.alias!, (whereLambdaParameter, (Elm.Element)with))))
        {
            var suchThatBody = TranslateArg(with.suchThat);

            var whereLambda = new CodeLambda([whereLambdaParameter], suchThatBody);
            var callWhereOnSource = BindCqlOperator(nameof(ICqlOperators.Where), source, whereLambda);
            var exists = BindCqlOperator(nameof(ICqlOperators.Exists), callWhereOnSource);
            if (with is Without)
                exists = BindCqlOperator(nameof(ICqlOperators.Not), exists);
            return new CodeLambda([rootScopeParameter], exists);
        }
    }


    protected CodeExpression Where(
        Elm.Expression queryWhere,
        CodeLocal sourceParameter,
        CodeExpression @return)
    {
        using (PushElement(queryWhere))
        {
            var whereBody = TranslateArg(queryWhere);
            var whereLambda = new CodeLambda([sourceParameter], whereBody);
            return BindCqlOperator(nameof(ICqlOperators.Where), @return, whereLambda);
        }
    }

    protected CodeExpression AggregateClause(
        Query query,
        AggregateClause queryAggregate,
        CodeLocal sourceParameter,
        CodeExpression @return)
    {
        using (PushElement(queryAggregate))
        {
            var resultAlias = queryAggregate.identifier!;
            Type? resultType = null;
            if (queryAggregate.resultTypeSpecifier is { } typeSpecifier)
            {
                resultType = TypeFor(typeSpecifier)!;
            }
            else if (!string.IsNullOrWhiteSpace(queryAggregate.resultTypeName.Name!))
            {
                resultType = _typeResolver.ResolveType(queryAggregate.resultTypeName.Name!);
            }

            if (resultType is null)
                throw this.NewExpressionBuildingException(
                    $"Could not resolve aggregate query result type for query {query.localId} at {query.locator}");

            var resultParameter = new CodeLocal(resultType, resultAlias);
            using (PushScopes(ImpliedAlias, new CodeExpressionElementPairForIdentifier(resultAlias!, (resultParameter, (Elm.Element)queryAggregate))))
            {
                var lambdaBody = TranslateArg(queryAggregate.expression!);
                // when starting is not present, it is a null literal typed as Any (object).
                // cast the null to the expression type.
                var starting = TranslateArg(queryAggregate.starting!);
                var startingValue = ChangeType(starting, lambdaBody.Type, throwOnError: true);
                if (queryAggregate.distinct)
                    @return = _cqlOperatorsBinder.BindToMethod(nameof(ICqlOperators.Distinct), [@return], [resultType]);
                var lambda = new CodeLambda([resultParameter, sourceParameter], lambdaBody);

                return BindCqlOperator(nameof(ICqlOperators.Aggregate), @return, lambda, startingValue);
            }
        }
    }

    #endregion

    #region Properties, instances and tuples

    protected CodeExpression? IdentifierRef(IdentifierRef ire)
    {
        if (string.Equals("$this", ire.name) && ImpliedAlias != null)
        {
            var scopeExpression = GetScopeExpression(ImpliedAlias!);
            return scopeExpression;
        }

        var pe = new Property
        {
            resultTypeSpecifier = ire.resultTypeSpecifier,
            resultTypeName = ire.resultTypeName,
            localId = ire.localId,
            locator = ire.locator,
            path = ire.name,
            scope = ImpliedAlias!,
        };
        var prop = Property(pe);
        return prop;
    }

    protected CodeExpression OperandRef(OperandRef ore)
    {
        if (_operands?.TryGetValue(ore.name!, out var expression) == true)
            return expression;
        throw this.NewExpressionBuildingException($"Operand reference to {ore.name} not found in definition operands.");
    }

    protected CodeExpression Property(Property op)
    {
        using (PushElement(op))
        {
            if (string.IsNullOrWhiteSpace(op.path))
                throw this.NewExpressionBuildingException("Property expression cannot have null or empty path");
            var path = op.path;

            Type? expectedType;

            if (!string.IsNullOrWhiteSpace(op.scope))
            {
                var scopeExpression = GetScopeExpression(op.scope!);
                expectedType = TypeFor(op) ?? typeof(object);
                var pathMemberInfo = _typeResolver.GetProperty(scopeExpression.Type, path!) ??
                                     _typeResolver.GetProperty(scopeExpression.Type, op.path);
                if (pathMemberInfo == null)
                {
                    _logger.LogWarning(
                        FormatMessage(
                            $"Property {op.path} can't be known at design time, and will be late-bound, slowing performance.  Consider casting the source first so that this property can be definitely bound.",
                            op));
                    return BindCqlOperator(nameof(ICqlOperators.LateBoundProperty), scopeExpression, new CodeConstant(op.path, typeof(string)),
                                           new CodeConstant(expectedType, typeof(Type)));
                }

                var propogate = PropagateNull(scopeExpression, pathMemberInfo);
                string message = $"TupleBuilderCache failed to resolve type.";
                var resultType = TypeFor(op) ?? throw this.NewExpressionBuildingException(message);
                if (resultType != propogate.Type)
                {
                    propogate = ChangeType(propogate, resultType, throwOnError: true);
                }

                return propogate;
            }

            if (op.source == null)
                throw this.NewExpressionBuildingException("Property expression cannot have an empty source when scope is empty");

            var source = TranslateArg(op.source);
            var parts = path.Split('.');
            if (parts.Length > 1)
            {
                // support paths like birthDate.value on Patient
                for (int i = 0; i < parts.Length; i++)
                {
                    var pathPart = parts[i];
                    var pathMemberInfo = _typeResolver.GetProperty(source.Type, pathPart);
                    if (pathMemberInfo != null)
                    {
                        var propertyAccess = PropagateNull(source, pathMemberInfo);
                        source = propertyAccess;
                    }
                }

                return source;
            }

            // If we cannot determine the type from the ELM, let's try
            // if the POCO model can help us.
            expectedType = TypeFor(op, throwIfNotFound: false)
                           ?? _typeResolver.GetProperty(source.Type, path)?.PropertyType
                           ?? throw this.NewExpressionBuildingException("Cannot resolve type for expression");

            var result = PropertyHelper(source, path, expectedType);
            return result;
        }
    }

    protected CodeExpression PropertyHelper(
        CodeExpression source,
        string? path,
        Type expectedType)
    {
        CodeExpression? result = null;
        if (_typeResolver.ShouldUseSourceObject(source.Type, path!))
        {
            result = source;
        }
        else
        {
            var pathMemberInfo = _typeResolver.GetProperty(source.Type, path!);

            if (pathMemberInfo == null)
            {
                _logger.LogWarning(
                    FormatMessage(
                        $"Property {path} can't be known at design time, and will be late-bound, slowing performance.  Consider casting the source first so that this property can be definitely bound."));
                return BindCqlOperator(nameof(ICqlOperators.LateBoundProperty), source, new CodeConstant(path, typeof(string)),
                                       new CodeConstant(expectedType, typeof(Type)));
            }

            if (pathMemberInfo.DeclaringType != source.Type) // the property is on a derived type, so cast it
            {
                var isCheck = source.NewTypeIsExpression(pathMemberInfo.DeclaringType!);
                var typeAs = source.NewTypeAsExpression(pathMemberInfo.DeclaringType!);
                var pathAccess = new CodeProperty(typeAs, pathMemberInfo);
                CodeExpression? ifIs = pathAccess;
                CodeExpression elseNull = new CodeConstant(null, pathMemberInfo.PropertyType);
                // some ops, like properties on alias refs, don't have type information on them.
                // can't check against what we don't have.
                if (expectedType != null)
                {
                    if (expectedType != ifIs.Type)
                    {
                        ifIs = ChangeType(ifIs, expectedType, throwOnError: true);
                    }

                    if (expectedType != elseNull.Type)
                    {
                        elseNull = ChangeType(elseNull, expectedType, throwOnError: true);
                    }
                }

                var condition = new CodeConditional(isCheck, ifIs, elseNull, ifIs.Type);
                return condition;
            }

            result = PropagateNull(source, pathMemberInfo);
        }

        if (expectedType != null && expectedType != result.Type)
        {
            result = ChangeType(result, expectedType, throwOnError: true);
        }

        return result;
    }

    internal static PropertyInfo? GetProperty(
        Type type,
        string name,
        TypeResolver typeResolver)
    {
        if (type.IsGenericType)
        {
            var gtd = type.GetGenericTypeDefinition();
            if (gtd == typeof(Nullable<>))
            {
                if (string.Equals(name, "value", StringComparison.OrdinalIgnoreCase))
                {
                    var valueMember = type.GetProperty("Value");
                    return valueMember;
                }
            }
        }

        var member = typeResolver.GetProperty(type, name);
        return member;
    }

    /// <remarks>The old builder returned a <c>MemberAssignment</c>; the IR pipeline represents
    /// an object-initializer binding as a <c>(MemberInfo, CodeExpression)</c> pair (see
    /// <see cref="CodeMemberInit"/>).</remarks>
    protected (MemberInfo member, CodeExpression value) Binding(CodeExpression value, MemberInfo memberInfo)
    {
        if (memberInfo is PropertyInfo property)
        {
            if (value.Type == property.PropertyType)
            {
                return (memberInfo, value);
            }

            if (property.PropertyType.IsArray)
            {
                if (value.Type.IsArray)
                {
                    if (property.PropertyType.GetElementType() == value.Type.GetElementType())
                    {
                        return (memberInfo, value);
                    }
                }
                else if (value.Type.IsGenericType)
                {
                    string message = $"{value.Type} was expected to be a list type.";
                    var valueEnumerableElement = _typeResolver.GetListElementType(value.Type) ?? throw this.NewExpressionBuildingException(message);
                    var memberArrayElement = property.PropertyType.GetElementType()!;
                    if (valueEnumerableElement == memberArrayElement)
                    {
                        var toArrayMethod = typeof(Enumerable)
                                            .GetMethod(nameof(Enumerable.ToArray))!
                                            .MakeGenericMethod(valueEnumerableElement);
                        var callToArray = new CodeInvoke(null, toArrayMethod, value);
                        return (memberInfo, callToArray);
                    }
                    else
                    {
                        var selectParameter = new CodeLocal(valueEnumerableElement, TypeNameToIdentifier(value.Type, this));
                        var body = ChangeType(selectParameter, memberArrayElement, throwOnError: true);
                        var selectLambda = new CodeLambda([selectParameter], body);
                        var callSelectMethod = BindCqlOperator(nameof(ICqlOperators.Select), [
                            value, selectLambda
                        ]);
                        var toArrayMethod = typeof(Enumerable)
                                            .GetMethod(nameof(Enumerable.ToArray))!
                                            .MakeGenericMethod(memberArrayElement);
                        var callToArray = new CodeInvoke(null, toArrayMethod, callSelectMethod);
                        return (memberInfo, callToArray);
                    }
                }
            }
            else if (property.PropertyType.IsImplementingGenericTypeDefinition(typeof(ICollection<>)))
            {
                if (_typeResolver.IsListType(value.Type))
                {
                    var elementType = _typeResolver.GetListElementType(property.PropertyType)!;
                    var ctor = ConstructorInfos.ListOf(elementType);
                    var newList = new CodeNew(ctor, value);
                    return (memberInfo, newList);
                }
            }

            var convert = ChangeType(value, property.PropertyType, throwOnError: true);
            return (memberInfo, convert);
        }

        throw new NotImplementedException().WithContext(this);
    }

    protected CodeExpression Instance(Instance ine)
    {
        var instanceType = _typeResolver.ResolveType(ine.classType.Name)
                           ?? throw this.NewExpressionBuildingException($"Could not resolve type for '{ine.classType.Name}'");

        if (instanceType.IsEnum())
        {
            // constructs like:
            // FHIR.RemittanceOutcome {value: 'complete'}
            // FHIR.RemittanceOutcome maps to an enum type
            if (ine.element?.Length == 1 && string.Equals(ine.element![0].name, "value", StringComparison.OrdinalIgnoreCase))
            {
                var enumValueValue = TranslateArg(ine.element[0]!.value!);

                if (enumValueValue.Type == instanceType)
                    return enumValueValue;

                if (enumValueValue.Type == typeof(string)) //@ TODO: Cast - Instance
                {
                    var methodInfo = typeof(Enum).GetMethod(nameof(Enum.Parse), new[] { typeof(Type), typeof(string), typeof(bool) })
                                     ?? throw this.NewExpressionBuildingException($"Could not find Enum.Parse method.");

                    var callEnumParse = new CodeInvoke(null, methodInfo, new CodeConstant(instanceType, typeof(Type)), enumValueValue, new CodeConstant(true, typeof(bool)));
                    return callEnumParse;
                }
            }
        }

        if (instanceType.IsGenericType
            && instanceType.GenericTypeArguments.Length == 1
            && instanceType.GenericTypeArguments[0].IsEnum)
        {
            // supports constructs like
            //  * FHIR.ObservationStatus { value: 'final' }
            //  * FHIR.AdministrativeGender { value: 'female' }
            //  * ...
            // which map to Code<ObservationStatus> or Code<AdministrativeGender
            if (ine.element?.Length == 1
                && string.Equals(ine.element![0].name, "value", StringComparison.OrdinalIgnoreCase))
            {
                var enumValueValue = TranslateArg(ine.element[0]!.value!);

                if (enumValueValue.Type == instanceType)
                    return enumValueValue;

                if (enumValueValue.Type == typeof(string)) //@ TODO: Cast - Instance
                {
                    var enumParseMethod = typeof(Enum).GetMethod(nameof(Enum.Parse), new[] { typeof(Type), typeof(string), typeof(bool) });

                    var genericType = instanceType.GenericTypeArguments[0];
                    var constructorInfo = instanceType.GetConstructor(new[] { genericType })
                                          ?? throw this.NewExpressionBuildingException(
                                              $"Could not find constructor for {instanceType}<{genericType}>({genericType})");

                    var parseCall = new CodeInvoke(
                        null,
                        enumParseMethod!,
                        new CodeConstant(instanceType.GenericTypeArguments[0], typeof(Type)),
                        enumValueValue,
                        new CodeConstant(true, typeof(bool)));

                    var typedParsedValue = new CodeCast(parseCall, genericType.MakeNullable(), CodeCastKind.Cast);

                    var genericEnumValue = new CodeNew(
                        constructorInfo,
                        typedParsedValue);

                    return genericEnumValue;
                }
            }
        }

        (string name, CodeExpression value)[] parameterNameValuePairs = ine.element!.SelectToArray(el => (name: el.name!, value: TranslateArg(el.value)));

        // Find a constructor that matches the provided parameters.
        const int NOT_MAPPED_HAS_DEFAULT_VALUE = int.MaxValue;
        var (ctor, ctorParameters, ctorPositionToParameterPositionMap) =
            // Prefer constructors with more parameters, and
            instanceType.GetConstructors()
                        .OrderByDescending(c => c.GetParameters().Length) // Prefer constructors with more parameters
                        .SelectWhere(ctor =>
                        {
                            var ctorParameters = ctor.GetParameters();

                            // Exit if the constructor has fewer parameters than provided
                            if (parameterNameValuePairs.Length > ctorParameters.Length)
                                return default;

                            // Exit if the constructor has a parameter that
                            // is not assignable from the provided value by name or type
                            // when the parameter has no default value.
                            int[] ctorPositionToParameterPositionMap = new int[ctorParameters.Length];
                            bool[] isParameterNameValuePairMapped = new bool[parameterNameValuePairs.Length];
                            for (var i = 0; i < ctorParameters.Length; i++)
                            {
                                var ctorParameter = ctorParameters[i];
                                var parameterPosition =
                                    Array.FindIndex(
                                        parameterNameValuePairs,
                                        parameterNameValuePair =>
                                            string.Equals(ctorParameter.Name, parameterNameValuePair.name, StringComparison.OrdinalIgnoreCase) &&
                                            ctorParameter.ParameterType.IsAssignableFrom(parameterNameValuePair.value.Type));
                                switch (parameterPosition)
                                {
                                    case -1 when ctorParameter.HasDefaultValue:
                                        ctorPositionToParameterPositionMap[i] = NOT_MAPPED_HAS_DEFAULT_VALUE; break;
                                    case -1:
                                        return default; // Exit immediately if we cannot map this parameter
                                    case { } p:
                                        ctorPositionToParameterPositionMap[i] = p;
                                        isParameterNameValuePairMapped[parameterPosition] = true;
                                        break;
                                }
                            }

                            // Make sure there are no provided values that are not mapped to a constructor parameter
                            if (Array.IndexOf(isParameterNameValuePairMapped, false) >= 0)
                                return default;

                            return (true, (ctor, ctorParameters, ctorPositionToParameterPositionMap));
                        })
                        .FirstOrDefault();

        if (ctor is not null)
        {
            CodeExpression[] values = new CodeExpression[ctorPositionToParameterPositionMap.Length];
            for (int i = 0; i < ctorPositionToParameterPositionMap.Length; i++)
            {
                var parameterPosition = ctorPositionToParameterPositionMap[i];
                var ctorParameter = ctorParameters[i];
                values[i] = (parameterPosition, ctorParameter.DefaultValue) switch
                {
                    (NOT_MAPPED_HAS_DEFAULT_VALUE, null) => new CodeConstant(null, ctorParameter.ParameterType),
                    (NOT_MAPPED_HAS_DEFAULT_VALUE, {} defaultValue) => new CodeConstant(defaultValue, ctorParameter.ParameterType),
                    _                                               => parameterNameValuePairs[parameterPosition].value
                };
            }
            var newInstance = new CodeNew(ctor, values);
            return newInstance;
        }

        // Fallback to member initialization if a constructor with all parameters is not available.
        ctor = instanceType.GetConstructor(Type.EmptyTypes);
        if (ctor != null)
        {
            var elementBindings = new (MemberInfo Member, CodeExpression Value)[parameterNameValuePairs.Length];
            for (int i = 0; i < parameterNameValuePairs.Length; i++)
            {
                var (name, value) = parameterNameValuePairs[i];
                var memberInfo = GetProperty(instanceType, name, _typeResolver) ??
                                 throw this.NewExpressionBuildingException($"Could not find member {name} on type {instanceType.ToCSharpString(Defaults.TypeCSharpFormat)}");
                var binding = Binding(value, memberInfo);
                elementBindings[i] = binding;
            }

            var @new = new CodeNew(ctor);
            var init = new CodeMemberInit(@new, elementBindings);
            return init;
        }

        throw this.NewExpressionBuildingException($"No suitable constructor found for type {instanceType}.");
    }

    protected CodeExpression Tuple(Tuple tuple)
    {
        Type tupleType;
        if (tuple.resultTypeSpecifier is null)
        {
            tupleType = TupleTypeFor(tuple);
        }
        else
        {
            var tupleTypeSpecifier = tuple.resultTypeSpecifier as TupleTypeSpecifier ??
                                     throw this.NewExpressionBuildingException($"Tuple expression has a resultType that is not a TupleTypeSpecifier.");
            tupleType = TupleTypeFor(tupleTypeSpecifier);
        }

        // NOTE(phase4): the reflection-emitted CQL tuple type is constructed via CodeTupleInit
        // rather than CodeNew + CodeMemberInit, per the phase-4 node-type mapping for CQL tuple
        // types. Binding(...) is still used per element so that the same coercion logic
        // (array/ICollection conversions, ChangeType fallback) applies as before.
        if (tuple.element?.Length > 0)
        {
            var elementBindings =
                tuple.element!
                     .SelectToArray(element =>
                     {
                         var value = TranslateArg(element.value!);
                         var propInfo = GetProperty(tupleType, IdentifierNormalizer.Normalize(element.name!), _typeResolver)
                                        ?? throw this.NewExpressionBuildingException(
                                            $"Could not find member {element} on type {tupleType.ToCSharpString(Defaults.TypeCSharpFormat)}");
                         var binding = Binding(value, propInfo);
                         return (binding.member.Name, binding.value);
                     });
            var init = new CodeTupleInit(tupleType, elementBindings);
            return init;
        }

        return new CodeTupleInit(tupleType, []);
    }

    #endregion
}
