using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler.Definitions;

#pragma warning disable CS1591
internal partial record DefinitionsBuilder
{
    public ExpressionBuilder ExpressionBuilder { get; }
    public Library Library { get; }
    public TypeManager TypeManager { get; }
    public Dictionary<string, string> LocalLibraryIdentifiers { get; } = new();
    public Dictionary<string, string> CodeSystemUrls { get; }
    public Dictionary<string, CqlCode> CodesByName { get; } = new();
    public Dictionary<string, List<CqlCode>> CodesByCodeSystemName { get; } = new();

    public DefinitionsBuilder(ExpressionBuilder expressionBuilder)
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

        if (Library.includes is { Length: > 0 } includes)
            Visit(includes);

        if (Library.valueSets is { Length: > 0 } valueSets)
            Visit(definitions, valueSets);

        if (Library.codes is { Length: > 0 } codes)
            Visit(definitions, codes);

        if (Library.codeSystems is { Length: > 0 } codeSystems)
            Visit(definitions, codeSystems);

        if (Library.concepts is { Length: > 0 } concepts)
            Visit(definitions, concepts);

        if (Library.parameters is { Length: > 0 } parameters)
            Visit(definitions, parameters);

        if (Library.statements is { Length: > 0 } statements)
            Visit(definitions, statements);

        return definitions;
    }
}