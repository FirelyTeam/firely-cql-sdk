using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Hl7.Cql.Abstractions.Exceptions;

namespace Hl7.Cql.Compiler.Builders;

internal static class IBuilderNodeExtensions
{

    public static IEnumerable<IBuilderNode?> SelfAndAncestorBuilders(this IBuilderNode context)
    {
        IBuilderNode? currentContext = context;
        while (currentContext != null)
        {
            yield return currentContext;
            currentContext = currentContext.OuterBuilder;
        }
    }

    public static CqlException NewExpressionBuildingException(
        this IBuilderNode context,
        string? message = null,
        Exception? innerException = null) =>
        new ExpressionBuildingError(context, message).ToException(innerException);

    public static string GetExpressionPath(this IBuilderNode builder) =>
        $"\r\n\tExpression Path:{string.Concat(
            from context in builder.SelfAndAncestorBuilders().Reverse()
            let info = context.BuilderDebuggerInfo
            where info != null
            select $"\r\n\t* {info}"
        )}";

    public static string GetDebuggerView(this IBuilderNode builder) =>
        $"{builder.GetType().Name}\r\n\tExpression Path:{string.Concat(
            from context in builder.SelfAndAncestorBuilders().Reverse()
            let info = context.BuilderDebuggerInfo
            where info != null
            select $"\r\n\t* {info}"
        )}";

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T CatchRethrowExpressionBuildingException<TBuilderNode, T>(
        this TBuilderNode builder,
        Func<TBuilderNode, T> fn,
        Func<Exception, string?>? provideErrorMessage = null)
        where TBuilderNode : IBuilderNode
    {
        try
        {
            return fn(builder);
        }
        catch (CqlException<ExpressionBuildingError> e)
        {
            _ = e.Error.Context!.BuilderDebuggerInfo;
            throw;
        }
        catch (Exception other)
        {
            throw builder.NewExpressionBuildingException(message: provideErrorMessage?.Invoke(other), innerException: other);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CatchRethrowExpressionBuildingException<TBuilderNode>(
        this TBuilderNode builder,
        Action<TBuilderNode> action,
        Func<Exception, string?>? provideErrorMessage = null)
        where TBuilderNode : IBuilderNode
    {
        try
        {
            action(builder);
        }
        catch (CqlException<ExpressionBuildingError> e)
        {
            _ = e.Error.Context!.BuilderDebuggerInfo;
            throw;
        }
        catch (Exception other)
        {
            throw builder.NewExpressionBuildingException(message: provideErrorMessage?.Invoke(other), innerException: other);
        }
    }
}