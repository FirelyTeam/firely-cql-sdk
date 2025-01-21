/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
namespace Hl7.Cql.CodeGeneration.NET;

/// <summary>
/// Represents the format of the debug information emitted by the compiler.
/// </summary>
public enum AssemblyCompilerDebugInformationFormat
{
    /// <summary>
    /// No debug information is emitted in the assembly or as a separate PDB files.
    /// </summary>
    None = 0,

    /// <summary>
    /// This format represents the portable PDB format, which is designed to be cross-platform and efficient.
    /// A portable PDB will be generated alongside the DLL, which contains the debug information for the associated assembly.
    /// </summary>
    PortablePdb = 2,

    /// <summary>
    /// This format embeds the debugging information directly within the assembly, making it self-contained,
    /// thus no PDB file will be generated.
    /// </summary>
    Embedded = 3,
}