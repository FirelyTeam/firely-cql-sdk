/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

/// <summary>
/// The interface for the library expression builder context.
/// </summary>
internal interface ILibraryExpressionBuilderContext : IBuilderContext
{
    /// <summary>
    /// Gets the library associated with the expression builder context.
    /// </summary>
    Library Library { get; }

    /// <summary>
    /// Gets the dictionary of library definitions.
    /// Before the library is built, this dictionary contains the definitions from all the included libraries.
    /// After processing of the library, this dictionary also contains the definitions from the library itself.
    /// If the library was processed within the context of a library set,
    /// then this dictionary will be merged with the library set's dictionary.
    /// </summary>
    DefinitionDictionary<LambdaExpression> LibraryDefinitions { get; }

    /// <summary>
    /// Gets the key of the library, which is the name and version of the library.
    /// </summary>
    /// <seealso cref="Library.NameAndVersion"/>
    string LibraryKey { get; }

    /// <summary>
    /// Tries to get the codes by code system name.
    /// </summary>
    /// <param name="codeSystemName">The name of the code system.</param>
    /// <param name="codes">The list of CqlCode objects.</param>
    /// <returns>True if the codes are found, false otherwise.</returns>
    bool TryGetCodesByCodeSystemName(string codeSystemName, [NotNullWhen(true)] out List<CqlCode>? codes);

    /// <summary>
    /// Tries to get the code system name by code system reference.
    /// </summary>
    /// <param name="codeSystemRef">The code system reference.</param>
    /// <param name="url">The URL of the code system.</param>
    /// <returns>True if the code system name is found, false otherwise.</returns>
    bool TryGetCodeSystemName(CodeSystemRef codeSystemRef, [NotNullWhen(true)] out string? url);

    /// <summary>
    /// Tries to get the CqlCode object by code reference.
    /// </summary>
    /// <param name="codeRef">The code reference.</param>
    /// <param name="systemCode">The CqlCode object.</param>
    /// <returns>True if the CqlCode object is found, false otherwise.</returns>
    bool TryGetCode(CodeRef codeRef, [NotNullWhen(true)] out CqlCode? systemCode);

    /// <summary>
    /// Adds a code definition and its corresponding CqlCode object.
    /// </summary>
    /// <param name="codeDef">The code definition.</param>
    /// <param name="cqlCode">The CqlCode object.</param>
    void AddCode(CodeDef codeDef, CqlCode cqlCode);

    /// <summary>
    /// Adds an alias for the library name and version.
    /// </summary>
    /// <param name="alias">The alias.</param>
    /// <param name="libraryKey">The library key.</param>
    void AddAliasForNameAndVersion(string alias, string libraryKey);

    /// <summary>
    /// Gets the name and version of the library from the alias.
    /// References to definitions from included libraries are resolved using the alias.
    /// </summary>
    /// <param name="alias">The alias.</param>
    /// <param name="throwError">Indicates whether to throw an error if the alias is not found.</param>
    /// <returns>The name and version of the library.</returns>
    string? GetNameAndVersionFromAlias(string? alias, bool throwError = true);
}
