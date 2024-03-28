using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler;

partial class LibraryExpressionBuilder
{
    public DefinitionDictionary<LambdaExpression> ProcessLibrary()
    {
        _logger.LogInformation("Building expressions for '{library}'", LibraryKey);

        if (Library.includes is { Length: > 0 } includeDefs)
        {
            foreach (var includeDef in includeDefs)
            {
                CreateExpressionBuilder().ProcessIncludes(includeDef);
            }
            AddLibraryDefinitionsFromIncludes();
            AddCodeSystemRefsFromIncludes();
        }

        if (Library.valueSets is { Length: > 0 } valueSetDefs)
        {
            foreach (var valueSetDef in valueSetDefs)
            {
                CreateExpressionBuilder().ProcessValueSetDef(valueSetDef);
            }
        }

        if (Library.codes is { Length: > 0 } codeDefs)
        {
            HashSet<(string codeName, string codeSystemUrl)> foundCodeNameCodeSystemUrls = new();

            foreach (var codeDef in codeDefs)
            {
                CreateExpressionBuilder().ProcessCodeDef(codeDef, foundCodeNameCodeSystemUrls);
            }
        }

        if (Library.codeSystems is { Length: > 0 } codeSystemDefs)
        {
            foreach (var codeSystemDef in codeSystemDefs)
            {
                CreateExpressionBuilder().ProcessCodeSystemDef(codeSystemDef);
            }
        }

        if (Library.concepts is { Length: > 0 } conceptDefs)
        {
            foreach (var conceptDef in conceptDefs)
            {
                CreateExpressionBuilder().ProcessConceptDef(conceptDef);
            }
        }

        if (Library.parameters is { Length: > 0 } parameterDefs)
        {
            foreach (var parameterDef in parameterDefs)
            {
                CreateExpressionBuilder().ProcessParameterDef(parameterDef);
            }
        }

        if (Library.statements is { Length: > 0 } expressionDefs)
        {
            foreach (var expressionDef in expressionDefs)
            {
                CreateExpressionBuilder().ProcessExpressionDef(expressionDef);
            }
        }

        return LibraryDefinitions;
    }

}

partial class ExpressionBuilder
{
    public void ProcessCodeSystemDef(
        CodeSystemDef codeSystem)
    {
        using (PushElement(codeSystem))
        {
            if (LibraryContext.TryGetCodesByCodeSystemName(codeSystem.name, out var codes))
            {
                var initMembers = codes
                    .Select(coding =>
                        Expression.New(
                            ConstructorInfos.CqlCode,
                            Expression.Constant(coding.code),
                            Expression.Constant(coding.system),
                            Expression.Constant(null, typeof(string)),
                            Expression.Constant(null, typeof(string))
                        ))
                    .ToArray();
                var arrayOfCodesInitializer = Expression.NewArrayInit(typeof(CqlCode), initMembers);
                var contextParameter = LibraryDefinitionsBuilder.ContextParameter;
                var lambda = Expression.Lambda(arrayOfCodesInitializer, contextParameter);
                LibraryContext.LibraryDefinitions.Add(LibraryContext.LibraryKey, codeSystem.name, lambda);
            }
            else
            {
                var newArray =
                    Expression.NewArrayBounds(typeof(CqlCode), Expression.Constant(0, typeof(int)));
                var contextParameter = LibraryDefinitionsBuilder.ContextParameter;
                var lambda = Expression.Lambda(newArray, contextParameter);
                LibraryContext.LibraryDefinitions.Add(LibraryContext.LibraryKey, codeSystem.name, lambda);
            }
        }
    }

    public void ProcessConceptDef(
        ConceptDef conceptDef)
    {
        using (PushElement(conceptDef))
        {
            if (conceptDef.code.Length <= 0)
            {
                var newArray =
                    Expression.NewArrayBounds(typeof(CqlCode), Expression.Constant(0, typeof(int)));
                var contextParameter = LibraryDefinitionsBuilder.ContextParameter;
                var lambda = Expression.Lambda(newArray, contextParameter);
                LibraryContext.LibraryDefinitions.Add(LibraryContext.LibraryKey, conceptDef.name, lambda);
            }
            else
            {
                var initMembers = new Expression[conceptDef.code.Length];
                for (int i = 0; i < conceptDef.code.Length; i++)
                {
                    var codeRef = conceptDef.code[i];
                    if (!LibraryContext.TryGetCode(codeRef, out var systemCode))
                        throw this.NewExpressionBuildingException(
                            $"Code {codeRef.name} in concept {conceptDef.name} is not defined.", null);

                    initMembers[i] = Expression.New(
                        ConstructorInfos.CqlCode,
                        Expression.Constant(systemCode.code),
                        Expression.Constant(systemCode.system),
                        Expression.Constant(null, typeof(string)),
                        Expression.Constant(null, typeof(string))
                    );
                }

                var arrayOfCodesInitializer = Expression.NewArrayInit(typeof(CqlCode), initMembers);
                var asEnumerable = Expression.TypeAs(arrayOfCodesInitializer, typeof(IEnumerable<CqlCode>));
                var display = Expression.Constant(conceptDef.display, typeof(string));
                var newConcept = Expression.New(ConstructorInfos.CqlConcept!, asEnumerable, display);
                var contextParameter = LibraryDefinitionsBuilder.ContextParameter;
                var lambda = Expression.Lambda(newConcept, contextParameter);
                LibraryContext.LibraryDefinitions.Add(LibraryContext.LibraryKey, conceptDef.name, lambda);
            }
        }
    }

    public void ProcessCodeDef(
        CodeDef codeDef,
        ISet<(string codeName, string codeSystemUrl)> codeNameCodeSystemUrlsSet)
    {
        using (PushElement(codeDef))
        {

            if (codeDef.codeSystem == null)
                throw this.NewExpressionBuildingException("Code definition has a null codeSystem node.", null);

            if (!LibraryContext.TryGetCodeSystemName(codeDef.codeSystem, out string? csUrl))
                throw this.NewExpressionBuildingException($"Undefined code system {codeDef.codeSystem.name!}", null);

            if (!codeNameCodeSystemUrlsSet.Add((codeDef.name!, csUrl!)))
                throw this.NewExpressionBuildingException(
                    $"Duplicate code name detected: {codeDef.name} from {codeDef.codeSystem.name} ({csUrl})", null);

            var systemCode = new CqlCode(codeDef.id, csUrl);
            LibraryContext.AddCode(codeDef, systemCode);

            var newCodingExpression = Expression.New(
                ConstructorInfos.CqlCode,
                Expression.Constant(codeDef.id),
                Expression.Constant(csUrl),
                Expression.Constant(null, typeof(string)),
                Expression.Constant(null, typeof(string))!
            );
            var contextParameter = LibraryDefinitionsBuilder.ContextParameter;
            var lambda = Expression.Lambda(newCodingExpression, contextParameter);
            LibraryContext.LibraryDefinitions.Add(LibraryContext.LibraryKey, codeDef.name!, lambda);
        }
    }

    public void ProcessExpressionDef(
        ExpressionDef expressionDef)
    {
        using (PushElement(expressionDef))
        {
            if (string.IsNullOrWhiteSpace(expressionDef.name))
            {
                throw this.NewExpressionBuildingException($"Definition with local ID {expressionDef.localId} does not have a name.  This is not allowed.", null);
            }

            var expressionKey = $"{LibraryContext.LibraryKey}.{expressionDef.name}";
            Type[] functionParameterTypes = Type.EmptyTypes;
            var parameters = new[] { LibraryDefinitionsBuilder.ContextParameter };
            var function = expressionDef as FunctionDef;
            if (function is { operand: not null })
            {
                functionParameterTypes = new Type[function.operand!.Length];
                int i = 0;
                foreach (var operand in function.operand!)
                {
                    if (operand.operandTypeSpecifier != null)
                    {
                        var operandType = TypeFor(operand.operandTypeSpecifier)!;
                        var opName = NormalizeIdentifier(operand.name);
                        var parameter = Expression.Parameter(operandType, opName);
                        _operands.Add(operand.name, parameter);
                        functionParameterTypes[i] = parameter.Type;
                        i += 1;
                    }
                    else
                        throw this.NewExpressionBuildingException(
                            $"Operand for function {expressionDef.name} is missing its {nameof(operand.operandTypeSpecifier)} property",
                            null);
                }

                parameters = parameters
                    .Concat(_operands.Values)
                    .ToArray();
                if (TryGetCustomImplementationByExpressionKey(expressionKey, out var factory))
                {
                    var customLambda = factory(parameters);
                    LibraryContext.LibraryDefinitions.Add(LibraryContext.LibraryKey, expressionDef.name, functionParameterTypes, customLambda);
                    return;
                }

                if (function?.external ?? false)
                {
                    if (LibraryContext.AllowUnresolvedExternals)
                    {
                        var returnType = TypeFor(expressionDef)!;
                        var paramTypes = new[] { typeof(CqlContext) }
                            .Concat(functionParameterTypes)
                            .ToArray();
                        var notImplemented = NotImplemented(this, expressionKey, paramTypes, returnType);
                        LibraryContext.LibraryDefinitions.Add(LibraryContext.LibraryKey, expressionDef.name, paramTypes, notImplemented);
                        _logger.LogWarning(FormatMessage($"Function '{expressionDef.name}' is declared external, but it was not defined in the expression scope. " +
                                                              "A stub has been created that throws a NotImplemented exception."), expressionDef);
                        return;
                    }

                    throw this.NewExpressionBuildingException($"{expressionKey} is declared external, but it was not defined in the expression scope.");
                }
            }

            //ctx = ctx.Deeper(expressionDef);
            var bodyExpression = TranslateExpression(expressionDef.expression);
            var lambda = Expression.Lambda(bodyExpression, parameters);
            if (function?.operand != null &&
                LibraryContext.LibraryDefinitions.ContainsKey(LibraryContext.LibraryKey, expressionDef.name, functionParameterTypes))
            {
                var ops = function.operand
                    .Where(op => op.operandTypeSpecifier != null && op.operandTypeSpecifier.resultTypeName != null)
                    .Select(op => $"{op.name} {op.operandTypeSpecifier!.resultTypeName!}");
                _logger.LogWarning(FormatMessage($"Function {expressionDef.name}({string.Join(", ", ops)}) skipped; another function matching this signature already exists."));
            }
            else
            {
                if (expressionDef.annotation is { Length: > 0 } annotations)
                {
                    var tags = annotations.OfType<Annotation>()
                        .SelectMany(a => a.t ?? Enumerable.Empty<Tag>())
                        .Where(tag => !string.IsNullOrWhiteSpace(tag?.name));

                    foreach (var tag in tags)
                    {
                        string[] values = new[] { tag.value ?? "" };
                        LibraryContext.LibraryDefinitions.AddTag(LibraryContext.LibraryKey, expressionDef.name, functionParameterTypes, tag.name, values);
                    }
                }

                Type[] signature = functionParameterTypes ?? Array.Empty<Type>();
                LibraryContext.LibraryDefinitions.Add(LibraryContext.LibraryKey, expressionDef.name, signature, lambda);
            }
        }
    }

    public void ProcessIncludes(
        IncludeDef includeDef)
    {
        using (PushElement(includeDef))
        {
            var alias = includeDef.libraryName
                    ?? throw this.NewExpressionBuildingException($"Include {includeDef.localId} does not have a alias.");

            var libNav = includeDef.NameAndVersion(false) ??
                         throw this.NewExpressionBuildingException($"Include {includeDef.localId} does not have a well-formed name and version");
            LibraryContext.AddAliasForNameAndVersion(alias, libNav);
        }
    }

    public void ProcessParameterDef(
        ParameterDef parameter)
    {
        using (PushElement(parameter))
        {
            if (LibraryContext.LibraryDefinitions.ContainsKey(LibraryContext.LibraryKey, parameter.name!))
                throw this.NewExpressionBuildingException($"There is already a definition named {parameter.name}", null);

            Expression? defaultValue = null;
            if (parameter.@default != null)
                defaultValue = Expression.TypeAs(TranslateExpression(parameter.@default), typeof(object));
            else defaultValue = Expression.Constant(null, typeof(object));

            var resolveParam = Expression.Call(
                LibraryDefinitionsBuilder.ContextParameter,
                typeof(CqlContext).GetMethod(nameof(CqlContext.ResolveParameter))!,
                Expression.Constant(LibraryContext.LibraryKey),
                Expression.Constant(parameter.name),
                defaultValue
            );

            var parameterType = TypeFor(parameter.parameterTypeSpecifier);
            var cast = Expression.Convert(resolveParam, parameterType);
            // e.g. (bundle, context) => context.Parameters["Measurement Period"]
            var lambda = Expression.Lambda(cast, LibraryDefinitionsBuilder.ContextParameter);
            LibraryContext.LibraryDefinitions.Add(LibraryContext.LibraryKey, parameter.name!, lambda);
        }
    }

    public void ProcessValueSetDef(
        ValueSetDef valueSetDef)
    {
        using (PushElement(valueSetDef))
        {
            var @new = Expression.New(ConstructorInfos.CqlValueSet, Expression.Constant(valueSetDef.id, typeof(string)),
                Expression.Constant(valueSetDef.version, typeof(string)));
            var contextParameter = LibraryDefinitionsBuilder.ContextParameter;
            var lambda = Expression.Lambda(@new, contextParameter);
            LibraryContext.LibraryDefinitions.Add(LibraryContext.LibraryKey, valueSetDef.name!, lambda);
        }
    }

    private static LambdaExpression NotImplemented(
        ExpressionBuilder ctx,
        string nav,
        Type[] signature,
        Type returnType)
    {
        var parameters = signature
            .Select((type, index) =>
                Expression.Parameter(type, TypeNameToIdentifier(type, ctx) + index))
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