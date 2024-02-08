using System.Collections.Generic;
using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler.Definitions;

#pragma warning disable CS1591
internal record DefinitionsBuilderForCodeDefs(
    DefinitionsBuilderForLibrary OuterLib,
    DefinitionDictionary<LambdaExpression> Definitions, 
    CodeDef[] LibraryCodeDefs)
{
    public void AddToDefinitions(DefinitionDictionary<LambdaExpression> definitions)
    {
        HashSet<(string codeName, string codeSystemUrl)> foundCodeNameCodeSystemUrls = new();
        foreach (var libraryCodeDef in LibraryCodeDefs)
        {
            new DefinitionsBuilderForCodeDef(this, libraryCodeDef, foundCodeNameCodeSystemUrls).Build();
        }
    }
}