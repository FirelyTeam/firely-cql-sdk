using System;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler.DefinitionBuilding;

#pragma warning disable CS1591
internal partial class DefinitionsBuilder
{
    private void VisitParameterDef(
        LibraryContext libraryContext,
        ParameterDef parameter)
    {
        if (libraryContext.ContainsDefinition(parameter.name!))
            throw new InvalidOperationException(
                $"There is already a definition named {parameter.name}");

        var expressionBuilderContext = libraryContext.NewExpressionBuilderContext();

        Expression? defaultValue = null;
        if (parameter.@default != null)
            defaultValue = Expression.TypeAs(libraryContext.TranslateExpression(parameter.@default, expressionBuilderContext),
                typeof(object));
        else defaultValue = Expression.Constant(null, typeof(object));

        var resolveParam = Expression.Call(
            expressionBuilderContext.RuntimeContextParameter,
            typeof(CqlContext).GetMethod(nameof(CqlContext.ResolveParameter))!,
            Expression.Constant(libraryContext.LibraryKey),
            Expression.Constant(parameter.name),
            defaultValue
        );

        var parameterType = expressionBuilderContext.TypeFor(parameter.parameterTypeSpecifier);
        var cast = Expression.Convert(resolveParam, parameterType);
        // e.g. (bundle, context) => context.Parameters["Measurement Period"]
        var lambda = Expression.Lambda(cast, expressionBuilderContext.RuntimeContextParameter);
        libraryContext.AddDefinition(parameter.name!, lambda);
    }
}