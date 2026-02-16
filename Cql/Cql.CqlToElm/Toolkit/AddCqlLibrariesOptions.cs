/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.CqlToElm.Toolkit;

/// <summary>
/// Options for adding CQL libraries from a directory.
/// </summary>
public sealed class AddCqlLibrariesOptions
{
    /// <summary>
    /// Optional callback invoked after each library is loaded.
    /// </summary>
    public LibraryLoadedCallback? OnLibraryLoaded { get; init; }

    /// <summary>
    /// The enumeration options to use when searching for files.
    /// </summary>
    public EnumerationOptions? EnumerationOptions { get; init; }

    /// <summary>
    /// An optional predicate to filter the files.
    /// </summary>
    public Func<FileInfo, bool>? FilePredicate { get; init; }
}
