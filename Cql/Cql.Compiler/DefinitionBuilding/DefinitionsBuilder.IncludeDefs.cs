using System;
using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler.Definitions;

#pragma warning disable CS1591
internal partial record DefinitionsBuilder
{
    private void Visit(IncludeDef[] libraryIncludesDefs)
    {
        foreach (var includeDef in libraryIncludesDefs)
        {
            Visit(includeDef);
        }
    }

    private void Visit(IncludeDef includeDef)
    {
        var alias = !string.IsNullOrWhiteSpace(includeDef.localIdentifier)
            ? includeDef.localIdentifier!
            : includeDef.path!;

        var libNav = includeDef.NameAndVersion();
        if (libNav == null)
            throw new InvalidOperationException($"Include {includeDef.localId} does not have a well-formed name and version");

        LocalLibraryIdentifiers.Add(alias, libNav);
    }

}