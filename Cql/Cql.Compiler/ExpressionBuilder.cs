

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Conversion;
using DateTime = Hl7.Cql.Elm.DateTime;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler
{
    /// <summary>
    /// The ExpressionBuilderContext class maintains scope information for the traversal of ElmPackage statements.
    /// </summary>
    /// <remarks>
    /// The scope information in this class is useful for <see cref="IExpressionMutator"/> and is supplied to <see cref="IExpressionMutator.Mutate(Expression, Elm.Element, ExpressionBuilder)"/>.
    /// </remarks>
    partial class ExpressionBuilder
    {
        private readonly OperatorsBinder _operatorsBinder;
        private readonly ContextBinder _contextBinder;
        private readonly TypeManager _typeManager;
        private readonly ILogger<ExpressionBuilder> _logger;
        private readonly TypeConverter _typeConverter;
        private readonly TypeResolver _typeResolver;

        private ImmutableStack<Element> _elementStack;
        private readonly LibraryDefinitionBuilderSettings _libraryDefinitionBuilderSettings;
        private readonly LibraryExpressionBuilder _libraryContext;

        /// <summary>
        /// Contains query aliases and let declarations, and any other symbol that is now "in scope"
        /// </summary>
        private ImmutableStack<(object? id, string? impliedAlias, IReadOnlyDictionary<string, (Expression expr, Element element)>? scopes)> _impliedAliasAndScopesStack;

        /// <summary>
        /// Parameters for function definitions.
        /// </summary>
        private readonly Dictionary<string, ParameterExpression> _operands;

        private readonly IReadOnlyCollection<IExpressionMutator> _expressionMutators; // Not used yet, since it's always empty

        /// <summary>
        /// A dictionary which maps qualified definition names in the form of {<see cref="Elm.Library.NameAndVersion"/>}.{<c>Definition.name"</c>}
        /// to a factory which will produce a <see cref="LambdaExpression"/> given the values of <see cref="ParameterExpression"/>.
        /// </summary>
        /// <remarks>
        /// This function can be used to provide .NET native functions in place of ELM functions, and should also be used to implement
        /// functions defined in CQL with the <code>external</code> keyword.
        /// </remarks>
        private readonly Dictionary<string, Func<ParameterExpression[], LambdaExpression>> _customImplementations;

        internal ExpressionBuilder(

            ExpressionBuildingDependencies dependencies,
            LibraryExpressionBuilder libContext)
        {
            // External Services
            _operatorsBinder = dependencies.OperatorsBinder;
            _contextBinder = dependencies.ContextBinder;
            _typeManager = dependencies.TypeManager;
            _libraryDefinitionBuilderSettings = dependencies.LibraryDefinitionBuilderSettings;
            _typeConverter = dependencies.TypeConverter;
            _typeConverter = dependencies.TypeConverter;
            _typeResolver = dependencies.TypeResolver;
            _logger = dependencies.LoggerFactory.CreateLogger<ExpressionBuilder>();

            // External State
            _libraryContext = libContext;

            // Internal State
            _elementStack = ImmutableStack<Element>.Empty;
            _operands = new Dictionary<string, ParameterExpression>();
            _impliedAliasAndScopesStack = ImmutableStack<(object? id, string? impliedAlias, IReadOnlyDictionary<string, (Expression expr, Element element)>? scopes)>.Empty;
            _expressionMutators = ReadOnlyCollection<IExpressionMutator>.Empty;
            _customImplementations = new Dictionary<string, Func<ParameterExpression[], LambdaExpression>>();
        }

        private Expression BindCqlOperator(CqlOperator @operator) =>
            _operatorsBinder.BindToMethod(@operator);

        private Expression BindCqlOperator(CqlOperator @operator, params object?[] args) =>
            _operatorsBinder.BindToMethod(@operator, TranslateAll(args));

        private Expression BindCqlOperator<T>(CqlOperator @operator, params T?[] args) =>
            _operatorsBinder.BindToMethod(@operator, TranslateAll(args));

        private Expression[] TranslateAll(params object?[] args) =>
            TranslateAll<object?>(args);

        private Expression[] TranslateAll<T>(params T?[] args) =>
            args switch
            {
                Expression[] expressions => expressions,
                object[] objects         => objects.SelectToArray(obj => Translate(obj!)),
                _                        => [],
            };

        [return:NotNullIfNotNull(nameof(arg))]
        internal Expression? Translate(object? arg) =>
            arg switch
            {
                //null                  => NullConstantExpression.Object,
                Expression expression => expression,
                Element element       => TranslateElement(element),
                var obj               => Expression.Constant(obj),
            };

        private Expression TranslateElement(Element element) =>
            this.CatchRethrowExpressionBuildingException(_ =>
                {
                    using (PushElement(element))
                    {
                        Expression? expression = element switch
                        {
                            //@formatter:off
                            Abs abs                    => BindCqlOperator(CqlOperator.Abs, abs.operand),
                            Ceiling ceil               => BindCqlOperator(CqlOperator.Ceiling, ceil.operand),
                            ConvertsToBoolean ce       => BindCqlOperator(CqlOperator.ConvertsToDate, ce.operand),
                            ConvertsToDate ce          => BindCqlOperator(CqlOperator.ConvertsToDate, ce.operand),
                            ConvertsToDateTime ce      => BindCqlOperator(CqlOperator.ConvertsToDateTime, ce.operand),
                            ConvertsToDecimal ce       => BindCqlOperator(CqlOperator.ConvertsToDecimal, ce.operand),
                            ConvertsToLong ce          => BindCqlOperator(CqlOperator.ConvertsToLong, ce.operand),
                            ConvertsToInteger ce       => BindCqlOperator(CqlOperator.ConvertsToInteger, ce.operand),
                            ConvertsToQuantity ce      => BindCqlOperator(CqlOperator.ConvertsToQuantity, ce.operand),
                            ConvertsToString ce        => BindCqlOperator(CqlOperator.ConvertsToString, ce.operand),
                            ConvertsToTime ce          => BindCqlOperator(CqlOperator.ConvertsToTime, ce.operand),
                            Distinct distinct          => BindCqlOperator(CqlOperator.Distinct, distinct.operand),
                            End e                      => BindCqlOperator(CqlOperator.IntervalEnd, e.operand),
                            Exists ex                  => BindCqlOperator(CqlOperator.Exists, ex.operand),
                            Exp exe                    => BindCqlOperator(CqlOperator.Exp, exe.operand),
                            Flatten fl                 => BindCqlOperator(CqlOperator.Flatten, fl.operand),
                            Floor floor                => BindCqlOperator(CqlOperator.Floor, floor.operand),
                            IsFalse isn                => BindCqlOperator(CqlOperator.IsFalse, isn.operand),
                            IsTrue isn                 => BindCqlOperator(CqlOperator.IsTrue, isn.operand),
                            Ln ln                      => BindCqlOperator(CqlOperator.Ln, ln.operand),
                            Lower e                    => BindCqlOperator(CqlOperator.Lower, e.operand),
                            Not not                    => BindCqlOperator(CqlOperator.Not, not.operand),
                            PointFrom pf               => BindCqlOperator(CqlOperator.PointFrom, pf.operand),
                            Precision pre              => BindCqlOperator(CqlOperator.Precision, pre.operand),
                            Predecessor prd            => BindCqlOperator(CqlOperator.Predecessor, prd.operand),
                            SingletonFrom sf           => BindCqlOperator(CqlOperator.Single, sf.operand),
                            Successor suc              => BindCqlOperator(CqlOperator.Successor, suc.operand),
                            Start start                => BindCqlOperator(CqlOperator.IntervalStart, start.operand),
                            TimezoneOffsetFrom tofe    => BindCqlOperator(CqlOperator.TimeZoneComponent, tofe.operand),
                            Truncate trunc             => BindCqlOperator(CqlOperator.Truncate, trunc.operand),
                            Upper e                    => BindCqlOperator(CqlOperator.Upper, e.operand),
                            Width width                => BindCqlOperator(CqlOperator.Width, width.operand),
                            Add add                    => BindCqlOperator(CqlOperator.Add, add.operand[..2]),
                            And and                    => BindCqlOperator(CqlOperator.And, and.operand[..2]), // https://cql.hl7.org/09-b-cqlreference.html#and
                            Divide divide              => BindCqlOperator(CqlOperator.Divide, divide.operand[..2]),
                            EndsWith e                 => BindCqlOperator(CqlOperator.EndsWith, e.operand[..2]),
                            Greater gtr                => BindCqlOperator(CqlOperator.Greater, gtr.operand[..2]),
                            GreaterOrEqual gtre        => BindCqlOperator(CqlOperator.GreaterOrEqual, gtre.operand[..2]),
                            HighBoundary hb            => BindCqlOperator(CqlOperator.HighBoundary, hb.operand[..2]),
                            Implies implies            => BindCqlOperator(CqlOperator.Implies, implies.operand[..2]), // https://cql.hl7.org/09-b-cqlreference.html#implies
                            Less less                  => BindCqlOperator(CqlOperator.Less, less.operand[..2]),
                            LessOrEqual lesse          => BindCqlOperator(CqlOperator.LessOrEqual, lesse.operand[..2]),
                            Log log                    => BindCqlOperator(CqlOperator.Log, log.operand[..2]),
                            LowBoundary lb             => BindCqlOperator(CqlOperator.LowBoundary, lb.operand[..2]),
                            Matches e                  => BindCqlOperator(CqlOperator.Matches, e.operand[..2]),
                            Modulo mod                 => BindCqlOperator(CqlOperator.Modulo, mod.operand[..2]),
                            Multiply mul               => BindCqlOperator(CqlOperator.Multiply, mul.operand[..2]),
                            Or or                      => BindCqlOperator(CqlOperator.Or, or.operand[..2]), // https://cql.hl7.org/09-b-cqlreference.html#or
                            Power pow                  => BindCqlOperator(CqlOperator.Pow, pow.operand[..2]),
                            Subtract sub               => BindCqlOperator(CqlOperator.Subtract, sub.operand[..2]),
                            StartsWith e               => BindCqlOperator(CqlOperator.StartsWith, e.operand[..2]),
                            TruncatedDivide div        => BindCqlOperator(CqlOperator.TruncatedDivide, div.operand[..2]),
                            Xor xor                    => BindCqlOperator(CqlOperator.Xor, xor.operand[..2]),
                            AllTrue alt                => BindCqlOperator(CqlOperator.AllTrue, alt.source),
                            AnyTrue ate                => BindCqlOperator(CqlOperator.AnyTrue, ate.source),
                            Avg avg                    => BindCqlOperator(CqlOperator.Avg, avg.source),
                            Count ce                   => BindCqlOperator(CqlOperator.Count, ce.source),
                            GeometricMean gme          => BindCqlOperator(CqlOperator.GeometricMean, gme.source),
                            Max max                    => BindCqlOperator(CqlOperator.MaxElementInList, max.source),
                            Median med                 => BindCqlOperator(CqlOperator.Median, med.source),
                            Min min                    => BindCqlOperator(CqlOperator.MinElementInList, min.source),
                            Mode mode                  => BindCqlOperator(CqlOperator.Mode, mode.source),
                            PopulationStdDev pstd      => BindCqlOperator(CqlOperator.PopulationStdDev, pstd.source),
                            PopulationVariance pvar    => BindCqlOperator(CqlOperator.PopulationVariance, pvar.source),
                            Product prod               => BindCqlOperator(CqlOperator.Product, prod.source),
                            Sum sum                    => BindCqlOperator(CqlOperator.Sum, sum.source),
                            StdDev stddev              => BindCqlOperator(CqlOperator.StdDev, stddev.source),
                            Variance variance          => BindCqlOperator(CqlOperator.Variance, variance.source),
                            Negate neg                 => neg.operand is Literal literal ? NegateLiteral(neg, literal) : ChangeType(BindCqlOperator(CqlOperator.Negate, neg.operand), neg.resultTypeSpecifier),
                            TimeOfDay tod              => BindCqlOperator(CqlOperator.TimeOfDay),
                            Today today                => BindCqlOperator(CqlOperator.Today),
                            ToBoolean e                => ChangeType(e.operand!, typeof(bool?)),
                            ToConcept tc               => ChangeType(tc.operand!, _typeResolver.ConceptType),
                            ToDateTime tdte            => ChangeType(tdte.operand!, _typeResolver.DateTimeType),
                            ToDate tde                 => ChangeType(tde.operand!, _typeResolver.DateType),
                            ToDecimal tde              => ChangeType(tde.operand!, typeof(decimal?)),
                            ToInteger tde              => ChangeType(tde.operand!, typeof(int?)),
                            ToList tle                 => BindCqlOperator(CqlOperator.ToList, tle.operand!),
                            ToLong toLong              => ChangeType(toLong.operand!, typeof(long?)),
                            ToQuantity tq              => ChangeType(tq.operand!, _typeResolver.QuantityType),
                            ToString e                 => ChangeType(e.operand!, typeof(string)),
                            ToTime e                   => ChangeType(e.operand!, _typeResolver.TimeType),
                            After after                => After(after),
                            AliasRef ar                => GetScopeExpression(ar.name!),
                            As @as                     => As(@as),
                            AnyInValueSet avs          => ProcessValueSet(avs.valueset, avs.codes, isList: true),
                            Before before              => Before(before),
                            CalculateAgeAt caa         => BindCqlOperator(CqlOperator.CalculateAgeAt, [.. caa.operand[..2], caa.precisionOrNull()]),
                            CalculateAge ca            => BindCqlOperator(CqlOperator.CalculateAge, ca.operand, ca.precisionOrNull()),
                            Case ce                    => Case(ce),
                            Coalesce cle               => Coalesce(cle),
                            CodeRef cre                => CodeRef(cre),
                            CodeSystemRef csr          => CodeSystemRef(csr),
                            Collapse col               => Collapse(col),
                            Combine com                => Combine(com),
                            Concatenate cctn           => BindCqlOperator(CqlOperator.Concatenate, cctn.operand),
                            ConceptRef cr              => ConceptRef(cr),
                            Contains ct                => Contains(ct),
                            ConvertQuantity cqe        => BindCqlOperator(CqlOperator.ConvertQuantity, cqe.operand[..2]),
                            DateFrom dfe               => BindCqlOperator(CqlOperator.DateComponent, dfe.operand!),
                            Elm.DateTime dt            => BindCqlOperator(CqlOperator.DateTime, dt.year, dt.month, dt.day, dt.hour, dt.minute, dt.second, dt.millisecond, dt.timezoneOffset),
                            Date d                     => BindCqlOperator(CqlOperator.Date, d.year, d.month, d.day),
                            DateTimeComponentFrom dtcf => BindCqlOperator(CqlOperator.DateTimeComponent, dtcf.operand, dtcf.precisionOrNull()), // https://cql.hl7.org/02-authorsguide.html#datetime-operators
                            Descendents desc           => desc.source == null ? NullConstantExpression.ForType<IEnumerable<object>>() : BindCqlOperator(CqlOperator.Descendents, desc.source),
                            DifferenceBetween dbe      => BindCqlOperator(CqlOperator.DifferenceBetween, [.. dbe.operand[..2], dbe.precisionOrNull()]),
                            DurationBetween dbe        => BindCqlOperator(CqlOperator.DurationBetween, [.. dbe.operand[..2], dbe.precisionOrNull()]),
                            Ends e                     => Ends(e),
                            Equal eq                   => BindCqlOperator(CqlOperator.Equal, eq.operand[..2]),
                            Equivalent eqv             => Equivalent(eqv),
                            Except ex                  => Except(ex),
                            Expand expand              => BindCqlOperator(CqlOperator.Expand, expand.operand[..2]),
                            ExpandValueSet evs         => CqlOperatorsBinder.CallCreateValueSetFacade(Translate(evs.operand!)),
                            FunctionRef fre            => FunctionRef(fre),
                            ExpressionRef ere          => ExpressionRef(ere),
                            First first                => BindCqlOperator(CqlOperator.First, first.source!),
                            IdentifierRef ire          => IdentifierRef(ire),
                            If @if                     => If(@if),
                            Includes inc               => Includes(inc),
                            IncludedIn ii              => IncludedIn(ii),
                            Indexer idx                => Indexer(idx),
                            IndexOf io                 => IndexOf(io),
                            Instance ine               => Instance(ine),
                            Intersect ise              => Intersect(ise),
                            Interval ie                => IntervalExpression(ie),
                            InValueSet inv             => ProcessValueSet(inv.valueset!, inv.code, isList: false),
                            In @in                     => In(@in),
                            Is @is                     => Is(@is),
                            IsNull isn                 => IsNull(isn),
                            Last last                  => BindCqlOperator(CqlOperator.Last, last.source),
                            LastPositionOf lpo         => BindCqlOperator(CqlOperator.LastPositionOf, lpo.@string, lpo.pattern!),
                            Length len                 => Length(len),
                            List list                  => List(list),
                            Literal lit                => Literal(lit),
                            MaxValue max               => BindCqlOperator(CqlOperator.MaximumValue, Expression.Constant(_typeResolver.ResolveType(max.valueType!.Name), typeof(Type))),
                            Meets meets                => Meets(meets),
                            MeetsBefore meets          => MeetsBefore(meets),
                            MeetsAfter meets           => MeetsAfter(meets),
                            Message msg                => Message(msg),
                            MinValue min               => BindCqlOperator(CqlOperator.MinimumValue, Expression.Constant(_typeResolver.ResolveType(min.valueType!.Name), typeof(Type))),
                            NotEqual ne                => BindCqlOperator(CqlOperator.Not, BindCqlOperator(CqlOperator.Equal, ne.operand[..2])),
                            Now now                    => BindCqlOperator(CqlOperator.Now),
                            Null @null                 => NullConstantExpression.ForType(TypeFor(@null)!),
                            OperandRef ore             => OperandRef(ore),
                            Overlaps ole               => Overlaps(ole),
                            OverlapsAfter ola          => OverlapsAfter(ola),
                            OverlapsBefore olb         => OverlapsBefore(olb),
                            ParameterRef pre           => ParameterRef(pre),
                            PositionOf po              => BindCqlOperator(CqlOperator.PositionOf, po.pattern, po.@string),
                            ProperContains pc          => ProperContains(pc),
                            ProperIn pi                => ProperIn(pi),
                            ProperIncludes pi          => ProperIncludes(pi),
                            ProperIncludedIn pie       => ProperIncludedIn(pie),
                            Property pe                => Property(pe),
                            Quantity qua               => BindCqlOperator(CqlOperator.Quantity, qua.value, qua.unit, "http://unitsofmeasure.org"),
                            Query qe                   => Query(qe),
                            QueryLetRef qlre           => GetScopeExpression(qlre.name!),
                            Ratio re                   => BindCqlOperator(CqlOperator.Ratio, re.numerator, re.denominator),
                            ReplaceMatches e           => ReplaceMatches(e),
                            Retrieve re                => Retrieve(re),
                            Round rnd                  => BindCqlOperator(CqlOperator.Round, rnd.operand, rnd.precision),
                            SameAs sa                  => SameAs(sa),
                            SameOrAfter soa            => SameOrAfter(soa),
                            SameOrBefore sob           => SameOrBefore(sob),
                            Slice slice                => Slice(slice),
                            Split split                => Split(split),
                            Substring e                => Substring(e),
                            Starts starts              => Starts(starts),
                            Time time                  => BindCqlOperator(CqlOperator.Time, time.hour, time.minute, time.second, time.millisecond),
                            Elm.Tuple tu               => Tuple(tu),
                            Union ue                   => Union(ue),
                            ValueSetRef vsre           => ValueSetRef(vsre),
                            _                          => throw this.NewExpressionBuildingException($"Expression {element.GetType().FullName} is not implemented.")
                            //@formatter:on
                        };

                        expression = ChangeType(expression!, element.resultTypeSpecifier);
                        expression = Mutate(element, expression);
                        return expression!;
                    }
                });

        protected Expression? Mutate(Element op, Expression? expression) =>
            _expressionMutators.Aggregate(
                expression,
                (current, visitor) =>
                    visitor.Mutate(current!, op, this));

        protected Expression? IdentifierRef(IdentifierRef ire)
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

        protected Expression ValueSetRef(ValueSetRef valueSetRef)
        {
            if (string.IsNullOrWhiteSpace(valueSetRef.name))
                throw this.NewExpressionBuildingException($"The ValueSetRef at {valueSetRef.locator} is missing a name.");
            var type = TypeFor(valueSetRef)!;
            var cqlValueSet = InvokeDefinitionThroughRuntimeContext(valueSetRef.name, valueSetRef.libraryName, typeof(CqlValueSet));

            if (_typeResolver.IsListType(type))
            {
                var elementType = _typeResolver.GetListElementType(type);
                if (elementType != typeof(CqlCode))
                {
                    throw this.NewExpressionBuildingException($"The expected type for value set {valueSetRef.name} in this context is {TypeManager.PrettyTypeName(type)}");
                }

                var @new = CqlOperatorsBinder.CallCreateValueSetFacade(cqlValueSet);
                return @new;
            }
            return cqlValueSet;
        }

        protected Expression Tuple(Elm.Tuple tuple)
        {
            Type tupleType;
            if (tuple.resultTypeSpecifier is null)
            {
                tupleType = TupleTypeFor(tuple);
            }
            else
            {
                var tupleTypeSpecifier = tuple.resultTypeSpecifier as Elm.TupleTypeSpecifier ?? throw this.NewExpressionBuildingException($"Tuple expression has a resultType that is not a TupleTypeSpecifier.");
                tupleType = TupleTypeFor(tupleTypeSpecifier);
            }

            var @new = Expression.New(tupleType);
            if (tuple.element?.Length > 0)
            {
                var elementBindings =
                    tuple.element!
                        .SelectToArray(element =>
                        {
                            var value = Translate(element.value!);
                            var propInfo = GetProperty(tupleType, NormalizeIdentifier(element.name!), _typeResolver)
                                           ?? throw this.NewExpressionBuildingException($"Could not find member {element} on type {TypeManager.PrettyTypeName(tupleType)}");
                            var binding = Binding(value, propInfo);
                            return binding;
                        });
                var init = Expression.MemberInit(@new, elementBindings);
                return init;
            }

            return @new;
        }

        protected Expression List(List list)
        {
            if (list.resultTypeSpecifier == null)
                throw this.NewExpressionBuildingException($"List is missing a result type specifier.");
            if (list.resultTypeSpecifier is Elm.ListTypeSpecifier listTypeSpecifier)
            {

                var elementType = TypeFor(listTypeSpecifier.elementType);
                var elements =  TranslateAll(list.element);
                if (!elementType.IsNullable(out _) && elements.Any(exp => exp.Type.IsNullable(out _)))
                {
                    for (int i = 0; i < elements.Length; i++)
                    {
                        elements[i] = HandleNullable(elements[i], elementType);

                    }
                }
                for (int i = 0; i < elements.Length; i++)
                {
                    if (elements[i].Type != elementType)
                    {
                        elements[i] = elements[i].ExprTypeAs(elementType);
                    }
                }
                Expression? array = null;
                if (elements != null)
                {
                    array = Expression.NewArrayInit(elementType, elements);
                }
                else
                {
                    array = Expression.NewArrayBounds(elementType, Expression.Constant(0));
                }
                var asEnumerable = array.ExprTypeAs(typeof(IEnumerable<>).MakeGenericType(elementType));
                return asEnumerable;
            }

            throw this.NewExpressionBuildingException($"List is the wrong type");

        }

        protected Expression CodeRef(CodeRef codeRef)
        {
            if (string.IsNullOrWhiteSpace(codeRef.name))
                throw this.NewExpressionBuildingException("The code ref has no name.");

            var type = _typeResolver.ResolveType(codeRef.resultTypeName.Name) ?? throw this.NewExpressionBuildingException($"Unable to resolve type {codeRef.resultTypeName}");
            return InvokeDefinitionThroughRuntimeContext(codeRef.name, codeRef.libraryName, type);
        }

        private Expression CodeSystemRef(CodeSystemRef codeSystemRef)
        {
            if (string.IsNullOrWhiteSpace(codeSystemRef.name))
                throw this.NewExpressionBuildingException("The code system ref has no name.");

            var type = _typeResolver.CodeType.MakeArrayType();
            return InvokeDefinitionThroughRuntimeContext(codeSystemRef.name, codeSystemRef.libraryName, type);
        }
        protected Expression ConceptRef(ConceptRef conceptRef)
        {
            if (string.IsNullOrWhiteSpace(conceptRef.name))
                throw this.NewExpressionBuildingException("The concept ref has no name.");

            var type = _typeResolver.CodeType.MakeArrayType();
            return InvokeDefinitionThroughRuntimeContext(conceptRef.name, conceptRef.libraryName, type);
        }

        protected Expression Instance(Instance ine)
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
                    var enumValueValue = Translate(ine.element[0]!.value!);

                    if (enumValueValue.Type == instanceType)
                        return enumValueValue;

                    if (enumValueValue.Type == typeof(string)) //@ TODO: Cast
                    {
                        var parseMethod = typeof(Enum)
                            .GetMethods()
                            .Single(m => m.Name == nameof(Enum.Parse) && m.GetParameters().Length == 3);
                        var callEnumParse = Expression.Call(parseMethod, Expression.Constant(instanceType), enumValueValue, Expression.Constant(true));
                        return callEnumParse;
                    }
                }
            }
            // Prefer a constructor will all parameters.


            //var valueTypes = values
            //    .Select(v => v.Type)
            //    .ToArray();
            //var allConstructors = instanceType!
            //    .GetConstructors();
            //ConstructorInfo? allParamsCtor = null;
            //foreach(var ctor in allConstructors)
            //{
            //    var ctorParameters = ctor.GetParameters();
            //    if (ctorParameters.Length == valueTypes.Length)
            //    {
            //        if (ctorParameters.All(p => p.T))
            //    }
            //}

            var tuples = ine.element!.SelectToArray(el => (el.name!, Translate(el.value)));

            // Handle immutable primitives without public setters on their properties.
            if (instanceType == typeof(CqlRatio))
            {
                Expression? numeratorExpr = null;
                Expression? denominatorExpr = null;

                foreach (var tuple in tuples)
                {
                    if (tuple.Item1 == "numerator")
                        numeratorExpr = tuple.Item2;
                    else if (tuple.Item1 == "denominator")
                        denominatorExpr = tuple.Item2;
                    else throw this.NewExpressionBuildingException($"No property called {tuple.Item1} should exist on {nameof(CqlRatio)}");
                }
                var ctor = ConstructorInfos.CqlRatio;
                var @new = Expression.New(ctor,
                    numeratorExpr ?? Expression.Default(typeof(CqlQuantity)),
                    denominatorExpr ?? Expression.Default(typeof(CqlQuantity)));
                return @new;
            }

            if (instanceType == typeof(CqlQuantity))
            {
                Expression? valueExpr = null;
                Expression? unitExpr = null;

                foreach (var tuple in tuples)
                {
                    if (tuple.Item1 == "value")
                        valueExpr = tuple.Item2;
                    else if (tuple.Item1 == "unit")
                        unitExpr = tuple.Item2;
                    else throw this.NewExpressionBuildingException($"No property called {tuple.Item1} should exist on {nameof(CqlQuantity)}");
                }
                var ctor = ConstructorInfos.CqlQuantity;

                if (unitExpr is not null)
                    unitExpr = ChangeType(unitExpr, typeof(string));

                var @new = Expression.New(ctor,
                    valueExpr ?? Expression.Default(typeof(decimal?)),
                    unitExpr ?? Expression.Default(typeof(string)));
                return @new;
            }
            if (instanceType == typeof(CqlCode))
            {
                Expression? codeExpr = null;
                Expression? systemExpr = null;
                Expression? versionExpr = null;
                Expression? displayExpr = null;


                foreach (var tuple in tuples)
                {
                    if (tuple.Item1 == "code")
                        codeExpr = tuple.Item2;
                    else if (tuple.Item1 == "system")
                        systemExpr = tuple.Item2;
                    else if (tuple.Item1 == "version")
                        versionExpr = tuple.Item2;
                    else if (tuple.Item1 == "display")
                        displayExpr = tuple.Item2;
                    else throw this.NewExpressionBuildingException($"No property called {tuple.Item1} should exist on {nameof(CqlCode)}");
                }
                var ctor = ConstructorInfos.CqlCode;
                var @new = Expression.New(ctor,
                    codeExpr ?? Expression.Default(typeof(string)),
                    systemExpr ?? Expression.Default(typeof(string)),
                    versionExpr ?? Expression.Default(typeof(string)),
                    displayExpr ?? Expression.Default(typeof(string)));
                return @new;
            }
            if (instanceType == typeof(CqlConcept))
            {
                Expression? codesExpr = null;
                Expression? displayExpr = null;

                foreach (var tuple in tuples)
                {
                    if (tuple.Item1 == "codes")
                        codesExpr = tuple.Item2;
                    else if (tuple.Item1 == "display")
                        displayExpr = tuple.Item2;
                    else throw this.NewExpressionBuildingException($"No property called {tuple.Item1} should exist on {nameof(CqlConcept)}");
                }
                var ctor = ConstructorInfos.CqlConcept;
                var @new = Expression.New(ctor,
                    codesExpr ?? Expression.Default(typeof(IEnumerable<CqlCode>)),
                    displayExpr ?? Expression.Default(typeof(string)));
                return @new;
            }
            else
            {
                var elementBindings = new MemberAssignment[tuples.Length];
                for (int i = 0; i < tuples.Length; i++)
                {
                    var tuple = tuples[i];
                    var element = tuple.Item1;
                    var expression = tuple.Item2;
                    var memberInfo = GetProperty(instanceType, element, _typeResolver) ?? throw this.NewExpressionBuildingException($"Could not find member {element} on type {TypeManager.PrettyTypeName(instanceType)}");
                    var binding = Binding(expression, memberInfo);
                    elementBindings[i] = binding;
                }
                var ctor = instanceType.GetConstructor(Type.EmptyTypes)!;
                var @new = Expression.New(ctor);
                var init = Expression.MemberInit(@new, elementBindings);
                return init;
            }
        }

        protected MemberAssignment Binding(Expression value, MemberInfo memberInfo)
        {
            if (memberInfo is PropertyInfo property)
            {
                if (value.Type == property.PropertyType)
                {
                    return Expression.Bind(memberInfo, value);
                }

                if (property.PropertyType.IsArray)
                {
                    if (value.Type.IsArray)
                    {
                        if (property.PropertyType.GetElementType() == value.Type.GetElementType())
                        {
                            return Expression.Bind(memberInfo, value);
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
                            var callToArray = Expression.Call(toArrayMethod, value);
                            return Expression.Bind(memberInfo, callToArray);
                        }
                        else
                        {
                            var selectParameter = Expression.Parameter(valueEnumerableElement, TypeNameToIdentifier(value.Type, this));
                            var body = ChangeType(selectParameter, memberArrayElement);
                            var selectLambda = Expression.Lambda(body, selectParameter);
                            var callSelectMethod = BindCqlOperator(CqlOperator.Select, [value, selectLambda
                            ]);
                            var toArrayMethod = typeof(Enumerable)
                                .GetMethod(nameof(Enumerable.ToArray))!
                                .MakeGenericMethod(memberArrayElement);
                            var callToArray = Expression.Call(toArrayMethod, callSelectMethod);
                            return Expression.Bind(memberInfo, callToArray);
                        }
                    }
                }
                else if (property.PropertyType.IsImplementingGenericTypeDefinition(typeof(ICollection<>)))
                {
                    if (_typeResolver.IsListType(value.Type))
                    {
                        var elementType = _typeResolver.GetListElementType(property.PropertyType)!;
                        var ctor = ConstructorInfos.ListOf(elementType);
                        var newList = Expression.New(ctor, value);
                        return Expression.Bind(memberInfo, newList);
                    }
                }
                var convert = ChangeType(value, property.PropertyType);
                return Expression.Bind(memberInfo, convert);
            }

            throw new NotImplementedException().WithContext(this);
        }

        protected Expression If(If @if)
        {
            var rc = Translate(@if.condition!);
            var condition = Expression.Coalesce(rc, Expression.Constant(false, typeof(bool)));
            var then = Translate(@if.then!);
            if (@if.@else != null)
            {
                var @else = Translate(@if.@else!);
                if (then.Type.IsValueType)
                {
                    @else = HandleNullable(@else, then.Type);
                }

                if (then.Type != @else.Type)
                {
                    // In fact, this is allowed, but since this would be handled using type "object" at runtime
                    // (since the CLR does not support discriminated unions), we will throw an exception here.
                    // We could also optimize by first trying whether the arguments are convertible to each other,
                    // since that would catch quite a few cases (mostly the if .... then X else List<X> cases),
                    // which are common.
                     throw this.NewExpressionBuildingException(
                        $"The If expression at {@if.locator} produces two branches with different types.");
                    // then = Expression.Convert(then, typeof(object));
                    // @else = Expression.Convert(@else, typeof(object));
                }

                var ifThenElse = Expression.Condition(condition, then, @else);

                return ifThenElse;
            }

            var @false = Expression.Constant(null).ExprConvert(then.Type);
            var ifThen = Expression.Condition(condition, then, @false);
            return ifThen;
        }

        protected Expression Literal(Literal lit)
        {
            var type = _typeResolver.ResolveType(lit.valueType.Name) ?? throw this.NewExpressionBuildingException($"Cannot resolve type for {lit.valueType}");


            var (value, convertedType) = ConvertLiteral(lit, type);

            // var result = _operatorBinding.ConvertToType(Expression.Constant(value), convertedType);
            // return result;

            if (type.IsNullable(out _))
            {
                var changed = Expression.Constant(value!, convertedType);
                var asNullable = changed.ExprConvert(type);
                return asNullable;
            }
            return Expression.Constant(value, convertedType);
        }

        protected (object?, Type) ConvertLiteral(Literal lit, Type? type) //@ TODO: Cast
        {
            if (type == null)
                throw new NotImplementedException().WithContext(this);

            if (type.IsNullable(out var underlyingType))
            {
                if (string.IsNullOrWhiteSpace(lit.value))
                    return (null, type);

                if (!typeof(IConvertible).IsAssignableFrom(underlyingType))
                    throw new NotSupportedException("Only convertible types can be used for literals.");

                try
                {
                    var converted = System.Convert.ChangeType(lit.value, underlyingType, CultureInfo.InvariantCulture); //@ TODO: Cast
                    return (converted, underlyingType);
                }
                catch (OverflowException)
                {
                    return (null, type);
                }
            }

            if (type == typeof(string))
                return (lit.value, type);

            if (typeof(IConvertible).IsAssignableFrom(type))
            {
                var converted = System.Convert.ChangeType(lit.value, type, CultureInfo.InvariantCulture); //@ TODO: Cast
                return (converted, type);
            }

            throw new NotSupportedException("Only convertible types can be used for literals.");
        }

        protected Expression OperandRef(OperandRef ore)
        {
            if (_operands.TryGetValue(ore.name!, out var expression))
                return expression;
            throw this.NewExpressionBuildingException($"Operand reference to {ore.name} not found in definition operands.");
        }

        protected Expression Case(Case ce)
        {
            //[{ when1, then1 }, { when2, then2}, { when3, then3 }]
            // when1 ? then 1 : (when2 ? then 2 : (when3 ? then 3 : else }
            if (ce.caseItem?.Length > 0 && ce.@else != null)
            {
                var elseThen = Translate(ce.@else!);
                var cases = new List<CaseWhenThenExpression.WhenThenCase>();

                if (ce.comparand != null)
                {
                    var comparand = Translate(ce.comparand);

                    foreach (var caseItem in ce.caseItem)
                    {
                        var caseWhen = Translate(caseItem.when!);
                        var caseWhenEquality = Expression.Coalesce(BindCqlOperator(CqlOperator.Equal, comparand, caseWhen), Expression.Constant(false));
                        var caseThen = Translate(caseItem.then!);

                        if (caseThen.Type != elseThen.Type)
                            caseThen = caseThen.ExprConvert(elseThen.Type);

                        cases.Add(new(caseWhenEquality, caseThen));
                    }
                }
                else
                {
                    foreach (var caseItem in ce.caseItem)
                    {
                        var caseWhen = Translate(caseItem.when!);
                        var caseThen = Translate(caseItem.then!);

                        if (caseThen.Type != elseThen.Type)
                            caseThen = caseThen.ExprConvert(elseThen.Type);

                        if (caseWhen.Type.IsNullable(out _))
                        {
                            caseWhen = Expression.Coalesce(caseWhen, Expression.Constant(false));
                        }

                        cases.Add(new(caseWhen, caseThen));
                    }
                }

                return new CaseWhenThenExpression(cases, elseThen);
            }

            throw this.NewExpressionBuildingException("Invalid case expression.  At least 1 case and an else must be present.");
        }

        private Expression Retrieve(Retrieve retrieve)
        {
            Type? sourceElementType;
            string? cqlRetrieveResultType;

            // SingletonFrom does not have this specified; in this case use DataType instead
            if (retrieve.resultTypeSpecifier == null)
            {
                if (string.IsNullOrWhiteSpace(retrieve.dataType.Name))
                    throw this.NewExpressionBuildingException("If a Retrieve lacks a ResultTypeSpecifier it must have a DataType");
                cqlRetrieveResultType = retrieve.dataType.Name;

                sourceElementType = _typeResolver.ResolveType(cqlRetrieveResultType);
            }
            else
            {
                if (retrieve.resultTypeSpecifier is Elm.ListTypeSpecifier listTypeSpecifier)
                {
                    cqlRetrieveResultType = listTypeSpecifier.elementType is Elm.NamedTypeSpecifier nts ? nts.name.Name : null;
                    sourceElementType = TypeFor(listTypeSpecifier.elementType);
                }
                else throw new NotImplementedException($"Sources with type {retrieve.resultTypeSpecifier.GetType().Name} are not implemented.").WithContext(this);
            }

            Expression? codeProperty;

            var hasCodePropertySpecified = sourceElementType != null && retrieve.codeProperty != null;
            var isDefaultCodeProperty = retrieve.codeProperty is null ||
                (cqlRetrieveResultType is not null &&
                 ModelMapping.TryGetValue(cqlRetrieveResultType, out ClassInfo? classInfo) &&
                 classInfo.primaryCodePath == retrieve.codeProperty);

            if (hasCodePropertySpecified && !isDefaultCodeProperty)
            {
                var codePropertyInfo = _typeResolver.GetProperty(sourceElementType!, retrieve.codeProperty!);
                codeProperty = Expression.Constant(codePropertyInfo, typeof(PropertyInfo));
            }
            else
            {
                codeProperty = NullConstantExpression.ForType<PropertyInfo>();
            }

            if (retrieve.codes != null)
            {
                if (retrieve.codes is ValueSetRef valueSetRef)
                {
                    if (string.IsNullOrWhiteSpace(valueSetRef.name))
                        throw this.NewExpressionBuildingException($"The ValueSetRef at {valueSetRef.locator} is missing a name.");
                    var valueSet = InvokeDefinitionThroughRuntimeContext(valueSetRef.name!, valueSetRef.libraryName, typeof(CqlValueSet));
                    return BindCqlOperator(CqlOperator.Retrieve, Expression.Constant(sourceElementType, typeof(Type)), valueSet, codeProperty);
                }

                // In this construct, instead of querying a value set, we're testing resources
                // against a list of codes, e.g., as defined by the code from or codesystem construct
                var codes = Translate(retrieve.codes);
                return BindCqlOperator(CqlOperator.Retrieve, Expression.Constant(sourceElementType, typeof(Type)), codes, codeProperty);
            }

            return BindCqlOperator(CqlOperator.Retrieve, Expression.Constant(sourceElementType, typeof(Type)), NullConstantExpression.ForType<CqlValueSet>(), codeProperty);
        }

        protected Expression Property(Property op)
        {
            using (PushElement(op))
            {
                if (string.IsNullOrWhiteSpace(op.path))
                    throw this.NewExpressionBuildingException("path cannot be null or empty");
                //var path = ExpressionBuilderContext.NormalizeIdentifier(op.path);
                var path = op.path;
                if (!string.IsNullOrWhiteSpace(op.scope))
                {
                    var scopeExpression = GetScopeExpression(op.scope!);
                    var expectedType = TypeFor(op) ?? typeof(object);
                    var pathMemberInfo = _typeResolver.GetProperty(scopeExpression.Type, path!) ??
                        _typeResolver.GetProperty(scopeExpression.Type, op.path);
                    if (pathMemberInfo == null)
                    {
                        _logger.LogWarning(FormatMessage($"Property {op.path} can't be known at design time, and will be late-bound, slowing performance.  Consider casting the source first so that this property can be definitely bound.", op));
                        return BindCqlOperator(CqlOperator.LateBoundProperty, scopeExpression, Expression.Constant(op.path, typeof(string)), Expression.Constant(expectedType, typeof(Type)));
                    }
                    var propogate = PropagateNull(scopeExpression, pathMemberInfo);
                    // This is only necessary for Firely b/c it always initializes colleciton members even if they are
                    // not included in the FHIR, and this makes it impossible for CQL to differentiate [] from null
                    //
                    //if (typeof(Resource).IsAssignableFrom(scopeExpression.Type)
                    //    && pathMemberInfo is PropertyInfo prop
                    //    && IsOrImplementsIEnumerableOfT(prop.PropertyType))
                    //{
                    //    var method = typeof(BuiltIns).GetMethod(nameof(BuiltIns.NullIfEmpty))
                    //        .MakeGenericMethod(GetElementType(prop.PropertyType));
                    //    var call = Expression.Call(method, propogate);
                    //    return call;
                    //}
                    string message = $"TypeManager failed to resolve type.";
                    var resultType = TypeFor(op) ?? throw this.NewExpressionBuildingException(message);
                    if (resultType != propogate.Type)
                    {
                        propogate = ChangeType(propogate, resultType);
                    }
                    return propogate;
                }

                if (op.source != null)
                {
                    var source = Translate(op.source);
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

                    var expectedType = TypeFor(op, throwIfNotFound: false);

                    // If we cannot determine the type from the ELM, let's try
                    // if the POCO model can help us.
                    if(expectedType == null)
                    {
                        expectedType = _typeResolver.GetProperty(source.Type, path)?.PropertyType
                                       ?? throw this.NewExpressionBuildingException("Cannot resolve type for expression");
                    }

                    var result = PropertyHelper(source, path, expectedType);
                    return result;
                }
                throw new NotImplementedException().WithContext(this);
            }
        }

        protected Expression PropertyHelper(Expression source, string? path, Type expectedType)
        {
            Expression? result = null;
            if (_typeResolver.ShouldUseSourceObject(source.Type, path!))
            {
                result = source;
            }
            else
            {
                var pathMemberInfo = _typeResolver.GetProperty(source.Type, path!);
                if (pathMemberInfo == null)
                {
                    _logger.LogWarning(FormatMessage($"Property {path} can't be known at design time, and will be late-bound, slowing performance.  Consider casting the source first so that this property can be definitely bound."));
                    return BindCqlOperator(CqlOperator.LateBoundProperty, source, Expression.Constant(path, typeof(string)), Expression.Constant(expectedType, typeof(Type)));
                }
                if (pathMemberInfo is PropertyInfo property && pathMemberInfo.DeclaringType != source.Type) // the property is on a derived type, so cast it
                {
                    var isCheck = source.ExprTypeIs(pathMemberInfo.DeclaringType!);
                    var typeAs = source.ExprTypeAs(pathMemberInfo.DeclaringType!);
                    var pathAccess = Expression.MakeMemberAccess(typeAs, pathMemberInfo);
                    Expression? ifIs = pathAccess;
                    Expression elseNull = Expression.Constant(null, property.PropertyType);
                    // some ops, like properties on alias refs, don't have type information on them.
                    // can't check against what we don't have.
                    if (expectedType != null)
                    {
                        if (expectedType != ifIs.Type)
                        {
                            ifIs = ChangeType(ifIs, expectedType);
                        }
                        if (expectedType != elseNull.Type)
                            elseNull = ChangeType(elseNull, expectedType);
                    }
                    var condition = Expression.Condition(isCheck, ifIs, elseNull);
                    return condition;
                }

                result = PropagateNull(source, pathMemberInfo);
            }

            if (expectedType != null && expectedType != result.Type)
            {
                if (expectedType == typeof(string))
                {
                    if (result.Type.IsEnum())
                        return result;
                }
                result = ChangeType(result, expectedType);
            }
            return result;
        }

        protected Expression FunctionRef(FunctionRef op)
        {
            Expression[] operands = TranslateAll(op.operand);

            // FHIRHelpers has special handling in CQL-to-ELM and does not translate correctly - specifically,
            // it interprets ToString(value string) oddly.  Normally when string is used in CQL it is resolved to the elm type.
            // In FHIRHelpers, this string gets treated as a FHIR string, which is normally mapped to a StringElement abstraction.
            if (op.libraryName is { } alias)
            {
                string libraryName = _libraryContext.GetNameAndVersionFromAlias(alias, throwError: true)!;
                if (libraryName.StartsWith("fhirhelpers", StringComparison.OrdinalIgnoreCase)
                    && op.name!.Equals("tostring", StringComparison.OrdinalIgnoreCase))
                {
                    if (operands[0].Type == typeof(string))
                    {
                        return operands[0];
                    }

                    return BindCqlOperator(CqlOperator.Convert, operands[0], Expression.Constant(typeof(string), typeof(Type)));
                }
            }

            var invoke = InvokeDefinedFunctionThroughRuntimeContext(op.name!, op.libraryName!, operands);
            return invoke;
        }

        protected Expression ExpressionRef(ExpressionRef expressionRef)
        {
            IPopToken popToken = null!;
            try
            {
                Type? expressionType = null;
                if (expressionRef.resultTypeSpecifier != null)
                {
                    expressionType = TypeFor(expressionRef.resultTypeSpecifier);
                }
                else if (!string.IsNullOrWhiteSpace(expressionRef.resultTypeName?.Name))
                {
                    expressionType = _typeResolver.ResolveType(expressionRef.resultTypeName.Name);
                }
                else
                {
                    var def = _libraryContext.Library.statements?.SingleOrDefault(d => d.name == expressionRef.name);
                    if (def != null)
                    {
                        popToken = PushElement(def);
                        expressionType = TypeFor(def);
                    }
                    else throw new NotSupportedException("Unable to resolve expression reference type.");
                }

                if (expressionType == null)
                    throw this.NewExpressionBuildingException($"Unable to determine type for {expressionRef.localId}");

                var invoke = InvokeDefinitionThroughRuntimeContext(expressionRef.name!, expressionRef.libraryName, expressionType);

                return invoke;
            }
            finally
            {
                popToken?.Pop();
            }
        }

        protected Expression ParameterRef(ParameterRef op)
        {
            if (_libraryContext.LibraryDefinitions.TryGetValue(_libraryContext.LibraryKey, op.name!, out var lambda) && lambda != null)
            {
                var invoke = InvokeDefinitionThroughRuntimeContext(op.name!, null, lambda);
                return invoke;
            }

            throw this.NewExpressionBuildingException($"Parameter {op.name} hasn't been defined yet.");
        }

        /// <param name="name">The function name</param>
        /// <param name="libraryAlias">If this is an external call, the local alias defined in the using statement</param>
        /// <param name="arguments">The function arguments</param>
        /// <returns></returns>
        protected Expression InvokeDefinedFunctionThroughRuntimeContext(
            string name,
            string? libraryAlias,
            Expression[] arguments)
        {
            string libraryName = _libraryContext.GetNameAndVersionFromAlias(libraryAlias, throwError: false)
                                 ?? throw this.NewExpressionBuildingException($"Local library {libraryAlias} is not defined; are you missing a using statement?");

            var argumentTypes = arguments.SelectToArray(a => a.Type);
            var selected = _libraryContext.LibraryDefinitions.Resolve(libraryName, name, CheckConversion, argumentTypes);
            Type definitionType = GetFuncType(selected.Parameters.Select(p => p.Type).Append(selected.ReturnType).ToArray());
            var parameterTypes = selected.Parameters.Skip(1).Select(p => p.Type).ToArray();

            // all functions still take the bundle and context parameters, plus whatver the operands
            // to the actual function are.
            var convertedArguments = arguments
                .Select((arg, i) => ChangeType(arg, parameterTypes[i]))
                .Prepend(CqlExpressions.ParameterExpression)
                .ToArray();

            return new FunctionCallExpression(CqlExpressions.Definitions_PropertyExpression, libraryName, name, convertedArguments, definitionType);

            bool CheckConversion(Type from, Type to) => _typeConverter.CanConvert(from, to);
        }

        protected Expression InvokeDefinitionThroughRuntimeContext(
            string name,
            string? libraryAlias,
            LambdaExpression definition)
        {
            var type = definition.Type;
            if (type.IsGenericType)
            {
                var typeArgs = type.GetGenericArguments();
                var returnType = typeArgs[^1];
                var invoke = InvokeDefinitionThroughRuntimeContext(name, libraryAlias, returnType);
                return invoke;
            }

            throw this.NewExpressionBuildingException("LambdaExpressions should be a variant of Func<>");
        }

        protected Expression InvokeDefinitionThroughRuntimeContext(
            string name,
            string? libraryAlias,
            Type definitionReturnType)
        {
            string libraryName = _libraryContext.GetNameAndVersionFromAlias(libraryAlias, throwError: false)
                                 ?? throw this.NewExpressionBuildingException($"Local library {libraryAlias} is not defined; are you missing a using statement?");

            var funcType = typeof(Func<,>).MakeGenericType(typeof(CqlContext), definitionReturnType);
            return new DefinitionCallExpression(CqlExpressions.Definitions_PropertyExpression, libraryName, name, CqlExpressions.ParameterExpression, funcType);
        }

        private Expression ProcessValueSet(ValueSetRef valueSetRef, Elm.Expression valueExpr, bool isList)
        {
            Expression expr = Translate(valueExpr);

            var codeType = isList ? _typeResolver.GetListElementType(expr.Type, throwError: true)! : expr.Type;

            var valueSet = InvokeDefinitionThroughRuntimeContext(valueSetRef.name!, valueSetRef.libraryName, typeof(CqlValueSet));
            if (codeType == _typeResolver.CodeType)
                return BindCqlOperator(isList ? CqlOperator.CodesInValueSet : CqlOperator.CodeInValueSet, expr, valueSet);

            if (codeType == _typeResolver.ConceptType)
                return BindCqlOperator(isList ? CqlOperator.ConceptsInValueSet : CqlOperator.ConceptInValueSet, expr, valueSet);

            if (codeType == typeof(string))
                return BindCqlOperator(isList ? CqlOperator.StringsInValueSet: CqlOperator.StringInValueSet, expr, valueSet);

            throw new NotImplementedException().WithContext(this);
        }
    }
}