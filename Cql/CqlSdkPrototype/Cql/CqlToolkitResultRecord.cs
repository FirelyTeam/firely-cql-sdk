/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Cql;

/// <summary>
/// Represents a result record by the <see cref="CqlToolkit"/>.
/// </summary>
/// <param name="LibraryIdentifier">The library identifier of the input library.</param>
/// <param name="ElmLibrary">The result ELM library.</param>
public readonly record struct CqlToolkitResultRecord(
    CqlVersionedLibraryIdentifier LibraryIdentifier,
    ElmLibrary ElmLibrary);
