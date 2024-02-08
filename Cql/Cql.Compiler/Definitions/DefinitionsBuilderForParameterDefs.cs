using System;
using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler.Definitions;

#pragma warning disable CS1591
internal record DefinitionsBuilderForParameterDefs(
    DefinitionsBuilderForLibrary OuterLib, 
    DefinitionDictionary<LambdaExpression> Definitions, 
    ParameterDef[] ParameterDefs)
{
    public void AddToDefinitions(DefinitionDictionary<LambdaExpression> definitions)
    {
        DefinitionsBuilderForLibrary lib = OuterLib;
        var expressionBuilder = lib.ExpressionBuilder;

        foreach (var parameter in ParameterDefs)
        {
            if (Definitions.ContainsKey(null, parameter.name!))
                throw new InvalidOperationException(
                    $"There is already a definition named {parameter.name}");

            var buildContext = new ExpressionBuilderContext(
                expressionBuilder,
                Expression.Parameter(typeof(CqlContext), "context"),
                Definitions,
                lib.LocalLibraryIdentifiers);

            Expression? defaultValue = null;
            if (parameter.@default != null)
                defaultValue = Expression.TypeAs(expressionBuilder.TranslateExpression(parameter.@default, buildContext),
                    typeof(object));
            else defaultValue = Expression.Constant(null, typeof(object));

            var resolveParam = Expression.Call(
                buildContext.RuntimeContextParameter,
                typeof(CqlContext).GetMethod(nameof(CqlContext.ResolveParameter))!,
                Expression.Constant(lib.Library.NameAndVersion),
                Expression.Constant(parameter.name),
                defaultValue
            );

            var parameterType = lib.TypeManager.TypeFor(parameter.parameterTypeSpecifier!, buildContext);
            var cast = Expression.Convert(resolveParam, parameterType);
            // e.g. (bundle, context) => context.Parameters["Measurement Period"]
            var lambda = Expression.Lambda(cast, buildContext.RuntimeContextParameter);

            Definitions.Add(lib.Library.NameAndVersion!, parameter.name!, lambda);
        }
    }
}