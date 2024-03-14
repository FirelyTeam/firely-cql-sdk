using System.Collections.Generic;
using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

internal class LibrarySetExpressionBuilderContext : IBuilderContext
{
    private readonly LibrarySet _librarySet;
    private readonly DefinitionDictionary<LambdaExpression> _definitions;

    public LibrarySetExpressionBuilderContext(
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression> definitions)
    {
        _librarySet = librarySet;
        _definitions = definitions;
        OuterContext = null;
        ContextInfo = new BuilderContextInfo("LibrarySet", Name: _librarySet.Name!);
    }

    // Load a set of ELM libraries from a folder (in parallel) into a dictionary by name and version (maybe also alias?)
    // Topologically sort them by their included libraries


    public IBuilderContext? OuterContext { get; }

    public BuilderContextInfo ContextInfo { get; }

    public IReadOnlyCollection<Elm.Library> TopologicallySortedLibraries => _librarySet.TopologicallySortedLibraries;

    public void MergeDefinitions(DefinitionDictionary<LambdaExpression> definitions) => 
        _definitions.Merge(definitions);
        
}