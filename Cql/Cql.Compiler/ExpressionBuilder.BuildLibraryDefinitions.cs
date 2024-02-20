using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler;

partial class ExpressionBuilder
{
    private static readonly ParameterExpression RuntimeContextParameter = Expression.Parameter(typeof(CqlContext), "context");

    /// <summary>
    /// Builds the definitions for the library.
    /// </summary>
    /// <param name="operatorBinding">The operator binding.</param>
    /// <param name="typeManager">The type manager.</param>
    /// <param name="logger">The logger.</param>
    /// <param name="library">The library ELM.</param>
    /// <returns>The definition dictionary of lambda expressions.</returns>
    public static DefinitionDictionary<LambdaExpression> BuildLibraryDefinitions(
        OperatorBinding operatorBinding,
        TypeManager typeManager,
        ILogger<ExpressionBuilder> logger,
        Library library) =>
        new ExpressionBuilder(operatorBinding, typeManager, logger, library).BuildLibraryDefinitions();

    /// <summary>
    /// Builds the definitions for the library.
    /// </summary>
    /// <returns>The definition dictionary of lambda expressions.</returns>
    private DefinitionDictionary<LambdaExpression> BuildLibraryDefinitions()
    {
        Logger.LogInformation("Building expressions for '{library}'", LibraryKey);

        var definitions = new DefinitionDictionary<LambdaExpression>();
        var definitionsBuilderContext = new DefinitionsBuilderContext(this, definitions);
        var definitionsBuilder = new DefinitionsBuilder(definitionsBuilderContext);
        definitionsBuilder.ProcessLibrary();
        return definitions;
    }

    /// <summary>
    /// The builder for processing the library into definitions.
    /// </summary>
    private readonly record struct DefinitionsBuilder
    {
        private readonly DefinitionsBuilderContext _context;

        public DefinitionsBuilder(DefinitionsBuilderContext context) => _context = context;

        public void ProcessLibrary()
        {
            var library = _context.Library;
            var libraryKey = _context.LibraryKey;

            if (library.includes is { Length: > 0 } includeDefs)
            {
                foreach (var includeDef in includeDefs)
                {
                    try
                    {
                        ProcessIncludes(includeDef);
                    }
                    catch (Exception e)
                    {
                        throw ExceptionWhileBuilding(includeDef switch
                        {
                            { version: { } version } => $"{includeDef.path} {version}",
                            _ => includeDef.path,
                        }, includeDef.locator, e);
                    }
                }
            }

            if (library.valueSets is { Length: > 0 } valueSetDefs)
            {
                foreach (ValueSetDef valueSetDef in valueSetDefs)
                {
                    try
                    {
                        ProcessValueSetDef(valueSetDef);
                    }
                    catch (Exception e)
                    {
                        throw ExceptionWhileBuilding(valueSetDef.name, valueSetDef.locator, e);
                    }
                }
            }

            if (library.codes is { Length: > 0 } codeDefs)
            {
                HashSet<(string codeName, string codeSystemUrl)> foundCodeNameCodeSystemUrls = new();
                Dictionary<string, string> codeSystemUrls =
                    library.codeSystems?.ToDictionary(cs => cs.name, cs => cs.id)
                    ?? new();

                foreach (var codeDef in codeDefs)
                {
                    try
                    {
                        ProcessCodeDef(codeDef, foundCodeNameCodeSystemUrls, codeSystemUrls);
                    }
                    catch (Exception e)
                    {
                        throw ExceptionWhileBuilding(codeDef.name, codeDef.locator, e);
                    }
                }
            }

            if (library.codeSystems is { Length: > 0 } codeSystemDefs)
            {
                foreach (var codeSystemDef in codeSystemDefs)
                {
                    try
                    {
                        ProcessCodeSystemDef(codeSystemDef);
                    }
                    catch (Exception e)
                    {
                        throw ExceptionWhileBuilding(codeSystemDef.name, codeSystemDef.locator, e);
                    }
                }
            }

            if (library.concepts is { Length: > 0 } conceptDefs)
            {
                foreach (var conceptDef in conceptDefs)
                {
                    try
                    {
                        ProcessConceptDef(conceptDef);
                    }
                    catch (Exception e)
                    {
                        throw ExceptionWhileBuilding(conceptDef.name, conceptDef.locator, e);
                    }
                }
            }

            if (library.parameters is { Length: > 0 } parameterDefs)
            {
                foreach (var parameterDef in parameterDefs)
                {
                    try
                    {
                        ProcessParameterDef(parameterDef);
                    }
                    catch (Exception e)
                    {
                        throw ExceptionWhileBuilding(parameterDef.name, parameterDef.locator, e);
                    }
                }
            }

            if (library.statements is { Length: > 0 } expressionDefs)
            {
                foreach (var expressionDef in expressionDefs)
                {
                    try
                    {
                        ProcessExpressionDef(expressionDef);
                    }
                    catch (Exception e)
                    {
                        throw ExceptionWhileBuilding(expressionDef.name, expressionDef.locator, e);
                    }
                }
            }

            Exception ExceptionWhileBuilding(string elementName, string locator, Exception innerException) =>
                throw new InvalidOperationException(
                    $"Exception while building expression definition '{elementName} ' in library '{libraryKey}' at location '{locator}'. See InnerException for more details.",
                    innerException);
        }

        private void ProcessCodeSystemDef(CodeSystemDef codeSystem)
        {
            if (_context.TryGetCodesByCodeSystemName(codeSystem.name, out var codes))
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
                var contextParameter = RuntimeContextParameter;
                var lambda = Expression.Lambda(arrayOfCodesInitializer, contextParameter);
                _context.AddDefinition(codeSystem.name, lambda);
            }
            else
            {
                var newArray =
                    Expression.NewArrayBounds(typeof(CqlCode), Expression.Constant(0, typeof(int)));
                var contextParameter = RuntimeContextParameter;
                var lambda = Expression.Lambda(newArray, contextParameter);
                _context.AddDefinition(codeSystem.name, lambda);
            }
        }

        private void ProcessConceptDef(ConceptDef conceptDef)
        {
            if (conceptDef.code.Length <= 0)
            {
                var newArray =
                    Expression.NewArrayBounds(typeof(CqlCode), Expression.Constant(0, typeof(int)));
                var contextParameter = RuntimeContextParameter;
                var lambda = Expression.Lambda(newArray, contextParameter);
                _context.AddDefinition(conceptDef.name, lambda);
            }
            else
            {
                var initMembers = new Expression[conceptDef.code.Length];
                for (int i = 0; i < conceptDef.code.Length; i++)
                {
                    var codeRef = conceptDef.code[i];
                    if (!_context.TryGetCode(codeRef, out var systemCode))
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
                var contextParameter = RuntimeContextParameter;
                var lambda = Expression.Lambda(newConcept, contextParameter);
                _context.AddDefinition(conceptDef.name, lambda);
            }
        }

        private void ProcessCodeDef(
            CodeDef codeDef,
            ISet<(string codeName, string codeSystemUrl)> codeNameCodeSystemUrlsSet,
            IReadOnlyDictionary<string, string> codeSystemUrls)
        {
            if (codeDef.codeSystem == null)
                throw new InvalidOperationException("Code definition has a null codeSystem node.");

            if (!codeSystemUrls.TryGetValue(codeDef.codeSystem.name, out var csUrl))
                throw new InvalidOperationException($"Undefined code system {codeDef.codeSystem.name!}");

            if (!codeNameCodeSystemUrlsSet.Add((codeDef.name, csUrl)))
                throw new InvalidOperationException(
                    $"Duplicate code name detected: {codeDef.name} from {codeDef.codeSystem.name} ({csUrl})");

            var systemCode = new CqlCode(codeDef.id, csUrl);
            _context.AddCode(codeDef, systemCode);

            var newCodingExpression = Expression.New(
                ConstructorInfos.CqlCode,
                Expression.Constant(codeDef.id),
                Expression.Constant(csUrl),
                Expression.Constant(null, typeof(string)),
                Expression.Constant(null, typeof(string))!
            );
            var contextParameter = RuntimeContextParameter;
            var lambda = Expression.Lambda(newCodingExpression, contextParameter);
            _context.AddDefinition(codeDef.name!, lambda);
        }

        private void ProcessExpressionDef(ExpressionDef expressionDef)
        {
            if (expressionDef.expression == null)
                throw new InvalidOperationException(
                    $"Definition '{expressionDef.name}' does not have an expression property");

            var builderContext = _context.NewExpressionBuilderContext();

            if (string.IsNullOrWhiteSpace(expressionDef.name))
            {
                var message =
                    $"Definition with local ID {expressionDef.localId} does not have a name.  This is not allowed.";
                builderContext.LogError(message, expressionDef);
                throw new InvalidOperationException(message);
            }

            var expressionKey = $"{_context.LibraryKey}.{expressionDef.name}";
            Type[] functionParameterTypes = Type.EmptyTypes;
            var parameters = new[] { RuntimeContextParameter };
            var function = expressionDef as FunctionDef;
            if (function is { operand: not null })
            {
                functionParameterTypes = new Type[function.operand!.Length];
                int i = 0;
                foreach (var operand in function.operand!)
                {
                    if (operand.operandTypeSpecifier != null)
                    {
                        var operandType = builderContext.TypeFor(operand.operandTypeSpecifier)!;
                        var opName = ExpressionBuilderContext.NormalizeIdentifier(operand.name);
                        var parameter = Expression.Parameter(operandType, opName);
                        builderContext.AddParameterExpression(operand, parameter);
                        functionParameterTypes[i] = parameter.Type;
                        i += 1;
                    }
                    else
                        throw new InvalidOperationException(
                            $"Operand for function {expressionDef.name} is missing its {nameof(operand.operandTypeSpecifier)} property");
                }

                parameters = parameters
                    .Concat(builderContext.GetParameterExpressions())
                    .ToArray();
                if (_context.TryGetCustomImplementationByExpressionKey(expressionKey, out var factory))
                {
                    var customLambda = factory(parameters);
                    _context.AddDefinition(expressionDef.name, functionParameterTypes, customLambda);
                    return;
                }

                if (function?.external ?? false)
                {
                    var message = $"{expressionKey} is declared external, but {nameof(CustomImplementations)} does not define this function.";
                    builderContext.LogError(message, expressionDef);
                    if (_context.AllowUnresolvedExternals)
                    {
                        var returnType = builderContext.TypeFor(expressionDef, throwIfNotFound: true)!;
                        var paramTypes = new[] { typeof(CqlContext) }
                            .Concat(functionParameterTypes)
                            .ToArray();
                        var notImplemented = NotImplemented(builderContext, expressionKey, paramTypes, returnType);
                        _context.AddDefinition(expressionDef.name, paramTypes, notImplemented);
                        return;
                    }

                    throw new InvalidOperationException(message);
                }
            }

            builderContext = builderContext.Deeper();
            var bodyExpression = builderContext.TranslateExpression(expressionDef.expression);
            var lambda = Expression.Lambda(bodyExpression, parameters);
            if (function?.operand != null && _context.ContainsDefinition(expressionDef.name, functionParameterTypes))
            {
                var ops = function.operand
                    .Where(op => op.operandTypeSpecifier != null && op.operandTypeSpecifier.resultTypeName != null)
                    .Select(op => $"{op.name} {op.operandTypeSpecifier!.resultTypeName!}");
                var message = $"Function {expressionDef.name}({string.Join(", ", ops)}) skipped; another function matching this signature already exists.";
                builderContext.LogWarning(message, expressionDef);
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
                        _context.AddDefinitionTag(expressionDef.name, functionParameterTypes, tag.name, values);
                    }
                }

                Type[] signature = functionParameterTypes ?? Array.Empty<Type>();
                _context.AddDefinition(expressionDef.name, signature, lambda);
            }
        }

        private void ProcessIncludes(IncludeDef includeDef)
        {
            var alias = !string.IsNullOrWhiteSpace(includeDef.localIdentifier)
                ? includeDef.localIdentifier!
                : includeDef.path!;

            var libNav = includeDef.NameAndVersion() ?? throw new InvalidOperationException($"Include {includeDef.localId} does not have a well-formed name and version");
            _context.AddIncludeAlias(alias, libNav);
        }

        private void ProcessParameterDef(ParameterDef parameter)
        {
            if (_context.ContainsDefinition(parameter.name!))
                throw new InvalidOperationException(
                    $"There is already a definition named {parameter.name}");

            var expressionBuilderContext = _context.NewExpressionBuilderContext();

            Expression? defaultValue = null;
            if (parameter.@default != null)
                defaultValue = Expression.TypeAs(expressionBuilderContext.TranslateExpression(parameter.@default), typeof(object));
            else defaultValue = Expression.Constant(null, typeof(object));

            var resolveParam = Expression.Call(
                RuntimeContextParameter,
                typeof(CqlContext).GetMethod(nameof(CqlContext.ResolveParameter))!,
                Expression.Constant(_context.LibraryKey),
                Expression.Constant(parameter.name),
                defaultValue
            );

            var parameterType = expressionBuilderContext.TypeFor(parameter.parameterTypeSpecifier);
            var cast = Expression.Convert(resolveParam, parameterType);
            // e.g. (bundle, context) => context.Parameters["Measurement Period"]
            var lambda = Expression.Lambda(cast, RuntimeContextParameter);
            _context.AddDefinition(parameter.name!, lambda);
        }

        private void ProcessValueSetDef(ValueSetDef valueSetDef)
        {
            var @new = Expression.New(ConstructorInfos.CqlValueSet, Expression.Constant(valueSetDef.id, typeof(string)),
                Expression.Constant(valueSetDef.version, typeof(string)));
            var contextParameter = RuntimeContextParameter;
            var lambda = Expression.Lambda(@new, contextParameter);
            _context.AddDefinition(valueSetDef.name!, lambda);
        }

        private static LambdaExpression NotImplemented(
            ExpressionBuilderContextFacade expressionBuilderContextFacade,
            string nav,
            Type[] signature,
            Type returnType)
        {
            var parameters = signature
                .Select((type, index) => Expression.Parameter(type, expressionBuilderContextFacade.TypeNameToIdentifier(type) + index))
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

    /// <summary>
    /// Encapsulates the ExpressionBuilder and state dictionaries for building definitions.
    /// </summary>
    private readonly record struct DefinitionsBuilderContext
    {
        private readonly ExpressionBuilder _expressionBuilder;
        private readonly Dictionary<string, string> _localLibraryIdentifiers;
        private readonly DefinitionDictionary<LambdaExpression> _definitions;
        private readonly Dictionary<string, CqlCode> _codesByName;
        private readonly Dictionary<string, List<CqlCode>> _codesByCodeSystemName;

        public DefinitionsBuilderContext(
            ExpressionBuilder expressionBuilder, 
            DefinitionDictionary<LambdaExpression> definitions)
        {
            _expressionBuilder = expressionBuilder;
            _definitions = definitions;
            _localLibraryIdentifiers = new();
            _codesByName = new();
            _codesByCodeSystemName = new();
        }

        public Library Library => _expressionBuilder.Library;

        public string LibraryKey => _expressionBuilder.LibraryKey;

        public bool AllowUnresolvedExternals => _expressionBuilder.Settings.AllowUnresolvedExternals;

        public ExpressionBuilderContextFacade NewExpressionBuilderContext() =>
            new ExpressionBuilderContextFacade(
                new ExpressionBuilderContext(
                    _expressionBuilder,
                    RuntimeContextParameter,
                    _definitions,
                    _localLibraryIdentifiers));

        public bool TryGetCustomImplementationByExpressionKey(
            string expressionKey,
            [NotNullWhen(true)] out Func<ParameterExpression[], LambdaExpression>? factory) =>
            _expressionBuilder.CustomImplementations.TryGetValue(expressionKey, out factory);

        public void AddDefinitionTag(string definition, Type[] signature, string name, params string[] values) =>
            _definitions.AddTag(LibraryKey, definition, signature, name, values);

        public void AddDefinition(string definition, LambdaExpression expression) =>
            _definitions.Add(LibraryKey, definition, expression);

        public void AddDefinition(string definition, Type[] signature, LambdaExpression expression) =>
            _definitions.Add(LibraryKey, definition, signature, expression);

        public bool ContainsDefinition(string definition, Type[] signature) =>
            _definitions.ContainsKey(LibraryKey, definition, signature);

        public bool ContainsDefinition(string definition) =>
            _definitions.ContainsKey(LibraryKey, definition);

        public void AddIncludeAlias(string includeAlias, string includeNameAndVersion) =>
            _localLibraryIdentifiers.Add(includeAlias, includeNameAndVersion);

        public bool TryGetCodesByCodeSystemName(string codeSystemName, [NotNullWhen(true)] out List<CqlCode>? codes) =>
            _codesByCodeSystemName.TryGetValue(codeSystemName, out codes);

        public void AddCode(CodeDef codeDef, CqlCode cqlCode)
        {
            _codesByName.Add(codeDef.name, cqlCode);

            var codeSystemName = codeDef.codeSystem!.name;
            var codings = GetOrCreateCodesByCodeSystemName(codeSystemName);
            codings.Add(cqlCode);
        }

        private List<CqlCode> GetOrCreateCodesByCodeSystemName(string codeSystemName)
        {
            if (_codesByCodeSystemName.TryGetValue(codeSystemName!, out var codings)) 
                return codings;

            codings = new List<CqlCode>();
            _codesByCodeSystemName.Add(codeSystemName!, codings);
            return codings;
        }

        public bool TryGetCode(CodeRef codeRef, [NotNullWhen(true)]out CqlCode? systemCode) => 
            _codesByName.TryGetValue(codeRef.name, out systemCode);
    }

    /// <summary>
    /// Encapsulates the ExpressionBuilderContext for building definitions.
    /// </summary>
    private readonly record struct ExpressionBuilderContextFacade
    {
        private readonly ExpressionBuilderContext _expressionBuilderContext;

        public ExpressionBuilderContextFacade(ExpressionBuilderContext expressionBuilderContext)
        {
            _expressionBuilderContext = expressionBuilderContext;
        }

        public void LogWarning(string message, Element? expression = null) =>
            _expressionBuilderContext.LogWarning(message, expression);

        public void LogError(string message, Element? element = null) =>
            _expressionBuilderContext.LogError(message, element);

        public Type TypeFor(TypeSpecifier resultTypeSpecifier) =>
            _expressionBuilderContext.TypeFor(resultTypeSpecifier);

        public Type? TypeFor(Element element, bool throwIfNotFound = true) =>
            _expressionBuilderContext.TypeFor(element, throwIfNotFound);

        public ExpressionBuilderContextFacade Deeper() =>
            new ExpressionBuilderContextFacade(_expressionBuilderContext.Deeper());

        public Expression TranslateExpression(Element op) =>
            _expressionBuilderContext.Builder.TranslateExpression(op, _expressionBuilderContext);

        public string TypeNameToIdentifier(Type type) =>
            ExpressionBuilder.TypeNameToIdentifier(type, _expressionBuilderContext);

        public void AddParameterExpression(OperandDef operand, ParameterExpression parameter) => 
            _expressionBuilderContext.Operands.Add(operand.name!, parameter);

        public IEnumerable<ParameterExpression> GetParameterExpressions() => 
            _expressionBuilderContext.Operands.Values;
    }
}

internal class LibraryDefinitionsBuilder
{
    private readonly ILogger<ExpressionBuilder> _logger;
    private readonly OperatorBinding _operatorBinding;
    private readonly TypeManager _typeManager;

    public LibraryDefinitionsBuilder(
        ILogger<ExpressionBuilder> logger, 
        OperatorBinding operatorBinding,
        TypeManager typeManager)
    {
        _logger = logger;
        _operatorBinding = operatorBinding;
        _typeManager = typeManager;
    }

    public DefinitionDictionary<LambdaExpression> BuildLibraryDefinitions(Library library)
    {
        return ExpressionBuilder.BuildLibraryDefinitions(_operatorBinding, _typeManager, _logger, library);
    }
}