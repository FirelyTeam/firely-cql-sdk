using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;

namespace CqlSdkPrototype.Invocation;

public class LibrarySetInvoker : IDisposable
{
    private readonly AssemblyLoadContext _alc;

    internal LibrarySetInvoker(LibrarySetInvokerBuilder librarySetInvokerBuilder, AssemblyLoadContext alc)
    {
        _alc = alc;
        LibraryInvokers =
            _alc.Assemblies
                .SelectMany(a => a.GetTypes())
                .SelectWhereNotNull(t =>
                {
                    LibraryInvoker.TryCreateFromType(librarySetInvokerBuilder, t, out var libraryInvoker);
                    return libraryInvoker;
                })
                .ToImmutableDictionary(o => o.LibraryVersionedIdentifier);
    }

    public void Dispose()
    {
        _alc.Unload();
    }

    public IReadOnlyDictionary<CqlVersionedLibraryIdentifier, LibraryInvoker> LibraryInvokers { get; }
}