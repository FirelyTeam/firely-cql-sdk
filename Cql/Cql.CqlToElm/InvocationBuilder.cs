using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm
{
    internal record ResolveResult<T>(T Result, int Cost, string? Error)
    {
        public bool Success => Error is null;

        public static ResolveResult<T>[] SelectBestCandidate(IEnumerable<ResolveResult<T>> candidates) =>
            candidates
              .OrderBy(r => r.Cost)
              .GroupBy(r => r.Cost)
              .First()
              .AsEnumerable().ToArray() ?? Array.Empty<ResolveResult<T>>();
    }

    /// <summary>
    /// Builds the implicit casts described in the CQL spec. Given the type of the parameter and an expression 
    /// representing the argument at the call site, this class will the necessary chain of nested expressions
    /// to implement the implicit casts.
    /// 
    /// See https://cql.hl7.org/03-developersguide.html#conversion-precedence
    /// </summary>
    internal class InvocationBuilder
    {
        private static readonly int ERROR_COST = 1000;  // Cost for a cast that is not possible.

        public IModelProvider Provider { get; }
        public InvocationBuilder(IModelProvider provider)
        {
            Provider = provider;
        }

        internal ResolveResult<Expression> Build(FunctionDef candidate, Expression[] arguments)
        {
            if (candidate is SystemFunction builtIn)
            {
                if (arguments.Length < (builtIn.RequiredParameterCount ?? builtIn.operand.Length))
                {
                    var resultExpression = candidate.CreateElmNode(arguments)
                        .WithResultType(candidate.resultTypeSpecifier);
                    return new ResolveResult<Expression>(resultExpression, ERROR_COST,
                        $"{candidate.Signature()} must be called with at least {builtIn.RequiredParameterCount} arguments, not {arguments.Length}.");
                }
                else if (arguments.Length > builtIn.operand.Length)
                {
                    var resultExpression = candidate.CreateElmNode(arguments)
                        .WithResultType(candidate.resultTypeSpecifier);
                    return new ResolveResult<Expression>(resultExpression, ERROR_COST,
                        $"{candidate.Signature()} must be called with no more than {builtIn.operand.Length} arguments, not {arguments.Length}.");
                }
            }
            else if (candidate.operand.Length != arguments.Length)
            {
                var resultExpression = candidate.CreateElmNode(arguments)
                    .WithResultType(candidate.resultTypeSpecifier);

                return new ResolveResult<Expression>(resultExpression, ERROR_COST,
                    $"{candidate.Signature()} must be called with {candidate.operand.Length} arguments, not {arguments.Length}.");
            }

            var operands = candidate.operand.Select(o => o.operandTypeSpecifier).ToArray();
            var positionResults = new List<ResolveResult<Expression>>();
            int? nextPosition = 0;

            while (nextPosition is not null)
            {
                var start = nextPosition.Value;
                nextPosition = null;
                var iterationResults = new ResolveResult<Expression>[arguments.Length];
                var assignments = new GenericParameterAssignments();
                string? firstError = null;

                for (var iteration = 0; iteration < arguments.Length; iteration++)
                {
                    var argumentIndex = (start + iteration) % arguments.Length;
                    var operand = operands[argumentIndex];
                    var argument = arguments[argumentIndex];

                    // Now, try to implicitly cast the argument to the parameter type.
                    var operandToTest = operand.ReplaceGenericParameters(assignments);
                    if (operandToTest != operand && argumentIndex > start && nextPosition is null) nextPosition = argumentIndex;

                    var argumentResult = BuildImplicitCast(argument, operandToTest, out var newAssignments);
                    assignments.AddRange(newAssignments);

                    if (!argumentResult.Success && firstError is null)
                        firstError = $"the {SystemFunction.GetArgumentName(argumentIndex)} argument {argumentResult.Error}.";

                    iterationResults[argumentIndex] = argumentResult;
                }

                var concreteCandidate = SystemFunction.ReplaceGenericParameters(candidate, assignments);
                var resultExpression = candidate.CreateElmNode(iterationResults.Select(a => a.Result).ToArray())
                        .WithResultType(concreteCandidate.resultTypeSpecifier);
                var totalCost = iterationResults.Sum(r => r.Cost);
                var totalError = firstError is not null ? $"Cannot resolve call to {concreteCandidate.Signature()}, {firstError}" : null;

                positionResults.Add(new(resultExpression, totalCost, totalError));
            }

            return ResolveResult<Expression>.SelectBestCandidate(positionResults).First();
        }

        /// <summary>
        /// Builds an expression that represents the implicit cast of the argument to the parameter type.
        /// </summary>
        /// <param name="argument">The expression to cast from.</param>
        /// <param name="to">The type to cast to.</param>
        /// <param name="newAssignments">If <paramref name="to"/> contains open generic parameters, this will contain the assignment parameters
        /// to actual types to make the conversion work.</param>
        /// <returns>A <see cref="ResolveResult{T}"/> that contains an Expression that casts the <paramref name="argument"/> to the type
        /// <paramref name="to"/>. If this is not possible, <see cref="ResolveResult{T}.Error"/> is not null and contains a description of the
        /// type error.</returns>
        public ResolveResult<Expression> BuildImplicitCast(
            Expression argument, TypeSpecifier to, out GenericParameterAssignments newAssignments)
        {
            var argumentType = argument.resultTypeSpecifier;
            var locatorContext = new StringLocatorRuleContext(argument.locator);

            // by default, we don't have a new hypothesis
            newAssignments = new();

            // Types are equal, or the argument is a subtype of the parameter type.
            if (argumentType.IsSubtypeOf(to, Provider))
                return new(argument, 0, null);

            // Untyped Nulls get promoted to any type necessary. If the target type has unbound
            // generic parameters, we will default those to a special "NullTypeSpecifier" that
            // we will replace by System.Any later on if no one cares to assign something more
            // permanent to it.
            // See https://cql.hl7.org/03-developersguide.html#implicit-casting
            if (argument is Null n)
            {
                var unbound = to.GetGenericParameters().ToList();

                newAssignments = new GenericParameterAssignments(
                    unbound.Select(gp => KeyValuePair.Create(gp, (TypeSpecifier)SystemTypes.AnyType)));

                var bound = to.ReplaceGenericParameters(newAssignments);
                var @as = SystemLibrary.As.Build(false, bound, n, locatorContext);

                // Make sure that we prefer any other solution than assigning
                // Any to a generic parameter to Any just to make a null argument fit
                // by giving it a high cost.
                return new(@as, unbound.Any() ? 100 : 1, null);
            }

            // If the parameter type is a generic type parameter, then we can assign any type to it,
            // unless it is already assigned to previously, in which case we need to check we can cast
            // to the assigned type for that generic type parameter.
            if (to is ParameterTypeSpecifier gtp)
            {
                newAssignments.Add(gtp, argumentType);
                return new(argument, 0, null);
            }

            // Casting a List<X> to a List<Y> is not possible in general(?), but it is
            // when Y is an unbound generic type or a direct (covariant) cast.
            if (to is ListTypeSpecifier toList)
            {
                if (argumentType is ListTypeSpecifier fromList)
                {
                    var toElement = toList.elementType;
                    var fromElement = fromList.elementType;
                    var sameDepth = true;
                    while (true)
                    {
                        if (toElement is ListTypeSpecifier t)
                        {
                            if (fromElement is ListTypeSpecifier f)
                            {
                                toElement = t.elementType;
                                fromElement = f.elementType;
                            }
                            else
                            {
                                sameDepth = false;
                                break;
                            }
                        }
                        else if (fromElement is ListTypeSpecifier)
                        {
                            sameDepth = false;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (sameDepth)
                    {
                        if (toElement is ParameterTypeSpecifier pts)
                        {
                            newAssignments.Add(pts, fromElement);
                            return new(argument, 0, null);
                        }
                        else if (fromElement.IsSubtypeOf(toElement, Provider))
                        {
                            return new(argument, 0, null);
                        }
                        else if (fromElement == SystemTypes.AnyType
                            && argument is List list
                            && (list.element?.Length ?? 0) == 0)
                        {
                            var @as = SystemLibrary.As.Build(false, to, argument, locatorContext);
                            return new(@as, 0, null);
                        }
                    }
                }
                // List promotion https://cql.hl7.org/03-developersguide.html#promotion-and-demotion
                else
                {
                    var list = SystemLibrary.ToList.Call(Provider, locatorContext, argument);
                    var intermediate = BuildImplicitCast(list, to, out newAssignments);
                    return intermediate with { Cost = intermediate.Cost + 5 };
                }

            }
            // Casting an Interval<X> to an Interval<Y> is not possible in general(?), but it is
            // when Y is an unbound generic type or a direct (covariant) cast.
            if (argumentType is IntervalTypeSpecifier fromInterval && to is IntervalTypeSpecifier toInterval)
            {
                var prototypeInstance = new Literal { resultTypeSpecifier = fromInterval.pointType };
                var elementCast = BuildImplicitCast(prototypeInstance, toInterval.pointType, out var nestedNewAssignments);

                if (elementCast.Success && elementCast.Result == prototypeInstance)
                {
                    newAssignments.AddRange(nestedNewAssignments);
                    return new(argument, elementCast.Cost, null);
                }
            }

            if (argumentType is ChoiceTypeSpecifier fromChoice)
            {
                if (to is not ChoiceTypeSpecifier)
                {
                    if (fromChoice.choice?.Contains(to) ?? false)
                        return new(argument, 0, null);
                }
            } 
            else if (to is ChoiceTypeSpecifier toChoice)
            {
                if (toChoice.choice?.Contains(argumentType) ?? false)
                {
                    var @as = SystemLibrary.As.Build(false, to, argument, locatorContext);
                    return new(@as.WithResultType(to), 0, null);
                }
            }

            // Implicit casts, see https://cql.hl7.org/03-developersguide.html#implicit-conversions
            // (note table is skewed, move first row 1 to the left, move row 2 2 to the left, etc)
            if (argumentType == SystemTypes.IntegerType && to == SystemTypes.LongType)
                return new(SystemLibrary.IntegerToLong.Build(locatorContext, argument), 1, null);
            if (argumentType == SystemTypes.IntegerType && to == SystemTypes.DecimalType)
                return new(SystemLibrary.IntegerToDecimal.Build(locatorContext, argument), 1, null);
            if (argumentType == SystemTypes.LongType && to == SystemTypes.DecimalType)
                return new(SystemLibrary.LongToDecimal.Build(locatorContext, argument), 1, null);
            if (argumentType == SystemTypes.IntegerType && to == SystemTypes.QuantityType)
                return new(SystemLibrary.IntegerToQuantity.Build(locatorContext, argument), 2, null);
            if (argumentType == SystemTypes.LongType && to == SystemTypes.QuantityType)
                return new(SystemLibrary.LongToQuantity.Build(locatorContext, argument), 2, null);
            if (argumentType == SystemTypes.DecimalType && to == SystemTypes.QuantityType)
                return new(SystemLibrary.DecimalToQuantity.Build(locatorContext, argument), 2, null);
            if (argumentType == SystemTypes.DateType && to == SystemTypes.DateTimeType)
                return new(SystemLibrary.DateToDateTime.Build(locatorContext, argument), 2, null);
            if (argumentType == SystemTypes.CodeType && to == SystemTypes.ConceptType)
                return new(SystemLibrary.CodeToConcept.Build(locatorContext, argument), 1, null);

            // TODO: There is still ValueSet to List, but it's not clear which function to call,
            // ToList<T>(T) would probably create a list with a single element, the valueset, but
            // that is not the intent.

            // TODO: interval promotion https://cql.hl7.org/03-developersguide.html#promotion-and-demotion

            // List demotion https://cql.hl7.org/03-developersguide.html#promotion-and-demotion
            if (argumentType is ListTypeSpecifier && to is not ListTypeSpecifier)
            {
                var singleton = SystemLibrary.SingletonFrom.Call(Provider, locatorContext, argument);
                var intermediate = BuildImplicitCast(singleton, to, out newAssignments);
                return intermediate with { Cost = intermediate.Cost + 5 };
            }

            // TODO: interval demotion https://cql.hl7.org/03-developersguide.html#promotion-and-demotion

            // No implicit cast found
            return new(argument, ERROR_COST, $"is of type {argumentType}, which cannot implicitly be cast to type {to}");
        }
    }
}

