/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler.Expressions;
using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Compiler;

partial class ExpressionBuilderContext
{
    public void ProcessCodeSystemDef(
        CodeSystemDef codeSystem) =>
        this.CatchRethrowExpressionBuildingException(_ =>
        {
            using (PushElement(codeSystem))
            {
                if (_libraryContext.TryGetCodesByCodeSystemName(codeSystem.name, out var codes))
                {
                    var initMembers = codes
                        .SelectToArray(coding =>
                                           Expression.New(
                                               ConstructorInfos.CqlCode,
                                               Expression.Constant(coding.code),
                                               Expression.Constant(coding.system),
                                               NullExpression.String,
                                               NullExpression.String
                                           ));
                    var arrayOfCodesInitializer = Expression.NewArrayInit(typeof(CqlCode), initMembers);
                    var lambda = Expression.Lambda(arrayOfCodesInitializer, CqlExpressions.ParameterExpression);
                    var codesys = new CqlCodeSystemDefinition(lambda, codeSystem.name!);
                    _libraryContext.LibraryDefinitions.Add(_libraryContext.LibraryVersionedIdentifier, codeSystem.name!, codesys);
                }
                else
                {
                    var newArray = Expression.NewArrayBounds(typeof(CqlCode), Expression.Constant(0, typeof(int)));
                    var lambda = Expression.Lambda(newArray, CqlExpressions.ParameterExpression);
                    var codesys = new CqlCodeSystemDefinition(lambda, codeSystem.name!);
                    _libraryContext.LibraryDefinitions.Add(_libraryContext.LibraryVersionedIdentifier, codeSystem.name!, codesys);
                }
            }
        });


    public void ProcessConceptDef(
        ConceptDef conceptDef) =>
        this.CatchRethrowExpressionBuildingException(_ =>
        {
            using (PushElement(conceptDef))
            {
                if (conceptDef.code.Length <= 0)
                {
                    var newArray = Expression.NewArrayBounds(typeof(CqlCode), Expression.Constant(0, typeof(int)));
                    var lambda = Expression.Lambda(newArray, CqlExpressions.ParameterExpression);
                    var cd = new CqlCodeSystemDefinition(lambda, conceptDef.name!);
                    _libraryContext.LibraryDefinitions.Add(_libraryContext.LibraryVersionedIdentifier, conceptDef.name!, cd);
                }
                else
                {
                    var initMembers = new Expression[conceptDef.code.Length];
                    for (int i = 0; i < conceptDef.code.Length; i++)
                    {
                        var codeRef = conceptDef.code[i];
                        if (!_libraryContext.TryGetCode(codeRef, out var systemCode))
                            throw this.NewExpressionBuildingException(
                                $"Code {codeRef.name} in concept {conceptDef.name} is not defined.", null);

                        initMembers[i] = Expression.New(
                            ConstructorInfos.CqlCode,
                            Expression.Constant(systemCode.code),
                            Expression.Constant(systemCode.system),
                            NullExpression.String,
                            NullExpression.String
                        );
                    }

                    var arrayOfCodesInitializer = Expression.NewArrayInit(typeof(CqlCode), initMembers);
                    var asEnumerable = arrayOfCodesInitializer.NewTypeAsExpression<IEnumerable<CqlCode>>();
                    var display = Expression.Constant(conceptDef.display, typeof(string));
                    var newConcept = Expression.New(ConstructorInfos.CqlConcept!, asEnumerable, display);
                    var lambda = Expression.Lambda(newConcept, CqlExpressions.ParameterExpression);
                    var cd = new CqlCodeSystemDefinition(lambda, conceptDef.name!);
                    _libraryContext.LibraryDefinitions.Add(_libraryContext.LibraryVersionedIdentifier, conceptDef.name, cd);
                }
            }
        });

    public void ProcessCodeDef(
        CodeDef codeDef,
        ISet<(string codeName, string codeSystemUrl)> codeNameCodeSystemUrlsSet) =>
        this.CatchRethrowExpressionBuildingException(_ =>
        {
            using (PushElement(codeDef))
            {
                if (codeDef.codeSystem == null)
                    throw this.NewExpressionBuildingException("Code definition has a null codeSystem node.", null);

                if (!_libraryContext.TryGetCodeSystemName(codeDef.codeSystem, out string? csUrl))
                    throw this.NewExpressionBuildingException($"Undefined code system {codeDef.codeSystem.name!}",
                                                              null);

                if (!codeNameCodeSystemUrlsSet.Add((codeDef.name!, csUrl!)))
                    throw this.NewExpressionBuildingException(
                        $"Duplicate code name detected: {codeDef.name} from {codeDef.codeSystem.name} ({csUrl})", null);

                var systemCode = new CqlCode(codeDef.id, csUrl);
                _libraryContext.AddCode(codeDef, systemCode);

                var newCodingExpression = Expression.New(
                    ConstructorInfos.CqlCode,
                    Expression.Constant(codeDef.id),
                    Expression.Constant(csUrl),
                    NullExpression.String,
                    NullExpression.String!
                );
                var lambda = Expression.Lambda(newCodingExpression, CqlExpressions.ParameterExpression);
                var codDef = new CqlCodeDefinition(lambda, codeDef.name!);
                _libraryContext.LibraryDefinitions.Add(_libraryContext.LibraryVersionedIdentifier, codeDef.name!, codDef);
            }
        });

    public void ProcessExpressionDef(
        ExpressionDef expressionDef) =>
        this.CatchRethrowExpressionBuildingException(_ =>
        {
            if (_operands is null)
                throw new InvalidOperationException("Operands dictionary is null.");

            using (PushElement(expressionDef))
            {
                var expressionDefName = expressionDef.name;
                if (string.IsNullOrWhiteSpace(expressionDefName))
                {
                    throw this.NewExpressionBuildingException(
                        $"Definition with local ID {expressionDef.localId} does not have a name.  This is not allowed.",
                        null);
                }

                var expressionKey = $"{_libraryContext.LibraryVersionedIdentifier}.{expressionDefName}";
                Type[] functionParameterTypes = Type.EmptyTypes;
                var parameters = new[] { CqlExpressions.ParameterExpression };
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
                                $"Operand for function {expressionDefName} is missing its {nameof(operand.operandTypeSpecifier)} property",
                                null);
                    }

                    parameters = [..parameters, .._operands.Values];

                    if (function?.external ?? false)
                    {
                        if (_expressionBuilderSettings.AllowUnresolvedExternals)
                        {
                            var returnType = TypeFor(expressionDef)!;
                            var funcOps = function.operand ?? [];
                            var @params = new (string name, Type type)[funcOps.Length + 1];
                            @params[0] = ("context", CqlExpressions.ParameterExpression.Type);
                            for (int o = 0; o < funcOps.Length; o++)
                                @params[o + 1] = (funcOps[o].name, functionParameterTypes[o]);
                            var notImplemented = NotImplemented(expressionKey, @params, returnType);
                            var paramTypes = @params.Select(p => p.type).ToArray();
                            _libraryContext.LibraryDefinitions.Add(
                                _libraryContext.LibraryVersionedIdentifier,
                                expressionDefName,
                                paramTypes,
                                new CqlExpressionDefinition(notImplemented, expressionDefName));
                            _logger.LogWarning(FormatMessage(
                                                   $"Function '{expressionDefName}' is declared external, but it was not defined in the expression scope. " +
                                                   "A stub has been created that throws a NotImplemented exception."), expressionDef);
                            return;
                        }

                        throw this.NewExpressionBuildingException(
                            $"{expressionKey} is declared external, but it was not defined in the expression scope.");
                    }
                }

                if (function?.operand != null &&
                    _libraryContext.LibraryDefinitions.ContainsKey(_libraryContext.LibraryVersionedIdentifier, expressionDefName, functionParameterTypes))
                {
                    var ops = function.operand
                                      .Where(op => op.operandTypeSpecifier != null && op.operandTypeSpecifier.resultTypeName != null)
                                      .Select(op => $"{op.name} {op.operandTypeSpecifier!.resultTypeName!}");
                    _logger.LogWarning(
                        FormatMessage(
                            $"Function {expressionDefName}({string.Join(", ", ops)}) skipped; another function matching this signature already exists."));
                }
                else
                {
                    var bodyExpression = TranslateArg(expressionDef.expression);
                    var lambda = Expression.Lambda(bodyExpression, parameters);

                    (string name, string[] values)[] tags = [];
                    if (expressionDef.annotation is { Length: > 0 } annotations)
                    {
                        tags = annotations
                               .OfType<Annotation>()
                               .SelectMany(a => a.t ?? [])
                               .SelectWhere(tag => string.IsNullOrWhiteSpace(tag?.name)
                                                       ? default
                                                       : (true, (name: tag.name!, values:(string[])[tag.value ?? ""])))
                               .ToArray();
                    }

                    var def = new CqlExpressionDefinition(lambda, expressionDefName, tags);
                    Type[] signature = functionParameterTypes ?? [];
                    _libraryContext.LibraryDefinitions.Add(_libraryContext.LibraryVersionedIdentifier, expressionDefName, signature, def);
                }
            }
        });

    public void ProcessIncludes(
        IncludeDef includeDef) =>
        this.CatchRethrowExpressionBuildingException(_ =>
        {
            using (PushElement(includeDef))
            {
                var alias = includeDef.libraryName
                            ?? throw this.NewExpressionBuildingException(
                                $"Include {includeDef.localId} does not have a alias.");

                var libNav = includeDef.GetVersionedIdentifier(false) ??
                             throw this.NewExpressionBuildingException(
                                 $"Include {includeDef.localId} does not have a well-formed name and version");
                _libraryContext.AddAliasLibraryVersionedIdentifier(alias, libNav);
            }
        });

    public void ProcessParameterDef(
        ParameterDef parameter) =>
        this.CatchRethrowExpressionBuildingException(_ =>
        {
            using (PushElement(parameter))
            {
                if (_libraryContext.LibraryDefinitions.ContainsKey(_libraryContext.LibraryVersionedIdentifier, parameter.name!))
                    throw this.NewExpressionBuildingException($"There is already a definition named {parameter.name}",
                                                              null);

                Expression? defaultValue = null;
                if (parameter.@default != null)
                    defaultValue = TranslateArg(parameter.@default).NewTypeAsExpression<object>();
                else defaultValue = NullExpression.Object;

                var resolveParam = _cqlContextBinder.ResolveParameter(_libraryContext.LibraryVersionedIdentifier, parameter.name, defaultValue);

                var parameterType = TypeFor(parameter.parameterTypeSpecifier)!;
                var cast = _cqlOperatorsBinder.CastToType(resolveParam, parameterType);
                // e.g. (bundle, context) => context.Parameters["Measurement Period"]
                var lambda = Expression.Lambda(cast, CqlExpressions.ParameterExpression);
                var paramDef = new CqlParameterDefinition(lambda, parameter.name!);
                _libraryContext.LibraryDefinitions.Add(_libraryContext.LibraryVersionedIdentifier, parameter.name!, paramDef);
            }
        });

    public void ProcessValueSetDef(
        ValueSetDef valueSetDef) =>
        this.CatchRethrowExpressionBuildingException(_ =>
        {
            using (PushElement(valueSetDef))
            {
                var @new = Expression.New(ConstructorInfos.CqlValueSet,
                                          Expression.Constant(valueSetDef.id, typeof(string)),
                                          Expression.Constant(valueSetDef.version, typeof(string)));
                var contextParameter = CqlExpressions.ParameterExpression;
                var lambda = Expression.Lambda(@new, contextParameter);
                var def = new CqlValueSetDefinition(lambda, valueSetDef.name!);
                _libraryContext.LibraryDefinitions.Add(_libraryContext.LibraryVersionedIdentifier, valueSetDef.name!, def);
            }
        });
}