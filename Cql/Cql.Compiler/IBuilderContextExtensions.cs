using System;
using System.Collections.Generic;
using System.Linq;
using Hl7.Cql.Abstractions.Exceptions;

namespace Hl7.Cql.Compiler;

internal static class IContextualExpressionBuilderExtensions
{

    public static IEnumerable<IContextualExpressionBuilder> SelfAndAncestorContexts(this IContextualExpressionBuilder context)
    {
        IContextualExpressionBuilder? currentContext = context;
        while (currentContext != null)
        {
            yield return currentContext;
            currentContext = currentContext.OuterContext;
        }
    }

    public static CqlException NewExpressionBuildingException(
        this IContextualExpressionBuilder context,
        string? message = null, 
        Exception? innerException = null) =>
        new ExpressionBuildingError(context, message).ToException(innerException);

    public static string GetExpressionPath(this IContextualExpressionBuilder contextualExpressionBuilder) =>
        $"\r\n\tExpression Path:{string.Concat(
            from context in contextualExpressionBuilder.SelfAndAncestorContexts().Reverse()
            select $"\r\n\t* {context.ContextInfo}"
        )}";

    public static string GetDebuggerView(this IContextualExpressionBuilder contextualExpressionBuilder) =>
        $"{contextualExpressionBuilder.GetType().Name}\r\n\tExpression Path:{string.Concat(
            from context in contextualExpressionBuilder.SelfAndAncestorContexts().Reverse()
            select $"\r\n\t* {context.ContextInfo}"
        )}";

}