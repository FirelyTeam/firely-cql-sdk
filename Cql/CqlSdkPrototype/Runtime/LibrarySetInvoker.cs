using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Loader;
using CqlSdkPrototype.CqlToElm;
using CqlSdkPrototype.ElmToAssembly;
using CqlSdkPrototype.Internal;
using Hl7.Cql.Abstractions.Infrastructure;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.Runtime;

public partial class LibrarySetInvoker : IDisposable
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
}

partial class LibrarySetInvoker
{
    public static bool TryCreate(
        [NotNullWhen(true)] out LibrarySetInvoker? librarySetInvoker,
        CqlTranslator cqlTranslation,
        ElmCompiler elmCompilation,
        ILogger logger)
    {
        librarySetInvoker = null;
        logger.LogInformation("Creating LibrarySetInvoker");

        var alc = new AssemblyLoadContext("", true);
        foreach ((byte[] assembly, byte[]? symbols) in elmCompilation.GetAssemblyBinaries().Values)
        {
            alc.LoadFromBytes(assembly, symbols);
        }

        librarySetInvoker = new LibrarySetInvoker(alc, logger);
        return true;
    }
}