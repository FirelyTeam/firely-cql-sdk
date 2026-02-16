/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;

namespace Hl7.Cql.CqlToElm.Toolkit;

/// <summary>
/// Callback invoked when a CQL library is loaded from a file.
/// </summary>
/// <param name="fileInfo">The file that was loaded.</param>
/// <param name="libraryIdentifier">The identifier of the loaded library.</param>
public delegate void LibraryLoadedCallback(FileInfo fileInfo, CqlVersionedLibraryIdentifier libraryIdentifier);
