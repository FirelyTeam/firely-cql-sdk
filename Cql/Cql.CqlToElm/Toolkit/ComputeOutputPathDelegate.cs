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
/// Computes the output path for a file based on the output directory, library identifier, and file name.
/// </summary>
/// <param name="outputDirectory">The base output directory.</param>
/// <param name="libraryIdentifier">The identifier of the library being saved.</param>
/// <param name="fileName">The file name (without directory path).</param>
/// <returns>The full output path where the file should be saved.</returns>
public delegate string ComputeOutputPathDelegate(DirectoryInfo outputDirectory, CqlVersionedLibraryIdentifier libraryIdentifier, string fileName);
