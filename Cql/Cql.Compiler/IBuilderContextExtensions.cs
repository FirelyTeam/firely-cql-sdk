using System;
using System.Collections.Generic;
using System.Linq;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Fhir.Rest;

namespace Hl7.Cql.Compiler;

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

}