/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;

namespace Hl7.Cql.Invocation.Toolkit.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="InvocationToolkit"/> class.
/// </summary>
public static class InvocationToolkitExtensions
{
    /// <summary>
    /// Adds the specified assembly binaries to the <see cref="InvocationToolkit"/>.
    /// </summary>
    /// <param name="invocationToolkit">The <see cref="InvocationToolkit"/> to add the assembly binaries to.</param>
    /// <param name="assemblyBinary">The assembly binaries to add.</param>
    /// <returns>The <see cref="InvocationToolkit"/> with the added assembly binaries.</returns>
    public static InvocationToolkit AddAssemblyBinaries(
        this InvocationToolkit invocationToolkit,
        params AssemblyBinary[] assemblyBinary) =>
        invocationToolkit.AddAssemblyBinaries(assemblyBinary.AsEnumerable());
}
