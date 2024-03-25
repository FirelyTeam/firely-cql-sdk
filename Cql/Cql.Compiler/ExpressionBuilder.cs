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
using Hl7.Cql.Operators;
using elm = Hl7.Cql.Elm;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler
{
    partial class ExpressionBuilder
    {
        // Yeah, hardwired to FHIR 4.0.1 for now.
        private static readonly IDictionary<string, ClassInfo> ModelMapping = Models.ClassesById(Models.Fhir401);

        private readonly ILogger<ExpressionBuilder> _logger = null!;

        internal Expression TranslateExpression(Element op)
        {
            using var _ = PushElement(op);

            Expression? expression;
            switch (op)
            {
                case Abs abs:
                    expression = Abs(abs);
                    break;
                case Add add:
                    expression = Add(add);
                    break;
                case After after:
                    expression = After(after);
                    break;
                case AliasRef ar:
                    expression = AliasRef(ar);
                    break;
                case AllTrue alt:
                    expression = AllTrue(alt);
                    break;
                case And and:
                    expression = And(and);
                    break;
                case As @as:
                    expression = As(@as);
                    break;
                case AnyTrue ate:
                    expression = AnyTrue(ate);
                    break;
                case AnyInValueSet avs:
                    expression = AnyInValueSet(avs);
                    break;
                case Avg avg:
                    expression = Avg(avg);
                    break;
                case Before before:
                    expression = Before(before);
                    break;
                case CalculateAgeAt caa:
                    expression = CalculateAgeAt(caa);
                    break;
                case CalculateAge ca:
                    expression = CalculateAge(ca);
                    break;
                case Case ce:
                    expression = Case(ce);
                    break;
                case Ceiling ceil:
                    expression = Ceiling(ceil);
                    break;
                case Coalesce cle:
                    expression = Coalesce(cle);
                    break;
                case CodeRef cre:
                    expression = CodeRef(cre);
                    break;
                case CodeSystemRef csr:
                    expression = CodeSystemRef(csr);
                    break;
                case Collapse col:
                    expression = Collapse(col);
                    break;
                case Combine com:
                    expression = Combine(com);
                    break;
                case Concatenate cctn:
                    expression = Concatenate(cctn);
                    break;
                case ConceptRef cr:
                    expression = ConceptRef(cr);
                    break;
                case Contains ct:
                    expression = Contains(ct);
                    break;
                case ConvertQuantity cqe:
                    expression = ConvertQuantity(cqe);
                    break;
                case ConvertsToBoolean ce:
                    expression = ConvertsToBoolean(ce);
                    break;
                case ConvertsToDate ce:
                    expression = ConvertsToDate(ce);
                    break;
                case ConvertsToDateTime ce:
                    expression = ConvertsToDateTime(ce);
                    break;
                case ConvertsToDecimal ce:
                    expression = ConvertsToDecimal(ce);
                    break;
                case ConvertsToLong ce:
                    expression = ConvertsToLong(ce);
                    break;
                case ConvertsToInteger ce:
                    expression = ConvertsToInteger(ce);
                    break;
                case ConvertsToQuantity ce:
                    expression = ConvertsToQuantity(ce);
                    break;
                case ConvertsToString ce:
                    expression = ConvertsToString(ce);
                    break;
                case ConvertsToTime ce:
                    expression = ConvertsToTime(ce);
                    break;
                case Count ce:
                    expression = Count(ce);
                    break;
                case DateFrom dfe:
                    expression = DateFrom(dfe);
                    break;
                case elm.DateTime dt:
                    expression = DateTime(dt);
                    break;
                case Date d:
                    expression = Date(d);
                    break;
                case DateTimeComponentFrom dtcf:
                    expression = DateTimeComponentFrom(dtcf);
                    break;
                case Descendents desc:
                    expression = Descendents(desc);
                    break;
                case DifferenceBetween dbe:
                    expression = DifferenceBetween(dbe);
                    break;
                case Distinct distinct:
                    expression = Distinct(distinct);
                    break;
                case Divide divide:
                    expression = Divide(divide);
                    break;
                case DurationBetween dbe:
                    expression = DurationBetween(dbe);
                    break;
                case End e:
                    expression = End(e);
                    break;
                case Ends e:
                    expression = Ends(e);
                    break;
                case EndsWith e:
                    expression = EndsWith(e);
                    break;
                case Equal eq:
                    expression = Equal(eq);
                    break;
                case Equivalent eqv:
                    expression = Equivalent(eqv);
                    break;
                case Except ex:
                    expression = Except(ex);
                    break;
                case Exists ex:
                    expression = Exists(ex);
                    break;
                case Exp exe:
                    expression = Exp(exe);
                    break;
                case Expand expand:
                    expression = Expand(expand);
                    break;
                case ExpandValueSet evs:
                    expression = ExpandValueSet(evs);
                    break;
                case FunctionRef fre:
                    expression = FunctionRef(fre);
                    break;
                case ExpressionRef ere:
                    expression = ExpressionRef(ere);
                    break;
                case First first:
                    expression = First(first);
                    break;
                case Flatten fl:
                    expression = Flatten(fl);
                    break;
                case Floor floor:
                    expression = Floor(floor);
                    break;
                case GeometricMean gme:
                    expression = GeometricMean(gme);
                    break;
                case Greater gtr:
                    expression = Greater(gtr);
                    break;
                case GreaterOrEqual gtre:
                    expression = GreaterOrEqual(gtre);
                    break;
                case HighBoundary hb:
                    expression = HighBoundary(hb);
                    break;
                case IdentifierRef ire:
                    expression = IdentifierRef(ire);
                    break;
                case If @if:
                    expression = If(@if);
                    break;
                case Implies implies:
                    expression = Implies(implies);
                    break;
                case Includes inc:
                    expression = Includes(inc);
                    break;
                case IncludedIn ii:
                    expression = IncludedIn(ii);
                    break;
                case Indexer idx:
                    expression = Indexer(idx);
                    break;
                case IndexOf io:
                    expression = IndexOf(io);
                    break;
                case Instance ine:
                    expression = Instance(ine);
                    break;
                case Intersect ise:
                    expression = Intersect(ise);
                    break;
                case Interval ie:
                    expression = IntervalExpression(ie);
                    break;
                case InValueSet inv:
                    expression = InValueSet(inv);
                    break;
                case In @in:
                    expression = In(@in);
                    break;
                case Is @is:
                    expression = Is(@is);
                    break;
                case IsFalse isn:
                    expression = IsFalse(isn);
                    break;
                case IsNull isn:
                    expression = IsNull(isn);
                    break;
                case IsTrue isn:
                    expression = IsTrue(isn);
                    break;
                case Last last:
                    expression = Last(last);
                    break;
                case LastPositionOf lpo:
                    expression = LastPositionOf(lpo);
                    break;
                case Length len:
                    expression = Length(len);
                    break;
                case Less less:
                    expression = Less(less);
                    break;
                case LessOrEqual lesse:
                    expression = LessOrEqual(lesse);
                    break;
                case List list:
                    expression = List(list);
                    break;
                case Literal lit:
                    expression = Literal(lit);
                    break;
                case Ln ln:
                    expression = Ln(ln);
                    break;
                case Log log:
                    expression = Log(log);
                    break;
                case LowBoundary lb:
                    expression = LowBoundary(lb);
                    break;
                case Lower e:
                    expression = Lower(e);
                    break;
                case Matches e:
                    expression = Matches(e);
                    break;
                case Max max:
                    expression = Max(max);
                    break;
                case MaxValue max:
                    expression = MaxValue(max);
                    break;
                case Median med:
                    expression = Median(med);
                    break;
                case Meets meets:
                    expression = Meets(meets);
                    break;
                case MeetsBefore meets:
                    expression = MeetsBefore(meets);
                    break;
                case MeetsAfter meets:
                    expression = MeetsAfter(meets);
                    break;
                case Message msg:
                    expression = Message(msg);
                    break;
                case Min min:
                    expression = Min(min);
                    break;
                case MinValue min:
                    expression = MinValue(min);
                    break;
                case Mode mode:
                    expression = Mode(mode);
                    break;
                case Modulo mod:
                    expression = Modulo(mod);
                    break;
                case Multiply mul:
                    expression = Multiply(mul);
                    break;
                case Negate neg:
                    expression = Negate(neg);
                    break;
                case Not not:
                    expression = Not(not);
                    break;
                case NotEqual ne:
                    expression = NotEqual(ne);
                    break;
                case Now now:
                    expression = Now(now);
                    break;
                case Null @null:
                    expression = Null(@null);
                    break;
                case OperandRef ore:
                    expression = OperandRef(ore);
                    break;
                case Or or:
                    expression = Or(or);
                    break;
                case Overlaps ole:
                    expression = Overlaps(ole);
                    break;
                case OverlapsAfter ola:
                    expression = OverlapsAfter(ola);
                    break;
                case OverlapsBefore olb:
                    expression = OverlapsBefore(olb);
                    break;
                case ParameterRef pre:
                    expression = ParameterRef(pre);
                    break;
                case PointFrom pf:
                    expression = PointFrom(pf);
                    break;
                case PopulationStdDev pstd:
                    expression = PopulationStdDev(pstd);
                    break;
                case PopulationVariance pvar:
                    expression = PopulationVariance(pvar);
                    break;
                case PositionOf po:
                    expression = PositionOf(po);
                    break;
                case Power pow:
                    expression = Power(pow);
                    break;
                case Precision pre:
                    expression = Precision(pre);
                    break;
                case Predecessor prd:
                    expression = Predecessor(prd);
                    break;
                case Product prod:
                    expression = Product(prod);
                    break;
                case ProperContains pc:
                    expression = ProperContains(pc);
                    break;
                case ProperIn pi:
                    expression = ProperIn(pi);
                    break;
                case ProperIncludes pi:
                    expression = ProperIncludes(pi);
                    break;
                case ProperIncludedIn pie:
                    expression = ProperIncludedIn(pie);
                    break;
                case Property pe:
                    expression = Property(pe);
                    break;
                case Quantity qua:
                    expression = Quantity(qua);
                    break;
                case Query qe:
                    expression = Query(qe);
                    break;
                case QueryLetRef qlre:
                    expression = QueryLetRef(qlre);
                    break;
                case Ratio re:
                    expression = Ratio(re);
                    break;
                case ReplaceMatches e:
                    expression = ReplaceMatches(e);
                    break;
                case Retrieve re:
                    expression = Retrieve(re);
                    break;
                case Round rnd:
                    expression = Round(rnd);
                    break;
                case SameAs sa:
                    expression = SameAs(sa);
                    break;
                case SameOrAfter soa:
                    expression = SameOrAfter(soa);
                    break;
                case SameOrBefore sob:
                    expression = SameOrBefore(sob);
                    break;
                case SingletonFrom sf:
                    expression = SingletonFrom(sf);
                    break;
                case Slice slice:
                    expression = Slice(slice);
                    break;
                case Split split:
                    expression = Split(split);
                    break;
                case Substring e:
                    expression = Substring(e);
                    break;
                case Subtract sub:
                    expression = Subtract(sub);
                    break;
                case Successor suc:
                    expression = Successor(suc);
                    break;
                case Sum sum:
                    expression = Sum(sum);
                    break;
                case Starts starts:
                    expression = Starts(starts);
                    break;
                case Start start:
                    expression = Start(start);
                    break;
                case StartsWith e:
                    expression = StartsWith(e);
                    break;
                case StdDev stddev:
                    expression = StdDev(stddev);
                    break;
                case Time time:
                    expression = Time(time);
                    break;
                case TimeOfDay tod:
                    expression = TimeOfDay(tod);
                    break;
                case TimezoneOffsetFrom tofe:
                    expression = TimezoneOffsetFrom(tofe);
                    break;
                case ToBoolean e:
                    expression = ToBoolean(e);
                    break;
                case ToConcept tc:
                    expression = ToConcept(tc);
                    break;
                case ToDateTime tdte:
                    expression = ToDateTime(tdte);
                    break;
                case ToDate tde:
                    expression = ToDate(tde);
                    break;
                case Today today:
                    expression = Today(today);
                    break;
                case ToDecimal tde:
                    expression = ToDecimal(tde);
                    break;
                case ToInteger tde:
                    expression = ToInteger(tde);
                    break;
                case ToList tle:
                    expression = ToList(tle);
                    break;
                case ToLong toLong:
                    expression = ToLong(toLong);
                    break;
                case ToQuantity tq:
                    expression = ToQuantity(tq);
                    break;
                case ToString e:
                    expression = ToString(e);
                    break;
                case ToTime e:
                    expression = ToTime(e);
                    break;
                case Truncate trunc:
                    expression = Truncate(trunc);
                    break;
                case TruncatedDivide div:
                    expression = TruncatedDivide(div);
                    break;
                case elm.Tuple tu:
                    expression = Tuple(tu);
                    break;
                case Union ue:
                    expression = Union(ue);
                    break;
                case ValueSetRef vsre:
                    expression = ValueSetRef(vsre);
                    break;
                case Variance variance:
                    expression = Variance(variance);
                    break;
                case Upper e:
                    expression = Upper(e);
                    break;
                case Width width:
                    expression = Width(width);
                    break;
                case Xor xor:
                    expression = Xor(xor);
                    break;
                default: throw this.NewExpressionBuildingException($"Expression {op.GetType().FullName} is not implemented.");
            }

            expression = Mutate(op, expression);
            return expression!;
        }

        protected Expression BinaryOperator(CqlOperator @operator, elm.BinaryExpression be)
        {
            var lhsExpression = TranslateExpression(be.operand![0]);
            var rhsExpression = TranslateExpression(be.operand![1]);
            var call = _operatorBinding.Bind(@operator, LibraryDefinitionsBuilder.ContextParameter, lhsExpression, rhsExpression);
            return call;
        }

        protected Expression UnaryOperator(CqlOperator @operator, elm.UnaryExpression unary)
        {
            var operand = TranslateExpression(unary.operand!);
            var resultType = unary.resultTypeSpecifier != null
                ? TypeFor(unary.resultTypeSpecifier)
                : null;
            var call = _operatorBinding.Bind(@operator, LibraryDefinitionsBuilder.ContextParameter, operand);
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
            var call = _operatorBinding.Bind(@operator, LibraryDefinitionsBuilder.ContextParameter, operators);
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
            var call = _operatorBinding.Bind(@operator, LibraryDefinitionsBuilder.ContextParameter, operand);
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

        protected Expression ValueSetRef(ValueSetRef valueSetRef)
        {
            if (string.IsNullOrWhiteSpace(valueSetRef.name))
                throw this.NewExpressionBuildingException($"The ValueSetRef at {valueSetRef.locator} is missing a name.");
            var type = TypeFor(valueSetRef)!;
            var cqlValueSet = InvokeDefinitionThroughRuntimeContext(valueSetRef.name, valueSetRef.libraryName, typeof(CqlValueSet));

            if (IsOrImplementsIEnumerableOfT(type))
            {
                var elementType = _typeManager.Resolver.GetListElementType(type);
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

        protected Expression Tuple(elm.Tuple tuple)
        {
            Type tupleType;
            if (tuple.resultTypeSpecifier is null)
            {
                tupleType = TupleTypeFor(tuple);
            }
            else
            {
                var tupleTypeSpecifier = (tuple.resultTypeSpecifier as elm.TupleTypeSpecifier) ?? throw this.NewExpressionBuildingException($"Tuple expression has a resultType that is not a TupleTypeSpecifier.");
                tupleType = TupleTypeFor(tupleTypeSpecifier);
            }

            var @new = Expression.New(tupleType);
            if (tuple.element?.Length > 0)
            {
                var elementBindings = (tuple.element!)
                               .Select(element =>
                               {
                                   var value = TranslateExpression(element.value!);
                                   var memberInfo = GetProperty(tupleType, NormalizeIdentifier(element.name!)!, _typeManager.Resolver)
                                                    ?? throw this.NewExpressionBuildingException($"Could not find member {element} on type {TypeManager.PrettyTypeName(tupleType!)}");
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
                            var callSelectMethod = _operatorBinding.Bind(CqlOperator.Select, LibraryDefinitionsBuilder.ContextParameter, value, selectLambda);
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
                var fromElement = _typeManager.Resolver.GetListElementType(from, @throw: true)!;
                var toElement = _typeManager.Resolver.GetListElementType(to, @throw: true)!;
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
                    throw this.NewExpressionBuildingException($"The If expression at {@if.locator} produces two branches with different types.");
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
                if (retrieve.resultTypeSpecifier is elm.ListTypeSpecifier listTypeSpecifier)
                {
                    cqlRetrieveResultType = listTypeSpecifier.elementType is elm.NamedTypeSpecifier nts ? nts.name.Name : null;
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
                    var valueSet = InvokeDefinitionThroughRuntimeContext(valueSetRef.name!, valueSetRef!.libraryName, typeof(CqlValueSet));
                    var call = _operatorBinding.Bind(CqlOperator.Retrieve, LibraryDefinitionsBuilder.ContextParameter,
                        Expression.Constant(sourceElementType, typeof(Type)), valueSet, codeProperty!);
                    return call;
                }
                else
                {
                    // In this construct, instead of querying a value set, we're testing resources
                    // against a list of codes, e.g., as defined by the code from or codesystem construct
                    var codes = TranslateExpression(retrieve.codes);
                    var call = _operatorBinding.Bind(CqlOperator.Retrieve, LibraryDefinitionsBuilder.ContextParameter,
                        Expression.Constant(sourceElementType, typeof(Type)), codes, codeProperty!);
                    return call;
                }
            }
            else
            {
                var call = _operatorBinding.Bind(CqlOperator.Retrieve, LibraryDefinitionsBuilder.ContextParameter,
                    Expression.Constant(sourceElementType, typeof(Type)), Expression.Constant(null, typeof(CqlValueSet)), codeProperty!);
                return call;
            }
        }

        protected Expression Property(Property op)
        {
            using var _ = PushElement(op);

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
                    var call = _operatorBinding.Bind(CqlOperator.LateBoundProperty, LibraryDefinitionsBuilder.ContextParameter,
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
                    var expectedType = TypeFor(op)!;
                    var result = PropertyHelper(source, path, expectedType);
                    return result;
                }
            }
            else throw new NotImplementedException().WithContext(this);
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
                    var call = _operatorBinding.Bind(CqlOperator.LateBoundProperty, LibraryDefinitionsBuilder.ContextParameter,
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
                        var bind = _operatorBinding.Bind(CqlOperator.Convert, LibraryDefinitionsBuilder.ContextParameter,

                            new[] { operands[0], Expression.Constant(typeof(string), typeof(Type)) });
                        return bind;
                    }
                }
            }
            // all functions still take the bundle and context parameters, plus whatver the operands
            // to the actual function are.
            operands = operands.Prepend(LibraryDefinitionsBuilder.ContextParameter).ToArray();

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

            // If that failed, try some hard-coded special cases from the FHIRHelpers
            if (op.libraryName?.StartsWith("FHIRHelpers") == true)
            {
                if (DetermineFhirHelpersReturnType(op) is { } resolved) return resolved;
            }

            // We failed....
            throw this.NewExpressionBuildingException($"Cannot determine type for function {op.libraryName ?? ""}.{op.name}");
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
            IDisposable pop = null!;
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
                    pop = PushElement(def);
                    expressionType = TypeFor(def);
                }
                else throw new NotSupportedException("Unable to resolve expression reference type.");
            }

            using var _2 = pop;

            if (expressionType == null)
                throw this.NewExpressionBuildingException($"Unable to determine type for {expressionRef.localId}");

            var invoke = InvokeDefinitionThroughRuntimeContext(expressionRef.name!, expressionRef.libraryName, expressionType);
            return invoke;
        }

        protected Expression ParameterRef(ParameterRef op)
        {
            if (LibraryContext.Definitions.TryGetValue(LibraryContext.LibraryKey, op.name!, out var lambda) && lambda != null)
            {
                var invoke = InvokeDefinitionThroughRuntimeContext(op.name!, null, lambda);
                return invoke;
            }

            throw this.NewExpressionBuildingException($"Parameter {op.name} hasn't been defined yet.");
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
            var definitionsProperty = Expression.Property(LibraryDefinitionsBuilder.ContextParameter, typeof(CqlContext).GetProperty(nameof(CqlContext.Definitions))!);

            string libraryName = LibraryContext.GetIncludeNameAndVersion(libraryAlias, throwError: false)
                ?? throw this.NewExpressionBuildingException($"Local library {libraryAlias} is not defined; are you missing a using statement?");

            return new FunctionCallExpression(definitionsProperty, libraryName, name, arguments, definitionType);
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

            string libraryName = LibraryContext.GetIncludeNameAndVersion(libraryAlias, throwError: false)
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

        private Expression CrossJoin(AliasedQuerySource[] sources, Type tupleType)
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

            if (sources.Length < 2) throw this.NewExpressionBuildingException($"This method should only be called for 2 or more query sources");

            // the first pair are special as they are not working off of a partially built tuple,
            // they are working only off of the initial selectmany parameters.
            var first = sources[0];
            var firstExpression = TranslateExpression(first.expression!);
            var firstElementType = _typeManager.Resolver.GetListElementType(firstExpression.Type)!;
            var second = sources[1];
            var secondExpression = TranslateExpression(second.expression!);
            var secondElementType = _typeManager.Resolver.GetListElementType(secondExpression.Type)!;

            var firstLambdaParameter = Expression.Parameter(firstElementType, $"_{first.alias}");
            var firstSelectManyParameter = Expression.Lambda(secondExpression, firstLambdaParameter);

            var secondLambdaParameter = Expression.Parameter(secondElementType, $"_{second.alias}");
            var @newTuple = Expression.New(tupleType);
            var memberInit = Expression.MemberInit(newTuple,
                Expression.Bind(tupleType.GetProperty(first.alias)!, firstLambdaParameter),
                Expression.Bind(tupleType.GetProperty(second.alias)!, secondLambdaParameter));
            var secondSelectManyParameter = Expression.Lambda(memberInit, firstLambdaParameter, secondLambdaParameter);

            var callSelectMany = _operatorBinding.Bind(CqlOperator.SelectManyResults, LibraryDefinitionsBuilder.ContextParameter,
                firstExpression,
                firstSelectManyParameter,
                secondSelectManyParameter);

            var enumerableOfTupleType = callSelectMany.Type;

            if (sources.Length > 2)
            {
                for (int i = 2; i < sources.Length; i++)
                {
                    var source = sources[i];

                    var sourceExpression = TranslateExpression(source.expression!);
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
                    @newTuple = Expression.New(tupleType);
                    memberInit = Expression.MemberInit(newTuple, bindings);
                    var p2 = Expression.Lambda(memberInit, ab, c);

                    var callAgain = _operatorBinding.Bind(CqlOperator.SelectManyResults, LibraryDefinitionsBuilder.ContextParameter,
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