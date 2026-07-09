/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Operators;

namespace Hl7.Cql.Compiler.Ir;

/// <summary>
/// IR counterpart of <see cref="CqlOperatorsBinder.Bind"/>: overload resolution
/// (<see cref="ResolveMethodInfoWithPotentialArgumentConversions"/>), candidate scoring, generic
/// inference, and the trailing-null precision retry. This is a mechanical port; see the remarks
/// on <see cref="IrCqlOperatorsBinder"/>.
/// </summary>
#pragma warning disable CS1591
partial class IrCqlOperatorsBinder
{
    // The method-info cache is Expression-free (pure reflection over ICqlOperators), so it is
    // reused directly from the old binder rather than ported. The type is nested inside the old
    // (internal) CqlOperatorsBinder, so it stays reachable until phase 6 deletes that class.
    // NOTE(phase6): relocate CqlOperatorsMethodsCache out of the old binder when it is deleted.
    private static readonly CqlOperatorsBinder.CqlOperatorsMethodsCache ICqlOperatorsMethods = new();

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
    private (MethodInfo? method, IrExpression[] arguments) ResolveMethodInfoWithPotentialArgumentConversions(
        string methodName,
        IrExpression[] methodArguments,
        Type[] genericTypeArguments,
        bool throwError = true)
    {
        if (_logger.IsEnabled(LogLevel.Debug))
            _logger.LogDebug("Resolving method overload for {input}", FormatMethodCall(methodName, methodArguments, genericTypeArguments));

        (MethodInfo method, IrExpression[] arguments, TypeConversion[] conversionMethods)[] candidates =
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
                                Format = t => $"{t.Type} as {candidate.conversionMethods[t.Position].ToString()}"
                            }
                        };

                    _logger.LogDebug(
                        "Resolved with score {score} to method overload {candidate}",
                        Score(candidate!),
                        candidate.method?.ToCSharpString(methodCSharpFormat));
                }

                return (candidate.method, candidate.arguments);

            case (method: null, throwError: true):
                // FIXME(phase6): unify with CannotBindToCqlOperatorError, which requires
                // Expression[] and cannot be constructed from IrExpression[] without modifying
                // the shared (Expression-based) error type. Build the same message shape by
                // hand until the old binder is deleted and the error type can be generalized.
                throw new InvalidOperationException(
                    FormatCannotBindMessage(methodName, methodArguments, genericTypeArguments));

            case (method: null, throwError: false):
                // No need to log here, since the caller didn't care about if the method
                // was not found and would perform its own action based on that.
                return default;
        }

        (MethodInfo? method, IrExpression[] arguments, TypeConversion[] conversionMethods) PickCandidate(
            (MethodInfo method, IrExpression[] arguments, TypeConversion[] conversionMethods)[] candidates)
        {
            if (methodArguments.Length > 0)
            {
                var scoredCandidates = candidates.SelectToArray(candidate => (candidate, score:Score(candidate)));
                Array.Sort(scoredCandidates, (a, b) => a.score.CompareTo(b.score));

                StringBuilder sbInput = new();
                sbInput.Append(Defaults.NextItem);
                sbInput.Append(FormatMethodCall(methodName, methodArguments, genericTypeArguments));

                StringBuilder sbCandidatesAndScore = new();
                foreach (var ((method, methodArguments, _), score) in scoredCandidates)
                {
                    sbCandidatesAndScore.Append(Defaults.NextItem);
                    sbCandidatesAndScore.Append(FormatMethodCall(method.Name, methodArguments, genericTypeArguments));
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

        double Score((MethodInfo method, IrExpression[] arguments, TypeConversion[] conversionMethods) candidate)
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

    private IEnumerable<(MethodInfo method, IrExpression[] arguments, TypeConversion[] conversionMethods)>
        ResolveMethodInfosWithPotentialArgumentConversions(
            string methodName,
            IrExpression[] arguments,
            Type[] genericTypeArguments)
    {
        IrExpression[] args = arguments; // So we don't modify the original array

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
                            // NOTE(phase3): ported as-is, possible upstream bug (#1341): this
                            // indexes methodParameters with `i` (the outer retry-pass index, 0 or
                            // 1), not `argIndexForGenericMethod`. The old CqlOperatorsBinder.Bind.cs
                            // has the same indexing, so this is faithfully preserved rather than
                            // "fixed" during the port -- the old behavior is the contract until
                            // golden parity is proven; fix after phase 6, in one place.
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
            if (i <= 0 && args[^1] is IrConstant { Value: null })
                args = args[..^1];
            else
                break;
        }

        bool TryBindArguments(
            ParameterInfo[] parameters,
            out IrExpression[] bindArgs,
            out TypeConversion[] bindConversions)
        {
            bindArgs = new IrExpression[args.Length];
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

    private static IrInvoke BindToDirectMethod(
        string methodName,
        params IrExpression[] arguments)
    {
        // FIXME(phase3-review): the old binder used Expression.Call(receiver, methodName,
        // typeArguments, arguments), which performs its own reflection-based overload
        // resolution against the argument expressions. IrInvoke requires an already-resolved
        // MethodInfo, so this resolves by name + argument count only. Every current call site
        // (ResolveValueSet, FlattenLateBoundList, and the ConvertXToY family selected via
        // CqlOperators.ConversionFunctionName) has exactly one overload under that name, so this
        // is behavior-preserving today; a genuinely overloaded name would need real resolution.
        var candidates = ICqlOperatorsMethods.GetMethodsByNameAndParamCount(methodName, arguments.Length);
        var method = candidates.Count switch
        {
            1 => candidates.Single(),
            0 => throw new InvalidOperationException($"No method named '{methodName}' with {arguments.Length} parameter(s) was found on {nameof(ICqlOperators)}."),
            _ => throw new InvalidOperationException($"Method name '{methodName}' with {arguments.Length} parameter(s) is ambiguous on {nameof(ICqlOperators)}; direct binding requires a unique overload by name and arity.")
        };
        return new IrInvoke(OperatorsReceiver, method, arguments);
    }

    private static IrInvoke BindToDirectMethod(
        MethodInfo method,
        params IrExpression[] expressions) =>
        new(OperatorsReceiver, method, expressions);

    /// <summary>
    /// Minimal, IR-side replacement for the old <c>StringBuilder.AppendCSharp(string, Expression[], Type[])</c>
    /// extension (which formatted from <c>Expression.Type</c>), used only for debug logging and
    /// error messages. Produces e.g. <c>"MethodName&lt;T1&gt;(Type1, Type2)"</c>.
    /// </summary>
    private static string FormatMethodCall(string methodName, IrExpression[] args, Type[] genericTypeArguments)
    {
        var typeArgsStr = genericTypeArguments.Length == 0
            ? ""
            : $"<{string.Join(", ", genericTypeArguments.Select(t => t.ToCSharpString(Defaults.TypeCSharpFormat)))}>";
        var argsStr = string.Join(", ", args.Select(a => a.Type.ToCSharpString(Defaults.TypeCSharpFormat)));
        return $"{methodName}{typeArgsStr}({argsStr})";
    }

    /// <summary>
    /// Minimal, IR-side replacement for <see cref="CannotBindToCqlOperatorError"/> (which
    /// requires <c>Expression[]</c> and is left untouched per the phase-3 brief). Mirrors
    /// <see cref="CannotBindToCqlOperatorError.GetMessage"/>.
    /// FIXME(phase6): unify once the old binder and its Expression-based error type are deleted.
    /// </summary>
    private static string FormatCannotBindMessage(string methodName, IrExpression[] methodArguments, Type[] genericTypeArguments)
    {
        StringBuilder sb = new();
        sb.Append("No suitable method could be bound from:");
        sb.Append(Defaults.NextItem);
        sb.Append(FormatMethodCall(methodName, methodArguments, genericTypeArguments));

        var availableMethods = ICqlOperatorsMethods.GetMethodsByName(methodName);
        if (availableMethods.Count > 0)
        {
            sb.Append('\n');
            sb.Append("to the following method overloads:");
            foreach (var availableMethod in availableMethods)
            {
                sb.Append(Defaults.NextItem);
                sb.AppendCSharp(availableMethod, Defaults.MethodCSharpFormat);
            }
        }
        return sb.ToString();
    }
}
