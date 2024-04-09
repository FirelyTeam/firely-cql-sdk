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
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Conversion;
using Hl7.Cql.Operators;
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
        // Yeah, hardwired to FHIR 4.0.1 for now.
        private static readonly IDictionary<string, ClassInfo> ModelMapping = Models.ClassesById(Models.Fhir401);

        private readonly ILogger<ExpressionBuilder> _logger = null!;

        internal ExpressionBuilder(
            ILogger<ExpressionBuilder> logger,
            OperatorBinding operatorBinding,
            TypeManager typeManager,
            TypeConverter typeConverter,
            LibraryDefinitionBuilderSettings settings,
            LibraryExpressionBuilder libContext)
        {
            // External Services
            _operatorBinding = operatorBinding;
            _typeManager = typeManager;
            _logger = logger;
            _typeConverter = typeConverter;

            // External State
            _libraryDefinitionBuilderSettings = settings ?? throw new ArgumentNullException(nameof(settings));
            LibraryContext = libContext;

            // Internal State
            _impliedAlias = null;
            _operands = new Dictionary<string, ParameterExpression>();
            _libraries = new Dictionary<string, DefinitionDictionary<LambdaExpression>>();
            _scopes = new Dictionary<string, (Expression, Elm.Element)>();
            _expressionMutators = new List<IExpressionMutator>();
            _customImplementations = new Dictionary<string, Func<ParameterExpression[], LambdaExpression>>();
        }

        private ExpressionBuilder(
            ExpressionBuilder source)
        {
            _elementStack = new Stack<Elm.Element>(_elementStack);
            _libraryDefinitionBuilderSettings = source._libraryDefinitionBuilderSettings;
            _operatorBinding = source._operatorBinding;
            _impliedAlias = source._impliedAlias;
            _operands = source._operands;
            _libraries = source._libraries;
            _scopes = source._scopes;
            LibraryContext = source.LibraryContext;
            _typeManager = source._typeManager;
            _logger = source._logger;
            _expressionMutators = source._expressionMutators;
            _customImplementations = source._customImplementations;
            _typeConverter = source._typeConverter;
        }

        private ExpressionBuilder(
            ExpressionBuilder outer,
            string? impliedAlias,
            IDictionary<string, (Expression, Elm.Element)> scopes) : this(outer)
        {
            _scopes = scopes;
            _impliedAlias = impliedAlias;
        }



        internal Expression TranslateExpression(Element op) =>
            this.CatchRethrowExpressionBuildingException(
                _ => {
                    using (PushElement(op))
                    {
                        Expression? expression = op switch
                        {
                            //@formatter:off
                            Abs abs                    => UnaryOperator(CqlOperator.Abs, abs),
                            Add add                    => BinaryOperator(CqlOperator.Add, add),
                            After after                => After(after),
                            AliasRef ar                => AliasRef(ar),
                            AllTrue alt                => AllTrue(alt),
                            And and                    => BinaryOperator(CqlOperator.And, and),   // https://cql.hl7.org/09-b-cqlreference.html#and
                            As @as                     => As(@as),
                            AnyTrue ate                => AnyTrue(ate),
                            AnyInValueSet avs          => AnyInValueSet(avs),
                            Avg avg                    => Avg(avg),
                            Before before              => Before(before),
                            CalculateAgeAt caa         => CalculateAgeAt(caa),
                            CalculateAge ca            => CalculateAge(ca),
                            Case ce                    => Case(ce),
                            Ceiling ceil               => UnaryOperator(CqlOperator.Ceiling, ceil),
                            Coalesce cle               => Coalesce(cle),
                            CodeRef cre                => CodeRef(cre),
                            CodeSystemRef csr          => CodeSystemRef(csr),
                            Collapse col               => Collapse(col),
                            Combine com                => Combine(com),
                            Concatenate cctn           => NaryOperator(CqlOperator.Concatenate, cctn),
                            ConceptRef cr              => ConceptRef(cr),
                            Contains ct                => Contains(ct),
                            ConvertQuantity cqe        => ConvertQuantity(cqe),
                            ConvertsToBoolean ce       => UnaryOperator(CqlOperator.ConvertsToDate, ce),
                            ConvertsToDate ce          => UnaryOperator(CqlOperator.ConvertsToDate, ce),
                            ConvertsToDateTime ce      => UnaryOperator(CqlOperator.ConvertsToDateTime, ce),
                            ConvertsToDecimal ce       => UnaryOperator(CqlOperator.ConvertsToDecimal, ce),
                            ConvertsToLong ce          => UnaryOperator(CqlOperator.ConvertsToLong, ce),
                            ConvertsToInteger ce       => UnaryOperator(CqlOperator.ConvertsToInteger, ce),
                            ConvertsToQuantity ce      => UnaryOperator(CqlOperator.ConvertsToQuantity, ce),
                            ConvertsToString ce        => UnaryOperator(CqlOperator.ConvertsToString, ce),
                            ConvertsToTime ce          => UnaryOperator(CqlOperator.ConvertsToTime, ce),
                            Count ce                   => Count(ce),
                            DateFrom dfe               => DateFrom(dfe),
                            Elm.DateTime dt            => DateTime(dt),
                            Date d                     => Date(d),
                            DateTimeComponentFrom dtcf => DateTimeComponentFrom(dtcf),
                            Descendents desc           => Descendents(desc),
                            DifferenceBetween dbe      => DifferenceBetween(dbe),
                            Distinct distinct          => UnaryOperator(CqlOperator.Distinct, distinct),
                            Divide divide              => BinaryOperator(CqlOperator.Divide, divide),
                            DurationBetween dbe        => DurationBetween(dbe),
                            End e                      => UnaryOperator(CqlOperator.IntervalEnd, e),
                            Ends e                     => Ends(e),
                            EndsWith e                 => BinaryOperator(CqlOperator.EndsWith, e),
                            Equal eq                   => Equal(eq),
                            Equivalent eqv             => Equivalent(eqv),
                            Except ex                  => Except(ex),
                            Exists ex                  => UnaryOperator(CqlOperator.Exists, ex),
                            Exp exe                    => UnaryOperator(CqlOperator.Exp, exe),
                            Expand expand              => Expand(expand),
                            ExpandValueSet evs         => ExpandValueSet(evs),
                            FunctionRef fre            => FunctionRef(fre),
                            ExpressionRef ere          => ExpressionRef(ere),
                            First first                => First(first),
                            Flatten fl                 => UnaryOperator(CqlOperator.Flatten, fl),
                            Floor floor                => UnaryOperator(CqlOperator.Floor, floor),
                            GeometricMean gme          => GeometricMean(gme),
                            Greater gtr                => BinaryOperator(CqlOperator.Greater, gtr),
                            GreaterOrEqual gtre        => BinaryOperator(CqlOperator.GreaterOrEqual, gtre),
                            HighBoundary hb            => BinaryOperator(CqlOperator.HighBoundary, hb),
                            IdentifierRef ire          => IdentifierRef(ire),
                            If @if                     => If(@if),
                            Implies implies            => BinaryOperator(CqlOperator.Implies, implies), // https://cql.hl7.org/09-b-cqlreference.html#implies
                            Includes inc               => Includes(inc),
                            IncludedIn ii              => IncludedIn(ii),
                            Indexer idx                => Indexer(idx),
                            IndexOf io                 => IndexOf(io),
                            Instance ine               => Instance(ine),
                            Intersect ise              => Intersect(ise),
                            Interval ie                => IntervalExpression(ie),
                            InValueSet inv             => InValueSet(inv),
                            In @in                     => In(@in),
                            Is @is                     => Is(@is),
                            IsFalse isn                => UnaryOperator(CqlOperator.IsFalse, isn),
                            IsNull isn                 => IsNull(isn),
                            IsTrue isn                 => UnaryOperator(CqlOperator.IsTrue, isn),
                            Last last                  => Last(last),
                            LastPositionOf lpo         => LastPositionOf(lpo),
                            Length len                 => Length(len),
                            Less less                  => BinaryOperator(CqlOperator.Less, less),
                            LessOrEqual lesse          => BinaryOperator(CqlOperator.LessOrEqual, lesse),
                            List list                  => List(list),
                            Literal lit                => Literal(lit),
                            Ln ln                      => UnaryOperator(CqlOperator.Ln, ln),
                            Log log                    => BinaryOperator(CqlOperator.Log, log),
                            LowBoundary lb             => BinaryOperator(CqlOperator.LowBoundary, lb),
                            Lower e                    => UnaryOperator(CqlOperator.Lower, e),
                            Matches e                  => BinaryOperator(CqlOperator.Matches, e),
                            Max max                    => Max(max),
                            MaxValue max               => MaxValue(max),
                            Median med                 => Median(med),
                            Meets meets                => Meets(meets),
                            MeetsBefore meets          => MeetsBefore(meets),
                            MeetsAfter meets           => MeetsAfter(meets),
                            Message msg                => Message(msg),
                            Min min                    => Min(min),
                            MinValue min               => MinValue(min),
                            Mode mode                  => Mode(mode),
                            Modulo mod                 => BinaryOperator(CqlOperator.Modulo, mod),
                            Multiply mul               => BinaryOperator(CqlOperator.Multiply, mul),
                            Negate neg                 => neg.operand is
                                                              Elm.Literal literal
                                                              ? NegateLiteral(neg, literal)
                                                              : UnaryOperator(CqlOperator.Negate, neg),
                            Not not                    => UnaryOperator(CqlOperator.Not, not),
                            NotEqual ne                => NotEqual(ne),
                            Now now                    => Now(now),
                            Null @null                 => Null(@null),
                            OperandRef ore             => OperandRef(ore),
                            Or or                      => BinaryOperator(CqlOperator.Or, or), // https://cql.hl7.org/09-b-cqlreference.html#or
                            Overlaps ole               => Overlaps(ole),
                            OverlapsAfter ola          => OverlapsAfter(ola),
                            OverlapsBefore olb         => OverlapsBefore(olb),
                            ParameterRef pre           => ParameterRef(pre),
                            PointFrom pf               => UnaryOperator(CqlOperator.PointFrom, pf),
                            PopulationStdDev pstd      => PopulationStdDev(pstd),
                            PopulationVariance pvar    => PopulationVariance(pvar),
                            PositionOf po              => PositionOf(po),
                            Power pow                  => BinaryOperator(CqlOperator.Pow, pow),
                            Precision pre              => UnaryOperator(CqlOperator.Precision, pre),
                            Predecessor prd            => UnaryOperator(CqlOperator.Predecessor, prd),
                            Product prod               => Product(prod),
                            ProperContains pc          => ProperContains(pc),
                            ProperIn pi                => ProperIn(pi),
                            ProperIncludes pi          => ProperIncludes(pi),
                            ProperIncludedIn pie       => ProperIncludedIn(pie),
                            Property pe                => Property(pe),
                            Quantity qua               => Quantity(qua),
                            Query qe                   => Query(qe),
                            QueryLetRef qlre           => QueryLetRef(qlre),
                            Ratio re                   => Ratio(re),
                            ReplaceMatches e           => ReplaceMatches(e),
                            Retrieve re                => Retrieve(re),
                            Round rnd                  => Round(rnd),
                            SameAs sa                  => SameAs(sa),
                            SameOrAfter soa            => SameOrAfter(soa),
                            SameOrBefore sob           => SameOrBefore(sob),
                            SingletonFrom sf           => UnaryOperator(CqlOperator.Single, sf),
                            Slice slice                => Slice(slice),
                            Split split                => Split(split),
                            Substring e                => Substring(e),
                            Subtract sub               => BinaryOperator(CqlOperator.Subtract, sub),
                            Successor suc              => UnaryOperator(CqlOperator.Successor, suc),
                            Sum sum                    => Sum(sum),
                            Starts starts              => Starts(starts),
                            Start start                => UnaryOperator(CqlOperator.IntervalStart, start),
                            StartsWith e               => BinaryOperator(CqlOperator.StartsWith, e),
                            StdDev stddev              => StdDev(stddev),
                            Time time                  => Time(time),
                            TimeOfDay tod              => BindCqlOperator(CqlOperator.TimeOfDay),
                            TimezoneOffsetFrom tofe    => UnaryOperator(CqlOperator.TimeZoneComponent, tofe),
                            ToBoolean e                => ToBoolean(e),
                            ToConcept tc               => ToConcept(tc),
                            ToDateTime tdte            => ToDateTime(tdte),
                            ToDate tde                 => ToDate(tde),
                            Today today                => BindCqlOperator(CqlOperator.Today),
                            ToDecimal tde              => ToDecimal(tde),
                            ToInteger tde              => ToInteger(tde),
                            ToList tle                 => ToList(tle),
                            ToLong toLong              => ToLong(toLong),
                            ToQuantity tq              => ToQuantity(tq),
                            ToString e                 => ToString(e),
                            ToTime e                   => ToTime(e),
                            Truncate trunc             => UnaryOperator(CqlOperator.Truncate, trunc),
                            TruncatedDivide div        => BinaryOperator(CqlOperator.TruncatedDivide, div),
                            Elm.Tuple tu               => Tuple(tu),
                            Union ue                   => Union(ue),
                            ValueSetRef vsre           => ValueSetRef(vsre),
                            Variance variance          => Variance(variance),
                            Upper e                    => UnaryOperator(CqlOperator.Upper, e),
                            Width width                => UnaryOperator(CqlOperator.Width, width),
                            Xor xor                    => BinaryOperator(CqlOperator.Xor, xor),
                            _                          => throw this.NewExpressionBuildingException($"Expression {op.GetType().FullName} is not implemented.")
                            //@formatter:om
                        };
                        expression = Mutate(op, expression);
                        return expression!;
                    }
                });

        protected Expression BindCqlOperator(CqlOperator @operator, params Expression[] parameters)
            => BindCqlOperator(@operator, parameters);

        protected Expression BinaryOperator(CqlOperator @operator, Elm.BinaryExpression be)
        {
            var lhsExpression = TranslateExpression(be.operand![0]);
            var rhsExpression = TranslateExpression(be.operand![1]);
            var call = BindCqlOperator(@operator, lhsExpression, rhsExpression);
            return call;
        }

        protected Expression UnaryOperator(CqlOperator @operator, Elm.UnaryExpression unary)
        {
            var operand = TranslateExpression(unary.operand!);
            var resultType = unary.resultTypeSpecifier != null
                ? TypeFor(unary.resultTypeSpecifier)
                : null;
            var call = BindCqlOperator(@operator, operand);
            if (resultType != null && resultType != call.Type)
            {
                var typeAs = ChangeType(call, resultType);
                return typeAs;
            }
            else
            {
                return call;
            }
        }

        protected Expression NaryOperator(CqlOperator @operator, NaryExpression ne)
        {
            var operators = ne.operand
                .Select(op => TranslateExpression(op))
                .ToArray();
            var call = BindCqlOperator(@operator, operators);
            return call;
        }

        protected ConstantExpression Precision(DateTimePrecision elmPrecision, bool precisionSpecified)
        {
            if (precisionSpecified)
            {
                var name = Enum.GetName(elmPrecision)!.ToLowerInvariant();
                var ce = Expression.Constant(name, typeof(string));
                return ce;
            }
            else
            {
                var ce = Expression.Constant(null, typeof(string));
                return ce;
            }
        }

        protected Expression AggregateOperator(CqlOperator @operator, AggregateExpression aggregate)
        {
            var operand = TranslateExpression(aggregate.source!);
            var call = BindCqlOperator(@operator, operand);
            return call;
        }

        protected Expression? IdentifierRef(IdentifierRef ire)
        {
            if (string.Equals("$this", ire.name) && _impliedAlias != null)
            {
                var scopeExpression = GetScopeExpression(_impliedAlias!);
                return scopeExpression;
            }
            var pe = new Property
            {
                resultTypeSpecifier = ire.resultTypeSpecifier,
                resultTypeName = ire.resultTypeName,
                localId = ire.localId,
                locator = ire.locator,
                path = ire.name,
                scope = _impliedAlias!,
            };
            var prop = Property(pe);
            return prop;
        }


        protected bool IsOrImplementsIEnumerableOfT(Type type) => _typeManager.Resolver.ImplementsGenericInterface(type, typeof(IEnumerable<>));

        protected Type? GetListElementType(Type type) => _typeManager.Resolver.GetListElementType(type);

        protected Expression ValueSetRef(ValueSetRef valueSetRef)
        {
            if (string.IsNullOrWhiteSpace(valueSetRef.name))
                throw this.NewExpressionBuildingException($"The ValueSetRef at {valueSetRef.locator} is missing a name.");
            var type = TypeFor(valueSetRef)!;
            var cqlValueSet = InvokeDefinitionThroughRuntimeContext(valueSetRef.name, valueSetRef.libraryName, typeof(CqlValueSet));

            if (IsOrImplementsIEnumerableOfT(type))
            {
                var elementType = GetListElementType(type);
                if (elementType != typeof(CqlCode))
                {
                    throw this.NewExpressionBuildingException($"The expected type for value set {valueSetRef.name} in this context is {TypeManager.PrettyTypeName(type)}");
                }

                var @new = CallCreateValueSetFacade(cqlValueSet);
                return @new;
            }
            return cqlValueSet;
        }

        protected Expression QueryLetRef(QueryLetRef qlre)
        {
            var name = qlre.name!;
            var expr = GetScopeExpression(name);
            return expr;
        }

        protected Expression AliasRef(AliasRef ar)
        {
            var expr = GetScopeExpression(ar.name!);
            return expr;
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
                var tupleTypeSpecifier = (tuple.resultTypeSpecifier as Elm.TupleTypeSpecifier) ?? throw this.NewExpressionBuildingException($"Tuple expression has a resultType that is not a TupleTypeSpecifier.");
                tupleType = TupleTypeFor(tupleTypeSpecifier);
            }

            var @new = Expression.New(tupleType);
            if (tuple.element?.Length > 0)
            {
                var elementBindings = (tuple.element!)
                               .Select(element =>
                               {
                                   var value = TranslateExpression(element.value!);
                                   var propInfo = GetProperty(tupleType, NormalizeIdentifier(element.name!)!, _typeManager.Resolver)
                                                    ?? throw this.NewExpressionBuildingException($"Could not find member {element} on type {TypeManager.PrettyTypeName(tupleType!)}");
                                   var binding = Binding(value, propInfo);
                                   return binding;
                               })
                               .ToArray();
                var init = Expression.MemberInit(@new, elementBindings);
                return init;
            }
            else return @new;
        }

        protected Expression List(List list)
        {
            if (list.resultTypeSpecifier == null)
                throw this.NewExpressionBuildingException($"List is missing a result type specifier.");
            if (list.resultTypeSpecifier is Elm.ListTypeSpecifier listTypeSpecifier)
            {

                var elementType = TypeFor(listTypeSpecifier.elementType);
                var elements = list.element?
                    .Select(ele => TranslateExpression(ele))
                    .ToArray() ?? new Expression[0];
                if (!elementType.IsNullable() && elements.Any(exp => exp.Type.IsNullable()))
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
                        elements[i] = Expression.TypeAs(elements[i], elementType);
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
                var asEnumerable = Expression.TypeAs(array, typeof(IEnumerable<>).MakeGenericType(elementType));
                return asEnumerable;
            }
            else
                throw this.NewExpressionBuildingException($"List is the wrong type");

        }

        protected Expression CodeRef(CodeRef codeRef)
        {
            if (string.IsNullOrWhiteSpace(codeRef.name))
                throw this.NewExpressionBuildingException("The code ref has no name.");

            var type = _typeManager.Resolver.ResolveType(codeRef.resultTypeName.Name) ?? throw this.NewExpressionBuildingException($"Unable to resolve type {codeRef.resultTypeName}");
            return InvokeDefinitionThroughRuntimeContext(codeRef.name, codeRef.libraryName, type!);
        }

        private Expression CodeSystemRef(CodeSystemRef codeSystemRef)
        {
            if (string.IsNullOrWhiteSpace(codeSystemRef.name))
                throw this.NewExpressionBuildingException("The code system ref has no name.");

            var type = _typeManager.Resolver.CodeType.MakeArrayType();
            return InvokeDefinitionThroughRuntimeContext(codeSystemRef.name, codeSystemRef.libraryName, type!);
        }
        protected Expression ConceptRef(ConceptRef conceptRef)
        {
            if (string.IsNullOrWhiteSpace(conceptRef.name))
                throw this.NewExpressionBuildingException("The concept ref has no name.");

            var type = _typeManager.Resolver.CodeType.MakeArrayType();
            return InvokeDefinitionThroughRuntimeContext(conceptRef.name, conceptRef.libraryName, type!);
        }

        protected Expression Instance(Instance ine)
        {
            var instanceType = _typeManager.Resolver.ResolveType(ine.classType.Name!)
                               ?? throw this.NewExpressionBuildingException($"Could not resolve type for '{ine.classType.Name!}'");

            if (IsEnum(instanceType))
            {
                // constructs like:
                // FHIR.RemittanceOutcome {value: 'complete'}
                // FHIR.RemittanceOutcome maps to an enum type
                if (ine.element?.Length == 1 && string.Equals(ine.element![0].name, "value", StringComparison.OrdinalIgnoreCase))
                {
                    var enumValueValue = TranslateExpression(ine.element[0]!.value!);
                    if (enumValueValue.Type == instanceType)
                        return enumValueValue;
                    else if (enumValueValue.Type == typeof(string))
                    {
                        var parseMethod = typeof(Enum).GetMethods()
                            .Where(m =>
                                m.Name == nameof(Enum.Parse)
                                && m.GetParameters().Length == 3)
                            .Single();
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

            var tuples = ine.element!
                .Select(el => (el.name!, TranslateExpression(el.value!)))
                .ToArray();

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
            else if (instanceType == typeof(CqlQuantity))
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
            else if (instanceType == typeof(CqlCode))
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
            else if (instanceType == typeof(CqlConcept))
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
                    var memberInfo = GetProperty(instanceType!, element, _typeManager.Resolver) ?? throw this.NewExpressionBuildingException($"Could not find member {element} on type {TypeManager.PrettyTypeName(instanceType!)}");
                    var binding = Binding(expression, memberInfo);
                    elementBindings[i] = binding;
                }
                var ctor = instanceType!.GetConstructor(Type.EmptyTypes)!;
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
                else if (property.PropertyType.IsArray)
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
                        var valueEnumerableElement = _typeManager.Resolver.GetListElementType(value.Type) ?? throw this.NewExpressionBuildingException(message);
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
                            var callSelectMethod = BindCqlOperator(CqlOperator.Select, value, selectLambda);
                            var toArrayMethod = typeof(Enumerable)
                                .GetMethod(nameof(Enumerable.ToArray))!
                                .MakeGenericMethod(memberArrayElement);
                            var callToArray = Expression.Call(toArrayMethod, callSelectMethod);
                            return Expression.Bind(memberInfo, callToArray);
                        }
                    }
                }
                else if (_typeManager.Resolver.ImplementsGenericInterface(property.PropertyType, typeof(ICollection<>)))
                {
                    if (IsOrImplementsIEnumerableOfT(value.Type))
                    {
                        var elementType = _typeManager.Resolver.GetListElementType(property.PropertyType)!;
                        var ctor = ConstructorInfos.ListOf(elementType);
                        var newList = Expression.New(ctor, value);
                        return Expression.Bind(memberInfo, newList);
                    }
                }
                var convert = ChangeType(value, property.PropertyType);
                return Expression.Bind(memberInfo, convert);
            }
            else throw new NotImplementedException().WithContext(this);
        }

        protected bool IsConvertible(Type from, Type to)
        {
            if (from == to)
                return true;
            if (to.IsAssignableFrom(from))
                return true;
            if (from.IsNullable() && !to.IsNullable())
                return true;
            if (IsOrImplementsIEnumerableOfT(from) && IsOrImplementsIEnumerableOfT(to))
            {
                var fromElement = _typeManager.Resolver.GetListElementType(from, throwError: true)!;
                var toElement = _typeManager.Resolver.GetListElementType(to, throwError: true)!;
                return IsConvertible(fromElement, toElement);
            }
            return false;
        }

        protected Expression If(If @if)
        {
            var rc = TranslateExpression(@if.condition!);
            var condition = Expression.Coalesce(rc, Expression.Constant(false, typeof(bool)));
            var then = TranslateExpression(@if.then!);
            if (@if.@else != null)
            {
                var @else = TranslateExpression(@if.@else!);
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
            else
            {
                var ifThen = Expression.Condition(condition, then, Expression.Convert(Expression.Constant(null), then.Type));
                return ifThen;
            }
        }

        protected Expression Null(Null @null)
        {
            var nullType = TypeFor(@null) ?? typeof(object);
            var constant = Expression.Constant(null, nullType);
            return constant;
        }

        protected Expression Literal(Literal lit)
        {
            string message = $"Cannot resolve type for {lit.valueType}";
            var type = _typeManager.Resolver.ResolveType(lit.valueType.Name!) ?? throw this.NewExpressionBuildingException(message);
            var (value, convertedType) = ConvertLiteral(lit, type);

            if (type.IsNullable())
            {
                var changed = Expression.Constant(value, convertedType);
                var asNullable = Expression.Convert(changed, type);
                return asNullable;
            }
            return Expression.Constant(value, convertedType);
        }

        public (object?, Type) ConvertLiteral(Literal lit, Type? type)
        {
            if (type == null)
                throw new NotImplementedException().WithContext(this);
            else if (type.IsNullable())
            {
                if (string.IsNullOrWhiteSpace(lit.value))
                    return (null, type);
                else
                {
                    var underlyingType = Nullable.GetUnderlyingType(type);
                    if (typeof(IConvertible).IsAssignableFrom(underlyingType))
                    {
                        try
                        {
                            var converted = System.Convert.ChangeType(lit.value, underlyingType, CultureInfo.InvariantCulture);
                            return (converted, underlyingType);
                        }
                        catch (OverflowException)
                        {
                            return (null, type);
                        }
                    }
                    else throw new NotSupportedException("Only convertible types can be used for literals.");
                }
            }
            else
            {
                if (type == typeof(string))
                    return (lit.value, type);
                if (typeof(IConvertible).IsAssignableFrom(type!))
                {
                    var converted = System.Convert.ChangeType(lit.value, type, CultureInfo.InvariantCulture);
                    return (converted, type);
                }
                else throw new NotSupportedException("Only convertible types can be used for literals.");
            }
        }

        protected Expression OperandRef(OperandRef ore)
        {
            if (_operands.TryGetValue(ore.name!, out var expression))
                return expression;
            else throw this.NewExpressionBuildingException($"Operand reference to {ore.name} not found in definition operands.");
        }

        protected Expression Case(Case ce)
        {
            //[{ when1, then1 }, { when2, then2}, { when3, then3 }]
            // when1 ? then 1 : (when2 ? then 2 : (when3 ? then 3 : else }
            if (ce.caseItem?.Length > 0 && ce.@else != null)
            {
                var elseThen = TranslateExpression(ce.@else!);
                var cases = new List<CaseWhenThenExpression.WhenThenCase>();

                if (ce.comparand != null)
                {
                    var comparand = TranslateExpression(ce.comparand);

                    foreach (var caseItem in ce.caseItem)
                    {
                        var caseWhen = TranslateExpression(caseItem.when!);
                        var caseWhenEquality = Expression.Coalesce(Equal(comparand, caseWhen), Expression.Constant(false));
                        var caseThen = TranslateExpression(caseItem.then!);

                        if (caseThen.Type != elseThen.Type)
                            caseThen = Expression.Convert(caseThen, elseThen.Type);

                        cases.Add(new(caseWhenEquality, caseThen));
                    }
                }
                else
                {
                    foreach (var caseItem in ce.caseItem)
                    {
                        var caseWhen = TranslateExpression(caseItem.when!);
                        var caseThen = TranslateExpression(caseItem.then!);

                        if (caseThen.Type != elseThen.Type)
                            caseThen = Expression.Convert(caseThen, elseThen.Type);

                        if (caseWhen.Type.IsNullable())
                        {
                            caseWhen = Expression.Coalesce(caseWhen, Expression.Constant(false));
                        }

                        cases.Add(new(caseWhen, caseThen));
                    }
                }

                return new CaseWhenThenExpression(cases, elseThen);
            }

            else throw this.NewExpressionBuildingException("Invalid case expression.  At least 1 case and an else must be present.");
        }

        protected bool IsInterval(Type t, out Type? elementType)
        {
            if (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(CqlInterval<>))
            {
                elementType = t.GetGenericArguments()[0];
                return true;
            }
            elementType = null;
            return false;
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

                sourceElementType = _typeManager.Resolver.ResolveType(cqlRetrieveResultType);
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
                var codePropertyInfo = _typeManager.Resolver.GetProperty(sourceElementType!, retrieve.codeProperty!);
                codeProperty = Expression.Constant(codePropertyInfo, typeof(PropertyInfo));
            }
            else
            {
                codeProperty = Expression.Constant(null, typeof(PropertyInfo));
            }

            if (retrieve.codes != null)
            {
                if (retrieve.codes is ValueSetRef valueSetRef)
                {
                    if (string.IsNullOrWhiteSpace(valueSetRef.name))
                        throw this.NewExpressionBuildingException($"The ValueSetRef at {valueSetRef.locator} is missing a name.");
                    var valueSet = InvokeDefinitionThroughRuntimeContext(valueSetRef.name!, valueSetRef.libraryName, typeof(CqlValueSet));
                    var call = BindCqlOperator(CqlOperator.Retrieve, LibraryDefinitionsBuilder.ContextParameter,
                        Expression.Constant(sourceElementType, typeof(Type)), valueSet, codeProperty!);
                    return call;
                }
                else
                {
                    // In this construct, instead of querying a value set, we're testing resources
                    // against a list of codes, e.g., as defined by the code from or codesystem construct
                    var codes = TranslateExpression(retrieve.codes);
                    var call = BindCqlOperator(CqlOperator.Retrieve, LibraryDefinitionsBuilder.ContextParameter,
                        Expression.Constant(sourceElementType, typeof(Type)), codes, codeProperty!);
                    return call;
                }
            }
            else
            {
                var call = BindCqlOperator(CqlOperator.Retrieve, LibraryDefinitionsBuilder.ContextParameter,
                    Expression.Constant(sourceElementType, typeof(Type)), Expression.Constant(null, typeof(CqlValueSet)), codeProperty!);
                return call;
            }
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
                    var pathMemberInfo = _typeManager.Resolver.GetProperty(scopeExpression.Type, path!) ??
                        _typeManager.Resolver.GetProperty(scopeExpression.Type, op.path);
                    if (pathMemberInfo == null)
                    {
                        _logger.LogWarning(FormatMessage($"Property {op.path} can't be known at design time, and will be late-bound, slowing performance.  Consider casting the source first so that this property can be definitely bound.", op));
                        var call = BindCqlOperator(CqlOperator.LateBoundProperty, LibraryDefinitionsBuilder.ContextParameter,
                            scopeExpression, Expression.Constant(op.path, typeof(string)), Expression.Constant(expectedType, typeof(Type)));
                        return call;
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
                else if (op.source != null)
                {
                    var source = TranslateExpression(op.source);
                    var parts = path.Split('.');
                    if (parts.Length > 1)
                    {
                        // support paths like birthDate.value on Patient
                        for (int i = 0; i < parts.Length; i++)
                        {
                            var pathPart = parts[i];
                            var pathMemberInfo = _typeManager.Resolver.GetProperty(source.Type, pathPart!);
                            if (pathMemberInfo != null)
                            {
                                var propertyAccess = PropagateNull(source, pathMemberInfo);
                                source = propertyAccess;
                            }
                        }
                        return source;
                    }
                    else
                    {
                        var expectedType = TypeFor(op, throwIfNotFound: false);

                        // If we cannot determine the type from the ELM, let's try
                        // if the POCO model can help us.
                        if(expectedType == null)
                        {
                            expectedType = _typeManager.Resolver.GetProperty(source.Type, path)?.PropertyType
                                ?? throw this.NewExpressionBuildingException("Cannot resolve type for expression");
                        }

                        var result = PropertyHelper(source, path, expectedType);
                        return result;
                    }
                }
                else throw new NotImplementedException().WithContext(this);
            }
        }

        protected Expression PropertyHelper(Expression source, string? path, Type expectedType)
        {
            Expression? result = null;
            if (_typeManager.Resolver.ShouldUseSourceObject(source.Type, path!))
            {
                result = source;
            }
            else
            {
                var pathMemberInfo = _typeManager.Resolver.GetProperty(source.Type, path!);
                if (pathMemberInfo == null)
                {
                    _logger.LogWarning(FormatMessage($"Property {path} can't be known at design time, and will be late-bound, slowing performance.  Consider casting the source first so that this property can be definitely bound."));
                    var call = BindCqlOperator(CqlOperator.LateBoundProperty, LibraryDefinitionsBuilder.ContextParameter,
                        source, Expression.Constant(path, typeof(string)), Expression.Constant(expectedType, typeof(Type)));
                    return call;
                }
                if (pathMemberInfo is PropertyInfo property && pathMemberInfo.DeclaringType != source.Type) // the property is on a derived type, so cast it
                {
                    var isCheck = Expression.TypeIs(source, pathMemberInfo.DeclaringType!);
                    var typeAs = Expression.TypeAs(source, pathMemberInfo.DeclaringType!);
                    var pathAccess = Expression.MakeMemberAccess(typeAs, pathMemberInfo);
                    Expression? ifIs = pathAccess;
                    Expression elseNull = Expression.Constant(null, property.PropertyType);
                    // some ops, like properties on alias refs, don't have type information on them.
                    // can't check against what we don't have.
                    if (expectedType != null)
                    {
                        if (expectedType != ifIs.Type)
                        {
                            ifIs = ChangeType(ifIs, expectedType!);
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
                    if (IsEnum(result.Type))
                        return result;
                }
                result = ChangeType(result, expectedType);
            }
            return result;
        }

        protected Expression FunctionRef(FunctionRef op)
        {
            var operands = op.operand
                .Select(TranslateExpression)
                .ToArray();

            // FHIRHelpers has special handling in CQL-to-ELM and does not translate correctly - specifically,
            // it interprets ToString(value string) oddly.  Normally when string is used in CQL it is resolved to the elm type.
            // In FHIRHelpers, this string gets treated as a FHIR string, which is normally mapped to a StringElement abstraction.
            if (op.libraryName is { } alias)
            {
                string libraryName = LibraryContext.GetNameAndVersionFromAlias(alias, throwError: true)!;
                if (libraryName.StartsWith("fhirhelpers", StringComparison.OrdinalIgnoreCase)
                    && op.name!.Equals("tostring", StringComparison.OrdinalIgnoreCase))
                {
                    if (operands[0].Type == typeof(string))
                    {
                        return operands[0];
                    }

                    var bind = BindCqlOperator(
                        CqlOperator.Convert,
                        operands[0],
                        Expression.Constant(typeof(string), typeof(Type)));
                    return bind;
                }
            }

            var invoke = InvokeDefinedFunctionThroughRuntimeContext(op.name!, op.libraryName!, operands);
            return invoke;
        }

        protected Type GetFuncType(Type[] funcTypeParameters)
        {
            Type? funcType;
            switch (funcTypeParameters.Length)
            {
                case 0:
                    throw new NotSupportedException();
                case 1:
                    funcType = typeof(Func<>).MakeGenericType(funcTypeParameters);
                    break;
                case 2:
                    funcType = typeof(Func<,>).MakeGenericType(funcTypeParameters);
                    break;
                case 3:
                    funcType = typeof(Func<,,>).MakeGenericType(funcTypeParameters);
                    break;
                case 4:
                    funcType = typeof(Func<,,,>).MakeGenericType(funcTypeParameters);
                    break;
                case 5:
                    funcType = typeof(Func<,,,,>).MakeGenericType(funcTypeParameters);
                    break;
                case 6:
                    funcType = typeof(Func<,,,,,>).MakeGenericType(funcTypeParameters);
                    break;
                case 7:
                    funcType = typeof(Func<,,,,,,>).MakeGenericType(funcTypeParameters);
                    break;
                case 8:
                    funcType = typeof(Func<,,,,,,,>).MakeGenericType(funcTypeParameters);
                    break;
                case 9:
                    funcType = typeof(Func<,,,,,,,,>).MakeGenericType(funcTypeParameters);
                    break;
                case 10:
                    funcType = typeof(Func<,,,,,,,,,>).MakeGenericType(funcTypeParameters);
                    break;
                case 11:
                    funcType = typeof(Func<,,,,,,,,,,>).MakeGenericType(funcTypeParameters);
                    break;
                case 12:
                    funcType = typeof(Func<,,,,,,,,,,,>).MakeGenericType(funcTypeParameters);
                    break;
                case 13:
                    funcType = typeof(Func<,,,,,,,,,,,,>).MakeGenericType(funcTypeParameters);
                    break;
                case 14:
                    funcType = typeof(Func<,,,,,,,,,,,,,>).MakeGenericType(funcTypeParameters);
                    break;
                case 15:
                    funcType = typeof(Func<,,,,,,,,,,,,,,>).MakeGenericType(funcTypeParameters);
                    break;
                default:
                    throw new NotSupportedException("Functions with more than 15 parameters are not supported.");
            }
            return funcType;
        }

        protected Type GetFunctionRefReturnType(FunctionRef op, IEnumerable<Type> operandTypes)
        {
            // Try determining the return type from the resultTypeSpecifier or resultTypeName
            if (op.resultTypeSpecifier != null)
            {
                string message = $"Cannot resolve result type {op.resultTypeSpecifier}.";
                return TypeFor(op.resultTypeSpecifier) ?? throw this.NewExpressionBuildingException(message);
            }

            if (!string.IsNullOrWhiteSpace(op.resultTypeName?.Name))
            {
                return _typeManager.Resolver.ResolveType(op.resultTypeName.Name!)
                    ?? throw this.NewExpressionBuildingException($"Cannot determine type for function {op.libraryName ?? ""}.{op.name}");
            }

            if (op.libraryName is { } libraryAlias)
            {
                var libraryKey = LibraryContext.GetNameAndVersionFromAlias(libraryAlias);
                if (!LibraryContext.LibraryDefinitions.TryGetValue(libraryKey, op.name, operandTypes.ToArray(), out var definition))
                    throw this.NewExpressionBuildingException($"Cannot resolve a library definition for function {op.libraryName ?? ""}.{op.name}");

                return definition.ReturnType;
            }

            // We failed....
            throw this.NewExpressionBuildingException($"Cannot determine type for function {op.libraryName ?? ""}.{op.name}");
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
                    expressionType = _typeManager.Resolver.ResolveType(expressionRef.resultTypeName.Name!);
                }
                else
                {
                    var def = LibraryContext.Library.statements?.SingleOrDefault(d => d.name == expressionRef.name);
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
            if (LibraryContext.LibraryDefinitions.TryGetValue(LibraryContext.LibraryKey, op.name!, out var lambda) && lambda != null)
            {
                var invoke = InvokeDefinitionThroughRuntimeContext(op.name!, null, lambda);
                return invoke;
            }

            throw this.NewExpressionBuildingException($"Parameter {op.name} hasn't been defined yet.");
        }

        protected internal static PropertyInfo? GetProperty(Type type, string name, TypeResolver typeResolver)
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

        /// <param name="name">The function name</param>
        /// <param name="libraryAlias">If this is an external call, the local alias defined in the using statement</param>
        /// <param name="arguments">The function arguments</param>
        /// <returns></returns>
        protected Expression InvokeDefinedFunctionThroughRuntimeContext(
            string name,
            string? libraryAlias,
            Expression[] arguments)
        {

            var definitionsProperty = Expression.Property(LibraryDefinitionsBuilder.ContextParameter, typeof(CqlContext).GetProperty(nameof(CqlContext.Definitions))!);

            string libraryName = LibraryContext.GetNameAndVersionFromAlias(libraryAlias, throwError: false)
                ?? throw this.NewExpressionBuildingException($"Local library {libraryAlias} is not defined; are you missing a using statement?");

            var argumentTypes = arguments.Select(a => a.Type).ToArray();
            var selected = LibraryContext.LibraryDefinitions.Resolve(libraryName, name, CheckConversion, argumentTypes);
            Type definitionType = GetFuncType(selected.Parameters.Select(p => p.Type).Append(selected.ReturnType).ToArray());
            var parameterTypes = selected.Parameters.Skip(1).Select(p => p.Type).ToArray();

            // all functions still take the bundle and context parameters, plus whatver the operands
            // to the actual function are.
            var convertedArguments = arguments
                .Select((arg, i) => ChangeType(arg, parameterTypes[i]))
                .Prepend(LibraryDefinitionsBuilder.ContextParameter)
                .ToArray();

            return new FunctionCallExpression(definitionsProperty, libraryName, name, convertedArguments, definitionType);

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
            else throw this.NewExpressionBuildingException("LambdaExpressions should be a variant of Func<>");
        }

        protected Expression InvokeDefinitionThroughRuntimeContext(
            string name,
            string? libraryAlias,
            Type definitionReturnType)
        {
            var definitionsProperty = Expression.Property(LibraryDefinitionsBuilder.ContextParameter, typeof(CqlContext).GetProperty(nameof(CqlContext.Definitions))!);

            string libraryName = LibraryContext.GetNameAndVersionFromAlias(libraryAlias, throwError: false)
                                  ?? throw this.NewExpressionBuildingException($"Local library {libraryAlias} is not defined; are you missing a using statement?");

            var funcType = typeof(Func<,>).MakeGenericType(typeof(CqlContext), definitionReturnType);
            return new DefinitionCallExpression(definitionsProperty, libraryName, name, LibraryDefinitionsBuilder.ContextParameter, funcType);
        }

        private static Expression HandleNullable(Expression expression, Type targetType) =>
            (
                exprNullTypeArg: Nullable.GetUnderlyingType(expression.Type),
                targetNullTypeArg: Nullable.GetUnderlyingType(targetType)) switch
            {
                // Only targetType is nullable
                (exprNullTypeArg: null, targetNullTypeArg: not null) => Expression.Convert(expression, targetType),

                // Both are nullable or not nullable
                ({ } exprNullTypeArg, targetNullTypeArg: null) => Expression.Coalesce(expression, Expression.Default(exprNullTypeArg)),

                _ => expression,
            };

        /// <summary>
        /// Implements the null propagation operator (x?.y) into (x == null ? null : x.y);
        /// </summary>
        private static Expression PropagateNull(Expression before, MemberInfo member)
        {
            if (before.Type.IsValueType)
                return before;
            else
            {
                return new NullConditionalMemberExpression(before, member);
            }
        }

        internal static string TypeNameToIdentifier(Type type, ExpressionBuilder? ctx)
        {
            var typeName = type.Name.ToLowerInvariant();
            if (type.IsGenericType)
            {
                var genericTypeNames = string.Join("_", type.GetGenericArguments().Select(t => TypeNameToIdentifier(t, ctx)));
                var tick = typeName.IndexOf('`');
                if (tick > -1)
                    typeName = typeName[..tick];
                var fullName = $"{typeName}_{genericTypeNames}";
                typeName = fullName;
            }

            if (ctx != null)
            {
                int i = 1;
                var uniqueTypeName = typeName;
                while (ctx.HasScope(uniqueTypeName))
                {
                    uniqueTypeName = $"{typeName}{i}";
                    i++;
                }
                typeName = uniqueTypeName;
            }

            return NormalizeIdentifier(typeName!)!;
        }

        private static bool IsEnum(Type type)
        {
            if (type.IsEnum)
                return true;
            else if (type.IsNullable() && (Nullable.GetUnderlyingType(type)?.IsEnum ?? false))
                return true;
            return false;
        }

        internal MethodCallExpression CallCreateValueSetFacade(Expression operand)
        {
            var operatorsProperty = typeof(CqlContext).GetProperty(nameof(CqlContext.Operators))!;
            var createFacadeMethod = typeof(ICqlOperators).GetMethod(nameof(ICqlOperators.CreateValueSetFacade))!;
            var property = Expression.Property(LibraryDefinitionsBuilder.ContextParameter, operatorsProperty);
            var call = Expression.Call(property, createFacadeMethod, operand);

            return call;
        }
    }
}