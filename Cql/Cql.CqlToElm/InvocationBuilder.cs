using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Hl7.Cql.CqlToElm
{


    /// <summary>
    /// Builds the implicit casts described in the CQL spec. Given the type of the parameter and an expression 
    /// representing the argument at the call site, this class will the necessary chain of nested expressions
    /// to implement the implicit casts.
    /// 
    /// See https://cql.hl7.org/03-developersguide.html#conversion-precedence
    /// </summary>
    internal class InvocationBuilder
    {
        public IModelProvider Provider { get; }
        public CoercionProvider CoercionProvider { get; }
        public ElmFactory ElmFactory { get; }
        public MessageProvider Messaging { get; }

        public InvocationBuilder(IModelProvider provider, 
            CoercionProvider coercionProvider, 
            ElmFactory elmFactory,
            MessageProvider messaging)
        {
            Provider = provider;
            CoercionProvider = coercionProvider;
            ElmFactory = elmFactory;
            Messaging = messaging;
        }

        /// <summary>
        /// Invokes a system function.
        /// </summary>
        /// <param name="systemFunction">The system function to invoke.</param>
        /// <param name="arguments">The arguments to invoke.</param>
        /// <returns>The invocation of this system function.</returns>
        internal Expression Invoke(SystemFunction systemFunction, params Expression[] arguments)
        {
            var result = MatchSignature(systemFunction, arguments);
            var newArguments = result.Arguments
                .Select(cr => cr.Result)
                .ToArray();
            var expression = ElmFactory.CreateElmNode(systemFunction, null, newArguments);
            if (!result.Compatible)
                expression.AddError(result.Error ?? Messaging.CouldNotResolveFunction(result.Function.name, arguments));
            expression = systemFunction.Validate(expression);
            var newResultType = ReplaceGenericType(systemFunction.resultTypeSpecifier, result.GenericInferences);
            return expression
                .WithResultType(newResultType);
        }

        /// <summary>
        /// Invokes an overloaded function.
        /// </summary>
        /// <param name="overloadedFunction">The overloaded function to invoke.</param>
        /// <param name="arguments">The arguments to invoke.</param>
        /// <returns>The invocation of the best-matching overload.</returns>
        internal Expression Invoke(OverloadedFunctionDef overloadedFunction, params Expression[] arguments)
        {
            var result = MatchSignature(overloadedFunction, arguments);
            var newArguments = result.Arguments
                .Select(cr => cr.Result)
                .ToArray();
            var expression = ElmFactory.CreateElmNode(result.Function, null, newArguments);
            if (!result.Compatible)
                expression.AddError(result.Error ?? Messaging.CouldNotResolveFunction(result.Function.name, arguments));
            if (result.Function is SystemFunction systemFunction)
                expression = systemFunction.Validate(expression);
            var newResultType = ReplaceGenericType(result.Function.resultTypeSpecifier, result.GenericInferences);
            return expression
                .WithResultType(newResultType);
        }

        /// <summary>
        /// Invokes a user defined function.
        /// </summary>
        /// <param name="function">The overloaded function to invoke.</param>
        /// <param name="library">The libary in which this function is defined, or <see langword="null"/> if the function is colocated within the same library as the invocation site.</param>
        /// <param name="arguments">The arguments to invoke.</param>
        /// <returns>The invocation of the best-matching overload.</returns>
        internal Expression Invoke(FunctionDef function, string? library, params Expression[] arguments)
        {
            var result = MatchSignature(function, arguments);
            var newArguments = result.Arguments
                .Select(cr => cr.Result)
                .ToArray();
            var expression = ElmFactory.CreateElmNode(function, null, newArguments);
            if (!result.Compatible)
                expression.AddError(result.Error ?? Messaging.CouldNotResolveFunction(result.Function.name, arguments));
            var newResultType = ReplaceGenericType(function.resultTypeSpecifier, result.GenericInferences);
            return expression
                .WithResultType(newResultType);
        }

        internal Expression Invoke(SignatureMatchResult result, string? library = null)
        {
            var args = result.Arguments.Select(arg => arg.Result).ToArray();
            if (result.Compatible)
            {
                if (result.Function is SystemFunction sysFunc)
                    return Invoke(sysFunc, args);
                else if (library is null)
                    throw new System.ArgumentException($"Library must be non-null when invoking a user defined function.", nameof(library));
                else
                    return Invoke(result.Function, library, args);
            }
            else
            {
                var expression = ElmFactory.CreateElmNode(result.Function, null, args);
                if (result.Error is not null)
                    expression.AddError(result.Error);
                else
                    expression.AddError(Messaging.CouldNotResolveFunction(result.Function.name, result.Arguments.Select(a=>a.Result).ToArray()));
                return expression;
            }
        }


        #region Generic inference

        private static readonly System.Collections.ObjectModel.ReadOnlyDictionary<string, TypeSpecifier> EmptyInferences = new(new Dictionary<string, TypeSpecifier>());

        internal SignatureMatchResult MatchSignature(FunctionDef candidate, params Expression[] arguments)
        {
            var operands = candidate.operand ?? Array.Empty<OperandDef>();
            var operandTypes = operands.Select(op => op.operandTypeSpecifier).ToArray();
            var flags = SignatureMatchFlags.None;
            int requiredArgumentCount = operands.Length;
            if (candidate is SystemFunction systemFunction && systemFunction.RequiredParameterCount.HasValue)
                requiredArgumentCount = Math.Min(systemFunction.RequiredParameterCount.Value, requiredArgumentCount);
            if (arguments.Length > operands.Length)
                flags |= SignatureMatchFlags.TooManyArguments;
            else if (arguments.Length < requiredArgumentCount)
                flags |= SignatureMatchFlags.TooFewArguments;
            if (flags > SignatureMatchFlags.None)
            {
                var conversionResults = arguments
                    .Select(arg => new CoercionResult<Expression>(arg, CoercionCost.ExactMatch))
                    .ToArray();
                return new SignatureMatchResult(candidate, conversionResults, EmptyInferences, flags);
            }
            // doing this to make debugging easier
            CoercionResult<Expression>[]? newOperands = null;
            IDictionary<string, TypeSpecifier>? genericInferences = null;
            var lowestCost = (int)CoercionCost.Incompatible;
            // For each argument, try to use it for inference.
            // As we go, keep track of which of those inferences results in the cheapest translation cost.
            for (int i = 0; i < arguments.Length; i++)
            {
                var argumentType = arguments[i].resultTypeSpecifier;
                var operandType = operands[i].operandTypeSpecifier;
                var inferences = InferGenericArgument(argumentType, operandType);
                if (inferences.Count > 0)
                {
                    var replaced = ReplaceGenericArguments(operandTypes, arguments, inferences);
                    var cost = replaced.Sum(operand => (int)operand.Cost);
                    //var cost = (CoercionCost)replaced.Max(operand => (int)operand.Cost);
                    if (cost < lowestCost)
                    {
                        lowestCost = cost;
                        newOperands = replaced;
                        genericInferences = inferences;
                    }
                }
            }
            if (newOperands != null && genericInferences != null)
                return new SignatureMatchResult(candidate, newOperands, genericInferences, flags);
            else
            {
                newOperands = new CoercionResult<Expression>[arguments.Length];
                for (int i = 0; i < arguments.Length; i++)
                {
                    newOperands[i] = CoercionProvider.Coerce(arguments[i], operandTypes[i]);
                }
                string? error = null;
                if (newOperands.Any(op => op.Cost == CoercionCost.Incompatible))
                    error = Messaging.CouldNotResolveFunction(candidate.name, arguments);
                return new SignatureMatchResult(candidate, newOperands, EmptyInferences, default, error);
            }
        }

        // At present we are not going to consider generics with mulitple type arguments, as those do not exist in any system functions.
        // We'll leave the type as Dictionary for now for future proofing
        internal Dictionary<string, TypeSpecifier> InferGenericArgument(TypeSpecifier argumentType, TypeSpecifier operandType)
        {
            // TODO: This feels very wrong.
            // But if we allow an argument of List<Integer> to be assigned to T, so many tests fail
            return operandType switch
            {
                ParameterTypeSpecifier generic
                    when argumentType is not ListTypeSpecifier && argumentType is not IntervalTypeSpecifier => new() { { generic.parameterName, argumentType } },
                ListTypeSpecifier opList
                    when argumentType is ListTypeSpecifier argList => InferNestedGeneric(opList.elementType, argList.elementType),
                ListTypeSpecifier opList
                    when argumentType is not ListTypeSpecifier => InferGenericArgument(argumentType, opList.elementType),
                IntervalTypeSpecifier opInt
                    when argumentType is IntervalTypeSpecifier argInt => InferNestedGeneric(opInt.pointType, argInt.pointType),
                IntervalTypeSpecifier opInt
                    when argumentType is not IntervalTypeSpecifier => InferGenericArgument(argumentType, opInt.pointType),
                _ => new()
            };
            Dictionary<string, TypeSpecifier> InferNestedGeneric(TypeSpecifier operandType, TypeSpecifier argumentType) =>
                operandType switch
                {
                    ParameterTypeSpecifier generic => new() { { generic.parameterName, argumentType } },
                    ListTypeSpecifier opList
                        when argumentType is ListTypeSpecifier argList => InferNestedGeneric(opList.elementType, argList.elementType),
                    ListTypeSpecifier opList
                        when argumentType is not ListTypeSpecifier => InferNestedGeneric(opList.elementType, argumentType),
                    IntervalTypeSpecifier opInt
                        when argumentType is IntervalTypeSpecifier argInt => InferNestedGeneric(opInt.pointType, argInt.pointType),
                    IntervalTypeSpecifier opInt
                        when argumentType is not IntervalTypeSpecifier => InferNestedGeneric(opInt.pointType, argumentType),
                    _ => new()
                };
        }

        internal CoercionResult<Expression>[] ReplaceGenericArguments(TypeSpecifier[] operandTypes,
            Expression[] arguments, IDictionary<string, TypeSpecifier> replacements)
        {
            var convertedArguments = new CoercionResult<Expression>[arguments.Length];
            for (int i = 0; i < arguments.Length; i++)
            {
                var argument = arguments[i];
                var operandType = operandTypes[i];
                convertedArguments[i] = ReplaceGenericArgument(operandType, argument, replacements);
            }
            return convertedArguments;
        }

        internal static TypeSpecifier ReplaceGenericType(TypeSpecifier type, IDictionary<string, TypeSpecifier> replacements)
        {
            if (type is ParameterTypeSpecifier generic)
            {
                if (replacements.TryGetValue(generic.parameterName, out var resolvedType))
                    return resolvedType;
                else throw new ArgumentException($"Generic type {generic.parameterName} does not have a replacement defined.", nameof(replacements));
            }
            else if (type is ListTypeSpecifier listType)
                return ReplaceGenericType(listType.elementType, replacements).ToListType();
            else if (type is IntervalTypeSpecifier intervalType)
                return ReplaceGenericType(intervalType.pointType, replacements).ToIntervalType();
            else return type;
        }

        internal CoercionResult<Expression> ReplaceGenericArgument(TypeSpecifier operandType, Expression argument, IDictionary<string, TypeSpecifier> replacements)
        {
            var newType = ReplaceGenericType(operandType, replacements);
            var conversion = CoercionProvider.Coerce(argument, newType);
            return conversion;
        }

        /// <summary>
        /// Picks the function which has the lowest total cost in converting its operands to be compatible with the invocation.
        /// </summary>
        internal SignatureMatchResult MatchSignature(OverloadedFunctionDef overloadedFunction, params Expression[] arguments)
        {
            var matches = overloadedFunction.Functions
                .Select(function => MatchSignature(function, arguments))
                .ToArray();
            var byCost = matches
                .Where(result => result.Compatible)
                .GroupBy(result => result.TotalCost)
                .OrderBy(group => group.Key)
                .ToArray();
            if (byCost.Length > 0)
            {
                var cheapest = byCost[0].ToArray();
                if (cheapest.Length == 1)
                {
                    return cheapest[0];
                }
                else if (cheapest.Length > 0)
                {
                    var argTypeString = string.Join(", ", arguments.Select(a => a.resultTypeSpecifier.ToString()));
                    // match cql-to-elm reference implementation (Java) error messages
                    var errorSb = new StringBuilder();
                    errorSb.AppendLine(CultureInfo.InvariantCulture, $"Call to operator {overloadedFunction.Name}({argTypeString}) is ambiguous with:");
                    foreach (var match in cheapest)
                    {
                        var matchTypeString = string.Join(", ", match.Arguments.Select(od => od.Result.resultTypeSpecifier.ToString()));
                        errorSb.AppendLine(CultureInfo.InvariantCulture, $"\t- {overloadedFunction.Name}({matchTypeString})");
                    }
                    return new(cheapest[0].Function,
                        cheapest[0].Arguments,
                        cheapest[0].GenericInferences,
                        cheapest[0].Flags | SignatureMatchFlags.Ambiguous,
                        errorSb.ToString());
                }
            }
            var firstMatch = matches[0];
            var result = new SignatureMatchResult(firstMatch.Function,
                firstMatch.Arguments,
                firstMatch.GenericInferences,
                firstMatch.Flags,
                Messaging.CouldNotResolveFunction(firstMatch.Function.name, arguments));
            return result;
        }


        #endregion
    }


}

