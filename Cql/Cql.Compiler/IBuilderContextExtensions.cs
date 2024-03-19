using System;
using System.Collections.Generic;
using System.Linq;
using Hl7.Cql.Abstractions.Exceptions;

namespace Hl7.Cql.Compiler;

internal static class IBuilderContextExtensions
{

    public static IEnumerable<IBuilderContext> SelfAndAncestorContexts(this IBuilderContext context)
    {
        IBuilderContext? currentContext = context;
        while (currentContext != null)
        {
            yield return currentContext;
            currentContext = currentContext.OuterContext;
        }
    }

    public static CqlException NewExpressionBuildingException(
        this IBuilderContext context,
        string? message = null, 
        Exception? innerException = null) =>
        new ExpressionBuildingError(context, message).ToException(innerException);

    public static string GetExpressionPath(this IBuilderContext builderContext) =>
        $"\r\n\tExpression Path:{string.Concat(
            from context in builderContext.SelfAndAncestorContexts().Reverse()
            select $"\r\n\t* {context.ContextInfo}"
        )}";

    public static string GetDebuggerView(this IBuilderContext builderContext) =>
        $"{builderContext.GetType().Name}\r\n\tExpression Path:{string.Concat(
            from context in builderContext.SelfAndAncestorContexts().Reverse()
            select $"\r\n\t* {context.ContextInfo}"
        )}";

}