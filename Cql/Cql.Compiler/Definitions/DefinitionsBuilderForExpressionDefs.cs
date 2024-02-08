using System;
using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler.Definitions;

#pragma warning disable CS1591
internal record DefinitionsBuilderForExpressionDefs(
    DefinitionsBuilderForLibrary OuterLib, 
    DefinitionDictionary<LambdaExpression> Definitions,
    ExpressionDef[] ExpressionDefs)
{
    public void AddToDefinitions(DefinitionDictionary<LambdaExpression> definitions)
    {
        var lib = OuterLib;

        foreach (var expressionDef in ExpressionDefs)
        {
            if (expressionDef.expression == null)
                throw new InvalidOperationException(
                    $"Definition {expressionDef.name} does not have an expression property");

            var buildContext = new ExpressionBuilderContext(
                lib.ExpressionBuilder,
                Expression.Parameter(typeof(CqlContext), "context"),
                Definitions,
                lib.LocalLibraryIdentifiers);

            if (string.IsNullOrWhiteSpace(expressionDef.name))
            {
                var message =
                    $"Definition with local ID {expressionDef.localId} does not have a name.  This is not allowed.";
                buildContext.LogError(message, expressionDef);
                throw new InvalidOperationException(message);
            }

            try
            {
                new DefinitionsBuilderForExpressionDef(this, expressionDef, buildContext).Build();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException(
                    $"Unhandled exception while building statement for definition '{expressionDef.name} 'in library '{lib.Library.NameAndVersion}'. See InnerException for more details.",
                    e);
            }
        }
    }
}