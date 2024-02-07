using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler;

#pragma warning disable CS1591
partial class ExpressionBuilder
{

    /// <summary>
    /// Builds <see cref="LambdaExpression"/>s for each definition in <see cref="Library"/>.
    /// </summary>
    /// <returns>The <see cref="DefinitionDictionary{LambdaExpression}"/> for this <see cref="Library"/>.</returns>
    /// <exception cref="InvalidOperationException">If any fatal translation errors occur.</exception>
    public DefinitionDictionary<LambdaExpression> Build()
    {
        var definitions = new DefinitionDictionary<LambdaExpression>();
        var localLibraryIdentifiers = new Dictionary<string, string>();

        var version = Library.identifier!.version;
        if (string.IsNullOrWhiteSpace(version))
            version = "1.0.0";

        if (string.IsNullOrWhiteSpace(Library.identifier!.id))
            throw new InvalidOperationException("This package does not have a name and version.");

        var nav = ThisLibraryKey;
        BuildIncludes(localLibraryIdentifiers);

        BuildValueSets(definitions);

        var codeCtor = typeof(CqlCode).GetConstructor(new Type[]
        {
            typeof(string),
            typeof(string),
            typeof(string),
            typeof(string)
        })!;
        var codeSystemUrls = Library.codeSystems?
            .ToDictionary(cs => cs.name, cs => cs.id) ?? new Dictionary<string, string>();
        var codesByName = new Dictionary<string, CqlCode>();
        var codesByCodeSystemName = new Dictionary<string, List<CqlCode>>();

        BuildCodes(codeSystemUrls, codesByName, codesByCodeSystemName, codeCtor, definitions);

        BuildCodeSystems(codesByCodeSystemName, codeCtor, definitions);

        BuildConcepts(codesByName, codeCtor, definitions);

        BuildParameters(definitions, localLibraryIdentifiers);

        BuildStatements(definitions, localLibraryIdentifiers, nav);

        return definitions;
    }

    private void BuildCodes(Dictionary<string, string> codeSystemUrls, Dictionary<string, CqlCode> codesByName, Dictionary<string, List<CqlCode>> codesByCodeSystemName,
        ConstructorInfo codeCtor, DefinitionDictionary<LambdaExpression> definitions)
    {
        if (Library.codes != null)
        {
            HashSet<(string codeName, string codeSystemUrl)> foundCodeNameCodeSystemUrls = new();

            foreach (var code in Library.codes)
            {
                if (code.codeSystem == null)
                    throw new InvalidOperationException("Code definition has a null codeSystem node.");
                if (!codeSystemUrls.TryGetValue(code.codeSystem.name, out var csUrl))
                    throw new InvalidOperationException($"Undefined code system {code.codeSystem.name!}");
                if (!foundCodeNameCodeSystemUrls.Add((code.name, csUrl)))
                    throw new InvalidOperationException(
                        $"Duplicate code name detected: {code.name} from {code.codeSystem.name} ({csUrl})");
                var systemCode = new CqlCode(code.id, csUrl, null, null);
                codesByName.Add(code.name, systemCode);
                if (!codesByCodeSystemName.TryGetValue(code.codeSystem!.name!, out var codings))
                {
                    codings = new List<CqlCode>();
                    codesByCodeSystemName.Add(code.codeSystem!.name!, codings);
                }

                codings.Add(systemCode);

                var newCodingExpression = Expression.New(codeCtor,
                    Expression.Constant(code.id),
                    Expression.Constant(csUrl),
                    Expression.Constant(null, typeof(string)),
                    Expression.Constant(null, typeof(string))!
                );
                var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
                var lambda = Expression.Lambda(newCodingExpression, contextParameter);
                definitions.Add(ThisLibraryKey, code.name!, lambda);
            }
        }
    }

    private void BuildCodeSystems(Dictionary<string, List<CqlCode>> codesByCodeSystemName, ConstructorInfo codeCtor,
        DefinitionDictionary<LambdaExpression> definitions)
    {
        if (Library.codeSystems != null)
        {
            foreach (var codeSystem in Library.codeSystems)
            {
                if (codesByCodeSystemName.TryGetValue(codeSystem.name, out var codes))
                {
                    var initMembers = codes
                        .Select(coding =>
                            Expression.New(codeCtor,
                                Expression.Constant(coding.code),
                                Expression.Constant(coding.system),
                                Expression.Constant(null, typeof(string)),
                                Expression.Constant(null, typeof(string))
                            ))
                        .ToArray();
                    var arrayOfCodesInitializer = Expression.NewArrayInit(typeof(CqlCode), initMembers);
                    var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
                    var lambda = Expression.Lambda(arrayOfCodesInitializer, contextParameter);
                    definitions.Add(ThisLibraryKey, codeSystem.name, lambda);
                }
                else
                {
                    var newArray =
                        Expression.NewArrayBounds(typeof(CqlCode), Expression.Constant(0, typeof(int)));
                    var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
                    var lambda = Expression.Lambda(newArray, contextParameter);
                    definitions.Add(ThisLibraryKey, codeSystem.name, lambda);
                }
            }
        }
    }

    private void BuildConcepts(Dictionary<string, CqlCode> codesByName, ConstructorInfo codeCtor, DefinitionDictionary<LambdaExpression> definitions)
    {
        if (Library.concepts != null)
        {
            var conceptCtor =
                typeof(CqlConcept).GetConstructor(new[] { typeof(IEnumerable<CqlCode>), typeof(string) });
            foreach (var concept in Library.concepts)
            {
                if (concept.code.Length > 0)
                {
                    var initMembers = new Expression[concept.code.Length];
                    for (int i = 0; i < concept.code.Length; i++)
                    {
                        var codeRef = concept.code[i];
                        if (!codesByName.TryGetValue(codeRef.name, out var systemCode))
                            throw new InvalidOperationException(
                                $"Code {codeRef.name} in concept {concept.name} is not defined.");
                        initMembers[i] = Expression.New(codeCtor,
                            Expression.Constant(systemCode.code),
                            Expression.Constant(systemCode.system),
                            Expression.Constant(null, typeof(string)),
                            Expression.Constant(null, typeof(string))
                        );
                    }

                    var arrayOfCodesInitializer = Expression.NewArrayInit(typeof(CqlCode), initMembers);
                    var asEnumerable = Expression.TypeAs(arrayOfCodesInitializer, typeof(IEnumerable<CqlCode>));
                    var display = Expression.Constant(concept.display, typeof(string));
                    var newConcept = Expression.New(conceptCtor!, asEnumerable, display);
                    var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
                    var lambda = Expression.Lambda(newConcept, contextParameter);
                    definitions.Add(ThisLibraryKey, concept.name, lambda);
                }
                else
                {
                    var newArray =
                        Expression.NewArrayBounds(typeof(CqlCode), Expression.Constant(0, typeof(int)));
                    var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
                    var lambda = Expression.Lambda(newArray, contextParameter);
                    definitions.Add(ThisLibraryKey, concept.name, lambda);
                }
            }
        }
    }

    private void BuildParameters(DefinitionDictionary<LambdaExpression> definitions, Dictionary<string, string> localLibraryIdentifiers)
    {
        if (Library.parameters != null)
        {
            foreach (var parameter in Library.parameters ?? Enumerable.Empty<Elm.ParameterDef>())
            {
                if (definitions.ContainsKey(null, parameter.name!))
                    throw new InvalidOperationException(
                        $"There is already a definition named {parameter.name}");

                var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
                var buildContext = new ExpressionBuilderContext(this,
                    contextParameter,
                    definitions,
                    localLibraryIdentifiers);

                Expression? defaultValue = null;
                if (parameter.@default != null)
                    defaultValue = Expression.TypeAs(TranslateExpression(parameter.@default, buildContext),
                        typeof(object));
                else defaultValue = Expression.Constant(null, typeof(object));

                var resolveParam = Expression.Call(
                    contextParameter,
                    typeof(CqlContext).GetMethod(nameof(CqlContext.ResolveParameter))!,
                    Expression.Constant(Library.NameAndVersion),
                    Expression.Constant(parameter.name),
                    defaultValue
                );

                var parameterType = TypeManager.TypeFor(parameter.parameterTypeSpecifier!, buildContext);
                var cast = Expression.Convert(resolveParam, parameterType);
                // e.g. (bundle, context) => context.Parameters["Measurement Period"]
                var lambda = Expression.Lambda(cast, contextParameter);

                definitions.Add(ThisLibraryKey, parameter.name!, lambda);
            }
        }
    }

    private void BuildStatements(DefinitionDictionary<LambdaExpression> definitions, Dictionary<string, string> localLibraryIdentifiers, string nav)
    {
        foreach (var def in Library.statements.OrEmpty())
        {
            if (def.expression == null)
                throw new InvalidOperationException(
                    $"Definition {def.name} does not have an expression property");

            var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
            var buildContext = new ExpressionBuilderContext(this,
                contextParameter,
                definitions,
                localLibraryIdentifiers);

            if (string.IsNullOrWhiteSpace(def.name))
            {
                var message =
                    $"Definition with local ID {def.localId} does not have a name.  This is not allowed.";
                buildContext.LogError(message, def);
                throw new InvalidOperationException(message);
            }

            try
            {
                BuildStatement(definitions, nav, def, buildContext);
            }
            catch (Exception e)
            {
                throw new InvalidOperationException(
                    $"Unhandled exception while building statement for definition '{def.name} 'in library '{Library.NameAndVersion}'. See InnerException for more details.",
                    e);
            }
        }
    }

    private void BuildStatement(DefinitionDictionary<LambdaExpression> definitions, string nav, ExpressionDef def, ExpressionBuilderContext buildContext)
    {
        var customKey = $"{nav}.{def.name}";
        Type[] functionParameterTypes = Type.EmptyTypes;
        var parameters = new[] { buildContext.RuntimeContextParameter };
        var function = def as FunctionDef;
        if (function != null && function.operand != null)
        {
            functionParameterTypes = new Type[function.operand!.Length];
            int i = 0;
            foreach (var operand in function.operand!)
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
                        $"Operand for function {def.name} is missing its {nameof(operand.operandTypeSpecifier)} property");
            }

            parameters = parameters
                .Concat(buildContext.Operands.Values)
                .ToArray();
            if (CustomImplementations.TryGetValue(customKey, out var factory) && factory != null)
            {
                var customLambda = factory(parameters);
                definitions.Add(ThisLibraryKey, def.name, functionParameterTypes, customLambda);
                return;
            }
            else if (function?.external ?? false)
            {
                var message =
                    $"{customKey} is declared external, but {nameof(CustomImplementations)} does not define this function.";
                buildContext.LogError(message, def);
                if (Settings.AllowUnresolvedExternals)
                {
                    var returnType = TypeManager.TypeFor(def, buildContext, throwIfNotFound: true)!;
                    var paramTypes = new[] { typeof(CqlContext) }
                        .Concat(functionParameterTypes)
                        .ToArray();
                    var notImplemented =
                        NotImplemented(customKey, paramTypes, returnType, buildContext);
                    definitions.Add(ThisLibraryKey, def.name, paramTypes, notImplemented);
                    return;
                }
                else throw new InvalidOperationException(message);
            }
        }

        buildContext = buildContext.Deeper(def);
        var bodyExpression = TranslateExpression(def.expression, buildContext);
        var lambda = Expression.Lambda(bodyExpression, parameters);
        if (function?.operand != null &&
            definitions.ContainsKey(ThisLibraryKey, def.name, functionParameterTypes))
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
                        definitions.AddTag(ThisLibraryKey, def.name, functionParameterTypes, name,
                            value);
                    }
                }
            }

            definitions.Add(ThisLibraryKey, def.name, functionParameterTypes ?? Array.Empty<Type>(),
                lambda);
        }
    }

    private void BuildValueSets(DefinitionDictionary<LambdaExpression> definitions)
    {
        if (Library.valueSets != null)
        {
            foreach (var def in Library.valueSets!)
            {
                var ctor = typeof(CqlValueSet).GetConstructor(new[] { typeof(string), typeof(string) }) ??
                           throw new InvalidOperationException(
                               "CqlValueSet type requires a constructor with two string parameters.");
                var @new = Expression.New(ctor, Expression.Constant(def.id, typeof(string)),
                    Expression.Constant(def.version, typeof(string)));
                var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
                var lambda = Expression.Lambda(@new, contextParameter);
                definitions.Add(ThisLibraryKey, def.name!, lambda);
            }
        }
    }

    private void BuildIncludes(Dictionary<string, string> localLibraryIdentifiers)
    {
        if (Library.includes != null)
        {
            foreach (var def in Library!.includes!)
            {
                var alias = !string.IsNullOrWhiteSpace(def.localIdentifier)
                    ? def.localIdentifier!
                    : def.path!;

                var libNav = def.NameAndVersion();
                if (libNav != null)
                {
                    localLibraryIdentifiers.Add(alias, libNav);
                }
                else
                    throw new InvalidOperationException(
                        $"Include {def.localId} does not have a well-formed name and version");
            }
        }
    }

}