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
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Operators;
using elm = Hl7.Cql.Elm;
using Expression = System.Linq.Expressions.Expression;

using ExpressionElementPairForIdentifier = System.Collections.Generic.KeyValuePair<string, (System.Linq.Expressions.Expression, Hl7.Cql.Elm.Element)>;

namespace Hl7.Cql.Compiler
{
    /// <summary>
    /// The ExpressionBuilder translates ELM <see cref="elm.Expression"/>s into <see cref="Expression"/>.
    /// </summary>
    internal partial class ExpressionBuilder
    {
        private readonly TypeManager _typeManager;
        private readonly ILoggerFactory _loggerFactory;


        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="typeManager">The <see cref="_typeManager"/> used to resolve and create types referenced.</param>
        /// <param name="loggerFactory">The <see cref="ILoggerFactory"/> used to log all messages issued.</param>
        /// <exception cref="ArgumentNullException">If any argument is <see langword="null"/></exception>
        public ExpressionBuilder(
            TypeManager typeManager,
            ILoggerFactory loggerFactory)
        {
            _typeManager = typeManager ?? throw new ArgumentNullException(nameof(typeManager));
            _loggerFactory = loggerFactory;
            Settings = new ExpressionBuilderSettings();
        }

        /// <summary>
        /// Gets the settings used while building expressions.
        /// </summary>
        public ExpressionBuilderSettings Settings { get; }

        /// <summary>
        /// Generates a lambda expression taking a <see cref="CqlContext"/> parameter whose body is
        /// <paramref name="expression"/> translated into a <see cref="Expression"/>.
        /// </summary>
        /// <remarks>
        /// This can be compiled to a <see cref="Delegate"/> and executed to resolve a value.
        /// </remarks>
        /// <param name="library">The containing ELM library</param>
        /// <param name="expression">The ELM expression to convert</param>
        /// <param name="operatorBinding">The <see cref="Compiler.OperatorBinding"/> used to invoke <see cref="CqlOperator"/>.</param>
        /// <param name="lambdas">Existing lambdas, required if <paramref name="expression"/> contains any references to other ELM definitions</param>
        public LambdaExpression Lambda(
            Library library,
            Elm.Expression expression,
            OperatorBinding operatorBinding,
            DefinitionDictionary<LambdaExpression>? lambdas = null)
        {
            var parameter = Expression.Parameter(typeof(CqlContext), "rtx");
            lambdas ??= new DefinitionDictionary<LambdaExpression>();
            var libraryExpressionsBuilderContext = new LibraryExpressionBuilderContext(library, Settings, operatorBinding, lambdas, _typeManager, _loggerFactory);
            var ctx = libraryExpressionsBuilderContext.NewExpressionBuilderContext(expression);
            var translated = ctx.TranslateExpression(expression);
            var lambda = Expression.Lambda(translated, parameter);
            return lambda;
        }
    }

    partial class ExpressionBuilderContext
    {
        // Yeah, hardwired to FHIR 4.0.1 for now.
        private static readonly IDictionary<string, ClassInfo> ModelMapping = Models.ClassesById(Models.Fhir401);

        private readonly ILogger<ExpressionBuilderContext> _logger = null!;

        internal Expression TranslateExpression(Element op)
        {
            ExpressionBuilderContext ctx = Push(op);
            Expression? expression;
            switch (op)
            {
                case Abs abs:
                    expression = ctx.Abs(abs);
                    break;
                case Add add:
                    expression = ctx.Add(add);
                    break;
                case After after:
                    expression = ctx.After(after);
                    break;
                case AliasRef ar:
                    expression = ctx.AliasRef(ar);
                    break;
                case AllTrue alt:
                    expression = ctx.AllTrue(alt);
                    break;
                case And and:
                    expression = ctx.And(and);
                    break;
                case As @as:
                    expression = ctx.As(@as);
                    break;
                case AnyTrue ate:
                    expression = ctx.AnyTrue(ate);
                    break;
                case AnyInValueSet avs:
                    expression = ctx.AnyInValueSet(avs);
                    break;
                case Avg avg:
                    expression = ctx.Avg(avg);
                    break;
                case Before before:
                    expression = ctx.Before(before);
                    break;
                case CalculateAgeAt caa:
                    expression = ctx.CalculateAgeAt(caa);
                    break;
                case CalculateAge ca:
                    expression = ctx.CalculateAge(ca);
                    break;
                case Case ce:
                    expression = ctx.Case(ce);
                    break;
                case Ceiling ceil:
                    expression = ctx.Ceiling(ceil);
                    break;
                case Coalesce cle:
                    expression = ctx.Coalesce(cle);
                    break;
                case CodeRef cre:
                    expression = ctx.CodeRef(cre);
                    break;
                case CodeSystemRef csr:
                    expression = ctx.CodeSystemRef(csr);
                    break;
                case Collapse col:
                    expression = ctx.Collapse(col);
                    break;
                case Combine com:
                    expression = ctx.Combine(com);
                    break;
                case Concatenate cctn:
                    expression = ctx.Concatenate(cctn);
                    break;
                case ConceptRef cr:
                    expression = ctx.ConceptRef(cr);
                    break;
                case Contains ct:
                    expression = ctx.Contains(ct);
                    break;
                case ConvertQuantity cqe:
                    expression = ctx.ConvertQuantity(cqe);
                    break;
                case ConvertsToBoolean ce:
                    expression = ctx.ConvertsToBoolean(ce);
                    break;
                case ConvertsToDate ce:
                    expression = ctx.ConvertsToDate(ce);
                    break;
                case ConvertsToDateTime ce:
                    expression = ctx.ConvertsToDateTime(ce);
                    break;
                case ConvertsToDecimal ce:
                    expression = ctx.ConvertsToDecimal(ce);
                    break;
                case ConvertsToLong ce:
                    expression = ctx.ConvertsToLong(ce);
                    break;
                case ConvertsToInteger ce:
                    expression = ctx.ConvertsToInteger(ce);
                    break;
                case ConvertsToQuantity ce:
                    expression = ctx.ConvertsToQuantity(ce);
                    break;
                case ConvertsToString ce:
                    expression = ctx.ConvertsToString(ce);
                    break;
                case ConvertsToTime ce:
                    expression = ctx.ConvertsToTime(ce);
                    break;
                case Count ce:
                    expression = ctx.Count(ce);
                    break;
                case DateFrom dfe:
                    expression = ctx.DateFrom(dfe);
                    break;
                case elm.DateTime dt:
                    expression = ctx.DateTime(dt);
                    break;
                case Date d:
                    expression = ctx.Date(d);
                    break;
                case DateTimeComponentFrom dtcf:
                    expression = ctx.DateTimeComponentFrom(dtcf);
                    break;
                case Descendents desc:
                    expression = ctx.Descendents(desc);
                    break;
                case DifferenceBetween dbe:
                    expression = ctx.DifferenceBetween(dbe);
                    break;
                case Distinct distinct:
                    expression = ctx.Distinct(distinct);
                    break;
                case Divide divide:
                    expression = ctx.Divide(divide);
                    break;
                case DurationBetween dbe:
                    expression = ctx.DurationBetween(dbe);
                    break;
                case End e:
                    expression = ctx.End(e);
                    break;
                case Ends e:
                    expression = ctx.Ends(e);
                    break;
                case EndsWith e:
                    expression = ctx.EndsWith(e);
                    break;
                case Equal eq:
                    expression = ctx.Equal(eq);
                    break;
                case Equivalent eqv:
                    expression = ctx.Equivalent(eqv);
                    break;
                case Except ex:
                    expression = ctx.Except(ex);
                    break;
                case Exists ex:
                    expression = ctx.Exists(ex);
                    break;
                case Exp exe:
                    expression = ctx.Exp(exe);
                    break;
                case Expand expand:
                    expression = ctx.Expand(expand);
                    break;
                case ExpandValueSet evs:
                    expression = ctx.ExpandValueSet(evs);
                    break;
                case FunctionRef fre:
                    expression = ctx.FunctionRef(fre);
                    break;
                case ExpressionRef ere:
                    expression = ctx.ExpressionRef(ere);
                    break;
                case First first:
                    expression = ctx.First(first);
                    break;
                case Flatten fl:
                    expression = ctx.Flatten(fl);
                    break;
                case Floor floor:
                    expression = ctx.Floor(floor);
                    break;
                case GeometricMean gme:
                    expression = ctx.GeometricMean(gme);
                    break;
                case Greater gtr:
                    expression = ctx.Greater(gtr);
                    break;
                case GreaterOrEqual gtre:
                    expression = ctx.GreaterOrEqual(gtre);
                    break;
                case HighBoundary hb:
                    expression = ctx.HighBoundary(hb);
                    break;
                case IdentifierRef ire:
                    expression = ctx.IdentifierRef(ire);
                    break;
                case If @if:
                    expression = ctx.If(@if);
                    break;
                case Implies implies:
                    expression = ctx.Implies(implies);
                    break;
                case Includes inc:
                    expression = ctx.Includes(inc);
                    break;
                case IncludedIn ii:
                    expression = ctx.IncludedIn(ii);
                    break;
                case Indexer idx:
                    expression = ctx.Indexer(idx);
                    break;
                case IndexOf io:
                    expression = ctx.IndexOf(io);
                    break;
                case Instance ine:
                    expression = ctx.Instance(ine);
                    break;
                case Intersect ise:
                    expression = ctx.Intersect(ise);
                    break;
                case Interval ie:
                    expression = ctx.IntervalExpression(ie);
                    break;
                case InValueSet inv:
                    expression = ctx.InValueSet(inv);
                    break;
                case In @in:
                    expression = ctx.In(@in);
                    break;
                case Is @is:
                    expression = ctx.Is(@is);
                    break;
                case IsFalse isn:
                    expression = ctx.IsFalse(isn);
                    break;
                case IsNull isn:
                    expression = ctx.IsNull(isn);
                    break;
                case IsTrue isn:
                    expression = ctx.IsTrue(isn);
                    break;
                case Last last:
                    expression = ctx.Last(last);
                    break;
                case LastPositionOf lpo:
                    expression = ctx.LastPositionOf(lpo);
                    break;
                case Length len:
                    expression = ctx.Length(len);
                    break;
                case Less less:
                    expression = ctx.Less(less);
                    break;
                case LessOrEqual lesse:
                    expression = ctx.LessOrEqual(lesse);
                    break;
                case List list:
                    expression = ctx.List(list);
                    break;
                case Literal lit:
                    expression = ctx.Literal(lit);
                    break;
                case Ln ln:
                    expression = ctx.Ln(ln);
                    break;
                case Log log:
                    expression = ctx.Log(log);
                    break;
                case LowBoundary lb:
                    expression = ctx.LowBoundary(lb);
                    break;
                case Lower e:
                    expression = ctx.Lower(e);
                    break;
                case Matches e:
                    expression = ctx.Matches(e);
                    break;
                case Max max:
                    expression = ctx.Max(max);
                    break;
                case MaxValue max:
                    expression = ctx.MaxValue(max);
                    break;
                case Median med:
                    expression = ctx.Median(med);
                    break;
                case Meets meets:
                    expression = ctx.Meets(meets);
                    break;
                case MeetsBefore meets:
                    expression = ctx.MeetsBefore(meets);
                    break;
                case MeetsAfter meets:
                    expression = ctx.MeetsAfter(meets);
                    break;
                case Message msg:
                    expression = ctx.Message(msg);
                    break;
                case Min min:
                    expression = ctx.Min(min);
                    break;
                case MinValue min:
                    expression = ctx.MinValue(min);
                    break;
                case Mode mode:
                    expression = ctx.Mode(mode);
                    break;
                case Modulo mod:
                    expression = ctx.Modulo(mod);
                    break;
                case Multiply mul:
                    expression = ctx.Multiply(mul);
                    break;
                case Negate neg:
                    expression = ctx.Negate(neg);
                    break;
                case Not not:
                    expression = ctx.Not(not);
                    break;
                case NotEqual ne:
                    expression = ctx.NotEqual(ne);
                    break;
                case Now now:
                    expression = ctx.Now(now);
                    break;
                case Null @null:
                    expression = ctx.Null(@null);
                    break;
                case OperandRef ore:
                    expression = ctx.OperandRef(ore);
                    break;
                case Or or:
                    expression = ctx.Or(or);
                    break;
                case Overlaps ole:
                    expression = ctx.Overlaps(ole);
                    break;
                case OverlapsAfter ola:
                    expression = ctx.OverlapsAfter(ola);
                    break;
                case OverlapsBefore olb:
                    expression = ctx.OverlapsBefore(olb);
                    break;
                case ParameterRef pre:
                    expression = ctx.ParameterRef(pre);
                    break;
                case PointFrom pf:
                    expression = ctx.PointFrom(pf);
                    break;
                case PopulationStdDev pstd:
                    expression = ctx.PopulationStdDev(pstd);
                    break;
                case PopulationVariance pvar:
                    expression = ctx.PopulationVariance(pvar);
                    break;
                case PositionOf po:
                    expression = ctx.PositionOf(po);
                    break;
                case Power pow:
                    expression = ctx.Power(pow);
                    break;
                case Precision pre:
                    expression = ctx.Precision(pre);
                    break;
                case Predecessor prd:
                    expression = ctx.Predecessor(prd);
                    break;
                case Product prod:
                    expression = ctx.Product(prod);
                    break;
                case ProperContains pc:
                    expression = ctx.ProperContains(pc);
                    break;
                case ProperIn pi:
                    expression = ctx.ProperIn(pi);
                    break;
                case ProperIncludes pi:
                    expression = ctx.ProperIncludes(pi);
                    break;
                case ProperIncludedIn pie:
                    expression = ctx.ProperIncludedIn(pie);
                    break;
                case Property pe:
                    expression = ctx.Property(pe);
                    break;
                case Quantity qua:
                    expression = ctx.Quantity(qua);
                    break;
                case Query qe:
                    expression = ctx.Query(qe);
                    break;
                case QueryLetRef qlre:
                    expression = ctx.QueryLetRef(qlre);
                    break;
                case Ratio re:
                    expression = ctx.Ratio(re);
                    break;
                case ReplaceMatches e:
                    expression = ctx.ReplaceMatches(e);
                    break;
                case Retrieve re:
                    expression = ctx.Retrieve(re);
                    break;
                case Round rnd:
                    expression = ctx.Round(rnd);
                    break;
                case SameAs sa:
                    expression = ctx.SameAs(sa);
                    break;
                case SameOrAfter soa:
                    expression = ctx.SameOrAfter(soa);
                    break;
                case SameOrBefore sob:
                    expression = ctx.SameOrBefore(sob);
                    break;
                case SingletonFrom sf:
                    expression = ctx.SingletonFrom(sf);
                    break;
                case Slice slice:
                    expression = ctx.Slice(slice);
                    break;
                case Split split:
                    expression = ctx.Split(split);
                    break;
                case Substring e:
                    expression = ctx.Substring(e);
                    break;
                case Subtract sub:
                    expression = ctx.Subtract(sub);
                    break;
                case Successor suc:
                    expression = ctx.Successor(suc);
                    break;
                case Sum sum:
                    expression = ctx.Sum(sum);
                    break;
                case Starts starts:
                    expression = ctx.Starts(starts);
                    break;
                case Start start:
                    expression = ctx.Start(start);
                    break;
                case StartsWith e:
                    expression = ctx.StartsWith(e);
                    break;
                case StdDev stddev:
                    expression = ctx.StdDev(stddev);
                    break;
                case Time time:
                    expression = ctx.Time(time);
                    break;
                case TimeOfDay tod:
                    expression = ctx.TimeOfDay(tod);
                    break;
                case TimezoneOffsetFrom tofe:
                    expression = ctx.TimezoneOffsetFrom(tofe);
                    break;
                case ToBoolean e:
                    expression = ctx.ToBoolean(e);
                    break;
                case ToConcept tc:
                    expression = ctx.ToConcept(tc);
                    break;
                case ToDateTime tdte:
                    expression = ctx.ToDateTime(tdte);
                    break;
                case ToDate tde:
                    expression = ctx.ToDate(tde);
                    break;
                case Today today:
                    expression = ctx.Today(today);
                    break;
                case ToDecimal tde:
                    expression = ctx.ToDecimal(tde);
                    break;
                case ToInteger tde:
                    expression = ctx.ToInteger(tde);
                    break;
                case ToList tle:
                    expression = ctx.ToList(tle);
                    break;
                case ToLong toLong:
                    expression = ctx.ToLong(toLong);
                    break;
                case ToQuantity tq:
                    expression = ctx.ToQuantity(tq);
                    break;
                case ToString e:
                    expression = ctx.ToString(e);
                    break;
                case ToTime e:
                    expression = ctx.ToTime(e);
                    break;
                case Truncate trunc:
                    expression = ctx.Truncate(trunc);
                    break;
                case TruncatedDivide div:
                    expression = ctx.TruncatedDivide(div);
                    break;
                case elm.Tuple tu:
                    expression = ctx.Tuple(tu);
                    break;
                case Union ue:
                    expression = ctx.Union(ue);
                    break;
                case ValueSetRef vsre:
                    expression = ctx.ValueSetRef(vsre);
                    break;
                case Variance variance:
                    expression = ctx.Variance(variance);
                    break;
                case Upper e:
                    expression = ctx.Upper(e);
                    break;
                case Width width:
                    expression = ctx.Width(width);
                    break;
                case Xor xor:
                    expression = ctx.Xor(xor);
                    break;
                default: throw ctx.NewExpressionBuildingException($"Expression {op.GetType().FullName} is not implemented.");
            }

            expression = ctx.Mutate(op, expression);
            return expression!;
        }

        protected Expression BinaryOperator(CqlOperator @operator, elm.BinaryExpression be)
        {
            ExpressionBuilderContext ctx = this;
            var lhsExpression = ctx.TranslateExpression(be.operand![0]);
            var rhsExpression = ctx.TranslateExpression(be.operand![1]);
            var call = ctx.OperatorBinding.Bind(@operator, ctx.RuntimeContextParameter, lhsExpression, rhsExpression);
            return call;
        }

        protected Expression UnaryOperator(CqlOperator @operator, elm.UnaryExpression unary)
        {
            ExpressionBuilderContext ctx = this;
            var operand = ctx.TranslateExpression(unary.operand!);
            var resultType = unary.resultTypeSpecifier != null
                ? _typeManager.TypeFor(unary.resultTypeSpecifier, ctx)
                : null;
            var call = ctx.OperatorBinding.Bind(@operator, ctx.RuntimeContextParameter, operand);
            if (resultType != null && resultType != call.Type)
            {
                var typeAs = ctx.ChangeType(call, resultType);
                return typeAs;
            }
            else
            {
                return call;
            }
        }

        protected Expression NaryOperator(CqlOperator @operator, NaryExpression ne)
        {
            ExpressionBuilderContext ctx = this;
            var operators = ne.operand
                .Select(op => ctx.TranslateExpression(op))
                .ToArray();
            var call = ctx.OperatorBinding.Bind(@operator, ctx.RuntimeContextParameter, operators);
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
            ExpressionBuilderContext ctx = this;
            var operand = ctx.TranslateExpression(aggregate.source!);
            var call = ctx.OperatorBinding.Bind(@operator, ctx.RuntimeContextParameter, operand);
            return call;
        }

        protected Expression? IdentifierRef(IdentifierRef ire)
        {
            ExpressionBuilderContext ctx = this;
            if (string.Equals("$this", ire.name) && ctx.ImpliedAlias != null)
            {
                var scopeExpression = ctx.GetScopeExpression(ctx.ImpliedAlias!);
                return scopeExpression;
            }
            var pe = new Property
            {
                resultTypeSpecifier = ire.resultTypeSpecifier,
                resultTypeName = ire.resultTypeName,
                localId = ire.localId,
                locator = ire.locator,
                path = ire.name,
                scope = ctx.ImpliedAlias!,
            };
            ctx = ctx.Push(pe);
            var prop = ctx.Property(pe);
            return prop;
        }


        protected bool IsOrImplementsIEnumerableOfT(Type type) => _typeManager.Resolver.ImplementsGenericInterface(type, typeof(IEnumerable<>));

        protected Expression ValueSetRef(ValueSetRef valueSetRef)
        {
            ExpressionBuilderContext ctx = this;
            if (string.IsNullOrWhiteSpace(valueSetRef.name))
                throw ctx.NewExpressionBuildingException($"The ValueSetRef at {valueSetRef.locator} is missing a name.");
            var type = _typeManager.TypeFor(valueSetRef, ctx)!;
            var cqlValueSet = InvokeDefinitionThroughRuntimeContext(valueSetRef.name, valueSetRef.libraryName, typeof(CqlValueSet));

            if (IsOrImplementsIEnumerableOfT(type))
            {
                var elementType = _typeManager.Resolver.GetListElementType(type);
                if (elementType != typeof(CqlCode))
                {
                    throw ctx.NewExpressionBuildingException($"The expected type for value set {valueSetRef.name} in this context is {TypeManager.PrettyTypeName(type)}");
                }

                var @new = ctx.CallCreateValueSetFacade(cqlValueSet);
                return @new;
            }
            return cqlValueSet;
        }

        protected Expression QueryLetRef(QueryLetRef qlre)
        {
            ExpressionBuilderContext ctx = this;
            var name = qlre.name!;
            var expr = ctx.GetScopeExpression(name);
            return expr;
        }

        protected Expression AliasRef(AliasRef ar)
        {
            ExpressionBuilderContext ctx = this;
            var expr = ctx.GetScopeExpression(ar.name!);
            return expr;
        }

        protected Expression Tuple(elm.Tuple tuple)
        {
            ExpressionBuilderContext ctx = this;
            Type tupleType;
            if (tuple.resultTypeSpecifier is null)
            {
                tupleType = _typeManager.TupleTypeFor(tuple, ctx);
            }
            else
            {
                var tupleTypeSpecifier = (tuple.resultTypeSpecifier as elm.TupleTypeSpecifier) ?? throw ctx.NewExpressionBuildingException($"Tuple expression has a resultType that is not a TupleTypeSpecifier.");
                tupleType = _typeManager.TupleTypeFor(tupleTypeSpecifier, ctx);
            }

            var @new = Expression.New(tupleType);
            if (tuple.element?.Length > 0)
            {
                var elementBindings = (tuple.element!)
                               .Select(element =>
                               {
                                   var value = ctx.TranslateExpression(element.value!);
                                   var memberInfo = GetProperty(tupleType, NormalizeIdentifier(element.name!)!, _typeManager.Resolver)
                                                    ?? throw ctx.NewExpressionBuildingException($"Could not find member {element} on type {TypeManager.PrettyTypeName(tupleType!)}");
                                   var binding = Binding(value, memberInfo);
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
            if (list.resultTypeSpecifier is elm.ListTypeSpecifier listTypeSpecifier)
            {

                var elementType = _typeManager.TypeFor(listTypeSpecifier.elementType, this);
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
            ExpressionBuilderContext ctx = this;
            if (string.IsNullOrWhiteSpace(codeSystemRef.name))
                throw ctx.NewExpressionBuildingException("The code system ref has no name.");

            var type = _typeManager.Resolver.CodeType.MakeArrayType();
            return InvokeDefinitionThroughRuntimeContext(codeSystemRef.name, codeSystemRef.libraryName, type!);
        }
        protected Expression ConceptRef(ConceptRef conceptRef)
        {
            ExpressionBuilderContext ctx = this;
            if (string.IsNullOrWhiteSpace(conceptRef.name))
                throw ctx.NewExpressionBuildingException("The concept ref has no name.");

            var type = _typeManager.Resolver.CodeType.MakeArrayType();
            return InvokeDefinitionThroughRuntimeContext(conceptRef.name, conceptRef.libraryName, type!);
        }

        protected Expression Instance(Instance ine)
        {
            ExpressionBuilderContext ctx = this;
            var instanceType = _typeManager.Resolver.ResolveType(ine.classType.Name!)
                ?? throw ctx.NewExpressionBuildingException($"Could not resolve type for '{ine.classType.Name!}'");

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
                    else throw ctx.NewExpressionBuildingException($"No property called {tuple.Item1} should exist on {nameof(CqlRatio)}");
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
                    else throw ctx.NewExpressionBuildingException($"No property called {tuple.Item1} should exist on {nameof(CqlQuantity)}");
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
                    else throw ctx.NewExpressionBuildingException($"No property called {tuple.Item1} should exist on {nameof(CqlCode)}");
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
                    else throw ctx.NewExpressionBuildingException($"No property called {tuple.Item1} should exist on {nameof(CqlConcept)}");
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
                    var memberInfo = GetProperty(instanceType!, element, _typeManager.Resolver) ?? throw ctx.NewExpressionBuildingException($"Could not find member {element} on type {TypeManager.PrettyTypeName(instanceType!)}");
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
            ExpressionBuilderContext ctx = this;
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
                        var valueEnumerableElement = _typeManager.Resolver.GetListElementType(value.Type) ?? throw ctx.NewExpressionBuildingException(message);
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
                            var callSelectMethod = ctx.OperatorBinding.Bind(CqlOperator.Select, ctx.RuntimeContextParameter, value, selectLambda);
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
            else throw new NotImplementedException().WithContext(ctx);
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
                var fromElement = _typeManager.Resolver.GetListElementType(from, @throw: true)!;
                var toElement = _typeManager.Resolver.GetListElementType(to, @throw: true)!;
                return IsConvertible(fromElement, toElement);
            }
            return false;
        }

        protected Expression If(If @if)
        {
            ExpressionBuilderContext ctx = this;
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
                    throw ctx.NewExpressionBuildingException($"The If expression at {@if.locator} produces two branches with different types.");
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
            ExpressionBuilderContext ctx = this;
            var nullType = _typeManager.TypeFor(@null, ctx) ?? typeof(object);
            var constant = Expression.Constant(null, nullType);
            return constant;
        }

        protected Expression Literal(Literal lit)
        {
            ExpressionBuilderContext ctx = this;
            string message = $"Cannot resolve type for {lit.valueType}";
            var type = _typeManager.Resolver.ResolveType(lit.valueType.Name!) ?? throw ctx.NewExpressionBuildingException(message);
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
            ExpressionBuilderContext ctx = this;
            if (ctx.Operands.TryGetValue(ore.name!, out var expression))
                return expression;
            else throw ctx.NewExpressionBuildingException($"Operand reference to {ore.name} not found in definition operands.");
        }

        protected Expression Case(Case ce)
        {
            ExpressionBuilderContext ctx = this;

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

            else throw ctx.NewExpressionBuildingException("Invalid case expression.  At least 1 case and an else must be present.");
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
            ExpressionBuilderContext ctx = this;
            Type? sourceElementType;
            string? cqlRetrieveResultType;

            // SingletonFrom does not have this specified; in this case use DataType instead
            if (retrieve.resultTypeSpecifier == null)
            {
                if (string.IsNullOrWhiteSpace(retrieve.dataType.Name))
                    throw ctx.NewExpressionBuildingException("If a Retrieve lacks a ResultTypeSpecifier it must have a DataType");
                cqlRetrieveResultType = retrieve.dataType.Name;

                sourceElementType = _typeManager.Resolver.ResolveType(cqlRetrieveResultType);
            }
            else
            {
                if (retrieve.resultTypeSpecifier is elm.ListTypeSpecifier listTypeSpecifier)
                {
                    cqlRetrieveResultType = listTypeSpecifier.elementType is elm.NamedTypeSpecifier nts ? nts.name.Name : null;
                    sourceElementType = _typeManager.TypeFor(listTypeSpecifier.elementType, ctx);
                }
                else throw new NotImplementedException($"Sources with type {retrieve.resultTypeSpecifier.GetType().Name} are not implemented.").WithContext(ctx);
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
                        throw ctx.NewExpressionBuildingException($"The ValueSetRef at {valueSetRef.locator} is missing a name.");
                    var valueSet = InvokeDefinitionThroughRuntimeContext(valueSetRef.name!, valueSetRef!.libraryName, typeof(CqlValueSet));
                    var call = ctx.OperatorBinding.Bind(CqlOperator.Retrieve, ctx.RuntimeContextParameter,
                        Expression.Constant(sourceElementType, typeof(Type)), valueSet, codeProperty!);
                    return call;
                }
                else
                {
                    // In this construct, instead of querying a value set, we're testing resources
                    // against a list of codes, e.g., as defined by the code from or codesystem construct
                    var codes = TranslateExpression(retrieve.codes);
                    var call = ctx.OperatorBinding.Bind(CqlOperator.Retrieve, ctx.RuntimeContextParameter,
                        Expression.Constant(sourceElementType, typeof(Type)), codes, codeProperty!);
                    return call;
                }
            }
            else
            {
                var call = ctx.OperatorBinding.Bind(CqlOperator.Retrieve, ctx.RuntimeContextParameter,
                    Expression.Constant(sourceElementType, typeof(Type)), Expression.Constant(null, typeof(CqlValueSet)), codeProperty!);
                return call;
            }
        }

        protected Expression Property(Property op)
        {
            if (string.IsNullOrWhiteSpace(op.path))
                throw this.NewExpressionBuildingException("path cannot be null or empty");
            //var path = ExpressionBuilderContext.NormalizeIdentifier(op.path);
            var path = op.path;
            if (!string.IsNullOrWhiteSpace(op.scope))
            {
                var scopeExpression = this.GetScopeExpression(op.scope!);
                var expectedType = _typeManager.TypeFor(op, this) ?? typeof(object);
                var pathMemberInfo = _typeManager.Resolver.GetProperty(scopeExpression.Type, path!) ??
                    _typeManager.Resolver.GetProperty(scopeExpression.Type, op.path);
                if (pathMemberInfo == null)
                {
                    _logger.LogWarning(this.FormatMessage($"Property {op.path} can't be known at design time, and will be late-bound, slowing performance.  Consider casting the source first so that this property can be definitely bound.", op));
                    var call = this.OperatorBinding.Bind(CqlOperator.LateBoundProperty, this.RuntimeContextParameter,
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
                var resultType = _typeManager.TypeFor(op, this) ?? throw this.NewExpressionBuildingException(message);
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
                    var expectedType = _typeManager.TypeFor(op, this)!;
                    var result = PropertyHelper(source, path, expectedType);
                    return result;
                }
            }
            else throw new NotImplementedException().WithContext(this);
        }

        protected Expression PropertyHelper(Expression source, string? path, Type expectedType)
        {
            ExpressionBuilderContext ctx = this;
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
                    _logger.LogWarning(ctx.FormatMessage($"Property {path} can't be known at design time, and will be late-bound, slowing performance.  Consider casting the source first so that this property can be definitely bound."));
                    var call = ctx.OperatorBinding.Bind(CqlOperator.LateBoundProperty, ctx.RuntimeContextParameter,
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
            ExpressionBuilderContext ctx = this;
            var operands = op.operand
                .Select(operand => TranslateExpression(operand))
                .ToArray();
            var operandTypes = operands
                .Select(op => op.Type);

            var functionType = GetFunctionRefReturnType(op, operandTypes);

            var funcTypeParameters =
                new[] { typeof(CqlContext) }
                .Concat(operandTypes)
                .Concat(new[] { functionType })
                .ToArray();

            var funcType = GetFuncType(funcTypeParameters);

            // FHIRHelpers has special handling in CQL-to-ELM and does not translate correctly - specifically,
            // it interprets ToString(value string) oddly.  Normally when string is used in CQL it is resolved to the elm type.
            // In FHIRHelpers, this string gets treated as a FHIR string, which is normally mapped to a StringElement abstraction.
            if (op.libraryName != null && op.libraryName.StartsWith("fhirhelpers", StringComparison.OrdinalIgnoreCase))
            {
                if (op.name!.Equals("tostring", StringComparison.OrdinalIgnoreCase))
                {
                    if (operands[0].Type == typeof(string))
                    {
                        return operands[0];
                    }
                    else
                    {
                        var bind = ctx.OperatorBinding.Bind(CqlOperator.Convert, ctx.RuntimeContextParameter,

                            new[] { operands[0], Expression.Constant(typeof(string), typeof(Type)) });
                        return bind;
                    }
                }
            }
            // all functions still take the bundle and context parameters, plus whatver the operands
            // to the actual function are.
            operands = operands.Prepend(ctx.RuntimeContextParameter).ToArray();

            var invoke = InvokeDefinedFunctionThroughRuntimeContext(op.name!, op.libraryName!, funcType, operands);
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
            ExpressionBuilderContext ctx = this;
            // Try determining the return type from the resultTypeSpecifier or resultTypeName
            if (op.resultTypeSpecifier != null)
            {
                string message = $"Cannot resolve result type {op.resultTypeSpecifier}.";
                return _typeManager.TypeFor(op.resultTypeSpecifier, ctx) ?? throw ctx.NewExpressionBuildingException(message);
            }

            if (!string.IsNullOrWhiteSpace(op.resultTypeName?.Name))
            {
                return _typeManager.Resolver.ResolveType(op.resultTypeName.Name!)
                    ?? throw ctx.NewExpressionBuildingException($"Cannot determine type for function {op.libraryName ?? ""}.{op.name}");
            }

            // If that failed, try some hard-coded special cases from the FHIRHelpers
            if (op.libraryName?.StartsWith("FHIRHelpers") == true)
            {
                if (DetermineFhirHelpersReturnType(op) is { } resolved) return resolved;
            }

            // We failed....
            throw ctx.NewExpressionBuildingException($"Cannot determine type for function {op.libraryName ?? ""}.{op.name}");
        }

        private Type? DetermineFhirHelpersReturnType(FunctionRef op) // TODO: Remove hack (in another PR)
        {
            // cql-to-elm does not handle FHIRHelpers conversion function refs appropriately; they are missing resultTypeSpecifiers
            return op.name switch
            {
                "ToDate" => _typeManager.Resolver.ResolveType("{urn:hl7-org:elm-types:r1}Date")!,
                "ToDateTime" => _typeManager.Resolver.ResolveType("{urn:hl7-org:elm-types:r1}DateTime")!,
                "ToQuantity" => _typeManager.Resolver.ResolveType("{urn:hl7-org:elm-types:r1}Quantity")!,
                "ToInteger" => _typeManager.Resolver.ResolveType("{urn:hl7-org:elm-types:r1}Integer")!,
                "ToBoolean" => _typeManager.Resolver.ResolveType("{urn:hl7-org:elm-types:r1}Boolean")!,
                "ToString" => _typeManager.Resolver.ResolveType("{urn:hl7-org:elm-types:r1}String")!,
                "ToDecimal" => _typeManager.Resolver.ResolveType("{urn:hl7-org:elm-types:r1}Decimal")!,
                "ToRatio" => _typeManager.Resolver.ResolveType("{urn:hl7-org:elm-types:r1}Ratio")!,
                "ToCode" => _typeManager.Resolver.ResolveType("{urn:hl7-org:elm-types:r1}Code")!,
                "ToConcept" => _typeManager.Resolver.ResolveType("{urn:hl7-org:elm-types:r1}Concept")!,
                "ToValue" => typeof(object),  // choice type
                "ToInterval" when op is { resultTypeSpecifier: null, resultTypeName: null } => BindToInterval(),
                _ => null
            };

            Type? BindToInterval()
            {
                if (op.operand?.Length == 1)
                {
                    var operand = op.operand![0];
                    var typeName = operand.resultTypeName?.Name;

                    if (operand is As @as)
                    {
                        typeName = @as.asType?.Name;
                        if (typeName == null && @as.asTypeSpecifier != null)
                            typeName = @as.asTypeSpecifier.resultTypeName.Name;
                        if (typeName == null)
                            typeName = @as.resultTypeName.Name;
                    }

                    if (typeName == "{http://hl7.org/fhir}Period")
                    {
                        var pointType = _typeManager.Resolver.ResolveType("{urn:hl7-org:elm-types:r1}DateTime");
                        var intervalType = _typeManager.Resolver.IntervalType(pointType!);
                        {
                            return intervalType;
                        }
                    }
                    else if (typeName == "{http://hl7.org/fhir}Range")
                    {
                        var pointType = _typeManager.Resolver.ResolveType("{urn:hl7-org:elm-types:r1}Quantity");
                        var intervalType = _typeManager.Resolver.IntervalType(pointType!);
                        {
                            return intervalType;
                        }
                    }
                }

                return null;
            }
        }

        protected Expression ExpressionRef(ExpressionRef expressionRef)
        {
            ExpressionBuilderContext ctx = this;
            Type? expressionType = null;
            if (expressionRef.resultTypeSpecifier != null)
            {
                expressionType = _typeManager.TypeFor(expressionRef.resultTypeSpecifier, this);
            }
            else if (!string.IsNullOrWhiteSpace(expressionRef.resultTypeName?.Name))
            {
                expressionType = _typeManager.Resolver.ResolveType(expressionRef.resultTypeName.Name!);
            }
            else
            {
                var def = ctx.LibraryContext.Library.statements?.SingleOrDefault(d => d.name == expressionRef.name);
                if (def != null)
                {
                    ctx = ctx.Push(def);
                    expressionType = _typeManager.TypeFor(def, ctx);
                }
                else throw new NotSupportedException("Unable to resolve expression reference type.");
            }

            if (expressionType == null)
                throw ctx.NewExpressionBuildingException($"Unable to determine type for {expressionRef.localId}");

            var invoke = ctx.InvokeDefinitionThroughRuntimeContext(expressionRef.name!, expressionRef.libraryName, expressionType);
            return invoke;
        }

        protected Expression ParameterRef(ParameterRef op)
        {
            ExpressionBuilderContext ctx = this;
            if (ctx.LibraryContext.Definitions.TryGetValue(ctx.LibraryContext.LibraryKey, op.name!, out var lambda) && lambda != null)
            {
                var invoke = ctx.InvokeDefinitionThroughRuntimeContext(op.name!, null, lambda);
                return invoke;
            }

            throw ctx.NewExpressionBuildingException($"Parameter {op.name} hasn't been defined yet.");
        }

        protected internal static MemberInfo? GetProperty(Type type, string name, TypeResolver typeResolver)
        {
            if (type.IsGenericType)
            {
                var gtd = type.GetGenericTypeDefinition();
                if (gtd == typeof(Nullable<>))
                {
                    if (string.Equals(name, "value", StringComparison.OrdinalIgnoreCase))
                    {
                        string message = $"value element not found as a Value property on object.";
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
        /// <param name="definitionType">The Func or Action type of this definition</param>
        /// <param name="arguments">The function arguments</param>
        /// <returns></returns>
        protected Expression InvokeDefinedFunctionThroughRuntimeContext(string name, string libraryAlias,
            Type definitionType,
            Expression[] arguments)
        {
            ExpressionBuilderContext ctx = this;
            var definitionsProperty = Expression.Property(ctx.RuntimeContextParameter, typeof(CqlContext).GetProperty(nameof(CqlContext.Definitions))!);

            string libraryName = ctx.LibraryContext.GetIncludeNameAndVersion(libraryAlias, throwError: false)
                ?? throw ctx.NewExpressionBuildingException($"Local library {libraryAlias} is not defined; are you missing a using statement?");

            return new FunctionCallExpression(definitionsProperty, libraryName, name, arguments, definitionType);
        }

        protected Expression InvokeDefinitionThroughRuntimeContext(
            string name,
            string? libraryAlias,
            LambdaExpression definition)
        {
            ExpressionBuilderContext ctx = this;
            var type = definition.Type;
            if (type.IsGenericType)
            {
                var typeArgs = type.GetGenericArguments();
                var returnType = typeArgs[^1];
                var invoke = ctx.InvokeDefinitionThroughRuntimeContext(name, libraryAlias, returnType);
                return invoke;
            }
            else throw ctx.NewExpressionBuildingException("LambdaExpressions should be a variant of Func<>");
        }

        protected Expression InvokeDefinitionThroughRuntimeContext(
            string name,
            string? libraryAlias,
            Type definitionReturnType)
        {
            ExpressionBuilderContext ctx = this;
            var definitionsProperty = Expression.Property(ctx.RuntimeContextParameter, typeof(CqlContext).GetProperty(nameof(CqlContext.Definitions))!);

            string libraryName = ctx.LibraryContext.GetIncludeNameAndVersion(libraryAlias, throwError: false)
                                  ?? throw ctx.NewExpressionBuildingException($"Local library {libraryAlias} is not defined; are you missing a using statement?");

            var funcType = typeof(Func<,>).MakeGenericType(typeof(CqlContext), definitionReturnType);
            return new DefinitionCallExpression(definitionsProperty, libraryName, name, ctx.RuntimeContextParameter, funcType);
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

        private Expression CrossJoin(AliasedQuerySource[] sources, Type tupleType)
        {
            ExpressionBuilderContext ctx = this;
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

            if (sources.Length < 2) throw ctx.NewExpressionBuildingException($"This method should only be called for 2 or more query sources");

            // the first pair are special as they are not working off of a partially built tuple,
            // they are working only off of the initial selectmany parameters.
            var first = sources[0];
            var firstExpression = ctx.TranslateExpression(first.expression!);
            var firstElementType = _typeManager.Resolver.GetListElementType(firstExpression.Type)!;
            var second = sources[1];
            var secondExpression = ctx.TranslateExpression(second.expression!);
            var secondElementType = _typeManager.Resolver.GetListElementType(secondExpression.Type)!;

            var firstLambdaParameter = Expression.Parameter(firstElementType, $"_{first.alias}");
            var firstSelectManyParameter = Expression.Lambda(secondExpression, firstLambdaParameter);

            var secondLambdaParameter = Expression.Parameter(secondElementType, $"_{second.alias}");
            var @newTuple = Expression.New(tupleType);
            var memberInit = Expression.MemberInit(newTuple,
                Expression.Bind(tupleType.GetProperty(first.alias)!, firstLambdaParameter),
                Expression.Bind(tupleType.GetProperty(second.alias)!, secondLambdaParameter));
            var secondSelectManyParameter = Expression.Lambda(memberInit, firstLambdaParameter, secondLambdaParameter);

            var callSelectMany = ctx.OperatorBinding.Bind(CqlOperator.SelectManyResults, ctx.RuntimeContextParameter,
                firstExpression,
                firstSelectManyParameter,
                secondSelectManyParameter);

            var enumerableOfTupleType = callSelectMany.Type;

            if (sources.Length > 2)
            {
                for (int i = 2; i < sources.Length; i++)
                {
                    var source = sources[i];

                    var sourceExpression = ctx.TranslateExpression(source.expression!);
                    string message = $"{sourceExpression.Type} was expected to be a list type.";
                    var sourceElementType = _typeManager.Resolver.GetListElementType(sourceExpression.Type) ?? throw ctx.NewExpressionBuildingException(message);

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
                    @newTuple = Expression.New(tupleType);
                    memberInit = Expression.MemberInit(newTuple, bindings);
                    var p2 = Expression.Lambda(memberInit, ab, c);

                    var callAgain = ctx.OperatorBinding.Bind(CqlOperator.SelectManyResults, ctx.RuntimeContextParameter,
                        callSelectMany,
                        p1,
                        p2);
                    callSelectMany = callAgain;
                }
            }
            return callSelectMany;
        }

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

        internal static string TypeNameToIdentifier(Type type, ExpressionBuilderContext? ctx)
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
            ExpressionBuilderContext ctx = this;
            var operatorsProperty = typeof(CqlContext).GetProperty(nameof(CqlContext.Operators))!;
            var createFacadeMethod = typeof(ICqlOperators).GetMethod(nameof(ICqlOperators.CreateValueSetFacade))!;
            var property = Expression.Property(ctx.RuntimeContextParameter, operatorsProperty);
            var call = Expression.Call(property, createFacadeMethod, operand);

            return call;
        }
    }
}