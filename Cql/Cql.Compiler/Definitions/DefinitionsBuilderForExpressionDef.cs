using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler.Definitions;

#pragma warning disable CS1591
internal record DefinitionsBuilderForExpressionDef(
    DefinitionsBuilderForExpressionDefs OuterStatements,
    ExpressionDef ExpressionDef,
    ExpressionBuilderContext BuildContext)
{
    public void Build()
    {
        ExpressionDef def = ExpressionDef;
        ExpressionBuilderContext buildContext = BuildContext;
        var lib = OuterStatements.OuterLib;
        var expressionBuilder = lib.ExpressionBuilder;
        var customKey = $"{lib.Library.NameAndVersion!}.{def.name}";
        Type[] functionParameterTypes = Type.EmptyTypes;
        var parameters = new[] { buildContext.RuntimeContextParameter };
        var function = def as FunctionDef;
        var definitions = OuterStatements.Definitions;

        if (function != null && function.operand != null)
        {
            functionParameterTypes = new Type[function.operand!.Length];
            int i = 0;
            foreach (var operand in function.operand!)
            {
                if (operand.operandTypeSpecifier != null)
                {
                    var operandType = lib.TypeManager.TypeFor(operand.operandTypeSpecifier, buildContext)!;
                    var opName = ExpressionBuilderContext.NormalizeIdentifier(operand.name);
                    var parameter = Expression.Parameter(operandType, opName);
                    buildContext.Operands.Add(operand.name!, parameter);
                    functionParameterTypes[i] = parameter.Type;
                    i += 1;
                }
                else
                    throw new InvalidOperationException(
                        $"Operand for function {def.name} is missing its {nameof(operand.operandTypeSpecifier)} property");
            }

            parameters = parameters
                .Concat(buildContext.Operands.Values)
                .ToArray();
            if (expressionBuilder.CustomImplementations.TryGetValue(customKey, out var factory) && factory != null)
            {
                var customLambda = factory(parameters);
                definitions.Add(lib.Library.NameAndVersion!, def.name, functionParameterTypes, customLambda);
                return;
            }
            else if (function?.external ?? false)
            {
                var message =
                    $"{customKey} is declared external, but {nameof(ExpressionBuilder.CustomImplementations)} does not define this function.";
                buildContext.LogError(message, def);
                if (lib.ExpressionBuilder.Settings.AllowUnresolvedExternals)
                {
                    var returnType = lib.TypeManager.TypeFor(def, buildContext, throwIfNotFound: true)!;
                    var paramTypes = new[] { typeof(CqlContext) }
                        .Concat(functionParameterTypes)
                        .ToArray();
                    var notImplemented =
                        NotImplemented(customKey, paramTypes, returnType, buildContext);
                    definitions.Add(lib.Library.NameAndVersion!, def.name, paramTypes, notImplemented);
                    return;
                }
                else throw new InvalidOperationException(message);
            }
        }

        buildContext = buildContext.Deeper(def);
        var bodyExpression = lib.ExpressionBuilder.TranslateExpression(def.expression, buildContext);
        var lambda = Expression.Lambda(bodyExpression, parameters);
        if (function?.operand != null &&
            definitions.ContainsKey(lib.Library.NameAndVersion!, def.name, functionParameterTypes))
        {
            var ops = function.operand
                .Where(op =>
                    op.operandTypeSpecifier != null && op.operandTypeSpecifier.resultTypeName != null)
                .Select(op => $"{op.name} {op.operandTypeSpecifier!.resultTypeName!}");
            var message =
                $"Function {def.name}({string.Join(", ", ops)}) skipped; another function matching this signature already exists.";
            buildContext.LogWarning(message, def);
        }
        else
        {
            foreach (var annotation in def.annotation?.OfType<Annotation>() ??
                                       Enumerable.Empty<Annotation>())
            {
                foreach (var tag in annotation.t ?? Enumerable.Empty<Tag>())
                {
                    var name = tag.name;
                    if (!string.IsNullOrWhiteSpace(name))
                    {
                        var value = tag.value ?? string.Empty;
                        definitions.AddTag(lib.Library.NameAndVersion!, def.name, functionParameterTypes, name, value);
                    }
                }
            }

            definitions.Add(lib.Library.NameAndVersion!, def.name, functionParameterTypes ?? Array.Empty<Type>(), lambda);
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