using System;
using System.Linq;
using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler.Definitions;

#pragma warning disable CS1591
partial record DefinitionsBuilder
{
    private void Visit(
        DefinitionDictionary<LambdaExpression> definitions, 
        ExpressionDef[] expressionDefs)
    {
        foreach (var expressionDef in expressionDefs) 
            Visit(definitions, expressionDef);
    }

    private void Visit(
        DefinitionDictionary<LambdaExpression> definitions,
        ExpressionDef expressionDef)
    {
        if (expressionDef.expression == null)
            throw new InvalidOperationException(
                $"Definition {expressionDef.name} does not have an expression property");

        var buildContext = new ExpressionBuilderContext(
            ExpressionBuilder,
            Expression.Parameter(typeof(CqlContext), "context"),
            definitions,
            LocalLibraryIdentifiers);

        if (string.IsNullOrWhiteSpace(expressionDef.name))
        {
            var message =
                $"Definition with local ID {expressionDef.localId} does not have a name.  This is not allowed.";
            buildContext.LogError(message, expressionDef);
            throw new InvalidOperationException(message);
        }

        try
        {
            var customKey = $"{Library.NameAndVersion!}.{expressionDef.name}";
            Type[] functionParameterTypes = Type.EmptyTypes;
            var parameters = new[] { buildContext.RuntimeContextParameter };
            var functionDef = expressionDef as FunctionDef;

            if (functionDef != null && functionDef.operand != null)
            {
                functionParameterTypes = new Type[functionDef.operand!.Length];
                int i = 0;
                foreach (var operand in functionDef.operand!)
                {
                    if (operand.operandTypeSpecifier != null)
                    {
                        var operandType = TypeManager.TypeFor(operand.operandTypeSpecifier, buildContext)!;
                        var opName = ExpressionBuilderContext.NormalizeIdentifier(operand.name);
                        var parameter = Expression.Parameter(operandType, opName);
                        buildContext.Operands.Add(operand.name!, parameter);
                        functionParameterTypes[i] = parameter.Type;
                        i += 1;
                    }
                    else
                        throw new InvalidOperationException(
                            $"Operand for function {expressionDef.name} is missing its {nameof(operand.operandTypeSpecifier)} property");
                }

                parameters = parameters
                    .Concat(buildContext.Operands.Values)
                    .ToArray();
                if (ExpressionBuilder.CustomImplementations.TryGetValue(customKey, out var factory) && factory != null)
                {
                    var customLambda = factory(parameters);
                    definitions.Add(Library.NameAndVersion!, expressionDef.name, functionParameterTypes, customLambda);
                }
                else if (functionDef?.external ?? false)
                {
                    var message =
                        $"{customKey} is declared external, but {nameof(ExpressionBuilder.CustomImplementations)} does not define this function.";
                    buildContext.LogError(message, expressionDef);
                    if (ExpressionBuilder.Settings.AllowUnresolvedExternals)
                    {
                        var returnType = TypeManager.TypeFor(expressionDef, buildContext, throwIfNotFound: true)!;
                        var paramTypes = new[] { typeof(CqlContext) }
                            .Concat(functionParameterTypes)
                            .ToArray();
                        var notImplemented =
                            NotImplemented(customKey, paramTypes, returnType, buildContext);
                        definitions.Add(Library.NameAndVersion!, expressionDef.name, paramTypes, notImplemented);
                    }
                    else throw new InvalidOperationException(message);
                }
            }
            else
            {
                var innerExpressionBuilderContext = buildContext.Deeper(expressionDef);
                var bodyExpression = ExpressionBuilder.TranslateExpression(expressionDef.expression, innerExpressionBuilderContext);
                var lambda = Expression.Lambda(bodyExpression, parameters);
                if (functionDef?.operand != null &&
                    definitions.ContainsKey(Library.NameAndVersion!, expressionDef.name, functionParameterTypes))
                {
                    var ops = functionDef.operand
                        .Where(op =>
                            op.operandTypeSpecifier != null && op.operandTypeSpecifier.resultTypeName != null)
                        .Select(op => $"{op.name} {op.operandTypeSpecifier!.resultTypeName!}");
                    var message =
                        $"Function {expressionDef.name}({string.Join(", ", ops)}) skipped; another function matching this signature already exists.";
                    innerExpressionBuilderContext.LogWarning(message, expressionDef);
                }
                else
                {
                    foreach (var annotation in (expressionDef.annotation?.OfType<Annotation>()).OrEmptyEnumerable())
                    {
                        foreach (var tag in annotation.t.OrEmptyEnumerable())
                        {
                            var name = tag.name;
                            if (!string.IsNullOrWhiteSpace(name))
                            {
                                var value = tag.value ?? string.Empty;
                                definitions.AddTag(Library.NameAndVersion!, expressionDef.name, functionParameterTypes, name, value);
                            }
                        }
                    }

                    definitions.Add(Library.NameAndVersion!, expressionDef.name, functionParameterTypes.OrEmptyArray(), lambda);
                }
            }
        }
        catch (Exception e)
        {
            throw new InvalidOperationException(
                $"Unhandled exception while building statement for definition '{expressionDef.name} 'in library '{Library.NameAndVersion}'. See InnerException for more details.",
                e);
        }
    }

    private static LambdaExpression NotImplemented(string nav, Type[] functionParameterTypes, Type returnType, ExpressionBuilderContext context)
    {
        var parameters = functionParameterTypes
            .Select((type, index) => Expression.Parameter(type, ExpressionBuilder.TypeNameToIdentifier(type, context) + index))
            .ToArray();
        var ctor = ConstructorInfos.NotImplementedException;
        var @new = Expression.New(ctor, Expression.Constant($"External function {nav} is not implemented."));
        var @throw = Expression.Throw(@new, returnType);
        var lambda = Expression.Lambda(@throw, parameters);
        //var funcTypes = new Type[functionParameterTypes.Length + 1];
        //Array.Copy(functionParameterTypes, funcTypes, functionParameterTypes.Length);
        //funcTypes[funcTypes.Length - 1] = returnType;
        //var funcType = GetFuncType(funcTypes);
        //var makeLambda = MakeGenericLambda.Value.MakeGenericMethod(funcType);
        //var lambda = (LambdaExpression)makeLambda.Invoke(null, new object[] { @throw, parameters });
        return lambda;
    }
}