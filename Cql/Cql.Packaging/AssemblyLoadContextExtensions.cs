/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
 
using System.Runtime.Loader;

namespace Hl7.Cql.Packaging;

internal static class AssemblyLoadContextExtensions
{
    public static Assembly LoadFromBytes(this AssemblyLoadContext assemblyLoadContext, byte[] assembly, byte[]? symbols = null)
    {
        using var assemblyStream = new MemoryStream(assembly);
        var symbolsStream = symbols is {Length:>0} ? new MemoryStream(symbols) : null;
        using var symbolsStreamDisposable = symbolsStream as IDisposable;
        return assemblyLoadContext.LoadFromStream(assemblyStream, symbolsStream);
    }
}
