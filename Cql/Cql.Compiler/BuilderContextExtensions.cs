/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Hl7.Cql.Abstractions.Exceptions;

namespace Hl7.Cql.Compiler;

internal static class BuilderContextExtensions
{

    public static IEnumerable<IBuilderContext?> SelfAndAncestorBuilders(this IBuilderContext context)
    {
        IBuilderContext? currentContext = context;
        while (currentContext != null)
        {
            yield return currentContext;
            currentContext = currentContext.OuterBuilderContext;
        }
    }

    public static CqlException NewExpressionBuildingException(
        this IBuilderContext context,
        string? message = null,
        Exception? innerException = null) =>
        new ExpressionBuildingError(context, message).ToException(innerException);

    public static string GetExpressionPath(this IBuilderContext builder) =>
        $"\r\n\tExpression Path {builder.Hash}:{GetExpressionPathLines(builder)}";

    public static string GetDebuggerView(this IBuilderContext builder) =>
        $"{builder.GetType().Name}{GetExpressionPath(builder)}";

    private static string GetExpressionPathLines(IBuilderContext builder) =>
        string.Concat(
            from context in builder.SelfAndAncestorBuilders().Reverse()
            let info = context.DebuggerInfo
            where info != null
            select $"\r\n\t* {info}"
        );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [DebuggerStepThrough]
    public static T CatchRethrowExpressionBuildingException<TBuilderContext, T>(
        this TBuilderContext builderContext,
        Func<TBuilderContext, T> fn,
        Func<Exception, string?>? provideErrorMessage = null)
        where TBuilderContext : IBuilderContext
    {
        try
        {
            return fn(builderContext);
        }
        catch (CqlException<ExpressionBuildingError> e)
        {
            _ = e.Error.Context!.DebuggerInfo;
            throw;
        }
        catch (Exception other)
        {
            throw builderContext.NewExpressionBuildingException(message: provideErrorMessage?.Invoke(other), innerException: other);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [DebuggerStepThrough]
    public static void CatchRethrowExpressionBuildingException<TBuilderNode>(
        this TBuilderNode builder,
        Action<TBuilderNode> action,
        Func<Exception, string?>? provideErrorMessage = null)
        where TBuilderNode : IBuilderContext
    {
        try
        {
            action(builder);
        }
        catch (CqlException<ExpressionBuildingError> e)
        {
            _ = e.Error.Context!.DebuggerInfo;
            throw;
        }
        catch (Exception other)
        {
            throw builder.NewExpressionBuildingException(message: provideErrorMessage?.Invoke(other), innerException: other);
        }
    }
}