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

internal partial class DefinitionsBuilder
{
    public static DefinitionsBuilder Instance { get; } = new();

    private DefinitionsBuilder()
    {
        // This class contains no state, so use it as a singleton
    }

    public DefinitionDictionary<LambdaExpression> BuildDefinitions(OperatorBinding operatorBinding,
        TypeManager typeManager,
        Library library,
        ILogger<ExpressionBuilder> logger)
    {
        library.NameAndVersion.NotNull();

        ExpressionBuilder expressionBuilder = new ExpressionBuilder(operatorBinding, typeManager, library, logger);
        DefinitionDictionary<LambdaExpression> definitions = new();
        Dictionary<string, string> localLibraryIdentifiers = new();
        Dictionary<string, string> codeSystemUrls =
            library.codeSystems
                ?.ToDictionary(cs => cs.name, cs => cs.id)
            ?? new();
        Dictionary<string, CqlCode> codesByName = new();
        Dictionary<string, List<CqlCode>> codesByCodeSystemName = new();
        LibraryContext libraryContext = new(library, expressionBuilder, definitions, localLibraryIdentifiers, codeSystemUrls, codesByName, codesByCodeSystemName);
        VisitLibrary(libraryContext);
        return definitions;
    }

    private record struct LibraryContext
    {
        public LibraryContext(Library Library,
            ExpressionBuilder ExpressionBuilder,
            DefinitionDictionary<LambdaExpression> Definitions,
            Dictionary<string, string> LocalLibraryIdentifiers,
            Dictionary<string, string> CodeSystemUrls,
            Dictionary<string, CqlCode> CodesByName,
            Dictionary<string, List<CqlCode>> CodesByCodeSystemName)
        {
            this.Library = Library;
            this._expressionBuilder = ExpressionBuilder;
            this.Definitions = Definitions;
            this.LocalLibraryIdentifiers = LocalLibraryIdentifiers;
            this.CodeSystemUrls = CodeSystemUrls;
            this.CodesByName = CodesByName;
            this.CodesByCodeSystemName = CodesByCodeSystemName;
        }

        public Library Library { get; }
        private readonly ExpressionBuilder _expressionBuilder; // Do not expose this
        public DefinitionDictionary<LambdaExpression> Definitions { get; }
        public Dictionary<string, string> LocalLibraryIdentifiers { get; }
        public Dictionary<string, string> CodeSystemUrls { get; }
        public Dictionary<string, CqlCode> CodesByName { get; }
        public Dictionary<string, List<CqlCode>> CodesByCodeSystemName { get; }

        public ExpressionBuilderContext NewExpressionBuilderContext() =>
            new(
                _expressionBuilder,
                Expression.Parameter(typeof(CqlContext), "context"),
                Definitions,
                LocalLibraryIdentifiers);

        public TypeManager TypeManager => _expressionBuilder.TypeManager;
        public IDictionary<string, Func<ParameterExpression[], LambdaExpression>> CustomImplementations => _expressionBuilder.CustomImplementations;
        public Expression TranslateExpression(Element op, ExpressionBuilderContext ctx) => _expressionBuilder.TranslateExpression(op, ctx);
        public ExpressionBuilderSettings Settings => _expressionBuilder.Settings;


    }

    private void VisitLibrary(
        LibraryContext libraryContext)
    {
        var library = libraryContext.Library;

        if (library.includes is { Length: > 0 } includesDefs)
            VisitIncludeDefs(libraryContext, includesDefs);

        if (library.valueSets is { Length: > 0 } valueSetDefs)
            VisitValueSetDefs(libraryContext, valueSetDefs);

        if (library.codes is { Length: > 0 } codeDefs)
            VisitCodeDefs(libraryContext, codeDefs);

        if (library.codeSystems is { Length: > 0 } codeSystemDefs)
            VisitCodeSystemDefs(libraryContext, codeSystemDefs);

        if (library.concepts is { Length: > 0 } conceptDefs)
            VisitConceptDefs(libraryContext, conceptDefs);

        if (library.parameters is { Length: > 0 } parameterDefs)
            VisitParameterDefs(libraryContext, parameterDefs);

        if (library.statements is { Length: > 0 } expressionDefs)
            VisitExpressionDefs(libraryContext, expressionDefs);
    }
}