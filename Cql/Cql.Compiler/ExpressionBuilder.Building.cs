using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler;

#pragma warning disable CS1591

partial class ExpressionBuilder
{

    private record LibraryStatementsBuilder(LibraryDefinitionsBuilder OuterLib, DefinitionDictionary<LambdaExpression> Definitions, ExpressionDef[] ExpressionDefs)
    {
        public void Build()
        {
            var lib = OuterLib;

            foreach (var expressionDef in ExpressionDefs)
            {
                if (expressionDef.expression == null)
                    throw new InvalidOperationException(
                        $"Definition {expressionDef.name} does not have an expression property");

                var buildContext = new ExpressionBuilderContext(
                    lib.ExpressionBuilder,
                    Expression.Parameter(typeof(CqlContext), "context"),
                    Definitions,
                    lib.LocalLibraryIdentifiers);

                if (string.IsNullOrWhiteSpace(expressionDef.name))
                {
                    var message =
                        $"Definition with local ID {expressionDef.localId} does not have a name.  This is not allowed.";
                    buildContext.LogError(message, expressionDef);
                    throw new InvalidOperationException(message);
                }

                try
                {
                    new LibraryStatementBuilder(this, expressionDef, buildContext).Build();
                }
                catch (Exception e)
                {
                    throw new InvalidOperationException(
                        $"Unhandled exception while building statement for definition '{expressionDef.name} 'in library '{lib.Library.NameAndVersion}'. See InnerException for more details.",
                        e);
                }
            }
        }
    }

    private record LibraryStatementBuilder(
        LibraryStatementsBuilder OuterStatements,
        ExpressionDef ExpressionDef,
        ExpressionBuilderContext BuildContext)
    {
        public void Build()
        {
            ExpressionDef def = ExpressionDef;
            ExpressionBuilderContext buildContext = BuildContext;
            var lib = OuterStatements.OuterLib;
            var expressionBuilder = lib.ExpressionBuilder;
            var customKey = $"{lib.LibraryNameAndVersion}.{def.name}";
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
                    definitions.Add(lib.LibraryNameAndVersion, def.name, functionParameterTypes, customLambda);
                    return;
                }
                else if (function?.external ?? false)
                {
                    var message =
                        $"{customKey} is declared external, but {nameof(CustomImplementations)} does not define this function.";
                    buildContext.LogError(message, def);
                    if (lib.ExpressionBuilder.Settings.AllowUnresolvedExternals)
                    {
                        var returnType = lib.TypeManager.TypeFor(def, buildContext, throwIfNotFound: true)!;
                        var paramTypes = new[] { typeof(CqlContext) }
                            .Concat(functionParameterTypes)
                            .ToArray();
                        var notImplemented =
                            NotImplemented(customKey, paramTypes, returnType, buildContext);
                        definitions.Add(lib.LibraryNameAndVersion, def.name, paramTypes, notImplemented);
                        return;
                    }
                    else throw new InvalidOperationException(message);
                }
            }

            buildContext = buildContext.Deeper(def);
            var bodyExpression = lib.ExpressionBuilder.TranslateExpression(def.expression, buildContext);
            var lambda = Expression.Lambda(bodyExpression, parameters);
            if (function?.operand != null &&
                definitions.ContainsKey(lib.LibraryNameAndVersion, def.name, functionParameterTypes))
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
                            definitions.AddTag(lib.LibraryNameAndVersion, def.name, functionParameterTypes, name, value);
                        }
                    }
                }

                definitions.Add(lib.LibraryNameAndVersion, def.name, functionParameterTypes ?? Array.Empty<Type>(), lambda);
            }
        }

        private static LambdaExpression NotImplemented(string nav, Type[] functionParameterTypes, Type returnType, ExpressionBuilderContext context)
        {
            var parameters = functionParameterTypes
                .Select((type, index) => Expression.Parameter(type, TypeNameToIdentifier(type, context) + index))
                .ToArray();
            var ctor = typeof(NotImplementedException).GetConstructor(new[] { typeof(string) })!;
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

    private record LibraryParametersBuilder(LibraryDefinitionsBuilder OuterLib, DefinitionDictionary<LambdaExpression> Definitions, ParameterDef[] ParameterDefs)
    {
        public void Build()
        {
            LibraryDefinitionsBuilder lib = OuterLib;
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

                Definitions.Add(lib.LibraryNameAndVersion, parameter.name!, lambda);
            }
        }
    }

    private record LibraryConceptsBuilder(LibraryDefinitionsBuilder OuterLib, DefinitionDictionary<LambdaExpression> Definitions, ConceptDef[] ConceptDefs)
    {
        public void Build()
        {
            var lib = OuterLib;
            foreach (var conceptDef in ConceptDefs)
            {
                if (conceptDef.code.Length <= 0)
                {
                    var newArray =
                        Expression.NewArrayBounds(typeof(CqlCode), Expression.Constant(0, typeof(int)));
                    var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
                    var lambda = Expression.Lambda(newArray, contextParameter);
                    Definitions.Add(lib.LibraryNameAndVersion, conceptDef.name, lambda);
                }
                else
                {
                    var initMembers = new Expression[conceptDef.code.Length];
                    for (int i = 0; i < conceptDef.code.Length; i++)
                    {
                        var codeRef = conceptDef.code[i];
                        if (!lib.CodesByName.TryGetValue(codeRef.name, out var systemCode))
                            throw new InvalidOperationException(
                                $"Code {codeRef.name} in concept {conceptDef.name} is not defined.");
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
                    var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
                    var lambda = Expression.Lambda(newConcept, contextParameter);
                    Definitions.Add(lib.LibraryNameAndVersion, conceptDef.name, lambda);
                }
            }
        }
    }

    private record LibraryCodeSystemsBuilder(LibraryDefinitionsBuilder OuterLib, DefinitionDictionary<LambdaExpression> Definitions, CodeSystemDef[] CodeSystemDefs)
    {
        public void Build()
        {
            LibraryDefinitionsBuilder lib = OuterLib;
            var thisLibraryKey = lib.LibraryNameAndVersion;
            var library = lib.Library;

            foreach (var codeSystem in CodeSystemDefs)
            {
                if (lib.CodesByCodeSystemName.TryGetValue(codeSystem.name, out var codes))
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
                    var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
                    var lambda = Expression.Lambda(arrayOfCodesInitializer, contextParameter);
                    Definitions.Add(thisLibraryKey, codeSystem.name, lambda);
                }
                else
                {
                    var newArray =
                        Expression.NewArrayBounds(typeof(CqlCode), Expression.Constant(0, typeof(int)));
                    var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
                    var lambda = Expression.Lambda(newArray, contextParameter);
                    Definitions.Add(thisLibraryKey, codeSystem.name, lambda);
                }
            }
        }
    }

    public record LibraryDefinitionsBuilder
    {
        public ExpressionBuilder ExpressionBuilder { get; }
        public Library Library { get; }
        public string LibraryNameAndVersion => Library.NameAndVersion.NotNull();
        public TypeManager TypeManager { get; }
        public Dictionary<string, string> LocalLibraryIdentifiers { get; } = new();
        //public DefinitionDictionary<LambdaExpression> Definitions { get; }
        public Dictionary<string, string> CodeSystemUrls { get; }
        public Dictionary<string, CqlCode> CodesByName { get; } = new();
        public Dictionary<string, List<CqlCode>> CodesByCodeSystemName { get; } = new();

        public LibraryDefinitionsBuilder(ExpressionBuilder expressionBuilder)
        {
            ExpressionBuilder = expressionBuilder;
            Library = expressionBuilder.Library;
            TypeManager = expressionBuilder.TypeManager;
            //Definitions = new();
            CodeSystemUrls = Library.codeSystems
                                 ?.ToDictionary(cs => cs.name, cs => cs.id)
                             ?? new();
        }

        public DefinitionDictionary<LambdaExpression> Build()
        {
            _ = LibraryNameAndVersion; // This checks that the library has a name and version
            DefinitionDictionary<LambdaExpression> definitions = new();

            if (Library.includes is { Length: > 0 } includes)
                new LibraryIncludesBuilder(this, definitions, includes).Build();

            if (Library.valueSets is { Length: > 0 } valueSets)
                new LibraryValueSetsBuilder(this, definitions, valueSets).Build();

            if (Library.codes is { Length: > 0 } codes)
                new LibraryCodesBuilder(this, definitions, codes).Build();

            if (Library.codeSystems is { Length: > 0 } codeSystems)
                new LibraryCodeSystemsBuilder(this, definitions, codeSystems).Build();

            if (Library.concepts is { Length: > 0 } concepts)
                new LibraryConceptsBuilder(this, definitions, concepts).Build();

            if (Library.parameters is { Length: > 0 } parameters)
                new LibraryParametersBuilder(this, definitions, parameters).Build();

            if (Library.statements is { Length: > 0 } statements)
                new LibraryStatementsBuilder(this, definitions, statements).Build();

            return definitions;
        }
    }
    
    private record LibraryValueSetsBuilder(LibraryDefinitionsBuilder OuterLib, DefinitionDictionary<LambdaExpression> Definitions, ValueSetDef[] LibraryValueSets)
    {
        public void Build()
        {
            foreach (ValueSetDef libraryValueSet in LibraryValueSets)
            {
                var ctor = typeof(CqlValueSet).GetConstructor(new[] { typeof(string), typeof(string) }) ??
                           throw new InvalidOperationException(
                               "CqlValueSet type requires a constructor with two string parameters.");
                var @new = Expression.New(ctor, Expression.Constant(libraryValueSet.id, typeof(string)),
                    Expression.Constant(libraryValueSet.version, typeof(string)));
                var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
                var lambda = Expression.Lambda(@new, contextParameter);
                Definitions.Add(OuterLib.LibraryNameAndVersion, libraryValueSet.name!, lambda);
            }
        }
    }

    private record LibraryCodesBuilder(LibraryDefinitionsBuilder OuterLib, DefinitionDictionary<LambdaExpression> Definitions, CodeDef[] LibraryCodeDefs)
    {
        public void Build()
        {
            HashSet<(string codeName, string codeSystemUrl)> foundCodeNameCodeSystemUrls = new();
            foreach (var libraryCodeDef in LibraryCodeDefs)
            {
                new LibraryCodeBuilder(this, libraryCodeDef, foundCodeNameCodeSystemUrls).Build();
            }
        }
    }

    private record LibraryCodeBuilder(
        LibraryCodesBuilder OuterCodes,
        CodeDef CodeDef,
        HashSet<(string codeName, string codeSystemUrl)> CodeNameCodeSystemUrlsSet)
    {
        public void Build()
        {
            var codeDef = CodeDef;
            var lib = OuterCodes.OuterLib;
            var outerLibCodeSystemUrls = lib.CodeSystemUrls;
            var outerLibCodesByName = lib.CodesByName;
            var outerLibCodesByCodeSystemName = lib.CodesByCodeSystemName;

            if (codeDef.codeSystem == null)
                throw new InvalidOperationException("Code definition has a null codeSystem node.");

            if (!outerLibCodeSystemUrls.TryGetValue(codeDef.codeSystem.name, out var csUrl))
                throw new InvalidOperationException($"Undefined code system {codeDef.codeSystem.name!}");

            if (!CodeNameCodeSystemUrlsSet.Add((codeDef.name, csUrl)))
                throw new InvalidOperationException(
                    $"Duplicate code name detected: {codeDef.name} from {codeDef.codeSystem.name} ({csUrl})");

            var systemCode = new CqlCode(codeDef.id, csUrl, null, null);
            outerLibCodesByName.Add(codeDef.name, systemCode);
            if (!outerLibCodesByCodeSystemName.TryGetValue(codeDef.codeSystem!.name!, out var codings))
            {
                codings = new List<CqlCode>();
                outerLibCodesByCodeSystemName.Add(codeDef.codeSystem!.name!, codings);
            }

            codings.Add(systemCode);

            var newCodingExpression = Expression.New(
                ConstructorInfos.CqlCode,
                Expression.Constant(codeDef.id),
                Expression.Constant(csUrl),
                Expression.Constant(null, typeof(string)),
                Expression.Constant(null, typeof(string))!
            );
            var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
            var lambda = Expression.Lambda(newCodingExpression, contextParameter);
            OuterCodes.Definitions.Add(lib.LibraryNameAndVersion, codeDef.name!, lambda);
        }
    }

    private record LibraryIncludesBuilder(LibraryDefinitionsBuilder OuterLibraryArgs, DefinitionDictionary<LambdaExpression> Definitions, IncludeDef[] LibraryIncludesDefs)
    {
        public void Build()
        {
            foreach (var includeDef in LibraryIncludesDefs)
            {
                var alias = !string.IsNullOrWhiteSpace(includeDef.localIdentifier)
                    ? includeDef.localIdentifier!
                    : includeDef.path!;

                var libNav = includeDef.NameAndVersion();
                if (libNav == null)
                    throw new InvalidOperationException($"Include {includeDef.localId} does not have a well-formed name and version");

                OuterLibraryArgs.LocalLibraryIdentifiers.Add(alias, libNav);
            }
        }
    }
}