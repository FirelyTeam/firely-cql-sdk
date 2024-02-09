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

namespace Hl7.Cql.Compiler.DefinitionBuilding;

internal sealed partial class DefinitionsBuilder
{
    public static DefinitionsBuilder Instance { get; } = new();

    private DefinitionsBuilder()
    {
        // This class contains no state, so use it as a singleton
    }

    public DefinitionDictionary<LambdaExpression> BuildDefinitions(
        OperatorBinding operatorBinding,
        TypeManager typeManager,
        Library library,
        ILogger<ExpressionBuilder> logger)
    {
        library.NameAndVersion.ArgNotNull();
        LibraryContext libraryContext = new(operatorBinding, typeManager, library, logger);
        return libraryContext.BuildDefinitions();
    }

    private readonly record struct LibraryContext
    {
        public LibraryContext(
            OperatorBinding operatorBinding,
            TypeManager typeManager,
            Library library,
            ILogger<ExpressionBuilder> logger)
        {
            _expressionBuilder = new ExpressionBuilder(operatorBinding, typeManager, library, logger);
            Library = library;
        }

        public DefinitionDictionary<LambdaExpression> BuildDefinitions()
        {
            Instance.VisitLibrary(this);
            return _definitions;
        }

        private readonly ExpressionBuilder _expressionBuilder;
        private readonly Dictionary<string, string> _localLibraryIdentifiers = new();
        private readonly Dictionary<string, CqlCode> _codesByName = new();
        private readonly Dictionary<string, List<CqlCode>> _codesByCodeSystemName = new();
        private readonly DefinitionDictionary<LambdaExpression> _definitions = new();

        public Library Library { get; }

        public string LibraryKey => Library.NameAndVersion!;

        public bool AllowUnresolvedExternals => _expressionBuilder.Settings.AllowUnresolvedExternals;

        public ExpressionBuilderContext NewExpressionBuilderContext() =>
            new(
                _expressionBuilder,
                Expression.Parameter(typeof(CqlContext), "context"),
                _definitions,
                _localLibraryIdentifiers);

        public Expression TranslateExpression(Element op, ExpressionBuilderContext ctx) =>
            _expressionBuilder.TranslateExpression(op, ctx);

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

        public void AddCodeByName(string codeDefName, CqlCode cqlCode) => 
            _codesByName.Add(codeDefName, cqlCode);

        public bool TryGetCodeByCodeName(string codeName, [NotNullWhen(true)] out CqlCode? code) => 
            _codesByName.TryGetValue(codeName, out code);

        public bool TryGetCodesByCodeSystemName(string codeSystemName, [NotNullWhen(true)] out List<CqlCode>? codes) => 
            _codesByCodeSystemName.TryGetValue(codeSystemName, out codes);

        public List<CqlCode> GetOrCreateCodesByCodeSystemName(string codeSystemName)
        {
            if (!_codesByCodeSystemName.TryGetValue(codeSystemName!, out var codings))
            {
                codings = new List<CqlCode>();
                _codesByCodeSystemName.Add(codeSystemName!, codings);
                return codings;
            }

            return codings;
        }

        public bool TryGetCustomImplementationByExpressionKey(string expressionKey, [NotNullWhen(true)] out Func<ParameterExpression[], LambdaExpression>? factory) => 
            _expressionBuilder.CustomImplementations.TryGetValue(expressionKey, out factory);
    }

    private void VisitLibrary(
        LibraryContext libraryContext)
    {
        var library = libraryContext.Library;

        if (library.includes is { Length: > 0 } includeDefs)
        {
            foreach (var includeDef in includeDefs)
            {
                try
                {
                    VisitIncludeDef(libraryContext, includeDef);
                }
                catch (Exception e)
                {
                    throw ExceptionWhileBuilding(includeDef switch
                    {
                        {version:{} version} => $"{includeDef.path} {version}",
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
                    VisitValueSetDef(libraryContext, valueSetDef);
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
                    VisitCodeDef(libraryContext, codeDef, foundCodeNameCodeSystemUrls, codeSystemUrls);
                }
                catch (Exception e)
                {
                    throw ExceptionWhileBuilding(codeDef.name,  codeDef.locator, e);
                }
            }
        }

        if (library.codeSystems is { Length: > 0 } codeSystemDefs)
        {
            foreach (var codeSystemDef in codeSystemDefs)
            {
                try
                {
                    VisitCodeSystemDef(libraryContext, codeSystemDef);
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
                    VisitConceptDef(libraryContext, conceptDef);
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
                    VisitParameterDef(libraryContext, parameterDef);
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
                    VisitExpressionDef(libraryContext, expressionDef);
                }
                catch (Exception e)
                {
                    throw ExceptionWhileBuilding(expressionDef.name, expressionDef.locator, e);
                }
            }
        }

        Exception ExceptionWhileBuilding(string elementName, string locator, Exception innerException) =>
            throw new InvalidOperationException(
                $"Exception while building expression definition '{elementName} ' in library '{libraryContext.LibraryKey}' at location '{locator}'. See InnerException for more details.",
                innerException);
    }
}