using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;
using CqlSdkPrototype.Runtime.Invokers;

namespace CqlSdkPrototype.Runtime;

public class RuntimeScope : IDisposable
{
    private readonly AssemblyLoadContext _alc;

    internal RuntimeScope(RuntimeApi runtimeApi, AssemblyLoadContext alc)
    {
        _alc = alc;
        Libraries =
            _alc.Assemblies
                .SelectMany(a => a.GetTypes())
                .SelectWhereNotNull(t =>
                {
                    LibraryInvoker.TryCreateFromType(runtimeApi, t, out var libraryInvoker);
                    return libraryInvoker;
                })
                .ToImmutableDictionary(o => o.LibraryVersionedIdentifier);
    }

    public void Dispose()
    {
        _alc.Unload();
    }

    public IReadOnlyDictionary<CqlVersionedLibraryIdentifier, LibraryInvoker> Libraries { get; }
}