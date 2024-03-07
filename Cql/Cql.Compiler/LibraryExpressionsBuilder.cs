using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Fhir.Introspection;
using Microsoft.Extensions.Logging;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler;

/// <summary>
/// The builder for processing the library into definitions.
/// </summary>
internal class LibraryExpressionsBuilder
{
    private readonly ILogger<LibraryExpressionsBuilder> _logger;

    public LibraryExpressionsBuilder(ILogger<LibraryExpressionsBuilder> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Builds the definitions for the library.
    /// </summary>
    /// <param name="operatorBinding">The operator binding.</param>
    /// <param name="typeManager">The type manager.</param>
    /// <param name="loggerFactory">The logger factory</param>
    /// <param name="library">The library ELM.</param>
    /// <returns>The definition dictionary of lambda expressions.</returns>
    public static DefinitionDictionary<LambdaExpression> BuildLibraryDefinitions(
        OperatorBinding operatorBinding,
        TypeManager typeManager,
        ILoggerFactory loggerFactory,
        Elm.Library library)
    {
        var expressionBuilder = new ExpressionBuilder(typeManager, loggerFactory.CreateLogger<ExpressionBuilder>());

        var definitions = new DefinitionDictionary<LambdaExpression>();
        var definitionsBuilderContext =
            new LibraryExpressionsBuilderContext(expressionBuilder, operatorBinding, definitions, library);

        var libraryExpressionsBuilderLogger = loggerFactory.CreateLogger<LibraryExpressionsBuilder>();
        var definitionsBuilder = new LibraryExpressionsBuilder(libraryExpressionsBuilderLogger);
        definitionsBuilder.ProcessLibrary(definitionsBuilderContext);

        return definitions;
    }

    public static readonly ParameterExpression ContextParameter = Expression.Parameter(typeof(CqlContext), "context");

    public void ProcessLibrary(LibraryExpressionsBuilderContext libCtx)
    {
        var library = libCtx.Library;
        var libraryKey = libCtx.LibraryKey;
        _logger.LogInformation("Building expressions for '{library}'", libCtx.LibraryKey);

        if (library.includes is { Length: > 0 } includeDefs)
        {
            foreach (var (includeDef, ordinal) in includeDefs.WithOrdinals())
            {
                try
                {
                    ProcessIncludes(includeDef, libCtx.NewExpressionBuilderContext(includeDef));
                }
                catch (Exception e)
                {
                    throw ExceptionWhileBuilding("include definition", ordinal, includeDefs.Length, includeDef switch
                    {
                        { version: { } version } => $"{includeDef.path} {version}",
                        _ => includeDef.path,
                    }, includeDef.locator, e);
                }
            }
        }

        if (library.valueSets is { Length: > 0 } valueSetDefs)
        {
            foreach (var (valueSetDef, ordinal) in valueSetDefs.WithOrdinals())
            {
                try
                {
                    ProcessValueSetDef(valueSetDef, libCtx.NewExpressionBuilderContext(valueSetDef));
                }
                catch (Exception e)
                {
                    throw ExceptionWhileBuilding("value set", ordinal, valueSetDefs.Length, valueSetDef.name,
                        valueSetDef.locator, e);
                }
            }
        }

        if (library.codes is { Length: > 0 } codeDefs)
        {
            HashSet<(string codeName, string codeSystemUrl)> foundCodeNameCodeSystemUrls = new();
            Dictionary<string, string> codeSystemUrls =
                library.codeSystems?.ToDictionary(cs => cs.name, cs => cs.id)
                ?? new();

            foreach (var (codeDef, ordinal) in codeDefs.WithOrdinals())
            {
                try
                {
                    ProcessCodeDef(codeDef, libCtx.NewExpressionBuilderContext(codeDef), foundCodeNameCodeSystemUrls,
                        codeSystemUrls);
                }
                catch (Exception e)
                {
                    throw ExceptionWhileBuilding("code definition", ordinal, codeDefs.Length, codeDef.name,
                        codeDef.locator, e);
                }
            }
        }

        if (library.codeSystems is { Length: > 0 } codeSystemDefs)
        {
            foreach (var (codeSystemDef, ordinal) in codeSystemDefs.WithOrdinals())
            {
                try
                {
                    ProcessCodeSystemDef(codeSystemDef, libCtx.NewExpressionBuilderContext(codeSystemDef));
                }
                catch (Exception e)
                {
                    throw ExceptionWhileBuilding("code system definition", ordinal, codeSystemDefs.Length,
                        codeSystemDef.name, codeSystemDef.locator, e);
                }
            }
        }

        if (library.concepts is { Length: > 0 } conceptDefs)
        {
            foreach (var (conceptDef, ordinal) in conceptDefs.WithOrdinals())
            {
                try
                {
                    ProcessConceptDef(conceptDef, libCtx.NewExpressionBuilderContext(conceptDef));
                }
                catch (Exception e)
                {
                    throw ExceptionWhileBuilding("concept definition", ordinal, conceptDefs.Length, conceptDef.name,
                        conceptDef.locator, e);
                }
            }
        }

        if (library.parameters is { Length: > 0 } parameterDefs)
        {
            foreach (var (parameterDef, ordinal) in parameterDefs.WithOrdinals())
            {
                try
                {
                    ProcessParameterDef(parameterDef, libCtx.NewExpressionBuilderContext(parameterDef));
                }
                catch (Exception e)
                {
                    throw ExceptionWhileBuilding("parameter definition", ordinal, parameterDefs.Length,
                        parameterDef.name, parameterDef.locator, e);
                }
            }
        }

        if (library.statements is { Length: > 0 } expressionDefs)
        {
            foreach (var (expressionDef, ordinal) in expressionDefs.WithOrdinals())
            {
                try
                {
                    ProcessExpressionDef(expressionDef, libCtx.NewExpressionBuilderContext(expressionDef));
                }
                catch (Exception e)
                {
                    throw ExceptionWhileBuilding("expression definition", ordinal, expressionDefs.Length,
                        expressionDef.name, expressionDef.locator, e);
                }
            }
        }

        Exception ExceptionWhileBuilding(string elmType, int ordinal, int count, string elementName, string locator,
            Exception innerException) =>
            throw new ExpressionBuildingException(
                message:
                $"Exception while building the {new Ordinal(ordinal + 1)} of {count} {elmType} '{elementName} ' in library '{libraryKey}' at location '{locator}'. See InnerException for more details.",
                innerException: innerException);
    }

    private void ProcessCodeSystemDef(
        CodeSystemDef codeSystem,
        ExpressionBuilderContext ctx)
    {
        if (ctx.LibraryContext.TryGetCodesByCodeSystemName(codeSystem.name, out var codes))
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
            var contextParameter = ContextParameter;
            var lambda = Expression.Lambda(arrayOfCodesInitializer, contextParameter);
            ctx.LibraryContext.AddDefinition(codeSystem.name, lambda);
        }
        else
        {
            var newArray =
                Expression.NewArrayBounds(typeof(CqlCode), Expression.Constant(0, typeof(int)));
            var contextParameter = ContextParameter;
            var lambda = Expression.Lambda(newArray, contextParameter);
            ctx.LibraryContext.AddDefinition(codeSystem.name, lambda);
        }
    }

    private void ProcessConceptDef(
        ConceptDef conceptDef,
        ExpressionBuilderContext ctx)
    {
        if (conceptDef.code.Length <= 0)
        {
            var newArray =
                Expression.NewArrayBounds(typeof(CqlCode), Expression.Constant(0, typeof(int)));
            var contextParameter = ContextParameter;
            var lambda = Expression.Lambda(newArray, contextParameter);
            ctx.LibraryContext.AddDefinition(conceptDef.name, lambda);
        }
        else
        {
            var initMembers = new Expression[conceptDef.code.Length];
            for (int i = 0; i < conceptDef.code.Length; i++)
            {
                var codeRef = conceptDef.code[i];
                if (!ctx.LibraryContext.TryGetCode(codeRef, out var systemCode))
                    throw ctx.NewExpressionBuildingException(
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
            var contextParameter = ContextParameter;
            var lambda = Expression.Lambda(newConcept, contextParameter);
            ctx.LibraryContext.AddDefinition(conceptDef.name, lambda);
        }
    }

    private void ProcessCodeDef(
        CodeDef codeDef,
        ExpressionBuilderContext ctx,
        ISet<(string codeName, string codeSystemUrl)> codeNameCodeSystemUrlsSet,
        IReadOnlyDictionary<string, string> codeSystemUrls)
    {
        if (codeDef.codeSystem == null)
            throw ctx.NewExpressionBuildingException("Code definition has a null codeSystem node.", null);

        if (!codeSystemUrls.TryGetValue(codeDef.codeSystem.name, out var csUrl))
            throw ctx.NewExpressionBuildingException($"Undefined code system {codeDef.codeSystem.name!}", null);

        if (!codeNameCodeSystemUrlsSet.Add((codeDef.name, csUrl)))
            throw ctx.NewExpressionBuildingException(
                $"Duplicate code name detected: {codeDef.name} from {codeDef.codeSystem.name} ({csUrl})", null);

        var systemCode = new CqlCode(codeDef.id, csUrl);
        ctx.LibraryContext.AddCode(codeDef, systemCode);

        var newCodingExpression = Expression.New(
            ConstructorInfos.CqlCode,
            Expression.Constant(codeDef.id),
            Expression.Constant(csUrl),
            Expression.Constant(null, typeof(string)),
            Expression.Constant(null, typeof(string))!
        );
        var contextParameter = ContextParameter;
        var lambda = Expression.Lambda(newCodingExpression, contextParameter);
        ctx.LibraryContext.AddDefinition(codeDef.name!, lambda);
    }

    private void ProcessExpressionDef(
        ExpressionDef expressionDef,
        ExpressionBuilderContext ctx)
    {
        if (string.IsNullOrWhiteSpace(expressionDef.name))
        {
            var message =
                $"Definition with local ID {expressionDef.localId} does not have a name.  This is not allowed.";
            ctx.LogError(message, expressionDef);
            throw ctx.NewExpressionBuildingException(message, null);
        }

        var expressionKey = $"{ctx.LibraryContext.LibraryKey}.{expressionDef.name}";
        Type[] functionParameterTypes = Type.EmptyTypes;
        var parameters = new[] { ContextParameter };
        var function = expressionDef as FunctionDef;
        if (function is { operand: not null })
        {
            functionParameterTypes = new Type[function.operand!.Length];
            int i = 0;
            foreach (var operand in function.operand!)
            {
                if (operand.operandTypeSpecifier != null)
                {
                    var operandType = ctx.Builder.TypeFor(operand.operandTypeSpecifier, ctx)!;
                    var opName = ExpressionBuilderContext.NormalizeIdentifier(operand.name);
                    var parameter = Expression.Parameter(operandType, opName);
                    ctx.Operands.Add(operand.name!, parameter);
                    functionParameterTypes[i] = parameter.Type;
                    i += 1;
                }
                else
                    throw ctx.NewExpressionBuildingException(
                        $"Operand for function {expressionDef.name} is missing its {nameof(operand.operandTypeSpecifier)} property",
                        null);
            }

            parameters = parameters
                .Concat(ctx.Operands.Values)
                .ToArray();
            if (ctx.LibraryContext.TryGetCustomImplementationByExpressionKey(expressionKey, out var factory))
            {
                var customLambda = factory(parameters);
                ctx.LibraryContext.AddDefinition(expressionDef.name, functionParameterTypes, customLambda);
                return;
            }

            if (function?.external ?? false)
            {
                var message =
                    $"{expressionKey} is declared external, but {nameof(ExpressionBuilder.CustomImplementations)} does not define this function.";
                ctx.LogError(message, expressionDef);
                if (ctx.LibraryContext.AllowUnresolvedExternals)
                {
                    var returnType = ctx.Builder.TypeFor(expressionDef, ctx)!;
                    var paramTypes = new[] { typeof(CqlContext) }
                        .Concat(functionParameterTypes)
                        .ToArray();
                    var notImplemented = NotImplemented(ctx, expressionKey, paramTypes, returnType);
                    ctx.LibraryContext.AddDefinition(expressionDef.name, paramTypes, notImplemented);
                    return;
                }

                throw ctx.NewExpressionBuildingException(message, null);
            }
        }

        //ctx = ctx.Deeper(expressionDef);
        var bodyExpression = ctx.Builder.TranslateExpression(expressionDef.expression, ctx);
        var lambda = Expression.Lambda(bodyExpression, parameters);
        if (function?.operand != null &&
            ctx.LibraryContext.ContainsDefinition(expressionDef.name, functionParameterTypes))
        {
            var ops = function.operand
                .Where(op => op.operandTypeSpecifier != null && op.operandTypeSpecifier.resultTypeName != null)
                .Select(op => $"{op.name} {op.operandTypeSpecifier!.resultTypeName!}");
            var message =
                $"Function {expressionDef.name}({string.Join(", ", ops)}) skipped; another function matching this signature already exists.";
            ctx.LogWarning(message, expressionDef);
        }
        else
        {
            if (expressionDef.annotation is { Length: > 0 } annotations)
            {
                var tags = annotations.OfType<Elm.Annotation>()
                    .SelectMany(a => a.t ?? Enumerable.Empty<Tag>())
                    .Where(tag => !string.IsNullOrWhiteSpace(tag?.name));

                foreach (var tag in tags)
                {
                    string[] values = new[] { tag.value ?? "" };
                    ctx.LibraryContext.AddDefinitionTag(expressionDef.name, functionParameterTypes, tag.name, values);
                }
            }

            Type[] signature = functionParameterTypes ?? Array.Empty<Type>();
            ctx.LibraryContext.AddDefinition(expressionDef.name, signature, lambda);
        }
    }

    private void ProcessIncludes(
        IncludeDef includeDef,
        ExpressionBuilderContext ctx)
    {
        var alias = !string.IsNullOrWhiteSpace(includeDef.localIdentifier)
            ? includeDef.localIdentifier!
            : includeDef.path!;

        var libNav = includeDef.NameAndVersion() ??
                     throw ctx.NewExpressionBuildingException(
                         $"Include {includeDef.localId} does not have a well-formed name and version", null);
        ctx.LibraryContext.AddIncludeAlias(alias, libNav);
    }

    private void ProcessParameterDef(
        ParameterDef parameter,
        ExpressionBuilderContext ctx)
    {
        if (ctx.LibraryContext.ContainsDefinition(parameter.name!))
            throw ctx.NewExpressionBuildingException($"There is already a definition named {parameter.name}", null);

        Expression? defaultValue = null;
        if (parameter.@default != null)
            defaultValue = Expression.TypeAs(ctx.Builder.TranslateExpression(parameter.@default, ctx), typeof(object));
        else defaultValue = Expression.Constant(null, typeof(object));

        var resolveParam = Expression.Call(
            ContextParameter,
            typeof(CqlContext).GetMethod(nameof(CqlContext.ResolveParameter))!,
            Expression.Constant(ctx.LibraryContext.LibraryKey),
            Expression.Constant(parameter.name),
            defaultValue
        );

        var parameterType = ctx.Builder.TypeFor(parameter.parameterTypeSpecifier, ctx);
        var cast = Expression.Convert(resolveParam, parameterType);
        // e.g. (bundle, context) => context.Parameters["Measurement Period"]
        var lambda = Expression.Lambda(cast, ContextParameter);
        ctx.LibraryContext.AddDefinition(parameter.name!, lambda);
    }

    private void ProcessValueSetDef(
        ValueSetDef valueSetDef,
        ExpressionBuilderContext ctx)
    {
        var @new = Expression.New(ConstructorInfos.CqlValueSet, Expression.Constant(valueSetDef.id, typeof(string)),
            Expression.Constant(valueSetDef.version, typeof(string)));
        var contextParameter = ContextParameter;
        var lambda = Expression.Lambda(@new, contextParameter);
        ctx.LibraryContext.AddDefinition(valueSetDef.name!, lambda);
    }

    private static LambdaExpression NotImplemented(
        ExpressionBuilderContext ctx,
        string nav,
        Type[] signature,
        Type returnType)
    {
        var parameters = signature
            .Select((type, index) =>
                Expression.Parameter(type, ExpressionBuilder.TypeNameToIdentifier(type, ctx) + index))
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
internal class LibraryExpressionsBuilderContext
{
    private readonly ExpressionBuilder _expressionBuilder;
    private readonly OperatorBinding _operatorBinding;
    private readonly Dictionary<string, string> _localLibraryIdentifiers;
    private readonly DefinitionDictionary<LambdaExpression> _definitions;
    private readonly Library _library;
    private readonly Dictionary<string, CqlCode> _codesByName;
    private readonly Dictionary<string, List<CqlCode>> _codesByCodeSystemName;

    public LibraryExpressionsBuilderContext(
        ExpressionBuilder expressionBuilder,
        OperatorBinding operatorBinding,
        DefinitionDictionary<LambdaExpression> definitions,
        Library library)
    {
        if (string.IsNullOrWhiteSpace(library.NameAndVersion))
            throw new ArgumentException("Library must have a name and version.");

        if (library.identifier is null) 
            throw new ArgumentException("Library must have an identifier.");

        _expressionBuilder = expressionBuilder;
        _operatorBinding = operatorBinding;
        _definitions = definitions;
        _library = library;
        _localLibraryIdentifiers = new();
        _codesByName = new();
        _codesByCodeSystemName = new();
    }

    public Elm.Library Library => _library;

    public string LibraryKey => _library.NameAndVersion!;

    public bool AllowUnresolvedExternals => _expressionBuilder.Settings.AllowUnresolvedExternals;

    public ExpressionBuilderContext NewExpressionBuilderContext(
        Elm.Element element) =>
        new ExpressionBuilderContext(
            _operatorBinding,
            _expressionBuilder,
            LibraryExpressionsBuilder.ContextParameter,
            _definitions,
            _localLibraryIdentifiers,
            this,
            element);

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

    public bool TryGetCode(CodeRef codeRef, [NotNullWhen(true)] out CqlCode? systemCode) =>
        _codesByName.TryGetValue(codeRef.name, out systemCode);
}