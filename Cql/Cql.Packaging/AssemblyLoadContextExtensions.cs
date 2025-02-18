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