using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler.Builders;

partial class LibraryExpressionBuilderContext
{
    #region Definitions

    public DefinitionDictionary<LambdaExpression> LibraryDefinitions { get; }

    private void AddLibraryDefinitionsFromIncludes()
    {
        if (LibrarySetContext != null)
        {
            foreach (var libraryDependency in LibrarySetContext.LibrarySet.GetLibraryDependencies(LibraryKey))
            {
                AddDefinitions(libraryDependency);
            }
        }

        void AddDefinitions(Library library)
        {
            string libraryName = library.NameAndVersion(true)!;
            if (!HasAliasForNameAndVersion(libraryName))
                throw new LibraryAliasUnresolvedError(library).ToException();

            if (LibrarySetContext!.LibrarySetDefinitions.TryGetDefinitionsForLibrary(
                    libraryName,
                    out IEnumerable<KeyValuePair<string, List<(Type[], LambdaExpression)>>>? definitions))
            {
                LibraryDefinitions.Merge(libraryName, definitions);
            }
        }
    }

    #endregion

    #region Library Identifiers by Alias

    private readonly Dictionary<string, string> _libraryIdentifiersByAlias;

    public void AddAliasForNameAndVersion(string alias, string libraryKey) =>
        _libraryIdentifiersByAlias.Add(alias, libraryKey);

    public string? GetNameAndVersionFromAlias(string? alias, bool throwError = true)
    {
        if (alias == null)
            return LibraryKey;
        if (throwError)
            return _libraryIdentifiersByAlias[alias];
        _libraryIdentifiersByAlias.TryGetValue(alias, out string? libraryKey);
        return libraryKey;
    }

    public bool HasAliasForNameAndVersion(string libraryKey) =>
        _libraryIdentifiersByAlias.ContainsValue(libraryKey);

    #endregion

    #region Codes By CodeSystemName

    private readonly Dictionary<string, List<CqlCode>> _codesByCodeSystemName;

    public bool TryGetCodesByCodeSystemName(string codeSystemName, [NotNullWhen(true)] out List<CqlCode>? codes) =>
        _codesByCodeSystemName.TryGetValue(codeSystemName, out codes);

    private List<CqlCode> GetOrCreateCodesByCodeSystemName(string codeSystemName)
    {
        if (_codesByCodeSystemName.TryGetValue(codeSystemName!, out var codings))
            return codings;

        codings = new List<CqlCode>();
        _codesByCodeSystemName.Add(codeSystemName!, codings);
        return codings;
    }
    public ILibrarySetExpressionBuilderContext? LibrarySetContext { get; }

    #endregion

    #region Codes By Name (cross library???)

    private readonly Dictionary<string, CqlCode> _codesByName;

    public bool TryGetCode(CodeRef codeRef, [NotNullWhen(true)] out CqlCode? systemCode) =>
        _codesByName.TryGetValue(codeRef.name, out systemCode);

    public void AddCode(CodeDef codeDef, CqlCode cqlCode)
    {
        _codesByName.Add(codeDef.name, cqlCode);

        var codeSystemName = codeDef.codeSystem!.name;
        var codings = GetOrCreateCodesByCodeSystemName(codeSystemName);
        codings.Add(cqlCode);
    }

    #endregion

    #region Url By CodeSystemRef (cross library)

    private readonly ByLibraryNameAndNameDictionary<string> _codeSystemIdsByCodeSystemRefs;

    private void AddCodeSystemRefsFromIncludes()
    {
        if (LibrarySetContext != null)
        {
            foreach (var libraryDependency in LibrarySetContext.LibrarySet.GetLibraryDependencies(LibraryKey))
            {
                AddCodeSystemRefs(libraryDependency);
            }
        }

        AddCodeSystemRefs(Library);

        void AddCodeSystemRefs(Library library)
        {
            if (library.codeSystems is { Length: > 0 } codeSystemDefs)
            {
                foreach (var codeSystemDef in codeSystemDefs)
                {
                    _codeSystemIdsByCodeSystemRefs.Add(new(library.NameAndVersion()!, codeSystemDef.name), codeSystemDef.id);
                }
            }
        }
    }

    public bool TryGetCodeSystemName(CodeSystemRef codeSystemRef, [NotNullWhen(true)] out string? url)
    {
        var libraryName = GetNameAndVersionFromAlias(codeSystemRef.libraryName);
        return _codeSystemIdsByCodeSystemRefs.TryGetValue(new(libraryName, codeSystemRef.name), out url);
    }

    #endregion

    private readonly record struct LibraryNameAndName(string? LibraryName, string Name);

    private class ByLibraryNameAndNameDictionary<TValue> : Dictionary<LibraryNameAndName, TValue>
    {
    }
}