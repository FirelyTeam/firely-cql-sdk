using System;
using System.Linq;

namespace Hl7.Cql.Compiler;

internal class ExpressionBuildingException : Exception
{
    private const string DefaultMessage = "Exception occurred during expression building.";
    
    public ExpressionBuilderContext? Context { get; }

    public ExpressionBuildingException(
        ExpressionBuilderContext? context = null, 
        string? message = null, 
        Exception? innerException = null)
        : base(message ?? DefaultMessage, innerException) =>
        Context = context;

    public override string Message =>
        Context is null 
            ? base.Message
            : $$"""
              {{base.Message}} Expression Path:{{
                  string.Concat(
                      from item in Context.ElementPathToRoot.Reverse()
                      select $@"
- {item}"
                  )
              }}
              """;
}

internal static class ExpressionBuildingExceptionExtensions
{
    public static ExpressionBuildingException WithContext(
        this Exception e,
        ExpressionBuilderContext ctx) =>
        ctx.NewExpressionBuildingException(innerException: e);
}