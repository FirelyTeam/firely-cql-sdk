using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm
{
    internal record FunctionResolveResult(Expression Call, int Cost, string? Error)
    {
        public bool Success => Error is null;

        public static implicit operator Expression(FunctionResolveResult result)
        {
            if(result.Success)
                return result.Call;
            else
                throw new InvalidOperationException(result.Error);
        }
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
        private record ArgumentCaster(Expression Caster, int Cost, GenericParameterAssignments? Assignments, bool Success);

        public IModelProvider Provider { get; }
        public InvocationBuilder(IModelProvider provider)
        {
            Provider = provider;
        }

        public FunctionResolveResult Build(FunctionDef candidate, Expression[] arguments)
        {        
            if (candidate.operand.Length != arguments.Length)
            {
                var errorExpression = candidate.CreateElmNode(arguments).WithResultType(candidate.resultTypeSpecifier);
                return new(errorExpression, int.MaxValue, $"The number or arguments ({arguments.Length}) do not match the number of " +
                            $"parameters for {candidate.Signature()}.");
            }

            var genericReplacements = new GenericParameterAssignments();
            var testedHypotheses = new List<KeyValuePair<ParameterTypeSpecifier, TypeSpecifier>>();

            while(true)
            {
                var result = tryBuild(candidate, arguments, genericReplacements, out var resolution, out var hypothesis);

                if(result || hypothesis.Any() == false || hypothesis.All(testedHypotheses.Contains) )
                    return resolution;  // Final result, either success, or no more hypthesis to test

                testedHypotheses.AddRange(hypothesis);
                genericReplacements.Replace(hypothesis);
            }
        }

        private bool tryBuild(FunctionDef candidate, Expression[] arguments, GenericParameterAssignments genericReplacements, 
          out FunctionResolveResult result, out GenericParameterAssignments hypothesis)
        {
            // Make sure that the expression we return contains dummy placeholders with the right types.
            var argumentResults = arguments.Select(a => new ArgumentCaster(a, int.MaxValue, null, false)).ToArray();
            
            hypothesis = new GenericParameterAssignments();
            var newReplacements = new GenericParameterAssignments(genericReplacements.Concat(hypothesis));
            var totalCost = 0;
            string? error = null;

            int argumentIndex = 0;
            foreach (var operand in candidate.operand)
            {               
                var to = operand.operandTypeSpecifier;
                var argument = arguments[argumentIndex];

                // Now, try to implicitly cast the argument to the parameter type.
                var argumentResult = buildImplicitCast(argument, to, newReplacements);

                if (argumentResult.Success)
                {
                    if (argumentResult.Assignments?.Any() == true)
                    {
                        hypothesis.AddRange(argumentResult.Assignments);
                        newReplacements.AddRange(argumentResult.Assignments);
                    }

                    totalCost += argumentResult.Cost;
                    argumentResults[argumentIndex] = argumentResult;
                }
                else
                {
                    // Stop at the first error.
                    var errorCandidate = BuiltInFunctionDef.ReplaceGenericParameters(candidate, newReplacements.WithNullAsAny());
                    var errorTo = to.ReplaceGenericParameters(newReplacements);
                    error = $"Cannot resolve call to {errorCandidate.Signature()}, " + 
                        $"the {BuiltInFunctionDef.GetArgumentName(argumentIndex)} argument is of type {argument.resultTypeSpecifier} " +
                        $"which cannot implicitly be cast to type {errorTo}";
                    
                    if(argumentResult.Assignments?.Any() == true)
                        hypothesis.Replace(argumentResult.Assignments);
                    
                    break;
                }

                argumentIndex += 1;
            }

            var returnType = candidate.resultTypeSpecifier.ReplaceGenericParameters(newReplacements.WithNullAsAny());
            var resultExpression = candidate.CreateElmNode(argumentResults.Select(a => a.Caster).ToArray()).WithResultType(returnType);
            var success = argumentResults.All(a => a.Success);

            result = new(resultExpression, error is null ? totalCost : int.MaxValue, error);
            return success;
        }

        private ArgumentCaster buildImplicitCast(Expression argument, TypeSpecifier to, GenericParameterAssignments genericReplacements)
        {
            var argumentType = argument.resultTypeSpecifier;
            var locatorContext = new StringLocatorRuleContext(argument.locator);

            // Types are equal, or the argument is a subtype of the parameter type.
            if (argumentType.IsSubtypeOf(to, Provider))
                return new(argument, 0, null, true);

            // Untyped Nulls get promoted to any type necessary. If the target type has unbound
            // generic parameters, we will default those to a special "NullTypeSpecifier" that
            // we will replace by System.Any later on if no one cares to assign something more
            // permanent to it.
            // See https://cql.hl7.org/03-developersguide.html#implicit-casting
            if (argument is Null n)
            {
                var unbound = to.ReplaceGenericParameters(genericReplacements).GetGenericParameters().ToList();
                var newAssignments = new GenericParameterAssignments(
                    unbound.Select(gp => KeyValuePair.Create(gp, (TypeSpecifier)NullTypeSpecifier.Instance)));

                var bound = to.ReplaceGenericParameters(genericReplacements.WithNullAsAny())
                    .ReplaceGenericParameters(newAssignments.WithNullAsAny());
                var @as = SystemLibrary.As.Build(false, bound, n, locatorContext);
                return new(@as, 1, newAssignments.Any() ? newAssignments : null, true);
            }

            // If the parameter type is a generic type parameter, then we can assign any type to it,
            // unless it is already assigned to previously, in which case we need to check we can cast
            // to the assigned type for that generic type parameter.
            if (to is ParameterTypeSpecifier gtp)
            {
                if(genericReplacements.TryGetValue(gtp, out var assignedType))
                {
                    var intermediate = buildImplicitCast(argument, assignedType, genericReplacements);
                    if(intermediate.Success) 
                        return intermediate;
                    else
                    {
                        // We cannot cast this parameter to the current generic parameter assignment.
                        // Create a new suggestion for an assignment, and return failure. 
				        var hypothesis = new GenericParameterAssignments(gtp, argumentType);
                        return new(argument, int.MaxValue, hypothesis, false);
                    }
                }
                else
                    return new(argument, 0, new() {{gtp, argumentType}}, true);
            }

            // Casting a List<X> to a List<Y> is not possible in general(?), but it is
            // when Y is an unbound generic type or a direct (covariant) cast.
            if (argumentType is ListTypeSpecifier fromList && to is ListTypeSpecifier toList)
            {
                var prototypeInstance = new Literal { resultTypeSpecifier = fromList.elementType };
                var elementCast = buildImplicitCast(prototypeInstance, toList.elementType, genericReplacements);

                if (elementCast.Success && elementCast.Caster == prototypeInstance)
                    return new(argument, elementCast.Cost, elementCast.Assignments, true);
            }

            // Casting an Interval<X> to an Interval<Y> is not possible in general(?), but it is
            // when Y is an unbound generic type or a direct (covariant) cast.
            if (argumentType is IntervalTypeSpecifier fromInterval && to is IntervalTypeSpecifier toInterval)
            {
                var prototypeInstance = new Literal { resultTypeSpecifier = fromInterval.pointType };
                var elementCast = buildImplicitCast(prototypeInstance, toInterval.pointType, genericReplacements);

                if (elementCast.Success && elementCast.Caster == prototypeInstance)
                    return new(argument, elementCast.Cost, elementCast.Assignments, true);
            }

            // TODO: choice, https://cql.hl7.org/03-developersguide.html#choice-types

            // Implicit casts, see https://cql.hl7.org/03-developersguide.html#implicit-conversions
            // (note table is skewed, move first row 1 to the left, move row 2 2 to the left, etc)
            if (argumentType == SystemTypes.IntegerType && to == SystemTypes.LongType)
                return new(SystemLibrary.IntegerToLong.Build(locatorContext, argument), 1, null, true);
            if (argumentType == SystemTypes.IntegerType && to == SystemTypes.DecimalType)
                return new(SystemLibrary.IntegerToDecimal.Build(locatorContext, argument), 1, null, true);
            if (argumentType == SystemTypes.LongType && to == SystemTypes.DecimalType)
                return new(SystemLibrary.LongToDecimal.Build(locatorContext, argument), 1, null, true);
            if (argumentType == SystemTypes.IntegerType && to == SystemTypes.QuantityType)
                return new(SystemLibrary.IntegerToQuantity.Build(locatorContext, argument), 1, null, true);
            if (argumentType == SystemTypes.LongType && to == SystemTypes.QuantityType)
                return new(SystemLibrary.LongToQuantity.Build(locatorContext, argument), 1, null, true);
            if (argumentType == SystemTypes.DecimalType && to == SystemTypes.QuantityType)
                return new(SystemLibrary.DecimalToQuantity.Build(locatorContext, argument), 1, null, true);
            if (argumentType == SystemTypes.DateType && to == SystemTypes.DateTimeType)
                return new(SystemLibrary.DateToDateTime.Build(locatorContext, argument), 1, null, true);
            if (argumentType == SystemTypes.CodeType && to == SystemTypes.ConceptType)
                return new(SystemLibrary.CodeToConcept.Build(locatorContext, argument), 1, null, true);

            // TODO: There is still ValueSet to List, but it's not clear which function to call,
            // ToList<T>(T) would probably create a list with a single element, the valueset, but
            // that is not the intent.

            // TODO: interval promotion https://cql.hl7.org/03-developersguide.html#promotion-and-demotion

            // List demotion https://cql.hl7.org/03-developersguide.html#promotion-and-demotion
            if (argumentType is ListTypeSpecifier && to is not ListTypeSpecifier)
            {
                var singleton = SystemLibrary.SingletonFrom.Call(Provider, locatorContext, argument);
                var intermediate = buildImplicitCast(singleton, to, genericReplacements);
                return intermediate with { Cost = intermediate.Cost + 1 };
            }

            // TODO: interval demotion https://cql.hl7.org/03-developersguide.html#promotion-and-demotion

            // List promotion https://cql.hl7.org/03-developersguide.html#promotion-and-demotion
            if (argumentType is not ListTypeSpecifier && to is ListTypeSpecifier)
            {
                var list = SystemLibrary.ToList.Call(Provider,locatorContext, argument);
                var intermediate = buildImplicitCast(list, to, genericReplacements);
                return intermediate with { Cost = intermediate.Cost + 1 };
            }

            // No implicit cast found
            var dummy = new Null { resultTypeSpecifier = to };
            return new(dummy, int.MaxValue, null, false);
        }

    }
}

