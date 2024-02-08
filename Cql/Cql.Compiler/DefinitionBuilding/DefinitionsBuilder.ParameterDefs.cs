using System;
using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler.Definitions;

#pragma warning disable CS1591
internal partial record DefinitionsBuilder
{
    private void Visit(
        DefinitionDictionary<LambdaExpression> definitions,
        ParameterDef[] parameterDefs)
    {
        foreach (var parameter in parameterDefs)
            Visit(definitions, parameter);
    }

    private void Visit(
        DefinitionDictionary<LambdaExpression> definitions,
        ParameterDef parameter)
    {
        if (definitions.ContainsKey(null, parameter.name!))
            throw new InvalidOperationException(
                $"There is already a definition named {parameter.name}");

        var buildContext = new ExpressionBuilderContext(
            ExpressionBuilder,
            Expression.Parameter(typeof(CqlContext), "context"),
            definitions,
            LocalLibraryIdentifiers);

        Expression? defaultValue = null;
        if (parameter.@default != null)
            defaultValue = Expression.TypeAs(ExpressionBuilder.TranslateExpression(parameter.@default, buildContext),
                typeof(object));
        else defaultValue = Expression.Constant(null, typeof(object));

        var resolveParam = Expression.Call(
            buildContext.RuntimeContextParameter,
            typeof(CqlContext).GetMethod(nameof(CqlContext.ResolveParameter))!,
            Expression.Constant(Library.NameAndVersion),
            Expression.Constant(parameter.name),
            defaultValue
        );

        var parameterType = TypeManager.TypeFor(parameter.parameterTypeSpecifier!, buildContext);
        var cast = Expression.Convert(resolveParam, parameterType);
        // e.g. (bundle, context) => context.Parameters["Measurement Period"]
        var lambda = Expression.Lambda(cast, buildContext.RuntimeContextParameter);
        definitions.Add(Library.NameAndVersion!, parameter.name!, lambda);
    }
}