/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Packager.Reporting;

/// <summary>
/// Represents the processing stages a library goes through.
/// </summary>
internal enum LibraryProcessingStage
{
    Cql,
    Elm,
    CSharp,
    DotNet,
    FhirResource
}
