using System;
using System.Collections.Generic;

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

}