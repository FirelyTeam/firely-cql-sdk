using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;

namespace CqlSdkPrototype.Invocation;

public class LibrarySetInvoker : IDisposable
{
    private readonly AssemblyLoadContext _alc;

    internal LibrarySetInvoker(InvokerApi invokerApi, AssemblyLoadContext alc)
    {
        _alc = alc;
        Libraries =
            _alc.Assemblies
                .SelectMany(a => a.GetTypes())
                .SelectWhereNotNull(t =>
                {
                    LibraryInvoker.TryCreateFromType(invokerApi, t, out var libraryInvoker);
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