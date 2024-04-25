using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Operators;
using Microsoft.Extensions.Logging;
using Expression = System.Linq.Expressions.Expression;


namespace Hl7.Cql.Compiler;

#pragma warning disable CS1591
internal partial class CqlOperatorsBinder
{
    private static readonly MethodAndParametersByParamCountByName
        ICqlOperatorsMethods =
            typeof(ICqlOperators)
                .GetMethods(BindingFlags.Instance | BindingFlags.Public)
                .Select(method => (method, parameters:method.GetParameters()))
                .GroupBy(g => g.method.Name)
                .ToDictionary(
                    g => g.Key,
                    g =>
                        g.GroupBy(g2 => g2.parameters.Length)
                         .ToDictionary(
                             g2 => g2.Key,
                             g2 => g2.ToArray())
                         .AsReadOnly())
                .AsReadOnly();

    private static readonly CSharpWriteTypeOptions CSharpWriteTypeOptions = new(PreferKeywords:true, HideNamespaces:true);

    private static readonly CSharpWriteMethodOptions CSharpWriteMethodOptions = new (
        methodFormat:t => $"\n\t* {t.name}({t.parameters})",
        parameterOptions:new (
            parameterFormat:t => $"{t.type}",
            typeOptions: CSharpWriteTypeOptions));

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
    ///  <param name="arguments">When an overload exists, returns the arguments that can be provided to this method. Conversions may be included to allow this.</param>
    ///  <param name="throwError">Whether to throw an error if no method overload could be found. This is the default behavior. Otherwise, returns the tuple with method as null.</param>
    ///  <exception cref="ArgumentException">If no method overload is discovered, and if <paramref name="throwError"/> is <c>true</c>.</exception>
    private (MethodInfo? method, Expression[] arguments) ResolveMethodInfoWithPotentialArgumentConversions(
        string methodName,
        Expression[] arguments,
        bool throwError = true)
    {
        (MethodInfo method, Expression[] arguments, TypeConversion[] conversionMethods)[] candidates = ResolveMethodInfosWithPotentialArgumentConversions(methodName, arguments).ToArray();

        var candidate = candidates switch
        {
            []         => candidates.FirstOrDefault(), // always default
            [{ } only] => only,
            _          => PickCandidate(candidates)
        };

        if (candidate.method is null)
        {
            if (throwError)
            {
                throw new ArgumentException(
                    NoCandidatesErrorMessage(),
                    nameof(methodName));
            }
        }
        else if (candidate.conversionMethods.Any(cm => cm == TypeConversion.SuperType))
        {
            var inputText = InputMethodAndParametersToString();
            var candidateText = candidate.method.WriteCSharp(CSharpWriteMethodOptions);

            _logger?.LogWarning(
                "Candidate for method {input}\nhas one of the arguments casting to a sub type: {candidateText}",
                inputText,
                candidateText);
        }

        return (candidate.method, candidate.arguments);

        (MethodInfo? method, Expression[] arguments, TypeConversion[] conversionMethods) PickCandidate(
            (MethodInfo method, Expression[] arguments, TypeConversion[] conversionMethods)[] candidates)
        {
            if (arguments.Length > 0)
            {
                var scoredCandidates = candidates
                    .SelectToArray(candidate => (candidate, score:Score(candidate)));
                Array.Sort(scoredCandidates, (a, b) => a.score.CompareTo(b.score));

                var inputText = InputMethodAndParametersToString();
                var scoredCandidatesText = string.Concat(
                    scoredCandidates.Select(t => $"{t.candidate.method.WriteCSharp(CSharpWriteMethodOptions)} ({t.score})"));

                _logger?.LogDebug(
                    "Multiple candidates found for method {input}\nPicking the top item with lowest score: {candidatesAndScore}",
                    inputText,
                    scoredCandidatesText);

                return scoredCandidates[0].candidate;
            }

            throw new InvalidOperationException("");
        }

        string NoCandidatesErrorMessage()
        {
            var inputText = InputMethodAndParametersToString();

            var overloadsText =
                string.Concat(
                    ICqlOperatorsMethods
                        .GetMethodsByName(methodName)
                        .Select(t => t.method.WriteCSharp(CSharpWriteMethodOptions))
                );
            return $$"""
                     Mo suitable method could be bound on:{{inputText}}
                     from the following method overloads:{{overloadsText}}
                     """;
        }

        string InputMethodAndParametersToString()
        {
            return CSharpWriteMethodOptions
                   .Write(
                       writer: null,
                       name: methodName,
                       parameters: () => arguments.SelectToArray(e => e.Type.WriteCSharp(CSharpWriteTypeOptions).ToString()!),
                       returnType: null!)
                   .ToString()!;
        }

        double Score((MethodInfo method, Expression[] arguments, TypeConversion[] conversionMethods) candidate)
        {
            var score = candidate.conversionMethods
                         .Where(cm => cm > TypeConversion.NoMatch)
                         .Select(cm => (double)cm)
                         .Average();
            return score;
        }
    }

    private IEnumerable<(MethodInfo method, Expression[] arguments, TypeConversion[] conversionMethods)>
        ResolveMethodInfosWithPotentialArgumentConversions(
            string methodName,
            Expression[] arguments)
    {
        Expression[] args = arguments; // So we don't modify the original array

        for (int i = 0; i < 2; i++) // Try twice, first with all arguments, then without the last one
        {
            var methodsWithParameters = ICqlOperatorsMethods.GetMethodsByNameAndParamCount(methodName, args.Length);

            if (args.Length == 0)
            {
                // No conversions, find method without parameters
                foreach (var (method, _) in methodsWithParameters)
                {
                    yield return (method, [], []);
                }
                break;
            }

            foreach (var (method, methodParameters) in methodsWithParameters)
            {
                if (method is not { IsGenericMethodDefinition: true })
                {
                    // Non-generic method
                    if (TryBindArguments(methodParameters, out var methodArgs, out var conversions))
                        yield return (method, methodArgs, conversions);
                }
                else
                {
                    // Generic method, figure out the generic type by the first two arguments
                    for (int argIndexForGenericMethod = 0;
                         argIndexForGenericMethod < Math.Min(args.Length, 2);
                         argIndexForGenericMethod
                             ++) // Try to get generic type from argument up to the second one
                    {
                        if (!args[argIndexForGenericMethod].Type.IsGenericType)
                            continue; // Not a generic argument, try again

                        var genericTypeArg = args[argIndexForGenericMethod].Type.GetGenericArguments().Single();
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
                        if (TryBindArguments(genericMethod.GetParameters(), out var genericMethodArgs,
                                             out var conversions))
                            yield return (genericMethod, genericMethodArgs, conversions);
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
                if (!TryConvert(args[i], parameters[i].ParameterType, out var t))
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

    private static MethodCallExpression BindToGenericMethod(
        string methodName,
        Type[] genericTypeArguments,
        params Expression[] arguments) =>
        Expression.Call(CqlExpressions.Operators_PropertyExpression, methodName, genericTypeArguments, arguments);
}