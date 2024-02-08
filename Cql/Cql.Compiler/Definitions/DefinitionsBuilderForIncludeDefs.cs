using System;
using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler.Definitions;

#pragma warning disable CS1591
internal record DefinitionsBuilderForIncludeDefs(
    DefinitionsBuilderForLibrary OuterLibraryBuilder, 
    DefinitionDictionary<LambdaExpression> Definitions, 
    IncludeDef[] LibraryIncludesDefs)
{
    public void AddToDefinitions(DefinitionDictionary<LambdaExpression> definitions)
    {
        foreach (var includeDef in LibraryIncludesDefs)
        {
            var alias = !string.IsNullOrWhiteSpace(includeDef.localIdentifier)
                ? includeDef.localIdentifier!
                : includeDef.path!;

            var libNav = includeDef.NameAndVersion();
            if (libNav == null)
                throw new InvalidOperationException($"Include {includeDef.localId} does not have a well-formed name and version");

            OuterLibraryBuilder.LocalLibraryIdentifiers.Add(alias, libNav);
        }
    }
}