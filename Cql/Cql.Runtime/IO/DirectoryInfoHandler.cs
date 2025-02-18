/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
 
namespace Hl7.Cql.Runtime.IO;

/// <summary>
/// Represents a method that handles a <see cref="DirectoryInfo"/> object.
/// </summary>
/// <param name="directory">The directory to handle.</param>
public delegate void DirectoryInfoHandler(DirectoryInfo directory);
