using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler.Definitions;

#pragma warning disable CS1591
internal record DefinitionsBuilderForLibrary
{
    public ExpressionBuilder ExpressionBuilder { get; }
    public Library Library { get; }
    public TypeManager TypeManager { get; }
    public Dictionary<string, string> LocalLibraryIdentifiers { get; } = new();
    public Dictionary<string, string> CodeSystemUrls { get; }
    public Dictionary<string, CqlCode> CodesByName { get; } = new();
    public Dictionary<string, List<CqlCode>> CodesByCodeSystemName { get; } = new();

    public DefinitionsBuilderForLibrary(ExpressionBuilder expressionBuilder)
    {
        ExpressionBuilder = expressionBuilder;
        Library = expressionBuilder.Library;
        TypeManager = expressionBuilder.TypeManager;
        CodeSystemUrls = Library.codeSystems
                             ?.ToDictionary(cs => cs.name, cs => cs.id)
                         ?? new();
    }

    public DefinitionDictionary<LambdaExpression> BuildDefinitions()
    {
        ExpressionBuilder.Library.NameAndVersion.NotNull(); // This checks that the library has a name and version
        DefinitionDictionary<LambdaExpression> definitions = new();
        AddToDefinitions(definitions);
        return definitions;
    }

    private void AddToDefinitions(DefinitionDictionary<LambdaExpression> definitions)
    {
        if (Library.includes is { Length: > 0 } includes)
            new DefinitionsBuilderForIncludeDefs(this, definitions, includes).AddToDefinitions(definitions);

        if (Library.valueSets is { Length: > 0 } valueSets)
            new DefinitionsBuilderForValueSetDefs(this, definitions, valueSets).AddToDefinitions(definitions);

        if (Library.codes is { Length: > 0 } codes)
            new DefinitionsBuilderForCodeDefs(this, definitions, codes).AddToDefinitions(definitions);

        if (Library.codeSystems is { Length: > 0 } codeSystems)
            new DefinitionsBuilderForCodeSystemDefs(this, definitions, codeSystems).AddToDefinitions(definitions);

        if (Library.concepts is { Length: > 0 } concepts)
            new DefinitionsBuilderForConceptDefs(this, definitions, concepts).AddToDefinitions(definitions);

        if (Library.parameters is { Length: > 0 } parameters)
            new DefinitionsBuilderForParameterDefs(this, definitions, parameters).AddToDefinitions(definitions);

        if (Library.statements is { Length: > 0 } statements)
            new DefinitionsBuilderForExpressionDefs(this, definitions, statements).AddToDefinitions(definitions);
    }
}