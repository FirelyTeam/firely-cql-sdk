/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
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
                if (!_libraryContext.TryGetCodesByCodeSystemName(codeSystem.name, out var codes))
                    codes = [];

                var cqlCodeSystem = new CqlCodeSystem(codeSystem.id, codeSystem.version, codes);
                var cqlCodeSystemDefinition = new CqlCodeSystemDefinition(codeSystem.name!, cqlCodeSystem);
                _libraryContext.LibraryDefinitions.AddDefinition(_libraryContext.LibraryVersionedIdentifier, codeSystem.name!, cqlCodeSystemDefinition);
            }
        });


    public void ProcessConceptDef(
        ConceptDef conceptDef) =>
        this.CatchRethrowExpressionBuildingException(_ =>
        {
            using (PushElement(conceptDef))
            {
                var conceptDefName = conceptDef.name!;
                CqlCode[] cqlCodes = [];
                if (conceptDef.code is { Length: > 0 } codeRefs)
                {
                    cqlCodes = codeRefs.SelectToArray(codeRef =>
                    {
                        if (!_libraryContext.TryGetCode(codeRef, out var systemCode))
                            throw this.NewExpressionBuildingException(
                                $"Code {codeRef.name} in concept {conceptDefName} is not defined.", null);
                        return new CqlCode(systemCode.code, systemCode.system /*, systemCode.version, systemCode.display*/);
                    });
                }
                var cqlConceptDefinition = new CqlConceptDefinition(conceptDefName, conceptDef.display, cqlCodes);
                _libraryContext.LibraryDefinitions.AddDefinition(_libraryContext.LibraryVersionedIdentifier, conceptDefName, cqlConceptDefinition);
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

                var cqlCode = new CqlCode(codeDef.id, csUrl);
                _libraryContext.AddCode(codeDef, cqlCode);
                var cqlCodeDefinition = new CqlCodeDefinition(codeDef.name, cqlCode);
                _libraryContext.LibraryDefinitions.AddDefinition(_libraryContext.LibraryVersionedIdentifier, codeDef.name, cqlCodeDefinition);
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
                            var definition = new CqlFunctionDefinition(notImplemented, expressionDefName);
                            _libraryContext.LibraryDefinitions.AddDefinition(_libraryContext.LibraryVersionedIdentifier, new(expressionDefName, paramTypes), definition);
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
                    _libraryContext.LibraryDefinitions.ContainsDefinition(_libraryContext.LibraryVersionedIdentifier,
                                                                          new(expressionDefName, functionParameterTypes)))
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
                                                       : (true, (name: tag.name!, values: (string[]) [tag.value ?? ""])))
                               .ToArray();
                    }

                    var def = new CqlExpressionDefinition(lambda, expressionDefName, tags);
                    Type[] signature = functionParameterTypes ?? [];
                    _libraryContext.LibraryDefinitions.AddDefinition(_libraryContext.LibraryVersionedIdentifier, new(expressionDefName, signature), def);
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

                var libNav = includeDef.GetVersionedLibraryIdentifierString() ??
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
                var parameterName = parameter.name!;
                if (_libraryContext.LibraryDefinitions.ContainsDefinition(_libraryContext.LibraryVersionedIdentifier, parameterName))
                    throw this.NewExpressionBuildingException($"There is already a definition named {parameterName}",
                                                              null);

                var defaultValue =
                    parameter.@default != null
                        ? TranslateArg(parameter.@default).NewTypeAsExpression<object>()
                        : NullExpression.Object;
                var resolveParam = _cqlContextBinder.ResolveParameter(_libraryContext.LibraryVersionedIdentifier, parameterName, defaultValue);

                var parameterType = TypeFor(parameter.parameterTypeSpecifier)!;
                var cast = _cqlOperatorsBinder.CastToType(resolveParam, parameterType);
                // e.g. (bundle, context) => context.Parameters["Measurement Period"]
                var lambda = Expression.Lambda(cast, CqlExpressions.ParameterExpression);
                var paramDef = new CqlParameterDefinition(lambda, parameterName);
                _libraryContext.LibraryDefinitions.AddDefinition(_libraryContext.LibraryVersionedIdentifier, parameterName, paramDef);
            }
        });

    public void ProcessValueSetDef(
        ValueSetDef valueSetDef) =>
        this.CatchRethrowExpressionBuildingException(_ =>
        {
            using (PushElement(valueSetDef))
            {
                var def = new CqlValueSetDefinition(valueSetDef.name!, valueSetDef.id, valueSetDef.version);
                _libraryContext.LibraryDefinitions.AddDefinition(_libraryContext.LibraryVersionedIdentifier, valueSetDef.name!, def);
            }
        });
}