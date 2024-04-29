using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Operators;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler;

#pragma warning disable CS1591
partial class CqlOperatorsBinder
{
    private static readonly IReadOnlyDictionary<(string methodName, int parameterCount), (MethodInfo method, ParameterInfo[] parameters)[]>
        ICqlOperatorsMethodsWithParameters_By_MethodNameAndParameterCount =
            typeof(ICqlOperators)
                .GetMethods(BindingFlags.Instance | BindingFlags.Public)
                .Select(method => (method, parameters:method.GetParameters()))
                .GroupBy(t => (t.method.Name, t.parameters.Length))
                .ToDictionary(
                    g => g.Key,
                    g => g.ToArray());

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
    ///  <param name="resultTypeHint">The hint of what the expected result type should be, which is used to discriminate between more than one bind candidate.</param>
    ///  <param name="arguments">When an overload exists, returns the arguments that can be provided to this method. Conversions may be included to allow this.</param>
    ///  <param name="throwError">Whether to throw an error if no method overload could be found. This is the default behavior. Otherwise, returns the tuple with method as null.</param>
    ///  <exception cref="ArgumentException">If no method overload is discovered, and if <paramref name="throwError"/> is <c>true</c>.</exception>
    private (MethodInfo? method, Expression[] arguments) ResolveMethodInfoWithPotentialArgumentConversions(
        string methodName,
        Type? resultTypeHint,
        Expression[] arguments,
        bool throwError = true)
    {
        var candidates = ResolveMethodInfosWithPotentialArgumentConversions(methodName, arguments).ToArray();

        return candidates switch
        {
            [] when throwError =>
                throw new ArgumentException(
                    $"No suitable method found {methodName}({string.Join(", ", arguments.Select(e => e.Type.Name))}).",
                    nameof(methodName)),
            []       => (null, []),
            [{ } only] => (only.method, only.arguments),
            _ => PickCandidate(candidates)
        };

        (MethodInfo? method, Expression[] arguments) PickCandidate(
            (MethodInfo method, Expression[] arguments, TypeConversion[] conversionMethods)[] candidates)
        {
            if (arguments.Length > 0)
            {
                // Find best match on arguments
                candidates = candidates
                             .OrderBy(c =>
                             {
                                 var score = c.conversionMethods
                                              .Where(cm => cm > TypeConversion.NoMatch)
                                              .Select(cm => (double)cm)
                                              .Average();
                                 return score;
                             })
                             .SelectToArray(candidates.Length, o => o);
                return (candidates[0].method, candidates[0].arguments);
            }

            if (resultTypeHint is { } t)
            {
                // Find best match on return type
                throw new InvalidOperationException("");
            }

            throw new InvalidOperationException("");
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
            if (ICqlOperatorsMethodsWithParameters_By_MethodNameAndParameterCount.TryGetValue(
                    (methodName, args.Length),
                    out var methodsWithParameters))
            {

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
                            var genericMethod = method.MakeGenericMethod(genericTypeArg);
                            if (TryBindArguments(genericMethod.GetParameters(), out var genericMethodArgs,
                                                 out var conversions))
                                yield return (genericMethod, genericMethodArgs, conversions);
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
                if (!TryConvert(args[i], parameters[i].ParameterType, out var t))
                    return false;

                (bindArgs[i], bindConversions[i]) = t;
            }

            return true;
        }
    }

    private static MethodCallExpression BindToMethod(
        string methodName,
        params Expression[] arguments) =>
        Expression.Call(CqlExpressions.Operators_PropertyExpression, methodName, null, arguments);

    private static MethodCallExpression BindToGenericMethod(
        string methodName,
        Type[] genericTypeArguments,
        params Expression[] arguments) =>
        Expression.Call(CqlExpressions.Operators_PropertyExpression, methodName, genericTypeArguments, arguments);

    private static MethodCallExpression BindToMethod(
        MethodInfo method,
        params Expression[] expressions) =>
        Expression.Call(CqlExpressions.Operators_PropertyExpression, method, expressions);
}