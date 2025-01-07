using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Loader;
using CqlSdkPrototype.ElmToAssembly;
using CqlSdkPrototype.Internal;
using Hl7.Cql.Runtime.Hosting;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.Runtime;

public class LibrarySetInvoker : IDisposable
{

    private readonly AssemblyLoadContext _asm;

    private LibrarySetInvoker(AssemblyLoadContext asm, ILogger? logger)
    {
        _asm = asm;
        LibraryInvokers =
            _asm.Assemblies
                .SelectMany(a => a.GetTypes())
                .SelectWhereNotNull(t =>
                {
                    LibraryInvoker.TryCreateFromType(t, out var libraryInvoker, logger);
                    return libraryInvoker;
                })
                .ToImmutableDictionary(o => o.LibraryVersionedIdentifier);
    }

    public void Dispose()
    {
        _asm.Unload();
    }

    public IReadOnlyDictionary<CqlVersionedLibraryIdentifier, LibraryInvoker> LibraryInvokers { get; }

    public static bool TryCreate(
        [NotNullWhen(true)] out LibrarySetInvoker? librarySetInvoker,
        ElmApi elmCompilation)
    {
        librarySetInvoker = null;
        var logger = elmCompilation.Options.ServiceProvider.GetLogger<LibrarySetInvoker>();
        logger.LogInformation("Creating LibrarySetInvoker");

        var alc = new AssemblyLoadContext("", true);
        foreach ((byte[] assembly, byte[]? symbols) in elmCompilation.GetAssemblyBinaries().Values)
            alc.LoadFromBytes(assembly, symbols);

        librarySetInvoker = new LibrarySetInvoker(alc, logger);
        return true;
    }
}