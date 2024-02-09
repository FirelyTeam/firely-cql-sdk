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
    private void VisitExpressionDef(
        LibraryContext libraryContext,
        ExpressionDef expressionDef)
    {
        if (expressionDef.expression == null)
            throw new InvalidOperationException(
                $"Definition '{expressionDef.name}' does not have an expression property");

        var builderContext = libraryContext.NewExpressionBuilderContext();

        if (string.IsNullOrWhiteSpace(expressionDef.name))
        {
            var message =
                $"Definition with local ID {expressionDef.localId} does not have a name.  This is not allowed.";
            builderContext.LogError(message, expressionDef);
            throw new InvalidOperationException(message);
        }

        var expressionKey = $"{libraryContext.LibraryKey}.{expressionDef.name}";
        Type[] functionParameterTypes = Type.EmptyTypes;
        var parameters = new[] { builderContext.RuntimeContextParameter };
        var function = expressionDef as FunctionDef;
        if (function is { operand: not null })
        {
            functionParameterTypes = new Type[function.operand!.Length];
            int i = 0;
            foreach (var operand in function.operand!)
            {
                if (operand.operandTypeSpecifier != null)
                {
                    var operandType = libraryContext.TypeManager.TypeFor(operand.operandTypeSpecifier, builderContext)!;
                    var opName = ExpressionBuilderContext.NormalizeIdentifier(operand.name);
                    var parameter = Expression.Parameter(operandType, opName);
                    builderContext.Operands.Add(operand.name!, parameter);
                    functionParameterTypes[i] = parameter.Type;
                    i += 1;
                }
                else
                    throw new InvalidOperationException(
                        $"Operand for function {expressionDef.name} is missing its {nameof(operand.operandTypeSpecifier)} property");
            }

            parameters = parameters
                .Concat(builderContext.Operands.Values)
                .ToArray();
            if (libraryContext.TryGetCustomImplementationByExpressionKey(expressionKey, out var factory))
            {
                var customLambda = factory(parameters);
                libraryContext.AddDefinition(expressionDef.name, functionParameterTypes, customLambda);
                return;
            }

            if (function?.external ?? false)
            {
                var message = $"{expressionKey} is declared external, but {nameof(ExpressionBuilder.CustomImplementations)} does not define this function.";
                builderContext.LogError(message, expressionDef);
                if (libraryContext.AllowUnresolvedExternals)
                {
                    var returnType =
                        libraryContext.TypeManager.TypeFor(expressionDef, builderContext, throwIfNotFound: true)!;
                    var paramTypes = new[] { typeof(CqlContext) }
                        .Concat(functionParameterTypes)
                        .ToArray();
                    var notImplemented = NotImplemented(expressionKey, paramTypes, returnType, builderContext);
                    libraryContext.AddDefinition(expressionDef.name, paramTypes, notImplemented);
                    return;
                }

                throw new InvalidOperationException(message);
            }
        }

        builderContext = builderContext.Deeper(expressionDef);
        var bodyExpression = libraryContext.TranslateExpression(expressionDef.expression, builderContext);
        var lambda = Expression.Lambda(bodyExpression, parameters);
        if (function?.operand != null && libraryContext.ContainsDefinition(expressionDef.name, functionParameterTypes))
        {
            var ops = function.operand
                .Where(op => op.operandTypeSpecifier != null && op.operandTypeSpecifier.resultTypeName != null)
                .Select(op => $"{op.name} {op.operandTypeSpecifier!.resultTypeName!}");
            var message =
                $"Function {expressionDef.name}({string.Join(", ", ops)}) skipped; another function matching this signature already exists.";
            builderContext.LogWarning(message, expressionDef);
        }
        else
        {
            if (expressionDef.annotation is { Length: > 0 } annotations)
            {
                var tags = annotations.OfType<Annotation>()
                    .SelectMany(a => a.t)
                    .Where(tag => !string.IsNullOrWhiteSpace(tag.name));

                foreach (var tag in tags)
                {
                    libraryContext.AddDefinitionTag(expressionDef.name, functionParameterTypes, tag.name, tag.value.OrEmptyString());
                }
            }

            libraryContext.AddDefinition(expressionDef.name, functionParameterTypes.OrEmptyArray(), lambda);
        }
    }

    private static LambdaExpression NotImplemented(
        string nav,
        Type[] functionParameterTypes,
        Type returnType,
        ExpressionBuilderContext context)
    {
        var parameters = functionParameterTypes
            .Select((type, index) =>
                Expression.Parameter(type, ExpressionBuilder.TypeNameToIdentifier(type, context) + index))
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