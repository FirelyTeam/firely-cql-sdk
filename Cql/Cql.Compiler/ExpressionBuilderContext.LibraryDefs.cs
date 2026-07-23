/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Processing the library's top-level definitions (codes, code systems, concepts, includes,
/// parameters, value sets and expression/function definitions) into
/// <see cref="CqlDefinition"/>s on the library context.
/// </summary>
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
        ExpressionDef expressionDef)
    {
        this.CatchRethrowExpressionBuildingException(_ =>
        {
            using (PushElement(expressionDef))
            {
                if (_operands is null)
                    throw new InvalidOperationException("Operands dictionary is null.");

                var expressionDefName = expressionDef.name;
                if (string.IsNullOrWhiteSpace(expressionDefName))
                {
                    throw this.NewExpressionBuildingException(
                        $"Definition with local ID {expressionDef.localId} does not have a name.  This is not allowed.",
                        null);
                }

                var expressionKey = $"{_libraryContext.LibraryVersionedIdentifier}.{expressionDefName}";
                Type[] parameterTypes = [];

                // NOTE(phase4): unlike the old CqlLambdaDefinition, the IR lambda for a definition
                // does not carry the CqlContext parameter (see CqlLambdaDefinition remarks) — this
                // array holds only the CQL operand locals, so it starts empty instead of
                // `[CqlExpressions.ParameterExpression]`.
                CodeLocal[] parameters = [];
                IReadOnlyDictionary<string, string> originalParameterNames = new Dictionary<string, string>();

                // Handle function definitions
                if (expressionDef is FunctionDef { operand: { } operands, external: var isExternalFunction } functionDef)
                {
                    (parameterTypes, originalParameterNames) = BuildParameterTypes(operands, expressionDefName);
                    parameters = [.. _operands.Values];

                    if (isExternalFunction)
                    {
                        HandleExternalFunction(expressionKey, functionDef, parameterTypes, expressionDefName);
                        return;
                    }

                    // Check for duplicate function signatures
                    var isDuplicate = _libraryContext.LibraryDefinitions.ContainsDefinition(_libraryContext.LibraryVersionedIdentifier, new(expressionDefName, parameterTypes));
                    if (isDuplicate)
                    {
                        if (_logger.IsEnabled(LogLevel.Warning))
                        {
                            IEnumerable<string> ops = operands
                                                      .Where(op => op.operandTypeSpecifier != null && op.operandTypeSpecifier.resultTypeName != null)
                                                      .Select(op => $"{op.name} {op.operandTypeSpecifier!.resultTypeName!}");
                            _logger.LogWarning(
                                FormatMessage($"Function {expressionDefName}({string.Join(", ", ops)}) skipped; another function matching this signature already exists."));
                        }
                        return;
                    }
                }

                if (expressionDef.expression is { } expressionDefExpression)
                {
                    var bodyExpression = TranslateArg(expressionDefExpression);
                    var lambda = new CodeLambda(parameters, bodyExpression);
                    var tags = BuildTags();
                    var def = expressionDef is FunctionDef
                                  ? new CqlFunctionDefinition(lambda, expressionDefName, originalParameterNames, tags)
                                  : (CqlDefinition)new CqlExpressionDefinition(lambda, expressionDefName, tags);
                    _libraryContext.LibraryDefinitions.AddDefinition(_libraryContext.LibraryVersionedIdentifier, new(expressionDefName, parameterTypes), def);
                }
            }
        });

        (string name, string[] values)[] BuildTags()
        {
            (string name, string[] values)[] valueTuples = [];
            if (expressionDef.annotation is { Length: > 0 } annotations)
            {
                valueTuples = annotations
                              .OfType<Annotation>()
                              .SelectMany(a => a.t ?? [])
                              .SelectWhere(tag => string.IsNullOrWhiteSpace(tag?.name)
                                                      ? default
                                                      : (true, (name: tag.name!, values: (string[])[tag.value ?? ""])))
                              .ToArray();
            }
            return valueTuples;
        }

        void HandleExternalFunction(
            string expressionKey,
            FunctionDef function,
            Type[] parameterTypes,
            string expressionDefName)
        {
            if (!_expressionBuilderSettings.AllowUnresolvedExternals)
                throw this.NewExpressionBuildingException(
                    $"{expressionKey} is declared external, but it was not defined in the expression scope.");

            var returnType = TypeFor(expressionDef)!;
            var operands = function.operand ?? [];

            // NOTE(phase4): ported as-is. The old builder prefixed this signature with a synthetic
            // "context" entry (CqlExpressions.ParameterExpression.Type there, typeof(CqlContext)
            // here) because CqlFunctionDefinition's LambdaExpression always carried the context
            // parameter first; the resulting DefinitionSignature below therefore includes the
            // context type even though non-external definitions register their signature with only
            // the CQL operand types (see the isDuplicate check above). This looks like a latent bug
            // (a CQL-argument-only lookup could never match this signature), but it's preserved here
            // for parity. The IR lambda passed to NotImplemented, however, only ever carries the CQL
            // operand parameters (see CqlLambdaDefinition remarks), so the synthetic entry is sliced
            // off before it gets there.
            (string name, Type type)[] paramNamesAndTypes = new (string name, Type type)[operands.Length + 1];
            paramNamesAndTypes[0] = ("context", typeof(CqlContext));
            for (int o = 0; o < operands.Length; o++)
                paramNamesAndTypes[o + 1] = (operands[o].name, parameterTypes[o]);
            var notImplemented = NotImplemented(expressionKey, paramNamesAndTypes[1..], returnType);
            var paramTypes = paramNamesAndTypes.Select(p => p.type).ToArray();
            var definition = new CqlFunctionDefinition(notImplemented, expressionDefName);
            var definitionSignature = new DefinitionSignature(expressionDefName, paramTypes);
            _libraryContext.LibraryDefinitions.AddDefinition(_libraryContext.LibraryVersionedIdentifier, definitionSignature, definition);

            if (_logger.IsEnabled(LogLevel.Warning))
                _logger.LogWarning(
                    FormatMessage(
                        $"Function '{expressionDefName}' is declared external, but it was not defined in the expression scope. " +
                        "A stub has been created that throws a NotImplemented exception."), expressionDef);
        }

        (Type[] parameterTypes, IReadOnlyDictionary<string, string> originalParameterNames) BuildParameterTypes(OperandDef[] operandDefs, string expressionDefName)
        {
            var parameterTypes = new Type[operandDefs.Length];
            var originalNames = new Dictionary<string, string>();
            int i = 0;
            foreach (var operandDef in operandDefs)
            {
                if (operandDef.operandTypeSpecifier is null)
                    throw this.NewExpressionBuildingException(
                        $"Operand for function {expressionDefName} is missing its {nameof(operandDef.operandTypeSpecifier)} property",
                        null);

                var operandType = TypeFor(operandDef.operandTypeSpecifier)!;
                var normalizedName = IdentifierNormalizer.Normalize(operandDef.name);
                var parameter = new CodeLocal(operandType, normalizedName);
                _operands.Add(operandDef.name, parameter);
                parameterTypes[i++] = parameter.Type;

                // Store original name if it differs from the normalized name.
                var isSameCSharpAndCqlName = (normalizedName.StartsWith('@') ? normalizedName[1..] : normalizedName) == operandDef.name;
                if (!isSameCSharpAndCqlName)
                    originalNames[normalizedName] = operandDef.name;
            }

            return (parameterTypes, originalNames);
        }
    }

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
                        : new CodeConstant(null, typeof(object));
                var resolveParam = _cqlContextBinder.ResolveParameter(_libraryContext.LibraryVersionedIdentifier, parameterName, defaultValue);

                var parameterType = TypeFor(parameter.parameterTypeSpecifier)!;
                var cast = _cqlOperatorsBinder.CastToType(resolveParam, parameterType);
                // e.g. (bundle, context) => context.Parameters["Measurement Period"]
                // NOTE(phase4): the IR lambda for a parameter definition has no parameters at all,
                // not even the context (see CqlLambdaDefinition remarks) — the body references
                // CodeContextParameter.Instance directly (see CqlContextBinder.ResolveParameter).
                var lambda = new CodeLambda([], cast);
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
