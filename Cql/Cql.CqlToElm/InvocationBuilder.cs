using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
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
            {
                return expression
                    .AddError(result.Error() ?? Messaging.CouldNotResolveFunction(result.Function.Name, arguments))
                    .WithResultType(SystemTypes.AnyType);
            }
            else
            {
                expression = systemFunction.Validate(expression);
                var newResultType = ReplaceGenericType(systemFunction.resultTypeSpecifier, result.GenericInferences);
                return expression
                    .WithResultType(newResultType);
            }
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
                expression.AddError(result.Error() ?? Messaging.CouldNotResolveFunction(result.Function.Name, arguments));
            if (result.Function is SystemFunction systemFunction)
                expression = systemFunction.Validate(expression);
            var newResultType = ReplaceGenericType(result.Function.ResultTypeSpecifier, result.GenericInferences);
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
        internal Expression Invoke(IHasSignature function, string? library, params Expression[] arguments)
        {
            if (function is SystemFunction systemFunction && systemFunction.Invoker is not null)
                return systemFunction.Invoker(this, arguments);
            var result = MatchSignature(function, arguments);
            var newArguments = result.Arguments
                .Select(cr => cr.Result)
                .ToArray();
            var expression = ElmFactory.CreateElmNode(function, null, newArguments);
            if (!result.Compatible)
                expression.AddError(result.Error() ?? Messaging.CouldNotResolveFunction(result.Function.Name, arguments));
            var newResultType = ReplaceGenericType(function.ResultTypeSpecifier, result.GenericInferences);
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
                if (!result.Compatible)
                    expression.AddError(result.Error() ?? Messaging.CouldNotResolveFunction(result.Function.Name, result.Arguments.Select(a => a.Result).ToArray()));
                return expression;
            }
        }


        #region Generic inference

        private static readonly System.Collections.ObjectModel.ReadOnlyDictionary<string, TypeSpecifier> EmptyInferences = new(new Dictionary<string, TypeSpecifier>());

        internal SignatureMatchResult MatchSignature(IHasSignature candidate, params Expression[] arguments)
        {
            var operands = candidate.Operands.ToArray() ?? Array.Empty<OperandDef>();
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
                // too many or too few arguments; issue could not resolve error
                var conversionResults = arguments
                    .Select(arg => new CoercionResult<Expression>(arg, CoercionCost.ExactMatch))
                    .ToArray();
                return new SignatureMatchResult(candidate, conversionResults, EmptyInferences, flags, ()=> Messaging.CouldNotResolveFunction(candidate.Name, arguments));
            }
            // doing this to make debugging easier
            CoercionResult<Expression>[]? newOperands = null;
            IDictionary<string, TypeSpecifier>? genericInferences = null;
            IDictionary<string, TypeSpecifier>? anyInference = null;
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
                    if (inferences.All(kvp => kvp.Value == SystemTypes.AnyType))
                        anyInference = inferences;
                    else
                    {
                        var replaced = ReplaceGenericArguments(operandTypes, arguments, inferences);

                        var cost = replaced.Sum(operand => (int)operand.Cost);
                        if (cost < lowestCost)
                        {
                            lowestCost = cost;
                            newOperands = replaced;
                            genericInferences = inferences;
                        }
                    }
                }
            }
            if (newOperands != null && genericInferences != null)
            {
                return new SignatureMatchResult(candidate, newOperands, genericInferences, flags, () => null);
            }
            else if (anyInference != null)
            {
                newOperands = ReplaceGenericArguments(operandTypes, arguments, anyInference);
                return new SignatureMatchResult(candidate, newOperands, anyInference, flags, ()=>null);
            }
            else
            {
                newOperands = new CoercionResult<Expression>[arguments.Length];
                for (int i = 0; i < arguments.Length; i++)
                {
                    newOperands[i] = CoercionProvider.Coerce(arguments[i], operandTypes[i]);
                }
                string? error = null;

                return new SignatureMatchResult(candidate, newOperands, EmptyInferences, default, ()=>error);
            }
        }

        // At present we are not going to consider generics with mulitple type arguments, as those do not exist in any system functions.
        // We'll leave the type as Dictionary for now for future proofing
        internal Dictionary<string, TypeSpecifier> InferGenericArgument(TypeSpecifier argumentType, TypeSpecifier operandType)
        {
            if (operandType is ParameterTypeSpecifier genericOperand)
            {
                if (argumentType is not ListTypeSpecifier && argumentType is not IntervalTypeSpecifier)
                    return new() { { genericOperand.parameterName, argumentType } };
            }
            else if (operandType is ListTypeSpecifier listOperand)
            {
                if (argumentType is ListTypeSpecifier listArgument)
                    return InferNestedGeneric(listArgument.elementType, listOperand.elementType);
                else
                    return InferGenericArgument(argumentType, listOperand.elementType);
            }
            else if (operandType is IntervalTypeSpecifier intervalOperand)
            {
                if (argumentType is IntervalTypeSpecifier intervalArgument)
                    return InferNestedGeneric(intervalArgument.pointType, intervalOperand.pointType);
                else if (CoercionProvider.HasConversionToIntervalThroughModel(argumentType, out var pointType))
                    return InferGenericArgument(pointType, intervalOperand.pointType);
                else
                    return InferGenericArgument(argumentType, intervalOperand.pointType);
            }
            return new();

            Dictionary<string, TypeSpecifier> InferNestedGeneric(TypeSpecifier argumentType, TypeSpecifier operandType) =>
                (operandType, argumentType) switch
                {
                    (ParameterTypeSpecifier generic, _) => new() { { generic.parameterName, argumentType } },
                    (ListTypeSpecifier opList, ListTypeSpecifier argList) => InferNestedGeneric(argList.elementType, opList.elementType),
                    (ListTypeSpecifier opList, _) => InferNestedGeneric(argumentType, opList.elementType),
                    (IntervalTypeSpecifier opInt, IntervalTypeSpecifier argInt) => InferNestedGeneric(argInt.pointType, opInt.pointType),
                    (IntervalTypeSpecifier opInt, _) => InferNestedGeneric(argumentType, opInt.pointType),
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
                .Select(function => MatchSignature(function, arguments));                
            var compatible = matches
                .Where(result => result.Compatible)
                .ToArray();
            SignatureMatchResult? candidate;
            if (match(compatible, out candidate))
                return candidate;
            // else, issue could not resolve.
            var firstMatch = matches.First();
            var result = new SignatureMatchResult(firstMatch.Function,
                firstMatch.Arguments,
                firstMatch.GenericInferences,
                firstMatch.Flags,
                ()=>Messaging.CouldNotResolveFunction(firstMatch.Function.Name, arguments));
            return result;

            //bool infersAny(SignatureMatchResult result) =>
            //    result.GenericInferences.Count > 0
            //    && result.GenericInferences.All(kvp => kvp.Value == SystemTypes.AnyType);

            bool match(SignatureMatchResult[] matches, [NotNullWhen(true)] out SignatureMatchResult? result)
            {
                var byCost = matches
                   .GroupBy(result => result.TotalCost)
                   .OrderBy(group => group.Key)
                   .ToArray();
                if (byCost.Length > 0)
                {
                    var cheapest = byCost[0].ToArray();
                    if (cheapest.Length == 1)
                    {
                        result = cheapest[0];
                        return true;
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
                        result = new(cheapest[0].Function,
                            cheapest[0].Arguments,
                            cheapest[0].GenericInferences,
                            cheapest[0].Flags | SignatureMatchFlags.Ambiguous,
                            ()=>errorSb.ToString());
                        return true;
                    }
                }
                result = null;
                return false;
            }

        }


        #endregion
    }


}

