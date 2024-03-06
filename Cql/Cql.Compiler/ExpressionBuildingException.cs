using System;
using System.Linq;

namespace Hl7.Cql.Compiler;

internal class ExpressionBuildingException : Exception
{
    public ExpressionBuilderContext Context { get; }

    public ExpressionBuildingException(
        ExpressionBuilderContext context, 
        string message, 
        Exception? innerException = null)
        : base(message, innerException) =>
        Context = context;

    public override string Message => 
        $$"""
          {{base.Message}} Expression Path:{{
              string.Concat(
                  from item in Context.ElementPathToRoot.Reverse()
                  select $@"
- {item}"
              )
          }}
          """;
}