using System;
using System.Linq;
using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler.DefinitionBuilding;

#pragma warning disable CS1591
partial class DefinitionsBuilder
{
    private void VisitExpressionDefs(
        LibraryContext libraryContext,
        ExpressionDef[] expressionDefs)
    {
        foreach (var expressionDef in expressionDefs)
        {
            VisitExpressionDef(libraryContext, expressionDef);
        }
    }

    private void VisitExpressionDef(
        LibraryContext libraryContext,
        ExpressionDef expressionDef)
    {
        if (expressionDef.expression == null)
            throw new InvalidOperationException(
                $"Definition {expressionDef.name} does not have an expression property");

        var libraryContextDefinitions = libraryContext.Definitions;
        var expressionBuilderContext = libraryContext.NewExpressionBuilderContext();

        if (string.IsNullOrWhiteSpace(expressionDef.name))
        {
            var message =
                $"Definition with local ID {expressionDef.localId} does not have a name.  This is not allowed.";
            expressionBuilderContext.LogError(message, expressionDef);
            throw new InvalidOperationException(message);
        }

        var libraryKey = libraryContext.Library.NameAndVersion;

        try
        {
            var customKey = $"{libraryKey!}.{expressionDef.name}";
            Type[] functionParameterTypes = Type.EmptyTypes;
            var parameters = new[] { expressionBuilderContext.RuntimeContextParameter };
            var functionDef = expressionDef as FunctionDef;

            if (functionDef != null && functionDef.operand != null)
            {
                functionParameterTypes = new Type[functionDef.operand!.Length];
                int i = 0;
                foreach (var operand in functionDef.operand!)
                {
                    if (operand.operandTypeSpecifier != null)
                    {
                        var operandType = libraryContext.TypeManager.TypeFor(operand.operandTypeSpecifier, expressionBuilderContext)!;
                        var opName = ExpressionBuilderContext.NormalizeIdentifier(operand.name);
                        var parameter = Expression.Parameter(operandType, opName);
                        expressionBuilderContext.Operands.Add(operand.name!, parameter);
                        functionParameterTypes[i] = parameter.Type;
                        i += 1;
                    }
                    else
                        throw new InvalidOperationException(
                            $"Operand for function {expressionDef.name} is missing its {nameof(operand.operandTypeSpecifier)} property");
                }

                parameters = parameters
                    .Concat(expressionBuilderContext.Operands.Values)
                    .ToArray();
                if (libraryContext.CustomImplementations.TryGetValue(customKey, out var factory) && factory != null)
                {
                    var customLambda = factory(parameters);
                    libraryContextDefinitions.Add(libraryKey!, expressionDef.name, functionParameterTypes, customLambda);
                }
                else if (functionDef?.external ?? false)
                {
                    var message =
                        $"{customKey} is declared external, but {nameof(ExpressionBuilder.CustomImplementations)} does not define this function.";
                    expressionBuilderContext.LogError(message, expressionDef);
                    if (libraryContext.Settings.AllowUnresolvedExternals)
                    {
                        var returnType = libraryContext.TypeManager.TypeFor(expressionDef, expressionBuilderContext, throwIfNotFound: true)!;
                        var paramTypes = new[] { typeof(CqlContext) }
                            .Concat(functionParameterTypes)
                            .ToArray();
                        var notImplemented =
                            NotImplemented(customKey, paramTypes, returnType, expressionBuilderContext);
                        libraryContextDefinitions.Add(libraryKey!, expressionDef.name, paramTypes, notImplemented);
                    }
                    else throw new InvalidOperationException(message);
                }
            }
            else
            {
                var innerExpressionBuilderContext = expressionBuilderContext.Deeper(expressionDef);
                var bodyExpression = libraryContext.TranslateExpression(expressionDef.expression, innerExpressionBuilderContext);
                var lambda = Expression.Lambda(bodyExpression, parameters);
                if (functionDef?.operand != null &&
                    libraryContextDefinitions.ContainsKey(libraryKey!, expressionDef.name, functionParameterTypes))
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
                                libraryContextDefinitions.AddTag(libraryKey!, expressionDef.name, functionParameterTypes, name, value);
                            }
                        }
                    }

                    libraryContextDefinitions.Add(libraryKey!, expressionDef.name, functionParameterTypes.OrEmptyArray(), lambda);
                }
            }
        }
        catch (Exception e)
        {
            throw new InvalidOperationException(
                $"Unhandled exception while building statement for definition '{expressionDef.name} 'in library '{libraryKey}'. See InnerException for more details.",
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