/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Exceptions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Invocation.Toolkit.Errors;

/// <summary>
/// Why the toolkit does not accept the way an assembly declares a CQL library, as the library's
/// <see cref="CqlLibraryInfo.ReadError"/> reports it.
/// </summary>
/// <remarks>
/// The toolkit skips such a library, and logs this error, while it loads the assembly's other libraries. Each
/// implementation is a value that carries the details of one kind of error, and <see cref="ICqlError.GetMessage"/>
/// describes it. Two reads of the same assembly therefore give equal errors.
/// </remarks>
public interface ICqlLibraryInfoError : ICqlError
{
    /// <summary>
    /// Gets the full name of the assembly whose types declare the library, as
    /// <see cref="System.Reflection.AssemblyName.FullName"/> gives it; <see langword="null"/> when the types are in
    /// different assemblies.
    /// </summary>
    /// <remarks>
    /// <see cref="InvocationToolkit.ReadCqlAssemblyInfo"/> reads one assembly at a time, so it always sets this. Only
    /// <see cref="InvocationToolkit.CreateLibrarySetInvoker(string)"/>, which sees every assembly of the toolkit,
    /// finds a library declared in more than one assembly, and it logs that error.
    /// </remarks>
    string? AssemblyName { get; }

    /// <summary>
    /// Gets the library the error is about.
    /// </summary>
    CqlVersionedLibraryIdentifier LibraryIdentifier { get; }
}
