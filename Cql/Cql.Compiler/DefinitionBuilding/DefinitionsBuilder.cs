using System;
using System.Collections.Generic;
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

        ExpressionBuilder expressionBuilder = new ExpressionBuilder(operatorBinding, typeManager, library, logger);

        DefinitionDictionary<LambdaExpression> definitions = new();
        Dictionary<string, string> localLibraryIdentifiers = new();
        Dictionary<string, string> codeSystemUrls =
            library.codeSystems
                ?.ToDictionary(cs => cs.name, cs => cs.id)
            ?? new();
        Dictionary<string, CqlCode> codesByName = new();
        Dictionary<string, List<CqlCode>> codesByCodeSystemName = new();

        LibraryContext libraryContext = new(expressionBuilder, definitions, localLibraryIdentifiers, codeSystemUrls, codesByName, codesByCodeSystemName);
        VisitLibrary(libraryContext);
        return definitions;
    }

    private record struct LibraryContext
    {
        public LibraryContext(
            ExpressionBuilder expressionBuilder,
            DefinitionDictionary<LambdaExpression> definitions,
            Dictionary<string, string> localLibraryIdentifiers,
            Dictionary<string, string> codeSystemUrls,
            Dictionary<string, CqlCode> codesByName,
            Dictionary<string, List<CqlCode>> codesByCodeSystemName)
        {
            _expressionBuilder = expressionBuilder;
           Library = expressionBuilder.Library;
           _definitions = definitions;
           LocalLibraryIdentifiers = localLibraryIdentifiers;
           CodeSystemUrls = codeSystemUrls;
           CodesByName = codesByName;
           CodesByCodeSystemName = codesByCodeSystemName;
        }

        private readonly ExpressionBuilder _expressionBuilder;
        private readonly DefinitionDictionary<LambdaExpression> _definitions;

        public Library Library { get; }
        public string LibraryNameAndVersion => Library.NameAndVersion!;
        public Dictionary<string, string> LocalLibraryIdentifiers { get; }
        public Dictionary<string, string> CodeSystemUrls { get; }
        public Dictionary<string, CqlCode> CodesByName { get; }
        public Dictionary<string, List<CqlCode>> CodesByCodeSystemName { get; }
        public TypeManager TypeManager => _expressionBuilder.TypeManager;
        public IDictionary<string, Func<ParameterExpression[], LambdaExpression>> CustomImplementations => _expressionBuilder.CustomImplementations;
        public ExpressionBuilderSettings Settings => _expressionBuilder.Settings;
        public ExpressionBuilderContext NewExpressionBuilderContext() =>
            new(
                _expressionBuilder,
                Expression.Parameter(typeof(CqlContext), "context"),
                _definitions,
                LocalLibraryIdentifiers);

        public Expression TranslateExpression(Element op, ExpressionBuilderContext ctx) =>
            _expressionBuilder.TranslateExpression(op, ctx);

        public void AddDefinitionTag(string definition, Type[] signature, string name, params string[] values) => 
            _definitions.AddTag(LibraryNameAndVersion, definition, signature, name, values);

        public void AddDefinition(string definition, LambdaExpression expression) => 
            _definitions.Add(LibraryNameAndVersion, definition, expression);

        public void AddDefinition(string definition, Type[] signature, LambdaExpression expression) => 
            _definitions.Add(LibraryNameAndVersion, definition, signature, expression);

        public bool ContainsDefinition(string definition, Type[] signature) => 
            _definitions.ContainsKey(LibraryNameAndVersion, definition, signature);

        public bool ContainsDefinition(string definition) => 
            _definitions.ContainsKey(LibraryNameAndVersion, definition);
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
            foreach (var codeDef in codeDefs)
            {
                try
                {
                    VisitCodeDef(libraryContext, codeDef, foundCodeNameCodeSystemUrls);
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
                $"Exception while building expression definition '{elementName} ' in library '{libraryContext.LibraryNameAndVersion}' at location '{locator}'. See InnerException for more details.",
                innerException);
    }
}