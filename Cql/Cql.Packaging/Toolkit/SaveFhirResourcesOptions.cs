/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Text.Json;
using Hl7.Cql.Abstractions;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Runtime.IO;

namespace Hl7.Cql.Packaging.Toolkit;

/// <summary>
/// Delegate for computing the output path for a FHIR resource file.
/// </summary>
/// <param name="outputDirectory">The base output directory.</param>
/// <param name="libraryIdentifier">The identifier of the library being saved.</param>
/// <param name="fileName">The file name (without directory path).</param>
/// <returns>The full output path where the file should be saved.</returns>
public delegate string ComputeFhirOutputPathDelegate(DirectoryInfo outputDirectory, CqlVersionedLibraryIdentifier libraryIdentifier, string fileName);

/// <summary>
/// Options for saving FHIR resources to a directory.
/// </summary>
public sealed class SaveFhirResourcesOptions
{
    /// <summary>
    /// Optional function to compute custom output paths.
    /// </summary>
    public ComputeFhirOutputPathDelegate? ComputeOutputPath { get; init; }

    /// <summary>
    /// If set to <c>true</c>, the JSON output will be indented.
    /// </summary>
    public bool WriteIndented { get; init; }

    /// <summary>
    /// Optional strategy for preparing the directory.
    /// </summary>
    public DirectoryInfoHandler? DirectoryPreparationStrategy { get; init; }

    /// <summary>
    /// Optional mutator for JSON serialization options.
    /// </summary>
    public Mutator<JsonSerializerOptions>? ConfigureJsonSerializerOptions { get; init; }
}
