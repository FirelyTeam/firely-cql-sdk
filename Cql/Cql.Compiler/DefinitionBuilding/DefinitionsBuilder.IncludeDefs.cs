using System;
using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler.DefinitionBuilding;

#pragma warning disable CS1591
internal partial class DefinitionsBuilder
{
    private void VisitIncludeDefs(
        LibraryContext libraryContext, 
        IncludeDef[] includesDefs)
    {
        foreach (var includeDef in includesDefs)
        {
            VisitIncludeDef(libraryContext, includeDef);
        }
    }

    private void VisitIncludeDef(
        LibraryContext libraryContext,
        IncludeDef includeDef)
    {
        var alias = !string.IsNullOrWhiteSpace(includeDef.localIdentifier)
            ? includeDef.localIdentifier!
            : includeDef.path!;

        var libNav = includeDef.NameAndVersion();
        if (libNav == null)
            throw new InvalidOperationException($"Include {includeDef.localId} does not have a well-formed name and version");

        libraryContext.LocalLibraryIdentifiers.Add(alias, libNav);
    }

}