/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security;
using System.Text;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Abstractions.Infrastructure;
using Microsoft.Extensions.Logging;
using Expression = System.Linq.Expressions.Expression;


namespace Hl7.Cql.Compiler;

#pragma warning disable CS1591
internal partial class CqlOperatorsBinder
{
    private static readonly CqlOperatorsMethodsCache ICqlOperatorsMethods = new();

    ///  <summary>
    ///
    ///  <para>
    ///  This method tries to match the method name with the arguments against the ICqlOperators methods.
    ///  It also converts the arguments to the correct types if necessary.
    ///  It returns the MethodInfo and the converted arguments, if successful.
    ///  If no method is found, it throws an ArgumentException when <paramref name="throwError"></paramref> is <c>true</c>;
    ///  otherwise , it returns <c>null</c> for method on the resulting tuple.
    ///  </para>
    ///
    ///  <para>
    ///  The discovery of the correct method is done in two steps:
    ///  The first step tries to match the arguments with the method parameters.
    ///  The second step tries to match the arguments with the method parameters, but without the last argument.
    ///  This last step is useful for methods that have a null argument at the end, which is commonly used for precision cases.
    /// </para>
    ///
    ///  <para>
    ///  For generic methods, it tries to match the generic type from the first argument, and if it fails, it tries the second argument.
    ///  </para>
    ///
    ///  </summary>
    ///  <param name="methodName">The exact method name to bind to. When there are overloads, the correct method will be resolved.</param>
    ///  <param name="methodArguments">When an overload exists, returns the arguments that can be provided to this method. Conversions may be included to allow this.</param>
    ///  <param name="genericTypeArguments">When binding to a generic method definition, these are the type arguments.</param>
    ///  <param name="throwError">Whether to throw an error if no method overload could be found. This is the default behavior. Otherwise, returns the tuple with method as null.</param>
    ///  <exception cref="ArgumentException">If no method overload is discovered, and if <paramref name="throwError"/> is <c>true</c>.</exception>
    private (MethodInfo? method, Expression[] arguments) ResolveMethodInfoWithPotentialArgumentConversions(
        string methodName,
        Expression[] methodArguments,
        Type[] genericTypeArguments,
        bool throwError = true)
    {
        if (_logger.IsEnabled(LogLevel.Debug))
            _logger.LogDebug("Resolving method overload for {input}", new StringBuilder().AppendCSharp(methodName, methodArguments, genericTypeArguments, Defaults.MethodCSharpFormat));

        (MethodInfo method, Expression[] arguments, TypeConversion[] conversionMethods)[] candidates =
            ResolveMethodInfosWithPotentialArgumentConversions(methodName, methodArguments, genericTypeArguments).ToArray();

        var candidate = candidates switch
        {
            []         => candidates.FirstOrDefault(), // always default
            [{ } only] => only,
            _          => PickCandidate(candidates)
        };

        switch (candidate.method, throwError)
        {
            case (method: not null, _):
                if (_logger.IsEnabled(LogLevel.Debug))
                {
                    MethodCSharpFormat methodCSharpFormat =
                        Defaults.MethodCSharpFormat with
                        {
                            ParameterFormat = Defaults.MethodCSharpFormat.ParameterFormat with
                            {
                                // Show the parameter type, and conversion method
                                ParameterFormat = t => $"{t.Type} as {candidate.conversionMethods[t.Position].ToString()}"
                            }
                        };

                    _logger.LogDebug(
                        "Resolved with score {score} to method overload {candidate}",
                        Score(candidate!),
                        candidate.method?.ToCSharpString(methodCSharpFormat));
                }

                return (candidate.method, candidate.arguments);

            case (method: null, throwError: true):
                throw new CannotBindToCqlOperatorError(
                        methodName,
                        methodArguments,
                        genericTypeArguments,
                        ICqlOperatorsMethods.GetMethodsByName(methodName),
                        Defaults.MethodCSharpFormat)
                    .ToException();

            case (method: null, throwError: false):
                // No need to log here, since the caller didn't care about if the method
                // was not found and would perform its own action based on that.
                return default;
        }

        (MethodInfo? method, Expression[] arguments, TypeConversion[] conversionMethods) PickCandidate(
            (MethodInfo method, Expression[] arguments, TypeConversion[] conversionMethods)[] candidates)
        {
            if (methodArguments.Length > 0)
            {
                var scoredCandidates = candidates.SelectToArray(candidate => (candidate, score:Score(candidate)));
                Array.Sort(scoredCandidates, (a, b) => a.score.CompareTo(b.score));

                StringBuilder sbInput = new();
                sbInput.Append(Defaults.NextItem);
                sbInput.AppendCSharp(methodName, methodArguments, genericTypeArguments);

                StringBuilder sbCandidatesAndScore = new();
                foreach (var ((method, methodArguments, _), score) in scoredCandidates)
                {
                    sbCandidatesAndScore.Append(Defaults.NextItem);
                    sbCandidatesAndScore.AppendCSharp(method.Name, methodArguments, genericTypeArguments);
                    sbCandidatesAndScore.Append(" (");
                    sbCandidatesAndScore.Append(score);
                    sbCandidatesAndScore.Append(')');
                }

                _logger?.LogDebug(
                    "Multiple candidates found for method:{input}\nPicking the top item with lowest score: {candidatesAndScore}",
                    sbInput,
                    sbCandidatesAndScore);

                return scoredCandidates[0].candidate;
            }

            throw new InvalidOperationException("");
        }

        double Score((MethodInfo method, Expression[] arguments, TypeConversion[] conversionMethods) candidate)
        {
            var score =
                PadWhenEmpty( // Cannot get average of empty list
                    candidate
                        .conversionMethods
                        .Where(cm => cm > TypeConversion.NoMatch)
                        .Select(cm => (double)cm),
                    padWhenEmpty: (double)TypeConversion.ExactType)
                    .Average();
            return score;
        }

        static IEnumerable<T> PadWhenEmpty<T>(IEnumerable<T> source, T padWhenEmpty)
        {
            using var enumerator = source.GetEnumerator();
            if (!enumerator.MoveNext())
                yield return padWhenEmpty;
            else
            {
                do
                {
                    yield return enumerator.Current;
                } while (enumerator.MoveNext());
            }
        }
    }

    private IEnumerable<(MethodInfo method, Expression[] arguments, TypeConversion[] conversionMethods)>
        ResolveMethodInfosWithPotentialArgumentConversions(
            string methodName,
            Expression[] arguments,
            Type[] genericTypeArguments)
    {
        Expression[] args = arguments; // So we don't modify the original array

        if (genericTypeArguments.Length > 0)
        {
            var methods = ICqlOperatorsMethods.GetMethodsByNameAndParamCount(methodName, args.Length);
            foreach (var method in methods)
            {
                if (method.IsGenericMethodDefinition
                    && method.GetGenericArguments().Length == genericTypeArguments.Length)
                {
                    var genericMethod = method.MakeGenericMethod(genericTypeArguments);
                    var parameters = genericMethod.GetParameters();

                    if (TryBindArguments(
                            parameters,
                            out var genericMethodArgs,
                            out var conversions))
                    {
                        yield return (genericMethod, genericMethodArgs, conversions);
                        break;
                    }
                }
            }
            yield break;
        }

        for (int i = 0; i < 2; i++) // Try twice, first with all arguments, then without the last one
        {
            var methods = ICqlOperatorsMethods.GetMethodsByNameAndParamCount(methodName, args.Length);

            if (args.Length == 0)
            {
                // No conversions, find method without parameters
                foreach (var method in methods)
                {
                    yield return (method, [], []);
                }
                break;
            }

            foreach (var method in methods)
            {
                var methodParameters = method.GetParameters();
                if (method is not { IsGenericMethodDefinition: true })
                {
                    // Non-generic method
                    if (TryBindArguments(methodParameters, out var methodArgs, out var conversions))
                        yield return (method, methodArgs, conversions);
                }
                else
                {
                    IEnumerable<Type> GetGenericTypeArgs()
                    {
                        for (int argIndexForGenericMethod = 0;
                             argIndexForGenericMethod < Math.Min(args.Length, 2);
                             argIndexForGenericMethod++) // Try to get generic type from argument up to the second one
                        {
                            var argType = args[argIndexForGenericMethod].Type;
                            var parameterType = methodParameters[i].ParameterType;
                            var argIsGeneric = argType.IsGenericType;
                            var paramIsGeneric = parameterType.IsGenericMethodParameter;

                            if (paramIsGeneric && !argIsGeneric)
                                yield return argType; // Already a generic argument, try again
                            else if (argIsGeneric)
                            {
                                yield return argType;
                                yield return argType.GetGenericArguments().Single();
                            }
                        }
                    }

                    var genericTypeArgs =
                        GetGenericTypeArgs()
#if DEBUG
                            .ToArray() // Helps debugging
#endif
                        ;

                    foreach (var genericTypeArg in genericTypeArgs)
                    {
                        MethodInfo genericMethod;
                        try
                        {
                            genericMethod = method.MakeGenericMethod(genericTypeArg);
                        }
                        catch (ArgumentException e) when (e.InnerException is VerificationException)
                        {
                            // Generic type argument is not valid for this method due to constraints
                            continue;
                        }

                        if (TryBindArguments(
                                genericMethod.GetParameters(),
                                out var genericMethodArgs,
                                out var conversions))
                        {
                            yield return (genericMethod, genericMethodArgs, conversions);
                            break;
                        }
                    }
                }
            }

            // Handles precision cases where the last argument might be supplied or not
            if (i <= 0 && args[^1] is ConstantExpression { Value: null })
                args = args[..^1];
            else
                break;
        }

        bool TryBindArguments(
            ParameterInfo[] parameters,
            out Expression[] bindArgs,
            out TypeConversion[] bindConversions)
        {
            bindArgs = new Expression[args.Length];
            bindConversions = new TypeConversion[args.Length];

            for (int i = 0; i < args.Length; i++)
            {
                Type to = parameters[i].ParameterType;
                if (!TryConvert(args[i], to, out var t))
                    return false;

                (bindArgs[i], bindConversions[i]) = t;
            }

            return true;
        }
    }

    private static MethodCallExpression BindToDirectMethod(
        string methodName,
        params Expression[] arguments) =>
        Expression.Call(CqlExpressions.Operators_PropertyExpression, methodName, null, arguments);

    private static MethodCallExpression BindToDirectMethod(
        MethodInfo method,
        params Expression[] expressions) =>
        Expression.Call(CqlExpressions.Operators_PropertyExpression, method, expressions);
}