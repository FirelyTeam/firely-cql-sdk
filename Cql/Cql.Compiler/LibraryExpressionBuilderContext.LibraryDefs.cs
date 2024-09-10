/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

partial class LibraryExpressionBuilderContext
{
    #region Definitions

    /// <summary>
    /// Gets the dictionary of library definitions.
    /// Before the library is built, this dictionary contains the definitions from all the included libraries.
    /// After processing of the library, this dictionary also contains the definitions from the library itself.
    /// If the library was processed within the context of a library set,
    /// then this dictionary will be merged with the library set's dictionary.
    /// </summary>
    public DefinitionDictionary<LambdaExpression> LibraryDefinitions { get; } = libraryDefinitions;

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
            string libraryName = library.NameAndVersion()!;
            if (!HasAliasForNameAndVersion(libraryName))
                throw new CouldNotResolveAliasFromTheLibraryNameAndVersionError(library).ToException();

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

    private readonly Dictionary<string, string> _libraryIdentifiersByAlias = new();

    /// <summary>
    /// Adds an alias for the library name and version.
    /// </summary>
    /// <param name="alias">The alias.</param>
    /// <param name="libraryKey">The library key.</param>
    public void AddAliasForNameAndVersion(string alias, string libraryKey) =>
        _libraryIdentifiersByAlias.Add(alias, libraryKey);

    /// <summary>
    /// Gets the name and version of the library from the alias.
    /// References to definitions from included libraries are resolved using the alias.
    /// </summary>
    /// <param name="alias">The alias.</param>
    /// <param name="throwError">Indicates whether to throw an error if the alias is not found.</param>
    /// <returns>The name and version of the library.</returns>
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

    private readonly Dictionary<string, List<CqlCode>> _codesByCodeSystemName = new();

    /// <summary>
    /// Tries to get the codes by code system name.
    /// </summary>
    /// <param name="codeSystemName">The name of the code system.</param>
    /// <param name="codes">The list of CqlCode objects.</param>
    /// <returns>True if the codes are found, false otherwise.</returns>
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
    public LibrarySetExpressionBuilderContext? LibrarySetContext { get; } = libsCtx;

    #endregion

    #region Codes By Name (cross library???)

    private readonly Dictionary<string, CqlCode> _codesByName = new();

    /// <summary>
    /// Tries to get the CqlCode object by code reference.
    /// </summary>
    /// <param name="codeRef">The code reference.</param>
    /// <param name="systemCode">The CqlCode object.</param>
    /// <returns>True if the CqlCode object is found, false otherwise.</returns>
    public bool TryGetCode(CodeRef codeRef, [NotNullWhen(true)] out CqlCode? systemCode) =>
        _codesByName.TryGetValue(codeRef.name, out systemCode);

    /// <summary>
    /// Adds a code definition and its corresponding CqlCode object.
    /// </summary>
    /// <param name="codeDef">The code definition.</param>
    /// <param name="cqlCode">The CqlCode object.</param>
    public void AddCode(CodeDef codeDef, CqlCode cqlCode)
    {
        _codesByName.Add(codeDef.name, cqlCode);

        var codeSystemName = codeDef.codeSystem!.name;
        var codings = GetOrCreateCodesByCodeSystemName(codeSystemName);
        codings.Add(cqlCode);
    }

    #endregion

    #region Url By CodeSystemRef (cross library)

    private readonly ByLibraryNameAndNameDictionary<string> _codeSystemIdsByCodeSystemRefs = new();

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
    }

    private void AddCodeSystemRefs(Library library)
    {
        if (library.codeSystems is { Length: > 0 } codeSystemDefs)
        {
            foreach (var codeSystemDef in codeSystemDefs)
            {
                var libraryNameAndName = new LibraryNameAndName(library.NameAndVersion()!, codeSystemDef.name);
                var newValue = codeSystemDef.id;
                if (!_codeSystemIdsByCodeSystemRefs.TryAdd(libraryNameAndName, newValue))
                {
                    var previousValue = _codeSystemIdsByCodeSystemRefs[libraryNameAndName];
                    if (previousValue != newValue)
                        throw this.NewExpressionBuildingException(
                            $"A code system '{libraryNameAndName}' was previously added with value '{previousValue}', and it cannot accept a different value '{newValue}'.");
                }
            }
        }
    }

    /// <summary>
    /// Tries to get the code system name by code system reference.
    /// </summary>
    /// <param name="codeSystemRef">The code system reference.</param>
    /// <param name="url">The URL of the code system.</param>
    /// <returns>True if the code system name is found, false otherwise.</returns>
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