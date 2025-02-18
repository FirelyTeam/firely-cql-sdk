/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
 
using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Invocation.Extensions;

public static class InvocationToolkitExtensions
{
    public static InvocationToolkit AddAssemblyBinaries(
        this InvocationToolkit invocationToolkit,
        params AssemblyBinary[] assemblyBinary) =>
        invocationToolkit.AddAssemblyBinaries(assemblyBinary.AsEnumerable());
}
