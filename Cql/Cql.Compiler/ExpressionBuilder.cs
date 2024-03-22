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
        // Yeah, hardwired to FHIR 4.0.1 for now.
        private static readonly IDictionary<string, ClassInfo> ModelMapping = Models.ClassesById(Models.Fhir401);

        private readonly ILogger<ExpressionBuilder> _logger;

        private readonly TypeManager _typeManager;


        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="typeManager">The <see cref="_typeManager"/> used to resolve and create types referenced.</param>
        /// <param name="logger">The <see cref="ILogger{ExpressionBuilder}"/> used to log all messages issued.</param>
        /// <exception cref="ArgumentNullException">If any argument is <see langword="null"/></exception>
        public ExpressionBuilder(
            TypeManager typeManager,
            ILogger<ExpressionBuilder> logger)
        {
            _typeManager = typeManager ?? throw new ArgumentNullException(nameof(typeManager));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
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
            Elm.Library library,
            Elm.Expression expression,
            OperatorBinding operatorBinding,
            DefinitionDictionary<LambdaExpression>? lambdas = null)
        {
            var parameter = Expression.Parameter(typeof(CqlContext), "rtx");
            lambdas ??= new DefinitionDictionary<LambdaExpression>();
            var libraryExpressionsBuilderContext = new LibraryExpressionBuilderContext(library, Settings, operatorBinding, lambdas);
            var ctx = libraryExpressionsBuilderContext.NewExpressionBuilderContext(expression);
            var translated = TranslateExpression(expression, ctx);
            var lambda = Expression.Lambda(translated, parameter);
            return lambda;
        }

        internal Expression TranslateExpression(elm.Element op, ExpressionBuilderContext ctx)
        {
            ctx = ctx.Deeper(op);
            Expression? expression;
            switch (op)
            {
                case Abs abs:
                    expression = Abs(abs, ctx);
                    break;
                case Add add:
                    expression = Add(add, ctx);
                    break;
                case After after:
                    expression = After(after, ctx);
                    break;
                case AliasRef ar:
                    expression = AliasRef(ar, ctx);
                    break;
                case AllTrue alt:
                    expression = AllTrue(alt, ctx);
                    break;
                case And and:
                    expression = And(and, ctx);
                    break;
                case As @as:
                    expression = As(@as, ctx);
                    break;
                case AnyTrue ate:
                    expression = AnyTrue(ate, ctx);
                    break;
                case AnyInValueSet avs:
                    expression = AnyInValueSet(avs, ctx);
                    break;
                case Avg avg:
                    expression = Avg(avg, ctx);
                    break;
                case Before before:
                    expression = Before(before, ctx);
                    break;
                case CalculateAgeAt caa:
                    expression = CalculateAgeAt(caa, ctx);
                    break;
                case CalculateAge ca:
                    expression = CalculateAge(ca, ctx);
                    break;
                case Case ce:
                    expression = Case(ce, ctx);
                    break;
                case Ceiling ceil:
                    expression = Ceiling(ceil, ctx);
                    break;
                case Coalesce cle:
                    expression = Coalesce(cle, ctx);
                    break;
                case CodeRef cre:
                    expression = CodeRef(cre, ctx);
                    break;
                case CodeSystemRef csr:
                    expression = CodeSystemRef(csr, ctx);
                    break;
                case Collapse col:
                    expression = Collapse(col, ctx);
                    break;
                case Combine com:
                    expression = Combine(com, ctx);
                    break;
                case Concatenate cctn:
                    expression = Concatenate(cctn, ctx);
                    break;
                case ConceptRef cr:
                    expression = ConceptRef(cr, ctx);
                    break;
                case Contains ct:
                    expression = Contains(ct, ctx);
                    break;
                case ConvertQuantity cqe:
                    expression = ConvertQuantity(cqe, ctx);
                    break;
                case ConvertsToBoolean ce:
                    expression = ConvertsToBoolean(ce, ctx);
                    break;
                case ConvertsToDate ce:
                    expression = ConvertsToDate(ce, ctx);
                    break;
                case ConvertsToDateTime ce:
                    expression = ConvertsToDateTime(ce, ctx);
                    break;
                case ConvertsToDecimal ce:
                    expression = ConvertsToDecimal(ce, ctx);
                    break;
                case ConvertsToLong ce:
                    expression = ConvertsToLong(ce, ctx);
                    break;
                case ConvertsToInteger ce:
                    expression = ConvertsToInteger(ce, ctx);
                    break;
                case ConvertsToQuantity ce:
                    expression = ConvertsToQuantity(ce, ctx);
                    break;
                case ConvertsToString ce:
                    expression = ConvertsToString(ce, ctx);
                    break;
                case ConvertsToTime ce:
                    expression = ConvertsToTime(ce, ctx);
                    break;
                case Count ce:
                    expression = Count(ce, ctx);
                    break;
                case DateFrom dfe:
                    expression = DateFrom(dfe, ctx);
                    break;
                case elm.DateTime dt:
                    expression = DateTime(dt, ctx);
                    break;
                case Date d:
                    expression = Date(d, ctx);
                    break;
                case DateTimeComponentFrom dtcf:
                    expression = DateTimeComponentFrom(dtcf, ctx);
                    break;
                case Descendents desc:
                    expression = Descendents(desc, ctx);
                    break;
                case DifferenceBetween dbe:
                    expression = DifferenceBetween(dbe, ctx);
                    break;
                case Distinct distinct:
                    expression = Distinct(distinct, ctx);
                    break;
                case Divide divide:
                    expression = Divide(divide, ctx);
                    break;
                case DurationBetween dbe:
                    expression = DurationBetween(dbe, ctx);
                    break;
                case End e:
                    expression = End(e, ctx);
                    break;
                case Ends e:
                    expression = Ends(e, ctx);
                    break;
                case EndsWith e:
                    expression = EndsWith(e, ctx);
                    break;
                case Equal eq:
                    expression = Equal(eq, ctx);
                    break;
                case Equivalent eqv:
                    expression = Equivalent(eqv, ctx);
                    break;
                case Except ex:
                    expression = Except(ex, ctx);
                    break;
                case Exists ex:
                    expression = Exists(ex, ctx);
                    break;
                case Exp exe:
                    expression = Exp(exe, ctx);
                    break;
                case Expand expand:
                    expression = Expand(expand, ctx);
                    break;
                case ExpandValueSet evs:
                    expression = ExpandValueSet(evs, ctx);
                    break;
                case FunctionRef fre:
                    expression = FunctionRef(fre, ctx);
                    break;
                case ExpressionRef ere:
                    expression = ExpressionRef(ere, ctx);
                    break;
                case First first:
                    expression = First(first, ctx);
                    break;
                case Flatten fl:
                    expression = Flatten(fl, ctx);
                    break;
                case Floor floor:
                    expression = Floor(floor, ctx);
                    break;
                case GeometricMean gme:
                    expression = GeometricMean(gme, ctx);
                    break;
                case Greater gtr:
                    expression = Greater(gtr, ctx);
                    break;
                case GreaterOrEqual gtre:
                    expression = GreaterOrEqual(gtre, ctx);
                    break;
                case HighBoundary hb:
                    expression = HighBoundary(hb, ctx);
                    break;
                case IdentifierRef ire:
                    expression = IdentifierRef(ire, ctx);
                    break;
                case If @if:
                    expression = If(@if, ctx);
                    break;
                case Implies implies:
                    expression = Implies(implies, ctx);
                    break;
                case Includes inc:
                    expression = Includes(inc, ctx);
                    break;
                case IncludedIn ii:
                    expression = IncludedIn(ii, ctx);
                    break;
                case Indexer idx:
                    expression = Indexer(idx, ctx);
                    break;
                case IndexOf io:
                    expression = IndexOf(io, ctx);
                    break;
                case Instance ine:
                    expression = Instance(ine, ctx);
                    break;
                case Intersect ise:
                    expression = Intersect(ise, ctx);
                    break;
                case Interval ie:
                    expression = IntervalExpression(ie, ctx);
                    break;
                case InValueSet inv:
                    expression = InValueSet(inv, ctx);
                    break;
                case In @in:
                    expression = In(@in, ctx);
                    break;
                case Is @is:
                    expression = Is(@is, ctx);
                    break;
                case IsFalse @isn:
                    expression = IsFalse(@isn, ctx);
                    break;
                case IsNull @isn:
                    expression = IsNull(@isn, ctx);
                    break;
                case IsTrue @isn:
                    expression = IsTrue(@isn, ctx);
                    break;
                case Last last:
                    expression = Last(last, ctx);
                    break;
                case LastPositionOf lpo:
                    expression = LastPositionOf(lpo, ctx);
                    break;
                case Length len:
                    expression = Length(len, ctx);
                    break;
                case Less less:
                    expression = Less(less, ctx);
                    break;
                case LessOrEqual lesse:
                    expression = LessOrEqual(lesse, ctx);
                    break;
                case List list:
                    expression = List(list, ctx);
                    break;
                case Literal lit:
                    expression = Literal(lit, ctx);
                    break;
                case Ln ln:
                    expression = Ln(ln, ctx);
                    break;
                case Log log:
                    expression = Log(log, ctx);
                    break;
                case LowBoundary lb:
                    expression = LowBoundary(lb, ctx);
                    break;
                case Lower e:
                    expression = Lower(e, ctx);
                    break;
                case Matches e:
                    expression = Matches(e, ctx);
                    break;
                case Max max:
                    expression = Max(max, ctx);
                    break;
                case MaxValue max:
                    expression = MaxValue(max, ctx);
                    break;
                case Median med:
                    expression = Median(med, ctx);
                    break;
                case Meets meets:
                    expression = Meets(meets, ctx);
                    break;
                case MeetsBefore meets:
                    expression = MeetsBefore(meets, ctx);
                    break;
                case MeetsAfter meets:
                    expression = MeetsAfter(meets, ctx);
                    break;
                case Message msg:
                    expression = Message(msg, ctx);
                    break;
                case Min min:
                    expression = Min(min, ctx);
                    break;
                case MinValue min:
                    expression = MinValue(min, ctx);
                    break;
                case Mode mode:
                    expression = Mode(mode, ctx);
                    break;
                case Modulo mod:
                    expression = Modulo(mod, ctx);
                    break;
                case Multiply mul:
                    expression = Multiply(mul, ctx);
                    break;
                case Negate neg:
                    expression = Negate(neg, ctx);
                    break;
                case Not not:
                    expression = Not(not, ctx);
                    break;
                case NotEqual ne:
                    expression = NotEqual(ne, ctx);
                    break;
                case Now now:
                    expression = Now(now, ctx);
                    break;
                case Null @null:
                    expression = Null(@null, ctx);
                    break;
                case OperandRef ore:
                    expression = OperandRef(ore, ctx);
                    break;
                case Or or:
                    expression = Or(or, ctx);
                    break;
                case Overlaps ole:
                    expression = Overlaps(ole, ctx);
                    break;
                case OverlapsAfter ola:
                    expression = OverlapsAfter(ola, ctx);
                    break;
                case OverlapsBefore olb:
                    expression = OverlapsBefore(olb, ctx);
                    break;
                case ParameterRef pre:
                    expression = ParameterRef(pre, ctx);
                    break;
                case PointFrom pf:
                    expression = PointFrom(pf, ctx);
                    break;
                case PopulationStdDev pstd:
                    expression = PopulationStdDev(pstd, ctx);
                    break;
                case PopulationVariance pvar:
                    expression = PopulationVariance(pvar, ctx);
                    break;
                case PositionOf po:
                    expression = PositionOf(po, ctx);
                    break;
                case Power pow:
                    expression = Power(pow, ctx);
                    break;
                case Precision pre:
                    expression = Precision(pre, ctx);
                    break;
                case Predecessor prd:
                    expression = Predecessor(prd, ctx);
                    break;
                case Product prod:
                    expression = Product(prod, ctx);
                    break;
                case ProperContains pc:
                    expression = ProperContains(pc, ctx);
                    break;
                case ProperIn pi:
                    expression = ProperIn(pi, ctx);
                    break;
                case ProperIncludes pi:
                    expression = ProperIncludes(pi, ctx);
                    break;
                case ProperIncludedIn pie:
                    expression = ProperIncludedIn(pie, ctx);
                    break;
                case Property pe:
                    expression = Property(pe, ctx);
                    break;
                case Quantity qua:
                    expression = Quantity(qua, ctx);
                    break;
                case Query qe:
                    expression = Query(qe, ctx);
                    break;
                case QueryLetRef qlre:
                    expression = QueryLetRef(qlre, ctx);
                    break;
                case Ratio re:
                    expression = Ratio(re, ctx);
                    break;
                case ReplaceMatches e:
                    expression = ReplaceMatches(e, ctx);
                    break;
                case Retrieve re:
                    expression = Retrieve(re, ctx);
                    break;
                case Round rnd:
                    expression = Round(rnd, ctx);
                    break;
                case SameAs sa:
                    expression = SameAs(sa, ctx);
                    break;
                case SameOrAfter soa:
                    expression = SameOrAfter(soa, ctx);
                    break;
                case SameOrBefore sob:
                    expression = SameOrBefore(sob, ctx);
                    break;
                case SingletonFrom sf:
                    expression = SingletonFrom(sf, ctx);
                    break;
                case Slice slice:
                    expression = Slice(slice, ctx);
                    break;
                case Split split:
                    expression = Split(split, ctx);
                    break;
                case Substring e:
                    expression = Substring(e, ctx);
                    break;
                case Subtract sub:
                    expression = Subtract(sub, ctx);
                    break;
                case Successor suc:
                    expression = Successor(suc, ctx);
                    break;
                case Sum sum:
                    expression = Sum(sum, ctx);
                    break;
                case Starts starts:
                    expression = Starts(starts, ctx);
                    break;
                case Start start:
                    expression = Start(start, ctx);
                    break;
                case StartsWith e:
                    expression = StartsWith(e, ctx);
                    break;
                case StdDev stddev:
                    expression = StdDev(stddev, ctx);
                    break;
                case Time time:
                    expression = Time(time, ctx);
                    break;
                case TimeOfDay tod:
                    expression = TimeOfDay(tod, ctx);
                    break;
                case TimezoneOffsetFrom tofe:
                    expression = TimezoneOffsetFrom(tofe, ctx);
                    break;
                case ToBoolean e:
                    expression = ToBoolean(e, ctx);
                    break;
                case ToConcept tc:
                    expression = ToConcept(tc, ctx);
                    break;
                case ToDateTime tdte:
                    expression = ToDateTime(tdte, ctx);
                    break;
                case ToDate tde:
                    expression = ToDate(tde, ctx);
                    break;
                case Today today:
                    expression = Today(today, ctx);
                    break;
                case ToDecimal tde:
                    expression = ToDecimal(tde, ctx);
                    break;
                case ToInteger tde:
                    expression = ToInteger(tde, ctx);
                    break;
                case ToList tle:
                    expression = ToList(tle, ctx);
                    break;
                case ToLong toLong:
                    expression = ToLong(toLong, ctx);
                    break;
                case ToQuantity tq:
                    expression = ToQuantity(tq, ctx);
                    break;
                case ToString e:
                    expression = ToString(e, ctx);
                    break;
                case ToTime e:
                    expression = ToTime(e, ctx);
                    break;
                case Truncate trunc:
                    expression = Truncate(trunc, ctx);
                    break;
                case TruncatedDivide div:
                    expression = TruncatedDivide(div, ctx);
                    break;
                case elm.Tuple tu:
                    expression = Tuple(tu, ctx);
                    break;
                case Union ue:
                    expression = Union(ue, ctx);
                    break;
                case ValueSetRef vsre:
                    expression = ValueSetRef(vsre, ctx);
                    break;
                case Variance variance:
                    expression = Variance(variance, ctx);
                    break;
                case Upper e:
                    expression = Upper(e, ctx);
                    break;
                case Width width:
                    expression = Width(width, ctx);
                    break;
                case Xor xor:
                    expression = Xor(xor, ctx);
                    break;
                default: throw ctx.NewExpressionBuildingException($"Expression {op.GetType().FullName} is not implemented.");
            }

            expression = ctx.Mutate(op, expression);
            return expression!;
        }

        protected Expression BinaryOperator(CqlOperator @operator, elm.BinaryExpression be, ExpressionBuilderContext ctx)
        {
            var lhsExpression = TranslateExpression(be.operand![0], ctx);
            var rhsExpression = TranslateExpression(be.operand![1], ctx);
            var call = ctx.OperatorBinding.Bind(@operator, ctx.RuntimeContextParameter, lhsExpression, rhsExpression);
            return call;
        }

        protected Expression UnaryOperator(CqlOperator @operator, elm.UnaryExpression unary, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(unary.operand!, ctx);
            var resultType = unary.resultTypeSpecifier != null
                ? _typeManager.TypeFor(unary.resultTypeSpecifier, ctx)
                : null;
            var call = ctx.OperatorBinding.Bind(@operator, ctx.RuntimeContextParameter, operand);
            if (resultType != null && resultType != call.Type)
            {
                var typeAs = ChangeType(call, resultType, ctx);
                return typeAs;
            }
            else
            {
                return call;
            }
        }

        protected Expression NaryOperator(CqlOperator @operator, elm.NaryExpression ne, ExpressionBuilderContext ctx)
        {
            var operators = ne.operand
                .Select(op => TranslateExpression(op, ctx))
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

        protected Expression AggregateOperator(CqlOperator @operator, AggregateExpression aggregate, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(aggregate.source!, ctx);
            var call = ctx.OperatorBinding.Bind(@operator, ctx.RuntimeContextParameter, operand);
            return call;
        }

        protected Expression? IdentifierRef(IdentifierRef ire, ExpressionBuilderContext ctx)
        {
            if (string.Equals("$this", ire.name) && ctx.ImpliedAlias != null)
            {
                var scopeExpression = ctx.GetScopeExpression(ctx.ImpliedAlias);
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
            ctx = ctx.Deeper(pe);
            var prop = Property(pe, ctx);
            return prop;
        }


        protected bool IsOrImplementsIEnumerableOfT(Type type) => _typeManager.Resolver.ImplementsGenericInterface(type, typeof(IEnumerable<>));

        protected Expression ValueSetRef(ValueSetRef valueSetRef, ExpressionBuilderContext ctx)
        {
            if (string.IsNullOrWhiteSpace(valueSetRef.name))
                throw ctx.NewExpressionBuildingException($"The ValueSetRef at {valueSetRef.locator} is missing a name.");
            var type = _typeManager.TypeFor(valueSetRef, ctx)!;
            var cqlValueSet = InvokeDefinitionThroughRuntimeContext(valueSetRef.name, valueSetRef.libraryName, typeof(CqlValueSet), ctx);

            if (IsOrImplementsIEnumerableOfT(type))
            {
                var elementType = _typeManager.Resolver.GetListElementType(type);
                if (elementType != typeof(CqlCode))
                {
                    throw ctx.NewExpressionBuildingException($"The expected type for value set {valueSetRef.name} in this context is {TypeManager.PrettyTypeName(type)}");
                }

                var @new = CallCreateValueSetFacade(ctx, cqlValueSet);
                return @new;
            }
            return cqlValueSet;
        }

        protected Expression QueryLetRef(QueryLetRef qlre, ExpressionBuilderContext ctx)
        {
            var name = qlre.name!;
            var expr = ctx.GetScopeExpression(name);
            return expr;
        }

        protected Expression AliasRef(AliasRef ar, ExpressionBuilderContext ctx)
        {
            var expr = ctx.GetScopeExpression(ar.name!);
            return expr;
        }

        protected Expression Tuple(elm.Tuple tuple, ExpressionBuilderContext ctx)
        {
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
                                   var value = TranslateExpression(element.value!, ctx);
                                   var memberInfo = GetProperty(tupleType, ExpressionBuilderContext.NormalizeIdentifier(element.name!)!) 
                                                    ?? throw ctx.NewExpressionBuildingException($"Could not find member {element} on type {TypeManager.PrettyTypeName(tupleType!)}");
                                   var binding = Binding(value, memberInfo, ctx);
                                   return binding;
                               })
                               .ToArray();
                var init = Expression.MemberInit(@new, elementBindings);
                return init;
            }
            else return @new;
        }

        protected Expression List(List list, ExpressionBuilderContext ctx)
        {
            if (list.resultTypeSpecifier == null)
                throw ctx.NewExpressionBuildingException($"List is missing a result type specifier.");
            if (list.resultTypeSpecifier is elm.ListTypeSpecifier listTypeSpecifier)
            {

                var elementType = _typeManager.TypeFor(listTypeSpecifier.elementType, ctx);
                var elements = list.element?
                    .Select(ele => TranslateExpression(ele, ctx))
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
                throw ctx.NewExpressionBuildingException($"List is the wrong type");

        }

        protected Expression CodeRef(CodeRef codeRef, ExpressionBuilderContext ctx)
        {
            if (string.IsNullOrWhiteSpace(codeRef.name))
                throw ctx.NewExpressionBuildingException("The code ref has no name.");

            var type = _typeManager.Resolver.ResolveType(codeRef.resultTypeName.Name) ?? throw ctx.NewExpressionBuildingException($"Unable to resolve type {codeRef.resultTypeName}");
            return InvokeDefinitionThroughRuntimeContext(codeRef.name, codeRef.libraryName, type!, ctx);
        }

        private Expression CodeSystemRef(CodeSystemRef codeSystemRef, ExpressionBuilderContext ctx)
        {
            if (string.IsNullOrWhiteSpace(codeSystemRef.name))
                throw ctx.NewExpressionBuildingException("The code system ref has no name.");
            
            var type = _typeManager.Resolver.CodeType.MakeArrayType();
            return InvokeDefinitionThroughRuntimeContext(codeSystemRef.name, codeSystemRef.libraryName, type!, ctx);
        }
        protected Expression ConceptRef(ConceptRef conceptRef, ExpressionBuilderContext ctx)
        {
            if (string.IsNullOrWhiteSpace(conceptRef.name))
                throw ctx.NewExpressionBuildingException("The concept ref has no name.");
            
            var type = _typeManager.Resolver.CodeType.MakeArrayType();
            return InvokeDefinitionThroughRuntimeContext(conceptRef.name, conceptRef.libraryName, type!, ctx);
        }

        protected Expression Instance(Instance ine, ExpressionBuilderContext ctx)
        {
            var instanceType = _typeManager.Resolver.ResolveType(ine.classType.Name!)
                ?? throw ctx.NewExpressionBuildingException($"Could not resolve type for '{ine.classType.Name!}'");

            if (IsEnum(instanceType))
            {
                // constructs like:
                // FHIR.RemittanceOutcome {value: 'complete'}
                // FHIR.RemittanceOutcome maps to an enum type
                if (ine.element?.Length == 1 && string.Equals(ine.element![0].name, "value", StringComparison.OrdinalIgnoreCase))
                {
                    var enumValueValue = TranslateExpression(ine.element[0]!.value!, ctx);
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
                .Select(el => (el.name!, TranslateExpression(el.value!, ctx)))
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
                    unitExpr = ChangeType(unitExpr, typeof(string), ctx);

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
                    var memberInfo = GetProperty(instanceType!, element) ?? throw ctx.NewExpressionBuildingException($"Could not find member {element} on type {TypeManager.PrettyTypeName(instanceType!)}");
                    var binding = Binding(expression, memberInfo, ctx);
                    elementBindings[i] = binding;
                }
                var ctor = instanceType!.GetConstructor(Type.EmptyTypes)!;
                var @new = Expression.New(ctor);
                var init = Expression.MemberInit(@new, elementBindings);
                return init;
            }
        }

        protected MemberAssignment Binding(Expression value, MemberInfo memberInfo, ExpressionBuilderContext ctx)
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
                            var selectParameter = Expression.Parameter(valueEnumerableElement, TypeNameToIdentifier(value.Type, ctx));
                            var body = ChangeType(selectParameter, memberArrayElement, ctx);
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
                var convert = ChangeType(value, property.PropertyType, ctx);
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

        protected Expression If(If @if, ExpressionBuilderContext ctx)
        {
            var rc = TranslateExpression(@if.condition!, ctx);
            var condition = Expression.Coalesce(rc, Expression.Constant(false, typeof(bool)));
            var then = TranslateExpression(@if.then!, ctx);
            if (@if.@else != null)
            {
                var @else = TranslateExpression(@if.@else!, ctx);
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

        protected Expression Null(Null @null, ExpressionBuilderContext ctx)
        {
            var nullType = _typeManager.TypeFor(@null, ctx) ?? typeof(object);
            var constant = Expression.Constant(null, nullType);
            return constant;
        }

        protected Expression Literal(Literal lit, ExpressionBuilderContext ctx)
        {
            string message = $"Cannot resolve type for {lit.valueType}";
            var type = _typeManager.Resolver.ResolveType(lit.valueType.Name!) ?? throw ctx.NewExpressionBuildingException(message);
            var (value, convertedType) = ConvertLiteral(lit, type, ctx);

            if (type.IsNullable())
            {
                var changed = Expression.Constant(value, convertedType);
                var asNullable = Expression.Convert(changed, type);
                return asNullable;
            }
            return Expression.Constant(value, convertedType);
        }

        private static (object?, Type) ConvertLiteral(Literal lit, Type? type, ExpressionBuilderContext ctx)
        {
            if (type == null)
                throw new NotImplementedException().WithContext(ctx);
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

        protected Expression OperandRef(OperandRef ore, ExpressionBuilderContext ctx)
        {
            if (ctx.Operands.TryGetValue(ore.name!, out var expression))
                return expression;
            else throw ctx.NewExpressionBuildingException($"Operand reference to {ore.name} not found in definition operands.");
        }

        protected Expression Case(Case ce, ExpressionBuilderContext ctx)
        {

            //[{ when1, then1 }, { when2, then2}, { when3, then3 }]
            // when1 ? then 1 : (when2 ? then 2 : (when3 ? then 3 : else }
            if (ce.caseItem?.Length > 0 && ce.@else != null)
            {
                var elseThen = TranslateExpression(ce.@else!, ctx);
                var cases = new List<CaseWhenThenExpression.WhenThenCase>();

                if (ce.comparand != null)
                {
                    var comparand = TranslateExpression(ce.comparand, ctx);

                    foreach (var caseItem in ce.caseItem)
                    {
                        var caseWhen = TranslateExpression(caseItem.when!, ctx);
                        var caseWhenEquality = Expression.Coalesce(Equal(comparand, caseWhen, ctx), Expression.Constant(false));
                        var caseThen = TranslateExpression(caseItem.then!, ctx);

                        if (caseThen.Type != elseThen.Type)
                            caseThen = Expression.Convert(caseThen, elseThen.Type);

                        cases.Add(new(caseWhenEquality, caseThen));
                    }
                }
                else
                {
                    foreach (var caseItem in ce.caseItem)
                    {
                        var caseWhen = TranslateExpression(caseItem.when!, ctx);
                        var caseThen = TranslateExpression(caseItem.then!, ctx);

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

        private Expression Retrieve(Retrieve retrieve, ExpressionBuilderContext ctx)
        {
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
                    var valueSet = InvokeDefinitionThroughRuntimeContext(valueSetRef.name!, valueSetRef!.libraryName, typeof(CqlValueSet), ctx);
                    var call = ctx.OperatorBinding.Bind(CqlOperator.Retrieve, ctx.RuntimeContextParameter,
                        Expression.Constant(sourceElementType, typeof(Type)), valueSet, codeProperty!);
                    return call;
                }
                else
                {
                    // In this construct, instead of querying a value set, we're testing resources
                    // against a list of codes, e.g., as defined by the code from or codesystem construct
                    var codes = TranslateExpression(retrieve.codes, ctx);
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

        protected Expression Property(Property op, ExpressionBuilderContext ctx)
        {
            if (string.IsNullOrWhiteSpace(op.path))
                throw ctx.NewExpressionBuildingException("path cannot be null or empty");
            //var path = ExpressionBuilderContext.NormalizeIdentifier(op.path);
            var path = op.path;
            if (!string.IsNullOrWhiteSpace(op.scope))
            {
                var scopeExpression = ctx.GetScopeExpression(op.scope!);
                var expectedType = _typeManager.TypeFor(op, ctx) ?? typeof(object);
                var pathMemberInfo = _typeManager.Resolver.GetProperty(scopeExpression.Type, path!) ??
                    _typeManager.Resolver.GetProperty(scopeExpression.Type, op.path);
                if (pathMemberInfo == null)
                {
                    _logger.LogWarning(ctx.FormatMessage($"Property {op.path} can't be known at design time, and will be late-bound, slowing performance.  Consider casting the source first so that this property can be definitely bound.", op));
                    var call = ctx.OperatorBinding.Bind(CqlOperator.LateBoundProperty, ctx.RuntimeContextParameter,
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
                var resultType = _typeManager.TypeFor(op, ctx) ?? throw ctx.NewExpressionBuildingException(message);
                if (resultType != propogate.Type)
                {
                    propogate = ChangeType(propogate, resultType, ctx);
                }
                return propogate;
            }
            else if (op.source != null)
            {
                var source = TranslateExpression(op.source, ctx);
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
                    var expectedType = _typeManager.TypeFor(op, ctx)!;
                    var result = PropertyHelper(source, path, expectedType, ctx);
                    return result;
                }
            }
            else throw new NotImplementedException().WithContext(ctx);
        }

        protected Expression PropertyHelper(Expression source, string? path, Type expectedType, ExpressionBuilderContext ctx)
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
                            ifIs = ChangeType(ifIs, expectedType!, ctx);
                        }
                        if (expectedType != elseNull.Type)
                            elseNull = ChangeType(elseNull, expectedType, ctx);
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
                result = ChangeType(result, expectedType, ctx);
            }
            return result;
        }

        protected Expression FunctionRef(FunctionRef op, ExpressionBuilderContext ctx)
        {
            var operands = op.operand
                .Select(operand => TranslateExpression(operand, ctx))
                .ToArray();
            var operandTypes = operands
                .Select(op => op.Type);

            var functionType = GetFunctionRefReturnType(op, operandTypes, ctx);

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

            var invoke = InvokeDefinedFunctionThroughRuntimeContext(op.name!, op.libraryName!, funcType, operands, ctx);
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

        protected Type GetFunctionRefReturnType(FunctionRef op, IEnumerable<Type> operandTypes, ExpressionBuilderContext ctx)
        {
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
                if (DetermineFhirHelpersReturnType(op) is {} resolved) return resolved;
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

        protected Expression ExpressionRef(ExpressionRef expressionRef, ExpressionBuilderContext ctx)
        {
            Type? expressionType = null;
            if (expressionRef.resultTypeSpecifier != null)
            {
                expressionType = _typeManager.TypeFor(expressionRef.resultTypeSpecifier, ctx);
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
                    ctx = ctx.Deeper(def);
                    expressionType = _typeManager.TypeFor(def, ctx);
                }
                else throw new NotSupportedException("Unable to resolve expression reference type.");
            }

            if (expressionType == null)
                throw ctx.NewExpressionBuildingException($"Unable to determine type for {expressionRef.localId}");

            var invoke = InvokeDefinitionThroughRuntimeContext(expressionRef.name!, expressionRef.libraryName, expressionType, ctx);
            return invoke;
        }

        protected Expression ParameterRef(ParameterRef op, ExpressionBuilderContext ctx)
        {
            if (ctx.LibraryContext.Definitions.TryGetValue(ctx.LibraryContext.LibraryKey, op.name!, out var lambda) && lambda != null)
            {
                var invoke = InvokeDefinitionThroughRuntimeContext(op.name!, null, lambda, ctx);
                return invoke;
            }

            throw ctx.NewExpressionBuildingException($"Parameter {op.name} hasn't been defined yet.");
        }

        protected internal MemberInfo? GetProperty(Type type, string name)
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

            var member = _typeManager.Resolver.GetProperty(type, name);
            return member;
        }

        /// <param name="name">The function name</param>
        /// <param name="libraryAlias">If this is an external call, the local alias defined in the using statement</param>
        /// <param name="definitionType">The Func or Action type of this definition</param>
        /// <param name="arguments">The function arguments</param>
        /// <param name="ctx">The builder context.</param>
        /// <returns></returns>
        protected Expression InvokeDefinedFunctionThroughRuntimeContext(string name, string libraryAlias,
            Type definitionType,
            Expression[] arguments,
            ExpressionBuilderContext ctx)
        {
            var definitionsProperty = Expression.Property(ctx.RuntimeContextParameter, typeof(CqlContext).GetProperty(nameof(CqlContext.Definitions))!);

            string libraryName = ctx.LibraryContext.GetIncludeNameAndVersion(libraryAlias, throwError:false)
                ?? throw ctx.NewExpressionBuildingException($"Local library {libraryAlias} is not defined; are you missing a using statement?");

            return new FunctionCallExpression(definitionsProperty, libraryName, name, arguments, definitionType);
        }

        protected Expression InvokeDefinitionThroughRuntimeContext(
            string name, 
            string? libraryAlias,
            LambdaExpression definition,
            ExpressionBuilderContext ctx)
        {
            var type = definition.Type;
            if (type.IsGenericType)
            {
                var typeArgs = type.GetGenericArguments();
                var returnType = typeArgs[^1];
                var invoke = InvokeDefinitionThroughRuntimeContext(name, libraryAlias, returnType, ctx);
                return invoke;
            }
            else throw ctx.NewExpressionBuildingException("LambdaExpressions should be a variant of Func<>");
        }

        protected Expression InvokeDefinitionThroughRuntimeContext(
            string name, 
            string? libraryAlias,
            Type definitionReturnType,
            ExpressionBuilderContext ctx)
        {
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

        private Expression CrossJoin(AliasedQuerySource[] sources, Type tupleType, ExpressionBuilderContext ctx)
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

            if (sources.Length < 2) throw ctx.NewExpressionBuildingException($"This method should only be called for 2 or more query sources");

            // the first pair are special as they are not working off of a partially built tuple,
            // they are working only off of the initial selectmany parameters.
            var first = sources[0];
            var firstExpression = TranslateExpression(first.expression!, ctx);
            var firstElementType = _typeManager.Resolver.GetListElementType(firstExpression.Type)!;
            var second = sources[1];
            var secondExpression = TranslateExpression(second.expression!, ctx);
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

                    var sourceExpression = TranslateExpression(source.expression!, ctx);
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
                var genericTypeNames = string.Join("_", type.GetGenericArguments().Select(t => TypeNameToIdentifier(t, null)));
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

            return ExpressionBuilderContext.NormalizeIdentifier(typeName!)!;
        }

        private static bool IsEnum(Type type)
        {
            if (type.IsEnum)
                return true;
            else if (type.IsNullable() && (Nullable.GetUnderlyingType(type)?.IsEnum ?? false))
                return true;
            return false;
        }

        internal MethodCallExpression CallCreateValueSetFacade(ExpressionBuilderContext ctx, Expression operand)
        {
            var operatorsProperty = typeof(CqlContext).GetProperty(nameof(CqlContext.Operators))!;
            var createFacadeMethod = typeof(ICqlOperators).GetMethod(nameof(ICqlOperators.CreateValueSetFacade))!;
            var property = Expression.Property(ctx.RuntimeContextParameter, operatorsProperty);
            var call = Expression.Call(property, createFacadeMethod, operand);

            return call;
        }
    }
}