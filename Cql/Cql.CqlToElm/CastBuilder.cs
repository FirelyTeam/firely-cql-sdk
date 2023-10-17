using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm
{
    internal record FunctionMatchResult(Expression[] Casters, int Cost, TypeSpecifier ReturnType, string? Error)
    {
        public bool Success => Error is null;
    }

    /// <summary>
    /// Builds the implicit casts described in the CQL spec. Given the type of the parameter and an expression 
    /// representing the argument at the call site, this class will the necessary chain of nested expressions
    /// to implement the implicit casts.
    /// 
    /// See https://cql.hl7.org/03-developersguide.html#conversion-precedence
    /// </summary>
    internal class CastBuilder
    {
        private record ArgumentCaster(Expression Caster, int Cost, GenericParameterAssignments? Assignments, string? Error)
        {
            public bool Success => Error is null;
        }

        public IModelProvider Provider { get; }
        public CastBuilder(IModelProvider provider)
        {
            Provider = provider;
        }

        public FunctionMatchResult Build(FunctionDef candidate, Expression[] arguments)
        {
            var genericReplacements = new GenericParameterAssignments();

            if (candidate.operand.Length != arguments.Length)
                return new(arguments, int.MaxValue, candidate.resultTypeSpecifier, $"Number or arguments should be the same as the number of parameters in the FunctionDef.");

            var argumentResults = new List<ArgumentCaster>();

            for (int ix = 0; ix < candidate.operand.Length; ix++)
            {
                var targetType = candidate.operand[ix].operandTypeSpecifier.ReplaceGenericParameters(genericReplacements);
                var argumentResult = buildArgumentCast(arguments[ix], targetType);

                if (!argumentResult.Success)
                    argumentResult = argumentResult with { Error = $"The {BuiltInFunctionDef.GetArgumentName(ix)} argument {argumentResult.Error}." };
                else
                {
                    if (argumentResult.Assignments is not null)
                        genericReplacements.AddRange(argumentResult.Assignments);
                }

                argumentResults.Add(argumentResult);
            }

            var error = argumentResults.FirstOrDefault(a => !a.Success)?.Error;
            var cost = argumentResults.Where(a => a.Success).Sum(a => a.Cost);

            return new(
                Casters: argumentResults.Select(a => a.Caster).ToArray(),
                Cost: cost,
                ReturnType: candidate.resultTypeSpecifier.ReplaceGenericParameters(genericReplacements),
                Error: error);
        }

        private ArgumentCaster buildArgumentCast(Expression argument, TypeSpecifier to)
        {
            var argumentType = argument.resultTypeSpecifier;
            var locatorContext = new StringLocatorRuleContext(argument.locator);

            // Types are equal, or the argument is a subtype of the parameter type.
            if (argumentType.IsSubtypeOf(to, Provider))
                return new(argument, 0, null, null);

            // If the parameter type is a generic type parameter, then we can assign any type to it,
            // unless it is already assigned to previously, in which case we need to check we can cast
            // to the assigned type for that generic type parameter.
            if (to is ParameterTypeSpecifier gtp)
                return new(argument, 0, new() { { gtp, argumentType } }, null);

            // Untyped Nulls get promoted to any type necessary. If the target type has unbound
            // generic parameters, we will default those to System.Any.
            // See https://cql.hl7.org/03-developersguide.html#implicit-casting
            if (argument is Null n && (n.resultTypeSpecifier is null || to.IsSubtypeOf(n.resultTypeSpecifier, Provider)))
            {
                var unbound = to.GetGenericParameters().ToList();
                var map = unbound.Any()
                    ? new GenericParameterAssignments(unbound.Select(gp => KeyValuePair.Create(gp, (TypeSpecifier)SystemTypes.AnyType)))
                    : null;

                if (map is not null)
                    to = to.ReplaceGenericParameters(map);

                var @as = SystemLibrary.As.Call(false, to, n, locatorContext);

                return new(@as, 1, map, null);
            }

            // Casting a List<X> to a List<Y> is not possible in general(?), but it is
            // when Y is an unbound generic type or a direct (covariant) cast is possible.
            if (argumentType is ListTypeSpecifier fromList && to is ListTypeSpecifier toList)
            {
                var prototypeInstance = new Null { resultTypeSpecifier = fromList.elementType };
                var elementCast = buildArgumentCast(prototypeInstance, toList.elementType);

                if (elementCast.Success && elementCast.Caster == prototypeInstance)
                    return new(argument, elementCast.Cost, elementCast.Assignments, null);
            }

            // Casting an Interval<X> to an Interval<Y> is not possible in general(?), but it is
            // when Y is an unbound generic type or a direct (covariant) cast is possible.
            if (argumentType is IntervalTypeSpecifier fromInterval && to is IntervalTypeSpecifier toInterval)
            {
                var prototypeInstance = new Null { resultTypeSpecifier = fromInterval.pointType };
                var elementCast = buildArgumentCast(prototypeInstance, toInterval.pointType);

                if (elementCast.Success && elementCast.Caster == prototypeInstance)
                    return new(argument, elementCast.Cost, elementCast.Assignments, null);
            }

            // TODO: choice, https://cql.hl7.org/03-developersguide.html#choice-types

            // Implicit casts, see https://cql.hl7.org/03-developersguide.html#implicit-conversions
            // (note table is skewed, move first row 1 to the left, move row 2 2 to the left, etc)
            if (argumentType == SystemTypes.IntegerType && to == SystemTypes.LongType)
                return new(SystemLibrary.IntegerToLong.Build(locatorContext, argument), 1, null, null);
            if (argumentType == SystemTypes.IntegerType && to == SystemTypes.DecimalType)
                return new(SystemLibrary.IntegerToDecimal.Build(locatorContext, argument), 1, null, null);
            if (argumentType == SystemTypes.LongType && to == SystemTypes.DecimalType)
                return new(SystemLibrary.LongToDecimal.Build(locatorContext, argument), 1, null, null);
            if (argumentType == SystemTypes.IntegerType && to == SystemTypes.QuantityType)
                return new(SystemLibrary.IntegerToQuantity.Build(locatorContext, argument), 1, null, null);
            if (argumentType == SystemTypes.LongType && to == SystemTypes.QuantityType)
                return new(SystemLibrary.LongToQuantity.Build(locatorContext, argument), 1, null, null);
            if (argumentType == SystemTypes.DecimalType && to == SystemTypes.QuantityType)
                return new(SystemLibrary.DecimalToQuantity.Build(locatorContext, argument), 1, null, null);
            if (argumentType == SystemTypes.DateType && to == SystemTypes.DateTimeType)
                return new(SystemLibrary.DateToDateTime.Build(locatorContext, argument), 1, null, null);
            if (argumentType == SystemTypes.CodeType && to == SystemTypes.ConceptType)
                return new(SystemLibrary.CodeToConcept.Build(locatorContext, argument), 1, null, null);

            // TODO: There is still ValueSet to List, but it's not clear which function to call,
            // ToList<T>(T) would probably create a list with a single element, the valueset, but
            // that is not the intent.

            // TODO: interval promotion https://cql.hl7.org/03-developersguide.html#promotion-and-demotion

            // List demotion https://cql.hl7.org/03-developersguide.html#promotion-and-demotion
            if (argumentType is ListTypeSpecifier && to is not ListTypeSpecifier)
            {
                var nested = SystemLibrary.SingletonFrom.Call(Provider, locatorContext, argument);
                if (nested.Success)
                {
                    var intermediate = buildArgumentCast(nested, to);
                    return intermediate with { Cost = intermediate.Cost + 1 };
                }
                else
                    return new(argument, int.MaxValue, null, nested.Error);
            }

            // TODO: interval demotion https://cql.hl7.org/03-developersguide.html#promotion-and-demotion

            // List promotion https://cql.hl7.org/03-developersguide.html#promotion-and-demotion
            if (argumentType is not ListTypeSpecifier && to is ListTypeSpecifier)
            {
                var nested = SystemLibrary.ToList.Call(Provider, locatorContext, argument);
                if (nested.Success)
                {
                    var intermediate = buildArgumentCast(nested, to);
                    return intermediate with { Cost = intermediate.Cost + 1 };
                }
                else
                    return new(argument, int.MaxValue, null, nested.Error);
            }

            // No cast found
            return new(argument, int.MaxValue, null, $"cannot implicitly be cast from {argumentType} to {to}");
        }

    }
}

