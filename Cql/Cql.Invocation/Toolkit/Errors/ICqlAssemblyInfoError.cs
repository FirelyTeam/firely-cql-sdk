/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Exceptions;

namespace Hl7.Cql.Invocation.Toolkit.Errors;

/// <summary>
/// Why <see cref="InvocationToolkit.ReadCqlAssemblyInfo"/> could not read an assembly, or found that the toolkit
/// cannot load it, as its <see cref="CqlAssemblyInfo.ReadError"/> reports it.
/// </summary>
/// <remarks>
/// The toolkit cannot load such an assembly either. Each implementation is a value that carries the details of one
/// kind of error, and <see cref="ICqlError.GetMessage"/> describes it.
/// </remarks>
public interface ICqlAssemblyInfoError : ICqlError
{
    /// <summary>
    /// Gets the full name of the assembly, as <see cref="System.Reflection.AssemblyName.FullName"/> gives it, when the
    /// read got far enough to learn it; otherwise, <see langword="null"/>.
    /// </summary>
    string? AssemblyName { get; }
}
